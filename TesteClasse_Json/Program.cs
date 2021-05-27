using Newtonsoft.Json;
using System;

namespace TesteClasse_Json
{
    class Program
    {
        static void Main(string[] args)
        {
            //Questão 4
            var clsTeste = new ClsTeste()
            {
                Codigo = 1000,
                Descricao = "teste"
            };

            //Questão 5
            string output = JsonConvert.SerializeObject(clsTeste);
            Console.WriteLine(output);

            Console.ReadKey();            
        }
    }
}
