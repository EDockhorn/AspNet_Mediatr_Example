using MediatR;
using System;

namespace AspNet_MediatR1.Notifications
{
    public class ProdutoUpdateNotification : INotification
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public bool IsConcluido { get; set; }
    }
}
