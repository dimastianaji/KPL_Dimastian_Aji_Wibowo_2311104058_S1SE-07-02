using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Newtonsoft.Json;

namespace modul8_2311104058
{
    public class BankTransferConfig
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public Confirmation confirmation { get; set; }

        private const string configFile = "bank_transfer_config.json";

        public BankTransferConfig()
        {
            if (File.Exists(configFile))
            {
                string json = File.ReadAllText(configFile);
                var configData = JsonConvert.DeserializeObject<BankTransferConfigData>(json);

                this.lang = configData.lang;
                this.transfer = configData.transfer;
                this.methods = configData.methods;
                this.confirmation = configData.confirmation;
            }
            else
            {
                lang = "en";
                transfer = new Transfer
                {
                    threshold = 1000000,
                    low_fee = 2500,
                    high_fee = 5000
                };
                methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
                confirmation = new Confirmation { en = "yes", id = "ya" };

                var defaultData = new BankTransferConfigData
                {
                    lang = this.lang,
                    transfer = this.transfer,
                    methods = this.methods,
                    confirmation = this.confirmation
                };

                string json = JsonConvert.SerializeObject(defaultData, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(configFile, json);
            }
        }
    }
    public class BankTransferConfigData
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public Confirmation confirmation { get; set; }
    }

    public class Transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
    }

    public class Confirmation
    {
        public string en { get; set; }
        public string id { get; set; }
    }
}