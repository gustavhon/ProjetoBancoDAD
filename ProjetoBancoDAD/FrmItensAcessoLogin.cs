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
    public partial class FrmItensAcessoLogin : Form
    {
        public FrmItensAcessoLogin()
        {
            InitializeComponent();
        }

        private void iTENSACESSOLOGINBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iTENSACESSOLOGINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmItensAcessoLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.LOGIN'. Você pode movê-la ou removê-la conforme necessário.
            this.lOGINTableAdapter.Fill(this.aTIVIDADEDataSet.LOGIN);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.ACESSO'. Você pode movê-la ou removê-la conforme necessário.
            this.aCESSOTableAdapter.Fill(this.aTIVIDADEDataSet.ACESSO);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.ITENSACESSOLOGIN'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENSACESSOLOGINTableAdapter.Fill(this.aTIVIDADEDataSet.ITENSACESSOLOGIN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAcesso frmAcesso = new FrmAcesso();
            frmAcesso.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }
    }
}
