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
    public partial class FrmItensTelefoneLoja : Form
    {
        public FrmItensTelefoneLoja()
        {
            InitializeComponent();
        }

        private void iTENSTELEFONELOJABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iTENSTELEFONELOJABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void ItensTelefoneLoja_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.ITENSTELEFONELOJA'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENSTELEFONELOJATableAdapter.Fill(this.aTIVIDADEDataSet.ITENSTELEFONELOJA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLoja frmLoja = new FrmLoja();
            frmLoja.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTelefone frmTelefone = new FrmTelefone();
            frmTelefone.ShowDialog();
        }
    }
}
