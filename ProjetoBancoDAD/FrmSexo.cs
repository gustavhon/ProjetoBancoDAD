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
    public partial class FrmSexo : Form
    {
        public FrmSexo()
        {
            InitializeComponent();
        }

        private void sEXOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sEXOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmSexo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.SEXO'. Você pode movê-la ou removê-la conforme necessário.
            this.sEXOTableAdapter.Fill(this.aTIVIDADEDataSet.SEXO);

        }
    }
}
