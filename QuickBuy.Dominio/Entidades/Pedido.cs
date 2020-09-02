using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public ICollection<ItemPedido> itensPedido { get; set; }


        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }



    }
}
