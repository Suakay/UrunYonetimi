namespace UrunYonetimi.UI
{
    partial class ProductForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProductName = new TextBox();
            txtProductDescription = new TextBox();
            nudProductPrice = new NumericUpDown();
            lblProductId = new Label();
            btnProductAdd = new Button();
            btnProductUpdate = new Button();
            dgwProduct = new DataGridView();
            cmsProduct = new ContextMenuStrip(components);
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            lbKategoriler = new ListBox();
            cbKategoriler = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudProductPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwProduct).BeginInit();
            cmsProduct.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 1;
            label2.Text = "Ürün Açıklaması :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 126);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Fiyat :";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(168, 26);
            txtProductName.Margin = new Padding(4, 5, 4, 5);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(402, 31);
            txtProductName.TabIndex = 3;
            // 
            // txtProductDescription
            // 
            txtProductDescription.Location = new Point(168, 75);
            txtProductDescription.Margin = new Padding(4, 5, 4, 5);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new Size(402, 31);
            txtProductDescription.TabIndex = 4;
            // 
            // nudProductPrice
            // 
            nudProductPrice.Location = new Point(168, 124);
            nudProductPrice.Margin = new Padding(4, 5, 4, 5);
            nudProductPrice.Name = "nudProductPrice";
            nudProductPrice.Size = new Size(402, 31);
            nudProductPrice.TabIndex = 5;
            nudProductPrice.ValueChanged += nudProductPrice_ValueChanged;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(18, 471);
            lblProductId.Margin = new Padding(4, 0, 4, 0);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(59, 25);
            lblProductId.TabIndex = 6;
            lblProductId.Text = "label4";
            lblProductId.Visible = false;
            // 
            // btnProductAdd
            // 
            btnProductAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnProductAdd.Location = new Point(351, 344);
            btnProductAdd.Margin = new Padding(4, 5, 4, 5);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(108, 105);
            btnProductAdd.TabIndex = 7;
            btnProductAdd.Text = "EKLE";
            btnProductAdd.UseVisualStyleBackColor = false;
            btnProductAdd.Click += btnProductAdd_Click;
            // 
            // btnProductUpdate
            // 
            btnProductUpdate.BackColor = Color.FromArgb(255, 224, 192);
            btnProductUpdate.Location = new Point(466, 344);
            btnProductUpdate.Margin = new Padding(4, 5, 4, 5);
            btnProductUpdate.Name = "btnProductUpdate";
            btnProductUpdate.Size = new Size(108, 105);
            btnProductUpdate.TabIndex = 7;
            btnProductUpdate.Text = "GÜNCELLE";
            btnProductUpdate.UseVisualStyleBackColor = false;
            btnProductUpdate.Click += btnProductUpdate_Click;
            // 
            // dgwProduct
            // 
            dgwProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProduct.ContextMenuStrip = cmsProduct;
            dgwProduct.Location = new Point(15, 558);
            dgwProduct.Margin = new Padding(4, 5, 4, 5);
            dgwProduct.Name = "dgwProduct";
            dgwProduct.RowHeadersWidth = 51;
            dgwProduct.RowTemplate.Height = 25;
            dgwProduct.Size = new Size(552, 250);
            dgwProduct.TabIndex = 8;
            // 
            // cmsProduct
            // 
            cmsProduct.ImageScalingSize = new Size(20, 20);
            cmsProduct.Items.AddRange(new ToolStripItem[] { güncelleToolStripMenuItem, silToolStripMenuItem });
            cmsProduct.Name = "cmsProduct";
            cmsProduct.Size = new Size(151, 68);
            // 
            // güncelleToolStripMenuItem
            // 
            güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            güncelleToolStripMenuItem.Size = new Size(150, 32);
            güncelleToolStripMenuItem.Text = "Güncelle";
            güncelleToolStripMenuItem.Click += güncelleToolStripMenuItem_Click;
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(150, 32);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 179);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 10;
            label4.Text = "Kategori :";
            // 
            // lbKategoriler
            // 
            lbKategoriler.FormattingEnabled = true;
            lbKategoriler.ItemHeight = 25;
            lbKategoriler.Location = new Point(168, 179);
            lbKategoriler.Margin = new Padding(4, 5, 4, 5);
            lbKategoriler.Name = "lbKategoriler";
            lbKategoriler.SelectionMode = SelectionMode.MultiSimple;
            lbKategoriler.Size = new Size(402, 154);
            lbKategoriler.TabIndex = 11;
            lbKategoriler.SelectedIndexChanged += lbKategoriler_SelectedIndexChanged;
            // 
            // cbKategoriler
            // 
            cbKategoriler.FormattingEnabled = true;
            cbKategoriler.Location = new Point(379, 514);
            cbKategoriler.Margin = new Padding(4, 4, 4, 4);
            cbKategoriler.Name = "cbKategoriler";
            cbKategoriler.Size = new Size(188, 33);
            cbKategoriler.TabIndex = 12;
            cbKategoriler.SelectedIndexChanged += cbKategoriler_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 518);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 0;
            label5.Text = "Kategori :";
            // 
            // button1
            // 
            button1.Location = new Point(575, 514);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 13;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1632, 841);
            Controls.Add(button1);
            Controls.Add(cbKategoriler);
            Controls.Add(lbKategoriler);
            Controls.Add(label4);
            Controls.Add(dgwProduct);
            Controls.Add(btnProductUpdate);
            Controls.Add(btnProductAdd);
            Controls.Add(lblProductId);
            Controls.Add(nudProductPrice);
            Controls.Add(txtProductDescription);
            Controls.Add(txtProductName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ProductForm";
            Text = "tool";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudProductPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwProduct).EndInit();
            cmsProduct.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProductName;
        private TextBox txtProductDescription;
        private NumericUpDown nudProductPrice;
        private Label lblProductId;
        private Button btnProductAdd;
        private Button btnProductUpdate;
        private DataGridView dgwProduct;
        private ContextMenuStrip cmsProduct;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private Label label4;
        private ListBox lbKategoriler;
        private ComboBox cbKategoriler;
        private Label label5;
        private Button button1;
    }
}