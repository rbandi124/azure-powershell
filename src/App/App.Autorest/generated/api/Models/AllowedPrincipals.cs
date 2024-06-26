// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>The configuration settings of the Azure Active Directory allowed principals.</summary>
    public partial class AllowedPrincipals :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAllowedPrincipals,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAllowedPrincipalsInternal
    {

        /// <summary>Backing field for <see cref="Group" /> property.</summary>
        private System.Collections.Generic.List<string> _group;

        /// <summary>The list of the allowed groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Group { get => this._group; set => this._group = value; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private System.Collections.Generic.List<string> _identity;

        /// <summary>The list of the allowed identities.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Identity { get => this._identity; set => this._identity = value; }

        /// <summary>Creates an new <see cref="AllowedPrincipals" /> instance.</summary>
        public AllowedPrincipals()
        {

        }
    }
    /// The configuration settings of the Azure Active Directory allowed principals.
    public partial interface IAllowedPrincipals :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>The list of the allowed groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of the allowed groups.",
        SerializedName = @"groups",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Group { get; set; }
        /// <summary>The list of the allowed identities.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of the allowed identities.",
        SerializedName = @"identities",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Identity { get; set; }

    }
    /// The configuration settings of the Azure Active Directory allowed principals.
    internal partial interface IAllowedPrincipalsInternal

    {
        /// <summary>The list of the allowed groups.</summary>
        System.Collections.Generic.List<string> Group { get; set; }
        /// <summary>The list of the allowed identities.</summary>
        System.Collections.Generic.List<string> Identity { get; set; }

    }
}