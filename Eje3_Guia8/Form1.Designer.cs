namespace Eje3_Guia8
{
    partial class Form1
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
            this.cmbFiguras = new System.Windows.Forms.ComboBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFiguras
            // 
            this.cmbFiguras.FormattingEnabled = true;
            this.cmbFiguras.Location = new System.Drawing.Point(29, 64);
            this.cmbFiguras.Name = "cmbFiguras";
            this.cmbFiguras.Size = new System.Drawing.Size(257, 21);
            this.cmbFiguras.TabIndex = 0;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(186, 238);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 1;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(186, 158);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 2;
            // 
            // btnDibujar
            // 
            this.btnDibujar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.Location = new System.Drawing.Point(53, 370);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(126, 46);
            this.btnDibujar.TabIndex = 3;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.LightGray;
            this.picCanvas.Location = new System.Drawing.Point(306, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(514, 404);
            this.picCanvas.TabIndex = 4;
            this.picCanvas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione la figura deseada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lado/base/radio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Altura **solo para triángulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = " Resultado área";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(122, 335);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 13);
            this.lblArea.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.cmbFiguras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFiguras;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblArea;
    }
}

