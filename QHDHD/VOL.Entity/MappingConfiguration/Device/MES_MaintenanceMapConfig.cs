using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class MES_MaintenanceMapConfig : EntityMappingConfiguration<MES_Maintenance>
    {
        public override void Map(EntityTypeBuilder<MES_Maintenance>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

