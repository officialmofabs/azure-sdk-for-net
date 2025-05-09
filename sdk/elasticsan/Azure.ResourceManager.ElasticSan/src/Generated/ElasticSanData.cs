// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ElasticSan.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ElasticSan
{
    /// <summary>
    /// A class representing the ElasticSan data model.
    /// Response for ElasticSan request.
    /// </summary>
    public partial class ElasticSanData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ElasticSanData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> resource sku. </param>
        /// <param name="baseSizeTiB"> Base size of the Elastic San appliance in TiB. </param>
        /// <param name="extendedCapacitySizeTiB"> Extended size of the Elastic San appliance in TiB. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public ElasticSanData(AzureLocation location, ElasticSanSku sku, long baseSizeTiB, long extendedCapacitySizeTiB) : base(location)
        {
            Argument.AssertNotNull(sku, nameof(sku));

            Sku = sku;
            AvailabilityZones = new ChangeTrackingList<string>();
            BaseSizeTiB = baseSizeTiB;
            ExtendedCapacitySizeTiB = extendedCapacitySizeTiB;
            PrivateEndpointConnections = new ChangeTrackingList<ElasticSanPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="ElasticSanData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> resource sku. </param>
        /// <param name="availabilityZones"> Logical zone for Elastic San resource; example: ["1"]. </param>
        /// <param name="provisioningState"> State of the operation on the resource. </param>
        /// <param name="baseSizeTiB"> Base size of the Elastic San appliance in TiB. </param>
        /// <param name="extendedCapacitySizeTiB"> Extended size of the Elastic San appliance in TiB. </param>
        /// <param name="totalVolumeSizeGiB"> Total size of the provisioned Volumes in GiB. </param>
        /// <param name="volumeGroupCount"> Total number of volume groups in this Elastic San appliance. </param>
        /// <param name="totalIops"> Total Provisioned IOPS of the Elastic San appliance. </param>
        /// <param name="totalMbps"> Total Provisioned MBps Elastic San appliance. </param>
        /// <param name="totalSizeTiB"> Total size of the Elastic San appliance in TB. </param>
        /// <param name="privateEndpointConnections"> The list of Private Endpoint Connections. </param>
        /// <param name="publicNetworkAccess"> Allow or disallow public network access to ElasticSan. Value is optional but if passed in, must be 'Enabled' or 'Disabled'. </param>
        /// <param name="autoScaleProperties"> Auto Scale Properties for Elastic San Appliance. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ElasticSanData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ElasticSanSku sku, IList<string> availabilityZones, ElasticSanProvisioningState? provisioningState, long baseSizeTiB, long extendedCapacitySizeTiB, long? totalVolumeSizeGiB, long? volumeGroupCount, long? totalIops, long? totalMbps, long? totalSizeTiB, IReadOnlyList<ElasticSanPrivateEndpointConnectionData> privateEndpointConnections, ElasticSanPublicNetworkAccess? publicNetworkAccess, AutoScaleProperties autoScaleProperties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            AvailabilityZones = availabilityZones;
            ProvisioningState = provisioningState;
            BaseSizeTiB = baseSizeTiB;
            ExtendedCapacitySizeTiB = extendedCapacitySizeTiB;
            TotalVolumeSizeGiB = totalVolumeSizeGiB;
            VolumeGroupCount = volumeGroupCount;
            TotalIops = totalIops;
            TotalMbps = totalMbps;
            TotalSizeTiB = totalSizeTiB;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            AutoScaleProperties = autoScaleProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ElasticSanData"/> for deserialization. </summary>
        internal ElasticSanData()
        {
        }

        /// <summary> resource sku. </summary>
        public ElasticSanSku Sku { get; set; }
        /// <summary> Logical zone for Elastic San resource; example: ["1"]. </summary>
        public IList<string> AvailabilityZones { get; }
        /// <summary> State of the operation on the resource. </summary>
        public ElasticSanProvisioningState? ProvisioningState { get; }
        /// <summary> Base size of the Elastic San appliance in TiB. </summary>
        public long BaseSizeTiB { get; set; }
        /// <summary> Extended size of the Elastic San appliance in TiB. </summary>
        public long ExtendedCapacitySizeTiB { get; set; }
        /// <summary> Total size of the provisioned Volumes in GiB. </summary>
        public long? TotalVolumeSizeGiB { get; }
        /// <summary> Total number of volume groups in this Elastic San appliance. </summary>
        public long? VolumeGroupCount { get; }
        /// <summary> Total Provisioned IOPS of the Elastic San appliance. </summary>
        public long? TotalIops { get; }
        /// <summary> Total Provisioned MBps Elastic San appliance. </summary>
        public long? TotalMbps { get; }
        /// <summary> Total size of the Elastic San appliance in TB. </summary>
        public long? TotalSizeTiB { get; }
        /// <summary> The list of Private Endpoint Connections. </summary>
        public IReadOnlyList<ElasticSanPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Allow or disallow public network access to ElasticSan. Value is optional but if passed in, must be 'Enabled' or 'Disabled'. </summary>
        public ElasticSanPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Auto Scale Properties for Elastic San Appliance. </summary>
        internal AutoScaleProperties AutoScaleProperties { get; set; }
        /// <summary> Scale up settings on Elastic San Appliance. </summary>
        public ElasticSanScaleUpProperties ScaleUpProperties
        {
            get => AutoScaleProperties is null ? default : AutoScaleProperties.ScaleUpProperties;
            set
            {
                if (AutoScaleProperties is null)
                    AutoScaleProperties = new AutoScaleProperties();
                AutoScaleProperties.ScaleUpProperties = value;
            }
        }
    }
}
