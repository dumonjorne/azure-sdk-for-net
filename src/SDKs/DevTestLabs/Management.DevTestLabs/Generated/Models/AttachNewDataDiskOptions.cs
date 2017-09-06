// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Properties to attach new disk to the Virtual Machine.
    /// </summary>
    public partial class AttachNewDataDiskOptions
    {
        /// <summary>
        /// Initializes a new instance of the AttachNewDataDiskOptions class.
        /// </summary>
        public AttachNewDataDiskOptions() { }

        /// <summary>
        /// Initializes a new instance of the AttachNewDataDiskOptions class.
        /// </summary>
        public AttachNewDataDiskOptions(int? diskSizeGiB = default(int?), string diskName = default(string), string diskType = default(string))
        {
            DiskSizeGiB = diskSizeGiB;
            DiskName = diskName;
            DiskType = diskType;
        }

        /// <summary>
        /// Size of the disk to be attached in GibiBytes.
        /// </summary>
        [JsonProperty(PropertyName = "diskSizeGiB")]
        public int? DiskSizeGiB { get; set; }

        /// <summary>
        /// The name of the disk to be attached.
        /// </summary>
        [JsonProperty(PropertyName = "diskName")]
        public string DiskName { get; set; }

        /// <summary>
        /// The storage type for the disk (i.e. Standard, Premium). Possible
        /// values include: 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "diskType")]
        public string DiskType { get; set; }

    }
}