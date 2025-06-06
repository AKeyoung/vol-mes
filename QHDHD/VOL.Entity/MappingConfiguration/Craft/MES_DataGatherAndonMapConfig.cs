using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class MES_DataGatherAndonMapConfig : EntityMappingConfiguration<MES_DataGatherAndon>
    {
        public override void Map(EntityTypeBuilder<MES_DataGatherAndon>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

