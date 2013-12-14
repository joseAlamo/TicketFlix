using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketFlix.Data.Persistence;
using TicketFlix.Commons.Entities;

namespace TicketFlix.MainForm
{
    public partial class Form1 : Form
    {
        #region VariablesGlobales
        List<string> AsientosSeleccionados;
        int Total;
        int PaloM = 35;
        int SodM = 20;
        int PaloG = 40;
        int SodG = 25;
        int nach = 30;
        List<PictureBox> pictureBoxList = new List<PictureBox>();
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<SALA> ListaSalas = new List<SALA>();
            ListaSalas = new SALAPersistence().GetList();
            foreach (SALA sala in ListaSalas)
            {
                cbSalas.Items.Add(sala.Película);
            }
            AsientosSeleccionados = new List<string>();
            pnDulce.Hide();
            nachos.BackColor = Color.White;
            nachos.Click += pictureDulce_Click;
            soda.BackColor = Color.White;
            soda.Click += pictureDulce_Click;
            palomitas.BackColor = Color.White;
            palomitas.Click += pictureDulce_Click;
            pictureBoxList.Add(nachos);
            pictureBoxList.Add(soda);
            pictureBoxList.Add(palomitas);
            foreach (PictureBox p in pictureBoxList)
            {
                pnDulce.Controls.Add(p);
            }
        }

        private void cbSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Total = 0;
            IEnumerable<SALA> Salas;
            Salas = from s
                    in new SALAPersistence().GetList()
                    where s.Película == cbSalas.SelectedItem.ToString()
                    select s;
            SALA SalaSeleccionada = new SALA();
            foreach (SALA sala in Salas)
            {
                SalaSeleccionada = sala;
            }

