using MediatR;
using System;

namespace AspNet_MediatR1.Notifications
{
    public class ProdutoCreateNotification : INotification
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
