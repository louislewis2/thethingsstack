namespace TheThingsStack
{
    using System.Threading.Tasks;

    using Api.Shared.Criteria;
    using Api.Webhooks.Criteria;
    using Api.Webhooks.ViewModels;

    public static class WebhookHandlers
    {
        #region Fields

        private const string resourceUrl = "as/webhooks";

        #endregion Fields

        #region Methods

        public static async Task<Webhooks> GetApplicationWebhooks(this TheThingsStackIntegrationClient thingsStackIntegrationClient, string applicationId)
        {
            var queryString = "field_mask=headers,downlink_api_key,uplink_message,join_accept,downlink_ack,downlink_nack,downlink_sent,downlink_failed,downlink_queued,downlink_queue_invalidated,location_solved,service_data";
            return await thingsStackIntegrationClient.GetAsync<Webhooks>(resourceUrl: $"{resourceUrl}/{applicationId}", queryString: queryString);
        }

        public static async Task<Webhook> GetApplicationWebhook(this TheThingsStackIntegrationClient thingsStackIntegrationClient, string webhookId, string applicationId)
        {
            var queryString = "field_mask=headers,downlink_api_key,uplink_message,join_accept,downlink_ack,downlink_nack,downlink_sent,downlink_failed,downlink_queued,downlink_queue_invalidated,location_solved,service_data";
            return await thingsStackIntegrationClient.GetAsync<Webhook>(resourceUrl: $"{resourceUrl}/{applicationId}/{webhookId}", queryString: queryString);
        }

        public static async Task<Webhook> CreateApplicationWebhook(this TheThingsStackIntegrationClient thingsStackIntegrationClient, string applicationId, SetWebhookCriteria setWebhookCriteria)
        {
            var fieldMasks = new[] {
            "base_url",
            "downlink_ack",
            "downlink_api_key",
            "downlink_failed",
            "downlink_nack",
            "downlink_queue_invalidated",
            "downlink_queued",
            "downlink_sent",
            "format",
            "headers",
            "ids",
            "ids.application_ids",
            "ids.application_ids.application_id",
            "ids.webhook_id",
            "join_accept",
            "location_solved",
            "service_data",
            "uplink_message",
            "uplink_message.path"};

            var data = new SetWebhookRequestCriteria(setWebhookCriteria: setWebhookCriteria, fieldMask: new FieldMaskCriteria(fieldMasks));
            return await thingsStackIntegrationClient.PostAsync<Webhook>(resourceUrl: $"{resourceUrl}/{applicationId}", data: data);
        }
        public static async Task<Webhook> UpdateApplicationWebhook(this TheThingsStackIntegrationClient thingsStackIntegrationClient, string webhookId, string applicationId, SetWebhookCriteria setWebhookCriteria)
        {
            var fieldMasks = new[] {
            "base_url",
            "downlink_ack",
            "downlink_api_key",
            "downlink_failed",
            "downlink_nack",
            "downlink_queue_invalidated",
            "downlink_queued",
            "downlink_sent",
            "format",
            "headers",
            "ids",
            "ids.application_ids",
            "ids.application_ids.application_id",
            "ids.webhook_id",
            "join_accept",
            "location_solved",
            "service_data",
            "uplink_message",
            "uplink_message.path"};

            var data = new SetWebhookRequestCriteria(setWebhookCriteria: setWebhookCriteria, fieldMask: new FieldMaskCriteria(fieldMasks));
            return await thingsStackIntegrationClient.PutAsync<Webhook>(resourceUrl: $"{resourceUrl}/{applicationId}/{webhookId}", data: data);
        }

        public static async Task<bool> DeleteApplicationWebhook(this TheThingsStackIntegrationClient thingsStackIntegrationClient, string webhookId, string applicationId)
        {
            return await thingsStackIntegrationClient.DeleteAsync(resourceUrl: $"{resourceUrl}/{applicationId}/{webhookId}");
        }

        #endregion Methods
    }
}
