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
        
        ArrayList agenda = new ArrayList();
        Persona contacto= new Persona();
       // List<Persona> agenda =new List<Persona>();// persona 
        public frmLista( ArrayList informacion)
        {
            InitializeComponent();
            agenda = informacion;
        }

        private void frmLista_Load(object sender, EventArgs e)
        {
            try
            {
                int renglones = agenda.Count;
                dataGridView1.Columns.Add("", "nombre");
                dataGridView1.Columns.Add("", "direccion");
                dataGridView1.Columns.Add("", "numero telefono");
                dataGridView1.Columns.Add("", "ciudad");
                for (int ren = 0; ren < renglones; ren++)
                {
                    contacto = (Persona)agenda[ren]; // casting 
                    dataGridView1.Rows.Add(contacto.nombre, contacto.direccion, contacto.numero - 1, contacto.ciudad);
                }
            }
            catch(Exception ){

            }
               
        }
    }
}
