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

namespace FormsFP
{
    public partial class MenuPrincipal : Form
    {
        SoundPlayer player;
        ListaFlightPlan listaFP = new ListaFlightPlan();
        ListaFlightPlan listaFP2 = new ListaFlightPlan();
        List<double> copia = new List<double>();
        double tiempo = 0;
        double seg = 0;
        string archivo;
        bool click = false;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        

        
    

        private void agregarPlanDeVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AñadirFP form = new AñadirFP();
            form.ShowDialog();
            FlightPlan FP = form.DameFP();
            listaFP.Pon(FP);
            listaFP2.Pon(FP);

         }

        private void agregarTiempoDeCicloYDistanciaDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tiempo_y_distancia form = new Tiempo_y_distancia();
            form.ShowDialog();
            this.tiempo = form.returntiempo();
            this.seg = form.returnseg();
            this.listaFP.SetDistSeg(this.seg);
            this.listaFP2.SetDistSeg(this.seg);
            this.listaFP.SetTiempo(this.tiempo);
            this.listaFP2.SetTiempo(this.tiempo);


            
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void simularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int conflicto = this.listaFP.willbeinconflict(this.seg);
            bool impossible = false;
            bool cambio = false;
            if (conflicto!=-1){
                MessageBox.Show("Habrá conflicto");
                while (conflicto != -1 && impossible==false)
                {
                    double velocidad = listaFP.Dame(conflicto).GetVelocidad() - 0.1;
                    listaFP.Dame(conflicto).CambiarVel(velocidad * 1000);
                    conflicto = listaFP.willbeinconflict(this.seg);
                    if (velocidad <= 0)
                    {
                        impossible =true;
                        MessageBox.Show("No se puede resolver el conflicto");
                    }
                }
                CambioAutomaticodeVelocidad cav = new CambioAutomaticodeVelocidad();
                cav.Sincambios(this.copia);
                cav.Concambios(this.listaFP);
                cav.ShowDialog();
                cambio = cav.Cambiar();
                
            }

            
            
            FlightSim FSform = new FlightSim();
            if (cambio) {
                FSform.SetFP(this.listaFP);
            }else
                FSform.SetFP(this.listaFP2);
            FSform.ShowDialog();
            
        }

        

        private void cargarFicheroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarArchivo form = new CargarArchivo();
            form.ShowDialog();
            if (form.returnaceptar())
            {
                this.archivo = form.getfichero();

                try
                {
                    StreamReader R = new StreamReader(this.archivo);
                    string linea = R.ReadLine();

                    while (linea != null )
                    {
                        string[] trozos = linea.Split(' ');
                        FlightPlan avion = new FlightPlan(trozos[0], trozos[1], Convert.ToDouble(trozos[2]), Convert.ToDouble(trozos[3]), Convert.ToDouble(trozos[4]), Convert.ToDouble(trozos[5]), Convert.ToDouble(trozos[6]));
                        FlightPlan avion2 = new FlightPlan(trozos[0], trozos[1], Convert.ToDouble(trozos[2]), Convert.ToDouble(trozos[3]), Convert.ToDouble(trozos[4]), Convert.ToDouble(trozos[5]), Convert.ToDouble(trozos[6]));
                        this.listaFP.Pon(avion);
                        this.listaFP2.Pon(avion2);
                        this.copia.Add(Convert.ToDouble(trozos[2]));
                        linea = R.ReadLine();
                    }
                    
                    MessageBox.Show("Fichero abierto correctamente");

                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
                agregarPlanDeVueloToolStripMenuItem.Visible = false;
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap("MI.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            player = new SoundPlayer();
            player.SoundLocation="MUSICA/MenuPrincipal.wav";
            player.Play();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (click==false)
            {
                click = true;
                player.Stop();
                button1.Text = "Musica: On";
            }
            else if (click==true)
            {
                click = false;
                player.Play();
                button1.Text = "Musica: Off";
            }
        }
        }
        }
       