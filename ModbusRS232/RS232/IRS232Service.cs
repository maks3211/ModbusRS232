using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ModbusRS232.RS232
{
    
        public interface IRS232Service
        {
            List<string> GetPortNames();

            bool OpenPort(PortParameters portParameters);

            void ClosePort();

            void SendMessage(string message);

            string StringToHex(string input);
            string HexToString(string input);

            string ReceiveMessage();

            void SendPing();
        }
    
}
