using AutoMapper;
using NUnit.Framework;

namespace GwoDb.Tests
{
    public class Company_model_mapping : BaseTest
    {
        [Test]
        public void Mapping_should_be_valid()
        {
            SupporterCompanyModel2Entity.Run(new SupporterCompanyModel());
            Mapper.AssertConfigurationIsValid();            
        }
    }
}
