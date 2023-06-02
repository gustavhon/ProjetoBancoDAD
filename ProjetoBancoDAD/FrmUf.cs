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
    public partial class FrmUf : Form
    {
        public FrmUf()
        {
            InitializeComponent();
        }

        private void uFBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uFBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmUf_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.UF'. Você pode movê-la ou removê-la conforme necessário.
            this.uFTableAdapter.Fill(this.aTIVIDADEDataSet.UF);

        }
    }
}
