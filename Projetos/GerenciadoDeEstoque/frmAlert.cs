using GerenciadoDeEstoque.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadoDeEstoque
{
    public partial class frmAlert : Form
    {
        public frmAlert()
        {
            InitializeComponent();
        }

        public enum enmAction
        {
            Wait,
            Start,
            Close
        }

        public enum enmType
        {
            Sucess,
            Warning,
            Error,
            Info
        }

        private frmAlert.enmAction action;

        private int x, y;

        private void timer1_Tick(object sendr, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.Wait:
                    Timer1.Interval = 5000;
                    action = enmAction.Close;
                    break;
                case frmAlert.enmAction.Start:
                    this.Timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if(this.Opacity > 1.0)
                        {
                            action = frmAlert.enmAction.Wait;
                        }
                    }
                    break;
                case enmAction.Close:
                    Timer1.Interval = 1;
                    this.Opacity -= 1.0;

                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                    {
                        this.Hide();
                        Timer1.Stop();
                    }
                    break;
            }
        }

        /*private void CloseBtn_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            int width = Screen.PrimaryScreen.WorkingArea.Width;
            int height = Screen.PrimaryScreen.WorkingArea.Height;

            // Verifica a posição disponível para exibir o alert (sem sobrepor outros)
            for (int i = 1; i < 10; i++)
            {
                string alertName = "alert" + i;
                frmAlert frm = (frmAlert)Application.OpenForms[alertName];

                if (frm == null)
                {
                    this.Name = alertName;
                    this.x = width - this.Width - 5;
                    this.y = height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            // Define imagem e cor conforme tipo
            switch (type)
            {
                case enmType.Sucess:
                    this.pictureBox1.Image = Resources.Checkmark_30px;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    this.pictureBox1.Image = Resources.error_30px;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    this.pictureBox1.Image = Resources.info_30px;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    this.pictureBox1.Image = Resources.brake_warning_30px;
                    this.BackColor = Color.DarkRed;
                    break;
            }

            this.MsgLbl.Text = msg;

            this.Show();
            this.action = enmAction.Start;
            this.Timer1.Interval = 1;
            this.Timer1.Start();
        }*/
    }
}
