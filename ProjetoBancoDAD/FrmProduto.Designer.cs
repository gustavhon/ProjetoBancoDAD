namespace ProjetoBancoDAD
{
    partial class FrmProduto
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
            System.Windows.Forms.Label cODPRODUTOLabel;
            System.Windows.Forms.Label nOMEPRODUTOLabel;
            System.Windows.Forms.Label qUANTIDADELabel;
            System.Windows.Forms.Label vALORLabel;
            System.Windows.Forms.Label cODMARCA_FKLabel;
            System.Windows.Forms.Label cODTIPO_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.pRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.PRODUTOTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.pRODUTOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pRODUTOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODPRODUTOLabel1 = new System.Windows.Forms.Label();
            this.nOMEPRODUTOTextBox = new System.Windows.Forms.TextBox();
            this.qUANTIDADETextBox = new System.Windows.Forms.TextBox();
            this.vALORTextBox = new System.Windows.Forms.TextBox();
            this.cODMARCA_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cODTIPO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pRODUTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARCABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mARCATableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.MARCATableAdapter();
            this.tIPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TIPOTableAdapter();
            cODPRODUTOLabel = new System.Windows.Forms.Label();
            nOMEPRODUTOLabel = new System.Windows.Forms.Label();
            qUANTIDADELabel = new System.Windows.Forms.Label();
            vALORLabel = new System.Windows.Forms.Label();
            cODMARCA_FKLabel = new System.Windows.Forms.Label();
            cODTIPO_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingNavigator)).BeginInit();
            this.pRODUTOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODPRODUTOLabel
            // 
            cODPRODUTOLabel.AutoSize = true;
            cODPRODUTOLabel.Location = new System.Drawing.Point(25, 49);
            cODPRODUTOLabel.Name = "cODPRODUTOLabel";
            cODPRODUTOLabel.Size = new System.Drawing.Size(83, 13);
            cODPRODUTOLabel.TabIndex = 1;
            cODPRODUTOLabel.Text = "Código Produto:";
            // 
            // nOMEPRODUTOLabel
            // 
            nOMEPRODUTOLabel.AutoSize = true;
            nOMEPRODUTOLabel.Location = new System.Drawing.Point(30, 78);
            nOMEPRODUTOLabel.Name = "nOMEPRODUTOLabel";
            nOMEPRODUTOLabel.Size = new System.Drawing.Size(78, 13);
            nOMEPRODUTOLabel.TabIndex = 3;
            nOMEPRODUTOLabel.Text = "Nome Produto:";
            // 
            // qUANTIDADELabel
            // 
            qUANTIDADELabel.AutoSize = true;
            qUANTIDADELabel.Location = new System.Drawing.Point(251, 45);
            qUANTIDADELabel.Name = "qUANTIDADELabel";
            qUANTIDADELabel.Size = new System.Drawing.Size(65, 13);
            qUANTIDADELabel.TabIndex = 5;
            qUANTIDADELabel.Text = "Quantidade:";
            // 
            // vALORLabel
            // 
            vALORLabel.AutoSize = true;
            vALORLabel.Location = new System.Drawing.Point(282, 79);
            vALORLabel.Name = "vALORLabel";
            vALORLabel.Size = new System.Drawing.Size(34, 13);
            vALORLabel.TabIndex = 7;
            vALORLabel.Text = "Valor:";
            // 
            // cODMARCA_FKLabel
            // 
            cODMARCA_FKLabel.AutoSize = true;
            cODMARCA_FKLabel.Location = new System.Drawing.Point(511, 43);
            cODMARCA_FKLabel.Name = "cODMARCA_FKLabel";
            cODMARCA_FKLabel.Size = new System.Drawing.Size(87, 13);
            cODMARCA_FKLabel.TabIndex = 9;
            cODMARCA_FKLabel.Text = "CODMARCA FK:";
            // 
            // cODTIPO_FKLabel
            // 
            cODTIPO_FKLabel.AutoSize = true;
            cODTIPO_FKLabel.Location = new System.Drawing.Point(524, 82);
            cODTIPO_FKLabel.Name = "cODTIPO_FKLabel";
            cODTIPO_FKLabel.Size = new System.Drawing.Size(74, 13);
            cODTIPO_FKLabel.TabIndex = 11;
            cODTIPO_FKLabel.Text = "CODTIPO FK:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.ITENSCOMPRAPRODUTOTableAdapter = null;
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
            this.tableAdapterManager.PRODUTOTableAdapter = this.pRODUTOTableAdapter;
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
            // pRODUTOBindingNavigator
            // 
            this.pRODUTOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pRODUTOBindingNavigator.BindingSource = this.pRODUTOBindingSource;
            this.pRODUTOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pRODUTOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pRODUTOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pRODUTOBindingNavigatorSaveItem});
            this.pRODUTOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pRODUTOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pRODUTOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pRODUTOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pRODUTOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pRODUTOBindingNavigator.Name = "pRODUTOBindingNavigator";
            this.pRODUTOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pRODUTOBindingNavigator.Size = new System.Drawing.Size(1278, 25);
            this.pRODUTOBindingNavigator.TabIndex = 0;
            this.pRODUTOBindingNavigator.Text = "bindingNavigator1";
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
            // pRODUTOBindingNavigatorSaveItem
            // 
            this.pRODUTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pRODUTOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pRODUTOBindingNavigatorSaveItem.Image")));
            this.pRODUTOBindingNavigatorSaveItem.Name = "pRODUTOBindingNavigatorSaveItem";
            this.pRODUTOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pRODUTOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pRODUTOBindingNavigatorSaveItem.Click += new System.EventHandler(this.pRODUTOBindingNavigatorSaveItem_Click);
            // 
            // cODPRODUTOLabel1
            // 
            this.cODPRODUTOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOBindingSource, "CODPRODUTO", true));
            this.cODPRODUTOLabel1.Location = new System.Drawing.Point(114, 49);
            this.cODPRODUTOLabel1.Name = "cODPRODUTOLabel1";
            this.cODPRODUTOLabel1.Size = new System.Drawing.Size(121, 23);
            this.cODPRODUTOLabel1.TabIndex = 2;
            this.cODPRODUTOLabel1.Text = "label1";
            // 
            // nOMEPRODUTOTextBox
            // 
            this.nOMEPRODUTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOBindingSource, "NOMEPRODUTO", true));
            this.nOMEPRODUTOTextBox.Location = new System.Drawing.Point(114, 75);
            this.nOMEPRODUTOTextBox.Name = "nOMEPRODUTOTextBox";
            this.nOMEPRODUTOTextBox.Size = new System.Drawing.Size(121, 20);
            this.nOMEPRODUTOTextBox.TabIndex = 4;
            // 
            // qUANTIDADETextBox
            // 
            this.qUANTIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOBindingSource, "QUANTIDADE", true));
            this.qUANTIDADETextBox.Location = new System.Drawing.Point(322, 43);
            this.qUANTIDADETextBox.Name = "qUANTIDADETextBox";
            this.qUANTIDADETextBox.Size = new System.Drawing.Size(159, 20);
            this.qUANTIDADETextBox.TabIndex = 6;
            // 
            // vALORTextBox
            // 
            this.vALORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOBindingSource, "VALOR", true));
            this.vALORTextBox.Location = new System.Drawing.Point(322, 76);
            this.vALORTextBox.Name = "vALORTextBox";
            this.vALORTextBox.Size = new System.Drawing.Size(159, 20);
            this.vALORTextBox.TabIndex = 8;
            // 
            // cODMARCA_FKComboBox
            // 
            this.cODMARCA_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pRODUTOBindingSource, "CODMARCA_FK", true));
            this.cODMARCA_FKComboBox.DataSource = this.mARCABindingSource;
            this.cODMARCA_FKComboBox.DisplayMember = "NOMEMARCA";
            this.cODMARCA_FKComboBox.FormattingEnabled = true;
            this.cODMARCA_FKComboBox.Location = new System.Drawing.Point(598, 40);
            this.cODMARCA_FKComboBox.Name = "cODMARCA_FKComboBox";
            this.cODMARCA_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODMARCA_FKComboBox.TabIndex = 10;
            this.cODMARCA_FKComboBox.ValueMember = "CODMARCA";
            // 
            // cODTIPO_FKComboBox
            // 
            this.cODTIPO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pRODUTOBindingSource, "CODTIPO_FK", true));
            this.cODTIPO_FKComboBox.DataSource = this.tIPOBindingSource;
            this.cODTIPO_FKComboBox.DisplayMember = "NOMETIPO";
            this.cODTIPO_FKComboBox.FormattingEnabled = true;
            this.cODTIPO_FKComboBox.Location = new System.Drawing.Point(598, 79);
            this.cODTIPO_FKComboBox.Name = "cODTIPO_FKComboBox";
            this.cODTIPO_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODTIPO_FKComboBox.TabIndex = 12;
            this.cODTIPO_FKComboBox.ValueMember = "CODTIPO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(729, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(729, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pRODUTODataGridView
            // 
            this.pRODUTODataGridView.AutoGenerateColumns = false;
            this.pRODUTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pRODUTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pRODUTODataGridView.DataSource = this.pRODUTOBindingSource;
            this.pRODUTODataGridView.Location = new System.Drawing.Point(15, 159);
            this.pRODUTODataGridView.Name = "pRODUTODataGridView";
            this.pRODUTODataGridView.ReadOnly = true;
            this.pRODUTODataGridView.Size = new System.Drawing.Size(1251, 220);
            this.pRODUTODataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODPRODUTO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Produto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMEPRODUTO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VALOR";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CODMARCA_FK";
            this.dataGridViewTextBoxColumn5.HeaderText = "Código MarcaFK";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CODTIPO_FK";
            this.dataGridViewTextBoxColumn6.HeaderText = "Código TipoFK";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // mARCABindingSource
            // 
            this.mARCABindingSource.DataMember = "MARCA";
            this.mARCABindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // mARCATableAdapter
            // 
            this.mARCATableAdapter.ClearBeforeFill = true;
            // 
            // tIPOBindingSource
            // 
            this.tIPOBindingSource.DataMember = "TIPO";
            this.tIPOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // tIPOTableAdapter
            // 
            this.tIPOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 414);
            this.Controls.Add(this.pRODUTODataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cODPRODUTOLabel);
            this.Controls.Add(this.cODPRODUTOLabel1);
            this.Controls.Add(nOMEPRODUTOLabel);
            this.Controls.Add(this.nOMEPRODUTOTextBox);
            this.Controls.Add(qUANTIDADELabel);
            this.Controls.Add(this.qUANTIDADETextBox);
            this.Controls.Add(vALORLabel);
            this.Controls.Add(this.vALORTextBox);
            this.Controls.Add(cODMARCA_FKLabel);
            this.Controls.Add(this.cODMARCA_FKComboBox);
            this.Controls.Add(cODTIPO_FKLabel);
            this.Controls.Add(this.cODTIPO_FKComboBox);
            this.Controls.Add(this.pRODUTOBindingNavigator);
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingNavigator)).EndInit();
            this.pRODUTOBindingNavigator.ResumeLayout(false);
            this.pRODUTOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource pRODUTOBindingSource;
        private ATIVIDADEDataSetTableAdapters.PRODUTOTableAdapter pRODUTOTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pRODUTOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pRODUTOBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODPRODUTOLabel1;
        private System.Windows.Forms.TextBox nOMEPRODUTOTextBox;
        private System.Windows.Forms.TextBox qUANTIDADETextBox;
        private System.Windows.Forms.TextBox vALORTextBox;
        private System.Windows.Forms.ComboBox cODMARCA_FKComboBox;
        private System.Windows.Forms.ComboBox cODTIPO_FKComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView pRODUTODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource mARCABindingSource;
        private ATIVIDADEDataSetTableAdapters.MARCATableAdapter mARCATableAdapter;
        private System.Windows.Forms.BindingSource tIPOBindingSource;
        private ATIVIDADEDataSetTableAdapters.TIPOTableAdapter tIPOTableAdapter;
    }
}