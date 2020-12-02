namespace Compra_y_venta
{
    partial class VENTAS_FORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VENTAS_FORM));
            this.VENTAS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.INS_PRECIO = new System.Windows.Forms.TextBox();
            this.INS_TIPO_PAGO = new System.Windows.Forms.TextBox();
            this.INS_ID = new System.Windows.Forms.TextBox();
            this.VENDER_BUTTON = new System.Windows.Forms.Button();
            this.RECARGAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VENTAS)).BeginInit();
            this.SuspendLayout();
            // 
            // VENTAS
            // 
            this.VENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VENTAS.Location = new System.Drawing.Point(12, 12);
            this.VENTAS.Name = "VENTAS";
            this.VENTAS.Size = new System.Drawing.Size(645, 264);
            this.VENTAS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(8, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "VENDER PRODUCTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.label5.Location = new System.Drawing.Point(470, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "PRECIO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(331, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "TIPO DE PAGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(231, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID";
            // 
            // INS_PRECIO
            // 
            this.INS_PRECIO.Location = new System.Drawing.Point(473, 350);
            this.INS_PRECIO.Name = "INS_PRECIO";
            this.INS_PRECIO.Size = new System.Drawing.Size(100, 20);
            this.INS_PRECIO.TabIndex = 12;
            this.INS_PRECIO.TextChanged += new System.EventHandler(this.INS_TIPO_TextChanged);
            // 
            // INS_TIPO_PAGO
            // 
            this.INS_TIPO_PAGO.Location = new System.Drawing.Point(335, 350);
            this.INS_TIPO_PAGO.Name = "INS_TIPO_PAGO";
            this.INS_TIPO_PAGO.Size = new System.Drawing.Size(122, 20);
            this.INS_TIPO_PAGO.TabIndex = 11;
            // 
            // INS_ID
            // 
            this.INS_ID.Location = new System.Drawing.Point(229, 350);
            this.INS_ID.Name = "INS_ID";
            this.INS_ID.Size = new System.Drawing.Size(100, 20);
            this.INS_ID.TabIndex = 10;
            // 
            // VENDER_BUTTON
            // 
            this.VENDER_BUTTON.FlatAppearance.BorderSize = 0;
            this.VENDER_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VENDER_BUTTON.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VENDER_BUTTON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.VENDER_BUTTON.Image = ((System.Drawing.Image)(resources.GetObject("VENDER_BUTTON.Image")));
            this.VENDER_BUTTON.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VENDER_BUTTON.Location = new System.Drawing.Point(579, 325);
            this.VENDER_BUTTON.Name = "VENDER_BUTTON";
            this.VENDER_BUTTON.Size = new System.Drawing.Size(78, 55);
            this.VENDER_BUTTON.TabIndex = 16;
            this.VENDER_BUTTON.Text = "VENDER";
            this.VENDER_BUTTON.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VENDER_BUTTON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.VENDER_BUTTON.UseVisualStyleBackColor = true;
            this.VENDER_BUTTON.Click += new System.EventHandler(this.VENDER_BUTTON_Click);
            // 
            // RECARGAR
            // 
            this.RECARGAR.FlatAppearance.BorderSize = 0;
            this.RECARGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RECARGAR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECARGAR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.RECARGAR.Image = ((System.Drawing.Image)(resources.GetObject("RECARGAR.Image")));
            this.RECARGAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RECARGAR.Location = new System.Drawing.Point(628, 282);
            this.RECARGAR.Name = "RECARGAR";
            this.RECARGAR.Size = new System.Drawing.Size(29, 31);
            this.RECARGAR.TabIndex = 17;
            this.RECARGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RECARGAR.UseVisualStyleBackColor = true;
            this.RECARGAR.Click += new System.EventHandler(this.RECARGAR_Click);
            // 
            // VENTAS_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(669, 382);
            this.Controls.Add(this.RECARGAR);
            this.Controls.Add(this.VENDER_BUTTON);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.INS_PRECIO);
            this.Controls.Add(this.INS_TIPO_PAGO);
            this.Controls.Add(this.INS_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VENTAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VENTAS_FORM";
            this.Text = "VENTAS_FORM";
            this.Load += new System.EventHandler(this.VENTAS_FORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VENTAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView VENTAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox INS_PRECIO;
        private System.Windows.Forms.TextBox INS_TIPO_PAGO;
        private System.Windows.Forms.TextBox INS_ID;
        private System.Windows.Forms.Button VENDER_BUTTON;
        private System.Windows.Forms.Button RECARGAR;
    }
}