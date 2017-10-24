namespace AuctionSim
{
    partial class ProveYouAreHuman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveYouAreHuman));
            this.ptbRead = new System.Windows.Forms.PictureBox();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRead)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbRead
            // 
            this.ptbRead.Location = new System.Drawing.Point(295, 140);
            this.ptbRead.Name = "ptbRead";
            this.ptbRead.Size = new System.Drawing.Size(120, 44);
            this.ptbRead.TabIndex = 0;
            this.ptbRead.TabStop = false;
            // 
            // rtbInput
            // 
            this.rtbInput.BackColor = System.Drawing.Color.AntiqueWhite;
            this.rtbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInput.ForeColor = System.Drawing.Color.Red;
            this.rtbInput.Location = new System.Drawing.Point(160, 145);
            this.rtbInput.MaxLength = 4;
            this.rtbInput.Multiline = false;
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(125, 30);
            this.rtbInput.TabIndex = 1;
            this.rtbInput.Text = "";
            this.rtbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbInput_KeyPress);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.Bisque;
            this.lblOutput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOutput.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblOutput.Location = new System.Drawing.Point(125, 85);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 21);
            this.lblOutput.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(250, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取    消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(65, 235);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(115, 30);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确    定";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ProveYouAreHuman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(440, 308);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.ptbRead);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProveYouAreHuman";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ProveYouAreHuman";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProveYouAreHuman_FormClosing);
            this.Load += new System.EventHandler(this.ProveYouAreHuman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbRead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbRead;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}