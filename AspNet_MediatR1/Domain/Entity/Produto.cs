using System;

namespace AspNet_MediatR1.Domain.Entity
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
