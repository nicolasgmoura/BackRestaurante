using BackRestaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackRestaurante.Domain.Interfaces
{
    public interface IServiceRestaurante
    {
        void Insert(Restaurante restaurante);
        void Update(int id, Restaurante restaurante);
        Restaurante GetOne(int id);
        void Delete(int id);
        IEnumerable<Restaurante> GetAll();

    }
}
