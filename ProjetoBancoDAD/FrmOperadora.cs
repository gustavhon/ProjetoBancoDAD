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
    public partial class FrmOperadora : Form
    {
        public FrmOperadora()
        {
            InitializeComponent();
        }

        private void oPERADORABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oPERADORABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmOperadora_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.OPERADORA'. Você pode movê-la ou removê-la conforme necessário.
            this.oPERADORATableAdapter.Fill(this.aTIVIDADEDataSet.OPERADORA);

        }
    }
}
