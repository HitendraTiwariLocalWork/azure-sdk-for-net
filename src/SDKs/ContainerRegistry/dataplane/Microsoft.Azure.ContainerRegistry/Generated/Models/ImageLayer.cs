// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Image layer information
    /// </summary>
    public partial class ImageLayer
    {
        /// <summary>
        /// Initializes a new instance of the ImageLayer class.
        /// </summary>
        public ImageLayer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageLayer class.
        /// </summary>
        /// <param name="blobSum">SHA of an image layer</param>
        public ImageLayer(string blobSum = default(string))
        {
            BlobSum = blobSum;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SHA of an image layer
        /// </summary>
        [JsonProperty(PropertyName = "blobSum")]
        public string BlobSum { get; set; }

    }
}