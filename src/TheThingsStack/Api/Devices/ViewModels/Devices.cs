namespace TheThingsStack.Api.Devices.ViewModels
{
    using Newtonsoft.Json;

    public class Devices
    {
        #region Properties

        [JsonProperty("end_devices")]
        public Device[] Items { get; set; }

        #endregion Properties
    }
}
