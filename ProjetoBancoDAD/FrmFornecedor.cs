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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void fORNECEDORBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fORNECEDORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.BAIRRO'. Você pode movê-la ou removê-la conforme necessário.
            this.bAIRROTableAdapter.Fill(this.aTIVIDADEDataSet.BAIRRO);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.RUA'. Você pode movê-la ou removê-la conforme necessário.
            this.rUATableAdapter.Fill(this.aTIVIDADEDataSet.RUA);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.FORNECEDOR'. Você pode movê-la ou removê-la conforme necessário.
            this.fORNECEDORTableAdapter.Fill(this.aTIVIDADEDataSet.FORNECEDOR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRua frmRua = new FrmRua();
            frmRua.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBairro frmBairro = new FrmBairro();
            frmBairro.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCep frmCep = new FrmCep();
            frmCep.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmCidade frmCidade = new FrmCidade();
            frmCidade.ShowDialog();
        }
    }
}
