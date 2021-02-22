using System;
namespace csvToBib.src
{
    public class Reference : BibTeXLibrary.BibEntry
    {
        public Reference(int id) 
        {
            this.id = id;
               
        }
        public int id { get; set; }

        static TypeIEEERef misc = new TypeIEEERef(0, "", "misc");
        static TypeIEEERef inproceedings = new TypeIEEERef(1, "IEEE Conferences", "INPROCEEDINGS");
        TypeIEEERef article = new TypeIEEERef(2, "IBM Journals & Magazines", "ARTICLE");
        TypeIEEERef Article = new TypeIEEERef(2, "IEEE Early Access Articles", "ARTICLE");
        // TypeIEEERef INBOOK = new TypeIEEERef(1, "IEEE Early Access Articles", "INBOOK");
        
        
        
        public Reference(IEEEfile ieeeFile){
            var type = identifierType(ieeeFile);
            if(type.Equals(inproceedings)){
                base.Author = ieeeFile.Authors;
                base.Title = ieeeFile.DocumentTitle;
                base.Booktitle = ieeeFile.PublicationTitle;
                base.Type = type.typeBib;
                base.Year = ieeeFile.Publication_Year;
                base.Volume = ieeeFile.Volume;
                base.Pages = $"{ieeeFile.StartPage} - {ieeeFile.EndPage}";
                this["keywords"] = $"{ieeeFile.INSPECControlledTerms}{ieeeFile.INSPECNonControlledTerms}{ieeeFile.IEEETerms}";
                this["doi"] = ieeeFile.DOI;
                base.Key = this.id.ToString();
                
                Console.WriteLine("é inproceedings");
            }else if(type.Equals(article) || type.Equals(Article)){
                Console.WriteLine("é article");


                base.Author = ieeeFile.Authors;
                base.Journal = ieeeFile.PublicationTitle;
                base.Title = ieeeFile.DocumentTitle;
                base.Year = ieeeFile.Publication_Year;
                base.Volume = ieeeFile.Volume;
                base.Pages = $"{ieeeFile.StartPage} - {ieeeFile.EndPage}";

                base.Key = this.id.ToString();
                
            }else{
                Console.WriteLine("é misc");

                base.Type = type.typeBib;
                base.Title = ieeeFile.DocumentTitle;
                base.Year = ieeeFile.Publication_Year;
                base.Publisher = ieeeFile.Publisher;
                base.Author = ieeeFile.Authors;
                base.Key = this.id.ToString();
                
            }
            
        }
        private TypeIEEERef identifierType(IEEEfile ieeefile){
            switch (ieeefile.DocumentIdentifier)
            {
                case "IEEE Conferences":
                    return inproceedings;
                case "IBM Journals & Magazines":
                    return  article;
                case "IET Journals & Magazines":
                    return  article;
                case "IEEE Journals & Magazines":
                    return  article;
                case "OUP Journals & Magazines":
                    return  article;
                case "IEEE Early Access Articles":
                    return Article;
                default: return misc;
            }
        }
    }
}