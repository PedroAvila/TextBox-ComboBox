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
        /// <summary>
        /// La propiedad que hace de Primary Key de la entidad de negocio, por convencion solo puede llamarse
        /// Id, Nombre de entidad + Id como por ejemplo CategoriaId, PersonalId, ProductoId.
        /// Como también Nombre de entidad + _Id como por ejemplo Categoria_Id, Personal_Id, Prodeucto_Id
        /// 
        /// Solo de esas tres maneras puede llamarse la propiedad que hace de Primary Key(Id, CategoriaId, 
        /// Categoria_Id) es a modo de ejemplo.
        /// 
        /// Recomiendo usar la nomenclatura CamelCase para escribir el nombre de sus propiedades,
        /// Como por ejemplo PersonalId, RazonSocial, etc.
        /// </summary>
        public int CategoriaId { get; set; }
        /// <summary>
        /// Se debe agregar esta notación para que se pueda reconocer automaticamente el DisplayMenber 
        /// Del ComboBox.
        /// </summary>
        [ComboDisplayMember]
        public string Descripcion { get; set; }
    }
}
