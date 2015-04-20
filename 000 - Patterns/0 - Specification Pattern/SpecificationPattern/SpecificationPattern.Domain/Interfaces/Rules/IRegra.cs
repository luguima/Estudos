using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Domain.Interfaces.Rules
{
    public interface IRegra<in TEntity>
    {
        string ErrorMessage { get; }
        bool Validate(TEntity entity);
    }
}
