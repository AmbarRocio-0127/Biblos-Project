using APIBiblos.Context;
using APIBiblos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBiblos.Repository
{
    public class BiblosRepository : IBiblosRepository
    {
        private readonly AppDbContext _context;

        public BiblosRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> Delete(int book_id)
        {
            try
            {
                var book = await _context.libros.FirstAsync(x => x.Id == book_id);
                _context.Entry(book).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        public async Task<IEnumerable<Libros>> GetAll()
        {
            return await _context.libros.ToListAsync();
        }

        public async Task<Libros> GetById(int book_id)
        {
            return await _context.libros.FirstAsync(x => x.Id == book_id);
        }

        public async Task<bool> Post(Libros book)
        {
            try
            {
                _context.Entry(book).State = EntityState.Added;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                throw;
                
            }
        }

        public async Task<bool> Update(Libros book)
        {
            try
            {
                _context.Entry(book).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
