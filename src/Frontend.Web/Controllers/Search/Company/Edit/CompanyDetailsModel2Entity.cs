using GwoDb;
using GwoDb.Infrastructure;

public class CompanyDetailsModel2Entity : IRegisterAsInstancePerLifetime
{
    private readonly CompanyRepository _companyRepository;

    public CompanyDetailsModel2Entity(CompanyRepository companyRepository)
    {
        _companyRepository = companyRepository;
    }

    public Company Run(CompanyDetailsModel companyDetailsModel, int companyId)
    {
        var company = _companyRepository.GetById(companyId);
        company.Name = companyDetailsModel.CompanyName;
        company.Industry = companyDetailsModel.Industry;
        company.Size = companyDetailsModel.Size;
        company.Url = companyDetailsModel.Url;
        company.Location = companyDetailsModel.Location;
        company.ZipCode = companyDetailsModel.ZipCode;
        company.Email = companyDetailsModel.Email;
        company.WelfareBalanceFor2012 = companyDetailsModel.WelfareBalanceFor2012;

        return company;
    }
}
