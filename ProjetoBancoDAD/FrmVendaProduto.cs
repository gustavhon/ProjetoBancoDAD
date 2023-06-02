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
    public partial class FrmVendaProduto : Form
    {
        public FrmVendaProduto()
        {
            InitializeComponent();
        }

        private void vENDAPRODUTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vENDAPRODUTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmVendaProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOSTableAdapter.Fill(this.aTIVIDADEDataSet.FUNCIONARIOS);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTETableAdapter.Fill(this.aTIVIDADEDataSet.CLIENTE);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.VENDAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.vENDAPRODUTOTableAdapter.Fill(this.aTIVIDADEDataSet.VENDAPRODUTO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmFuncionario frmFuncionario = new FrmFuncionario();
            frmFuncionario.ShowDialog();
        }
    }
}
