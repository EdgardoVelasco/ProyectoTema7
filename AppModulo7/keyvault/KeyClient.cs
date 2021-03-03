using System;
using System.Collections.Generic;
using System.Text;
using Azure.Security.KeyVault.Secrets;
using Azure.Identity;

namespace AppModulo7.keyvault
{
    class KeyClient
    {
        private static readonly string CLIENT_ID = "<<AppRegistrationClientID>>";
        private static readonly string TENANT_ID = "<<AppRegistrationTenantID>>";
        private static readonly string SECRET_CLIENT = "<<SecretAppRegistration>>";
        private static readonly string KEYVAULT = "<<URLKeyVaultService>>";
        public static SecretClient Secret { get; private set;}
        static KeyClient() { InitSecret(); }

        private static void InitSecret() {
            if (Secret == null)
            {
                var credential = new ClientSecretCredential(TENANT_ID, CLIENT_ID, SECRET_CLIENT);
                Secret = new SecretClient(new Uri(KEYVAULT), credential);
            }
        }   
            
       
    }
}
