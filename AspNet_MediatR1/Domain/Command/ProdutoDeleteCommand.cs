using MediatR;
using System;

namespace AspNet_MediatR1.Domain.Command
{
    public class ProdutoDeleteCommand : IRequest<string>
    {
        public Guid Id { get; set; }
    }
}
