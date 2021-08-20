using MediatR;
using System;

namespace AspNet_MediatR1.Notifications
{
    public class ProdutoDeleteNotification : INotification
    {
        public Guid Id { get; set; }
        public bool IsConcluido { get; set; }
    }
}
