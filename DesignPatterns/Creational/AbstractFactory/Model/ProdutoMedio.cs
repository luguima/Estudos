using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory.Model
{
    public class ProdutoMedio : Produto
    {
        public ProdutoMedio(string nome, double valor)
            : base (nome, Tamanho.Medio, valor)
        {

        }
    }
}
