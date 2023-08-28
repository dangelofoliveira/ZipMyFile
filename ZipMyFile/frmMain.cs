using System.ComponentModel;
using System.Text;
using System.IO.Compression;

namespace ZipMyFile
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblProgresso.Visible = false;
            pgbZip.Visible = false;
        }

        #region "Botões"

        private void BtnDiretorioEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                using FolderBrowserDialog folderBrowserDialog = new();
                {
                    folderBrowserDialog.Description = "Selecione a pasta.";
                    folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        ctrTextoDiretorioEntrada.Text = folderBrowserDialog.SelectedPath;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnDiretorioSaida_Click(object sender, EventArgs e)
        {
            try
            {
                using FolderBrowserDialog folderBrowserDialog = new();
                {
                    folderBrowserDialog.Description = "Selecione o destino.";
                    folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        ctrTextoDiretorioSaida.Text = folderBrowserDialog.SelectedPath;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new();

            if (ValidaControles(ref sb))
            {
                MessageBox.Show($"{sb}", "ZipMyFile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpaControles();
                return;
            }

            try
            {
                btnDiretorioEntrada.Enabled = false;
                btnDiretorioSaida.Enabled = false;
                btnOk.Enabled = false;
                Cursor = Cursors.WaitCursor;

                if (!VerificaDiretorioEntrada())
                {
                    return;
                }

                ValidaNomeArquivo();

                if (MessageBox.Show("Deseja realmente gerar o arquivo?", " ----- Zip My file -----", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(lblNomeCompletoArquivo.Text))
                    {
                        ZipMyfile();
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                btnDiretorioEntrada.Enabled = true;
                btnDiretorioSaida.Enabled = true;
                btnOk.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        #endregion

        #region "Controles"

        private bool ValidaControles(ref StringBuilder sb)
        {
            bool temErro = false;

            try
            {
                if (string.IsNullOrEmpty(ctrTextoDiretorioEntrada.Text))
                {
                    sb.Append("Diretório de Entrada Vazio | ");
                    temErro = true;
                }

                if (string.IsNullOrEmpty(ctrTextoDiretorioSaida.Text))
                {
                    sb.Append("Diretório de Destino Vazio | ");
                    temErro = true;
                }

                if (string.IsNullOrEmpty(ctrTextoNomeArquivo.Text))
                {
                    sb.Append("Nome do Arquivo Vazio");
                    temErro = true;
                }

                if (temErro)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }

        private void LimpaControles()
        {
            ctrTextoNomeArquivo.Text = "";
            lblNomeCompletoArquivo.Text = "";
        }

        private void ValidaNomeArquivo()
        {
            try
            {
                DateTime dataAtual = DateTime.Today;
                string nomeArquivo = ctrTextoNomeArquivo.Text;

                if (!string.IsNullOrEmpty(nomeArquivo))
                {
                    lblNomeCompletoArquivo.Text = $"{nomeArquivo}_Versao_Teste_{dataAtual:yyyy-MM-dd}".ToUpper();
                }
                else
                {
                    throw new Exception("Favor inserir um nome para o arquivo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "ZipMyFile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpaControles();
            }
        }

        private bool VerificaDiretorioEntrada()
        {
            try
            {
                DirectoryInfo diretorio = new(ctrTextoDiretorioEntrada.Text);

                if (diretorio.GetFiles().Length <= 0)
                {
                    ctrTextoDiretorioEntrada.Focus();

                    if (MessageBox.Show("A pasta está vazia. Deseja prosseguir com a ação?", "ZipMyFile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return true;
        }

        private void CtrTextoNomeArquivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnOk_Click(this, new EventArgs());
            }
        }

        private void CtrTextoNomeArquivo_Validating(object sender, CancelEventArgs e)
        {
            ValidaNomeArquivo();
        }

        #endregion

        #region "Gera Arquivo"

        private void ZipMyfile()
        {
            try
            {
                UseWaitCursor = true;
                lblProgresso.Visible = true;
                pgbZip.Visible = true;
                string nomeCompletoArquivo = $"{ctrTextoDiretorioSaida.Text}\\{lblNomeCompletoArquivo.Text}.zip";

                pgbZip.Minimum = 0;
                pgbZip.Maximum = 100;
                pgbZip.Value = 0;
                lblProgresso.Text = $"0%";
                Application.DoEvents();

                new Thread(t =>
                {
                    if (File.Exists(nomeCompletoArquivo))
                    {
                        File.Delete(nomeCompletoArquivo);
                    }

                    ZipFile.CreateFromDirectory(ctrTextoDiretorioEntrada.Text, nomeCompletoArquivo, CompressionLevel.Fastest, false, Encoding.UTF8);
                })
                { IsBackground = true }.Start();

                if (Thread.CurrentThread.IsAlive)
                {
                    DirectoryInfo directoryInfo = new(ctrTextoDiretorioEntrada.Text);
                    int percentualAtual = 0;
                    int tamanhoTotal = directoryInfo.GetFiles().Length;

                    for (int i = 0; i < tamanhoTotal; i++)
                    {
                        if (Math.Floor((decimal)(i + 1) / tamanhoTotal * 100) > percentualAtual)
                        {
                            percentualAtual = (int)Math.Floor((decimal)(i + 1) / tamanhoTotal * 100);
                            pgbZip.Value = percentualAtual;
                            lblProgresso.Text = $"{percentualAtual}%";
                            Application.DoEvents();
                        }
                    }

                    if (MessageBox.Show("Arquivo gerado com sucesso!", "ZipMyFile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        LimpaControles();
                        ctrTextoDiretorioEntrada.Text = "";
                        ctrTextoDiretorioSaida.Text = "";
                        pgbZip.Visible = false;
                        lblProgresso.Visible = false;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        #endregion

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Rectangle rect = new(Location, Icon.Size);

            if (rect.Contains(Cursor.Position) && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }

        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Código utilizado para mover o form (arrastar e soltar) | Chupinhado deste link: https://www.codeproject.com/Articles/11114/Move-window-form-without-Titlebar-in-C
        /// </summary>
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
