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
    public partial class FrmItensTelefoneCliente : Form
    {
        public FrmItensTelefoneCliente()
        {
            InitializeComponent();
        }

        private void iTENSTELCLIENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iTENSTELCLIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmItensTelefoneCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTETableAdapter.Fill(this.aTIVIDADEDataSet.CLIENTE);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.TELEFONE'. Você pode movê-la ou removê-la conforme necessário.
            this.tELEFONETableAdapter.Fill(this.aTIVIDADEDataSet.TELEFONE);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.ITENSTELCLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENSTELCLIENTETableAdapter.Fill(this.aTIVIDADEDataSet.ITENSTELCLIENTE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTelefone frmTelefone = new FrmTelefone();
            frmTelefone.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();
        }
    }
}
