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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("", "nombre");
            dataGridView1.Columns.Add("", "direccion");
            dataGridView1.Columns.Add("", "numero telefono");
            dataGridView1.Columns.Add("", "ciudad");
        }
        ArrayList agenda = new ArrayList();
        Persona perso = new Persona();
        int renglon;
        int bandera = 0;
        public struct Persona
        {
            public string nombre;
            public string direccion;
            public string ciudad;
            public long numero;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                perso.nombre = textBoxNombre.Text;
                perso.direccion = textBoxDireccion.Text;
                perso.numero = Convert.ToInt64(textBoxNumero.Text);
                perso.ciudad = textBoxCiudad.Text;
                if (bandera == 1)
                {
                    agenda.Add(perso);
                    dataGridView1.Rows.Add(perso.nombre, perso.direccion, perso.numero, perso.ciudad);
                    MessageBox.Show("contacto guardado correctamente", "agenda ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataGridView1[0, renglon].Value = perso.nombre;
                    dataGridView1[1, renglon].Value = perso.direccion;
                    dataGridView1[2, renglon].Value = perso.numero;
                    dataGridView1[3, renglon].Value = perso.ciudad;
                }
                textBoxNombre.Clear();
                textBoxDireccion.Clear();
                textBoxNumero.Clear();
                textBoxCiudad.Clear();
                panel1.Enabled = false;
            }
            catch(Exception)
            {
                MessageBox.Show("error");
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            textBoxNombre.Focus();
            bandera = 1;//agregar nuevo
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             renglon = dataGridView1.CurrentRow.Index;// celda actual
            textBoxNombre.Text = dataGridView1.Rows[renglon].Cells[0].Value.ToString();
            textBoxDireccion.Text = dataGridView1.Rows[renglon].Cells[1].Value.ToString();
            textBoxNumero.Text = dataGridView1.Rows[renglon].Cells[2].Value.ToString();
            textBoxCiudad.Text = dataGridView1.Rows[renglon].Cells[3].Value.ToString();
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;





        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            textBoxNombre.Focus();
            bandera = 2;// modificar 
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            
            frmLista listar = new frmLista(agenda);
            listar.ShowDialog(); 
        }
        
    }
}
