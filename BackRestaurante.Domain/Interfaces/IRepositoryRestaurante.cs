using BackRestaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackRestaurante.Domain.Interfaces
{
    public interface IRepositoryRestaurante
    {
        void Insert(Restaurante restaurante);
        void Update(int id, Restaurante restaurante);
        void Delete(Restaurante restaurante);
        Restaurante GetOne(int id);
        IEnumerable<Restaurante> GetAll();
    }
}
