﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        public virtual ICollection<ItemPedido> ItensPedido { get; set; }


        //Implementar as Regras de Negocio  dentro do Validate
        public override void Validate()
        {

            LimparMensagemValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Critica - Pedido não pode ficar sem itens");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Critica - CEP Não pode ser vazio");

            if (string.IsNullOrEmpty(NumeroEndereco))
                AdicionarCritica("Critica - O numero Não pode ser vazio");

        }

      

    }
}
