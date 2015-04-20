using SpecificationPattern.Domain.Entities;
using SpecificationPattern.Domain.Interfaces.Specification;
using System;

namespace SpecificationPattern.Domain.Specification.Users
{
    public class UsuarioMaiorDeIdade : ISpecification<Usuario>
    {
        public bool IsSatisfiedBy(Usuario entity)
        {
            return (DateTime.Now.Year - entity.DataNascimento.Year) > 18;
        }
    }
}
