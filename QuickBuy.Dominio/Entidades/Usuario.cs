using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string SobreNome { get; set; }
        public string Nome { get; set; }



        //nenhum ou muitos peidos
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Campo nome é obrigatorio");

            if (string.IsNullOrEmpty(SobreNome))
                AdicionarCritica("O Campo Sobre Nome é obrigatorio");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não informada ou em não inserida");

            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("O Campo Email é obrigatorio");


        }



    }
}
