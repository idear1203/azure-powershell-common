// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Version2017_10_01.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SkuName.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SkuName
    {
        [EnumMember(Value = "Standard_LRS")]
        StandardLRS,
        [EnumMember(Value = "Standard_GRS")]
        StandardGRS,
        [EnumMember(Value = "Standard_RAGRS")]
        StandardRAGRS,
        [EnumMember(Value = "Standard_ZRS")]
        StandardZRS,
        [EnumMember(Value = "Premium_LRS")]
        PremiumLRS
    }
    internal static class SkuNameEnumExtension
    {
        internal static string ToSerializedValue(this SkuName? value)
        {
            return value == null ? null : ((SkuName)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SkuName value)
        {
            switch( value )
            {
                case SkuName.StandardLRS:
                    return "Standard_LRS";
                case SkuName.StandardGRS:
                    return "Standard_GRS";
                case SkuName.StandardRAGRS:
                    return "Standard_RAGRS";
                case SkuName.StandardZRS:
                    return "Standard_ZRS";
                case SkuName.PremiumLRS:
                    return "Premium_LRS";
            }
            return null;
        }

        internal static SkuName? ParseSkuName(this string value)
        {
            switch( value )
            {
                case "Standard_LRS":
                    return SkuName.StandardLRS;
                case "Standard_GRS":
                    return SkuName.StandardGRS;
                case "Standard_RAGRS":
                    return SkuName.StandardRAGRS;
                case "Standard_ZRS":
                    return SkuName.StandardZRS;
                case "Premium_LRS":
                    return SkuName.PremiumLRS;
            }
            return null;
        }
    }
}
