using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Estoque
{

    public class produto
    {
        //Declaração das variaveis nome, preço e quantidade
        private string _nome;
        private double _preco;
        private int _quantidade;

        //Declaração do construtor
        public produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //contrutor padrao
        public produto()
        {

        }

        //contrutor personalizado
        public string GetNome()
        {
            return _nome;
        }

        //Criação de uma função para a variavel _nome
        public void SetNome(string nome)
        {
            _nome = nome;
        }

        //função com get para ler o preço
        public double GetPreco()
        {
            return _preco;
        }

        //função para ler a variavel _quantidade
        public int GetQuantidade()
        {
            return _quantidade;
        }

        //Função para calcular o valor total do estoque
        public double ValorTotalEstoque()
        {
            return _preco * _quantidade;
        }

        //Função para adicionar Produtos ao estoque
        public void AdicionarProduto(int qtd)
        {
            _quantidade += qtd;
        }

        //Função para remover produtos do estoque
        public void RemoverProduto(int qtd)
        {
            _quantidade = _quantidade - qtd;
        }

        //finalizão do resultado
        public override string ToString()
        {
            return _nome + ", R$ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidades, Total: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
