using BackRestaurante.Domain.Entities;
using BackRestaurante.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackRestaurante.Service.Services
{
    public class RestauranteService : IServiceRestaurante
    {
        private IRepositoryRestaurante _repository;
        public RestauranteService(IRepositoryRestaurante repository)
        {
            _repository = repository;
        }
        public void Insert(Restaurante restaurante)
        {

            restaurante.validacaoRestaurant();

            _repository.Insert(restaurante);
        }

        public void Update(int id, Restaurante restaurante)
        {
            Restaurante model = _repository.GetOne(id);

            if (model == null)
                throw new Exception("Restaurante não encontrado");

            model.NomeRestaurante = restaurante.NomeRestaurante;
            model.validacaoRestaurant();

            _repository.Update(id, model);
        }

        public Restaurante GetOne(int id)
        {
            var model = _repository.GetOne(id);

            if (model == null)
                throw new Exception("Restaurante não encontrado");

            return model;
        }
        public IEnumerable<Restaurante> GetAll()
        {
            return _repository.GetAll();
        }

        public void Delete(int id)
        {
            var model = _repository.GetOne(id);
            if (model == null)
                throw new Exception("Restaurante não encontrado");

            _repository.Delete(model);
        }
    }
}
