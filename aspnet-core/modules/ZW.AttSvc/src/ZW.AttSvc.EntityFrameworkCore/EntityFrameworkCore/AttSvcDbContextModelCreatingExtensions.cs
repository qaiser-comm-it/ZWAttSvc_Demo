﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ZW.AttSvc.EntityFrameworkCore;

public static class AttSvcDbContextModelCreatingExtensions
{
    public static void ConfigureAttSvc(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(AttSvcDbProperties.DbTablePrefix + "Questions", AttSvcDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */

        builder.Entity<Project>(b =>
        {
            //Configure table & schema name
            b.ToTable(AttSvcDbProperties.DbTablePrefix + "Projects", AttSvcDbProperties.DbSchema);
            b.ConfigureByConvention();

        });
    }
}
