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
    public partial class FrmCep : Form
    {
        public FrmCep()
        {
            InitializeComponent();
        }

        private void cEPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cEPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmCep_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.CEP'. Você pode movê-la ou removê-la conforme necessário.
            this.cEPTableAdapter.Fill(this.aTIVIDADEDataSet.CEP);

        }
    }
}
