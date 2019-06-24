using System;
using System.Collections.Generic;
using System.Text;
using BackRestaurante.Domain.Entities;

namespace BackRestaurante.Domain.Interfaces
{
    public interface IRepositoryPrato
    {


        void Insert(Prato prato);
        void Update(int id, Prato prato);
        Prato GetOne(int idPrato);
        IEnumerable<Prato> GetAll();
        void Delete(Prato prato);
    }
}
