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
    public partial class FrmSituacao : Form
    {
        public FrmSituacao()
        {
            InitializeComponent();
        }

        private void sITUACAOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sITUACAOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmSituacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.SITUACAO'. Você pode movê-la ou removê-la conforme necessário.
            this.sITUACAOTableAdapter.Fill(this.aTIVIDADEDataSet.SITUACAO);

        }
    }
}
