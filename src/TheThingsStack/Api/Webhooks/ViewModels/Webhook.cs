namespace TheThingsStack.Api.Webhooks.ViewModels
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    using Enums;
    using Converters;

    [JsonConverter(typeof(JsonPathConverter))]
    public class Webhook : ViewModelBase
    {
        #region Properties

        [JsonProperty("ids.webhook_id")]
        public string Id { get; set; }

        [JsonProperty("ids.application_ids.application_id")]
        public string ApplicationId { get; set; }

        [JsonProperty("base_url")]
        public string BaseUrl { get; set; }

        [JsonProperty("headers")]
        public Dictionary<string, string> Headers { get; set; }

        [JsonProperty("format")]
        public WebhookFormats Format { get; set; }

        [JsonProperty("template_ids.template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("template_fields")]
        public Dictionary<string, string> TemplateFields { get; set; }

        [JsonProperty("downlink_api_key")]
        public string DownlinkApiKey { get; set; }

        [JsonProperty("uplink_message.path")]
        public string UplinkMessagePath { get; set; }

        [JsonProperty("join_accept.path")]
        public string JoinAcceptPath { get; set; }

        [JsonProperty("downlink_ack.path")]
        public string DownlinkAckPath { get; set; }

        [JsonProperty("downlink_nack.path")]
        public string DownlinkNackPath { get; set; }

        [JsonProperty("downlink_sent.path")]
        public string DownlinkSentPath { get; set; }

        [JsonProperty("downlink_failed.path")]
        public string DownlinkFailedPath { get; set; }

        [JsonProperty("downlink_queued.path")]
        public string DownlinkQueuedPath { get; set; }

        [JsonProperty("downlink_queue_invalidated.path")]
        public string DownlinkQueueInvalidatedPath { get; set; }

        [JsonProperty("location_solved.path")]
        public string LocationSolvedPath { get; set; }

        [JsonProperty("service_data.path")]
        public string ServiceDataPath { get; set; }

        #endregion Properties
    }
}
