using System;
using csvToBib.src;

namespace csvToBib
{
    class Program
    {
        static void Main(string[] args)
        {
             ReadCsv r = new ReadCsv(args);
        }
    }
}
