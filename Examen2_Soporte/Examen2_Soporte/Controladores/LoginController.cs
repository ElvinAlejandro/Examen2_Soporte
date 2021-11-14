using Examen2_Soporte.Modelos.DAO;
using Examen2_Soporte.Modelos.Entidades;
using Examen2_Soporte.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2_Soporte.Controladores
{
    public class LoginController
    {
        LoginView vista;

        public  LoginController(LoginView view)
        {
            vista = view;

            vista.IngresarButton.Click += new EventHandler(ValidarUsuario);
        }




        private void ValidarUsuario(object serder, EventArgs e)
        {
            bool esValido = false;

            UsuarioDAO userDao = new UsuarioDAO();

            Usuario user = new Usuario();

            user.Correo = vista.CorreoTextBox.Text;
            user.Clave = vista.ClaveTextBox.Text;

            esValido = userDao.ValidarUsuario(user);

            if (esValido)
            {
                MessageBox.Show("Usuario Correcto");
                //MenuView menu = new MenuView();
                //vista.Hide();

                //menu.CorreoUsuario = user.Correo;

                //menu.Show();

            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }

    }
}
