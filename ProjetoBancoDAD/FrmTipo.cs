using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBancoDAD
{
    public partial class FrmTipo : Form
    {
        public FrmTipo()
        {
            InitializeComponent();
        }

        private void tIPOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tIPOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmTipo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.TIPO'. Você pode movê-la ou removê-la conforme necessário.
            this.tIPOTableAdapter.Fill(this.aTIVIDADEDataSet.TIPO);

        }
    }
}