            IEnumerable<HORARIO> ListaHorario = new List<HORARIO>();
            ListaHorario = from h
                           in new HORARIOPersistence().GetList()
                           where h.SALA.IDSala == SalaSeleccionada.IDSala
                           select h;
            cbHorario.Items.Clear();            
            foreach (HORARIO horario in ListaHorario)
            {
                cbHorario.Items.Add(horario.Horario);
            }
        }

        void picture_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            PictureBox cosa = new PictureBox
            {
                ImageLocation = @"Imagenes\asientoB.jpg",
            };

            if (pic.ImageLocation == cosa.ImageLocation)
            {
                pic.ImageLocation = @"Imagenes\asientoV.jpg";
                AsientosSeleccionados.Add(pic.Name);
            }
            else
            {
                pic.ImageLocation = @"Imagenes\asientoB.jpg";
                AsientosSeleccionados.Remove(pic.Name);
            }
            Total += AsientosSeleccionados.Count * 39;
            lbTotal.Text = "$" + Total.ToString() + ".00";
        }
            
        private void cbHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region AsientosPorClickEnPictureBox
            pnAsientos.Refresh();
            IEnumerable<ASIENTO> ListaAsientos;
            ListaAsientos = from a
                            in new ASIENTOPersistence().GetList()
                            where a.HORARIO.Horario == cbHorario.SelectedItem.ToString()
                            select a;
            int tamanoSala = ListaAsientos.Count() / 5;
            List<PictureBox> listaPbAsientos = new List<PictureBox>();
            int d = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < tamanoSala; j++)
                {
                    PictureBox picture = new PictureBox
                    {
                        Name = d.ToString(),
                        Size = new Size(50, 50),
                        Location = new Point(j * 55, i * 55),
                        BorderStyle = BorderStyle.FixedSingle,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        ImageLocation = @"Imagenes\asientoB.jpg",
                    };
                    picture.BackColor = Color.Red;
                    picture.Click += picture_Click;
                    listaPbAsientos.Add(picture);
                    d++;
                }
            }

            foreach (PictureBox p in listaPbAsientos)
            {
                pnAsientos.Controls.Add(p);
            }
            #endregion
        }
        
        private void cbxOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (!pnDulce.Visible)
                pnDulce.Show();
            else
                pnDulce.Hide();
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            string pelicula = cbSalas.SelectedItem.ToString();
            string horario = cbHorario.SelectedItem.ToString();
            string asientos = string.Empty;
            foreach (string asiento in AsientosSeleccionados)
            {
                asientos += " " + asiento;
            }
            MessageBox.Show("La película es: " + pelicula + " a las " + horario + ". Tus asientos:" + asientos);
        }
        #region Dulceria
        private void btDulce_Click(object sender, EventArgs e)
        {
            string palom = string.Empty, nac = string.Empty, sod = string.Empty;
            string tam1 = string.Empty, tam2 = string.Empty;
            int t1 = 0, t2 = 0, t3 = 0;
            int totalNacho = 0, totalPalo = 0, totalSod = 0;

            if (nachos.BackColor == Color.Blue && nudNachos.Value != 0)
            {
                if (nudNachos.Value >= 2)
                {
                    nac = nachos.Name + "s";
                }
                else if (nudNachos.Value == 1)
                {
                    nac = nachos.Name;
                }
                t3 = Convert.ToInt32(nudNachos.Value);
                totalNacho = t3 * nach;
            }
            if (palomitas.BackColor == Color.Blue && (cbPalomitas.SelectedItem.ToString() == "mediana" || cbPalomitas.SelectedItem.ToString() == "grande") && nudPalomitas.Value != 0 && cbPalomitas.SelectedItem != null)
            {
                t1 = Convert.ToInt32(nudPalomitas.Value);
                if (nudPalomitas.Value >= 2)
                {
                    palom = palomitas.Name + "s";
                    if (cbPalomitas.SelectedItem.ToString() == "mediana")
                    {
                        tam1 = "medianas";
                        totalPalo = t1 * PaloM;
                    }

                    else if (cbPalomitas.SelectedItem.ToString() == "grande")
                    {
                        tam1 = "grandes";
                        totalPalo = t1 * PaloG;
                    }
                }
                else if (nudPalomitas.Value == 1)
                {
                    palom = palomitas.Name;
                    if (cbPalomitas.SelectedItem.ToString() == "mediana")
                    {
                        tam1 = cbPalomitas.SelectedItem.ToString();
                        totalPalo = t1 * PaloM;
                    }

                    else if (cbPalomitas.SelectedItem.ToString() == "grande")
                    {
                        tam1 = cbPalomitas.SelectedItem.ToString();
                        totalPalo = t1 * PaloG;
                    }
                }
            }
            if (soda.BackColor == Color.Blue && (cbSodas.SelectedItem.ToString() == "mediana" || cbSodas.SelectedItem.ToString() == "grande") && nudSodas.Value != 0 && cbSodas.SelectedItem != null)
            {
                t2 = Convert.ToInt32(nudSodas.Value);
                if (nudSodas.Value >= 2)
                {
                    sod = soda.Name + "s";
                    if (cbSodas.SelectedItem.ToString() == "mediana")
                    {
                        tam2 = "medianas";
                        totalSod = t2 * SodM;
                    }
                    else if (cbSodas.SelectedItem.ToString() == "grande")
                    {
                        tam2 = "grandes";
                        totalSod = t2 * SodG;
                    }
                }
                else if (nudSodas.Value == 1)
                {
                    sod = soda.Name;
                    if (cbSodas.SelectedItem.ToString() == "mediana")
                    {
                        tam2 = cbSodas.SelectedItem.ToString();
                        totalSod = t2 * SodM;
                    }
                    else if (cbSodas.SelectedItem.ToString() == "grande")
                    {
                        tam2 = cbSodas.SelectedItem.ToString();
                        totalSod = t2 * SodG;
                    }
                }
            }
            #region LógicaVentas
            if (nac != string.Empty && palom != string.Empty && sod != string.Empty)
            {
                MessageBox.Show("La orden consiste en " + t1 + " " + palom + " " + tam1 + ", " + t2 + " " + sod + " " + tam2 + " y " + t3 + " " + nac + ".");
                MessageBox.Show("El total es " + (totalNacho + totalPalo + totalSod));
            }

            else if (nac == string.Empty && palom == string.Empty && sod == string.Empty)
            {
                MessageBox.Show("Elija un producto");
            }

            else if (nac != string.Empty && palom == string.Empty && sod == string.Empty)
            {
                MessageBox.Show("La orden consiste en " + t3 + " " + nac + ".");
                MessageBox.Show("El total es " + (totalNacho + totalPalo + totalSod));
            }

            else if (nac == string.Empty && palom != string.Empty && sod == string.Empty)
            {
                MessageBox.Show("La orden consiste en " + t1 + " " + palom + " " + tam1 + ".");
                MessageBox.Show("El total es " + (totalNacho + totalPalo + totalSod));

            }

            else if (nac == string.Empty && palom == string.Empty && sod != string.Empty)
            {
                MessageBox.Show("La orden consiste en " + t2 + " " + sod + " " + tam2 + ".");
                MessageBox.Show("El total es " + (totalNacho + totalPalo + totalSod));

            }

            else if (nac != string.Empty && palom != string.Empty && sod == string.Empty)
            {
                MessageBox.Show("La orden consiste en " + t1 + " " + palom + " " + tam1 + " y " + t3 + " " + nac + ".");
                MessageBox.Show("El total es " + (totalNacho + totalPalo + totalSod));

            }

            else if (nac != string.Empty && palom == string.Empty && sod != string.Empty)
            {
                MessageBox.Show("La orden consiste en " + t2 + " " + sod + " " + tam2 + " y " + t3 + " " + nac + ".");
                MessageBox.Show("El total es " + (totalNacho + totalPalo + totalSod));

            }

            else if (nac == string.Empty && palom != string.Empty && sod != string.Empty)
            {
                MessageBox.Show("La orden consiste en " + t1 + " " + palom + " " + tam1 + " y " + t2 + " " + sod + " " + tam2 + ".");
                MessageBox.Show("El total es " + (totalNacho + totalPalo + totalSod));
            }
            Total += totalNacho + totalPalo + totalSod;
            lbTotal.Text = "$" + Total.ToString() + ".00";
            pnDulce.Hide();
            #endregion
            cbxOrden.Hide();
        }
        void pictureDulce_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (pic.BackColor == Color.White)
            {
                pic.BackColor = Color.Blue;
            }
            else
            {
                pic.BackColor = Color.White;
            }
        }

        #region Imagenes
        PictureBox palomitas = new PictureBox
        {
            Name = "palomita",
            Size = new Size(100, 100),
            Location = new Point(50, 55),
            BorderStyle = BorderStyle.FixedSingle,
            SizeMode = PictureBoxSizeMode.Zoom,
            ImageLocation = @"Imagenes\popcorn.png",
        };

        PictureBox soda = new PictureBox
        {
            Name = "soda",
            Size = new Size(100, 100),
            Location = new Point(150, 55),
            BorderStyle = BorderStyle.FixedSingle,
            SizeMode = PictureBoxSizeMode.Zoom,
            ImageLocation = @"Imagenes\soda.png",
        };

        PictureBox nachos = new PictureBox
        {
            Name = "nacho",
            Size = new Size(100, 100),
            Location = new Point(250, 55),
            BorderStyle = BorderStyle.FixedSingle,
            SizeMode = PictureBoxSizeMode.Zoom,
            ImageLocation = @"Imagenes\nachos.png",
        };
        #endregion
        #endregion








    }
}
