using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class MES_ProductSchedulingMapConfig : EntityMappingConfiguration<MES_ProductScheduling>
    {
        public override void Map(EntityTypeBuilder<MES_ProductScheduling>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

