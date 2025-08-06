namespace Form1
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
            this.txtCaminhoBanco = new System.Windows.Forms.TextBox();
            this.btnBuscarBanco = new System.Windows.Forms.Button();
            this.btnSalvarEm = new System.Windows.Forms.Button();
            this.txtDestinoBackup = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.richLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtCaminhoBanco
            // 
            this.txtCaminhoBanco.Location = new System.Drawing.Point(63, 74);
            this.txtCaminhoBanco.Name = "txtCaminhoBanco";
            this.txtCaminhoBanco.Size = new System.Drawing.Size(100, 20);
            this.txtCaminhoBanco.TabIndex = 0;
            // 
            // btnBuscarBanco
            // 
            this.btnBuscarBanco.Location = new System.Drawing.Point(193, 70);
            this.btnBuscarBanco.Name = "btnBuscarBanco";
            this.btnBuscarBanco.Size = new System.Drawing.Size(94, 23);
            this.btnBuscarBanco.TabIndex = 1;
            this.btnBuscarBanco.Text = "Buscar Banco\n...";
            this.btnBuscarBanco.UseVisualStyleBackColor = true;
            // 
            // btnSalvarEm
            // 
            this.btnSalvarEm.Location = new System.Drawing.Point(193, 99);
            this.btnSalvarEm.Name = "btnSalvarEm";
            this.btnSalvarEm.Size = new System.Drawing.Size(94, 23);
            this.btnSalvarEm.TabIndex = 2;
            this.btnSalvarEm.Text = "Salvar Em\n...";
            this.btnSalvarEm.UseVisualStyleBackColor = true;
            // 
            // txtDestinoBackup
            // 
            this.txtDestinoBackup.Location = new System.Drawing.Point(63, 101);
            this.txtDestinoBackup.Name = "txtDestinoBackup";
            this.txtDestinoBackup.Size = new System.Drawing.Size(100, 20);
            this.txtDestinoBackup.TabIndex = 3;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(63, 415);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(100, 23);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar Backup";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.button3_Click);
            // 
            // richLog
            // 
            this.richLog.Location = new System.Drawing.Point(63, 313);
            this.richLog.Name = "richLog";
            this.richLog.Size = new System.Drawing.Size(100, 96);
            this.richLog.TabIndex = 5;
            this.richLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "lblStatus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richLog);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtDestinoBackup);
            this.Controls.Add(this.btnSalvarEm);
            this.Controls.Add(this.btnBuscarBanco);
            this.Controls.Add(this.txtCaminhoBanco);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaminhoBanco;
        private System.Windows.Forms.Button btnBuscarBanco;
        private System.Windows.Forms.Button btnSalvarEm;
        private System.Windows.Forms.TextBox txtDestinoBackup;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.RichTextBox richLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

