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
using Microsoft.Azure.Management.Sql.LegacySdk;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public static partial class ServiceObjectiveOperationsExtensions
    {
        /// <summary>
        /// Returns information about an Azure SQL Database Server Service
        /// Objectives.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServiceObjectiveOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Server.
        /// </param>
        /// <param name='serviceObjectiveName'>
        /// Required. The name of the service objective to retrieve.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql Database Service
        /// Objective request.
        /// </returns>
        public static ServiceObjectiveGetResponse Get(this IServiceObjectiveOperations operations, string resourceGroupName, string serverName, string serviceObjectiveName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServiceObjectiveOperations)s).GetAsync(resourceGroupName, serverName, serviceObjectiveName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Database Server Service
        /// Objectives.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServiceObjectiveOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Server.
        /// </param>
        /// <param name='serviceObjectiveName'>
        /// Required. The name of the service objective to retrieve.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql Database Service
        /// Objective request.
        /// </returns>
        public static Task<ServiceObjectiveGetResponse> GetAsync(this IServiceObjectiveOperations operations, string resourceGroupName, string serverName, string serviceObjectiveName)
        {
            return operations.GetAsync(resourceGroupName, serverName, serviceObjectiveName, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Database Server Service
        /// Objectives.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServiceObjectiveOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Server.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql Database Service
        /// Objectives request.
        /// </returns>
        public static ServiceObjectiveListResponse List(this IServiceObjectiveOperations operations, string resourceGroupName, string serverName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServiceObjectiveOperations)s).ListAsync(resourceGroupName, serverName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Database Server Service
        /// Objectives.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServiceObjectiveOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Server.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql Database Service
        /// Objectives request.
        /// </returns>
        public static Task<ServiceObjectiveListResponse> ListAsync(this IServiceObjectiveOperations operations, string resourceGroupName, string serverName)
        {
            return operations.ListAsync(resourceGroupName, serverName, CancellationToken.None);
        }
    }
}
