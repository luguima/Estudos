using System;

namespace DesignPatterns.Creational.AbstractFactory.Model
{
    public class DeliveryCorreio : DeliveryMethod
    {
        public override double Entregar(Produto produto)
        {
            var valor = produto.Valor * 0.015;
            Console.WriteLine($"Entregando Por Correio: {produto.Nome}, valor entrega: {valor}");
            return valor;
        }
    }
}
