using BackRestaurante.Domain.Entities;
using BackRestaurante.Domain.Interfaces;
using BackRestaurante.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackRestaurante.Infra.Data.Repository
{
    public class PratoRepository : IRepositoryPrato
    {
        private DataContext _context;

        public PratoRepository(DataContext context)
        {
            _context = context;
        }
        public void Insert(Prato prato)
        {
            _context.Pratos.Add(prato);
            _context.SaveChanges();
        }

        public void Delete(Prato prato)
        {
            _context.Pratos.Remove(prato);
            _context.SaveChanges();
        }

        public IEnumerable<Prato> GetAll()
        {
            return _context.Pratos.ToList();
        }

        public Prato GetOne(int id)
        {
            return _context.Pratos.Find(id);
        }

        public void Update(int id, Prato prato)
        {
            _context.Entry(prato).State = EntityState.Modified;

            _context.SaveChanges();
        }
    }
}
