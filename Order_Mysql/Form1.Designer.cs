namespace Order_Window
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IDlabel = new System.Windows.Forms.Label();
            this.Goodslabel = new System.Windows.Forms.Label();
            this.Customerlabel = new System.Windows.Forms.Label();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Findbutton = new System.Windows.Forms.Button();
            this.Alterbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.GoodstextBox = new System.Windows.Forms.TextBox();
            this.CustomertextBox = new System.Windows.Forms.TextBox();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ListgroupBox = new System.Windows.Forms.GroupBox();
            this.ByPriceDownradioButton = new System.Windows.Forms.RadioButton();
            this.ByPriceUpradioButton = new System.Windows.Forms.RadioButton();
            this.ByIDradioButton = new System.Windows.Forms.RadioButton();
            this.Exportbutton = new System.Windows.Forms.Button();
            this.Inputbutton = new System.Windows.Forms.Button();
            this.Timelabel = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.IDheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Goodsheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Customerheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priceheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remarksheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ListgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.9375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.0625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.Controls.Add(this.IDlabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Goodslabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Customerlabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Pricelabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Addbutton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Findbutton, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Alterbutton, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.Deletebutton, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.IDtextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GoodstextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CustomertextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.PricetextBox, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(953, 91);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // IDlabel
            // 
            this.IDlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDlabel.AutoSize = true;
            this.IDlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDlabel.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDlabel.Location = new System.Drawing.Point(3, 0);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(132, 45);
            this.IDlabel.TabIndex = 0;
            this.IDlabel.Text = "订单ID";
            this.IDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IDlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Goodslabel
            // 
            this.Goodslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Goodslabel.AutoSize = true;
            this.Goodslabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Goodslabel.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Goodslabel.Location = new System.Drawing.Point(3, 45);
            this.Goodslabel.Name = "Goodslabel";
            this.Goodslabel.Size = new System.Drawing.Size(132, 46);
            this.Goodslabel.TabIndex = 1;
            this.Goodslabel.Text = "商品名称";
            this.Goodslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Customerlabel
            // 
            this.Customerlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Customerlabel.AutoSize = true;
            this.Customerlabel.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Customerlabel.Location = new System.Drawing.Point(387, 0);
            this.Customerlabel.Name = "Customerlabel";
            this.Customerlabel.Size = new System.Drawing.Size(90, 45);
            this.Customerlabel.TabIndex = 2;
            this.Customerlabel.Text = "顾客姓名";
            this.Customerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pricelabel
            // 
            this.Pricelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pricelabel.Location = new System.Drawing.Point(387, 45);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(90, 46);
            this.Pricelabel.TabIndex = 3;
            this.Pricelabel.Text = "订单价格";
            this.Pricelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Addbutton
            // 
            this.Addbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Addbutton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Addbutton.Location = new System.Drawing.Point(671, 3);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(135, 39);
            this.Addbutton.TabIndex = 4;
            this.Addbutton.Text = "添加订单";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.AddbtnClick);
            // 
            // Findbutton
            // 
            this.Findbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Findbutton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Findbutton.Location = new System.Drawing.Point(671, 48);
            this.Findbutton.Name = "Findbutton";
            this.Findbutton.Size = new System.Drawing.Size(135, 40);
            this.Findbutton.TabIndex = 5;
            this.Findbutton.Text = "查找订单";
            this.Findbutton.UseVisualStyleBackColor = true;
            this.Findbutton.Click += new System.EventHandler(this.Findbutton_Click);
            // 
            // Alterbutton
            // 
            this.Alterbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Alterbutton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Alterbutton.Location = new System.Drawing.Point(812, 3);
            this.Alterbutton.Name = "Alterbutton";
            this.Alterbutton.Size = new System.Drawing.Size(138, 39);
            this.Alterbutton.TabIndex = 6;
            this.Alterbutton.Text = "修改订单";
            this.Alterbutton.UseVisualStyleBackColor = true;
            this.Alterbutton.Click += new System.EventHandler(this.Alterbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Deletebutton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Deletebutton.Location = new System.Drawing.Point(812, 48);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(138, 40);
            this.Deletebutton.TabIndex = 7;
            this.Deletebutton.Text = "删除订单";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // IDtextBox
            // 
            this.IDtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDtextBox.BackColor = System.Drawing.SystemColors.Info;
            this.IDtextBox.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDtextBox.Location = new System.Drawing.Point(141, 3);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(240, 32);
            this.IDtextBox.TabIndex = 8;
            this.IDtextBox.Text = "4";
            // 
            // GoodstextBox
            // 
            this.GoodstextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoodstextBox.BackColor = System.Drawing.SystemColors.Info;
            this.GoodstextBox.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GoodstextBox.Location = new System.Drawing.Point(141, 48);
            this.GoodstextBox.Name = "GoodstextBox";
            this.GoodstextBox.Size = new System.Drawing.Size(240, 32);
            this.GoodstextBox.TabIndex = 9;
            this.GoodstextBox.Text = "test";
            // 
            // CustomertextBox
            // 
            this.CustomertextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomertextBox.BackColor = System.Drawing.SystemColors.Info;
            this.CustomertextBox.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CustomertextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CustomertextBox.Location = new System.Drawing.Point(483, 3);
            this.CustomertextBox.Name = "CustomertextBox";
            this.CustomertextBox.Size = new System.Drawing.Size(182, 32);
            this.CustomertextBox.TabIndex = 10;
            this.CustomertextBox.Text = "test";
            // 
            // PricetextBox
            // 
            this.PricetextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PricetextBox.BackColor = System.Drawing.SystemColors.Info;
            this.PricetextBox.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PricetextBox.Location = new System.Drawing.Point(483, 48);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(182, 32);
            this.PricetextBox.TabIndex = 11;
            this.PricetextBox.Text = "10";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.21569F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.78431F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel2.Controls.Add(this.ListgroupBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Exportbutton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Inputbutton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Timelabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 627);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(953, 63);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ListgroupBox
            // 
            this.ListgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListgroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListgroupBox.Controls.Add(this.ByPriceDownradioButton);
            this.ListgroupBox.Controls.Add(this.ByPriceUpradioButton);
            this.ListgroupBox.Controls.Add(this.ByIDradioButton);
            this.ListgroupBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListgroupBox.Location = new System.Drawing.Point(267, 3);
            this.ListgroupBox.Name = "ListgroupBox";
            this.ListgroupBox.Size = new System.Drawing.Size(404, 41);
            this.ListgroupBox.TabIndex = 0;
            this.ListgroupBox.TabStop = false;
            this.ListgroupBox.Text = "订单排序方式";
            // 
            // ByPriceDownradioButton
            // 
            this.ByPriceDownradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ByPriceDownradioButton.AutoSize = true;
            this.ByPriceDownradioButton.Location = new System.Drawing.Point(263, 18);
            this.ByPriceDownradioButton.Name = "ByPriceDownradioButton";
            this.ByPriceDownradioButton.Size = new System.Drawing.Size(90, 20);
            this.ByPriceDownradioButton.TabIndex = 2;
            this.ByPriceDownradioButton.Text = "价格降序";
            this.ByPriceDownradioButton.UseVisualStyleBackColor = true;
            // 
            // ByPriceUpradioButton
            // 
            this.ByPriceUpradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ByPriceUpradioButton.AutoSize = true;
            this.ByPriceUpradioButton.Location = new System.Drawing.Point(134, 18);
            this.ByPriceUpradioButton.Name = "ByPriceUpradioButton";
            this.ByPriceUpradioButton.Size = new System.Drawing.Size(90, 20);
            this.ByPriceUpradioButton.TabIndex = 1;
            this.ByPriceUpradioButton.Text = "价格升序";
            this.ByPriceUpradioButton.UseVisualStyleBackColor = true;
            this.ByPriceUpradioButton.CheckedChanged += new System.EventHandler(this.ByPriceUpradioButton_CheckedChanged);
            // 
            // ByIDradioButton
            // 
            this.ByIDradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ByIDradioButton.AutoSize = true;
            this.ByIDradioButton.Checked = true;
            this.ByIDradioButton.Location = new System.Drawing.Point(6, 18);
            this.ByIDradioButton.Name = "ByIDradioButton";
            this.ByIDradioButton.Size = new System.Drawing.Size(58, 20);
            this.ByIDradioButton.TabIndex = 0;
            this.ByIDradioButton.TabStop = true;
            this.ByIDradioButton.Text = "按ID";
            this.ByIDradioButton.UseVisualStyleBackColor = true;
            // 
            // Exportbutton
            // 
            this.Exportbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exportbutton.AutoSize = true;
            this.Exportbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Exportbutton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exportbutton.Location = new System.Drawing.Point(808, 3);
            this.Exportbutton.Name = "Exportbutton";
            this.Exportbutton.Size = new System.Drawing.Size(142, 57);
            this.Exportbutton.TabIndex = 2;
            this.Exportbutton.Text = "导出订单";
            this.Exportbutton.UseVisualStyleBackColor = true;
            this.Exportbutton.Click += new System.EventHandler(this.Exportbutton_Click);
            // 
            // Inputbutton
            // 
            this.Inputbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inputbutton.AutoSize = true;
            this.Inputbutton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Inputbutton.Location = new System.Drawing.Point(677, 3);
            this.Inputbutton.Name = "Inputbutton";
            this.Inputbutton.Size = new System.Drawing.Size(125, 57);
            this.Inputbutton.TabIndex = 1;
            this.Inputbutton.Text = "导入订单";
            this.Inputbutton.UseVisualStyleBackColor = true;
            this.Inputbutton.Click += new System.EventHandler(this.Inputbutton_Click);
            // 
            // Timelabel
            // 
            this.Timelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Timelabel.AutoSize = true;
            this.Timelabel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Timelabel.Location = new System.Drawing.Point(3, 0);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(258, 63);
            this.Timelabel.TabIndex = 3;
            this.Timelabel.Text = "Time";
            this.Timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Timelabel.Click += new System.EventHandler(this.Timelabel_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDheader,
            this.Goodsheader,
            this.Customerheader,
            this.Priceheader,
            this.Remarksheader});
            this.listView.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 109);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(954, 512);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.as_decslist);
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // IDheader
            // 
            this.IDheader.Text = "订单ID";
            this.IDheader.Width = 105;
            // 
            // Goodsheader
            // 
            this.Goodsheader.Text = "商品名称";
            this.Goodsheader.Width = 104;
            // 
            // Customerheader
            // 
            this.Customerheader.Text = "顾客姓名";
            this.Customerheader.Width = 108;
            // 
            // Priceheader
            // 
            this.Priceheader.Text = "订单价格";
            this.Priceheader.Width = 116;
            // 
            // Remarksheader
            // 
            this.Remarksheader.Text = "订单备注";
            this.Remarksheader.Width = 517;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Form1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 692);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ListgroupBox.ResumeLayout(false);
            this.ListgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label Goodslabel;
        private System.Windows.Forms.Label Customerlabel;
        private System.Windows.Forms.Label Pricelabel;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Findbutton;
        private System.Windows.Forms.Button Alterbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox GoodstextBox;
        private System.Windows.Forms.TextBox CustomertextBox;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox ListgroupBox;
        private System.Windows.Forms.RadioButton ByPriceDownradioButton;
        private System.Windows.Forms.RadioButton ByPriceUpradioButton;
        private System.Windows.Forms.RadioButton ByIDradioButton;
        private System.Windows.Forms.Button Inputbutton;
        private System.Windows.Forms.Button Exportbutton;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.ListView listView; 
        private System.Windows.Forms.ColumnHeader IDheader;
        private System.Windows.Forms.ColumnHeader Goodsheader;
        private System.Windows.Forms.ColumnHeader Customerheader;
        private System.Windows.Forms.ColumnHeader Priceheader;
        private System.Windows.Forms.ColumnHeader Remarksheader;
        private System.Windows.Forms.Timer timer1;
    }
}

