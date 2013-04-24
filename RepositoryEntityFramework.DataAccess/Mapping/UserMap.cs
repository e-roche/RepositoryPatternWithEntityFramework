using System.Data.Entity.ModelConfiguration;
using RepositoryEntityFramework.DataAccess.Model;

namespace RepositoryEntityFramework.DataAccess.Mapping
{
    internal class UserMap : EntityTypeConfiguration<User>
    {
        internal UserMap()
            : base()
        {
            HasKey(u => u.ID);

            Property(u => u.ID).HasColumnName("ROW_ID").IsRequired();   // Podemos mapear cualquier propiedad a campos de la base de datos aunque no tengan el mismo nombre
            Property(u => u.Codigo).HasColumnName("Codigo");
            Property(u => u.Nombre).HasColumnName("Nombre");

            ToTable("USUARIOS");
        }
    }
}
