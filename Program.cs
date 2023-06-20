using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> produtos = new List<string> { "pepsi","fanta" };

            Console.WriteLine("Bem-vindo ao conradito store");


            while (true)
            {

                Console.WriteLine("Digite 1 para cadastrar ou 2 para listar");
                string resposta = Console.ReadLine();
                produtos = produtos.ToLower();




                if (resposta == "1")
                {

                    Console.WriteLine("Digite o nome do produto:");
                    string produto = Console.ReadLine();
                    produtos.Add(produto);

                    if (produtos.Contains(produto))
                    {
                        Console.WriteLine("Esse item já existe na lista...");

                    }
                    else
                    {
                        produtos.Add(produto);
                        Console.WriteLine("Produto adicionado");
                    }


                }

               
                else
                {
                    string texto = "";
                    int contador = 0;

                    while (contador < produtos.Count)
                    {
                        string primeira_letra = texto.Substring(0, 1);//f
                        primeira_letra = primeira_letra.ToUpper();//F

                        string segunda_parte = texto.Substring(1, texto.Length) //anta
                        string palavra_completa = primeira_letra + segunda_parte;



                        texto += produtos[contador] + ", ";
                        contador++;



                    }

                    texto.ToUpper();

                    texto = texto.Substring(0, texto.Length - 2);


                    Console.WriteLine(texto);
                    //[0]=>PEPSI
                    //[1]=>FANTA
                    //

                }
            }
            Console.ReadKey();
        }
    }
}
    

