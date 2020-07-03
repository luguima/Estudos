using DesignPatterns.Creational.AbstractFactory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class DistribuidoraDeliveryFactory : DeliveryFactory
    {
        public override DeliveryMethod CriarDelivery()
        {
            return new DeliveryDistribuidora();
        }

        public override Produto CriarProduto(string nome, double valor)
        {
            return new ProdutoGrande(nome, valor);
        }
    }
}
