using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);


            //utilizar padrão Fluent
            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);
                
            builder
               .Property(u => u.SobreNome)
               .IsRequired()
               .HasMaxLength(50);

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);

            //Conig. 1 pedido para 1 unico usuário
            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);
                
                

           
        }
    }
}
