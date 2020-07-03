using DesignPatterns.Creational.AbstractFactory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class CorreioDeliveryFactory : DeliveryFactory
    {
        public override DeliveryMethod CriarDelivery()
        {
            return new DeliveryCorreio();
        }

        public override Produto CriarProduto(string nome, double valor)
        {
            return new ProdutoMedio(nome, valor);
        }
    }
}
