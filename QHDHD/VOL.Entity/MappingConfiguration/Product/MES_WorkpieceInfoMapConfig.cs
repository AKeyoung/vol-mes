using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class MES_WorkpieceInfoMapConfig : EntityMappingConfiguration<MES_WorkpieceInfo>
    {
        public override void Map(EntityTypeBuilder<MES_WorkpieceInfo>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

