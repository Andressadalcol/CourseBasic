using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseBasic
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome; 
            double quarto;
            int preco;


            Console.WriteLine("Qual seu nome completo:");
            nome = Console.ReadLine();
            Console.WriteLine(nome);

            Console.WriteLine("Quantos quartos tem na sua casa:");
            quarto = double.Parse(Console.ReadLine());
            Console.WriteLine(quarto);
            


            Console.WriteLine("Entre com o preço de um produto:");
            preco = int.Parse(Console.ReadLine());
            Console.WriteLine(preco);
            Console.ReadLine();
            
            
            
            
            
            
            
            
            
        




        }
    }
}
