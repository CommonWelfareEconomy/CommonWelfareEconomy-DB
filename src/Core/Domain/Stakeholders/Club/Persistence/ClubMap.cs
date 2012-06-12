using FluentNHibernate.Mapping;

namespace GwoDb
{
    public class ClubMap : ClassMap<Club>
    {
        public ClubMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.AreaOfWork);
            Map(x => x.Location);
            Map(x => x.Email);
            Map(x => x.Url);
            Map(x => x.DateCreated);
            Map(x => x.DateModified);
        }
    }
}
