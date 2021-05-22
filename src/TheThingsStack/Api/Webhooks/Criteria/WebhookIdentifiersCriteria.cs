namespace TheThingsStack.Api.Webhooks.Criteria
{
    using Newtonsoft.Json;

    using Applications.Criteria;

    /// <summary>
    /// https://www.thethingsindustries.com/docs/reference/api/application_webhooks/#message:ApplicationWebhookIdentifiers
    /// </summary>
    public class WebhookIdentifiersCriteria
    {
        #region Constructor

        public WebhookIdentifiersCriteria() { }

        public WebhookIdentifiersCriteria(ApplicationIdentifierCriteria applicationIdentifiers, string webhookId)
        {
            this.ApplicationIdentifiers = applicationIdentifiers;
            this.WebhookId = webhookId;
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Application Identifier
        /// </summary>
        [JsonProperty("application_ids")]
        public ApplicationIdentifierCriteria ApplicationIdentifiers { get; set; }

        /// <summary>
        /// Webhook Identifier
        /// </summary>
        [JsonProperty("webhook_id")]
        public string WebhookId { get; set; }

        #endregion Properties
    }
}
