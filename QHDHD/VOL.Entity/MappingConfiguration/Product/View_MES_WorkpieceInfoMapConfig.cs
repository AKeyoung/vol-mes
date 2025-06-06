using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class View_MES_WorkpieceInfoMapConfig : EntityMappingConfiguration<View_MES_WorkpieceInfo>
    {
        public override void Map(EntityTypeBuilder<View_MES_WorkpieceInfo>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

