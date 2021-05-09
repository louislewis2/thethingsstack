namespace TheThingsStack.Test
{
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Applications : TestBase
    {
        #region Fields

        private const string applicationId = "dev-application";

        #endregion Fields

        #region Methods

        [TestMethod]
        public async Task Can_Load_Application()
        {
            // Arrange
            var client = this.GetClient();

            // Act
            var application = await client.GetApplication(applicationId: applicationId);

            // Assert
            Assert.IsNotNull(value: application, message: "application is expected to not be null");
        }

        [TestMethod]
        public async Task Can_Load_Application_Rights()
        {
            // Arrange
            var client = this.GetClient();

            // Act
            var rights = await client.GetApplicationRights(applicationId: applicationId);

            // Assert
            Assert.IsNotNull(value: rights, message: "rights is expected to not be null");
        }

        [TestMethod]
        public async Task Can_Load_Application_ApiKeys()
        {
            // Arrange
            var client = this.GetClient();

            // Act
            var apiKeys = await client.GetApplicationApiKeys(applicationId: applicationId);

            // Assert
            Assert.IsNotNull(value: apiKeys, message: "apiKeys is expected to not be null");
        }

        [TestMethod]
        public async Task Can_Load_Applications()
        {
            // Arrange
            var client = this.GetClient();

            // Act
            var applications = await client.GetApplications();

            // Assert
            Assert.IsNotNull(value: applications, message: "applications is expected to not be null");
        }

        [TestMethod]
        public async Task Can_Load_Application_Devices()
        {
            // Arrange
            var client = this.GetClient();

            // Act
            var devices = await client.GetApplicationDevices(applicationId: applicationId);

            // Assert
            Assert.IsNotNull(value: devices, message: "devices is expected to not be null");
        }

        #endregion Methods
    }
}
