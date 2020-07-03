using DesignPatterns.Creational.AbstractFactory.Model;
using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class ProdutoCreator
    {
        public static Produto Criar(string nome, double valor, Tamanho tamanho)
        {
            switch (tamanho)
            {
                case Tamanho.Pequeno:
                    return new ProdutoPequeno(nome, valor);
                case Tamanho.Medio:
                    return new ProdutoPequeno(nome, valor);
                case Tamanho.Grande:
                    return new ProdutoPequeno(nome, valor);
                default:
                    throw new ApplicationException("Tamanho nao identificado");
            }
        }
    }
}
