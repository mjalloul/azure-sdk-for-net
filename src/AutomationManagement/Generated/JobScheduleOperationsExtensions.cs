// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Automation;
using Microsoft.WindowsAzure.Management.Automation.Models;

namespace Microsoft.WindowsAzure.Management.Automation
{
    public static partial class JobScheduleOperationsExtensions
    {
        /// <summary>
        /// Create a job schedule.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobScheduleOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the create job schedule
        /// operation.
        /// </param>
        /// <returns>
        /// The response model for the create job schedule operation.
        /// </returns>
        public static JobScheduleCreateResponse Create(this IJobScheduleOperations operations, string automationAccount, JobScheduleCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobScheduleOperations)s).CreateAsync(automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a job schedule.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobScheduleOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the create job schedule
        /// operation.
        /// </param>
        /// <returns>
        /// The response model for the create job schedule operation.
        /// </returns>
        public static Task<JobScheduleCreateResponse> CreateAsync(this IJobScheduleOperations operations, string automationAccount, JobScheduleCreateParameters parameters)
        {
            return operations.CreateAsync(automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete the job schedule identified by job schedule name.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobScheduleOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobScheduleName'>
        /// Required. The job schedule name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IJobScheduleOperations operations, string automationAccount, Guid jobScheduleName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobScheduleOperations)s).DeleteAsync(automationAccount, jobScheduleName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete the job schedule identified by job schedule name.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobScheduleOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobScheduleName'>
        /// Required. The job schedule name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IJobScheduleOperations operations, string automationAccount, Guid jobScheduleName)
        {
            return operations.DeleteAsync(automationAccount, jobScheduleName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the job schedule identified by job schedule name.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobScheduleOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobScheduleName'>
        /// Required. The job schedule name.
        /// </param>
        /// <returns>
        /// The response model for the get job schedule operation.
        /// </returns>
        public static JobScheduleGetResponse Get(this IJobScheduleOperations operations, string automationAccount, Guid jobScheduleName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobScheduleOperations)s).GetAsync(automationAccount, jobScheduleName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the job schedule identified by job schedule name.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobScheduleOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobScheduleName'>
        /// Required. The job schedule name.
        /// </param>
        /// <returns>
        /// The response model for the get job schedule operation.
        /// </returns>
        public static Task<JobScheduleGetResponse> GetAsync(this IJobScheduleOperations operations, string automationAccount, Guid jobScheduleName)
        {
            return operations.GetAsync(automationAccount, jobScheduleName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of job schedules.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobScheduleOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list job schedule operation.
        /// </returns>
        public static JobScheduleListResponse List(this IJobScheduleOperations operations, string automationAccount)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobScheduleOperations)s).ListAsync(automationAccount);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of job schedules.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobScheduleOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list job schedule operation.
        /// </returns>
        public static Task<JobScheduleListResponse> ListAsync(this IJobScheduleOperations operations, string automationAccount)
        {
            return operations.ListAsync(automationAccount, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve next list of schedules.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobScheduleOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list job schedule operation.
        /// </returns>
        public static JobScheduleListResponse ListNext(this IJobScheduleOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobScheduleOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve next list of schedules.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobScheduleOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list job schedule operation.
        /// </returns>
        public static Task<JobScheduleListResponse> ListNextAsync(this IJobScheduleOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
    }
}
