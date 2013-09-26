using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

using inventory.Vistas;
using inventory.controladores;

namespace inventory
{
    public partial class Main : Form
    {
        private ControlerClientes clientes;
        private Proveedores proveedores = new Proveedores();
        private Articulos articulos = new Articulos();
        private Entradas entradas = new Entradas();
        private Salidas salidas = new Salidas();
        private Login login = new Login();

        //private listClientes listClientes = new listClientes();

        public Main()
        {
            clientes = new ControlerClientes(this); //se llama al controlador cliente

            InitializeComponent();

            //verClientes.Visible = false;
            //panel1.Visible = false;
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Contenedor.Controls.Clear();

            int childFormNumber = 0;
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();

            //Contenedor.Controls.Add();



            //verClientes.Visible = true;
            //Contenedor.Controls.Add(verClientes);


            //this.Contenedor.Controls.Clear();
            //Contenedor.Controls.Add(clientes.listClientes());
            
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Contenedor.Controls.Clear();
            //panel1.Visible = true;
            //Contenedor.Controls.Add(panel1);

            //this.Contenedor.Controls.Clear();
            //Contenedor.Controls.Add(proveedores.listProveedores());
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Contenedor.Controls.Clear();
            Contenedor.Controls.Add(entradas.listEntradas());
        }

        private void salidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Contenedor.Controls.Clear();
            Contenedor.Controls.Add(salidas.listSalidas());
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Contenedor.Controls.Clear();
            Contenedor.Controls.Add(articulos.listArticulos());
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.label1.Text = "Hora " + DateTime.Now.ToLongTimeString() + "Ayuda";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.menuStrip1.Visible = false;
            this.Contenedor.Controls.Add(login.PanelLogin(this));
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 