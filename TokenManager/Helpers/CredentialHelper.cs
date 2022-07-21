#nullable enable
using TokenManager.Modules;
using TokenManager.Structs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenManager.Helpers
{
    public static class CredentialHelper
    {
        public static Credentials? GetVaultCredentials(string displayName)
        {
            var bnetCredentials = Vault.GetCredential(Constants.ProfilePrefix + displayName);
            var username = "";
            var password = "";
            Debug.WriteLine("Disp: " + displayName + " User: " + bnetCredentials?.User + " Pass: 12345");
            //if (bnetCredentials == null || (bnetCredentials?.User?.Length < 3 || bnetCredentials?.Pass?.Length < 3))
            if (bnetCredentials == null || bnetCredentials?.User?.Length == null)
            {
                // The user has input some crap into the credentials, just delete and ask again
                Vault.RemoveCredentials(Constants.ProfilePrefix + displayName);
                Debug.WriteLine("Requesting username");
                //;
                if ((username = Prompt.ShowDialog("Enter your battle.net username: ", "Only needed for AutoRefresh")) != null)
                {
                    Debug.WriteLine("Requesting password");
                    if ((password = Prompt.ShowDialog("Enter your battle.net password: ", "Only needed for AutoRefresh", true)) != null)
                    {
                        Debug.WriteLine("Saving credentials in store");
                    }
                }
                if (username != null)
                {
                    Vault.SetCredentials(Constants.ProfilePrefix + displayName, username, password); // Save credentials in windows credential store on local computer
                }
                bnetCredentials = Vault.GetCredential(Constants.ProfilePrefix + displayName);
            }
            return bnetCredentials;
        }
        public static bool RemoveVaultCredentials(string displayName)
        {
            var bnetCredentials = Vault.GetCredential(Constants.ProfilePrefix + displayName);
            Debug.WriteLine("Disp: " + displayName + " User: " + bnetCredentials?.User + " Pass: 12345");
            if (bnetCredentials != null)
            {
                Vault.RemoveCredentials(Constants.ProfilePrefix + displayName);
                return true;
            }
            return false;
        
        }
    }
}
