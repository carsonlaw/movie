using System;
using Microsoft.EntityFrameworkCore;
using Movie.Collections;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Movie.EntityFrameworkCore
{
    public static class MovieDbContextModelCreatingExtensions
    {
        public static void ConfigureMovie(
            this ModelBuilder builder,
            Action<MovieModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new MovieModelBuilderConfigurationOptions(
                MovieDbProperties.DbTablePrefix,
                MovieDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureFullAuditedAggregateRoot();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */
            builder.Entity<Category>(b =>
            {
                b.ToTable(options.TablePrefix + "Category", options.Schema);
                b.ConfigureAudited();
                b.HasMany(f => f.Categorys);
                b.HasOne(f => f.ParentCategory);
            });

            builder.Entity<Collection>(f =>
            {
                f.ToTable(options.TablePrefix + "Collection", options.Schema);
                f.ConfigureFullAuditedAggregateRoot();
                f.OwnsMany(c => c.CollectionCategorys);
                
            });

            builder.Entity<Person>(f =>
            {
                f.ToTable(options.TablePrefix + "Person", options.Schema);
                f.ConfigureAudited();
                f.OwnsOne(p => p.Country);
            });

            builder.Entity<Movie>(f =>
            {
                f.ToTable(options.TablePrefix + "Movie", options.Schema);
                f.ConfigureFullAuditedAggregateRoot();
                f.HasMany(m => m.Actors);
                f.HasMany(m => m.Directors);
                f.HasMany(m => m.Writers);
                f.HasOne(m => m.CateGory);
                f.OwnsOne(m => m.PropertyCountry);
                f.OwnsOne(m => m.PropertyYear);
                f.OwnsOne(m => m.PropertyLang);
                f.OwnsMany(m => m.PropertyTypes);
                f.OwnsMany(m => m.Downers);
                f.OwnsMany(m => m.Players);
            });
        }
    }
}