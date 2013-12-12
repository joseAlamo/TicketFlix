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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //SALA sala = new SALA();
            //sala.Película = "ble";
            //SALAPersistence spers = new SALAPersistence();
            //SALA salaprueba = new SALA();
            //salaprueba = spers.Create(sala);
            //MessageBox.Show(salaprueba.Película);

            

            //HORARIO hora = new HORARIO();
            //hora.Horario = "10:08 - 12:00";
            //hora.SALA = new SALA();
            //hora.SALA.IDSala = 1;
            //HORARIOPersistence hpers = new HORARIOPersistence();
            //HORARIO horaprueba = new HORARIO();
            //horaprueba = hpers.Create(hora);

            //MessageBox.Show(horaprueba.IDHorario + hora.SALA.Película);

            //ASIENTO seat = new ASIENTO();
            //seat.Orden = "Palomitas";
            //seat.Disponiblidad = false;


            //HORARIO hora = new HORARIO();
            //hora.Horario = "9:17 - 10:00";
            //hora.IDHorario = 1;
            //HORARIOPersistence hpers = new HORARIOPersistence();
            //HORARIO laprueba = new HORARIO();
            //laprueba = hpers.Update(hora);
            //MessageBox.Show(laprueba.IDHorario + " " + laprueba.Horario);

            //ASIENTO asiento = new ASIENTO();
            //asiento.IDAsiento = 0;
            //asiento.Disponiblidad = true;
            //asiento.Orden = "Crepas";
            //ASIENTOPersistence apers = new ASIENTOPersistence();
            //ASIENTO laprueba = new ASIENTO();
            //laprueba = apers.Update(asiento);
            //MessageBox.Show(laprueba.IDAsiento + " " + laprueba.Orden + " " + laprueba.Disponiblidad);

            //SALA sala = new SALA();
            //sala.IDSala = 1;
            //sala.Película = "Aracnofobia";
            //SALAPersistence spers = new SALAPersistence();
            //SALA laprueba = new SALA();
            //laprueba = spers.Update(sala);
            //MessageBox.Show(laprueba.IDSala + " " + laprueba.Película);

            List<SALA> lista = new List<SALA>();
            SALAPersistence spers = new SALAPersistence();
            lista = spers.GetList();


        }
    }
}
