
namespace ex31stapp3
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
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Location = new System.Drawing.Point(59, 38);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(422, 31);
            this.filenameTextBox.TabIndex = 0;
            this.filenameTextBox.Text = "Z:\\OneDrive - Savonia-ammattikorkeakoulu\\Work.syksy2020\\opetus\\EF20SP_BasicsOfPro" +
    "gramming\\slides\\projects\\IntroductionToProgrammingInC\\RPS\\examplerand01.c";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(487, 28);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(240, 50);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(59, 94);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(708, 344);
            this.outputTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.filenameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

