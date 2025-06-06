using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class MES_AttachmentMapConfig : EntityMappingConfiguration<MES_Attachment>
    {
        public override void Map(EntityTypeBuilder<MES_Attachment>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

