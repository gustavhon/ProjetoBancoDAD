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
    public partial class FrmRua : Form
    {
        public FrmRua()
        {
            InitializeComponent();
        }

        private void rUABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rUABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmRua_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.RUA'. Você pode movê-la ou removê-la conforme necessário.
            this.rUATableAdapter.Fill(this.aTIVIDADEDataSet.RUA);

        }
    }
}
