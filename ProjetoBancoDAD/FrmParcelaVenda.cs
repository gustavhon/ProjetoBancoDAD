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
    public partial class FrmParcelaVenda : Form
    {
        public FrmParcelaVenda()
        {
            InitializeComponent();
        }

        private void pARCELAVENDABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pARCELAVENDABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmParcelaVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.VENDAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.vENDAPRODUTOTableAdapter.Fill(this.aTIVIDADEDataSet.VENDAPRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.SITUACAO'. Você pode movê-la ou removê-la conforme necessário.
            this.sITUACAOTableAdapter.Fill(this.aTIVIDADEDataSet.SITUACAO);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.PARCELAVENDA'. Você pode movê-la ou removê-la conforme necessário.
            this.pARCELAVENDATableAdapter.Fill(this.aTIVIDADEDataSet.PARCELAVENDA);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmVendaProduto frmVendaProduto = new FrmVendaProduto();
            frmVendaProduto.ShowDialog();
        }
    }
}
