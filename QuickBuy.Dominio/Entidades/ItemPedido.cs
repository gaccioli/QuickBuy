﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }


        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Referencia do Produto não localizada");

            if (Quantidade == 0)
                AdicionarCritica("Quantidade não pode ser 0");

        }

        }
}
