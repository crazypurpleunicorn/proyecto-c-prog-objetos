using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlightPlanLib;
using System.IO;
using System.Media;
using MisFormularios;
namespace FormsFP
{
    public partial class FlightSim : Form
    {
        ListaFlightPlan milistaFP = new ListaFlightPlan();
        SoundPlayer player = new SoundPlayer();
        DataGridView dgv = new DataGridView();
        PictureBox[] misPics = new PictureBox[100];
        bool Conflicto;
        int numPics = 0;
        bool click = false;
        int dist = 0;
        int tiempo = 0;
        Stack<ListaFlightPlan> stacklista = new Stack<ListaFlightPlan>();

        public FlightSim()
        {
            InitializeComponent();
        }


        

        private void Mover_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ///System.Drawing.Graphics graf = Mapa.CreateGraphics();
            ///System.Drawing.SolidBrush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightBlue);
            ///Pen myPen = new Pen(Color.LightBlue);

            try
            {
                ListaFlightPlan copia = new ListaFlightPlan();
                int cont = 0;
                while (cont < milistaFP.DameNum())
                {
                    FlightPlan nuevo = new FlightPlan(milistaFP.Dame(cont).GetID(), milistaFP.Dame(cont).GetCompañia(), milistaFP.Dame(cont).GetVelocidad(), milistaFP.Dame(cont).GetXorigen(), milistaFP.Dame(cont).GetYorigen(), milistaFP.Dame(cont).GetFX(), milistaFP.Dame(cont).GetFY());
                    nuevo.SetIX(milistaFP.Dame(cont).GetIX());
                    nuevo.SetIY(milistaFP.Dame(cont).GetIY());
                    copia.Pon(nuevo);
                    cont = cont + 1;
                }
                copia.SetDistSeg(this.milistaFP.GetDistSeg());
                copia.SetTiempo(this.milistaFP.GetTiempo());


                stacklista.Push(copia);
                milistaFP.MoverVuelo(milistaFP.GetTiempo());
                for (int i = 0; i < milistaFP.DameNum(); i++)
                {
                    misPics[i].Location = new Point(Convert.ToInt32(milistaFP.Dame(i).GetIX()), Convert.ToInt32(milistaFP.Dame(i).GetIY()));
                }
                this.Conflicto = this.milistaFP.hayconflicto2();
            }
            catch {
                MessageBox.Show("Inserte valor de tiempo de ciclo y distancia de seguridad");
            }
            if (this.Conflicto == true)
            {
                
                MessageBox.Show("Accidente aéreo!! Debería cambiar la velocidad de uno de los aviones para evitarlo");
            }

        }


        private void Automatico_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListaFlightPlan copia = new ListaFlightPlan();
            int cont = 0;
            while (cont < milistaFP.DameNum())
            {
                FlightPlan nuevo = new FlightPlan(milistaFP.Dame(cont).GetID(), milistaFP.Dame(cont).GetCompañia(), milistaFP.Dame(cont).GetVelocidad(), milistaFP.Dame(cont).GetXorigen(), milistaFP.Dame(cont).GetYorigen(), milistaFP.Dame(cont).GetFX(), milistaFP.Dame(cont).GetFY());
                nuevo.SetIX(milistaFP.Dame(cont).GetIX());
                nuevo.SetIY(milistaFP.Dame(cont).GetIY());
                copia.Pon(nuevo);
                cont = cont + 1;
            }
            copia.SetDistSeg(this.milistaFP.GetDistSeg());
            copia.SetTiempo(this.milistaFP.GetTiempo());


            stacklista.Push(copia);
            milistaFP.MoverVuelo(milistaFP.GetTiempo());
            for (int i = 0; i < milistaFP.DameNum(); i++)
                misPics[i].Location = new Point(Convert.ToInt32(milistaFP.Dame(i).GetIX()), Convert.ToInt32(milistaFP.Dame(i).GetIY()));

