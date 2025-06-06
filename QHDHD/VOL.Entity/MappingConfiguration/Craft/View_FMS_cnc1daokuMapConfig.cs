using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class View_FMS_cnc1daokuMapConfig : EntityMappingConfiguration<View_FMS_cnc1daoku>
    {
        public override void Map(EntityTypeBuilder<View_FMS_cnc1daoku>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

