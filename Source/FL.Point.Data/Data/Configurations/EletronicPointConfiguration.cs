using FL.Point.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FL.Point.Data.Data.Configurations
{
    public class EletronicPointConfiguration : IEntityTypeConfiguration<EletronicPoint>
    {
        public void Configure(EntityTypeBuilder<EletronicPoint> builder)
        {
            builder.ToTable("EletronicPoint");
            builder.HasKey(p => p.Id);
            //builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();
            //builder.Property(p => p.Telefone).HasColumnType("CHAR(11)");
            //builder.Property(p => p.CEP).HasColumnType("CHAR(8)").IsRequired();
            //builder.Property(p => p.Estado).HasColumnType("CHAR(2)").IsRequired();
            //builder.Property(p => p.Cidade).HasMaxLength(60).IsRequired();

            //builder.HasIndex(i => i.Telefone).HasName("idx_cliente_telefone");
        }
    }
}
