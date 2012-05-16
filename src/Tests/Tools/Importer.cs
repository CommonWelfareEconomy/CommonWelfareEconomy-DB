using System;
using GwoDb.Tools.Import;
using NUnit.Framework;

namespace GwoDb.Tests
{
    public class ImporterTests : BaseTest
    {
        [Test]
        public void Should_read_data()
        {
            var resultRows = Resolve<GetOldDbAsResultRows>().Run();
            var resultRowsAggregated = Resolve<GetOldDbAsAggregatedRows>().Run();
            var resultOrganisations = Resolve<GetOldDbAsModel>().Run();
            
            Console.WriteLine(resultRows.Count);
            Console.WriteLine(resultRowsAggregated.Count);
            Console.WriteLine(resultOrganisations.Organisations.Count);

            var csvExporter = new CsvExporter();
            csvExporter.Run(resultOrganisations.Organisations, "unternehmen.csv");

            foreach(var orga in resultOrganisations.Organisations)
            {
                Console.WriteLine(orga.Name  + " " + orga.Location);
            }

            Resolve<Importer>().Run();
        }
    }
}
