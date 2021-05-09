﻿namespace TheThingsStack.Api.Organizations.ViewModels
{
    using Newtonsoft.Json;

    using Converters;

    [JsonConverter(typeof(JsonPathConverter))]
    public class Organization : ViewModelBase
    {
        #region Properties

        [JsonProperty("ids.organization_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        #endregion Properties
    }
}
