using System.ComponentModel;

namespace MHWModManager
{
    partial class AddModForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.modURLLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.addModButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modURLLabel
            // 
            this.modURLLabel.Location = new System.Drawing.Point(13, 12);
            this.modURLLabel.Name = "modURLLabel";
            this.modURLLabel.Size = new System.Drawing.Size(173, 23);
            this.modURLLabel.TabIndex = 0;
            this.modURLLabel.Text = "Nexusmods Mod URL:";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(13, 47);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(475, 23);
            this.urlTextBox.TabIndex = 1;
            // 
            // addModButton
            // 
            this.addModButton.Location = new System.Drawing.Point(494, 47);
            this.addModButton.Name = "addModButton";
            this.addModButton.Size = new System.Drawing.Size(87, 22);
            this.addModButton.TabIndex = 2;
            this.addModButton.Text = "Add";
            this.addModButton.UseVisualStyleBackColor = true;
            this.addModButton.Click += new System.EventHandler(this.addModButton_Click);
            // 
            // AddModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 102);
            this.Controls.Add(this.addModButton);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.modURLLabel);
            this.Name = "AddModForm";
            this.Text = "Add Mod";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label modURLLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button addModButton;
    }
}