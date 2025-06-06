using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class WMS_PutStockMapConfig : EntityMappingConfiguration<WMS_PutStock>
    {
        public override void Map(EntityTypeBuilder<WMS_PutStock>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

