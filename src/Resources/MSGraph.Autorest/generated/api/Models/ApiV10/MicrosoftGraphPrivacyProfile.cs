// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>privacyProfile</summary>
    public partial class MicrosoftGraphPrivacyProfile :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPrivacyProfile,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPrivacyProfileInternal
    {

        /// <summary>Backing field for <see cref="ContactEmail" /> property.</summary>
        private string _contactEmail;

        /// <summary>A valid smtp email address for the privacy statement contact. Not required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string ContactEmail { get => this._contactEmail; set => this._contactEmail = value; }

        /// <summary>Backing field for <see cref="StatementUrl" /> property.</summary>
        private string _statementUrl;

        /// <summary>
        /// A valid URL format that begins with http:// or https://. Maximum length is 255 characters. The URL that directs to the
        /// company's privacy statement. Not required.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string StatementUrl { get => this._statementUrl; set => this._statementUrl = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphPrivacyProfile" /> instance.</summary>
        public MicrosoftGraphPrivacyProfile()
        {

        }
    }
    /// privacyProfile
    public partial interface IMicrosoftGraphPrivacyProfile :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>A valid smtp email address for the privacy statement contact. Not required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A valid smtp email address for the privacy statement contact. Not required.",
        SerializedName = @"contactEmail",
        PossibleTypes = new [] { typeof(string) })]
        string ContactEmail { get; set; }
        /// <summary>
        /// A valid URL format that begins with http:// or https://. Maximum length is 255 characters. The URL that directs to the
        /// company's privacy statement. Not required.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A valid URL format that begins with http:// or https://. Maximum length is 255 characters. The URL that directs to the company's privacy statement. Not required.",
        SerializedName = @"statementUrl",
        PossibleTypes = new [] { typeof(string) })]
        string StatementUrl { get; set; }

    }
    /// privacyProfile
    internal partial interface IMicrosoftGraphPrivacyProfileInternal

    {
        /// <summary>A valid smtp email address for the privacy statement contact. Not required.</summary>
        string ContactEmail { get; set; }
        /// <summary>
        /// A valid URL format that begins with http:// or https://. Maximum length is 255 characters. The URL that directs to the
        /// company's privacy statement. Not required.
        /// </summary>
        string StatementUrl { get; set; }

    }
}