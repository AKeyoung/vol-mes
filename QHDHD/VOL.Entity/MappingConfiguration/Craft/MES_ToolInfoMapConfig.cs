using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class MES_ToolInfoMapConfig : EntityMappingConfiguration<MES_ToolInfo>
    {
        public override void Map(EntityTypeBuilder<MES_ToolInfo>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

