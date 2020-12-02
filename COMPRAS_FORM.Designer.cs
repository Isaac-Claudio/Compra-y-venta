namespace Compra_y_venta
{
    partial class COMPRAS_FORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COMPRAS_FORM));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.INS_NOMBRE = new System.Windows.Forms.TextBox();
            this.INS_PROVEEDOR = new System.Windows.Forms.TextBox();
            this.INS_TIPO = new System.Windows.Forms.TextBox();
            this.INS_PRECIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.REGISTRAR_COMPRA = new System.Windows.Forms.Button();
            this.RECARGAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 258);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(6, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "NUEVA COMPRA";
            // 
            // INS_NOMBRE
            // 
            this.INS_NOMBRE.Location = new System.Drawing.Point(10, 341);
            this.INS_NOMBRE.Name = "INS_NOMBRE";
            this.INS_NOMBRE.Size = new System.Drawing.Size(100, 20);
            this.INS_NOMBRE.TabIndex = 2;
            // 
            // INS_PROVEEDOR
            // 
            this.INS_PROVEEDOR.Location = new System.Drawing.Point(116, 341);
            this.INS_PROVEEDOR.Name = "INS_PROVEEDOR";
            this.INS_PROVEEDOR.Size = new System.Drawing.Size(122, 20);
            this.INS_PROVEEDOR.TabIndex = 3;
            // 
            // INS_TIPO
            // 
            this.INS_TIPO.Location = new System.Drawing.Point(244, 341);
            this.INS_TIPO.Name = "INS_TIPO";
            this.INS_TIPO.Size = new System.Drawing.Size(100, 20);
            this.INS_TIPO.TabIndex = 4;
            // 
            // INS_PRECIO
            // 
            this.INS_PRECIO.Location = new System.Drawing.Point(350, 341);
            this.INS_PRECIO.Name = "INS_PRECIO";
            this.INS_PRECIO.Size = new System.Drawing.Size(100, 20);
            this.INS_PRECIO.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(12, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(119, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "PROVEEDOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.label4.Location = new System.Drawing.Point(350, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "PRECIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.label5.Location = new System.Drawing.Point(241, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "TIPO";
            // 
            // REGISTRAR_COMPRA
            // 
            this.REGISTRAR_COMPRA.FlatAppearance.BorderSize = 0;
            this.REGISTRAR_COMPRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.REGISTRAR_COMPRA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTRAR_COMPRA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.REGISTRAR_COMPRA.Image = ((System.Drawing.Image)(resources.GetObject("REGISTRAR_COMPRA.Image")));
            this.REGISTRAR_COMPRA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.REGISTRAR_COMPRA.Location = new System.Drawing.Point(480, 309);
            this.REGISTRAR_COMPRA.Name = "REGISTRAR_COMPRA";
            this.REGISTRAR_COMPRA.Size = new System.Drawing.Size(115, 61);
            this.REGISTRAR_COMPRA.TabIndex = 10;
            this.REGISTRAR_COMPRA.Text = "REGISTRAR";
            this.REGISTRAR_COMPRA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.REGISTRAR_COMPRA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.REGISTRAR_COMPRA.UseVisualStyleBackColor = true;
            this.REGISTRAR_COMPRA.Click += new System.EventHandler(this.REGISTRAR_COMPRA_Click);
            // 
            // RECARGAR
            // 
            this.RECARGAR.FlatAppearance.BorderSize = 0;
            this.RECARGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RECARGAR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECARGAR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.RECARGAR.Image = ((System.Drawing.Image)(resources.GetObject("RECARGAR.Image")));
            this.RECARGAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RECARGAR.Location = new System.Drawing.Point(618, 276);
            this.RECARGAR.Name = "RECARGAR";
            this.RECARGAR.Size = new System.Drawing.Size(29, 31);
            this.RECARGAR.TabIndex = 11;
            this.RECARGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RECARGAR.UseVisualStyleBackColor = true;
            this.RECARGAR.Click += new System.EventHandler(this.RECARGAR_Click);
            // 
            // COMPRAS_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(669, 382);
            this.Controls.Add(this.RECARGAR);
            this.Controls.Add(this.REGISTRAR_COMPRA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.INS_PRECIO);
            this.Controls.Add(this.INS_TIPO);
            this.Controls.Add(this.INS_PROVEEDOR);
            this.Controls.Add(this.INS_NOMBRE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "COMPRAS_FORM";
            this.Text = "COMPRAS_FORM";
            this.Load += new System.EventHandler(this.COMPRAS_FORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox INS_NOMBRE;
        private System.Windows.Forms.TextBox INS_PROVEEDOR;
        private System.Windows.Forms.TextBox INS_TIPO;
        private System.Windows.Forms.TextBox INS_PRECIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button REGISTRAR_COMPRA;
        private System.Windows.Forms.Button RECARGAR;
    }
}