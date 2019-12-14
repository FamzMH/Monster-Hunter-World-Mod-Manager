using System;
using System.Windows.Forms;


namespace MHWModManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            String uri =
                @"https://api.nexusmods.com/v1/games/monsterhunterworld/mods/latest_updated.json";
            String requestReturn = Http.Get(uri);
            requestLabel.Text = requestReturn;
        }
    }
}