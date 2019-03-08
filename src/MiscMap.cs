using CsvHelper.Configuration;
namespace csvToBib.src
{
    public class MiscMap : ClassMap<Misc>
    {

        public MiscMap()
        {
            Map(m => m.Id).Name("DOI");
            Map(m => m.Publication_Year).Name("Publication_Year");
            Map(m => m.Publisher).Name("Publisher");
            Map(m => m.DocumentTitle).Name("Document Title");
            Map(m => m.Authors).Name("Authors");
            
        }
        
    }
}