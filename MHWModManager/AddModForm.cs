using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MHWModManager
{
    public partial class AddModForm : Form
    {

        private Label modsLabel;
        
        public AddModForm(Label modsLabel)
        {
            InitializeComponent();
            this.modsLabel = modsLabel;
        }

        private void addModButton_Click(object sender, EventArgs e)
        {
            String url = urlTextBox.Text;

            String result = GetIDFromURL(url);
            if (result == null)
            {
                String message = "It should look like: https://www.nexusmods.com/monsterhunterworld/mods/XXX";
                String caption = "Invalid URL format";

                MessageBox.Show(message, caption);
                return;
            }
            
            String uri = $"https://api.nexusmods.com/v1/games/monsterhunterworld/mods/{result}.json";
            String requestReturn = "";
            try
            { 
                requestReturn = Http.Get(uri);
            }
            catch (System.Net.WebException webException)
            {
                if (webException.Message.Contains("404"))
                {
                    String message = "Please make sure the URL is correct";
                    String caption = "Mod not found";

                    MessageBox.Show(message, caption);
                    return;
                }
            }

            dynamic json = JsonConvert.DeserializeObject(requestReturn);
            String name = json.name;
            Console.WriteLine(name);
            modsLabel.Text = name;
        }

        private String GetIDFromURL(String url)
        {
            String nexusModHead = "https://www.nexusmods.com/monsterhunterworld/mods/";
            if (!url.Contains(nexusModHead)) return null;
            int pFrom = url.IndexOf(nexusModHead, StringComparison.Ordinal) + nexusModHead.Length;
            int pTo = url.LastIndexOf("?", StringComparison.Ordinal);

            return url.Contains("?") ? url.Substring(pFrom, pTo - pFrom) : url.Substring(pFrom, url.Length - pFrom);
        }
    }
}