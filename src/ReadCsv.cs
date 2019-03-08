using System;
using System.IO;
using CsvHelper;
using System.Linq;
using BibTeXLibrary;

namespace csvToBib.src
{
    public class ReadCsv
    {
        manipuleFile mf;
         public ReadCsv(string [] dir)
        {   
            string saida;
            if(dir.Length == 1 || string.IsNullOrWhiteSpace(dir[1])){
                saida = "saida.bib";
            } else{
                saida = dir[1];
            }
            mf = new manipuleFile(saida);
            using (var reader = new StreamReader(dir[0]))
            using (var csv = new CsvReader(reader))

            {   csv.Configuration.RegisterClassMap<MiscMap>();   
                var records = csv.GetRecords<Misc>();
                var recordsList = records.ToList();
                
                recordsList.ForEach(mapToBibEntry);
                
            } 
        }

      private void mapToBibEntry(Misc value)
        {
            var x = new BibEntry();
            
            x.Title = value.DocumentTitle;
            x.Key = value.Id;
            x.Year = value.Publication_Year;
            x.Type = "misc";
            x.Publisher = value.Publisher;
            x.Author = value.Authors;


            mf.Escrever(x.ToString());
        }
    }


    public class manipuleFile
    {
        private string arquivo;
        public manipuleFile(string arquivo)
        {
            this.arquivo = arquivo;
        }

        public void Escrever<T>(T conteudo)
        {
            using (StreamWriter sw = new StreamWriter(this.arquivo, true))
            {
                sw.WriteLine(conteudo);
                sw.Close();
            }
        }

        public string Ler()
        {
            string conteudo = string.Empty;
            if (File.Exists(this.arquivo))
            {
                using (StreamReader sr = new StreamReader(this.arquivo))
                {
                    conteudo = sr.ReadToEnd();
                    sr.Close();
                }
            }
            return conteudo;
        }
    }
}