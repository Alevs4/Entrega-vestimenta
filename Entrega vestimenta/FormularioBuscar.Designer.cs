﻿namespace Entrega_vestimenta
{
    partial class FormularioBuscar
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
            this.formRedondo1 = new Entrega_vestimenta.Componentes.FormRedondo();
            this.botonesRedondos1 = new Entrega_vestimenta.Componentes.BotonesRedondos();
            this.BtnSalir = new Entrega_vestimenta.Componentes.BotonesRedondos();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRutBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new Entrega_vestimenta.Componentes.BotonesRedondos();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formRedondo1
            // 
            this.formRedondo1.CornerRadius = 30;
            this.formRedondo1.TargetControl = this;
            // 
            // botonesRedondos1
            // 
            this.botonesRedondos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botonesRedondos1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botonesRedondos1.BorderColor = System.Drawing.Color.Black;
            this.botonesRedondos1.BorderRadius = 15;
            this.botonesRedondos1.BorderSize = 2;
            this.botonesRedondos1.FlatAppearance.BorderSize = 0;
            this.botonesRedondos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonesRedondos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonesRedondos1.ForeColor = System.Drawing.Color.Black;
            this.botonesRedondos1.Location = new System.Drawing.Point(632, 4);
            this.botonesRedondos1.Name = "botonesRedondos1";
            this.botonesRedondos1.Size = new System.Drawing.Size(69, 46);
            this.botonesRedondos1.TabIndex = 257;
            this.botonesRedondos1.Text = "-";
            this.botonesRedondos1.TextColor = System.Drawing.Color.Black;
            this.botonesRedondos1.UseVisualStyleBackColor = false;
            this.botonesRedondos1.Click += new System.EventHandler(this.botonesRedondos1_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnSalir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnSalir.BorderColor = System.Drawing.Color.Black;
            this.BtnSalir.BorderRadius = 15;
            this.BtnSalir.BorderSize = 2;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(719, 4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSalir.Size = new System.Drawing.Size(67, 46);
            this.BtnSalir.TabIndex = 256;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextColor = System.Drawing.Color.White;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.botonesRedondos1);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Location = new System.Drawing.Point(-1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 57);
            this.panel1.TabIndex = 258;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 29);
            this.label1.TabIndex = 258;
            this.label1.Text = "Buscar personal para Editar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 29);
            this.label2.TabIndex = 259;
            this.label2.Text = "Rut";
            // 
            // TxtRutBuscar
            // 
            this.TxtRutBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRutBuscar.Location = new System.Drawing.Point(227, 230);
            this.TxtRutBuscar.Name = "TxtRutBuscar";
            this.TxtRutBuscar.Size = new System.Drawing.Size(326, 34);
            this.TxtRutBuscar.TabIndex = 260;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Blue;
            this.BtnBuscar.BackgroundColor = System.Drawing.Color.Blue;
            this.BtnBuscar.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.BorderRadius = 15;
            this.BtnBuscar.BorderSize = 2;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(588, 224);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(141, 46);
            this.BtnBuscar.TabIndex = 261;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextColor = System.Drawing.Color.White;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 262;
            this.label3.Text = "Ejemplo 11.111.111-1";
            // 
            // FormularioBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 420);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtRutBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioBuscar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.FormRedondo formRedondo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Componentes.BotonesRedondos botonesRedondos1;
        private Componentes.BotonesRedondos BtnSalir;
        private System.Windows.Forms.Label label3;
        private Componentes.BotonesRedondos BtnBuscar;
        private System.Windows.Forms.TextBox TxtRutBuscar;
        private System.Windows.Forms.Label label2;
    }
}