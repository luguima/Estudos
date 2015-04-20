using SpecificationPattern.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Domain.Interfaces.Rules
{
    public interface IValidadorRegra<in TEntity>
    {
        ValidationResult Validar(TEntity entity);
    }
}
