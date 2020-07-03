using DesignPatterns.Creational.AbstractFactory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Execucao
    {
        public static void Executar()
        {
            var prods = new List<Produto>
            {
                ProdutoCreator.Criar("Remedio", 150, Tamanho.Pequeno),
                ProdutoCreator.Criar("Celular", 1500, Tamanho.Medio),
                ProdutoCreator.Criar("Geladeira", 5000, Tamanho.Grande)
            };

            prods.ForEach(v =>
                        Console.WriteLine($"Entrega criada {v.Nome}, valor entrega: {Delivery.CriarDelivery(v).RealizarEntrega()}")
                        );
        }
    }
}
