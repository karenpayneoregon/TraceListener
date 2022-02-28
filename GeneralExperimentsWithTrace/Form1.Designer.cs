namespace GeneralExperimentsWithTrace
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.GetListenerPropertiesButton = new System.Windows.Forms.Button();
            this.CastingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetListenerPropertiesButton
            // 
            this.GetListenerPropertiesButton.Location = new System.Drawing.Point(25, 14);
            this.GetListenerPropertiesButton.Name = "GetListenerPropertiesButton";
            this.GetListenerPropertiesButton.Size = new System.Drawing.Size(330, 23);
            this.GetListenerPropertiesButton.TabIndex = 0;
            this.GetListenerPropertiesButton.Text = "Create Log: Get name and log file name";
            this.GetListenerPropertiesButton.UseVisualStyleBackColor = true;
            this.GetListenerPropertiesButton.Click += new System.EventHandler(this.GetListenerPropertiesButton_Click);
            // 
            // CastingButton
            // 
            this.CastingButton.Location = new System.Drawing.Point(25, 43);
            this.CastingButton.Name = "CastingButton";
            this.CastingButton.Size = new System.Drawing.Size(330, 23);
            this.CastingButton.TabIndex = 1;
            this.CastingButton.Text = "Casting";
            this.CastingButton.UseVisualStyleBackColor = true;
            this.CastingButton.Click += new System.EventHandler(this.CastingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 175);
            this.Controls.Add(this.CastingButton);
            this.Controls.Add(this.GetListenerPropertiesButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logging";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetListenerPropertiesButton;
        private System.Windows.Forms.Button CastingButton;
    }
}

