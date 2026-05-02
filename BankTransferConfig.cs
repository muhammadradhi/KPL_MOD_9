using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

namespace Modul9_103022400055
{
    internal class BankTransferConfig
    {
        public Config config;
        public const string filepath = @"bank_transfer_config.json";

        public BankTransferConfig()
        {
            try
            {
                ReadConfigFile();
            } catch
            {
                SetDefault();
                WriteConfigFile();
            }
        }

        public void ReadConfigFile()
        {
            string read = File.ReadAllText(filepath);
            config = JsonSerializer.Deserialize<Config>(read);
        }

        public void WriteConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string write = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filepath, write);
        }

        public void SetDefault()
        {
            config = new Config();
            config.lang = "en";
            Transfer transfer = new Transfer(25000000, 6500, 15000);
            config.transfer = transfer;
            List<string> files = new List<string>();
            files.Add("RTO (real-time)");
            files.Add("SKN");
            files.Add("RTGS");
            files.Add("BI FAST");

            config.methods = files;
            Confirmation confirmation = new Confirmation();
            confirmation.en = "yes";
            confirmation.id = "ya";
            config.confirmation = confirmation;

        }
    }
}
