using AutoMapper;
using GwoDb;


public  static class SupporterCompanyModel2Entity 
{
    static SupporterCompanyModel2Entity()
    {
        CreateMap();
    }

    public static Company Run(SupporterCompanyModel model)
    {
        return Mapper.Map<SupporterCompanyModel, Company>(model);
    }

    private static void CreateMap()
    {
        Mapper.CreateMap<SupporterCompanyModel, Company>().
            ForMember(right => right.Name, opt => opt.MapFrom(left => left.CompanyName)).
            ForMember(right => right.Users , opt => opt.Ignore()).
            ForMember(right => right.WelfareBalanceFor2011, opt => opt.Ignore()).
            ForMember(right => right.DateCreated , opt => opt.Ignore()).
            ForMember(right => right.DateModified, opt => opt.Ignore()).
            ForMember(right => right.Id, opt => opt.Ignore());        
    }

}

