namespace WfaAbstrato
{
    partial class FrmCalcular
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCalcular = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.cmbObjetos = new System.Windows.Forms.ComboBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblRaio = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbForma = new System.Windows.Forms.ComboBox();
            this.gbCalcular.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCalcular
            // 
            this.gbCalcular.Controls.Add(this.btnSair);
            this.gbCalcular.Controls.Add(this.cmbObjetos);
            this.gbCalcular.Controls.Add(this.txtBase);
            this.gbCalcular.Controls.Add(this.txtAltura);
            this.gbCalcular.Controls.Add(this.txtRaio);
            this.gbCalcular.Controls.Add(this.txtArea);
            this.gbCalcular.Controls.Add(this.txtPerimetro);
            this.gbCalcular.Controls.Add(this.lblPerimetro);
            this.gbCalcular.Controls.Add(this.btnCriar);
            this.gbCalcular.Controls.Add(this.lblArea);
            this.gbCalcular.Controls.Add(this.lblRaio);
            this.gbCalcular.Controls.Add(this.lblAltura);
            this.gbCalcular.Controls.Add(this.lblBase);
            this.gbCalcular.Controls.Add(this.cmbTipo);
            this.gbCalcular.Controls.Add(this.cmbForma);
            this.gbCalcular.Location = new System.Drawing.Point(12, 12);
            this.gbCalcular.Name = "gbCalcular";
            this.gbCalcular.Size = new System.Drawing.Size(776, 164);
            this.gbCalcular.TabIndex = 0;
            this.gbCalcular.TabStop = false;
            this.gbCalcular.Text = "Informações";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(603, 35);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(73, 21);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cmbObjetos
            // 
            this.cmbObjetos.FormattingEnabled = true;
            this.cmbObjetos.Location = new System.Drawing.Point(402, 35);
            this.cmbObjetos.Name = "cmbObjetos";
            this.cmbObjetos.Size = new System.Drawing.Size(145, 21);
            this.cmbObjetos.TabIndex = 13;
            this.cmbObjetos.SelectedIndexChanged += new System.EventHandler(this.cmbObjetos_SelectedIndexChanged);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(56, 74);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 12;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(56, 98);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 11;
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(56, 124);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(100, 20);
            this.txtRaio.TabIndex = 10;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(306, 74);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 9;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(328, 102);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(100, 20);
            this.txtPerimetro.TabIndex = 8;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(271, 105);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(51, 13);
            this.lblPerimetro.TabIndex = 7;
            this.lblPerimetro.Text = "Perimetro";
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(274, 33);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 6;
            this.btnCriar.Text = "&Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(271, 77);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Area";
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(19, 126);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(29, 13);
            this.lblRaio.TabIndex = 4;
            this.lblRaio.Text = "Raio";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(16, 101);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(19, 77);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Base";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Equilatero",
            "Isosceles",
            "Reto"});
            this.cmbTipo.Location = new System.Drawing.Point(158, 33);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(93, 21);
            this.cmbTipo.TabIndex = 1;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // cmbForma
            // 
            this.cmbForma.FormattingEnabled = true;
            this.cmbForma.Items.AddRange(new object[] {
            "Circunferencia",
            "Quadrado",
            "Triangulo",
            "Retangulo"});
            this.cmbForma.Location = new System.Drawing.Point(22, 33);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(95, 21);
            this.cmbForma.TabIndex = 0;
            this.cmbForma.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmCalcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCalcular);
            this.Name = "FrmCalcular";
            this.Text = "Calcular";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalcular_FormClosing);
            this.gbCalcular.ResumeLayout(false);
            this.gbCalcular.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCalcular;
        private System.Windows.Forms.ComboBox cmbForma;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbObjetos;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Button btnSair;
    }
}

