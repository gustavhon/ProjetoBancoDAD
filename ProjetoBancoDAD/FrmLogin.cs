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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lOGINBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOGINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOSTableAdapter.Fill(this.aTIVIDADEDataSet.FUNCIONARIOS);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.LOGIN'. Você pode movê-la ou removê-la conforme necessário.
            this.lOGINTableAdapter.Fill(this.aTIVIDADEDataSet.LOGIN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFuncionario frmFuncionario = new FrmFuncionario();
            frmFuncionario.ShowDialog();
        }

        private void sENHATextBox_TextChanged(object sender, EventArgs e)
        {
            sENHATextBox.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sENHATextBox.PasswordChar == '*')
            {
                sENHATextBox.PasswordChar = '\0'; //revelar senha
            }
            else
            {
                sENHATextBox.PasswordChar = '*'; //esconder senha
            }
        }
    }
}
