using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace postgres2
{
    public partial class clienteForm : Form
    {
        public clienteForm()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basedatos1DataSet);

        }

        private void clienteForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basedatos1DataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.basedatos1DataSet.cliente);

        }
    }
}
