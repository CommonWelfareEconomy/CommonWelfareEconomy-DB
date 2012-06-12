using FluentNHibernate.Mapping;

namespace GwoDb
{
    public class PoliticianMap : ClassMap<Politician>
    {
        public PoliticianMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Capacity);
            Map(x => x.Location);
            Map(x => x.Email);
            Map(x => x.Url);
            Map(x => x.DateCreated);
            Map(x => x.DateModified);            
        }
    }
}
