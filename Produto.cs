using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Atualizaçãoestoque
{

    class Produto
    {
        //declaração de variaveis do produto
        private string _nome;
        private double _preco;
        private int _quantidade;

        //construtor personalizado
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //utilizando do GET e SET
        public string GetNome()
        {
            return _nome;
        }

        public void SetName(string nome)
        {
            _nome = nome;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEStoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }

        // resoltado final

        public override string ToString()
        {
            return _nome + ", R$ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidades, Total: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
    


}
