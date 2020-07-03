using System;

namespace DesignPatterns.Creational.AbstractFactory.Model
{
    public class DeliveryMoto : DeliveryMethod
    {
        public override double Entregar(Produto produto)
        {
            var valor = produto.Valor * 0.01;
            Console.WriteLine($"Entregando Por Motoboy: {produto.Nome}, valor entrega: {valor}");
            return valor;
        }
    }
}
