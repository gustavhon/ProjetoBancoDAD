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
    public partial class FrmBairro : Form
    {
        public FrmBairro()
        {
            InitializeComponent();
        }

        private void bAIRROBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bAIRROBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmBairro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.BAIRRO'. Você pode movê-la ou removê-la conforme necessário.
            this.bAIRROTableAdapter.Fill(this.aTIVIDADEDataSet.BAIRRO);

        }
    }
}
