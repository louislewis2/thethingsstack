namespace TheThingsStack.Api.ApiKeys.ViewModels
{
    using Newtonsoft.Json;

    using Api;
    using Api.Rights.Enums;

    public class ApiKey : ViewModelBase
    {
        #region Properties

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rights")]
        public RightTypes[] Rights { get; set; }

        #endregion Properties
    }
}
