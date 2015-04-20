using SpecificationPattern.Domain.Interfaces.Rules;
using SpecificationPattern.Domain.Interfaces.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Domain.Rules
{
    public class Regra<TEntity> : IRegra<TEntity>
    {
        private readonly ISpecification<TEntity> _specificationRule;

        public string ErrorMessage { get; private set; }

        public Regra(ISpecification<TEntity> rule, string mensagemErro)
        {
            this._specificationRule = rule;
            this.ErrorMessage = mensagemErro;
        }

        public bool Validate(TEntity entity)
        {
            return this._specificationRule.IsSatisfiedBy(entity);
        }
    }
}
