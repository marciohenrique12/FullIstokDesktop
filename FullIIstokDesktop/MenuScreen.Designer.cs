namespace FullIIstokDesktop
{
    partial class MenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCreateProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.itmReadProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.itmUpdateProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.itmDeleteProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtProductSku = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbProductSku = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.lblSalutation = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmCreateProduct,
            this.itmReadProduct,
            this.itmUpdateProduct,
            this.itmDeleteProduct});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.produtosToolStripMenuItem.Text = "Products";
            // 
            // itmCreateProduct
            // 
            this.itmCreateProduct.Name = "itmCreateProduct";
            this.itmCreateProduct.Size = new System.Drawing.Size(112, 22);
            this.itmCreateProduct.Text = "Create";
            this.itmCreateProduct.Click += new System.EventHandler(this.itmCreateProduct_Click);
            // 
            // itmReadProduct
            // 
            this.itmReadProduct.Name = "itmReadProduct";
            this.itmReadProduct.Size = new System.Drawing.Size(112, 22);
            this.itmReadProduct.Text = "Read";
            this.itmReadProduct.Click += new System.EventHandler(this.itmReadProduct_Click);
            // 
            // itmUpdateProduct
            // 
            this.itmUpdateProduct.Name = "itmUpdateProduct";
            this.itmUpdateProduct.Size = new System.Drawing.Size(112, 22);
            this.itmUpdateProduct.Text = "Update";
            this.itmUpdateProduct.Click += new System.EventHandler(this.itmUpdateProduct_Click);
            // 
            // itmDeleteProduct
            // 
            this.itmDeleteProduct.Name = "itmDeleteProduct";
            this.itmDeleteProduct.Size = new System.Drawing.Size(112, 22);
            this.itmDeleteProduct.Text = "Delete";
            this.itmDeleteProduct.Click += new System.EventHandler(this.itmDeleteProduct_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // txtProductSku
            // 
            this.txtProductSku.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductSku.Location = new System.Drawing.Point(151, 30);
            this.txtProductSku.Multiline = true;
            this.txtProductSku.Name = "txtProductSku";
            this.txtProductSku.Size = new System.Drawing.Size(300, 30);
            this.txtProductSku.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductName.Location = new System.Drawing.Point(151, 75);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(300, 30);
            this.txtProductName.TabIndex = 3;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductQuantity.Location = new System.Drawing.Point(151, 125);
            this.txtProductQuantity.Multiline = true;
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(300, 30);
            this.txtProductQuantity.TabIndex = 4;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductPrice.Location = new System.Drawing.Point(151, 220);
            this.txtProductPrice.Multiline = true;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(300, 30);
            this.txtProductPrice.TabIndex = 5;
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRead.Location = new System.Drawing.Point(475, 76);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(103, 40);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(475, 30);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(103, 40);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(475, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(475, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 40);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbProductSku
            // 
            this.lbProductSku.AutoSize = true;
            this.lbProductSku.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductSku.Location = new System.Drawing.Point(19, 40);
            this.lbProductSku.Name = "lbProductSku";
            this.lbProductSku.Size = new System.Drawing.Size(89, 19);
            this.lbProductSku.TabIndex = 10;
            this.lbProductSku.Text = "Product SKU:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(19, 86);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(100, 19);
            this.lblProductName.TabIndex = 11;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductQuantity.Location = new System.Drawing.Point(19, 136);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(118, 19);
            this.lblProductQuantity.TabIndex = 12;
            this.lblProductQuantity.Text = "Product Quantity:";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductPrice.Location = new System.Drawing.Point(19, 231);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(93, 19);
            this.lblProductPrice.TabIndex = 13;
            this.lblProductPrice.Text = "Product Price:";
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductDescription.Location = new System.Drawing.Point(151, 174);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(300, 30);
            this.txtProductDescription.TabIndex = 14;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductDescription.Location = new System.Drawing.Point(19, 185);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(133, 19);
            this.lblProductDescription.TabIndex = 15;
            this.lblProductDescription.Text = "Product Description:";
            // 
            // pnlProducts
            // 
            this.pnlProducts.Controls.Add(this.lblProductPrice);
            this.pnlProducts.Controls.Add(this.btnCreate);
            this.pnlProducts.Controls.Add(this.btnUpdate);
            this.pnlProducts.Controls.Add(this.btnRead);
            this.pnlProducts.Controls.Add(this.txtProductDescription);
            this.pnlProducts.Controls.Add(this.btnDelete);
            this.pnlProducts.Controls.Add(this.lblProductDescription);
            this.pnlProducts.Controls.Add(this.lbProductSku);
            this.pnlProducts.Controls.Add(this.lblProductName);
            this.pnlProducts.Controls.Add(this.txtProductPrice);
            this.pnlProducts.Controls.Add(this.lblProductQuantity);
            this.pnlProducts.Controls.Add(this.txtProductSku);
            this.pnlProducts.Controls.Add(this.txtProductName);
            this.pnlProducts.Controls.Add(this.txtProductQuantity);
            this.pnlProducts.Location = new System.Drawing.Point(12, 27);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(602, 261);
            this.pnlProducts.TabIndex = 16;
            // 
            // lblSalutation
            // 
            this.lblSalutation.AutoSize = true;
            this.lblSalutation.Location = new System.Drawing.Point(487, 306);
            this.lblSalutation.Name = "lblSalutation";
            this.lblSalutation.Size = new System.Drawing.Size(0, 15);
            this.lblSalutation.TabIndex = 17;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 330);
            this.Controls.Add(this.lblSalutation);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuScreen";
            this.Text = "FullIstok Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlProducts.ResumeLayout(false);
            this.pnlProducts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem itmCreateProduct;
        private ToolStripMenuItem itmReadProduct;
        private ToolStripMenuItem itmUpdateProduct;
        private ToolStripMenuItem itmDeleteProduct;
        private TextBox txtProductSku;
        private TextBox txtProductName;
        private TextBox txtProductQuantity;
        private TextBox txtProductPrice;
        private Button btnRead;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private Label lbProductSku;
        private Label lblProductName;
        private Label lblProductQuantity;
        private Label lblProductPrice;
        private TextBox txtProductDescription;
        private Label lblProductDescription;
        private Panel pnlProducts;
        private Label lblSalutation;
    }
}