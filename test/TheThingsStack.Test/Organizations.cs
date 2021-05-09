namespace TheThingsStack.Test
{
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Organizations : TestBase
    {
        #region Fields

        private const string organizationId = "sample-organization";

        #endregion Fields

        #region Methods

        [TestMethod]
        public async Task Can_Load_Organization()
        {
            // Arrange
            var client = this.GetClient();

            // Act
            var organization = await client.GetOrganization(organizationId: organizationId);

            // Assert
            Assert.IsNotNull(value: organization, message: "organization is expected to not be null");
        }

        [TestMethod]
        public async Task Can_Load_Organization_Rights()
        {
            // Arrange
            var client = this.GetClient();

            // Act
            var rights = await client.GetOrganizationRights(organizationId: organizationId);

            // Assert
            Assert.IsNotNull(value: rights, message: "rights is expected to not be null");
        }

        [TestMethod]
        public async Task Can_Load_Organization_ApiKeys()
        {
            // Arrange
            var client = this.GetClient();

            // Act
            var apiKeys = await client.GetOrganizationApiKeys(organizationId: organizationId);

            // Assert
            Assert.IsNotNull(value: apiKeys, message: "apiKeys is expected to not be null");
        }

        [TestMethod]
        public async Task Can_Load_Organization_Applications()
        {
            // Arrange
            var client = this.GetClient();

            // Act
            var applications = await client.GetOrganizationApplications(organizationId: organizationId);

            // Assert
            Assert.IsNotNull(value: applications, message: "applications is expected to not be null");
        }

        #endregion Methods
    }
}
