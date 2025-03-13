namespace WFCadastroEnderecoo
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            btnSalvar = new Button();
            lblCep = new Label();
            lblLinha = new Label();
            txtLogradouro = new TextBox();
            lblLogradouro = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            mtbCep = new MaskedTextBox();
            lblBairro = new Label();
            lblCidade = new Label();
            lblUf = new Label();
            chkSemNumero = new CheckBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            cbxUf = new ComboBox();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(23, 18);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(23, 36);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(379, 23);
            txtNomeCompleto.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(339, 410);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 32);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(23, 98);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 9;
            lblCep.Text = "Cep";
            // 
            // lblLinha
            // 
            lblLinha.BorderStyle = BorderStyle.Fixed3D;
            lblLinha.Location = new Point(-4, 75);
            lblLinha.Name = "lblLinha";
            lblLinha.Size = new Size(452, 14);
            lblLinha.TabIndex = 11;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(23, 202);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(178, 23);
            txtLogradouro.TabIndex = 2;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(23, 169);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 13;
            lblLogradouro.Text = "Logradouro";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(219, 202);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(98, 23);
            txtNumero.TabIndex = 3;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(219, 169);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 16;
            lblNumero.Text = "Número";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(12, 274);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(132, 23);
            txtComplemento.TabIndex = 5;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(12, 256);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 18;
            lblComplemento.Text = "Complemento";
            // 
            // mtbCep
            // 
            mtbCep.Location = new Point(23, 116);
            mtbCep.Mask = "00000-9999";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(96, 23);
            mtbCep.TabIndex = 1;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(176, 256);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 22;
            lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(23, 345);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 23;
            lblCidade.Text = "Cidade";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(180, 345);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(21, 15);
            lblUf.TabIndex = 24;
            lblUf.Text = "UF";
            // 
            // chkSemNumero
            // 
            chkSemNumero.AutoSize = true;
            chkSemNumero.Location = new Point(339, 202);
            chkSemNumero.Name = "chkSemNumero";
            chkSemNumero.Size = new Size(101, 19);
            chkSemNumero.TabIndex = 4;
            chkSemNumero.Text = "Sem Número?";
            chkSemNumero.UseVisualStyleBackColor = true;
            chkSemNumero.CheckedChanged += chkSemNumero_CheckedChanged;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(12, 363);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(132, 23);
            txtCidade.TabIndex = 7;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(176, 274);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(132, 23);
            txtBairro.TabIndex = 6;
            // 
            // cbxUf
            // 
            cbxUf.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUf.FormattingEnabled = true;
            cbxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxUf.Location = new Point(180, 363);
            cbxUf.Name = "cbxUf";
            cbxUf.Size = new Size(121, 23);
            cbxUf.TabIndex = 8;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 454);
            Controls.Add(cbxUf);
            Controls.Add(txtBairro);
            Controls.Add(txtCidade);
            Controls.Add(chkSemNumero);
            Controls.Add(lblUf);
            Controls.Add(lblCidade);
            Controls.Add(lblBairro);
            Controls.Add(mtbCep);
            Controls.Add(txtComplemento);
            Controls.Add(lblComplemento);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(lblLogradouro);
            Controls.Add(lblLinha);
            Controls.Add(lblCep);
            Controls.Add(btnSalvar);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Button btnSalvar;
        private Label lblCep;
        private Label lblLinha;
        //private Label label3;
        private TextBox txtLogradouro;
        private Label lblLogradouro;
        private TextBox txtNumero;
        private Label lblNumero;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private MaskedTextBox mtbCep;
        private Label lblBairro;
        private Label lblCidade;
        private Label lblUf;
        private CheckBox chkSemNumero;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private ComboBox cbxUf;
    }
}