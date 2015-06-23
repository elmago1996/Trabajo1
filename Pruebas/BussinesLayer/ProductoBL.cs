using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModeler;

namespace BussinesLayer
{
    public class ProductoBL
    {
        public int Cuanto_stock_tengo_Producto(string c_producto)
        {
            using (DeliveryFastFoodEntities db = new DeliveryFastFoodEntities())
            {
                var query = db.Producto.FirstOrDefault(em => em.C_Producto == c_producto);
                if (query != null) return query.Q_Stock;
                return -1;

            }
        }

        public string Dame_Nombre_Producto(string c_producto)
        {
            using (DeliveryFastFoodEntities db = new DeliveryFastFoodEntities())
            {
                var query = db.Producto.FirstOrDefault(em => em.C_Producto == c_producto);
                if (query != null) return query.N_Producto.Replace(" ","");
                return null;
            }
        }


        public string Dame_Codigo_Producto(string nombre_producto)
        {
            using (DeliveryFastFoodEntities db = new DeliveryFastFoodEntities())
            {
                var query = db.Producto.FirstOrDefault(em => em.N_Producto == nombre_producto);
                if (query != null) return query.C_Producto.Replace(" ", "");
                return null;
            }
        }

    }
}
