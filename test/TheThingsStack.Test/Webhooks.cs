namespace TheThingsStack.Test
{
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Api.Webhooks.Enums;
    using Api.Webhooks.Criteria;

    [TestClass]
    public class Webhooks : TestBase
    {
        #region Fields

        private const string applicationId = "dev-application";

        #endregion Fields

        #region Methods

        [TestMethod]
        public async Task Can_Load_Webhooks()
        {
            // Arrange
            var client = this.GetClient();

            // Act
            var webhooks = await client.GetApplicationWebhooks(applicationId: applicationId);

            // Assert
            Assert.IsNotNull(value: webhooks, message: "webhooks is expected to not be null");
        }

        [TestMethod]
        public async Task Can_Create_Webhook()
        {
            // Arrange
            var client = this.GetClient();
            var setWebhookCriteria = new SetWebhookCriteria(
                id: "test-webhook",
                applicationId: applicationId,
                baseUrl: "https://test-webhook.test-site.com/",
                headers: new Dictionary<string, string> { { "Authorization", "Bearer 123456" } },
                format: WebhookFormats.json,
                templateId: string.Empty,
                templateFields: null,
                downlinkApiKey: string.Empty,
                uplinkMessagePath: string.Empty,
                joinAcceptPath: string.Empty,
                downlinkAckPath: string.Empty,
                downlinkNackPath: string.Empty,
                downlinkSentPath: string.Empty,
                downlinkFailedPath: string.Empty,
                downlinkQueuedPath: string.Empty,
                downlinkQueueInvalidatedPath: string.Empty,
                locationSolvedPath: string.Empty,
                serviceDataPath: string.Empty);

            // Act
            var createWebhookResponse = await client.CreateApplicationWebhook(applicationId: applicationId, setWebhookCriteria: setWebhookCriteria);

            // Assert
            Assert.IsNotNull(value: createWebhookResponse, message: "createWebhookResponse is expected to not be null");
        }

        [TestMethod]
        public async Task Can_Update_Webhook()
        {
            // Arrange
            var client = this.GetClient();
            var setWebhookCriteria = new SetWebhookCriteria(
                id: "test-webhook",
                applicationId: applicationId,
                baseUrl: "https://test-webhook.test-site.com/",
                headers: new Dictionary<string, string> { { "Authorization", "Bearer 123456" } },
                format: WebhookFormats.json,
                templateId: string.Empty,
                templateFields: null,
                downlinkApiKey: string.Empty,
                uplinkMessagePath: string.Empty,
                joinAcceptPath: string.Empty,
                downlinkAckPath: string.Empty,
                downlinkNackPath: string.Empty,
                downlinkSentPath: string.Empty,
                downlinkFailedPath: string.Empty,
                downlinkQueuedPath: string.Empty,
                downlinkQueueInvalidatedPath: string.Empty,
                locationSolvedPath: string.Empty,
                serviceDataPath: string.Empty);

            var createWebhookResponse = await client.CreateApplicationWebhook(applicationId: applicationId, setWebhookCriteria: setWebhookCriteria);

            setWebhookCriteria.UplinkMessage = new WebhookMessageCriteria("/some-path");

            // Act
            var updateWebhookResponse = await client.UpdateApplicationWebhook(webhookId: createWebhookResponse.Id, applicationId: applicationId, setWebhookCriteria: setWebhookCriteria);

            // Assert
            Assert.IsNotNull(value: updateWebhookResponse, message: "updateWebhookResponse is expected to not be null");
            Assert.AreEqual(expected: setWebhookCriteria.UplinkMessage.Path, actual: updateWebhookResponse.UplinkMessagePath);
        }

        [TestMethod]
        public async Task Can_Load_Webhook()
        {
            // Arrange
            var client = this.GetClient();
            var setWebhookCriteria = new SetWebhookCriteria(
               id: "test-webhook",
               applicationId: applicationId,
               baseUrl: "https://test-webhook.test-site.com/",
               headers: new Dictionary<string, string> { { "Authorization", "Bearer 123456" } },
               format: WebhookFormats.json,
               templateId: string.Empty,
               templateFields: null,
               downlinkApiKey: string.Empty,
               uplinkMessagePath: string.Empty,
               joinAcceptPath: string.Empty,
               downlinkAckPath: string.Empty,
               downlinkNackPath: string.Empty,
               downlinkSentPath: string.Empty,
               downlinkFailedPath: string.Empty,
               downlinkQueuedPath: string.Empty,
               downlinkQueueInvalidatedPath: string.Empty,
               locationSolvedPath: string.Empty,
               serviceDataPath: string.Empty);

            var createWebhookResponse = await client.CreateApplicationWebhook(applicationId: applicationId, setWebhookCriteria: setWebhookCriteria);

            // Act
            var webhook = await client.GetApplicationWebhook(webhookId: createWebhookResponse.Id, applicationId: applicationId);

            // Assert
            Assert.IsNotNull(value: webhook, message: "webhook is expected to not be null");
        }

        [TestMethod]
        public async Task Can_Delete_Webhook()
        {
            // Arrange
            var client = this.GetClient();
            var setWebhookCriteria = new SetWebhookCriteria(
                id: "test-webhook",
                applicationId: applicationId,
                baseUrl: "https://test-webhook.test-site.com/",
                headers: new Dictionary<string, string> { { "Authorization", "Bearer 123456" } },
                format: WebhookFormats.json,
                templateId: string.Empty,
                templateFields: null,
                downlinkApiKey: string.Empty,
                uplinkMessagePath: string.Empty,
                joinAcceptPath: string.Empty,
                downlinkAckPath: string.Empty,
                downlinkNackPath: string.Empty,
                downlinkSentPath: string.Empty,
                downlinkFailedPath: string.Empty,
                downlinkQueuedPath: string.Empty,
                downlinkQueueInvalidatedPath: string.Empty,
                locationSolvedPath: string.Empty,
                serviceDataPath: string.Empty);

            var createWebhookResponse = await client.CreateApplicationWebhook(applicationId: applicationId, setWebhookCriteria: setWebhookCriteria);

            // Act
            var deleteWebhookResponse = await client.DeleteApplicationWebhook(webhookId: createWebhookResponse.Id, applicationId: applicationId);

            // Assert
            Assert.IsTrue(condition: deleteWebhookResponse, message: "deleteWebhookResponse is expected to be true");
        }

        #endregion Methods
    }
}
