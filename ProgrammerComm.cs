using ArdEepromProgrammer.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArdEepromProgrammer
{

    public class ProgrammerComm : SerialPort
    {
        public int BufferLen { get; }
        public int PageSize { get; }
        public int Pages { get; }
        public int MaxSize { get; }

        public ProgrammerComm(string PORT, int PageSize, int Pages) : base(PORT)
        {
            this.BaudRate = 9600;
            this.BufferLen = PageSize;
            this.PageSize = PageSize;
            this.Pages = Pages;
            this.MaxSize = PageSize * Pages;
        }



        /// <summary>
        /// Send the Device Settings to the Programmer
        /// </summary>
        /// <returns></returns>
        public string SetDeviceSettings()
        {
            this.WriteLine("SET:" + PageSize + ":" + Pages);
            return this.WaitForReturn();
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
        public void DumpMemory(ProgrammerDumpMode mode, Stream output, Action<int> onProgress)
        {
            this.WriteLine("DUMP:" + ModeToText(mode)); // Starts the Dump Process
                        
            this.CopyTo(output, BufferLen, (t) => {
                float total = t;
                float maxSize = this.MaxSize;
                float perc = (t / maxSize) * 100;
                                                             

                onProgress?.Invoke((int)perc);
            });
        }

        public ProgrammerVerifyResult VerifyMemory(Stream compareTo, Action<int> onProgress, bool onlyChecksum = true)
        {
            ProgrammerVerifyResult results = new ProgrammerVerifyResult();

            SHA256 sha = SHA256.Create();
            String tempFile = Path.GetTempFileName();
            using (Stream fs = File.Open(tempFile, FileMode.Create, FileAccess.ReadWrite))
            {
                // Dumps the EEPROM Memory
                this.DumpMemory(ProgrammerDumpMode.RAW, fs, onProgress);

                // Generates the CRC32 of the Compare and the EEPROM
                fs.Flush();
                fs.Seek(0, SeekOrigin.Begin);

                var eepromHash = sha.ComputeHash(fs);
                var compareHash = sha.ComputeHash(compareTo);

                // 
                results.EEPROM_HASH = HashToString(eepromHash);
                results.COMPARE_HASH = HashToString(compareHash);

                // -
                results.IsOkay = results.EEPROM_HASH == results.COMPARE_HASH;

                if(!onlyChecksum)
                {
                    fs.Seek(0, SeekOrigin.Begin);
                    compareTo.Seek(0, SeekOrigin.Begin);

                    fs.CompareTo(compareTo, sizeof(Int64), onProgress);
                }
            }

            return results;
        }

        private string HashToString(byte[] hash)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                builder.Append(hash[i].ToString("x2"));
            }
            return builder.ToString();
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
