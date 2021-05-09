namespace TheThingsStack.Api.Rights
{
    using Newtonsoft.Json;

    using Enums;

    public class Right
    {
        #region Properties

        [JsonProperty("rights")]
        public RightTypes[] Rights { get; set; }

        #endregion Properties
    }
}
