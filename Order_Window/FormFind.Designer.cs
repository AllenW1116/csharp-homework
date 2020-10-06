namespace Order_Window
{
    partial class FormFind
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
            this.FindgroupBox = new System.Windows.Forms.GroupBox();
            this.ByGoodsradioButton = new System.Windows.Forms.RadioButton();
            this.ByCustomerradioButton = new System.Windows.Forms.RadioButton();
            this.ByPriceradioButton = new System.Windows.Forms.RadioButton();
            this.lowpricelabel = new System.Windows.Forms.Label();
            this.Customerlabel = new System.Windows.Forms.Label();
            this.Goodslabel = new System.Windows.Forms.Label();
            this.Highpricelabel = new System.Windows.Forms.Label();
            this.LowPricetextBox = new System.Windows.Forms.TextBox();
            this.HighPricetextBox = new System.Windows.Forms.TextBox();
            this.CustomertextBox = new System.Windows.Forms.TextBox();
            this.GoodstextBox = new System.Windows.Forms.TextBox();
            this.FindResultlistView = new System.Windows.Forms.ListView();
            this.IDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GoodsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemarksHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.FindgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindgroupBox
            // 
            this.FindgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FindgroupBox.Controls.Add(this.ByGoodsradioButton);
            this.FindgroupBox.Controls.Add(this.ByCustomerradioButton);
            this.FindgroupBox.Controls.Add(this.ByPriceradioButton);
            this.FindgroupBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FindgroupBox.Location = new System.Drawing.Point(12, 12);
            this.FindgroupBox.Name = "FindgroupBox";
            this.FindgroupBox.Size = new System.Drawing.Size(318, 78);
            this.FindgroupBox.TabIndex = 0;
            this.FindgroupBox.TabStop = false;
            this.FindgroupBox.Text = "查找方式";
            // 
            // ByGoodsradioButton
            // 
            this.ByGoodsradioButton.AutoSize = true;
            this.ByGoodsradioButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ByGoodsradioButton.Location = new System.Drawing.Point(209, 42);
            this.ByGoodsradioButton.Name = "ByGoodsradioButton";
            this.ByGoodsradioButton.Size = new System.Drawing.Size(95, 16);
            this.ByGoodsradioButton.TabIndex = 2;
            this.ByGoodsradioButton.TabStop = true;
            this.ByGoodsradioButton.Text = "按照产品查找";
            this.ByGoodsradioButton.UseVisualStyleBackColor = true;
            // 
            // ByCustomerradioButton
            // 
            this.ByCustomerradioButton.AutoSize = true;
            this.ByCustomerradioButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ByCustomerradioButton.Location = new System.Drawing.Point(108, 42);
            this.ByCustomerradioButton.Name = "ByCustomerradioButton";
            this.ByCustomerradioButton.Size = new System.Drawing.Size(95, 16);
            this.ByCustomerradioButton.TabIndex = 1;
            this.ByCustomerradioButton.TabStop = true;
            this.ByCustomerradioButton.Text = "按照顾客查找";
            this.ByCustomerradioButton.UseVisualStyleBackColor = true;
            // 
            // ByPriceradioButton
            // 
            this.ByPriceradioButton.AutoSize = true;
            this.ByPriceradioButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ByPriceradioButton.Location = new System.Drawing.Point(7, 42);
            this.ByPriceradioButton.Name = "ByPriceradioButton";
            this.ByPriceradioButton.Size = new System.Drawing.Size(95, 16);
            this.ByPriceradioButton.TabIndex = 0;
            this.ByPriceradioButton.TabStop = true;
            this.ByPriceradioButton.Text = "按照价格查找";
            this.ByPriceradioButton.UseVisualStyleBackColor = true;
            // 
            // lowpricelabel
            // 
            this.lowpricelabel.AutoSize = true;
            this.lowpricelabel.Location = new System.Drawing.Point(347, 31);
            this.lowpricelabel.Name = "lowpricelabel";
            this.lowpricelabel.Size = new System.Drawing.Size(29, 12);
            this.lowpricelabel.TabIndex = 1;
            this.lowpricelabel.Text = "低价";
            // 
            // Customerlabel
            // 
            this.Customerlabel.AutoSize = true;
            this.Customerlabel.Location = new System.Drawing.Point(347, 69);
            this.Customerlabel.Name = "Customerlabel";
            this.Customerlabel.Size = new System.Drawing.Size(53, 12);
            this.Customerlabel.TabIndex = 2;
            this.Customerlabel.Text = "顾客姓名";
            // 
            // Goodslabel
            // 
            this.Goodslabel.AutoSize = true;
            this.Goodslabel.Location = new System.Drawing.Point(538, 69);
            this.Goodslabel.Name = "Goodslabel";
            this.Goodslabel.Size = new System.Drawing.Size(53, 12);
            this.Goodslabel.TabIndex = 3;
            this.Goodslabel.Text = "商品名称";
            // 
            // Highpricelabel
            // 
            this.Highpricelabel.AutoSize = true;
            this.Highpricelabel.Location = new System.Drawing.Point(487, 31);
            this.Highpricelabel.Name = "Highpricelabel";
            this.Highpricelabel.Size = new System.Drawing.Size(35, 12);
            this.Highpricelabel.TabIndex = 4;
            this.Highpricelabel.Text = "~高价";
            // 
            // LowPricetextBox
            // 
            this.LowPricetextBox.Location = new System.Drawing.Point(401, 28);
            this.LowPricetextBox.Name = "LowPricetextBox";
            this.LowPricetextBox.Size = new System.Drawing.Size(68, 21);
            this.LowPricetextBox.TabIndex = 5;
            this.LowPricetextBox.Text = "0";
            // 
            // HighPricetextBox
            // 
            this.HighPricetextBox.Location = new System.Drawing.Point(537, 28);
            this.HighPricetextBox.Name = "HighPricetextBox";
            this.HighPricetextBox.Size = new System.Drawing.Size(77, 21);
            this.HighPricetextBox.TabIndex = 6;
            this.HighPricetextBox.Text = "50";
            // 
            // CustomertextBox
            // 
            this.CustomertextBox.Location = new System.Drawing.Point(406, 66);
            this.CustomertextBox.Name = "CustomertextBox";
            this.CustomertextBox.Size = new System.Drawing.Size(126, 21);
            this.CustomertextBox.TabIndex = 7;
            // 
            // GoodstextBox
            // 
            this.GoodstextBox.Location = new System.Drawing.Point(603, 66);
            this.GoodstextBox.Name = "GoodstextBox";
            this.GoodstextBox.Size = new System.Drawing.Size(126, 21);
            this.GoodstextBox.TabIndex = 8;
            // 
            // FindResultlistView
            // 
            this.FindResultlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDHeader,
            this.CustomerHeader,
            this.GoodsHeader,
            this.PriceHeader,
            this.RemarksHeader});
            this.FindResultlistView.HideSelection = false;
            this.FindResultlistView.Location = new System.Drawing.Point(12, 133);
            this.FindResultlistView.Name = "FindResultlistView";
            this.FindResultlistView.Size = new System.Drawing.Size(717, 336);
            this.FindResultlistView.TabIndex = 9;
            this.FindResultlistView.UseCompatibleStateImageBehavior = false;
            this.FindResultlistView.View = System.Windows.Forms.View.Details;
            // 
            // IDHeader
            // 
            this.IDHeader.Text = "ID";
            // 
            // CustomerHeader
            // 
            this.CustomerHeader.Text = "顾客姓名";
            this.CustomerHeader.Width = 88;
            // 
            // GoodsHeader
            // 
            this.GoodsHeader.Text = "商品名称";
            this.GoodsHeader.Width = 81;
            // 
            // PriceHeader
            // 
            this.PriceHeader.Text = "商品价格";
            this.PriceHeader.Width = 99;
            // 
            // RemarksHeader
            // 
            this.RemarksHeader.Text = "订单备注";
            this.RemarksHeader.Width = 410;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(643, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "查找订单";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FindResultlistView);
            this.Controls.Add(this.GoodstextBox);
            this.Controls.Add(this.CustomertextBox);
            this.Controls.Add(this.HighPricetextBox);
            this.Controls.Add(this.LowPricetextBox);
            this.Controls.Add(this.Highpricelabel);
            this.Controls.Add(this.Goodslabel);
            this.Controls.Add(this.Customerlabel);
            this.Controls.Add(this.lowpricelabel);
            this.Controls.Add(this.FindgroupBox);
            this.Name = "FormFind";
            this.Text = "查找订单";
            this.FindgroupBox.ResumeLayout(false);
            this.FindgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FindgroupBox;
        public System.Windows.Forms.RadioButton ByGoodsradioButton;
        public System.Windows.Forms.RadioButton ByCustomerradioButton;
        private System.Windows.Forms.Label lowpricelabel;
        private System.Windows.Forms.Label Customerlabel;
        private System.Windows.Forms.Label Goodslabel;
        private System.Windows.Forms.Label Highpricelabel;
        public System.Windows.Forms.TextBox LowPricetextBox;
        public System.Windows.Forms.TextBox HighPricetextBox;
        public System.Windows.Forms.TextBox CustomertextBox;
        public System.Windows.Forms.TextBox GoodstextBox;
        public System.Windows.Forms.RadioButton ByPriceradioButton;
        public System.Windows.Forms.ListView FindResultlistView;
        private System.Windows.Forms.ColumnHeader IDHeader;
        private System.Windows.Forms.ColumnHeader CustomerHeader;
        private System.Windows.Forms.ColumnHeader GoodsHeader;
        private System.Windows.Forms.ColumnHeader PriceHeader;
        private System.Windows.Forms.ColumnHeader RemarksHeader;
        private System.Windows.Forms.Button button1;
    }
}