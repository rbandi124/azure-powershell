// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Extensions;

    /// <summary>Resource log category configuration of a Microsoft.SignalRService resource.</summary>
    public partial class ResourceLogCategory :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IResourceLogCategory,
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IResourceLogCategoryInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private string _enabled;

        /// <summary>
        /// Indicates whether or the resource log category is enabled.
        /// Available values: true, false.
        /// Case insensitive.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        public string Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// Gets or sets the resource log category's name.
        /// Available values: ConnectivityLogs, MessagingLogs.
        /// Case insensitive.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="ResourceLogCategory" /> instance.</summary>
        public ResourceLogCategory()
        {

        }
    }
    /// Resource log category configuration of a Microsoft.SignalRService resource.
    public partial interface IResourceLogCategory :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Indicates whether or the resource log category is enabled.
        /// Available values: true, false.
        /// Case insensitive.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether or the resource log category is enabled.
        Available values: true, false.
        Case insensitive.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(string) })]
        string Enabled { get; set; }
        /// <summary>
        /// Gets or sets the resource log category's name.
        /// Available values: ConnectivityLogs, MessagingLogs.
        /// Case insensitive.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the resource log category's name.
        Available values: ConnectivityLogs, MessagingLogs.
        Case insensitive.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Resource log category configuration of a Microsoft.SignalRService resource.
    internal partial interface IResourceLogCategoryInternal

    {
        /// <summary>
        /// Indicates whether or the resource log category is enabled.
        /// Available values: true, false.
        /// Case insensitive.
        /// </summary>
        string Enabled { get; set; }
        /// <summary>
        /// Gets or sets the resource log category's name.
        /// Available values: ConnectivityLogs, MessagingLogs.
        /// Case insensitive.
        /// </summary>
        string Name { get; set; }

    }
}