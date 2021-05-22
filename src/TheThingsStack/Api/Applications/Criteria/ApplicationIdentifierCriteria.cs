namespace TheThingsStack.Api.Applications.Criteria
{
    using Newtonsoft.Json;

    /// <summary>
    /// https://www.thethingsindustries.com/docs/reference/api/application/#message:ApplicationIdentifiers
    /// </summary>
    public class ApplicationIdentifierCriteria
    {
        #region Constructor

        public ApplicationIdentifierCriteria() { }

        public ApplicationIdentifierCriteria(string applicationId)
        {
            this.ApplicationId = applicationId;
        }

        #endregion Constructor

        #region Properties

        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }

        #endregion Properties
    }
}
