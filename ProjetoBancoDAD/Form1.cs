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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();
        }

        private void sexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSexo frmSexo = new FrmSexo();
            frmSexo.ShowDialog();
        }

        private void ruaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRua frmRua = new FrmRua();
            frmRua.ShowDialog();
        }

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBairro frmBairro = new FrmBairro();
            frmBairro.ShowDialog();
        }

        private void cepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCep frmCep = new FrmCep();
            frmCep.ShowDialog();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCidade frmCidade = new FrmCidade();
            frmCidade.ShowDialog();
        }

        private void ufToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUf frmUf = new FrmUf();
            frmUf.ShowDialog();
        }

        private void trabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrabalho frmTrabalho = new FrmTrabalho();
            frmTrabalho.ShowDialog();
        }

        private void telefoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelefone frmTelefone = new FrmTelefone();
            frmTelefone.ShowDialog();
        }

        private void iTENSTELCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItensTelefoneCliente frmItensTelCliente = new FrmItensTelefoneCliente();
            frmItensTelCliente.ShowDialog();
        }

        private void iTENSTELTRABALHOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItensTelefoneTrabalho frmItensTelefoneTrabalho = new FrmItensTelefoneTrabalho();
            frmItensTelefoneTrabalho.ShowDialog();
        }

        private void fUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario frmFuncionarios = new FrmFuncionario();
            frmFuncionarios.ShowDialog();
        }

        private void fUNÇÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncao frmFuncao = new FrmFuncao();
            frmFuncao.ShowDialog();
        }

        private void iTENSTELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItensTelefoneFuncionario frmItensTelefoneFuncionario = new FrmItensTelefoneFuncionario();
            frmItensTelefoneFuncionario.ShowDialog();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void cONTROLELOGSISTEMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmControleLogSistema frmControleLogSistema = new FrmControleLogSistema();
            frmControleLogSistema.ShowDialog();
        }

        private void aCESSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcesso frmAcesso = new FrmAcesso();
            frmAcesso.ShowDialog();
        }

        private void iTENSACESSOLOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItensAcessoLogin frmItensAcessoLogin = new FrmItensAcessoLogin();
            frmItensAcessoLogin.ShowDialog();
        }

        private void lOJAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoja frmLoja = new FrmLoja();
            frmLoja.ShowDialog();
        }

        private void operadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperadora frmOperadora = new FrmOperadora();
            frmOperadora.ShowDialog();
        }

        private void mARCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca frmMarca = new FrmMarca();
            frmMarca.ShowDialog();
        }

        private void tIPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipo frmTipo = new FrmTipo();
            frmTipo.ShowDialog();
        }

        private void fORNECEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedor frmFornecedor = new FrmFornecedor();
            frmFornecedor.ShowDialog();
        }

        private void iTENSTELEFONEFORNECEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItensTelefoneFornecedor frmItensTelefoneFornecedor = new FrmItensTelefoneFornecedor();
            frmItensTelefoneFornecedor.ShowDialog();
        }

        private void cOMPRAPRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompraProduto frmCompraProduto = new FrmCompraProduto();
            frmCompraProduto.ShowDialog();
        }

        private void iTENSCOMPRAPRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItensCompraProduto frmItensCompraProduto = new FrmItensCompraProduto();
            frmItensCompraProduto.ShowDialog();
        }

        private void pRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
        }

        private void vENDAPRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendaProduto frmVendaProduto = new FrmVendaProduto();
            frmVendaProduto.ShowDialog();
        }

        private void iTENSVENDAPRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItensVendaProduto frmItensVendaProduto = new FrmItensVendaProduto();
            frmItensVendaProduto.ShowDialog();
        }

        private void pARCELAVENDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParcelaVenda frmParcelaVenda = new FrmParcelaVenda();
            frmParcelaVenda.ShowDialog();
        }

        private void sITUACAOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSituacao frmSituacao = new FrmSituacao();
            frmSituacao.ShowDialog();
        }

        private void iMAGENSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImagens frmImagens = new FrmImagens();
            frmImagens.ShowDialog();
        }
    }
}
