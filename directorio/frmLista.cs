using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace directorio
{
    public partial class frmLista : Form
    {
        public struct Persona
        {
            public string nombre;
            public string direccion;
            public string ciudad;
            public long numero;
        }
        Persona contacto= new Persona();
        ArrayList agenda;
        public frmLista( ArrayList datos)
        {
            InitializeComponent();
            agenda = datos;
        }

        private void frmLista_Load(object sender, EventArgs e)
        {
            int renglones = agenda.Count;
            dataGridView1.Columns.Add("", "nombre");
            dataGridView1.Columns.Add("", "direccion");
            dataGridView1.Columns.Add("", "numero telefono");
            dataGridView1.Columns.Add("", "ciudad");
            for (int ren = 0; ren < renglones; ren++)
            {
                contacto = (Persona)agenda[ren]; // casting 
                dataGridView1.Rows.Add(contacto.nombre, contacto.direccion, contacto.numero, contacto.ciudad);
            }
               
        }
    }
}
