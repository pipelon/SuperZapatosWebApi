using Microsoft.AspNetCore.Mvc;
using SuperZapatosWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperZapatosWebApi.Services
{
    public interface IRepositoryStores
    {
        Task<IEnumerable<StoreDTO>> GetStoresAsync();

        Task<StoreDTO> GetStoreAsync(int id);

        Task PutStoreAsync(int id, StoreCrUpDTO storeEd);

        Task<StoreDTO> PostStoreAsync(StoreCrUpDTO storeCr);

        Task<bool> DeleteStoreAsync(int id);
    }
}
