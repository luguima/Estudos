using System;

namespace DesignPatterns.Creational.AbstractFactory.Model
{
    public class DeliveryDistribuidora : DeliveryMethod
    {
        public override double Entregar(Produto produto)
        {
            var valor = produto.Valor * 0.05;
            Console.WriteLine($"Entregando Por Distribuidora: {produto.Nome}, valor entrega: {valor}");
            return valor;
        }
    }
}
