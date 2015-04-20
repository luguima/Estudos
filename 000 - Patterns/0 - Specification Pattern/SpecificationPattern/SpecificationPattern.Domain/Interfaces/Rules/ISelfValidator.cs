using SpecificationPattern.Domain.ValueObject;

namespace SpecificationPattern.Domain.Interfaces.Rules
{
    interface ISelfValidator
    {
        ValidationResult ValidationResult { get; }
        bool IsValid();
    }
}
