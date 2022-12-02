namespace EntradaNF
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.textTransportadora = new System.Windows.Forms.TextBox();
            this.chkLastEntry = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDestino = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textCnpj = new System.Windows.Forms.TextBox();
            this.ckNf = new System.Windows.Forms.CheckBox();
            this.valNF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtNF = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.Nf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textObs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textEmpresa = new System.Windows.Forms.TextBox();
            this.dtSaida = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textMotivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textRG = new System.Windows.Forms.TextBox();
            this.dtEntrada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textMotorista = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbEmpresa = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.cboxPorteiro = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.cboxPorteiro);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textTransportadora);
            this.panel1.Controls.Add(this.chkLastEntry);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textDestino);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textCnpj);
            this.panel1.Controls.Add(this.ckNf);
            this.panel1.Controls.Add(this.valNF);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dtNF);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Nf);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textObs);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textEmpresa);
            this.panel1.Controls.Add(this.dtSaida);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textMotivo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textPlaca);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textRG);
            this.panel1.Controls.Add(this.dtEntrada);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textMotorista);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.lbEmpresa);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(426, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 63;
            this.label13.Text = "Tranportadora:";
            // 
            // textTransportadora
            // 
            this.textTransportadora.Location = new System.Drawing.Point(509, 43);
            this.textTransportadora.Name = "textTransportadora";
            this.textTransportadora.Size = new System.Drawing.Size(159, 20);
            this.textTransportadora.TabIndex = 64;
            // 
            // chkLastEntry
            // 
            this.chkLastEntry.AutoSize = true;
            this.chkLastEntry.Location = new System.Drawing.Point(12, 12);
            this.chkLastEntry.Name = "chkLastEntry";
            this.chkLastEntry.Size = new System.Drawing.Size(143, 17);
            this.chkLastEntry.TabIndex = 62;
            this.chkLastEntry.Text = "Buscar da última entrada";
            this.chkLastEntry.UseVisualStyleBackColor = true;
            this.chkLastEntry.CheckedChanged += new System.EventHandler(this.chkLastEntry_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Destino:";
            // 
            // textDestino
            // 
            this.textDestino.Location = new System.Drawing.Point(509, 95);
            this.textDestino.Name = "textDestino";
            this.textDestino.Size = new System.Drawing.Size(159, 20);
            this.textDestino.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(188, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "CNPJ:";
            // 
            // textCnpj
            // 
            this.textCnpj.Location = new System.Drawing.Point(233, 69);
            this.textCnpj.Name = "textCnpj";
            this.textCnpj.Size = new System.Drawing.Size(159, 20);
            this.textCnpj.TabIndex = 58;
            this.textCnpj.TextChanged += new System.EventHandler(this.textCnpj_TextChanged);
            // 
            // ckNf
            // 
            this.ckNf.AutoSize = true;
            this.ckNf.Location = new System.Drawing.Point(233, 215);
            this.ckNf.Name = "ckNf";
            this.ckNf.Size = new System.Drawing.Size(83, 17);
            this.ckNf.TabIndex = 56;
            this.ckNf.Text = "Possui NF ?";
            this.ckNf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckNf.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ckNf.UseVisualStyleBackColor = true;
            this.ckNf.CheckedChanged += new System.EventHandler(this.ckNf_CheckedChanged_1);
            // 
            // valNF
            // 
            this.valNF.Enabled = false;
            this.valNF.Location = new System.Drawing.Point(232, 305);
            this.valNF.Name = "valNF";
            this.valNF.Size = new System.Drawing.Size(159, 20);
            this.valNF.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(189, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Valor:";
            // 
            // dtNF
            // 
            this.dtNF.Enabled = false;
            this.dtNF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNF.Location = new System.Drawing.Point(232, 253);
            this.dtNF.Name = "dtNF";
            this.dtNF.Size = new System.Drawing.Size(159, 20);
            this.dtNF.TabIndex = 43;
            this.dtNF.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Data Emissão:";
            // 
            // Nf
            // 
            this.Nf.Enabled = false;
            this.Nf.Location = new System.Drawing.Point(233, 279);
            this.Nf.Name = "Nf";
            this.Nf.Size = new System.Drawing.Size(159, 20);
            this.Nf.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "NF:";
            // 
            // textObs
            // 
            this.textObs.Location = new System.Drawing.Point(509, 173);
            this.textObs.Name = "textObs";
            this.textObs.Size = new System.Drawing.Size(159, 20);
            this.textObs.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Observacao:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Empresa:";
            // 
            // textEmpresa
            // 
            this.textEmpresa.Location = new System.Drawing.Point(233, 95);
            this.textEmpresa.Name = "textEmpresa";
            this.textEmpresa.Size = new System.Drawing.Size(159, 20);
            this.textEmpresa.TabIndex = 31;
            // 
            // dtSaida
            // 
            this.dtSaida.CustomFormat = "yyyy-MM-dd  HH:mm";
            this.dtSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSaida.Location = new System.Drawing.Point(509, 147);
            this.dtSaida.Name = "dtSaida";
            this.dtSaida.Size = new System.Drawing.Size(159, 20);
            this.dtSaida.TabIndex = 40;
            this.dtSaida.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Saida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Motivo:";
            // 
            // textMotivo
            // 
            this.textMotivo.Location = new System.Drawing.Point(509, 121);
            this.textMotivo.Name = "textMotivo";
            this.textMotivo.Size = new System.Drawing.Size(159, 20);
            this.textMotivo.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Placa:";
            // 
            // textPlaca
            // 
            this.textPlaca.Location = new System.Drawing.Point(233, 173);
            this.textPlaca.Name = "textPlaca";
            this.textPlaca.Size = new System.Drawing.Size(159, 20);
            this.textPlaca.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "RG: ";
            // 
            // textRG
            // 
            this.textRG.Location = new System.Drawing.Point(233, 147);
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(159, 20);
            this.textRG.TabIndex = 38;
            // 
            // dtEntrada
            // 
            this.dtEntrada.CustomFormat = "yyyy-MM-dd  HH:mm";
            this.dtEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEntrada.Location = new System.Drawing.Point(233, 43);
            this.dtEntrada.Name = "dtEntrada";
            this.dtEntrada.Size = new System.Drawing.Size(159, 20);
            this.dtEntrada.TabIndex = 30;
            this.dtEntrada.Value = new System.DateTime(2022, 11, 30, 13, 4, 29, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Motorista:";
            // 
            // textMotorista
            // 
            this.textMotorista.Location = new System.Drawing.Point(233, 121);
            this.textMotorista.Name = "textMotorista";
            this.textMotorista.Size = new System.Drawing.Size(159, 20);
            this.textMotorista.TabIndex = 32;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(232, 384);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 48;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // lbEmpresa
            // 
            this.lbEmpresa.AutoSize = true;
            this.lbEmpresa.Location = new System.Drawing.Point(457, 72);
            this.lbEmpresa.Name = "lbEmpresa";
            this.lbEmpresa.Size = new System.Drawing.Size(46, 13);
            this.lbEmpresa.TabIndex = 33;
            this.lbEmpresa.Text = "Porteiro:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(178, 43);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(47, 13);
            this.lbNome.TabIndex = 29;
            this.lbNome.Text = "Entrada:";
            // 
            // cboxPorteiro
            // 
            this.cboxPorteiro.FormattingEnabled = true;
            this.cboxPorteiro.Location = new System.Drawing.Point(509, 69);
            this.cboxPorteiro.Name = "cboxPorteiro";
            this.cboxPorteiro.Size = new System.Drawing.Size(159, 21);
            this.cboxPorteiro.TabIndex = 65;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entrada";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckNf;
        private System.Windows.Forms.TextBox valNF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtNF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Nf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textObs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textEmpresa;
        private System.Windows.Forms.DateTimePicker dtSaida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textRG;
        private System.Windows.Forms.DateTimePicker dtEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMotorista;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbEmpresa;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textCnpj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDestino;
        private System.Windows.Forms.CheckBox chkLastEntry;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textTransportadora;
        private System.Windows.Forms.ComboBox cboxPorteiro;
    }
}