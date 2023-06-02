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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void cLIENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.TRABALHO'. Você pode movê-la ou removê-la conforme necessário.
            this.tRABALHOTableAdapter.Fill(this.aTIVIDADEDataSet.TRABALHO);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.CEP'. Você pode movê-la ou removê-la conforme necessário.
            this.cEPTableAdapter.Fill(this.aTIVIDADEDataSet.CEP);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.BAIRRO'. Você pode movê-la ou removê-la conforme necessário.
            this.bAIRROTableAdapter.Fill(this.aTIVIDADEDataSet.BAIRRO);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.RUA'. Você pode movê-la ou removê-la conforme necessário.
            this.rUATableAdapter.Fill(this.aTIVIDADEDataSet.RUA);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.SEXO'. Você pode movê-la ou removê-la conforme necessário.
            this.sEXOTableAdapter.Fill(this.aTIVIDADEDataSet.SEXO);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTETableAdapter.Fill(this.aTIVIDADEDataSet.CLIENTE);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTETableAdapter.Fill(this.aTIVIDADEDataSet.CLIENTE);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTETableAdapter.Fill(this.aTIVIDADEDataSet.CLIENTE);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTETableAdapter.Fill(this.aTIVIDADEDataSet.CLIENTE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSexo frmSexo = new FrmSexo();
            frmSexo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRua frmRua = new FrmRua();
            frmRua.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBairro frmBairro = new FrmBairro();
            frmBairro.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmCep frmCep = new FrmCep();
            frmCep.ShowDialog();
        }

        private void cLIENTEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void cLIENTEBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void cLIENTEBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmSexo frmSexo = new FrmSexo();
            frmSexo.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmRua frmRua = new FrmRua();
            frmRua.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmBairro frmBairro = new FrmBairro();
            frmBairro.ShowDialog();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FrmCep frmCep = new FrmCep();
            frmCep.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            FrmTrabalho frmTrabalho = new FrmTrabalho();
            frmTrabalho.ShowDialog();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cLIENTETableAdapter.Fill(this.aTIVIDADEDataSet.CLIENTE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "";

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                    imageLocation = dialog.FileName;

                    fOTOPictureBox.ImageLocation = imageLocation;
                }
            }
            catch(Exception) {
                MessageBox.Show("Um erro ocorreu","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
