using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Pac_Routing_OpMapConfig : EntityMappingConfiguration<Pac_Routing_Op>
    {
        public override void Map(EntityTypeBuilder<Pac_Routing_Op>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

