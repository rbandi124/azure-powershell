// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101
{
    using Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.PowerShell;

    /// <summary>Savings plan purchase details</summary>
    [System.ComponentModel.TypeConverter(typeof(SavingsPlanToPurchaseCalculateExchangeTypeConverter))]
    public partial class SavingsPlanToPurchaseCalculateExchange
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SavingsPlanToPurchaseCalculateExchange"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchange"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchange DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SavingsPlanToPurchaseCalculateExchange(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SavingsPlanToPurchaseCalculateExchange"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchange"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchange DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SavingsPlanToPurchaseCalculateExchange(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SavingsPlanToPurchaseCalculateExchange" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="SavingsPlanToPurchaseCalculateExchange" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchange FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SavingsPlanToPurchaseCalculateExchange"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SavingsPlanToPurchaseCalculateExchange(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequest) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SavingsPlanPurchaseRequestTypeConverter.ConvertFrom);
            }
            if (content.Contains("BillingCurrencyTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).BillingCurrencyTotal = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice) content.GetValueForProperty("BillingCurrencyTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).BillingCurrencyTotal, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("SavingsPlanPurchaseRequestProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).SavingsPlanPurchaseRequestProperty = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestProperties) content.GetValueForProperty("SavingsPlanPurchaseRequestProperty",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).SavingsPlanPurchaseRequestProperty, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SavingsPlanPurchaseRequestPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Commitment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).Commitment = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICommitment) content.GetValueForProperty("Commitment",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).Commitment, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.CommitmentTypeConverter.ConvertFrom);
            }
            if (content.Contains("BillingPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).BillingPlan = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.BillingPlan?) content.GetValueForProperty("BillingPlan",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).BillingPlan, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.BillingPlan.CreateFrom);
            }
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISkuName) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SkuNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopeProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopeProperty = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopeProperties) content.GetValueForProperty("AppliedScopeProperty",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopeProperty, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.AppliedScopePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("BillingScopeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).BillingScopeId = (string) content.GetValueForProperty("BillingScopeId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).BillingScopeId, global::System.Convert.ToString);
            }
            if (content.Contains("Term"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).Term = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.SavingsPlanTerm?) content.GetValueForProperty("Term",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).Term, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.SavingsPlanTerm.CreateFrom);
            }
            if (content.Contains("AppliedScopeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopeType = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType?) content.GetValueForProperty("AppliedScopeType",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopeType, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType.CreateFrom);
            }
            if (content.Contains("AppliedScopePropertyTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertyTenantId = (string) content.GetValueForProperty("AppliedScopePropertyTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertyTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertySubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertySubscriptionId = (string) content.GetValueForProperty("AppliedScopePropertySubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertySubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertyDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertyDisplayName = (string) content.GetValueForProperty("AppliedScopePropertyDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertyDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("CommitmentGrain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).CommitmentGrain = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.CommitmentGrain?) content.GetValueForProperty("CommitmentGrain",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).CommitmentGrain, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.CommitmentGrain.CreateFrom);
            }
            if (content.Contains("AppliedScopePropertyManagementGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertyManagementGroupId = (string) content.GetValueForProperty("AppliedScopePropertyManagementGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertyManagementGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertyResourceGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertyResourceGroupId = (string) content.GetValueForProperty("AppliedScopePropertyResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertyResourceGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("CommitmentCurrencyCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).CommitmentCurrencyCode = (string) content.GetValueForProperty("CommitmentCurrencyCode",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).CommitmentCurrencyCode, global::System.Convert.ToString);
            }
            if (content.Contains("CommitmentAmount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).CommitmentAmount = (double?) content.GetValueForProperty("CommitmentAmount",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).CommitmentAmount, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SavingsPlanToPurchaseCalculateExchange"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SavingsPlanToPurchaseCalculateExchange(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequest) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SavingsPlanPurchaseRequestTypeConverter.ConvertFrom);
            }
            if (content.Contains("BillingCurrencyTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).BillingCurrencyTotal = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice) content.GetValueForProperty("BillingCurrencyTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).BillingCurrencyTotal, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("SavingsPlanPurchaseRequestProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).SavingsPlanPurchaseRequestProperty = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestProperties) content.GetValueForProperty("SavingsPlanPurchaseRequestProperty",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).SavingsPlanPurchaseRequestProperty, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SavingsPlanPurchaseRequestPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Commitment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).Commitment = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICommitment) content.GetValueForProperty("Commitment",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).Commitment, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.CommitmentTypeConverter.ConvertFrom);
            }
            if (content.Contains("BillingPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).BillingPlan = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.BillingPlan?) content.GetValueForProperty("BillingPlan",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).BillingPlan, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.BillingPlan.CreateFrom);
            }
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISkuName) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SkuNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopeProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopeProperty = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopeProperties) content.GetValueForProperty("AppliedScopeProperty",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopeProperty, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.AppliedScopePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("BillingScopeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).BillingScopeId = (string) content.GetValueForProperty("BillingScopeId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).BillingScopeId, global::System.Convert.ToString);
            }
            if (content.Contains("Term"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).Term = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.SavingsPlanTerm?) content.GetValueForProperty("Term",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).Term, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.SavingsPlanTerm.CreateFrom);
            }
            if (content.Contains("AppliedScopeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopeType = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType?) content.GetValueForProperty("AppliedScopeType",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopeType, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType.CreateFrom);
            }
            if (content.Contains("AppliedScopePropertyTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertyTenantId = (string) content.GetValueForProperty("AppliedScopePropertyTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertyTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertySubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertySubscriptionId = (string) content.GetValueForProperty("AppliedScopePropertySubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertySubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertyDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertyDisplayName = (string) content.GetValueForProperty("AppliedScopePropertyDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertyDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("CommitmentGrain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).CommitmentGrain = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.CommitmentGrain?) content.GetValueForProperty("CommitmentGrain",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).CommitmentGrain, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.CommitmentGrain.CreateFrom);
            }
            if (content.Contains("AppliedScopePropertyManagementGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertyManagementGroupId = (string) content.GetValueForProperty("AppliedScopePropertyManagementGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertyManagementGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertyResourceGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertyResourceGroupId = (string) content.GetValueForProperty("AppliedScopePropertyResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).AppliedScopePropertyResourceGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("CommitmentCurrencyCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).CommitmentCurrencyCode = (string) content.GetValueForProperty("CommitmentCurrencyCode",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).CommitmentCurrencyCode, global::System.Convert.ToString);
            }
            if (content.Contains("CommitmentAmount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).CommitmentAmount = (double?) content.GetValueForProperty("CommitmentAmount",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseCalculateExchangeInternal)this).CommitmentAmount, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Savings plan purchase details
    [System.ComponentModel.TypeConverter(typeof(SavingsPlanToPurchaseCalculateExchangeTypeConverter))]
    public partial interface ISavingsPlanToPurchaseCalculateExchange

    {

    }
}