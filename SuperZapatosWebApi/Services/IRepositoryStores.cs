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
        Task<ActionResult<IEnumerable<StoreDTO>>> GetStoresAsync();

        Task<ActionResult<StoreDTO>> GetStoreAsync(int id);

        Task<ActionResult<StoreDTO>> PutStoreAsync(int id, StoreCrUpDTO storeEd);

        Task<ActionResult<StoreDTO>> PostStoreAsync(StoreCrUpDTO storeCr);

        Task<ActionResult<StoreDTO>> DeleteStoreAsync(int id);
    }
}
