namespace csvToBib.src
{
    public class Reference : BibTeXLibrary.BibEntry
    {
        public int id { get; set; }
        
        


        public Reference(TypeReference typeR){
            Type = typeR.typeBib;
        }
    }
}