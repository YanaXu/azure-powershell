// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Network Status in the Location
    /// </summary>
    public partial class NetworkStatusContractByLocation
    {
        /// <summary>
        /// Initializes a new instance of the NetworkStatusContractByLocation class.
        /// </summary>
        public NetworkStatusContractByLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkStatusContractByLocation class.
        /// </summary>

        /// <param name="location">Location of service
        /// </param>

        /// <param name="networkStatus">Network status in Location
        /// </param>
        public NetworkStatusContractByLocation(string location = default(string), NetworkStatusContract networkStatus = default(NetworkStatusContract))

        {
            this.Location = location;
            this.NetworkStatus = networkStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets location of service
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location {get; set; }

        /// <summary>
        /// Gets or sets network status in Location
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "networkStatus")]
        public NetworkStatusContract NetworkStatus {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Location != null)
            {
                if (this.Location.Length < 1)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MinLength, "Location", 1);
                }
            }
            if (this.NetworkStatus != null)
            {
                this.NetworkStatus.Validate();
            }
        }
    }
}