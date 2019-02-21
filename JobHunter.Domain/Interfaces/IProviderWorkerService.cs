using System;
using System.Collections.Generic;
using System.Text;
using JobHunter.Domain.Models;
namespace JobHunter.Domain.Interfaces
{
    public interface IWorkerProfileService
    {
        int CreateInfoProfile(WorkerProfileDTO workerProfile);
    }
}