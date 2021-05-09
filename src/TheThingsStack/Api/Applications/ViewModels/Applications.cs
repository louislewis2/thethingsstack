namespace TheThingsStack.Api.Applications.ViewModels
{
    using Newtonsoft.Json;

    public class Applications
    {
        #region Properties

        [JsonProperty("applications")]
        public Application[] Items { get; set; }

        #endregion Properties
    }
}
