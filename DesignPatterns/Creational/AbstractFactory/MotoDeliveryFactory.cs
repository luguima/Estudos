using DesignPatterns.Creational.AbstractFactory.Model;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class MotoDeliveryFactory : DeliveryFactory
    {
        public override DeliveryMethod CriarDelivery()
        {
            return new DeliveryMoto();
        }

        public override Produto CriarProduto(string nome, double valor)
        {
            return new ProdutoPequeno(nome, valor);
        }
    }
}
