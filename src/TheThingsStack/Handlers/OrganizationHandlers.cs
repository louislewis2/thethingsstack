namespace TheThingsStack
{
    using System.Threading.Tasks;

    using Api.Rights;
    using Api.ApiKeys.ViewModels;
    using Api.Applications.ViewModels;
    using Api.Organizations.ViewModels;

    public static class OrganizationHandlers
    {
        #region Fields

        private const string resourceUrl = "organizations";

        #endregion Fields

        #region Methods

        public static async Task<Organization> GetOrganization(this TheThingsStackIntegrationClient thingsStackIntegrationClient, string organizationId)
        {
            return await thingsStackIntegrationClient.GetAsync<Organization>(resourceUrl: $"{resourceUrl}/{organizationId}", queryString: "field_mask=name,description");
        }

        /// <summary>
        /// List the rights the caller has on this organization.
        /// </summary>
        public static async Task<Right> GetOrganizationRights(this TheThingsStackIntegrationClient thingsStackIntegrationClient, string organizationId)
        {
            return await thingsStackIntegrationClient.GetAsync<Right>(resourceUrl: $"{resourceUrl}/{organizationId}/rights", queryString: null);
        }

        /// <summary>
        /// List the api keys on this organization.
        /// </summary>
        public static async Task<ApiKeys> GetOrganizationApiKeys(this TheThingsStackIntegrationClient thingsStackIntegrationClient, string organizationId)
        {
            return await thingsStackIntegrationClient.GetAsync<ApiKeys>(resourceUrl: $"{resourceUrl}/{organizationId}/api-keys", queryString: null);
        }

        /// <summary>
        /// List the applications on this organization.
        /// </summary>
        public static async Task<Applications> GetOrganizationApplications(this TheThingsStackIntegrationClient thingsStackIntegrationClient, string organizationId)
        {
            return await thingsStackIntegrationClient.GetAsync<Applications>(resourceUrl: $"{resourceUrl}/{organizationId}/applications", queryString: "field_mask=name,description");
        }

        #endregion Methods
    }
}
