namespace TheThingsStack.Api.Applications.ViewModels
{
    using Newtonsoft.Json;

    using Converters;

    [JsonConverter(typeof(JsonPathConverter))]
    public class Application : ViewModelBase
    {
        #region Methods

        [JsonProperty("ids.application_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        #endregion Methods
    }
}
