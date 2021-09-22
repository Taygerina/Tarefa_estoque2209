using System;
using System.Globalization;

namespace Estoque
{
    public class Program
    {
        static void Main(string[] args)
        {
            // interaçao com usuario
            Console.WriteLine("Entre com dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            // declarando classe de produtos
            produto p = new produto(nome, preco, quantidade);

            // interaçao com usuario
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            // resultado 
            Console.WriteLine("Dados do atualizados: " + p);

            // resultado
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            // resultado final
            Console.WriteLine("Dados do atualizados: " + p);

            Console.ReadKey();
        }
    }
}