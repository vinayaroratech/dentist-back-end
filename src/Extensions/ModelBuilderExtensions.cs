﻿namespace DentallApp.Extensions;

public static class ModelBuilderExtensions
{
    /// <summary>
    /// Adds the entity as a model so that EF Core can generate the database schema (tables, primary keys, foreign keys, among others).
    /// </summary>
    /// <typeparam name="TEntity">The entity type to be added.</typeparam>
    /// <param name="modelBuilder"></param>
    /// <returns></returns>
    public static ModelBuilder AddEntity<TEntity>(this ModelBuilder modelBuilder) where TEntity : class
    {
        modelBuilder.Entity<TEntity>();
        return modelBuilder;
    }

    public static DataBuilder<TEntity> AddSeedData<TEntity>(this ModelBuilder builder, params TEntity[] data) where TEntity : EntityBase
    {
        foreach (var entity in data)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
        }
        return builder.Entity<TEntity>().HasData(data);
    }
}
