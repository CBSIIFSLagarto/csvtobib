namespace csvToBib.src
{
    public class TypeReference
    {
        public int id { get; set; }
        public string chave { get; set; }
        public string typeBib { get; set; }

        public TypeReference(){
            id = 0;
            chave = "ieee";
            typeBib = "misc";
        }
    }
}