using MediatR;
using System;

namespace AspNet_MediatR1.Domain.Command
{
    public class ProdutoCreateCommand : IRequest<string>
    {
        public Guid Id { get; private set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public ProdutoCreateCommand()
        {
            Id = Guid.NewGuid();
        }
    }

}
