namespace Anyo.WindowsForms.MessageBoxes
{
    partial class SampleMessageBox
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
            this.OK_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.message_richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // OK_btn
            // 
            this.OK_btn.Active = true;
            this.OK_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OK_btn.BorderWidth = 1;
            this.OK_btn.ButtonRadius = 2;
            this.OK_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.OK_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.OK_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.OK_btn.ClickColorB = System.Drawing.Color.DarkGoldenrod;
            this.OK_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.OK_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.OK_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.OK_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.OK_btn.HoverColorB = System.Drawing.Color.Orange;
            this.OK_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.None;
            this.OK_btn.ImageCornerX = 0;
            this.OK_btn.ImageCornerY = 0;
            this.OK_btn.Location = new System.Drawing.Point(140, 39);
            this.OK_btn.Margin = new System.Windows.Forms.Padding(0);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.OK_btn.NormalColorA = System.Drawing.Color.Orange;
            this.OK_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.OK_btn.Size = new System.Drawing.Size(62, 25);
            this.OK_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.OK_btn.TabIndex = 0;
            this.OK_btn.Text = "OK";
            this.OK_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.OK_btn.TextX = 20.98112F;
            this.OK_btn.TextY = 5.087402F;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // message_richTextBox
            // 
            this.message_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.message_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.message_richTextBox.ForeColor = System.Drawing.Color.White;
            this.message_richTextBox.Location = new System.Drawing.Point(12, 12);
            this.message_richTextBox.Name = "message_richTextBox";
            this.message_richTextBox.ReadOnly = true;
            this.message_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.message_richTextBox.Size = new System.Drawing.Size(318, 24);
            this.message_richTextBox.TabIndex = 1;
            this.message_richTextBox.Text = "";
            // 
            // SampleMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(342, 67);
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.message_richTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SampleMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Buttons.GradientButton OK_btn;
        private System.Windows.Forms.RichTextBox message_richTextBox;
    }
}

