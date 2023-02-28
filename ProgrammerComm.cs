using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdEepromProgrammer
{
    public class ProgrammerComm : SerialPort
    {
        public int PageSize { get; }
        public int Pages { get; }

        public ProgrammerComm(string PORT, int baudRate, int PageSize, int Pages) : base(PORT)
        {
            this.BaudRate = baudRate;
            this.PageSize = PageSize;
            this.Pages = Pages;
        }

        
        /// <summary>
        /// Gets the EEPROM Device ID
        /// </summary>
        /// <returns></returns>
        public string GetDeviceId()
        {
            this.WriteLine("GETID");
            string result = this.WaitForReturn();
            return result.Replace("DEVID:", "").Trim();
        }

        /// <summary>
        /// Dumps all the Memory Contents to the Stream
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="ouput"></param>
        public void DumpMemory(ProgrammerDumpMode mode, Stream output)
        {
            this.WriteLine("DUMP:" + ModeToText(mode)); // Starts the Dump Process
            this.WaitForReturn("START_DUMP");

            byte[] buffer = new byte[this.PageSize];

            while (this.Read(buffer, 0, this.PageSize) > 0)
            {
                output.Write(buffer, 0, buffer.Length);
            }
        }

        private string ModeToText(ProgrammerDumpMode mode)
        {
            if (mode == ProgrammerDumpMode.RAW) return "RAW";
            if (mode == ProgrammerDumpMode.HEX) return "HEX";

            return "RAW";
        }

        private string WaitForReturn(string expected = null)
        {
            String result = "";
            while (true)
            {
                result += this.ReadTo("\n");
                if (string.IsNullOrEmpty(expected)) break; // Se expected for NULO então sai depois de receber a primeira informação
                if (!string.IsNullOrEmpty(expected) && result.Contains(expected)) break; // Se resultado conter expected sai
            }

            return result;            
        }
    }
}
