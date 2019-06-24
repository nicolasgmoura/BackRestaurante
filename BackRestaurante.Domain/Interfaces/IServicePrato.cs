using BackRestaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackRestaurante.Domain.Interfaces
{
    public interface IServicePrato
    {
        void Insert(Prato prato);
        void Update(int id, Prato prato);
        Prato GetOne(int id);
        void Delete(int id);
        IEnumerable<Prato> GetAll();

    }
}
