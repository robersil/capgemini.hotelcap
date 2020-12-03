﻿using HotelTDD.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelTDD.Infra.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                            .IsRequired()
                            .HasMaxLength(50);

            builder.Property(e => e.Email)
                            .IsRequired()
                            .HasMaxLength(50);

            builder.Property(e => e.Perfil)
                            .IsRequired()
                            .HasMaxLength(50);

            builder.Property(e => e.Senha)
                            .IsRequired()
                            .HasMaxLength(50);
        }
    }
}
