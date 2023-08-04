using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Imaging;

namespace Interface
{
    public partial class FormInterface : Form
    {
        // Variables
        SerialPort puerto;
        Bitmap bmp;

        // Variables de imagen
        int ancho = 640, alto = 480;
        int numBytesCaptura = 614400;
        bool capturaHabilitada = false;

        decimal fR = 1, fG = 1, fB = 1;

        string puertoSeleccionado;
        bool conectado = false;

        int cuentaBytes = 0;
        int cuentaProcesados = 0;

        int n = 0;
        int desfase = 0;
        byte[] buffer;


        // Inicialización de los componentes del Form
        public FormInterface()
        {
            InitializeComponent();
        }

        /*  Función que se inicia al cargar el Form, crea la imagen inicial
         *  y el buffer de datos.   */
        private void Form1_Load(object sender, EventArgs e)
        {
            // Bitmap
            bmp = new Bitmap(ancho, alto);

            // Crea una imagen
            for (int y = 0; y < alto; y++)
            {
                for (int x = 0; x < ancho; x++)
                {
                    // Poner valor ARGB
                    bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));
                }
            }

            // Cargar bmp en el picturebox
            imageBox.Image = bmp;

            // Crea un buffer de almacenamiento, de un tamaño del doble de la imagen
            buffer = new byte[640*480*4];

            // Trackbars
            trackBarR.Maximum = 10;
            trackBarR.Minimum = 0;

            trackBarB.Maximum = 10;
            trackBarB.Minimum = 0;

