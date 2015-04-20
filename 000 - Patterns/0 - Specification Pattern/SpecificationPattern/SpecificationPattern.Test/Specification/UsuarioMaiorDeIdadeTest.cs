using SpecificationPattern.Domain.Entities;
using SpecificationPattern.Domain.Specification.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SpecificationPattern.Test.Specification
{
    public class UsuarioMaiorDeIdadeTest
    {
        [Fact]
        public void DeveRetornarFalseParaUsuarioMenorDe18()
        {
            var user = new Usuario() {
                NomeCompleto = "Usuario Teste",
                DataNascimento = DateTime.Now.AddYears(-5)
            };
            
            var result = new UsuarioMaiorDeIdade().IsSatisfiedBy(user);

            Assert.False(result, "Usuario maior de Idade");
        }

        [Fact]
        public void DeveRetornarTrueParaUsuarioMaiorDe18() {
            var user = new Usuario() { 
                NomeCompleto = "Usuario Teste",
                DataNascimento = DateTime.Now.AddYears(-20)
            };

            var result = new UsuarioMaiorDeIdade().IsSatisfiedBy(user);

            Assert.True(result, "Usuario menor de Idade");
        }
    }
}
