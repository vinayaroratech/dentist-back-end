﻿using DentallApp.Features.Dependents.UseCases;

namespace DentallApp.Extensions;

public static class ApplicationDependencies
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services
            .AddScoped(typeof(IEntityService<>), typeof(EntityService<>))
            .AddScoped<ITokenService, TokenService>()
            .AddScoped<IEmailService, EmailService>()
            .AddSingleton<IDateTimeService, DateTimeService>()
            .AddSingleton<IHtmlConverter, HtmlConverterIText>()
            .AddSingleton<IHtmlTemplateLoader, HtmlTemplateLoaderScriban>()
            .AddSingleton<IPasswordHasher, PasswordHasherBcrypt>()
            .AddSingleton<IInstantMessaging, WhatsAppMessaging>();

        services
            .AddScoped<IUnitOfWork, UnitOfWork>()
            .AddScoped<ISchedulingQueries, SchedulingQueries>()
            .AddScoped(typeof(IRepository<>), typeof(Repository<>))
            .AddScoped<IUserRepository, UserRepository>()
            .AddScoped<ITreatmentRepository, TreatmentRepository>()
            .AddScoped<IAppointmentRepository, AppointmentRepository>()
            .AddScoped<IEmployeeScheduleRepository, EmployeeScheduleRepository>()
            .AddScoped<IOfficeHolidayRepository, OfficeHolidayRepository>();

        return services;
    }

    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        // Specifies the assembly for Scrutor to search for types.
        var assembly = typeof(GetDependentsByUserIdUseCase).Assembly;

        services.Scan(scan => scan
        // Search the types from the specified assemblies.
            .FromAssemblies(assembly)
              // Registers the concrete classes as a service, for example: 'CreateUserUseCase'.
              // It also registers interfaces as a service, for example: 'ICreateUserUseCase'.
              .AddClasses(classes => classes.Where(type => type.Name.EndsWith("UseCase")))
                .AsSelfWithInterfaces()
                .WithScopedLifetime()); 

        return services;
    }
}
