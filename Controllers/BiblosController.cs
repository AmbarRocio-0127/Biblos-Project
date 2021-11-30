using APIBiblos.Models;
using APIBiblos.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIBiblos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiblosController : ControllerBase
    {
        private readonly IBiblosRepository _biblosRepository;

        public BiblosController(IBiblosRepository biblosRepository)
        {
            _biblosRepository = biblosRepository;

        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _biblosRepository.GetAll());

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            

            if (id > 0)
            {
                 IEnumerable<Libros>listBook = await _biblosRepository.GetAll();
                if (listBook.Count() < 1)
                {
                    return NoContent();
                }
            }
            
            return Ok(await _biblosRepository.GetById(id));
        }


        [HttpPost]
        public async Task<bool> Post(Libros book)
        {
            var fecha = book.Fecha?.Date;
            DateTime DateObject = Convert.ToDateTime(fecha);
            book.Fecha = DateObject.Date;

            return await _biblosRepository.Post(book);
        }


        [HttpPut]
        public async Task<bool> Put(Libros book)
        {
            return await (_biblosRepository.Update(book));

        }


        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _biblosRepository.Delete(id);
        }
    }
}
