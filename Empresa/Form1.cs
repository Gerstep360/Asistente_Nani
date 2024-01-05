using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using HtmlAgilityPack;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;


namespace Empresa
{
    public partial class Form1 : Form
    {
        private Clase_Descarga descarga;
        private FolderBrowserDialog folderBrowserDialog;

        public Form1()
        {
            InitializeComponent();

            folderBrowserDialog = new FolderBrowserDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void btnSeleccionarCarpeta_Click_1(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtRutaCarpeta.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRutaCarpeta.Text))
            {
                MessageBox.Show("Por favor, seleccione una carpeta antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Desea comenzar el proceso de ordenamiento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OrdenarArchivos(txtRutaCarpeta.Text);
                MessageBox.Show("El ordenamiento ha sido completado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
            }
        }

        private void OrdenarArchivos(string carpeta)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(carpeta);
                FileInfo[] archivos = directoryInfo.GetFiles();

                int totalArchivos = archivos.Length;
                int archivosOrdenados = 0;

                foreach (var archivo in archivos)
                {
                    string tipoArchivo = Path.GetExtension(archivo.FullName).ToLower().Trim('.');

                    // Crear carpetas según el tipo de archivo
                    string tipoCarpeta = Path.Combine(carpeta, tipoArchivo);
                    Directory.CreateDirectory(tipoCarpeta);

                    // Mover el archivo a la carpeta correspondiente
                    string destino = Path.Combine(tipoCarpeta, archivo.Name);
                    File.Move(archivo.FullName, destino);

                    archivosOrdenados++;
                    double porcentaje = (double)archivosOrdenados / totalArchivos * 100;
                    porcentaje_Graphic.Value = (int)porcentaje;
                    Application.DoEvents();
                }
                // Abrir la carpeta después de completar el ordenamiento

                Process.Start("explorer.exe", carpeta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante el proceso de ordenamiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuRadialGauge1_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRadialGauge.ValueChangedEventArgs e)
        {

        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFormCaptionButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuShapes1_ShapeChanged(object sender, Bunifu.UI.WinForms.BunifuShapes.ShapeChangedEventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrEmpty(txtRutaCarpeta.Text))
            {
                string url = txtRutaCarpeta.Text;
                string filename = Path.GetFileName(new Uri(url).AbsolutePath);
                string destino = Path.Combine(folderBrowserDialog.SelectedPath, filename);

                descarga = new Clase_Descarga(
                    porcentaje_Graphic,
                    url,
                    destino
                );

                descarga.IniciarDescarga();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            porcentaje_Graphic.Value = descarga.Progress;
        }

        private async void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            await ObtenerJuegosGratis();
        }

        private async Task ObtenerJuegosGratis()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://free-epic-games.p.rapidapi.com/free"),
                Headers =
        {
            { "X-RapidAPI-Key", "288ef8af1amsh0f40ec72435ee4cp143188jsn06a5f2c9b687" },
            { "X-RapidAPI-Host", "free-epic-games.p.rapidapi.com" },
        },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                // Parsea el JSON
                var juegosGratis = JObject.Parse(body);

                // Obtiene el nombre del juego
                var nombreDelJuego = juegosGratis["freeGames"]["current"][0]["title"].ToString();

                // Actualiza el nombre del juego en el panel
                this.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread
                    lblPorcentaje.Text = nombreDelJuego;
                });
            }
        }

        private void gunaGradient2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
