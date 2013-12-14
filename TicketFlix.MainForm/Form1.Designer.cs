namespace TicketFlix.MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gpCompra = new System.Windows.Forms.GroupBox();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.cbxOrden = new System.Windows.Forms.CheckBox();
            this.cbSalas = new System.Windows.Forms.ComboBox();
            this.pnAsientos = new System.Windows.Forms.Panel();
            this.pnDulce = new System.Windows.Forms.Panel();
            this.btDulce = new System.Windows.Forms.Button();
            this.cbSodas = new System.Windows.Forms.ComboBox();
            this.cbPalomitas = new System.Windows.Forms.ComboBox();
            this.nudSodas = new System.Windows.Forms.NumericUpDown();
            this.nudNachos = new System.Windows.Forms.NumericUpDown();
            this.nudPalomitas = new System.Windows.Forms.NumericUpDown();
            this.gpCompra.SuspendLayout();
            this.pnAsientos.SuspendLayout();
            this.pnDulce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPalomitas)).BeginInit();
            this.SuspendLayout();
            // 
            // gpCompra
            // 
            this.gpCompra.Controls.Add(this.cbHorario);
            this.gpCompra.Controls.Add(this.btFinalizar);
            this.gpCompra.Controls.Add(this.lbTotal);
            this.gpCompra.Controls.Add(this.cbxOrden);
            this.gpCompra.Controls.Add(this.cbSalas);
            this.gpCompra.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpCompra.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCompra.Location = new System.Drawing.Point(0, 0);
            this.gpCompra.Name = "gpCompra";
            this.gpCompra.Size = new System.Drawing.Size(212, 344);
            this.gpCompra.TabIndex = 1;
            this.gpCompra.TabStop = false;
            this.gpCompra.Text = "Sala";
            // 
            // cbHorario
            // 
            this.cbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorario.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Location = new System.Drawing.Point(6, 90);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(121, 24);
            this.cbHorario.TabIndex = 5;
            this.cbHorario.SelectedIndexChanged += new System.EventHandler(this.cbHorario_SelectedIndexChanged);
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(13, 283);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(179, 34);
            this.btFinalizar.TabIndex = 4;
            this.btFinalizar.Text = "Aceptar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(70, 233);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(57, 26);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "$ 0.00";
            // 
            // cbxOrden
            // 
            this.cbxOrden.AutoSize = true;
            this.cbxOrden.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrden.Location = new System.Drawing.Point(7, 179);
            this.cbxOrden.Name = "cbxOrden";
            this.cbxOrden.Size = new System.Drawing.Size(136, 24);
            this.cbxOrden.TabIndex = 2;
            this.cbxOrden.Text = "Alguna Orden?";
            this.cbxOrden.UseVisualStyleBackColor = true;
            this.cbxOrden.CheckedChanged += new System.EventHandler(this.cbxOrden_CheckedChanged);
            // 
            // cbSalas
            // 
            this.cbSalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalas.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalas.FormattingEnabled = true;
            this.cbSalas.Location = new System.Drawing.Point(6, 31);
            this.cbSalas.Name = "cbSalas";
            this.cbSalas.Size = new System.Drawing.Size(121, 24);
            this.cbSalas.TabIndex = 0;
            this.cbSalas.SelectedIndexChanged += new System.EventHandler(this.cbSalas_SelectedIndexChanged);
            // 
            // pnAsientos
            // 
            this.pnAsientos.Controls.Add(this.pnDulce);
            this.pnAsientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAsientos.Location = new System.Drawing.Point(212, 0);
            this.pnAsientos.Name = "pnAsientos";
            this.pnAsientos.Size = new System.Drawing.Size(384, 344);
            this.pnAsientos.TabIndex = 2;
            // 
            // pnDulce
            // 
            this.pnDulce.Controls.Add(this.btDulce);
            this.pnDulce.Controls.Add(this.cbSodas);
            this.pnDulce.Controls.Add(this.cbPalomitas);
            this.pnDulce.Controls.Add(this.nudSodas);
            this.pnDulce.Controls.Add(this.nudNachos);
            this.pnDulce.Controls.Add(this.nudPalomitas);
            this.pnDulce.Location = new System.Drawing.Point(0, 0);
            this.pnDulce.Name = "pnDulce";
            this.pnDulce.Size = new System.Drawing.Size(384, 344);
            this.pnDulce.TabIndex = 0;
            // 
            // btDulce
            // 
            this.btDulce.Location = new System.Drawing.Point(279, 278);
            this.btDulce.Name = "btDulce";
            this.btDulce.Size = new System.Drawing.Size(66, 28);
            this.btDulce.TabIndex = 5;
            this.btDulce.Text = "Ordenar";
            this.btDulce.UseVisualStyleBackColor = true;
            this.btDulce.Click += new System.EventHandler(this.btDulce_Click);
            // 
            // cbSodas
            // 
            this.cbSodas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSodas.FormattingEnabled = true;
            this.cbSodas.Items.AddRange(new object[] {
            "mediana",
            "grande"});
            this.cbSodas.Location = new System.Drawing.Point(155, 283);
            this.cbSodas.Name = "cbSodas";
            this.cbSodas.Size = new System.Drawing.Size(102, 21);
            this.cbSodas.TabIndex = 4;
            // 
            // cbPalomitas
            // 
            this.cbPalomitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPalomitas.FormattingEnabled = true;
            this.cbPalomitas.Items.AddRange(new object[] {
            "mediana",
            "grande"});
            this.cbPalomitas.Location = new System.Drawing.Point(23, 283);
            this.cbPalomitas.Name = "cbPalomitas";
            this.cbPalomitas.Size = new System.Drawing.Size(102, 21);
            this.cbPalomitas.TabIndex = 3;
            // 
            // nudSodas
            // 
            this.nudSodas.Location = new System.Drawing.Point(155, 239);
            this.nudSodas.Name = "nudSodas";
            this.nudSodas.Size = new System.Drawing.Size(33, 20);
            this.nudSodas.TabIndex = 2;
            // 
            // nudNachos
            // 
            this.nudNachos.Location = new System.Drawing.Point(286, 239);
            this.nudNachos.Name = "nudNachos";
            this.nudNachos.Size = new System.Drawing.Size(34, 20);
            this.nudNachos.TabIndex = 1;
            // 
            // nudPalomitas
            // 
            this.nudPalomitas.Location = new System.Drawing.Point(23, 239);
            this.nudPalomitas.Name = "nudPalomitas";
            this.nudPalomitas.Size = new System.Drawing.Size(34, 20);
            this.nudPalomitas.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 344);
            this.Controls.Add(this.pnAsientos);
            this.Controls.Add(this.gpCompra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TicketFlix: Asientos&Munchies";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpCompra.ResumeLayout(false);
            this.gpCompra.PerformLayout();
            this.pnAsientos.ResumeLayout(false);
            this.pnDulce.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPalomitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpCompra;
        private System.Windows.Forms.ComboBox cbSalas;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.CheckBox cbxOrden;
        private System.Windows.Forms.Panel pnAsientos;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.Panel pnDulce;
        private System.Windows.Forms.ComboBox cbSodas;
        private System.Windows.Forms.ComboBox cbPalomitas;
        private System.Windows.Forms.NumericUpDown nudSodas;
        private System.Windows.Forms.NumericUpDown nudNachos;
        private System.Windows.Forms.NumericUpDown nudPalomitas;
        private System.Windows.Forms.Button btDulce;


    }
}

