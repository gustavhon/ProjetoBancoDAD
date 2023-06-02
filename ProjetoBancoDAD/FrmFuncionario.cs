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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void fUNCIONARIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fUNCIONARIOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.FUNCAO'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCAOTableAdapter.Fill(this.aTIVIDADEDataSet.FUNCAO);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.LOJA'. Você pode movê-la ou removê-la conforme necessário.
            this.lOJATableAdapter.Fill(this.aTIVIDADEDataSet.LOJA);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.CIDADE'. Você pode movê-la ou removê-la conforme necessário.
            this.cIDADETableAdapter.Fill(this.aTIVIDADEDataSet.CIDADE);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.CEP'. Você pode movê-la ou removê-la conforme necessário.
            this.cEPTableAdapter.Fill(this.aTIVIDADEDataSet.CEP);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.BAIRRO'. Você pode movê-la ou removê-la conforme necessário.
            this.bAIRROTableAdapter.Fill(this.aTIVIDADEDataSet.BAIRRO);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.RUA'. Você pode movê-la ou removê-la conforme necessário.
            this.rUATableAdapter.Fill(this.aTIVIDADEDataSet.RUA);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOSTableAdapter.Fill(this.aTIVIDADEDataSet.FUNCIONARIOS);

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

        private void button5_Click(object sender, EventArgs e)
        {
            FrmLoja frmLoja = new FrmLoja();
            frmLoja.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmFuncao frmFuncao = new FrmFuncao();
            frmFuncao.ShowDialog();
        }
    }
}
