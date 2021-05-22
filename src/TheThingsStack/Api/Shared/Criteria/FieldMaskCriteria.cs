namespace TheThingsStack.Api.Shared.Criteria
{
    using Newtonsoft.Json;

    public class FieldMaskCriteria
    {
        #region Constructor

        public FieldMaskCriteria() { }

        public FieldMaskCriteria(string[] paths)
        {
            this.Paths = paths;
        }

        #endregion Constructor

        #region Properties

        [JsonProperty("paths")]
        public string[] Paths { get; set; }

        #endregion Properties
    }
}
