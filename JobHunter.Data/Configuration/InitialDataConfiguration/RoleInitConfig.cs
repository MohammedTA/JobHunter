using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobHunter.Data.Configuration.InitialDataConfiguration
{
    public class RoleInitConfig : IEntityTypeConfiguration<IdentityRole<int>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<int>> builder)
        {
            int roleId = 1;
            IdentityRole<int>[] identityRoles = new IdentityRole<int>[]
            {
                new IdentityRole<int>
                {
                    Id=roleId++,
                    Name="admin",
                    NormalizedName="admin".ToUpper()
                },
                 new IdentityRole<int>
                {
                    Id=roleId++,
                    Name="manager",
                    NormalizedName="manager".ToUpper()
                },
                  new IdentityRole<int>
                {
                    Id=roleId++,
                    Name="worker",
                    NormalizedName="worker".ToUpper()
                },
                  new IdentityRole<int>
                {
                    Id=roleId++,
                    Name="employer",
                    NormalizedName="employer".ToUpper()
                },
                   new IdentityRole<int>
                {
                    Id=roleId++,
                    Name="moderator",
                    NormalizedName="moderator".ToUpper()
                },
            };
            builder.HasData(identityRoles);
        }
    }
}
