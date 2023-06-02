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
    public partial class FrmItensCompraProduto : Form
    {
        public FrmItensCompraProduto()
        {
            InitializeComponent();
        }

        private void iTENSCOMPRAPRODUTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iTENSCOMPRAPRODUTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void iTENSCOMPRAPRODUTOBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.iTENSCOMPRAPRODUTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmItensCompraProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOTableAdapter.Fill(this.aTIVIDADEDataSet.PRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.COMPRAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.cOMPRAPRODUTOTableAdapter.Fill(this.aTIVIDADEDataSet.COMPRAPRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.ITENSCOMPRAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENSCOMPRAPRODUTOTableAdapter.Fill(this.aTIVIDADEDataSet.ITENSCOMPRAPRODUTO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCompraProduto frmCompraProduto = new FrmCompraProduto();
            frmCompraProduto.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
        }
    }
}
