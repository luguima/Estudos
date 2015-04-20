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
    public class UsuarioPossuiEmailValidoTest
    {
        [Fact]
        public void DeveRetornarFalseEmailSemArroba()
        {
            var usuario = new Usuario()
            {
                NomeCompleto = "Usuario Teste",
                Email = "asasasa.com.br"
            };

            var result = new UsuarioPossuiEmailValido().IsSatisfiedBy(usuario);

            Assert.False(result, "email com arroba");
        }

        [Fact]
        public void DeveRetornarTrueEmailComArroba()
        {
            var usuario = new Usuario()
            {
                NomeCompleto = "Usuario Teste",
                Email = "asasasa@hotmail.com.br"
            };

            var result = new UsuarioPossuiEmailValido().IsSatisfiedBy(usuario);

            Assert.True(result, "email sem arroba");
        }
    }
}
