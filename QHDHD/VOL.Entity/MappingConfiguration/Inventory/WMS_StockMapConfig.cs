using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class WMS_StockMapConfig : EntityMappingConfiguration<WMS_Stock>
    {
        public override void Map(EntityTypeBuilder<WMS_Stock>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

