using GwoDb.Infrastructure;
using GwoDb.Tools.Importer;

namespace GwoDb.Tools.Import
{
    public class Importer : IRegisterAsInstancePerLifetime
    {
        private readonly GetOldDbAsModel _getOldDbAsModel;
        private readonly CompanyRepository _companyRepository;
        private readonly PersonRepository _personRepository;
        private readonly PoliticianRepository _politicianRepository;
        private readonly ClubRepository _clubRepository;

        public Importer(GetOldDbAsModel getOldDbAsModel, 
                        CompanyRepository companyRepository, 
                        PersonRepository personRepository, 
                        PoliticianRepository politicianRepository, 
                        ClubRepository clubRepository)
        {
            _getOldDbAsModel = getOldDbAsModel;
            _companyRepository = companyRepository;
            _personRepository = personRepository;
            _politicianRepository = politicianRepository;
            _clubRepository = clubRepository;
        }

        public ImporterResult Run()
        {
            var getOldDbAsModelResult = _getOldDbAsModel.Run();

            _companyRepository.Create(getOldDbAsModelResult.Organisations);
            _personRepository.Create(getOldDbAsModelResult.Persons);
            _politicianRepository.Create(getOldDbAsModelResult.Politicians);
            _clubRepository.Create(getOldDbAsModelResult.Clubs);

            _companyRepository.Session.Clear();

            return new ImporterResult { ImportedCompaniesCount = getOldDbAsModelResult.Organisations.Count};
        }
    }
}
