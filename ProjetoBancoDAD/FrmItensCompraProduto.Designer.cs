namespace ProjetoBancoDAD
{
    partial class FrmItensCompraProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cODCOMPRA_FKLabel;
            System.Windows.Forms.Label cODPRODUTO_FKLabel;
            System.Windows.Forms.Label qUANTIDADELabel;
            System.Windows.Forms.Label vALORCLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensCompraProduto));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.iTENSCOMPRAPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENSCOMPRAPRODUTOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.ITENSCOMPRAPRODUTOTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.iTENSCOMPRAPRODUTOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iTENSCOMPRAPRODUTOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODCOMPRA_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cODPRODUTO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.qUANTIDADETextBox = new System.Windows.Forms.TextBox();
            this.vALORCTextBox = new System.Windows.Forms.TextBox();
            this.iTENSCOMPRAPRODUTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cOMPRAPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPRAPRODUTOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.COMPRAPRODUTOTableAdapter();
            this.pRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.PRODUTOTableAdapter();
            cODCOMPRA_FKLabel = new System.Windows.Forms.Label();
            cODPRODUTO_FKLabel = new System.Windows.Forms.Label();
            qUANTIDADELabel = new System.Windows.Forms.Label();
            vALORCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSCOMPRAPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSCOMPRAPRODUTOBindingNavigator)).BeginInit();
            this.iTENSCOMPRAPRODUTOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSCOMPRAPRODUTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODCOMPRA_FKLabel
            // 
            cODCOMPRA_FKLabel.AutoSize = true;
            cODCOMPRA_FKLabel.Location = new System.Drawing.Point(273, 57);
            cODCOMPRA_FKLabel.Name = "cODCOMPRA_FKLabel";
            cODCOMPRA_FKLabel.Size = new System.Drawing.Size(95, 13);
            cODCOMPRA_FKLabel.TabIndex = 1;
            cODCOMPRA_FKLabel.Text = "CODCOMPRA FK:";
            // 
            // cODPRODUTO_FKLabel
            // 
            cODPRODUTO_FKLabel.AutoSize = true;
            cODPRODUTO_FKLabel.Location = new System.Drawing.Point(265, 91);
            cODPRODUTO_FKLabel.Name = "cODPRODUTO_FKLabel";
            cODPRODUTO_FKLabel.Size = new System.Drawing.Size(103, 13);
            cODPRODUTO_FKLabel.TabIndex = 3;
            cODPRODUTO_FKLabel.Text = "CODPRODUTO FK:";
            // 
            // qUANTIDADELabel
            // 
            qUANTIDADELabel.AutoSize = true;
            qUANTIDADELabel.Location = new System.Drawing.Point(12, 59);
            qUANTIDADELabel.Name = "qUANTIDADELabel";
            qUANTIDADELabel.Size = new System.Drawing.Size(81, 13);
            qUANTIDADELabel.TabIndex = 5;
            qUANTIDADELabel.Text = "QUANTIDADE:";
            // 
            // vALORCLabel
            // 
            vALORCLabel.AutoSize = true;
            vALORCLabel.Location = new System.Drawing.Point(40, 90);
            vALORCLabel.Name = "vALORCLabel";
            vALORCLabel.Size = new System.Drawing.Size(53, 13);
            vALORCLabel.TabIndex = 7;
            vALORCLabel.Text = "VALORC:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTENSCOMPRAPRODUTOBindingSource
            // 
            this.iTENSCOMPRAPRODUTOBindingSource.DataMember = "ITENSCOMPRAPRODUTO";
            this.iTENSCOMPRAPRODUTOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // iTENSCOMPRAPRODUTOTableAdapter
            // 
            this.iTENSCOMPRAPRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAIRROTableAdapter = null;
            this.tableAdapterManager.CEPTableAdapter = null;
            this.tableAdapterManager.CIDADETableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.COMPRAPRODUTOTableAdapter = null;
            this.tableAdapterManager.CONTROLELOGSISTEMATableAdapter = null;
            this.tableAdapterManager.FORNECEDORTableAdapter = null;
            this.tableAdapterManager.FUNCAOTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOSTableAdapter = null;
            this.tableAdapterManager.IMAGENSTableAdapter = null;
            this.tableAdapterManager.ITENSACESSOLOGINTableAdapter = null;
            this.tableAdapterManager.ITENSCOMPRAPRODUTOTableAdapter = this.iTENSCOMPRAPRODUTOTableAdapter;
            this.tableAdapterManager.ITENSTELCLIENTETableAdapter = null;
            this.tableAdapterManager.ITENSTELEFONEFORNECEDORTableAdapter = null;
            this.tableAdapterManager.ITENSTELEFONEFUNCIONARIOTableAdapter = null;
            this.tableAdapterManager.ITENSTELEFONELOJATableAdapter = null;
            this.tableAdapterManager.ITENSTELEFONETRABALHOTableAdapter = null;
            this.tableAdapterManager.ITENSVENDAPRODUTOTableAdapter = null;
            this.tableAdapterManager.LOGINTableAdapter = null;
            this.tableAdapterManager.LOJATableAdapter = null;
            this.tableAdapterManager.MARCATableAdapter = null;
            this.tableAdapterManager.OPERADORATableAdapter = null;
            this.tableAdapterManager.PARCELACOMPRATableAdapter = null;
            this.tableAdapterManager.PARCELAVENDATableAdapter = null;
            this.tableAdapterManager.PRODUTOTableAdapter = null;
            this.tableAdapterManager.RUATableAdapter = null;
            this.tableAdapterManager.SEXOTableAdapter = null;
            this.tableAdapterManager.SITUACAOTableAdapter = null;
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // iTENSCOMPRAPRODUTOBindingNavigator
            // 
            this.iTENSCOMPRAPRODUTOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTENSCOMPRAPRODUTOBindingNavigator.BindingSource = this.iTENSCOMPRAPRODUTOBindingSource;
            this.iTENSCOMPRAPRODUTOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTENSCOMPRAPRODUTOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTENSCOMPRAPRODUTOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.iTENSCOMPRAPRODUTOBindingNavigatorSaveItem});
            this.iTENSCOMPRAPRODUTOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTENSCOMPRAPRODUTOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTENSCOMPRAPRODUTOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTENSCOMPRAPRODUTOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTENSCOMPRAPRODUTOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTENSCOMPRAPRODUTOBindingNavigator.Name = "iTENSCOMPRAPRODUTOBindingNavigator";
            this.iTENSCOMPRAPRODUTOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTENSCOMPRAPRODUTOBindingNavigator.Size = new System.Drawing.Size(872, 25);
            this.iTENSCOMPRAPRODUTOBindingNavigator.TabIndex = 0;
            this.iTENSCOMPRAPRODUTOBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // iTENSCOMPRAPRODUTOBindingNavigatorSaveItem
            // 
            this.iTENSCOMPRAPRODUTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTENSCOMPRAPRODUTOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iTENSCOMPRAPRODUTOBindingNavigatorSaveItem.Image")));
            this.iTENSCOMPRAPRODUTOBindingNavigatorSaveItem.Name = "iTENSCOMPRAPRODUTOBindingNavigatorSaveItem";
            this.iTENSCOMPRAPRODUTOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iTENSCOMPRAPRODUTOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.iTENSCOMPRAPRODUTOBindingNavigatorSaveItem.Click += new System.EventHandler(this.iTENSCOMPRAPRODUTOBindingNavigatorSaveItem_Click_1);
            // 
            // cODCOMPRA_FKComboBox
            // 
            this.cODCOMPRA_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENSCOMPRAPRODUTOBindingSource, "CODCOMPRA_FK", true));
            this.cODCOMPRA_FKComboBox.DataSource = this.cOMPRAPRODUTOBindingSource;
            this.cODCOMPRA_FKComboBox.DisplayMember = "CODCOMPRA";
            this.cODCOMPRA_FKComboBox.FormattingEnabled = true;
            this.cODCOMPRA_FKComboBox.Location = new System.Drawing.Point(371, 53);
            this.cODCOMPRA_FKComboBox.Name = "cODCOMPRA_FKComboBox";
            this.cODCOMPRA_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODCOMPRA_FKComboBox.TabIndex = 2;
            this.cODCOMPRA_FKComboBox.ValueMember = "CODCOMPRA";
            // 
            // cODPRODUTO_FKComboBox
            // 
            this.cODPRODUTO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENSCOMPRAPRODUTOBindingSource, "CODPRODUTO_FK", true));
            this.cODPRODUTO_FKComboBox.DataSource = this.pRODUTOBindingSource;
            this.cODPRODUTO_FKComboBox.DisplayMember = "NOMEPRODUTO";
            this.cODPRODUTO_FKComboBox.FormattingEnabled = true;
            this.cODPRODUTO_FKComboBox.Location = new System.Drawing.Point(371, 87);
            this.cODPRODUTO_FKComboBox.Name = "cODPRODUTO_FKComboBox";
            this.cODPRODUTO_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODPRODUTO_FKComboBox.TabIndex = 4;
            this.cODPRODUTO_FKComboBox.ValueMember = "CODPRODUTO";
            // 
            // qUANTIDADETextBox
            // 
            this.qUANTIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENSCOMPRAPRODUTOBindingSource, "QUANTIDADE", true));
            this.qUANTIDADETextBox.Location = new System.Drawing.Point(96, 56);
            this.qUANTIDADETextBox.Name = "qUANTIDADETextBox";
            this.qUANTIDADETextBox.Size = new System.Drawing.Size(121, 20);
            this.qUANTIDADETextBox.TabIndex = 6;
            // 
            // vALORCTextBox
            // 
            this.vALORCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENSCOMPRAPRODUTOBindingSource, "VALORC", true));
            this.vALORCTextBox.Location = new System.Drawing.Point(96, 87);
            this.vALORCTextBox.Name = "vALORCTextBox";
            this.vALORCTextBox.Size = new System.Drawing.Size(121, 20);
            this.vALORCTextBox.TabIndex = 8;
            // 
            // iTENSCOMPRAPRODUTODataGridView
            // 
            this.iTENSCOMPRAPRODUTODataGridView.AutoGenerateColumns = false;
            this.iTENSCOMPRAPRODUTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iTENSCOMPRAPRODUTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.iTENSCOMPRAPRODUTODataGridView.DataSource = this.iTENSCOMPRAPRODUTOBindingSource;
            this.iTENSCOMPRAPRODUTODataGridView.Location = new System.Drawing.Point(15, 141);
            this.iTENSCOMPRAPRODUTODataGridView.Name = "iTENSCOMPRAPRODUTODataGridView";
            this.iTENSCOMPRAPRODUTODataGridView.ReadOnly = true;
            this.iTENSCOMPRAPRODUTODataGridView.Size = new System.Drawing.Size(845, 220);
            this.iTENSCOMPRAPRODUTODataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "QUANTIDADE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VALORC";
            this.dataGridViewTextBoxColumn4.HeaderText = "ValorC";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODCOMPRA_FK";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código CompraFK";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CODPRODUTO_FK";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código ProdutoFK";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cOMPRAPRODUTOBindingSource
            // 
            this.cOMPRAPRODUTOBindingSource.DataMember = "COMPRAPRODUTO";
            this.cOMPRAPRODUTOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // cOMPRAPRODUTOTableAdapter
            // 
            this.cOMPRAPRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUTOBindingSource
            // 
            this.pRODUTOBindingSource.DataMember = "PRODUTO";
            this.pRODUTOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // pRODUTOTableAdapter
            // 
            this.pRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmItensCompraProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iTENSCOMPRAPRODUTODataGridView);
            this.Controls.Add(cODCOMPRA_FKLabel);
            this.Controls.Add(this.cODCOMPRA_FKComboBox);
            this.Controls.Add(cODPRODUTO_FKLabel);
            this.Controls.Add(this.cODPRODUTO_FKComboBox);
            this.Controls.Add(qUANTIDADELabel);
            this.Controls.Add(this.qUANTIDADETextBox);
            this.Controls.Add(vALORCLabel);
            this.Controls.Add(this.vALORCTextBox);
            this.Controls.Add(this.iTENSCOMPRAPRODUTOBindingNavigator);
            this.Name = "FrmItensCompraProduto";
            this.Text = "FrmItensCompraProduto";
            this.Load += new System.EventHandler(this.FrmItensCompraProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSCOMPRAPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSCOMPRAPRODUTOBindingNavigator)).EndInit();
            this.iTENSCOMPRAPRODUTOBindingNavigator.ResumeLayout(false);
            this.iTENSCOMPRAPRODUTOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSCOMPRAPRODUTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource iTENSCOMPRAPRODUTOBindingSource;
        private ATIVIDADEDataSetTableAdapters.ITENSCOMPRAPRODUTOTableAdapter iTENSCOMPRAPRODUTOTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iTENSCOMPRAPRODUTOBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton iTENSCOMPRAPRODUTOBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox cODCOMPRA_FKComboBox;
        private System.Windows.Forms.ComboBox cODPRODUTO_FKComboBox;
        private System.Windows.Forms.TextBox qUANTIDADETextBox;
        private System.Windows.Forms.TextBox vALORCTextBox;
        private System.Windows.Forms.DataGridView iTENSCOMPRAPRODUTODataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource cOMPRAPRODUTOBindingSource;
        private ATIVIDADEDataSetTableAdapters.COMPRAPRODUTOTableAdapter cOMPRAPRODUTOTableAdapter;
        private System.Windows.Forms.BindingSource pRODUTOBindingSource;
        private ATIVIDADEDataSetTableAdapters.PRODUTOTableAdapter pRODUTOTableAdapter;
    }
}