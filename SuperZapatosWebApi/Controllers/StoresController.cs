using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperZapatosWebApi.Contexts;
using SuperZapatosWebApi.Entities;
using SuperZapatosWebApi.Models;
using SuperZapatosWebApi.Services;

namespace SuperZapatosWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {

        private readonly IRepositoryStores repositoryStores;

        public StoresController(IRepositoryStores repositoryStores)
        {

            this.repositoryStores = repositoryStores;
        }

        // GET: api/Stores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoreDTO>>> GetStores()
        {
            var stores = await repositoryStores.GetStoresAsync();

            if (stores == null)
            {
                return NotFound();
            }

            return Ok(stores);
        }

        // GET: api/Stores/5
        [HttpGet("{id}", Name = "ObtenerStore")]
        public async Task<ActionResult<StoreDTO>> GetStore(int id)
        {
            var store = await repositoryStores.GetStoreAsync(id);

            if (store == null)
            {
                return NotFound();
            }

            return Ok(store);
        }

        // PUT: api/Stores/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStore(int id, [FromBody] StoreCrUpDTO storeEd)
        {
            var store = await repositoryStores.PutStoreAsync(id, storeEd);
            if (store == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/Stores
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<StoreDTO>> PostStore([FromBody] StoreCrUpDTO storeCr)
        {
            var storeDTO =  await repositoryStores.PostStoreAsync(storeCr);
            return new CreatedAtRouteResult("ObtenerStore", new { id = storeDTO.Value.Id }, storeDTO);
        }
        
        // DELETE: api/Stores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StoreDTO>> DeleteStore(int id)
        {
            var store = await repositoryStores.DeleteStoreAsync(id);
            if (store == null)
            {
                return NotFound();
            }
            
            return Ok(store);
        }
        
    }
}
