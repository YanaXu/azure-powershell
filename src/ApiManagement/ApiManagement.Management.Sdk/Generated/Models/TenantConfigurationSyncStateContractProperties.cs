// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Tenant Configuration Synchronization State.
    /// </summary>
    public partial class TenantConfigurationSyncStateContractProperties
    {
        /// <summary>
        /// Initializes a new instance of the TenantConfigurationSyncStateContractProperties class.
        /// </summary>
        public TenantConfigurationSyncStateContractProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TenantConfigurationSyncStateContractProperties class.
        /// </summary>

        /// <param name="branch">The name of Git branch.
        /// </param>

        /// <param name="commitId">The latest commit Id.
        /// </param>

        /// <param name="isExport">value indicating if last sync was save (true) or deploy (false) operation.
        /// </param>

        /// <param name="isSynced">value indicating if last synchronization was later than the configuration
        /// change.
        /// </param>

        /// <param name="isGitEnabled">value indicating whether Git configuration access is enabled.
        /// </param>

        /// <param name="syncDate">The date of the latest synchronization. The date conforms to the following
        /// format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        /// </param>

        /// <param name="configurationChangeDate">The date of the latest configuration change. The date conforms to the
        /// following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601
        /// standard.
        /// </param>

        /// <param name="lastOperationId">Most recent tenant configuration operation identifier
        /// </param>
        public TenantConfigurationSyncStateContractProperties(string branch = default(string), string commitId = default(string), bool? isExport = default(bool?), bool? isSynced = default(bool?), bool? isGitEnabled = default(bool?), System.DateTime? syncDate = default(System.DateTime?), System.DateTime? configurationChangeDate = default(System.DateTime?), string lastOperationId = default(string))

        {
            this.Branch = branch;
            this.CommitId = commitId;
            this.IsExport = isExport;
            this.IsSynced = isSynced;
            this.IsGitEnabled = isGitEnabled;
            this.SyncDate = syncDate;
            this.ConfigurationChangeDate = configurationChangeDate;
            this.LastOperationId = lastOperationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the name of Git branch.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "branch")]
        public string Branch {get; set; }

        /// <summary>
        /// Gets or sets the latest commit Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "commitId")]
        public string CommitId {get; set; }

        /// <summary>
        /// Gets or sets value indicating if last sync was save (true) or deploy
        /// (false) operation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isExport")]
        public bool? IsExport {get; set; }

        /// <summary>
        /// Gets or sets value indicating if last synchronization was later than the
        /// configuration change.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isSynced")]
        public bool? IsSynced {get; set; }

        /// <summary>
        /// Gets or sets value indicating whether Git configuration access is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isGitEnabled")]
        public bool? IsGitEnabled {get; set; }

        /// <summary>
        /// Gets or sets the date of the latest synchronization. The date conforms to
        /// the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601
        /// standard.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "syncDate")]
        public System.DateTime? SyncDate {get; set; }

        /// <summary>
        /// Gets or sets the date of the latest configuration change. The date conforms
        /// to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO
        /// 8601 standard.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "configurationChangeDate")]
        public System.DateTime? ConfigurationChangeDate {get; set; }

        /// <summary>
        /// Gets or sets most recent tenant configuration operation identifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastOperationId")]
        public string LastOperationId {get; set; }
    }
}