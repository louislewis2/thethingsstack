using Newtonsoft.Json;
using TheThingsStack.Converters;

namespace TheThingsStack.Api.Devices.ViewModels
{
    [JsonConverter(typeof(JsonPathConverter))]
    public class Device : ViewModelBase
    {
        #region Properties

        [JsonProperty("ids.device_id")]
        public string Id { get; set; }

        [JsonProperty("ids.application_ids.application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The LoRaWAN DevEUI.
        /// </summary>
        [JsonProperty("ids.dev_eui")]
        public string DeviceEui { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        #endregion Properties
    }
}