            trackBarG.Maximum = 10;
            trackBarG.Minimum = 0;
        }

        /*  Función que lista los puertos disponibles en un componente combobox.    */
        private void btnGetPorts_Click(object sender, EventArgs e)
        {
            // Lista los puertos seriales
            string[] puertos = SerialPort.GetPortNames();
            cboxPorts.Items.Clear();

            // Agrega los elementos al combobox
            foreach (string port in puertos)
            {
                cboxPorts.Items.Add(port);
            }
            this.ActiveControl = cboxPorts;
        }

        /*  Función que crea la conexión con el puerto serial seleccionado.  */
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!conectado)
            {
                // Si no seleccionó ninguno
                if (puertoSeleccionado == null)
                    return;

                // Crea la conexión
                puerto = new SerialPort(puertoSeleccionado, 115200, Parity.None, 8, StopBits.One);
                if (puerto.IsOpen)
                {
                    puerto.Close();
                }

                // Tamaño del buffer de lectura para el puerto serial
                puerto.ReadBufferSize = 16000;
                puerto.Open();
                // Limpia el buffer
                puerto.DiscardInBuffer();

                conectado = true;
                btnConectar.Text = "Conectado";
                btnConectar.BackColor = Color.LawnGreen;
                
                // Habilita los temporizadores de eventos
                timer.Enabled = true;
                timer1.Enabled = true;
            }
            else
            {
                // Cierra el puerto seleccionado
                puerto.Close();
                conectado = false;
                btnConectar.Text = "Desconectado";
                btnConectar.BackColor = Color.Coral;
                
                timer.Enabled = false;
                timer1.Enabled = false;
            }
        }

        /*  Selección del puerto en el combobox*/
        private void cboxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            puertoSeleccionado = cboxPorts.SelectedItem.ToString();
            this.ActiveControl = btnConectar;
        }

        /*  Boton de captura.   */
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (puerto == null)
            {
                return;
            }
            if (puerto.IsOpen)
            {
                // Enviar comando de captura
                puerto.Write("TC|END");
                btnCaptura.Enabled = false;
                btnCapturaSecuencial.Enabled = false;
            }
        }

        /*  Botón de limpieza de imagen.    */
        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < alto; y++)
            {
                for (int x = 0; x < ancho; x++)
                {
                    // Poner valor ARGB
                    bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));
                }
            }

            // Carga el bmp en un picturebox
            imageBox.Image = bmp;

            desfase = 0;
            cuentaBytes = 0;
            cuentaProcesados = 0;
            lblCount.Text = 0.ToString();
            lblCount2.Text = 0.ToString();
        }

        /*  Función de evento del timer que transpasa los datos recibidos
         *  del puerto serial al buffer de imagen*/
        private void timer_Tick(object sender, EventArgs e)
        {
            if (puerto.IsOpen)
            {
                n = puerto.BytesToRead;
                if (n == 0)
                    return;
                puerto.Read(buffer, desfase, n);
                desfase += n;
            }
        }

        /*  Evento del timer que actualiza el estado del proceso de recepción de datos*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            cuentaBytes = desfase;
            lblCount.Text = cuentaBytes.ToString();
            if (cuentaBytes == 0)
            {
                lblStatus.Text = "En espera";
            }
            if (cuentaBytes > 0 && cuentaBytes < numBytesCaptura)
            {
                lblStatus.Text = "Recibiendo datos ...";
                lblCount2.Text = "0";
            }
            if (cuentaBytes == numBytesCaptura)
            {
                lblStatus.Text = "Procesando datos";
                timer.Stop();
                timer1.Stop();
                processImageRGB();

                desfase = 0;

                if (capturaHabilitada)
                {
                    puerto.Write("TC|END");
                }
                else
                {
                    btnCaptura.Enabled = true;
                    btnCapturaSecuencial.Enabled = true;
                }

                timer.Start();
                timer1.Start();
            }
        }

        /*  Activa el modo imagen del sensor con el comando.   */
        private void btnModoImagen_Click(object sender, EventArgs e)
        {
            if (puerto == null)
                return;
            else
            {
                if (puerto.IsOpen)
                {
                    puerto.Write("CF|END");
                    MessageBox.Show("Modo imagen seleccionado");
                }
            }
        }

        /*  Activa el modo barra de colores del sensor de imagen con el comando definido.   */
        private void btnModoBarraColor_Click(object sender, EventArgs e)
        {
            if (puerto == null)
                return;
            else
            {
                if (puerto.IsOpen)
                {
                    puerto.Write("CB|END");
                    MessageBox.Show("Modo barra de colores seleccionado");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Archivos de imagen (*.jpeg)|*.jpeg|All files (*.*)|*.*";
            dialog.FileName = "IMG_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss") + ".jpeg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void btnCapturaSecuencial_Click(object sender, EventArgs e)
        {
            if (puerto == null)
                return;
            else
            {
                if (puerto.IsOpen)
                {
                    capturaHabilitada = true;
                    btnCaptura.Enabled = false;
                    btnCapturaSecuencial.Enabled = false;

                    puerto.Write("TC|END");
                }
            }
        }

        private void btnDetenerCaptSec_Click(object sender, EventArgs e)
        {
            if (puerto == null)
                return;
            else
            {
                if (puerto.IsOpen)
                {
                    capturaHabilitada = false;
                    btnCaptura.Enabled = true;
                    btnCapturaSecuencial.Enabled = true;
                }
            }
        }

        private void btnReiniciarCfg_Click(object sender, EventArgs e)
        {
            if (puerto == null)
                return;
            else
            {
                if (puerto.IsOpen)
                {
                    puerto.Write("RS|END");
                    MessageBox.Show("Reiniciar configuración");
                }
            }
        }

        /*  Enviar los comandos del textbox*/
        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            if (puerto == null)
                return;
            else
            {
                if (puerto.IsOpen)
                {
                    // Procesa cada uno de los comandos escritos en el textbox
                    for (int i = 0; i < tboxComandos.Lines.Length; i++)
                    {
                        puerto.Write(tboxComandos.Lines[i]);
                        MessageBox.Show("Comando enviado: " + tboxComandos.Lines[i]);
                    }
                }
            }
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            fR = (decimal)trackBarR.Value / 10;
            lblRval.Text = fR.ToString();
        }

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            processImageRGB();
        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            fG = (decimal)trackBarG.Value / 10;
            lblGval.Text = fG.ToString();
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            fB = (decimal)trackBarB.Value / 10;
            lblBval.Text = fB.ToString();
        }

        public void processImageRGB()
        {
            // Variables para los pixeles
            int R, G1, G2, G, B, dato;
            decimal R8, G8, B8;

            cuentaProcesados = 0;

            int i = 1;

            // create image
            for (int y = 0; y < alto; y++)
            {
                for (int x = 0; x < ancho; x++)
                {
                    // Procesa 2 bytes del buffer para un pixel RGB565
                    dato = buffer[i++];
                    R = (dato >> 3) & 0x1F;
                    G1 = dato & 0x07;
                    G1 = G1 << 3;

                    dato = buffer[i++];
                    G2 = (dato >> 5) & 0x07;
                    G = G1 | G2;
                    B = dato & 0x1F;

                    R8 = Math.Round((decimal)R * (255 / 31) * fR);
                    G8 = Math.Round((decimal)G * (255 / 63) * fG);
                    B8 = Math.Round((decimal)B * (255 / 31) * fB);

                    // Establece el valor ARGB
                    bmp.SetPixel(x, y, Color.FromArgb(255, (int)R8, (int)G8, (int)B8));

                    cuentaProcesados += 2;
                }
                lblCount2.Text = cuentaProcesados.ToString();
            }
            cuentaBytes = 0;

            // Carga el bitmap en el picturebox
            imageBox.Image = bmp;
        }
    }
}
