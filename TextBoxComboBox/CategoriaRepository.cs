using System.Collections.Generic;

namespace TextBoxComboBox
{
    public class CategoriaRepository
    {
        public static List<Categoria> ListarCategoria()
        {
            var categorias = new List<Categoria>() { 
                new Categoria() { CategoriaId = 1, Descripcion = "Abarrotes" },
                new Categoria() { CategoriaId = 2, Descripcion = "Linea blanca" },
                new Categoria() { CategoriaId = 3, Descripcion = "Frutas" },
            };
            return categorias;
        }
    }
}
