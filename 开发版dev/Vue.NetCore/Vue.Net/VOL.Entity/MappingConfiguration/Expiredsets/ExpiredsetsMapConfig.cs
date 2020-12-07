using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class ExpiredsetsMapConfig : EntityMappingConfiguration<Expiredsets>
    {
        public override void Map(EntityTypeBuilder<Expiredsets>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