            this.Conflicto = this.milistaFP.hayconflicto2();
            if (this.Conflicto == true)
            {
                timer1.Stop();
                MessageBox.Show("Accidente aéreo!!");
            }

        }

        private void Parar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        

        private void Reiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            for (int i = 0; i < milistaFP.DameNum(); i++)
            {
                milistaFP.Dame(i).SetIX(milistaFP.Dame(i).GetXorigen());
                milistaFP.Dame(i).SetIY(milistaFP.Dame(i).GetYorigen());
                misPics[i].Location = new Point(Convert.ToInt32(milistaFP.Dame(i).GetXorigen()), Convert.ToInt32(milistaFP.Dame(i).GetYorigen()));
                
            }
        }

        private void datosVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosdeVuelo form = new DatosdeVuelo();
            form.SetLista(milistaFP);
            form.ShowDialog();
        }

        private void cambiarVelocidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cambio_velocidad form = new Cambio_velocidad();
            form.SetLista(milistaFP);
            form.ShowDialog();
            this.milistaFP = new ListaFlightPlan();
            this.milistaFP = form.cambiadas();
        }

        private void FlightSim_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer();
            player.SoundLocation="MUSICA/sim.wav";
            player.Play();
            int i = 0;
            while (i < this.milistaFP.DameNum())
            {
                ///object space = @"C:\Users\Usuario\Desktop\PROYECTObuenooo bueno\FlightPlanLib\FormsFP\bin\Debug\space.png";

                PictureBox ds = new PictureBox();
                PictureBox pic = new PictureBox();
                pic.Size = new Size(20, 20);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap image = new Bitmap("Nave1.png");
                pic.Image = (Image)image;
                ///pic.BackColor = Color.Green;
                pic.Location = new Point(Convert.ToInt32(milistaFP.Dame(i).GetIX()), Convert.ToInt32(milistaFP.Dame(i).GetIY()));
                Mapa.Controls.Add(pic);
                misPics[numPics] = pic;
                pic.Tag = Convert.ToString(numPics);
                numPics = numPics + 1;
                pic.Click += new System.EventHandler(this.evento);
                i += 1;

            }
        }

        private void evento(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            string numero = (string)p.Tag;
            int z = Convert.ToInt32(numero);
            Datosavion datos = new Datosavion();
            datos.TomaLista(milistaFP);
            datos.Tomaposicion(z);
            datos.ShowDialog();



        }

        public void SetFP(ListaFlightPlan lfp)
        {
            this.milistaFP = lfp;
        }

        public void SetPics(PictureBox[] pbox)
        {
            this.misPics = pbox;
        }

        public void SetnumPics(int num)
        {
            this.numPics = num;
        }

        private void guardarPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarArchivo form = new CargarArchivo();
            form.ShowDialog();
            string archivo = form.getfichero();
            if (form.returnaceptar())
            {
                try
                {
                    StreamWriter fich = new StreamWriter(archivo);
                    for (int i = 0; i < milistaFP.DameNum(); i++)
                    {
                        fich.WriteLine(milistaFP.Dame(i).GetID() + " " + milistaFP.Dame(i).GetCompañia() + " " + Convert.ToInt32(milistaFP.Dame(i).GetVelocidad()) + " " + Convert.ToInt32(milistaFP.Dame(i).GetIX()) + " " + Convert.ToInt32(milistaFP.Dame(i).GetIY()) + " " + Convert.ToInt32(milistaFP.Dame(i).GetFX()) + " " + Convert.ToInt32(milistaFP.Dame(i).GetFY()) + " " + Convert.ToInt32(milistaFP.Dame(i).GetXorigen()) + " " + Convert.ToInt32(milistaFP.Dame(i).GetYorigen()));
                    }
                    fich.Close();
                    MessageBox.Show("El fichero se ha guardado correctamente");
                }


                catch (FormatException)
                {
                    MessageBox.Show("Error al abrir el fichero");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void cargarPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarArchivo form = new CargarArchivo();
            form.ShowDialog();
            System.Drawing.Graphics graphics = Mapa.CreateGraphics();
            string archivo = form.getfichero();
            if (form.returnaceptar())
            {
                
                try
                {
                    StreamReader fich = new StreamReader(archivo);
                    ListaFlightPlan nuevalista = new ListaFlightPlan();
                    nuevalista.SetTiempo(milistaFP.GetTiempo());
                    nuevalista.SetDistSeg(milistaFP.GetDistSeg());
                    string linea = fich.ReadLine();
                    while (linea != null)
                    {
                        string[] trozos = linea.Split(' ');
                        FlightPlan avion = new FlightPlan(trozos[0], trozos[1], Convert.ToDouble(trozos[2]), Convert.ToDouble(trozos[7]), Convert.ToDouble(trozos[8]), Convert.ToDouble(trozos[5]), Convert.ToDouble(trozos[6]));
                        avion.SetIX(Convert.ToDouble(trozos[3]));
                        avion.SetIY(Convert.ToDouble(trozos[4]));
                        nuevalista.Pon(avion);
                        linea = fich.ReadLine();
                    }
                    fich.Close();

                    this.milistaFP = nuevalista;
                    Mapa.Refresh();
                    for (int i = 0; i < milistaFP.DameNum() && milistaFP.DameNum() > 0; i++)
                    {
                        misPics[i].Location = new Point(Convert.ToInt32(milistaFP.Dame(i).GetIX() ), Convert.ToInt32(milistaFP.Dame(i).GetIY()) );
                    }
                    MessageBox.Show("Fichero abierto correctamente");


                }
                catch (FormatException)
                {
                    MessageBox.Show("El fichero seleccionado presenta errores");

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        

        private void retroceder_Click(object sender, EventArgs e)
        {
            if (stacklista.Count > 0)
            {
                timer1.Stop();
                milistaFP = stacklista.Pop();
                for (int i = 0; i < milistaFP.DameNum(); i++)
                {

                    misPics[i].Location = new Point(Convert.ToInt32(milistaFP.Dame(i).GetIX()), Convert.ToInt32(milistaFP.Dame(i).GetIY()));

                }


            }
            Mapa.Refresh();
        }

        

        private void Silenciar_Click(object sender, EventArgs e)
        {
            if (click==false)
            {
                click = true;
                player.Stop();
                Silenciar.Text = "Musica: On";
            }
            else if (click==true)
            {
                click = false;
                player.Play();
                Silenciar.Text = "Musica: Off";
            }
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adquirirNaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnviarCorreo form = new EnviarCorreo();
            form.ShowDialog();
        }

        
      

        private void button1_Click(object sender, EventArgs e)
        {
            Compañiasver form = new Compañiasver();
            form.ShowDialog();


        }
        
        
        }
}
