namespace Compra_y_venta
{
    partial class MAIN_SCREEN
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN_SCREEN));
            this.Pantalla_principal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.STOCK_BUTTON = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.COMPRAS_BUTTON = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.VENTAS_BUTTON = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.EXIT_BUTTON = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pantalla_principal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pantalla_principal
            // 
            this.Pantalla_principal.Controls.Add(this.pictureBox1);
            this.Pantalla_principal.Location = new System.Drawing.Point(114, 33);
            this.Pantalla_principal.Name = "Pantalla_principal";
            this.Pantalla_principal.Size = new System.Drawing.Size(685, 421);
            this.Pantalla_principal.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-2, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 37);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(-2, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 418);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.STOCK_BUTTON);
            this.panel4.Location = new System.Drawing.Point(3, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 75);
            this.panel4.TabIndex = 0;
            // 
            // STOCK_BUTTON
            // 
            this.STOCK_BUTTON.FlatAppearance.BorderSize = 0;
            this.STOCK_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.STOCK_BUTTON.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STOCK_BUTTON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.STOCK_BUTTON.Image = ((System.Drawing.Image)(resources.GetObject("STOCK_BUTTON.Image")));
            this.STOCK_BUTTON.Location = new System.Drawing.Point(0, 0);
            this.STOCK_BUTTON.Name = "STOCK_BUTTON";
            this.STOCK_BUTTON.Size = new System.Drawing.Size(114, 75);
            this.STOCK_BUTTON.TabIndex = 0;
            this.STOCK_BUTTON.Text = "STOCK";
            this.STOCK_BUTTON.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.STOCK_BUTTON.UseVisualStyleBackColor = false;
            this.STOCK_BUTTON.Click += new System.EventHandler(this.STOCK_BUTTON_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.COMPRAS_BUTTON);
            this.panel5.Location = new System.Drawing.Point(3, 127);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 75);
            this.panel5.TabIndex = 1;
            // 
            // COMPRAS_BUTTON
            // 
            this.COMPRAS_BUTTON.FlatAppearance.BorderSize = 0;
            this.COMPRAS_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMPRAS_BUTTON.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPRAS_BUTTON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.COMPRAS_BUTTON.Image = ((System.Drawing.Image)(resources.GetObject("COMPRAS_BUTTON.Image")));
            this.COMPRAS_BUTTON.Location = new System.Drawing.Point(0, 0);
            this.COMPRAS_BUTTON.Name = "COMPRAS_BUTTON";
            this.COMPRAS_BUTTON.Size = new System.Drawing.Size(114, 75);
            this.COMPRAS_BUTTON.TabIndex = 0;
            this.COMPRAS_BUTTON.Text = "COMPRAS";
            this.COMPRAS_BUTTON.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.COMPRAS_BUTTON.UseVisualStyleBackColor = false;
            this.COMPRAS_BUTTON.Click += new System.EventHandler(this.COMPRAS_BUTTON_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.VENTAS_BUTTON);
            this.panel6.Location = new System.Drawing.Point(3, 208);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(114, 75);
            this.panel6.TabIndex = 1;
            // 
            // VENTAS_BUTTON
            // 
            this.VENTAS_BUTTON.FlatAppearance.BorderSize = 0;
            this.VENTAS_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VENTAS_BUTTON.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VENTAS_BUTTON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.VENTAS_BUTTON.Image = ((System.Drawing.Image)(resources.GetObject("VENTAS_BUTTON.Image")));
            this.VENTAS_BUTTON.Location = new System.Drawing.Point(0, 0);
            this.VENTAS_BUTTON.Name = "VENTAS_BUTTON";
            this.VENTAS_BUTTON.Size = new System.Drawing.Size(114, 75);
            this.VENTAS_BUTTON.TabIndex = 0;
            this.VENTAS_BUTTON.Text = "VENTAS";
            this.VENTAS_BUTTON.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VENTAS_BUTTON.UseVisualStyleBackColor = false;
            this.VENTAS_BUTTON.Click += new System.EventHandler(this.VENTAS_BUTTON_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.EXIT_BUTTON);
            this.panel7.Location = new System.Drawing.Point(3, 289);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(114, 75);
            this.panel7.TabIndex = 1;
            // 
            // EXIT_BUTTON
            // 
            this.EXIT_BUTTON.FlatAppearance.BorderSize = 0;
            this.EXIT_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXIT_BUTTON.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT_BUTTON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.EXIT_BUTTON.Image = ((System.Drawing.Image)(resources.GetObject("EXIT_BUTTON.Image")));
            this.EXIT_BUTTON.Location = new System.Drawing.Point(0, 0);
            this.EXIT_BUTTON.Name = "EXIT_BUTTON";
            this.EXIT_BUTTON.Size = new System.Drawing.Size(114, 75);
            this.EXIT_BUTTON.TabIndex = 0;
            this.EXIT_BUTTON.Text = "SALIR";
            this.EXIT_BUTTON.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EXIT_BUTTON.UseVisualStyleBackColor = false;
            this.EXIT_BUTTON.Click += new System.EventHandler(this.EXIT_BUTTON_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPRA Y VENTA";
            // 
            // MAIN_SCREEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Pantalla_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MAIN_SCREEN";
            this.Text = "Compra y Venta";
            this.Pantalla_principal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pantalla_principal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button EXIT_BUTTON;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button VENTAS_BUTTON;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button COMPRAS_BUTTON;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button STOCK_BUTTON;
    }
}

