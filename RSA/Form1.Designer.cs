namespace RSA
{
    partial class Form1
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
            this.cbxP = new System.Windows.Forms.ComboBox();
            this.lblP = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.cbxQ = new System.Windows.Forms.ComboBox();
            this.lblN = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.lblE = new System.Windows.Forms.Label();
            this.btnCriarChaves = new System.Windows.Forms.Button();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblCriptografado = new System.Windows.Forms.Label();
            this.txtCriptografado = new System.Windows.Forms.TextBox();
            this.lblDescriptografado = new System.Windows.Forms.Label();
            this.txtDescriptografado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxP
            // 
            this.cbxP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxP.FormattingEnabled = true;
            this.cbxP.Items.AddRange(new object[] {
            "2",
            "3",
            "5",
            "7",
            "11",
            "13",
            "17",
            "19",
            "23",
            "29",
            "31",
            "37",
            "41",
            "43",
            "47",
            "53",
            "59",
            "61",
            "67",
            "71",
            "73",
            "79",
            "83",
            "89",
            "97"});
            this.cbxP.Location = new System.Drawing.Point(41, 9);
            this.cbxP.Name = "cbxP";
            this.cbxP.Size = new System.Drawing.Size(43, 24);
            this.cbxP.TabIndex = 0;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(12, 16);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(23, 17);
            this.lblP.TabIndex = 1;
            this.lblP.Text = "P:";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.Location = new System.Drawing.Point(12, 53);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(25, 17);
            this.lblQ.TabIndex = 3;
            this.lblQ.Text = "Q:";
            // 
            // cbxQ
            // 
            this.cbxQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxQ.FormattingEnabled = true;
            this.cbxQ.Items.AddRange(new object[] {
            "2",
            "3",
            "5",
            "7",
            "11",
            "13",
            "17",
            "19",
            "23",
            "29",
            "31",
            "37",
            "41",
            "43",
            "47",
            "53",
            "59",
            "61",
            "67",
            "71",
            "73",
            "79",
            "83",
            "89",
            "97"});
            this.cbxQ.Location = new System.Drawing.Point(41, 46);
            this.cbxQ.Name = "cbxQ";
            this.cbxQ.Size = new System.Drawing.Size(43, 24);
            this.cbxQ.TabIndex = 2;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(109, 16);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(24, 17);
            this.lblN.TabIndex = 4;
            this.lblN.Text = "N:";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZ.Location = new System.Drawing.Point(109, 53);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(23, 17);
            this.lblZ.TabIndex = 5;
            this.lblZ.Text = "Z:";
            // 
            // txtN
            // 
            this.txtN.Enabled = false;
            this.txtN.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(139, 9);
            this.txtN.Name = "txtN";
            this.txtN.ReadOnly = true;
            this.txtN.Size = new System.Drawing.Size(43, 24);
            this.txtN.TabIndex = 6;
            // 
            // txtZ
            // 
            this.txtZ.Enabled = false;
            this.txtZ.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZ.Location = new System.Drawing.Point(138, 47);
            this.txtZ.Name = "txtZ";
            this.txtZ.ReadOnly = true;
            this.txtZ.Size = new System.Drawing.Size(43, 24);
            this.txtZ.TabIndex = 7;
            // 
            // txtD
            // 
            this.txtD.Enabled = false;
            this.txtD.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(236, 9);
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(43, 24);
            this.txtD.TabIndex = 9;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(206, 16);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(24, 17);
            this.lblD.TabIndex = 8;
            this.lblD.Text = "D:";
            // 
            // txtE
            // 
            this.txtE.Enabled = false;
            this.txtE.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.Location = new System.Drawing.Point(236, 47);
            this.txtE.Name = "txtE";
            this.txtE.ReadOnly = true;
            this.txtE.Size = new System.Drawing.Size(43, 24);
            this.txtE.TabIndex = 11;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(206, 54);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(23, 17);
            this.lblE.TabIndex = 10;
            this.lblE.Text = "E:";
            // 
            // btnCriarChaves
            // 
            this.btnCriarChaves.FlatAppearance.BorderSize = 0;
            this.btnCriarChaves.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriarChaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarChaves.Location = new System.Drawing.Point(296, 10);
            this.btnCriarChaves.Name = "btnCriarChaves";
            this.btnCriarChaves.Size = new System.Drawing.Size(75, 61);
            this.btnCriarChaves.TabIndex = 12;
            this.btnCriarChaves.Text = "Gerar Chaves";
            this.btnCriarChaves.UseVisualStyleBackColor = true;
            this.btnCriarChaves.Click += new System.EventHandler(this.btnCriarChaves_Click);
            // 
            // txtOriginal
            // 
            this.txtOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginal.Location = new System.Drawing.Point(12, 109);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(359, 23);
            this.txtOriginal.TabIndex = 13;
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginal.Location = new System.Drawing.Point(12, 89);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(115, 17);
            this.lblOriginal.TabIndex = 14;
            this.lblOriginal.Text = "Texto Original:";
            // 
            // lblCriptografado
            // 
            this.lblCriptografado.AutoSize = true;
            this.lblCriptografado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriptografado.Location = new System.Drawing.Point(12, 141);
            this.lblCriptografado.Name = "lblCriptografado";
            this.lblCriptografado.Size = new System.Drawing.Size(112, 17);
            this.lblCriptografado.TabIndex = 16;
            this.lblCriptografado.Text = "Criptografado:";
            // 
            // txtCriptografado
            // 
            this.txtCriptografado.Enabled = false;
            this.txtCriptografado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriptografado.Location = new System.Drawing.Point(12, 161);
            this.txtCriptografado.Name = "txtCriptografado";
            this.txtCriptografado.ReadOnly = true;
            this.txtCriptografado.Size = new System.Drawing.Size(359, 23);
            this.txtCriptografado.TabIndex = 15;
            this.txtCriptografado.TextChanged += new System.EventHandler(this.txtCriptografado_TextChanged);
            // 
            // lblDescriptografado
            // 
            this.lblDescriptografado.AutoSize = true;
            this.lblDescriptografado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptografado.Location = new System.Drawing.Point(12, 193);
            this.lblDescriptografado.Name = "lblDescriptografado";
            this.lblDescriptografado.Size = new System.Drawing.Size(138, 17);
            this.lblDescriptografado.TabIndex = 18;
            this.lblDescriptografado.Text = "Descriptografado:";
            // 
            // txtDescriptografado
            // 
            this.txtDescriptografado.Enabled = false;
            this.txtDescriptografado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptografado.Location = new System.Drawing.Point(12, 213);
            this.txtDescriptografado.Name = "txtDescriptografado";
            this.txtDescriptografado.ReadOnly = true;
            this.txtDescriptografado.Size = new System.Drawing.Size(359, 23);
            this.txtDescriptografado.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(387, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 61);
            this.button1.TabIndex = 19;
            this.button1.Text = "Executar RSA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 248);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDescriptografado);
            this.Controls.Add(this.txtDescriptografado);
            this.Controls.Add(this.lblCriptografado);
            this.Controls.Add(this.txtCriptografado);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.btnCriarChaves);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.cbxQ);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.cbxP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxP;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.ComboBox cbxQ;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Button btnCriarChaves;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblCriptografado;
        private System.Windows.Forms.TextBox txtCriptografado;
        private System.Windows.Forms.Label lblDescriptografado;
        private System.Windows.Forms.TextBox txtDescriptografado;
        private System.Windows.Forms.Button button1;
    }
}

