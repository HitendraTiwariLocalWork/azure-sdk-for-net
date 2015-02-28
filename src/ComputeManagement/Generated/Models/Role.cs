// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Details of a role in a deployment.
    /// </summary>
    public partial class Role
    {
        private string _availabilitySetName;
        
        /// <summary>
        /// Optional. The name of the role.
        /// </summary>
        public string AvailabilitySetName
        {
            get { return this._availabilitySetName; }
            set { this._availabilitySetName = value; }
        }
        
        private IList<ConfigurationSet> _configurationSets;
        
        /// <summary>
        /// Optional. A collection of values that represents system or
        /// application configuration settings.
        /// </summary>
        public IList<ConfigurationSet> ConfigurationSets
        {
            get { return this._configurationSets; }
            set { this._configurationSets = value; }
        }
        
        private IList<DataVirtualHardDisk> _dataVirtualHardDisks;
        
        /// <summary>
        /// Optional. Contains the parameters Azure uses to create a data disk
        /// for a virtual machine.
        /// </summary>
        public IList<DataVirtualHardDisk> DataVirtualHardDisks
        {
            get { return this._dataVirtualHardDisks; }
            set { this._dataVirtualHardDisks = value; }
        }
        
        private string _defaultWinRmCertificateThumbprint;
        
        /// <summary>
        /// Optional. The read-only thumbprint of the certificate that is used
        /// with the HTTPS listener for WinRM.
        /// </summary>
        public string DefaultWinRmCertificateThumbprint
        {
            get { return this._defaultWinRmCertificateThumbprint; }
            set { this._defaultWinRmCertificateThumbprint = value; }
        }
        
        private string _label;
        
        /// <summary>
        /// Optional. The friendly name for the role.
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }
        
        private Uri _mediaLocation;
        
        /// <summary>
        /// Optional. Storage location where the VM Image VHDs should be
        /// copied, for published VM Images.
        /// </summary>
        public Uri MediaLocation
        {
            get { return this._mediaLocation; }
            set { this._mediaLocation = value; }
        }
        
        private string _oSVersion;
        
        /// <summary>
        /// Optional. The version of the operating system on which the role
        /// instances are running.
        /// </summary>
        public string OSVersion
        {
            get { return this._oSVersion; }
            set { this._oSVersion = value; }
        }
        
        private OSVirtualHardDisk _oSVirtualHardDisk;
        
        /// <summary>
        /// Optional. Contains the parameters Azure uses to create the
        /// operating system disk for the virtual machine.
        /// </summary>
        public OSVirtualHardDisk OSVirtualHardDisk
        {
            get { return this._oSVirtualHardDisk; }
            set { this._oSVirtualHardDisk = value; }
        }
        
        private bool? _provisionGuestAgent;
        
        /// <summary>
        /// Optional. Indicates whether the WindowsAzureGuestAgent service is
        /// installed on the Virtual Machine. To run a resource extension in a
        /// Virtual Machine, this service must be installed.
        /// </summary>
        public bool? ProvisionGuestAgent
        {
            get { return this._provisionGuestAgent; }
            set { this._provisionGuestAgent = value; }
        }
        
        private IList<ResourceExtensionReference> _resourceExtensionReferences;
        
        /// <summary>
        /// Optional. Contains a collection of resource extensions that are to
        /// be installed on the Virtual Machine. This element is used if
        /// ProvisionGuestAgent is set to true.
        /// </summary>
        public IList<ResourceExtensionReference> ResourceExtensionReferences
        {
            get { return this._resourceExtensionReferences; }
            set { this._resourceExtensionReferences = value; }
        }
        
        private string _roleName;
        
        /// <summary>
        /// Optional. The name of the role.
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }
        
        private string _roleSize;
        
        /// <summary>
        /// Optional. The size of the role instance.
        /// </summary>
        public string RoleSize
        {
            get { return this._roleSize; }
            set { this._roleSize = value; }
        }
        
        private string _roleType;
        
        /// <summary>
        /// Optional. Specifies the type of the role. This element is only
        /// listed for Virtual Machine deployments, and by default is
        /// PersistentVMRole.
        /// </summary>
        public string RoleType
        {
            get { return this._roleType; }
            set { this._roleType = value; }
        }
        
        private VMImageInput _vMImageInput;
        
        /// <summary>
        /// Optional. When a VM Image is used to create a new PersistantVMRole,
        /// the DiskConfigurations in the VM Image are used to create new
        /// Disks for the new VM. This parameter can be used to resize the
        /// newly created Disks to a larger size than the underlying
        /// DiskConfigurations in the VM Image.This property is only returned
        /// with a version header of 2014-10-01 or newer.
        /// </summary>
        public VMImageInput VMImageInput
        {
            get { return this._vMImageInput; }
            set { this._vMImageInput = value; }
        }
        
        private string _vMImageName;
        
        /// <summary>
        /// Optional. Optional. The name of the VMImage from which this Role is
        /// to be created. If the OSDisk in the VMImage was Specialized, then
        /// no WindowsProvisioningConfigurationSet or
        /// LinuxProvisioningConfigurationSet should be provided. No
        /// OSVirtualHardDisk or DataVirtualHardDisk should be specified when
        /// using this argument.
        /// </summary>
        public string VMImageName
        {
            get { return this._vMImageName; }
            set { this._vMImageName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Role class.
        /// </summary>
        public Role()
        {
            this.ConfigurationSets = new LazyList<ConfigurationSet>();
            this.DataVirtualHardDisks = new LazyList<DataVirtualHardDisk>();
            this.ResourceExtensionReferences = new LazyList<ResourceExtensionReference>();
        }
    }
}
