using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory.Model
{
    public class Produto
    {
        public string Nome { get; set; }
        public Tamanho Tamanho { get; set; }
        public double Valor { get; set; }

        protected Produto(string nome, Tamanho tamanho, double valor)
        {
            this.Nome = nome;
            this.Tamanho = Tamanho;
            this.Valor = valor;
        }
    }
}
