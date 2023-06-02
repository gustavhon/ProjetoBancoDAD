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
    public partial class FrmControleLogSistema : Form
    {
        public FrmControleLogSistema()
        {
            InitializeComponent();
        }

        private void cONTROLELOGSISTEMABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cONTROLELOGSISTEMABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmControleLogSistema_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.LOGIN'. Você pode movê-la ou removê-la conforme necessário.
            this.lOGINTableAdapter.Fill(this.aTIVIDADEDataSet.LOGIN);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.CONTROLELOGSISTEMA'. Você pode movê-la ou removê-la conforme necessário.
            this.cONTROLELOGSISTEMATableAdapter.Fill(this.aTIVIDADEDataSet.CONTROLELOGSISTEMA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }
    }
}
