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
    public partial class FrmItensTelefoneFornecedor : Form
    {
        public FrmItensTelefoneFornecedor()
        {
            InitializeComponent();
        }

        private void iTENSTELEFONEFORNECEDORBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iTENSTELEFONEFORNECEDORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmItensTelefoneFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.FORNECEDOR'. Você pode movê-la ou removê-la conforme necessário.
            this.fORNECEDORTableAdapter.Fill(this.aTIVIDADEDataSet.FORNECEDOR);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.TELEFONE'. Você pode movê-la ou removê-la conforme necessário.
            this.tELEFONETableAdapter.Fill(this.aTIVIDADEDataSet.TELEFONE);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.ITENSTELEFONEFORNECEDOR'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENSTELEFONEFORNECEDORTableAdapter.Fill(this.aTIVIDADEDataSet.ITENSTELEFONEFORNECEDOR);

        }
    }
}
