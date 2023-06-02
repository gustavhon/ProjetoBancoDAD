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
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void mARCABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mARCABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.MARCA'. Você pode movê-la ou removê-la conforme necessário.
            this.mARCATableAdapter.Fill(this.aTIVIDADEDataSet.MARCA);

        }
    }
}
