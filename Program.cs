using System;

namespace Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            Estabelecimento Guaiba = new Estabelecimento();
            Guaiba.Nome = "Guaiba";
            Guaiba.Estrelas = "4.5";
            Rank.Show();
            Console.WriteLine($"1* Lugar - {Guaiba.Nome}");

            //Console.WriteLine("Qual o nome do seu estabelecimento? ");
            //var Escolha = Console.ReadLine();

            Estabelecimento Escolha = new Estabelecimento();
            Console.WriteLine("Qual o nome do estabelecimento?");
            Escolha.Nome = Console.ReadLine();
            Console.WriteLine("Como você avaliado o estabelecimento?");
            Escolha.Estrelas = Console.ReadLine();

            Console.WriteLine(Escolha);
            /*int[] numeros = new int[] { };
         
            int valorProcurado = 16;
            bool valorExiste;

            valorExiste = numeros.Contains(valorProcurado);    

            if(valorExiste)
            {
                Console.WriteLine("Valor encontrado!");
            }
            else
            {
                Console.WriteLine("Valor não encontrado!");
            }    

          
            Console.ReadLine();*/
            
        }
    } 
   public class Estabelecimento
   {
    public string Nome;
    public string Estrelas;
   }
}

