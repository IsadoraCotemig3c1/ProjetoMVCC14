namespace ProjetoMVCC14
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
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_nomemae = new System.Windows.Forms.Label();
            this.txt_nomemaec14 = new System.Windows.Forms.TextBox();
            this.txt_nomec14 = new System.Windows.Forms.TextBox();
            this.txt_cpfc14 = new System.Windows.Forms.TextBox();
            this.btn_enviarc14 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(12, 62);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_cpf.TabIndex = 0;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(12, 118);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(81, 13);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome completo";
            // 
            // lbl_nomemae
            // 
            this.lbl_nomemae.AutoSize = true;
            this.lbl_nomemae.Location = new System.Drawing.Point(12, 191);
            this.lbl_nomemae.Name = "lbl_nomemae";
            this.lbl_nomemae.Size = new System.Drawing.Size(74, 13);
            this.lbl_nomemae.TabIndex = 2;
            this.lbl_nomemae.Text = "Nome da Mãe";
            // 
            // txt_nomemaec14
            // 
            this.txt_nomemaec14.Location = new System.Drawing.Point(15, 217);
            this.txt_nomemaec14.Name = "txt_nomemaec14";
            this.txt_nomemaec14.Size = new System.Drawing.Size(183, 20);
            this.txt_nomemaec14.TabIndex = 3;
            // 
            // txt_nomec14
            // 
            this.txt_nomec14.Location = new System.Drawing.Point(15, 151);
            this.txt_nomec14.Name = "txt_nomec14";
            this.txt_nomec14.Size = new System.Drawing.Size(183, 20);
            this.txt_nomec14.TabIndex = 4;
            // 
            // txt_cpfc14
            // 
            this.txt_cpfc14.Location = new System.Drawing.Point(15, 78);
            this.txt_cpfc14.Name = "txt_cpfc14";
            this.txt_cpfc14.Size = new System.Drawing.Size(183, 20);
            this.txt_cpfc14.TabIndex = 5;
            // 
            // btn_enviarc14
            // 
            this.btn_enviarc14.Location = new System.Drawing.Point(70, 257);
            this.btn_enviarc14.Name = "btn_enviarc14";
            this.btn_enviarc14.Size = new System.Drawing.Size(75, 23);
            this.btn_enviarc14.TabIndex = 6;
            this.btn_enviarc14.Text = "Enviar";
            this.btn_enviarc14.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 343);
            this.Controls.Add(this.btn_enviarc14);
            this.Controls.Add(this.txt_cpfc14);
            this.Controls.Add(this.txt_nomec14);
            this.Controls.Add(this.txt_nomemaec14);
            this.Controls.Add(this.lbl_nomemae);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_cpf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_nomemae;
        private System.Windows.Forms.TextBox txt_nomemaec14;
        private System.Windows.Forms.TextBox txt_nomec14;
        private System.Windows.Forms.TextBox txt_cpfc14;
        private System.Windows.Forms.Button btn_enviarc14;
    }
}

