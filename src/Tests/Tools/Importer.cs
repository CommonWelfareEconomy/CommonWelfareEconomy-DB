using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GwoDb.Tools;
using GwoDb.Tools.Import;
using NUnit.Framework;

namespace GwoDb.Tests
{
    public class ImporterTests : BaseTest
    {
        [Test]
        public void Should_read_data()
        {
            var resultRows = Resolve<Importer>().Run();
            var resultRowsAggregated = Resolve<ImporterAggregatedRows>().Run();
            var resultOrganisations = Resolve<ImporterOrganisations>().Run();
            
            Console.WriteLine(resultRows.Count);
            Console.WriteLine(resultRowsAggregated.Count);
            Console.WriteLine(resultOrganisations.Count);

            var csvExporter = new CsvExporter();
            csvExporter.Run(resultOrganisations, "unternehmen.csv");

            foreach(var orga in resultOrganisations)
            {
                Console.WriteLine(orga.Name  + " " + orga.Location);
            }
        }
    }
}
