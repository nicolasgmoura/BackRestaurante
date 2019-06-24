using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BackRestaurante.Domain.Entities
{
    public class Prato
    {
        #region PropriedadesEncapsuladas
        public int IdPrato { get; set; }
        public string NomePrato { get; set; }
        public double Preco { get; set; }

        public int IdRestaurante { get; set; }

        [ForeignKey("IdRestaurante")]
        public virtual Restaurante Restaurante { get; set; }
        #endregion


        #region ConstrutorPrato
        public Prato()
        {

        }

        public Prato(string nomePrato, double preco)
        {
            NomePrato = nomePrato;
            Preco = preco;
        }
        #endregion


        #region ValidacaoPrato
        public void validaPrato()
        {
            if (string.IsNullOrEmpty(NomePrato))
            {
                throw new System.Exception("Nome do prato é obrigatório");
            }
            if (NomePrato.Length > 100)
            {
                throw new System.Exception("Nome do prato no máximo 100 caracteres");
            }
            if (Preco < 0.01)
            {
                throw new System.Exception("Informe um preço válido");
            }
            if (IdRestaurante == 0)
            {
                throw new System.Exception("Informe o Restaurante que pertence o prato");
            }
        }

        #endregion

    }
}
