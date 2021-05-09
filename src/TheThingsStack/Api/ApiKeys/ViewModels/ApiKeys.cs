namespace TheThingsStack.Api.ApiKeys.ViewModels
{
    using Newtonsoft.Json;

    public class ApiKeys
    {
        #region Properties

        [JsonProperty("api_keys")]
        public ApiKey[] Items { get; set; }

        #endregion Properties
    }
}
