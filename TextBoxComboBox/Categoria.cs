using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalTech.TextBoxControl;

namespace TextBoxComboBox
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [ComboDisplayMember]
        public string Descripcion { get; set; }
    }
}
