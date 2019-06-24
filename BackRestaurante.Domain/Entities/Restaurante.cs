using System.Collections.Generic;

namespace BackRestaurante.Domain.Entities
{
    public class Restaurante
    {
        #region PropriedadesRestaurante
        public int IdRestaurante { get; set; }
        public string NomeRestaurante { get; set; }

        public List<Prato> Prato { get; set; }

        #endregion

        #region ConstrutorRestaurante
        public Restaurante()
        {

        }

        public Restaurante(string nomeRestaurante)
        {
            NomeRestaurante = nomeRestaurante;
        }
        #endregion

        public void validacaoRestaurant()
        {
            if (string.IsNullOrEmpty(NomeRestaurante))
            {
                throw new System.Exception("Informe o nome do Restaurante");
            }
            if (NomeRestaurante.Length > 100)
            {
                throw new System.Exception("Nome do restaurante no máximo 100 caracteres");
            }
        }

    }
}