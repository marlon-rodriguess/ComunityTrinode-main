using Trinode.Application.UseCases.Generics.Interfaces;

namespace Trinode.Application.UseCases.Generics
{
    public class GenericRequest : IGenericRequest
    {
        public Guid Id { get; set; }
    }
}

