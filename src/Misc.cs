
using CsvHelper.Configuration.Attributes;

namespace csvToBib.src
{
    public class Misc
    {
        [Name("DOI")]
        public string Id { get; set; }
        [Name("Publication_Year")]
        public string Publication_Year { get; set; }
        [Name("Publisher")]
        public string Publisher { get; set; }
        [Name("Document Title")]
        public string DocumentTitle { get; set; }
        [Name("Authors")]
        public string Authors { get; set; }
    }
}