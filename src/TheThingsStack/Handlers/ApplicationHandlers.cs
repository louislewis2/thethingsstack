namespace TheThingsStack
{
    using System.Threading.Tasks;

    using Api.Rights;
    using Api.Devices.ViewModels;
    using Api.ApiKeys.ViewModels;
    using Api.Applications.ViewModels;

    public static class ApplicationHandlers
    {
        #region Fields

        private const string resourceUrl = "applications";

        #endregion Fields

        #region Methods

        public static async Task<Application> GetApplication(this TheThingsStackIntegrationClient thingsStackIntegrationClient, string applicationId)
        {
            return await thingsStackIntegrationClient.GetAsync<Application>(resourceUrl: $"{resourceUrl}/{applicationId}", queryString: "field_mask=name,description");
        }

        /// <summary>
        /// List the rights the caller has on this application.
        /// </summary>
        public static async Task<Right> GetApplicationRights(this TheThingsStackIntegrationClient thingsStackIntegrationClient, string applicationId)
        {
            return await thingsStackIntegrationClient.GetAsync<Right>(resourceUrl: $"{resourceUrl}/{applicationId}/rights", queryString: null);
        }

        /// <summary>
        /// List the api keys on this application.
        /// </summary>
        public static async Task<ApiKeys> GetApplicationApiKeys(this TheThingsStackIntegrationClient thingsStackIntegrationClient, string applicationId)
        {
            return await thingsStackIntegrationClient.GetAsync<ApiKeys>(resourceUrl: $"{resourceUrl}/{applicationId}/api-keys", queryString: null);
        }

        /// <summary>
        /// List the applications
        /// </summary>
        public static async Task<Applications> GetApplications(this TheThingsStackIntegrationClient thingsStackIntegrationClient)
        {
            return await thingsStackIntegrationClient.GetAsync<Applications>(resourceUrl: resourceUrl, queryString: "field_mask=name,description");
        }

        public static async Task<Devices> GetApplicationDevices(this TheThingsStackIntegrationClient thingsStackIntegrationClient, string applicationId)
        {
            return await thingsStackIntegrationClient.GetAsync<Devices>(resourceUrl: $"{resourceUrl}/{applicationId}/devices", queryString: "field_mask=name,description");
        }

        #endregion Methods
    }
}
