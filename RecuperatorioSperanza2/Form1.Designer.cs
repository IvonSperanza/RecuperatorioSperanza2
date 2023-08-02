using System;
using System.Windows.Forms;

namespace RecuperatorioSperanza2
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
            this.dgvSalasYAsistentes = new System.Windows.Forms.DataGridView();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.btnAgregarPelicula = new System.Windows.Forms.Button();
            this.btnAgregarSala = new System.Windows.Forms.Button();
            this.txtNombreSala = new System.Windows.Forms.TextBox();
            this.btnVenderEntrada = new System.Windows.Forms.Button();
            this.chkEsJubilado = new System.Windows.Forms.CheckBox();
            this.cmbTipoSalaEntrada = new System.Windows.Forms.ComboBox();
            this.lstPeliculas = new System.Windows.Forms.ListBox();
            this.cmbTipoSala = new System.Windows.Forms.ComboBox();
            this.txtAsistentesJubilados = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalasYAsistentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalasYAsistentes
            // 
            this.dgvSalasYAsistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalasYAsistentes.Location = new System.Drawing.Point(12, 243);
            this.dgvSalasYAsistentes.Name = "dgvSalasYAsistentes";
            this.dgvSalasYAsistentes.RowHeadersWidth = 62;
            this.dgvSalasYAsistentes.RowTemplate.Height = 28;
            this.dgvSalasYAsistentes.Size = new System.Drawing.Size(257, 195);
            this.dgvSalasYAsistentes.TabIndex = 0;
            this.dgvSalasYAsistentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Location = new System.Drawing.Point(275, 243);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.RowHeadersWidth = 62;
            this.dgvEntradas.RowTemplate.Height = 28;
            this.dgvEntradas.Size = new System.Drawing.Size(257, 195);
            this.dgvEntradas.TabIndex = 3;
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(538, 243);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.RowHeadersWidth = 62;
            this.dgvPeliculas.RowTemplate.Height = 28;
            this.dgvPeliculas.Size = new System.Drawing.Size(257, 195);
            this.dgvPeliculas.TabIndex = 4;
            // 
            // btnAgregarPelicula
            // 
            this.btnAgregarPelicula.Location = new System.Drawing.Point(538, 12);
            this.btnAgregarPelicula.Name = "btnAgregarPelicula";
            this.btnAgregarPelicula.Size = new System.Drawing.Size(150, 37);
            this.btnAgregarPelicula.TabIndex = 5;
            this.btnAgregarPelicula.Text = "Agregar Pelicula";
            this.btnAgregarPelicula.UseVisualStyleBackColor = true;
            this.btnAgregarPelicula.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregarSala
            // 
            this.btnAgregarSala.Location = new System.Drawing.Point(31, 26);
            this.btnAgregarSala.Name = "btnAgregarSala";
            this.btnAgregarSala.Size = new System.Drawing.Size(130, 32);
            this.btnAgregarSala.TabIndex = 7;
            this.btnAgregarSala.Text = "Agregar Sala";
            this.btnAgregarSala.UseVisualStyleBackColor = true;
            this.btnAgregarSala.Click += new System.EventHandler(this.btnAgregarSala_Click);
            // 
            // txtNombreSala
            // 
            this.txtNombreSala.Location = new System.Drawing.Point(31, 73);
            this.txtNombreSala.Name = "txtNombreSala";
            this.txtNombreSala.Size = new System.Drawing.Size(100, 26);
            this.txtNombreSala.TabIndex = 8;
            this.txtNombreSala.Text = "NombreSala";
            this.txtNombreSala.TextChanged += new System.EventHandler(this.txtNombreSala_TextChanged);
            // 
            // btnVenderEntrada
            // 
            this.btnVenderEntrada.Location = new System.Drawing.Point(275, 26);
            this.btnVenderEntrada.Name = "btnVenderEntrada";
            this.btnVenderEntrada.Size = new System.Drawing.Size(130, 32);
            this.btnVenderEntrada.TabIndex = 9;
            this.btnVenderEntrada.Text = "Venta Entrada";
            this.btnVenderEntrada.UseVisualStyleBackColor = true;
            this.btnVenderEntrada.Click += new System.EventHandler(this.btnVenderEntrada_Click);
            // 
            // chkEsJubilado
            // 
            this.chkEsJubilado.AutoSize = true;
            this.chkEsJubilado.Location = new System.Drawing.Point(284, 65);
            this.chkEsJubilado.Name = "chkEsJubilado";
            this.chkEsJubilado.Size = new System.Drawing.Size(94, 24);
            this.chkEsJubilado.TabIndex = 10;
            this.chkEsJubilado.Text = "Jubilado";
            this.chkEsJubilado.UseVisualStyleBackColor = true;
            this.chkEsJubilado.CheckedChanged += new System.EventHandler(this.chkEsJubilado_CheckedChanged);
            // 
            // cmbTipoSalaEntrada
            // 
            this.cmbTipoSalaEntrada.FormattingEnabled = true;
            this.cmbTipoSalaEntrada.Location = new System.Drawing.Point(275, 96);
            this.cmbTipoSalaEntrada.Name = "cmbTipoSalaEntrada";
            this.cmbTipoSalaEntrada.Size = new System.Drawing.Size(155, 28);
            this.cmbTipoSalaEntrada.TabIndex = 11;
            this.cmbTipoSalaEntrada.Text = "Tipo sala entrada";
            // 
            // lstPeliculas
            // 
            this.lstPeliculas.FormattingEnabled = true;
            this.lstPeliculas.ItemHeight = 20;
            this.lstPeliculas.Items.AddRange(new object[] {
            "Titanic",
            "Barbie",
            "Batman"});
            this.lstPeliculas.Location = new System.Drawing.Point(538, 87);
            this.lstPeliculas.Name = "lstPeliculas";
            this.lstPeliculas.Size = new System.Drawing.Size(184, 64);
            this.lstPeliculas.TabIndex = 12;
            // 
            // cmbTipoSala
            // 
            this.cmbTipoSala.FormattingEnabled = true;
            this.cmbTipoSala.Location = new System.Drawing.Point(538, 157);
            this.cmbTipoSala.Name = "cmbTipoSala";
            this.cmbTipoSala.Size = new System.Drawing.Size(155, 28);
            this.cmbTipoSala.TabIndex = 13;
            this.cmbTipoSala.Text = "Tipo sala ";
            // 
            // txtAsistentesJubilados
            // 
            this.txtAsistentesJubilados.Location = new System.Drawing.Point(284, 147);
            this.txtAsistentesJubilados.Name = "txtAsistentesJubilados";
            this.txtAsistentesJubilados.Size = new System.Drawing.Size(159, 26);
            this.txtAsistentesJubilados.TabIndex = 14;
            this.txtAsistentesJubilados.Text = "Cantidad Jubiilados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAsistentesJubilados);
            this.Controls.Add(this.cmbTipoSala);
            this.Controls.Add(this.lstPeliculas);
            this.Controls.Add(this.cmbTipoSalaEntrada);
            this.Controls.Add(this.chkEsJubilado);
            this.Controls.Add(this.btnVenderEntrada);
            this.Controls.Add(this.txtNombreSala);
            this.Controls.Add(this.btnAgregarSala);
            this.Controls.Add(this.btnAgregarPelicula);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.dgvEntradas);
            this.Controls.Add(this.dgvSalasYAsistentes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalasYAsistentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalasYAsistentes;
        private DataGridView dgvEntradas;
        private DataGridView dgvPeliculas;
        private Button btnAgregarPelicula;
        private Button btnAgregarSala;
        private TextBox txtNombreSala;
        private Button btnVenderEntrada;
        private CheckBox chkEsJubilado;
        private ComboBox cmbTipoSalaEntrada;
        private ListBox lstPeliculas;
        private ComboBox cmbTipoSala;
        private TextBox txtAsistentesJubilados;
    }
}

