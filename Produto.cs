using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Estoque
{

    class produto
    {
        // declarando variaveis nome, preço e a quantidade
        private string _nome;
        public double Preco;
        public int Quantidade;

        // construtor do usuario
        public produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        // Atualização no codigo que melhora na construtor do usuario
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1) { _nome = value; }
            }
        }
        // construtor do valor
        public double ValorTotalEstoque()
        {
            // claculo
            return Preco * Quantidade;
        }

        // construtor da qauntidade
        public void AdicionarProduto(int quantidade)
        {
            // claculo
            Quantidade += quantidade;
        }

        // construtor
        public void RemoverProduto(int quantidade)
        {
            // claculo
            Quantidade = Quantidade - quantidade;
        }

        // resoltado final
        public override string ToString()
        {
            return Nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
