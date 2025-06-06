using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class View_MES_ConserveMapConfig : EntityMappingConfiguration<View_MES_Conserve>
    {
        public override void Map(EntityTypeBuilder<View_MES_Conserve>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

