
using CsvHelper.Configuration.Attributes;

namespace csvToBib.src
{
    public class IEEEfile
    {   

        public string Id { get; set; }



        [Name("DOI")]
        public string DOI { get; set; }
        [Name("Document Identifier")]
        public string DocumentIdentifier { get; set; }
        [Name("Reference Count")]
        public string ReferenceCount { get; set; }
        [Name("Article Citation Count")]
        public string ArticleCitationCount { get; set; }
        [Name("Mesh_Terms")]
        public string Mesh_Terms { get; set; }
        [Name("INSPEC Non-Controlled Terms")]
        public string INSPECNonControlledTerms { get; set; }
        [Name("INSPEC Controlled Terms")]
        public string INSPECControlledTerms { get; set; }
        [Name("IEEE Terms")]
        public string IEEETerms { get; set; }
        [Name("Author Keywords")]
        public string AuthorKeywords { get; set; }
        [Name("PDF Link")]
        public string PDFLink { get; set; }
        [Name("Funding Information")]
        public string FundingInformation { get; set; }
        [Name("ISBNs")]
        public string ISBNs { get; set; }
        [Name("ISSN")]
        public string ISSN { get; set; }
        [Name("Abstract")]
        public string Abstract { get; set; }
        [Name("End Page")]
        public string EndPage { get; set; }
        [Name("Start Page")]
        public string StartPage { get; set; }
        [Name("Issue")]
        public string Issue { get; set; }

        [Name("Volume")]
        public string Volume { get; set; }
        [Name("Date Added To Xplore")]
        public string DateToXplore { get; set; }

        [Name("Publication Title")]
        public string PublicationTitle { get; set; }

        [Name("Author Affiliations")]
        public string AuthorsAffiliations { get; set; }
        
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