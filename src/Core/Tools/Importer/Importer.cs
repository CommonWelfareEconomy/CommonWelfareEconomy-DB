using GwoDb.Infrastructure;
using GwoDb.Infrastructure.Persistence;
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
        private readonly TruncateTable _truncateTable;

        public Importer(GetOldDbAsModel getOldDbAsModel, 
                        CompanyRepository companyRepository, 
                        PersonRepository personRepository, 
                        PoliticianRepository politicianRepository, 
                        ClubRepository clubRepository, 
                        TruncateTable truncateTable)
        {
            _getOldDbAsModel = getOldDbAsModel;
            _companyRepository = companyRepository;
            _personRepository = personRepository;
            _politicianRepository = politicianRepository;
            _clubRepository = clubRepository;
            _truncateTable = truncateTable;
        }

        public ImporterResult Run()
        {
            var getOldDbAsModelResult = _getOldDbAsModel.Run();

            _truncateTable.Run(new[] { "Company", "Person", "Club", "Politician" });
            _companyRepository.Create(getOldDbAsModelResult.Organisations);
            _personRepository.Create(getOldDbAsModelResult.Persons);
            _politicianRepository.Create(getOldDbAsModelResult.Politicians);
            _clubRepository.Create(getOldDbAsModelResult.Clubs);

            _companyRepository.Session.Flush();
            _companyRepository.Session.Clear();

            return new ImporterResult
                       {
                           ImportedCompaniesCount = getOldDbAsModelResult.Organisations.Count, 
                           ImportedPersons = getOldDbAsModelResult.Persons.Count,
                           ImportedPoliticians = getOldDbAsModelResult.Politicians.Count,
                           ImportedClubs = getOldDbAsModelResult.Clubs.Count
                       };
        }
    }
}
