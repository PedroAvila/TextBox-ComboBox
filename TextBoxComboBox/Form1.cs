using System;
using System.Windows.Forms;

namespace TextBoxComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // De esta manera simple y rápida se puede cargar un ComboBox.
            cboCategoria.DataSource = CategoriaRepository.ListarCategoria();
        }
    }
}
