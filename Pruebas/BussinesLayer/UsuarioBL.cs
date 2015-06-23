using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModeler;

namespace BussinesLayer
{
    public class UsuarioBL
    {
        public string DamePassword_Usuario(string username)
        {
            using(DeliveryFastFoodEntities db = new DeliveryFastFoodEntities())
            {
                var usuario = db.Usuario.FirstOrDefault(em => em.UserName == username);
                if(usuario != null) return usuario.Password_Usuario.ToString().Replace(" ","");
                return null;   
            }
        }

        public bool Contraseña_Correcta(string username, string pass)
        {
            using (DeliveryFastFoodEntities db = new DeliveryFastFoodEntities())
            {
                var usuario = db.Usuario.FirstOrDefault(em => em.UserName == username);
                if(usuario != null)
                {
                    if(usuario.Password_Usuario.Replace(" ","") == pass)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
        }

        public bool Existen_Usuarios_en_tabla()
        {
            using (DeliveryFastFoodEntities db = new DeliveryFastFoodEntities())
            {
                var query = db.Usuario.Count();
                if (query > 0)
                    return true;
                return false;
            }
        }



    }
}
