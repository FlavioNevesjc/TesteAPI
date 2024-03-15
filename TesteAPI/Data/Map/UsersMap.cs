using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteAPI.Models;

namespace TesteAPI.Data.Map
{
    public class UsersMap : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Username).IsRequired().HasMaxLength(40);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(30);
            builder.Property(x => x.NomeCompleto).HasMaxLength(255);
        }
    }
}