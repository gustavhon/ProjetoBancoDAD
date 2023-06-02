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
    public partial class FrmCompraProduto : Form
    {
        public FrmCompraProduto()
        {
            InitializeComponent();
        }

        private void cOMPRAPRODUTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOMPRAPRODUTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmCompraProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOSTableAdapter.Fill(this.aTIVIDADEDataSet.FUNCIONARIOS);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.FORNECEDOR'. Você pode movê-la ou removê-la conforme necessário.
            this.fORNECEDORTableAdapter.Fill(this.aTIVIDADEDataSet.FORNECEDOR);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.COMPRAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.cOMPRAPRODUTOTableAdapter.Fill(this.aTIVIDADEDataSet.COMPRAPRODUTO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFornecedor frmFornecedor = new FrmFornecedor();
            frmFornecedor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmFuncionario frmFuncionario = new FrmFuncionario();
            frmFuncionario.ShowDialog();
        }
    }
}
