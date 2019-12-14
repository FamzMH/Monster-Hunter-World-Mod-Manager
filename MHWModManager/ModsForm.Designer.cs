namespace MHWModManager
{
    partial class ModsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.addModButton = new System.Windows.Forms.Button();
            this.modsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addModButton
            // 
            this.addModButton.Location = new System.Drawing.Point(12, 12);
            this.addModButton.Name = "addModButton";
            this.addModButton.Size = new System.Drawing.Size(101, 46);
            this.addModButton.TabIndex = 0;
            this.addModButton.Text = "Add mod";
            this.addModButton.UseVisualStyleBackColor = true;
            this.addModButton.Click += new System.EventHandler(this.addModButton_Click);
            // 
            // modsLabel
            // 
            this.modsLabel.Location = new System.Drawing.Point(10, 75);
            this.modsLabel.Name = "modsLabel";
            this.modsLabel.Size = new System.Drawing.Size(302, 29);
            this.modsLabel.TabIndex = 1;
            // 
            // ModsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.modsLabel);
            this.Controls.Add(this.addModButton);
            this.Name = "ModsForm";
            this.Text = "Monster Hunter World Mod Manager";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button addModButton;
        private System.Windows.Forms.Label modsLabel;
    }
}