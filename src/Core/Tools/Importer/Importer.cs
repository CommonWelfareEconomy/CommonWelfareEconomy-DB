using GwoDb.Infrastructure;
using GwoDb.Tools.Importer;

namespace GwoDb.Tools.Import
{
    public class Importer : IRegisterAsInstancePerLifetime
    {
        private readonly GetOldDbAsModel _getOldDbAsModel;
        private readonly OrganisationRepository _organisationRepository;

        public Importer(GetOldDbAsModel getOldDbAsModel, 
                        OrganisationRepository organisationRepository)
        {
            _getOldDbAsModel = getOldDbAsModel;
            _organisationRepository = organisationRepository;
        }

        public ImporterResult Run()
        {
            var getOldDbAsModelResult = _getOldDbAsModel.Run();
            _organisationRepository.Create(getOldDbAsModelResult.Organisations);
            _organisationRepository.Session.Clear();

            return new ImporterResult { ImportedCompaniesCount = getOldDbAsModelResult.Organisations.Count};
        }
    }
}
