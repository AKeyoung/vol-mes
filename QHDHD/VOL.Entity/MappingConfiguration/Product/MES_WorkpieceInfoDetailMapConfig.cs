using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class MES_WorkpieceInfoDetailMapConfig : EntityMappingConfiguration<MES_WorkpieceInfoDetail>
    {
        public override void Map(EntityTypeBuilder<MES_WorkpieceInfoDetail>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

