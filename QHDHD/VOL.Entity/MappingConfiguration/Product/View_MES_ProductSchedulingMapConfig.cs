using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class View_MES_ProductSchedulingMapConfig : EntityMappingConfiguration<View_MES_ProductScheduling>
    {
        public override void Map(EntityTypeBuilder<View_MES_ProductScheduling>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

