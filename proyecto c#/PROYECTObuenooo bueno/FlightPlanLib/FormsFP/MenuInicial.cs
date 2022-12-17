using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using FlightPlanLib;
using System.Media;

namespace FormsFP
{
    public partial class MenuInicial : Form
    {
        SoundPlayer player;
        bool parar = false;

        public MenuInicial()
        {
            InitializeComponent();
        }

        bool found = false;
        string newuser;
        string newpaswd;
        string usuarioact;

        Databaseclass cnx = new Databaseclass();
        

        
        private void entrar_Click(object sender, EventArgs e)
        {
            if (user.Text == "" || pwd.Text == "")
            {
                MessageBox.Show("Rellena todos los campos");
            }
            else
            {

                try
                {
                    cnx.OpenDatabase();
                    DataTable res = new DataTable();
                    res = cnx.Datatable();

                    int i = 0;
                    while (i < res.Rows.Count && found == false)
                    {
                        if (user.Text == Convert.ToString(res.Rows[i]["Usuario"]) && pwd.Text == Convert.ToString(res.Rows[i]["Contraseña"]))
                        {
                            found = true;
                            this.usuarioact = Convert.ToString(res.Rows[i]["Usuario"]);
                        }
                        i++;
                    }
                    if (found)
                    {
                        MessageBox.Show("usuario verificado");
                        cnx.CloseDatabase();


                        MenuPrincipal form = new MenuPrincipal();
                        form.ShowDialog();



                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrectos");
                        cnx.CloseDatabase();
                    }

                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }


            }
        }

        private void registerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Registrar reg = new Registrar();
            reg.ShowDialog();
            if (reg.reg())
            {
                this.newuser = reg.TomaUsuario();
                this.newpaswd = reg.Tomapassword();



                try
                {
                    this.cnx.OpenDatabase();
                    int resultado = this.cnx.Insert(this.newuser, this.newpaswd);
                    if (resultado == 1)
                    {
                        MessageBox.Show("Usuario registrado");

                    }
                    else
                    {
                        MessageBox.Show("Usuario no registrado");
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }

            }
        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = new Bitmap("MI3D.png");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                player = new SoundPlayer();
                player.SoundLocation = "MUSICA/MenuInicial.wav";
                player.Play();

                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

       
    }
}
