namespace Ejercicio
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.LbFiltro = new System.Windows.Forms.Label();
            this.filtro = new System.Windows.Forms.TextBox();
            this.dgvEntidad = new System.Windows.Forms.DataGridView();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidad)).BeginInit();
            this.SuspendLayout();
            // 
            // LbFiltro
            // 
            this.LbFiltro.AutoSize = true;
            this.LbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFiltro.Location = new System.Drawing.Point(42, 502);
            this.LbFiltro.Name = "LbFiltro";
            this.LbFiltro.Size = new System.Drawing.Size(50, 20);
            this.LbFiltro.TabIndex = 0;
            this.LbFiltro.Text = "Filtro";
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(110, 499);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(217, 26);
            this.filtro.TabIndex = 1;
            this.filtro.TextChanged += new System.EventHandler(this.filtro_TextChanged);
            // 
            // dgvEntidad
            // 
            this.dgvEntidad.AllowUserToAddRows = false;
            this.dgvEntidad.AllowUserToDeleteRows = false;
            this.dgvEntidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntidad.Location = new System.Drawing.Point(37, 95);
            this.dgvEntidad.Name = "dgvEntidad";
            this.dgvEntidad.ReadOnly = true;
            this.dgvEntidad.RowHeadersWidth = 62;
            this.dgvEntidad.RowTemplate.Height = 28;
            this.dgvEntidad.Size = new System.Drawing.Size(879, 351);
            this.dgvEntidad.TabIndex = 2;
            this.dgvEntidad.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            // 
            // ComboBox
            // 
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(46, 30);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(215, 28);
            this.ComboBox.TabIndex = 3;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(422, 486);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(103, 52);
            this.btnAlta.TabIndex = 4;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(553, 486);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(103, 52);
            this.btnBaja.TabIndex = 5;
            this.btnBaja.Text = "BAJA";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(686, 486);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(103, 52);
            this.btnInforme.TabIndex = 6;
            this.btnInforme.Text = "INFORME";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(819, 486);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 52);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "CERRAR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 565);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.dgvEntidad);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.LbFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbFiltro;
        private System.Windows.Forms.TextBox filtro;
        private System.Windows.Forms.DataGridView dgvEntidad;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnSalir;
    }
}