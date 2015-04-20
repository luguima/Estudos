using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Domain.ValueObject
{
    public class ValidationResult
    {
        private readonly List<ValidationError> _errors = new List<ValidationError>();

        public bool IsValid { get { return _errors.Count == 0; } }

        public IEnumerable<ValidationError> Erros { get { return this._errors; } }

        public void AddError(ValidationError error)
        {
            _errors.Add(error);
        }
        public void RemoveError(ValidationError error)
        {
            if (_errors.Contains(error))
                _errors.Remove(error);
        }

        public void AddError(params ValidationResult[] resultadoValidacao)
        {
            if (resultadoValidacao == null)
                return;

            foreach (var validationResult in resultadoValidacao.Where(result => result != null))
                this._errors.AddRange(validationResult.Erros);
        }
    }
}
