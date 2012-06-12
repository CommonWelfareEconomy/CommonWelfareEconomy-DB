using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;

namespace GwoDb
{
    public class CsvExporter
    {
        public void Run(IEnumerable<Company> organisations, string filePath)
        {
            var conf = new CsvHelper.Configuration.CsvConfiguration();
            conf.UseInvariantCulture = true;

            var sb = new StringBuilder();
            using (var streamWriter = new StringWriter(sb))
            using (var writer = new CsvWriter(streamWriter, conf))
            {
                writer.WriteField("Name");
                writer.WriteField("Email");
                writer.WriteField("Location");
                writer.WriteField("Size");
                writer.WriteField("Industry");
                writer.WriteField("Url");
                writer.WriteField("Bilanz2011");
                writer.WriteField("Bilanz2012");
                writer.NextRecord();

                foreach (var orga in organisations)
                {
                    writer.WriteField(orga.Name);
                    writer.WriteField(orga.Email);
                    writer.WriteField(orga.Location);
                    writer.WriteField(orga.Size);
                    writer.WriteField(orga.Industry);
                    writer.WriteField(orga.Url);
                    writer.WriteField(orga.WelfareBalanceFor2011);
                    writer.WriteField(orga.WelfareBalanceFor2012);
                    writer.NextRecord();
                }
                File.WriteAllText(filePath, sb.ToString(), Encoding.Default);
            }
        }
    }
}
