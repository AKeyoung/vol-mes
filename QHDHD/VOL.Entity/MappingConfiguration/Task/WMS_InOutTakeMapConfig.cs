using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class WMS_InOutTakeMapConfig : EntityMappingConfiguration<WMS_InOutTake>
    {
        public override void Map(EntityTypeBuilder<WMS_InOutTake>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

