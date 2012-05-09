using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GwoDb.Tools;
using NUnit.Framework;

namespace GwoDb.Tests
{
    public class ImporterTests : BaseTest
    {

        [Test]
        public void Should_read_data()
        {
            Resolve<Importer>().Run();
        }
    }
}
