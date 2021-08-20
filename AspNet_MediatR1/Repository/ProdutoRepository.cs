using AspNet_MediatR1.Controllers;
using AspNet_MediatR1.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_MediatR1.Repository
{
    public class ProdutoRepository : IRepository<Produto>
    {
        private readonly Dictionary<Guid, Produto> produtos = new Dictionary<Guid, Produto>();

        public Dictionary<Guid, Produto> GetProdutos()
        {
            var produto1Guid = Guid.NewGuid();
            var produto2Guid = Guid.NewGuid();
            var produto3Guid = Guid.NewGuid();

            produtos.Add(produto1Guid, new Produto { Id = produto1Guid, Nome = "Caneta", Preco = 3.45m });
            produtos.Add(produto2Guid, new Produto { Id = produto2Guid, Nome = "Caderno", Preco = 7.65m });
            produtos.Add(produto3Guid, new Produto { Id = produto3Guid, Nome = "Borracha", Preco = 1.20m });
            return produtos;
        }
        public ProdutoRepository()
        {
            produtos = GetProdutos();
        }

        public async Task<IEnumerable<Produto>> GetAll()
        {
            return await Task.Run(() => produtos.Values.ToList());
        }

        public async Task<Produto> Get(Guid id)
        {
            return await Task.Run(() => produtos.GetValueOrDefault(id));
        }

        public async Task Add(Produto produto)
        {
             await Task.Run(() => produtos.Add(produto.Id, produto));
        }

        public async Task Edit(Produto produto)
        {
            await Task.Run(() =>
            {
                produtos.Remove(produto.Id);
                produtos.Add(produto.Id, produto);
            });
        }

        public async Task Delete(Guid id)
        {
            await Task.Run(() => produtos.Remove(id));
        }
    }
}
