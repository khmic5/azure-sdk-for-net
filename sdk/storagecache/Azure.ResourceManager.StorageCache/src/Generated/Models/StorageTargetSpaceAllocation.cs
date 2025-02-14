// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Storage Target space allocation properties. </summary>
    public partial class StorageTargetSpaceAllocation
    {
        /// <summary> Initializes a new instance of <see cref="StorageTargetSpaceAllocation"/>. </summary>
        public StorageTargetSpaceAllocation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageTargetSpaceAllocation"/>. </summary>
        /// <param name="name"> Name of the storage target. </param>
        /// <param name="allocationPercentage"> The percentage of cache space allocated for this storage target. </param>
        internal StorageTargetSpaceAllocation(string name, int? allocationPercentage)
        {
            Name = name;
            AllocationPercentage = allocationPercentage;
        }

        /// <summary> Name of the storage target. </summary>
        public string Name { get; set; }
        /// <summary> The percentage of cache space allocated for this storage target. </summary>
        public int? AllocationPercentage { get; set; }
    }
}
