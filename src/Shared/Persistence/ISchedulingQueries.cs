﻿namespace DentallApp.Shared.Persistence;

/// <summary>
/// Represents queries for appointment scheduling.
/// </summary>
public interface ISchedulingQueries
{
    Task<List<AdaptiveChoice>> GetPatientsAsync(AuthenticatedUser user);
    Task<List<AdaptiveChoice>> GetOfficesAsync();
    Task<List<AdaptiveChoice>> GetDentalServicesAsync();
    Task<List<AdaptiveChoice>> GetDentistsAsync(int officeId, int specialtyId);
}
