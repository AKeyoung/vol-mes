using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class MES_Report_WorkMapConfig : EntityMappingConfiguration<MES_Report_Work>
    {
        public override void Map(EntityTypeBuilder<MES_Report_Work>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

