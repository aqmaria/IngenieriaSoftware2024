using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCTD2020.ArquitecturaCapasV2.BLL;
using TCTD2020.ArquitecturaCapasV2.Servicios;
using TCTD2020.ArquitecturaCapasV2.UI;

namespace TCTD2020.ArquitecturaCapasV2.UI
{
    internal class Login
    {
        UsuarioBLL _usuarioBLL;

        public Login(UsuarioBLL usuarioBLL) {
            _usuarioBLL = usuarioBLL;
        }

        public void Ingresar(String email , String password)
        {
            try
            {
                ValidarInput(email, password);
                var res = _usuarioBLL.Login(email, password);


            }
            catch (Exception error)
            {
                Console.WriteLine("Ingreso no valido . Intente nuevamente");

            }
        }

        private void ValidarInput(String usuario, String password){
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                throw new Exception("No se ha ingresado usuario o contrasenia");
            }

            if (!Regex.IsMatch(usuario, "^[a-z0-9]+$"))
            {
                throw new Exception("Usuario incorrecto");
            }

            if (!Regex.IsMatch(password, "^[a-zA-Z0-9]+$"))
            {
                throw new Exception("Contrasenia incorrecta");
            }

        }
    }
}
