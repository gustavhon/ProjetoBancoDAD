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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void pRODUTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRODUTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.TIPO'. Você pode movê-la ou removê-la conforme necessário.
            this.tIPOTableAdapter.Fill(this.aTIVIDADEDataSet.TIPO);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.MARCA'. Você pode movê-la ou removê-la conforme necessário.
            this.mARCATableAdapter.Fill(this.aTIVIDADEDataSet.MARCA);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOTableAdapter.Fill(this.aTIVIDADEDataSet.PRODUTO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMarca frmMarca = new FrmMarca();
            frmMarca.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTipo frmTipo = new FrmTipo();
            frmTipo.ShowDialog();
        }
    }
}
