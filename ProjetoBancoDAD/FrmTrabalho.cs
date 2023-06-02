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
    public partial class FrmTrabalho : Form
    {
        public FrmTrabalho()
        {
            InitializeComponent();
        }

        private void tRABALHOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tRABALHOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmTrabalho_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.TRABALHO'. Você pode movê-la ou removê-la conforme necessário.
            this.tRABALHOTableAdapter.Fill(this.aTIVIDADEDataSet.TRABALHO);

        }
    }
}
