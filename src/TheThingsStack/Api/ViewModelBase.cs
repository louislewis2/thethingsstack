namespace TheThingsStack.Api
{
    using System;

    using Newtonsoft.Json;

    public class ViewModelBase
    {
        #region Properties

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        #endregion Properties
    }
}
