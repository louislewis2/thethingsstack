namespace TheThingsStack.Api.Webhooks.Criteria
{
    using Newtonsoft.Json;

    public class WebhookMessageCriteria
    {
        #region Constructor

        public WebhookMessageCriteria() { }

        public WebhookMessageCriteria(string path)
        {
            this.Path = path;
        }

        #endregion Constructor

        #region Properties

        [JsonProperty("path")]
        public string Path { get; set; }

        #endregion Properties
    }
}
