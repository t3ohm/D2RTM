using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokenManager
{
    public partial class RefreshAccountToken : Form
    {
        public string Token { get; set; } = null;
        private string User { get; set; } = null;
        private string Pass { get; set; } = null;
        public RefreshAccountToken(string user="diablo4life@Dmail.com", string pass=null)
        {   
            User = user;
            Pass = pass;
            InitializeComponent2();
            InitializeWebView2();
            DialogResult = DialogResult.Cancel;
        }

        public async void InitializeWebView2()
        {
            var userDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Constants.SelfTitle);
            var env = await CoreWebView2Environment.CreateAsync(null, userDataFolder);
            await webView2.EnsureCoreWebView2Async(env);
        }

        private void webView2_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            webView2.CoreWebView2.CookieManager.DeleteAllCookies();
            webView2.CoreWebView2.DOMContentLoaded += webView2_DOMContentLoaded;
            //region doesnt matter, token is reusable on all regions
            webView2.CoreWebView2.Navigate(@"https://us.battle.net/login/en/?externalChallenge=login&app=OSI");
        }

        private async void webView2_DOMContentLoaded(object sender, CoreWebView2DOMContentLoadedEventArgs e)
        {
            if (webView2.Source.ToString().Contains("battle.net/login"))
            {
                //fill in username
                await webView2.ExecuteScriptAsync($"document.querySelector('#accountName').value = '" + User + "'");
                if (Pass != null)
                {
                    //fill in password
                    await webView2.ExecuteScriptAsync($"document.querySelector('#password').value = '" + Pass + "'");
                    
                    //Check for Verification
                    string html = await webView2.ExecuteScriptAsync("document.documentElement.outerHTML;");
                    if (html.Contains("Security"))
                    {
                        //Debug("We triggered security check");
                        return;
                    }
                    else
                    {
                        //click login   
                        await webView2.ExecuteScriptAsync("document.getElementById('submit').click();");
                    }
                }
            }
        }

        private void webView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            //after a successful login you are redirected to localhost. the token is a query param 'ST'
            if (webView2.Source.ToString().Contains("localhost"))
            {
                var query = webView2.Source.Query;
                int idx = query.IndexOf("ST=");
                //tokens are 44 chars, format US-xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx-xxxxxxxx
                Token = query.Substring(idx + 3, 44);
                DialogResult = DialogResult.OK;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RefreshAccountToken
            // 
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(624, 546);
            this.ControlBox = false;
            this.Name = "RefreshAccountToken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }
    }
}