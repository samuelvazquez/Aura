using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data;

namespace inventory.Vistas.Clientes
{
    class listClientes : Panel
    {
        public SqlConnection conection;

        public Panel list()
        {
            InitializeComponent();

            try
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("SELECT * FROM usuarios", conection);
                conection.Open();

                System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show(String.Format("{0}", reader["usuario"]) + " " + String.Format("{0}", reader["usuario"]));

                    }
                    reader.Close();
                }
                else
                {
                    //RETORNO = false;
                    //ERROR = "El Usuario o Contraseña son incorrectas.";
                }
            }
            catch (Exception err)
            {

                MessageBox.Show("Hola - " + err.Message);
                //ERROR = "La Conexion con el servidor fallo.\n"
                /* + "Posibles Causas:\n "
                 + "\t1. Su computadora no tiene conexion a la red.\n"
                 + "\t2. El servidor no esta accesible.\n"
                 + "Por favor intente mas tarde. Si el problema persiste pongase en contacto con el administrador del sistema.";*/

                //RETORNO = false;
            }

            finally
            {

                //conection.Close();
            }
            return this;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
