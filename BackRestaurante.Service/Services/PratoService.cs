using BackRestaurante.Domain.Entities;
using BackRestaurante.Domain.Interfaces;
using BackRestaurante.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackRestaurante.Service.Services
{
    public class PratoService : IServicePrato
{
        private IRepositoryPrato _repository;
        public PratoService(IRepositoryPrato repository)
        {
            _repository = repository;
        }
        public void Insert(Prato prato)
        {

            prato.validaPrato();

            _repository.Insert(prato);
        }

        public void Update(int id, Prato prato)
        {
            Prato model = _repository.GetOne(id);

            if (model == null)
                throw new Exception("Prato não encontrado");

            model.NomePrato = prato.NomePrato;
            model.Preco = prato.Preco;
            model.IdRestaurante = prato.IdRestaurante;
            model.validaPrato();

            _repository.Update(id, model);
        }

        public Prato GetOne(int id)
        {
            var model = _repository.GetOne(id);

            if (model == null)
                throw new Exception("Prato não encontrado");

            return model;
        }
        public IEnumerable<Prato> GetAll()
        {
            return _repository.GetAll();
        }

        public void Delete(int id)
        {
            var model = _repository.GetOne(id);
            if (model == null)
                throw new Exception("Prato não encontrado");

            _repository.Delete(model);
        }

    }
}
