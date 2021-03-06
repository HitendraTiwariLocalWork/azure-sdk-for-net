// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.Search.Models
{
    /// <summary> The result of Autocomplete requests. </summary>
    public partial class AutocompleteItem
    {
        /// <summary> The completed term. </summary>
        public string Text { get; internal set; }
        /// <summary> The query along with the completed term. </summary>
        public string QueryPlusText { get; internal set; }
    }
}
