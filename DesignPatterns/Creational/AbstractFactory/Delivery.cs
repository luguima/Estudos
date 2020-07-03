using DesignPatterns.Creational.AbstractFactory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Delivery
    {
        private readonly DeliveryMethod _delivery;
        private readonly Produto _produto;

        public Delivery(DeliveryFactory factory, Produto prod)
        {
            _delivery = factory.CriarDelivery();
            _produto = factory.CriarProduto(prod.Nome, prod.Valor);
        }

        public double RealizarEntrega()
        {
            return _delivery.Entregar(_produto);
        }

        public static Delivery CriarDelivery(Produto prod)
        {
            switch (prod.Tamanho)
            {
                case Tamanho.Pequeno:
                    return new Delivery(new MotoDeliveryFactory(), prod);
                case Tamanho.Medio:
                    return new Delivery(new CorreioDeliveryFactory(), prod);
                case Tamanho.Grande:
                    return new Delivery(new DistribuidoraDeliveryFactory(), prod);
                default:
                    throw new ApplicationException("Não foi possível identificar o veículo");
            }
        }
    }
}
