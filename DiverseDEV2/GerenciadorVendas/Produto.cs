using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVendas
{
    internal class Produto
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public float Valor { get; private set; }

        public void setCodigo(int codigo)
        {
            Codigo = codigo;
        }
        public void setNome(string nome)
        {
            Nome = nome;
        }
        public void setValor(float valor)
        {
            Valor = valor;
        }
    }
}
