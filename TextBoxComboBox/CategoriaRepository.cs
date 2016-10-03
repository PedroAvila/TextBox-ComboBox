using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBoxComboBox
{
    public class CategoriaRepository
    {
        public static List<Categoria> ListarCategoria()
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
            {
                cn.Open();
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "SELECT CategoriaId, Descripcion FROM Categorias";
                    var entity = new List<Categoria>();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var s = new Categoria()
                            {
                                CategoriaId = Convert.ToInt32(reader["CategoriaId"]),
                                Descripcion = Convert.ToString(reader["Descripcion"])
                            };
                            entity.Add(s);
                        }
                    }
                    return entity;
                }
            }
        }
    }
}
