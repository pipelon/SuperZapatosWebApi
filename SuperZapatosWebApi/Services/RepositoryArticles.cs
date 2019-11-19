using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperZapatosWebApi.Contexts;
using SuperZapatosWebApi.Entities;

namespace SuperZapatosWebApi.Services
{
    public class RepositoryArticles : IRepositoryArticles
    {
        private readonly ApplicationDbContext context;

        public RepositoryArticles(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Task<Article> GetArticles()
        {
            throw new NotImplementedException();
        }
    }
}
