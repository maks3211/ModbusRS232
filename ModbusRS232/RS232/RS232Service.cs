﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ModbusRS232.RS232.Enums;
using System.IO.Ports;

namespace ModbusRS232.RS232
{
    public class RS232Service : IRS232Service
    {
        private readonly SerialPort _serialPort = new SerialPort();
        private DataType dataType;
        private Stopwatch sw = new Stopwatch();

        public List<string> GetPortNames()
        {
            return SerialPort.GetPortNames().ToList();
        }

        public string HexToString(String input)
        {
            input = input.ToLower();
            byte[] bytes = new byte[input.Length / 2];
            for (int i = 0; i < input.Length; i += 2)
                bytes[i / 2] = Convert.ToByte(input.Substring(i, 2), 16);
            string str = "";
            new List<byte>(bytes).ForEach(b => str += (char)b);
            return str;
        }
        public string StringToHex(String input)
        {
            string hex = "0123456789abcdef ";
            string str = String.Concat(
                input
                    .Select(ch => (int)ch)
                    .SelectMany(ch => new List<int> { ch / 16, ch % 16, 16 /*spacja*/ })
                    .Select(ch => hex[ch])
            );
            if (str != "")
                str = str.Substring(0, str.Length - 1); // obcięcie ostatniej spacji
            return str;
            //input.Select(ch => )
        }
        public byte LRC(String input)
        {
            int LRC = 0;
            foreach (byte b in input)
                LRC = (LRC + b) & 0xFF;
            LRC = (((LRC ^ 0xFF) + 1) & 0xFF);
            return (byte)LRC;
        }

        public bool OpenPort(PortParameters portParameters)
        {
            dataType = portParameters.DataType;

            _serialPort.BaudRate = portParameters.Speed;
            _serialPort.StopBits = (System.IO.Ports.StopBits)portParameters.StopBits;
            _serialPort.DataBits = portParameters.DataBits;
            _serialPort.PortName = portParameters.PortName;
            _serialPort.Handshake = (Handshake)portParameters.FlowControl;
            _serialPort.Parity = (System.IO.Ports.Parity)portParameters.Parity;
            _serialPort.ReadTimeout = (int)(portParameters.Timeout * 100);
            _serialPort.WriteTimeout = (int)(portParameters.Timeout * 100);
            _serialPort.NewLine = portParameters.Terminator != Terminator.WLASNY
                ? TerminatorToAscii(portParameters.Terminator)
                : HexToString(portParameters.MyTerminator);

            try
            {
                _serialPort.Open();
                return _serialPort.IsOpen;
            }
            catch
            {
                _serialPort.Close();
                return false;
            }
        }

        public void ClosePort()
        {
            _serialPort.Close();
        }

        public void SendMessage(string message)
        {
            if (_serialPort.IsOpen)
            {
                string port = _serialPort.BaudRate + " " + _serialPort.StopBits + " " + _serialPort.DataBits + " " + _serialPort.Parity + " " + _serialPort.NewLine;
                _serialPort.WriteLine(port);
                _serialPort.WriteLine(message);
            }
        }

        public void SendPing()
        {
            sw.Restart();
            SendMessage("PING");
        }

        public string ReceiveMessage()
        {
            if (_serialPort.IsOpen)
            {
                try
                {
                    string message = "";
                    if (dataType == DataType.ASCII)
                        message = _serialPort.ReadLine();
                    else if (dataType == DataType.HEX)
                        message = StringToHex(_serialPort.ReadLine());

                    // check if ping
                    if (message.Equals("PING"))
                    {
                        SendMessage("PONG");
                        return null;
                    }
                    else if (message.Equals("PONG"))
                    {
                        sw.Stop();
                        return $"PING {sw.Elapsed.TotalMilliseconds}ms";
                    }

                    return $"[in] {message}";
                }
                catch
                {
                    return null;
                }
            }

            return null;
        }
    }
}
