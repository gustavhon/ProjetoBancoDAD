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
    public partial class FrmImagens : Form
    {
        public FrmImagens()
        {
            InitializeComponent();
        }

        private void iMAGENSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iMAGENSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void iMAGENSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.iMAGENSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void iMAGENSBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.iMAGENSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void iMAGENSBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.iMAGENSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void iMAGENSBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.iMAGENSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTIVIDADEDataSet);

        }

        private void FrmImagens_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOTableAdapter.Fill(this.aTIVIDADEDataSet.PRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'aTIVIDADEDataSet.IMAGENS'. Você pode movê-la ou removê-la conforme necessário.
            this.iMAGENSTableAdapter.Fill(this.aTIVIDADEDataSet.IMAGENS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    iMAGEMPictureBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Um erro ocorreu", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
