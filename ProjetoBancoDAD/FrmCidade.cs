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
    public partial class FrmCidade : Form
    {
        public FrmCidade()
        {
            InitializeComponent();
        }

        private void cIDADEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cIDADEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmCidade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.UF'. Você pode movê-la ou removê-la conforme necessário.
            this.uFTableAdapter.Fill(this.aTIVIDADEDataSet.UF);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.CIDADE'. Você pode movê-la ou removê-la conforme necessário.
            this.cIDADETableAdapter.Fill(this.aTIVIDADEDataSet.CIDADE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUf frmUf = new FrmUf();
            frmUf.ShowDialog();
        }
    }
}
