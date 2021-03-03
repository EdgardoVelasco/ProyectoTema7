using System;
using System.Collections.Generic;
using System.Text;
using Azure.AI.TextAnalytics;
using AppModulo7.keyvault;
using Azure;

namespace AppModulo7.text
{
    class TextClient
    {

        private static readonly string ENDPOINT = "<<agrega el enpoint del api TextAnalytics de java>>";
        public static TextAnalyticsClient Text { get; private set; }

        static TextClient() { InitText(); }

        private static void InitText() {
            if (Text==null) {
                var key = KeyClient.Secret.GetSecret("<<Nombre de secret en KeyVault>>").Value.Value;
                var credential = new AzureKeyCredential(key);
                Text = new TextAnalyticsClient(new Uri(ENDPOINT), credential);
            }
        }
    }
}
