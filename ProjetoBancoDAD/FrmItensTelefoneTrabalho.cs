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
    public partial class FrmItensTelefoneTrabalho : Form
    {
        public FrmItensTelefoneTrabalho()
        {
            InitializeComponent();
        }

        private void iTENSTELEFONETRABALHOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iTENSTELEFONETRABALHOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmItensTelefoneTrabalho_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.TELEFONE'. Você pode movê-la ou removê-la conforme necessário.
            this.tELEFONETableAdapter.Fill(this.aTIVIDADEDataSet.TELEFONE);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.TRABALHO'. Você pode movê-la ou removê-la conforme necessário.
            this.tRABALHOTableAdapter.Fill(this.aTIVIDADEDataSet.TRABALHO);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.ITENSTELEFONETRABALHO'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENSTELEFONETRABALHOTableAdapter.Fill(this.aTIVIDADEDataSet.ITENSTELEFONETRABALHO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTrabalho frmTrabalho = new FrmTrabalho();
            frmTrabalho.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTelefone frmTelefone = new FrmTelefone();
            frmTelefone.ShowDialog();
        }
    }
}
