namespace CopyOnGitHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.thanks = new System.Windows.Forms.Label();
            this.subtext = new System.Windows.Forms.Label();
            this.getSetUp = new System.Windows.Forms.Button();
            this.robotoNotice = new System.Windows.Forms.Label();
            this.getOutOfHere = new System.Windows.Forms.Label();
            this.allDone = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // thanks
            // 
            this.thanks.AutoSize = true;
            this.thanks.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanks.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.thanks.Location = new System.Drawing.Point(167, 42);
            this.thanks.Name = "thanks";
            this.thanks.Size = new System.Drawing.Size(289, 37);
            this.thanks.TabIndex = 0;
            this.thanks.Text = "Thanks for evaluating!";
            // 
            // subtext
            // 
            this.subtext.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.subtext.ForeColor = System.Drawing.Color.Gray;
            this.subtext.Location = new System.Drawing.Point(12, 92);
            this.subtext.Name = "subtext";
            this.subtext.Size = new System.Drawing.Size(599, 130);
            this.subtext.TabIndex = 1;
            this.subtext.Text = resources.GetString("subtext.Text");
            this.subtext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // getSetUp
            // 
            this.getSetUp.BackColor = System.Drawing.Color.Transparent;
            this.getSetUp.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.getSetUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getSetUp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.getSetUp.Location = new System.Drawing.Point(236, 225);
            this.getSetUp.Name = "getSetUp";
            this.getSetUp.Size = new System.Drawing.Size(150, 26);
            this.getSetUp.TabIndex = 2;
            this.getSetUp.Text = "Get Set Up";
            this.getSetUp.UseVisualStyleBackColor = false;
            this.getSetUp.Click += new System.EventHandler(this.getSetUp_Click);
            // 
            // robotoNotice
            // 
            this.robotoNotice.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robotoNotice.ForeColor = System.Drawing.Color.Silver;
            this.robotoNotice.Location = new System.Drawing.Point(87, 274);
            this.robotoNotice.Name = "robotoNotice";
            this.robotoNotice.Size = new System.Drawing.Size(449, 44);
            this.robotoNotice.TabIndex = 3;
            this.robotoNotice.Text = "Note: This process will also locally install Roboto and Pacifico, the former of w" +
    "hich is licensed under the Apache License 2.0 and latter under the SIL Open Font" +
    " License 1.1.";
            this.robotoNotice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // getOutOfHere
            // 
            this.getOutOfHere.AutoSize = true;
            this.getOutOfHere.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.getOutOfHere.ForeColor = System.Drawing.Color.Red;
            this.getOutOfHere.Location = new System.Drawing.Point(594, 9);
            this.getOutOfHere.Name = "getOutOfHere";
            this.getOutOfHere.Size = new System.Drawing.Size(17, 19);
            this.getOutOfHere.TabIndex = 4;
            this.getOutOfHere.Text = "X";
            this.getOutOfHere.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.getOutOfHere.Click += new System.EventHandler(this.getOutOfHere_Click);
            // 
            // allDone
            // 
            this.allDone.AutoSize = true;
            this.allDone.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allDone.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.allDone.Location = new System.Drawing.Point(111, 101);
            this.allDone.Name = "allDone";
            this.allDone.Size = new System.Drawing.Size(401, 37);
            this.allDone.TabIndex = 5;
            this.allDone.Text = "You can now close this window.";
            this.allDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.allDone.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.closeButton.Location = new System.Drawing.Point(236, 163);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(150, 26);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(623, 326);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.allDone);
            this.Controls.Add(this.getOutOfHere);
            this.Controls.Add(this.robotoNotice);
            this.Controls.Add(this.getSetUp);
            this.Controls.Add(this.subtext);
            this.Controls.Add(this.thanks);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Snowshoes @ GitHub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label thanks;
        private System.Windows.Forms.Label subtext;
        private System.Windows.Forms.Button getSetUp;
        private System.Windows.Forms.Label robotoNotice;
        private System.Windows.Forms.Label getOutOfHere;
        private System.Windows.Forms.Label allDone;
        private System.Windows.Forms.Button closeButton;
    }
}

