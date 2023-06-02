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
    public partial class FrmItensVendaProduto : Form
    {
        public FrmItensVendaProduto()
        {
            InitializeComponent();
        }

        private void iTENSVENDAPRODUTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iTENSVENDAPRODUTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmItensVendaProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOTableAdapter.Fill(this.aTIVIDADEDataSet.PRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.VENDAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.vENDAPRODUTOTableAdapter.Fill(this.aTIVIDADEDataSet.VENDAPRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.ITENSVENDAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENSVENDAPRODUTOTableAdapter.Fill(this.aTIVIDADEDataSet.ITENSVENDAPRODUTO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVendaProduto frmVendaProduto = new FrmVendaProduto();
            frmVendaProduto.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
        }
    }
}
