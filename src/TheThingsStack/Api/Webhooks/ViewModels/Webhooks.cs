namespace TheThingsStack.Api.Webhooks.ViewModels
{
    using Newtonsoft.Json;

    public class Webhooks
    {
        #region Properties

        [JsonProperty("webhooks")]
        public Webhook[] Items { get; set; }

        #endregion Properties
    }
}
