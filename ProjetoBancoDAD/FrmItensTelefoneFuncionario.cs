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
    public partial class FrmItensTelefoneFuncionario : Form
    {
        public FrmItensTelefoneFuncionario()
        {
            InitializeComponent();
        }

        private void iTENSTELEFONEFUNCIONARIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iTENSTELEFONEFUNCIONARIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmItensTelefoneFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.TELEFONE'. Você pode movê-la ou removê-la conforme necessário.
            this.tELEFONETableAdapter.Fill(this.aTIVIDADEDataSet.TELEFONE);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOSTableAdapter.Fill(this.aTIVIDADEDataSet.FUNCIONARIOS);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.ITENSTELEFONEFUNCIONARIO'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENSTELEFONEFUNCIONARIOTableAdapter.Fill(this.aTIVIDADEDataSet.ITENSTELEFONEFUNCIONARIO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFuncionario frmFuncionario = new FrmFuncionario();
            frmFuncionario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTelefone frmTelefone = new FrmTelefone();
            frmTelefone.ShowDialog();
        }
    }
}
