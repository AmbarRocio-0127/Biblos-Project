using APIBiblos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBiblos.Repository
{
    public interface IBiblosRepository
    {
        Task<IEnumerable<Libros>> GetAll();
        Task<Libros> GetById(int book_id);
        Task<bool> Post(Libros book);
        Task<bool> Update(Libros book);
        Task<bool> Delete(int book_id);
    }
}
