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
    public class RestauranteRepository : IRepositoryRestaurante
    {
        private DataContext _context;

        public RestauranteRepository(DataContext context)
        {
            _context = context;
        }
        public void Insert(Restaurante restaurante)
        {
            _context.Restaurantes.Add(restaurante);
            _context.SaveChanges();
        }

        public void Delete(Restaurante restaurante)
        {
            _context.Restaurantes.Remove(restaurante);
            _context.SaveChanges();
        }

        public IEnumerable<Restaurante> GetAll()
        {
            return _context.Restaurantes.ToList();
        }

        public Restaurante GetOne(int id)
        {
            return _context.Restaurantes.Find(id);
        }

        public void Update(int id, Restaurante restaurante)
        {
            _context.Entry(restaurante).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
