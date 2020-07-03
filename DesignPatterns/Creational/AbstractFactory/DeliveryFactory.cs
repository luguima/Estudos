using DesignPatterns.Creational.AbstractFactory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class DeliveryFactory
    {
        public abstract DeliveryMethod CriarDelivery();
        public abstract Produto CriarProduto(string nome, double valor);
    }
}
