using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Campo nome é obrigatorio");

            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Descrição é um Campo obrigatorio");

            if (Preco == 0)
                AdicionarCritica("Preço não imformado ou o Valor inserido não é valido");

        }


    }
}
