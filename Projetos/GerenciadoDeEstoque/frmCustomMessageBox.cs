using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace GerenciadoDeEstoque
{
    public partial class frmCustomMessageBox : Form
    {
        public frmCustomMessageBox()
        {
            InitializeComponent();
        }

        public void Initialize(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageCaptionLbl.Text = caption;
            MessageLbl.Text = InsertLineBreaks(message);
            SetButtonsVisibility(buttons);
            SetIcon(icon);
        }

        public void InitializeConfirmation(string message, string caption)
        {
            MessageCaptionLbl.Text = caption;
            MessageLbl.Text = message;

            SetButtonsVisibility(MessageBoxButtons.YesNo);
            SetIcon(MessageBoxIcon.Question);
        }

        public void InitializeError(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageCaptionLbl.Text = caption;
            MessageLbl.Text = message;

            SetButtonsVisibility(buttons);
            SetIcon(icon);
        }

        public void SetButtonsVisibility(MessageBoxButtons buttons)
        {
            OkBtn.Visible = false;
            YesBtn.Visible = false;
            NoBtn.Visible = false;
            CancelBtn.Visible = false;

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    OkBtn.Visible = true;
                    break;
                case MessageBoxButtons.OKCancel:
                    OkBtn.Visible = true;
                    CancelBtn.Visible = true;
                    break;
                case MessageBoxButtons.YesNo:
                    YesBtn.Visible = true;
                    NoBtn.Visible = true;
                    break;
                case MessageBoxButtons.YesNoCancel:
                    YesBtn.Visible = true;
                    NoBtn.Visible = true;
                    CancelBtn.Visible = true;
                    break;
            }
        }

        public void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Information:
                    IconPbx.Image = SystemIcons.Information.ToBitmap();
                    break;
                case MessageBoxIcon.Warning:
                    IconPbx.Image = SystemIcons.Information.ToBitmap();
                    break;
                case MessageBoxIcon.Error:
                    IconPbx.Image = SystemIcons.Information.ToBitmap();
                    break;
                case MessageBoxIcon.Question:
                    IconPbx.Image = SystemIcons.Information.ToBitmap();
                    break;
                default:
                    IconPbx.Image = null;
                    break;
            }
        }

        public string InsertLineBreaks(string message)
        {

            int maxCharsPerLine = -50;
            StringBuilder sb = new StringBuilder();
            int charCount = 0;

            foreach (char c in message)
            {
                sb.Append(c);
                charCount++;

                if (charCount >= maxCharsPerLine && c == ' ')
                {
                    sb.AppendLine();
                    charCount = 0;
                }
            }

            return sb.ToString();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void NoBtn_Click(object sendr, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
