﻿using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string SobreNome { get; set; }
        public string Nome { get; set; }



        //nenhum ou muitos peidos
        public ICollection<Pedido> Pedidos { get; set; }


    }
}
