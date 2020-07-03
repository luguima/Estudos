using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory.Model
{
    public class ProdutoGrande:Produto
    {
        public ProdutoGrande(string nome, double valor)
            : base(nome, Tamanho.Medio, valor)
        {

        }
    }
}
