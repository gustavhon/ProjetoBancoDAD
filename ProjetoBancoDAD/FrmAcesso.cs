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
    public partial class FrmAcesso : Form
    {
        public FrmAcesso()
        {
            InitializeComponent();
        }

        private void aCESSOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aCESSOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmAcesso_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.ACESSO'. Você pode movê-la ou removê-la conforme necessário.
            this.aCESSOTableAdapter.Fill(this.aTIVIDADEDataSet.ACESSO);

        }
    }
}
