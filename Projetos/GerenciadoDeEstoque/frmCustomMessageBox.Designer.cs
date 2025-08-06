namespace GerenciadoDeEstoque
{
    partial class frmCustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomMessageBox));
            this.SidePnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MessageCaptionLbl = new System.Windows.Forms.Label();
            this.IconPbx = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.YesBtn = new System.Windows.Forms.Button();
            this.NoBtn = new System.Windows.Forms.Button();
            this.MessageLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPbx)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePnl
            // 
            this.SidePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SidePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePnl.Location = new System.Drawing.Point(0, 0);
            this.SidePnl.Name = "SidePnl";
            this.SidePnl.Size = new System.Drawing.Size(10, 159);
            this.SidePnl.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.MessageCaptionLbl);
            this.panel1.Controls.Add(this.IconPbx);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 47);
            this.panel1.TabIndex = 1;
            // 
            // MessageCaptionLbl
            // 
            this.MessageCaptionLbl.AutoSize = true;
            this.MessageCaptionLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.MessageCaptionLbl.ForeColor = System.Drawing.Color.Black;
            this.MessageCaptionLbl.Location = new System.Drawing.Point(9, 17);
            this.MessageCaptionLbl.Name = "MessageCaptionLbl";
            this.MessageCaptionLbl.Size = new System.Drawing.Size(74, 14);
            this.MessageCaptionLbl.TabIndex = 5;
            this.MessageCaptionLbl.Text = "Message Caption";
            // 
            // IconPbx
            // 
            this.IconPbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconPbx.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.IconPbx.Image = ((System.Drawing.Image)(resources.GetObject("IconPbx.Image")));
            this.IconPbx.Location = new System.Drawing.Point(364, 12);
            this.IconPbx.Name = "IconPbx";
            this.IconPbx.Size = new System.Drawing.Size(32, 25);
            this.IconPbx.TabIndex = 4;
            this.IconPbx.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(10, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 124);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 27);
            this.panel2.TabIndex = 2;
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OkBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.OkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkBtn.FlatAppearance.BorderSize = 0;
            this.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.Location = new System.Drawing.Point(16, 98);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(57, 28);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelBtn.BackColor = System.Drawing.Color.IndianRed;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.CancelBtn.Location = new System.Drawing.Point(79, 98);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(57, 28);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancelar";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // YesBtn
            // 
            this.YesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.YesBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.YesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YesBtn.FlatAppearance.BorderSize = 0;
            this.YesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.YesBtn.Location = new System.Drawing.Point(290, 98);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(57, 28);
            this.YesBtn.TabIndex = 2;
            this.YesBtn.Text = "Yes";
            this.YesBtn.UseVisualStyleBackColor = false;
            // 
            // NoBtn
            // 
            this.NoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NoBtn.BackColor = System.Drawing.Color.IndianRed;
            this.NoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoBtn.FlatAppearance.BorderSize = 0;
            this.NoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.NoBtn.Location = new System.Drawing.Point(353, 98);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(57, 28);
            this.NoBtn.TabIndex = 3;
            this.NoBtn.Text = "No";
            this.NoBtn.UseVisualStyleBackColor = false;
            // 
            // MessageLbl
            // 
            this.MessageLbl.AutoSize = true;
            this.MessageLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.MessageLbl.Location = new System.Drawing.Point(17, 54);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(42, 14);
            this.MessageLbl.TabIndex = 4;
            this.MessageLbl.Text = "Message";
            // 
            // frmCustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(418, 159);
            this.Controls.Add(this.MessageLbl);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SidePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SidePnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Button NoBtn;
        private System.Windows.Forms.PictureBox IconPbx;
        private System.Windows.Forms.Label MessageCaptionLbl;
        private System.Windows.Forms.Label MessageLbl;
    }
}

