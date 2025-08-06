using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        private TextBox txtLog;
        private Label lblStatus;
        private TextBox txtCaminho;
        private TextBox txtDestino;

        public Form1()
        {
            InitializeComponent();
            txtLog = new TextBox { Multiline = true, Dock = DockStyle.Bottom, Height = 100 };
            lblStatus = new Label { Dock = DockStyle.Top, Height = 30 };
            txtCaminho = new TextBox { Dock = DockStyle.Top, Height = 30 };
            txtDestino = new TextBox { Dock = DockStyle.Top, Height = 30 };

            Controls.Add(txtLog);
            Controls.Add(lblStatus);
            Controls.Add(txtCaminho);
            Controls.Add(txtDestino);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Firebird DB (*.fdb)|*.fdb";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = openFileDialog.FileName;
            }
        }

        private void btnSalvarEm_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtDestino.Text = folderDialog.SelectedPath;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string dbPath = txtCaminho.Text;
            string destino = txtDestino.Text;

            if (!File.Exists(dbPath))
            {
                lblStatus.Text = "Arquivo de banco de dados não encontrado.";
                return;
            }

            if (string.IsNullOrWhiteSpace(destino) || !Directory.Exists(destino))
            {
                lblStatus.Text = "Diretório de destino inválido.";
                return;
            }

            try
            {
                string nomeArquivo = Path.GetFileNameWithoutExtension(dbPath);
                string zipPath = Path.Combine(destino, nomeArquivo + ".zip");
                string gbkPath = Path.Combine(destino, nomeArquivo + ".gbk");

                // Criar arquivo zip
                using (FileStream zipToOpen = new FileStream(zipPath, FileMode.Create))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Create))
                    {
                        ZipArchiveEntry entry = archive.CreateEntry(Path.GetFileName(dbPath));
                        using (Stream entryStream = entry.Open())
                        using (FileStream fileToCompress = new FileStream(dbPath, FileMode.Open, FileAccess.Read))
                        {
                            fileToCompress.CopyTo(entryStream);
                        }
                    }
                }

                // Gerar .gbk (Backup do Firebird)
                string gbakPath = @"C:\Program Files\Firebird\Firebird_3_0\bin\gbak.exe"; // Ajuste conforme sua instalação
                if (!File.Exists(gbakPath))
                {
                    lblStatus.Text = "gbak.exe não encontrado. Verifique o caminho.";
                    return;
                }

                string arguments = $"-b -user SYSDBA -pass masterkey \"{dbPath}\" \"{gbkPath}\"";

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = gbakPath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    txtLog.Text = output + Environment.NewLine + error;

                    if (process.ExitCode == 0)
                        lblStatus.Text = "Backup gerado com sucesso.";
                    else
                        lblStatus.Text = "Erro ao gerar backup. Verifique o log.";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Erro: " + ex.Message;
                txtLog.Text = ex.ToString();
            }
        }
    }
}
