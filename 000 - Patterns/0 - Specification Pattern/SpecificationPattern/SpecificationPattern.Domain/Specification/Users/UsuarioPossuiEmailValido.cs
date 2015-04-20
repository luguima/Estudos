using SpecificationPattern.Domain.Entities;
using SpecificationPattern.Domain.Interfaces.Specification;
using SpecificationPattern.Domain.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Domain.Specification.Users
{
    public class UsuarioPossuiEmailValido : ISpecification<Usuario>
    {
        public bool IsSatisfiedBy(Usuario entity)
        {
            return ValidadorEmail.Validar(entity.Email);
        }
    }
}
