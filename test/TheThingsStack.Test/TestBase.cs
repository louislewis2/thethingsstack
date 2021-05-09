namespace TheThingsStack.Test
{
    using System;

    public class TestBase
    {
        #region Constructor

        public TestBase()
        {
            this.Random = new Random();
        }

        #endregion Constructor

        #region Properties

        public string Url = "https://eu1.cloud.thethings.network/";
        public string Token = ""; // Remove Value Before Commiting Code
        public Random Random { get; }

        #endregion Properties

        #region Methods

        public TheThingsStackIntegrationClient GetClient()
        {
            if (string.IsNullOrWhiteSpace(value: this.Url) || string.IsNullOrWhiteSpace(value: this.Token))
            {
                throw new Exception(message: "Credentials Missing In TestBase.cs");
            }

            return new TheThingsStackIntegrationClient(baseUrl: this.Url, token: this.Token);
        }

        #endregion Methods
    }
}
