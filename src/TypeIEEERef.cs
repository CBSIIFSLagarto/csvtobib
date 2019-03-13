namespace csvToBib.src
{
    public class TypeIEEERef
    {
        public TypeIEEERef()
        {
        }

        public TypeIEEERef(int id, string chave, string typeBib)
        {
            this.id = id;
            this.chave = chave;
            this.typeBib = typeBib;

        }
        public int id { get; set; }
        public string chave { get; set; }
        public string typeBib { get; set; }

        
    }
}