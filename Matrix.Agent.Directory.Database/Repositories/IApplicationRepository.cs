﻿using Matrix.Agent.Database;
using Matrix.Agent.Directory.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Matrix.Agent.Directory.Database.Repositories
{
    public interface IApplicationRepository : IRepository
    {
        Task<List<Application>> GetApplications();

        Task<Application> GetApplicationById(Guid id);

        Task<bool> ContainsApplication(Guid id);

        Task<bool> CreateApplication(Guid id, string name, string description);

        Task<bool> UpdateApplication(Guid id, string name, string description);

        Task<bool> DeleteApplication(Guid id);
    }
}