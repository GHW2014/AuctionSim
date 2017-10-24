namespace AuctionSim
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBid = new System.Windows.Forms.Button();
            this.tbxPriceAdd = new System.Windows.Forms.TextBox();
            this.tbxPriceBid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblBidStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbOutput
            // 
            this.rtbOutput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(22, 239);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(370, 280);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(758, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "加  价";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBid
            // 
            this.btnBid.BackColor = System.Drawing.Color.Blue;
            this.btnBid.ForeColor = System.Drawing.Color.White;
            this.btnBid.Location = new System.Drawing.Point(759, 392);
            this.btnBid.Name = "btnBid";
            this.btnBid.Size = new System.Drawing.Size(70, 30);
            this.btnBid.TabIndex = 2;
            this.btnBid.Text = "出  价";
            this.btnBid.UseVisualStyleBackColor = false;
            this.btnBid.Click += new System.EventHandler(this.btnBid_Click);
            // 
            // tbxPriceAdd
            // 
            this.tbxPriceAdd.BackColor = System.Drawing.Color.Orange;
            this.tbxPriceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPriceAdd.Location = new System.Drawing.Point(630, 285);
            this.tbxPriceAdd.MaxLength = 3;
            this.tbxPriceAdd.Name = "tbxPriceAdd";
            this.tbxPriceAdd.Size = new System.Drawing.Size(100, 31);
            this.tbxPriceAdd.TabIndex = 3;
            this.tbxPriceAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPriceAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPriceAdd_KeyPress);
            // 
            // tbxPriceBid
            // 
            this.tbxPriceBid.BackColor = System.Drawing.Color.LightGray;
            this.tbxPriceBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPriceBid.Location = new System.Drawing.Point(611, 391);
            this.tbxPriceBid.MaxLength = 5;
            this.tbxPriceBid.Name = "tbxPriceBid";
            this.tbxPriceBid.Size = new System.Drawing.Size(121, 31);
            this.tbxPriceBid.TabIndex = 4;
            this.tbxPriceBid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPriceBid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPriceBid_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(609, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "-300";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.ForestGreen;
            this.button2.Location = new System.Drawing.Point(685, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "-200";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Linen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.ForestGreen;
            this.button3.Location = new System.Drawing.Point(761, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "-100";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.OrangeRed;
            this.button4.Location = new System.Drawing.Point(609, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "+300";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.OrangeRed;
            this.button5.Location = new System.Drawing.Point(685, 355);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 30);
            this.button5.TabIndex = 9;
            this.button5.Text = "+200";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.OrangeRed;
            this.button6.Location = new System.Drawing.Point(761, 355);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 30);
            this.button6.TabIndex = 10;
            this.button6.Text = "+100";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblOutput.Location = new System.Drawing.Point(455, 249);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 25);
            this.lblOutput.TabIndex = 11;
            // 
            // lblBidStatus
            // 
            this.lblBidStatus.AutoSize = true;
            this.lblBidStatus.BackColor = System.Drawing.Color.Silver;
            this.lblBidStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBidStatus.ForeColor = System.Drawing.Color.Red;
            this.lblBidStatus.Location = new System.Drawing.Point(430, 465);
            this.lblBidStatus.Name = "lblBidStatus";
            this.lblBidStatus.Size = new System.Drawing.Size(0, 16);
            this.lblBidStatus.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(887, 691);
            this.Controls.Add(this.lblBidStatus);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxPriceBid);
            this.Controls.Add(this.tbxPriceAdd);
            this.Controls.Add(this.btnBid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtbOutput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auction";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBid;
        private System.Windows.Forms.TextBox tbxPriceAdd;
        private System.Windows.Forms.TextBox tbxPriceBid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblBidStatus;
    }
}

