using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

public class Clase_Descarga
{
    public BunifuRadialGauge ProgressBar { get; set; }
    public string Url { get; set; }
    public string Destino { get; set; }
    public int Progress { get; private set; }  // Agrega esta línea

    public Clase_Descarga(BunifuRadialGauge progressBar, string url, string destino)
    {
        ProgressBar = progressBar;
        Url = url;
        Destino = destino;
    }

    public async void IniciarDescarga()
    {
        // Crear el directorio si no existe
        string directorio = Path.GetDirectoryName(Destino);
        if (!Directory.Exists(directorio))
        {
            Directory.CreateDirectory(directorio);
        }

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
        HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();

        using (Stream responseStream = response.GetResponseStream())
        using (Stream fileStream = File.Create(Destino))
        {
            byte[] buffer = new byte[1024];
            int bytesRead;
            long totalBytesRead = 0;

            while ((bytesRead = await responseStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                await fileStream.WriteAsync(buffer, 0, bytesRead);
                totalBytesRead += bytesRead;

                // Actualizar la barra de progreso
                Progress = (int)(totalBytesRead * 100 / response.ContentLength);
            }
        }

        // Mostrar el cuadro de diálogo de archivo abierto con el archivo descargado seleccionado
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = directorio;
        openFileDialog.FileName = Path.GetFileName(Destino);
        openFileDialog.ShowDialog();

        // Mostrar un mensaje indicando que la descarga se completó
        MessageBox.Show("Descarga completada!");
    }
}


