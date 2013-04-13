using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgileDashboardContracts.Entities;
namespace AgileDashboardContracts.Repositories
{
    public interface IProjectRepository
    {
         List<IProject> GetActiveProjects(string user);
    }
}
