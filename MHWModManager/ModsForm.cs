using System;
using System.Windows.Forms;


namespace MHWModManager
{
    public partial class ModsForm : Form
    {
        public ModsForm()
        {
            InitializeComponent();
        }

        private void addModButton_Click(object sender, EventArgs e)
        {
            AddModForm addModForm = new AddModForm(this.modsLabel);
            addModForm.Show();
        }
    }
}