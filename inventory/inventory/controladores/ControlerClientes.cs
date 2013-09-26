using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using inventory.Vistas.Clientes;
using inventory;

namespace inventory.controladores
{
    class ControlerClientes 
    {
        //private addCliente add;
        private listClientes list;

        Main Main;

        //private System.Data.SqlClient.SqlConnection conection;

        /* Constructo de la Clase Cliente */
        public ControlerClientes(Main Main)
        {
            this.Main = Main;

            //add = new addCliente();
            list = new listClientes();
        }//fin de la funcion

        /* Funcion para agregar un Cliente */
        /*public UserControl addCliente()
        {
            Panel addCliente = new Panel();

            addCliente = this.add.

            add = new addCliente();

            return add;
        }//fin de la funcion */

        /* Funcion para mostrar todos los Clientes */
        public Panel listClientes()
        {
            list.conection = Main.conection;
            list.list();
            return list;
        }//fin de la funcion

        /* Funcion para modificar un Cliente */
        public void modifyCliente()
        {

        }//fin de la funcion

        /* Funcion para eliminar un Cliente */
        public void deleteCliente(String IdCliente)
        {

        }//fin de la funcion

        /* Funcion para buscar un Cliente */
        public void searchCliente(String IdCliente)
        {

        }//fin de la funcion

    }//fin de la clase
}
