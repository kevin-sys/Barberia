﻿namespace BarberiaGUI
{
    partial class FrmConsultarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarProveedor));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnConsultar = new System.Windows.Forms.PictureBox();
            this.DtaTablaEmpleados = new System.Windows.Forms.DataGridView();
            this.PnlMenuVertical = new System.Windows.Forms.Panel();
            this.BtnGestion = new System.Windows.Forms.Button();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlBarraTitulo = new System.Windows.Forms.Panel();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.Btncerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtaTablaEmpleados)).BeginInit();
            this.PnlMenuVertical.SuspendLayout();
            this.PnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(453, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 40);
            this.label2.TabIndex = 100;
            this.label2.Text = "Consultar Proveedores";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(840, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 99;
            this.label1.Text = "Consultar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(304, 429);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 22);
            this.label21.TabIndex = 98;
            this.label21.Text = "Volver";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::BarberiaGUI.Properties.Resources.anterior;
            this.pictureBox3.Location = new System.Drawing.Point(296, 369);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 97;
            this.pictureBox3.TabStop = false;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultar.Image = global::BarberiaGUI.Properties.Resources.consultar;
            this.BtnConsultar.Location = new System.Drawing.Point(839, 369);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(84, 57);
            this.BtnConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnConsultar.TabIndex = 96;
            this.BtnConsultar.TabStop = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // DtaTablaEmpleados
            // 
            this.DtaTablaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtaTablaEmpleados.Location = new System.Drawing.Point(296, 142);
            this.DtaTablaEmpleados.Name = "DtaTablaEmpleados";
            this.DtaTablaEmpleados.Size = new System.Drawing.Size(627, 202);
            this.DtaTablaEmpleados.TabIndex = 95;
            this.DtaTablaEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaTablaEmpleados_CellContentDoubleClick);
            this.DtaTablaEmpleados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaTablaEmpleados_CellContentDoubleClick);
            // 
            // PnlMenuVertical
            // 
            this.PnlMenuVertical.BackColor = System.Drawing.Color.SaddleBrown;
            this.PnlMenuVertical.Controls.Add(this.BtnGestion);
            this.PnlMenuVertical.Controls.Add(this.BtnVentas);
            this.PnlMenuVertical.Controls.Add(this.button1);
            this.PnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.PnlMenuVertical.Name = "PnlMenuVertical";
            this.PnlMenuVertical.Size = new System.Drawing.Size(250, 479);
            this.PnlMenuVertical.TabIndex = 101;
            // 
            // BtnGestion
            // 
            this.BtnGestion.FlatAppearance.BorderSize = 2;
            this.BtnGestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestion.ForeColor = System.Drawing.Color.White;
            this.BtnGestion.Location = new System.Drawing.Point(0, 225);
            this.BtnGestion.Name = "BtnGestion";
            this.BtnGestion.Size = new System.Drawing.Size(250, 40);
            this.BtnGestion.TabIndex = 3;
            this.BtnGestion.Text = "Gestión";
            this.BtnGestion.UseVisualStyleBackColor = true;
            // 
            // BtnVentas
            // 
            this.BtnVentas.FlatAppearance.BorderSize = 2;
            this.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.ForeColor = System.Drawing.Color.White;
            this.BtnVentas.Location = new System.Drawing.Point(0, 290);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(250, 40);
            this.BtnVentas.TabIndex = 2;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PnlBarraTitulo
            // 
            this.PnlBarraTitulo.BackColor = System.Drawing.Color.SaddleBrown;
            this.PnlBarraTitulo.Controls.Add(this.BtnRestaurar);
            this.PnlBarraTitulo.Controls.Add(this.BtnMaximizar);
            this.PnlBarraTitulo.Controls.Add(this.BtnMinimizar);
            this.PnlBarraTitulo.Controls.Add(this.Btncerrar);
            this.PnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.PnlBarraTitulo.Name = "PnlBarraTitulo";
            this.PnlBarraTitulo.Size = new System.Drawing.Size(757, 45);
            this.PnlBarraTitulo.TabIndex = 102;
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestaurar.Image")));
            this.BtnRestaurar.Location = new System.Drawing.Point(607, 3);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(45, 36);
            this.BtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRestaurar.TabIndex = 3;
            this.BtnRestaurar.TabStop = false;
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.Location = new System.Drawing.Point(658, 3);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(45, 36);
            this.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMaximizar.TabIndex = 2;
            this.BtnMaximizar.TabStop = false;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(556, 3);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(45, 36);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 1;
            this.BtnMinimizar.TabStop = false;
            // 
            // Btncerrar
            // 
            this.Btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btncerrar.Image")));
            this.Btncerrar.Location = new System.Drawing.Point(709, 3);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(45, 36);
            this.Btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btncerrar.TabIndex = 0;
            this.Btncerrar.TabStop = false;
            // 
            // FrmConsultarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 479);
            this.Controls.Add(this.PnlBarraTitulo);
            this.Controls.Add(this.PnlMenuVertical);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.DtaTablaEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarProveedor";
            this.Text = "FrmConsultarProveedor";
            this.Load += new System.EventHandler(this.FrmConsultarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtaTablaEmpleados)).EndInit();
            this.PnlMenuVertical.ResumeLayout(false);
            this.PnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btncerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox BtnConsultar;
        private System.Windows.Forms.DataGridView DtaTablaEmpleados;
        private System.Windows.Forms.Panel PnlMenuVertical;
        private System.Windows.Forms.Button BtnGestion;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PnlBarraTitulo;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox Btncerrar;
    }
}