namespace Cartrige_Inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addBrand = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartridge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPrinter = new System.Windows.Forms.Button();
            this.addCartrige = new System.Windows.Forms.Button();
            this.listPrinter = new System.Windows.Forms.ComboBox();
            this.listBrand = new System.Windows.Forms.ComboBox();
            this.inputBrand = new System.Windows.Forms.TextBox();
            this.inputPrinter = new System.Windows.Forms.TextBox();
            this.inputCartridge = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBrand
            // 
            this.addBrand.Location = new System.Drawing.Point(77, 56);
            this.addBrand.Name = "addBrand";
            this.addBrand.Size = new System.Drawing.Size(121, 32);
            this.addBrand.TabIndex = 0;
            this.addBrand.Text = "Add Brand";
            this.addBrand.UseVisualStyleBackColor = true;
            this.addBrand.Click += new System.EventHandler(this.addBrand_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brand,
            this.model,
            this.cartridge,
            this.QT,
            this.location});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(77, 141);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(589, 197);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.LocationChanged += new System.EventHandler(this.dataGridView1_LocationChanged);
            // 
            // brand
            // 
            this.brand.HeaderText = "Brand";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            // 
            // model
            // 
            this.model.HeaderText = "Printer";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // cartridge
            // 
            this.cartridge.HeaderText = "Cartridge";
            this.cartridge.Name = "cartridge";
            this.cartridge.ReadOnly = true;
            // 
            // QT
            // 
            this.QT.HeaderText = "Quantity";
            this.QT.Name = "QT";
            // 
            // location
            // 
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            // 
            // addPrinter
            // 
            this.addPrinter.Location = new System.Drawing.Point(312, 56);
            this.addPrinter.Name = "addPrinter";
            this.addPrinter.Size = new System.Drawing.Size(121, 32);
            this.addPrinter.TabIndex = 2;
            this.addPrinter.Text = "Add Printer";
            this.addPrinter.UseVisualStyleBackColor = true;
            this.addPrinter.Click += new System.EventHandler(this.addPrinter_Click);
            // 
            // addCartrige
            // 
            this.addCartrige.Location = new System.Drawing.Point(545, 56);
            this.addCartrige.Name = "addCartrige";
            this.addCartrige.Size = new System.Drawing.Size(121, 59);
            this.addCartrige.TabIndex = 3;
            this.addCartrige.Text = "Add Cartridge";
            this.addCartrige.UseVisualStyleBackColor = true;
            this.addCartrige.Click += new System.EventHandler(this.addCartrige_Click);
            // 
            // listPrinter
            // 
            this.listPrinter.FormattingEnabled = true;
            this.listPrinter.Location = new System.Drawing.Point(312, 94);
            this.listPrinter.Name = "listPrinter";
            this.listPrinter.Size = new System.Drawing.Size(121, 21);
            this.listPrinter.TabIndex = 4;
            // 
            // listBrand
            // 
            this.listBrand.FormattingEnabled = true;
            this.listBrand.Location = new System.Drawing.Point(77, 94);
            this.listBrand.Name = "listBrand";
            this.listBrand.Size = new System.Drawing.Size(121, 21);
            this.listBrand.TabIndex = 6;
            this.listBrand.SelectedIndexChanged += new System.EventHandler(this.listBrand_SelectedIndexChanged);
            // 
            // inputBrand
            // 
            this.inputBrand.Location = new System.Drawing.Point(77, 30);
            this.inputBrand.Name = "inputBrand";
            this.inputBrand.Size = new System.Drawing.Size(121, 20);
            this.inputBrand.TabIndex = 7;
            // 
            // inputPrinter
            // 
            this.inputPrinter.Location = new System.Drawing.Point(312, 30);
            this.inputPrinter.Name = "inputPrinter";
            this.inputPrinter.Size = new System.Drawing.Size(121, 20);
            this.inputPrinter.TabIndex = 8;
            // 
            // inputCartridge
            // 
            this.inputCartridge.Location = new System.Drawing.Point(545, 30);
            this.inputCartridge.Name = "inputCartridge";
            this.inputCartridge.Size = new System.Drawing.Size(121, 20);
            this.inputCartridge.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.inputCartridge);
            this.Controls.Add(this.inputPrinter);
            this.Controls.Add(this.inputBrand);
            this.Controls.Add(this.listBrand);
            this.Controls.Add(this.listPrinter);
            this.Controls.Add(this.addCartrige);
            this.Controls.Add(this.addPrinter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addBrand);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBrand;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addPrinter;
        private System.Windows.Forms.Button addCartrige;
        private System.Windows.Forms.ComboBox listPrinter;
        private System.Windows.Forms.ComboBox listBrand;
        private System.Windows.Forms.TextBox inputBrand;
        private System.Windows.Forms.TextBox inputPrinter;
        private System.Windows.Forms.TextBox inputCartridge;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartridge;
        private System.Windows.Forms.DataGridViewTextBoxColumn QT;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
    }
}

