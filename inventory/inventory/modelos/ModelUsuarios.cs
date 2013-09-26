using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace inventory.modelos
{

    class ModelUsuarios
    {
        public int i = 0;
        public SqlConnection conection;

        private String ERROR = "";

        public ModelUsuarios(/*SqlConnection conection*/)
        {
            //this.conection = conection;
        }//fin del constructor

        public void addUser()
        {

        }//fin de la funcion ....

        public void modifyUser()
        {

        }//fin de la funcion

        public void deleteUser()
        {

        }//fin de la funcion

        public Boolean getLogin(String User, String Password)
        {
            Boolean RETORNO = false;
            
            try
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("SELECT * FROM usuarios WHERE  usuario = '" + User + "' and contrasena = '" + Password + "'", conection);
                conection.Open();

               System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows == true)
                {
                    RETORNO = true;
                    reader.Close();
                }
                else
                {
                    RETORNO = false;
                    ERROR = "El Usuario o Contraseña son incorrectas.";
                }
            }
            catch (Exception)
            {
                ERROR = "La Conexion con el servidor fallo.\n"
                    + "Posibles Causas:\n "
                    + "\t1. Su computadora no tiene conexion a la red.\n"
                    + "\t2. El servidor no esta accesible.\n"
                    + "Por favor intente mas tarde. Si el problema persiste pongase en contacto con el administrador del sistema.";

                RETORNO = false;
            }

            finally
            {
                
                conection.Close();
            }

            return RETORNO;
        }//fin de la funcion

        public String getError()
        {
            return ERROR;
        }//funcion que retorna un error


    }
}
