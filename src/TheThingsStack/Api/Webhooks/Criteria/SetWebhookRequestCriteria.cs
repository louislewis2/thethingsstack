namespace TheThingsStack.Api.Webhooks.Criteria
{
    using Newtonsoft.Json;

    using Shared.Criteria;

    public class SetWebhookRequestCriteria
    {
        #region Constructor

        public SetWebhookRequestCriteria() { }

        public SetWebhookRequestCriteria(SetWebhookCriteria setWebhookCriteria, FieldMaskCriteria fieldMask)
        {
            this.SetWebhookCriteria = setWebhookCriteria;
            this.FieldMask = fieldMask;
        }

        #endregion Constructor

        #region Properties

        [JsonProperty("webhook")]
        public SetWebhookCriteria SetWebhookCriteria { get; set; }

        [JsonProperty("field_mask")]
        public FieldMaskCriteria FieldMask { get; set; }

        #endregion Properties
    }
}
