using CompanyServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyServer.Infrastructure.Configurations
{
    public class IssueConfiguration : IEntityTypeConfiguration<Issue>
    {
        public void Configure(EntityTypeBuilder<Issue> builder)
        {
            builder.ToTable("Issues");

            builder.HasKey(p => p.Id);

            builder.HasOne(s => s.Project)
                .WithMany(p => p.Issues)
                .HasForeignKey(f => f.ProjectId);
        }
    }
}
