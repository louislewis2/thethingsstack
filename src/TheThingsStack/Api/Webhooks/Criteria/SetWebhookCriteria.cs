namespace TheThingsStack.Api.Webhooks.Criteria
{
    using System.Collections.Generic;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using Enums;
    using Applications.Criteria;

    /// <summary>
    /// https://www.thethingsindustries.com/docs/reference/api/application_webhooks/
    /// </summary>
    public class SetWebhookCriteria
    {
        #region Constructor

        public SetWebhookCriteria() { }

        public SetWebhookCriteria(
            WebhookIdentifiersCriteria ids,
            string baseUrl,
            Dictionary<string, string> headers,
            WebhookFormats format,
            string templateId,
            Dictionary<string, string> templateFields,
            string downlinkApiKey,
            WebhookMessageCriteria uplinkMessage,
            WebhookMessageCriteria joinAccept,
            WebhookMessageCriteria downlinkAck,
            WebhookMessageCriteria downlinkNack,
            WebhookMessageCriteria downlinkSent,
            WebhookMessageCriteria downlinkFailed,
            WebhookMessageCriteria downlinkQueued,
            WebhookMessageCriteria downlinkQueueInvalidated,
            WebhookMessageCriteria locationSolved,
            WebhookMessageCriteria serviceData)
        {
            this.Ids = ids;
            this.BaseUrl = baseUrl;
            this.Headers = headers;
            this.Format = format;
            this.TemplateId = templateId;
            this.TemplateFields = templateFields;
            this.DownlinkApiKey = downlinkApiKey;
            this.UplinkMessage = uplinkMessage;
            this.JoinAccept = joinAccept;
            this.DownlinkAck = downlinkAck;
            this.DownlinkNack = downlinkNack;
            this.DownlinkSent = downlinkSent;
            this.DownlinkFailed = downlinkFailed;
            this.DownlinkQueued = downlinkQueued;
            this.DownlinkQueueInvalidated = downlinkQueueInvalidated;
            this.LocationSolved = locationSolved;
            this.ServiceData = serviceData;
        }

        public SetWebhookCriteria(
            string id,
            string applicationId,
            string baseUrl,
            Dictionary<string, string> headers,
            WebhookFormats format,
            string templateId,
            Dictionary<string, string> templateFields,
            string downlinkApiKey,
            string uplinkMessagePath,
            string joinAcceptPath,
            string downlinkAckPath,
            string downlinkNackPath,
            string downlinkSentPath,
            string downlinkFailedPath,
            string downlinkQueuedPath,
            string downlinkQueueInvalidatedPath,
            string locationSolvedPath,
            string serviceDataPath)
        {
            this.Ids = new WebhookIdentifiersCriteria(
                applicationIdentifiers: new ApplicationIdentifierCriteria(applicationId: applicationId),
                webhookId: id);

            this.BaseUrl = baseUrl;
            this.Headers = headers;
            this.Format = format;
            this.TemplateId = templateId;
            this.TemplateFields = templateFields;
            this.DownlinkApiKey = downlinkApiKey;
            this.UplinkMessage = new WebhookMessageCriteria(path: uplinkMessagePath);
            this.JoinAccept = new WebhookMessageCriteria(path: joinAcceptPath);
            this.DownlinkAck = new WebhookMessageCriteria(path: downlinkAckPath);
            this.DownlinkNack = new WebhookMessageCriteria(path: downlinkNackPath);
            this.DownlinkSent = new WebhookMessageCriteria(path: downlinkSentPath);
            this.DownlinkFailed = new WebhookMessageCriteria(path: downlinkFailedPath);
            this.DownlinkQueued = new WebhookMessageCriteria(path: downlinkQueuedPath);
            this.DownlinkQueueInvalidated = new WebhookMessageCriteria(path: downlinkQueueInvalidatedPath);
            this.LocationSolved = new WebhookMessageCriteria(path: locationSolvedPath);
            this.ServiceData = new WebhookMessageCriteria(path: serviceDataPath);
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Webhook Identifier
        /// </summary>
        [JsonProperty("ids")]
        public WebhookIdentifiersCriteria Ids { get; set; }

        /// <summary>
        /// Base URL to which the message’s path is appended.
        /// </summary>
        [JsonProperty("base_url")]
        public string BaseUrl { get; set; }

        /// <summary>
        /// HTTP headers to use.
        /// </summary>
        [JsonProperty("headers")]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// The format to use for the body. Supported values depend on the Application Server configuration.
        /// </summary>
        [JsonProperty("format")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WebhookFormats Format { get; set; }

        /// <summary>
        /// The ID of the template that was used to create the Webhook.
        /// </summary>
        [JsonProperty("template_ids.template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// The value of the fields used by the template. Maps field.id to the value.
        /// </summary>
        [JsonProperty("template_fields")]
        public Dictionary<string, string> TemplateFields { get; set; }

        /// <summary>
        /// The API key to be used for downlink queue operations. The field is provided for convenience reasons, and can contain API keys with additional rights (albeit this is discouraged).
        /// </summary>
        [JsonProperty("downlink_api_key")]
        public string DownlinkApiKey { get; set; }

        /// <summary>
        /// Path to append to the base URL.
        /// </summary>
        [JsonProperty("uplink_message")]
        public WebhookMessageCriteria UplinkMessage { get; set; }

        /// <summary>
        /// Path to append to the base URL.
        /// </summary>
        [JsonProperty("join_accept")]
        public WebhookMessageCriteria JoinAccept { get; set; }

        /// <summary>
        /// Path to append to the base URL.
        /// </summary>
        [JsonProperty("downlink_ack")]
        public WebhookMessageCriteria DownlinkAck { get; set; }

        /// <summary>
        /// Path to append to the base URL.
        /// </summary>
        [JsonProperty("downlink_nack")]
        public WebhookMessageCriteria DownlinkNack { get; set; }

        /// <summary>
        /// Path to append to the base URL.
        /// </summary>
        [JsonProperty("downlink_sent")]
        public WebhookMessageCriteria DownlinkSent { get; set; }

        /// <summary>
        /// Path to append to the base URL.
        /// </summary>
        [JsonProperty("downlink_failed")]
        public WebhookMessageCriteria DownlinkFailed { get; set; }

        /// <summary>
        /// Path to append to the base URL.
        /// </summary>
        [JsonProperty("downlink_queued")]
        public WebhookMessageCriteria DownlinkQueued { get; set; }

        /// <summary>
        /// Path to append to the base URL.
        /// </summary>
        [JsonProperty("downlink_queue_invalidated")]
        public WebhookMessageCriteria DownlinkQueueInvalidated { get; set; }

        /// <summary>
        /// Path to append to the base URL.
        /// </summary>
        [JsonProperty("location_solved")]
        public WebhookMessageCriteria LocationSolved { get; set; }

        /// <summary>
        /// Path to append to the base URL.
        /// </summary>
        [JsonProperty("service_data")]
        public WebhookMessageCriteria ServiceData { get; set; }

        #endregion Properties
    }
}
