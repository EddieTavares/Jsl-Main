using Jsl.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jsl.Infra.Data.Mapping
{
    public class MotoristaMap : IEntityTypeConfiguration<Motorista>
    {
        public void Configure(EntityTypeBuilder<Motorista> builder)
        {
            builder.ToTable("Motorista");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Sobrenome)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("Sobrenome")
               .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Logradouro)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Logradouro")
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.Numero)
                .IsRequired();

            builder.Property(prop => prop.Bairro)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Bairro")
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.Cidade)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Cidade")
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.UF)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("UF")
                .HasColumnType("varchar(2)");

            builder.Property(prop => prop.CEP)
                .IsRequired()
                .HasColumnName("CEP")
                .HasColumnType("varchar(11)");

            builder.Property(prop => prop.Complemento)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .HasColumnName("Complemento")
                .HasColumnType("varchar(200)");

            builder.Property(prop => prop.Telefone)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Telefone")
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Marca)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Marca")
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Modelo)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Modelo")
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.Placa)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Placa")
                .HasColumnType("varchar(10)");

            builder.Property(prop => prop.Eixos)
                .IsRequired();
        }
    }
}
