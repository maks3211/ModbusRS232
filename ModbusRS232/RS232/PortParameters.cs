using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ModbusRS232.RS232.Enums;

namespace ModbusRS232.RS232
{
    public class PortParameters
    {
        public int Speed { get; set; }
        public StopBits StopBits { get; set; }
        public int DataBits { get; set; }
        public Terminator Terminator { get; set; }
        public string MyTerminator { get; set; }
        public string PortName { get; set; }
        public FlowControl FlowControl { get; set; }
        public Parity Parity { get; set; }
        public double Timeout { get; set; }
        public DataType DataType { get; set; }
    }
}
