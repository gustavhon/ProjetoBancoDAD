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
    public partial class FrmTelefone : Form
    {
        public FrmTelefone()
        {
            InitializeComponent();
        }

        private void tELEFONEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tELEFONEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmTelefone_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.OPERADORA'. Você pode movê-la ou removê-la conforme necessário.
            this.oPERADORATableAdapter.Fill(this.aTIVIDADEDataSet.OPERADORA);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.TELEFONE'. Você pode movê-la ou removê-la conforme necessário.
            this.tELEFONETableAdapter.Fill(this.aTIVIDADEDataSet.TELEFONE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOperadora frmOperadora = new FrmOperadora();
            frmOperadora.ShowDialog();
        }
    }
}
