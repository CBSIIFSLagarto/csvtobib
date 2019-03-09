using System;
using CsvHelper.Configuration;
namespace csvToBib.src
{
    public class IEEEMap : ClassMap<IEEEfile>
    {

        public IEEEMap()
        {   
            Map(m => m.DocumentTitle).Name("Document Title");
            Map(m => m.Authors).Name("Authors");
            Map(m => m.AuthorsAffiliations).Name("Author Affiliations");
            Map(m => m.PublicationTitle).Name("Publication Title");
            Map(m => m.DateToXplore).Name("Date Added To Xplore");
            Map(m => m.Publication_Year).Name("Publication_Year");
            Map(m => m.Volume).Name("Volume");
            Map(m => m.Issue).Name("Issue");
            Map(m => m.StartPage).Name("Start Page");
            Map(m => m.EndPage).Name("End Page");
            Map(m => m.Abstract).Name("Abstract");
            Map(m => m.ISSN).Name("ISSN");
            Map(m => m.ISBNs).Name("ISBNs");
            Map(m => m.DOI).Name("DOI");    
            Map(m => m.FundingInformation).Name("Funding Information");    
            Map(m => m.PDFLink).Name("PDF Link");    
            Map(m => m.AuthorKeywords).Name("Author Keywords");    
            Map(m => m.IEEETerms).Name("IEEE Terms");    
            Map(m => m.INSPECControlledTerms).Name("INSPEC Controlled Terms");    
            Map(m => m.INSPECNonControlledTerms).Name("INSPEC Non-Controlled Terms");    
            Map(m => m.Mesh_Terms).Name("Mesh_Terms");    
            Map(m => m.ArticleCitationCount).Name("Article Citation Count");    
            Map(m => m.ReferenceCount).Name("Reference Count");    
            Map(m => m.Publisher).Name("Publisher");
            Map(m => m.DocumentIdentifier).Name("Document Identifier");
            
            
            
        }
        
    }
}