﻿using Harvest.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest.Net
{
    public partial interface IHarvestRestClient
    {
        IList<UserAssignment> ListUserAssignments(long projectId, DateTime? updatedSince = null);
        
        UserAssignment UserAssignment(long projectId, long userAssignmentId);
        
        UserAssignment CreateUserAssignment(long projectId, long userId);
        
        bool DeleteUserAssignment(long projectId, long userAssignmentId);
        
        UserAssignment UpdateUserAssignment(long projectId, long userAssignmentId, long userId, bool? deactivated = null, decimal? hourlyRate = null, decimal? budget = null, bool? isProjectManager = null);
        
        UserAssignment UpdateUserAssignment(long projectId, long userAssignmentId, UserAssignmentOptions options);
    }
}
