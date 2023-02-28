using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ArdEepromProgrammer
{
    public class AppConfig
    {
        private static AppConfig _Default;

        static AppConfig()
        {
            if(!File.Exists(AppConfig._ConfigFile()))
            {
                Save();
            }


            _Default = new AppConfig();
            Load();
        }

        public static void Save()
        {
            string app = _ConfigFile();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(AppConfig));
            using (FileStream fw = File.Open(app, FileMode.Create))
            {
                xmlSerializer.Serialize(fw, Default);
            }
        }

        public static void Load()
        {
            string app = _ConfigFile();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(AppConfig));
            using (FileStream fw = File.Open(app, FileMode.Open))
            {
                _Default = (AppConfig)xmlSerializer.Deserialize(fw);
            }


            if (_Default == null) _Default = new AppConfig();
        }

        public static string _ConfigFile()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config.xml");
        }

        
        public string Port { get; set; }

        public int BaudRate { get; set; }

        public int Pages { get; set; }

        public int PageSize { get; set; }

        public static AppConfig Default
        {
            get
            {
                return _Default;
            }
        }
    }
}
