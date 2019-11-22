using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperZapatosWebApi.Contexts;
using SuperZapatosWebApi.Entities;
using SuperZapatosWebApi.Models;

namespace SuperZapatosWebApi.Services
{
    public class RepositoryStores : IRepositoryStores
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public RepositoryStores(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<StoreDTO>> GetStoresAsync()
        {
            var stores = await context.Stores
                .Include(x => x.Articles)
                .ToListAsync();
            return mapper.Map<List<StoreDTO>>(stores);
        }

        public async Task<StoreDTO> GetStoreAsync(int id)
        {
            var store = await context.Stores.FindAsync(id);
            if (store == null)
            {
                return null;
            }
            return mapper.Map<StoreDTO>(store);

        }

        public async Task<StoreDTO> PostStoreAsync(StoreCrUpDTO storeCr)
        {
            var store = mapper.Map<Store>(storeCr);
            context.Stores.Add(store);
            await context.SaveChangesAsync();
            var storeDTO = mapper.Map<StoreDTO>(store);
            return storeDTO;

        }

        public async Task PutStoreAsync(int id, StoreCrUpDTO storeEd)
        {
            var store = mapper.Map<Store>(storeEd);
            store.Id = id;
            context.Entry(store).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task<bool> DeleteStoreAsync(int id)
        {
            var store = await context.Stores.FindAsync(id);
            if (store == null)
            {
                return false;
            }

            context.Stores.Remove(store);
            await context.SaveChangesAsync();
            return true;
        }

        private bool StoreExists(int id)
        {
            return context.Stores.Any(e => e.Id == id);
        }
    }
}
