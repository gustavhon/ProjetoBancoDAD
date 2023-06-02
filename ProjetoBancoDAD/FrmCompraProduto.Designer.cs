namespace ProjetoBancoDAD
{
    partial class FrmCompraProduto
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
            System.Windows.Forms.Label cODCOMPRALabel;
            System.Windows.Forms.Label dATACOMPRALabel;
            System.Windows.Forms.Label cODFORNECEDOR_FKLabel;
            System.Windows.Forms.Label cODFUNCIONARIO_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompraProduto));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.cOMPRAPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPRAPRODUTOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.COMPRAPRODUTOTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.cOMPRAPRODUTOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cOMPRAPRODUTOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODCOMPRALabel1 = new System.Windows.Forms.Label();
            this.dATACOMPRADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cODFORNECEDOR_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cODFUNCIONARIO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cOMPRAPRODUTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORNECEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fORNECEDORTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.FORNECEDORTableAdapter();
            this.fUNCIONARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCIONARIOSTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.FUNCIONARIOSTableAdapter();
            cODCOMPRALabel = new System.Windows.Forms.Label();
            dATACOMPRALabel = new System.Windows.Forms.Label();
            cODFORNECEDOR_FKLabel = new System.Windows.Forms.Label();
            cODFUNCIONARIO_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingNavigator)).BeginInit();
            this.cOMPRAPRODUTOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODCOMPRALabel
            // 
            cODCOMPRALabel.AutoSize = true;
            cODCOMPRALabel.Location = new System.Drawing.Point(74, 35);
            cODCOMPRALabel.Name = "cODCOMPRALabel";
            cODCOMPRALabel.Size = new System.Drawing.Size(82, 13);
            cODCOMPRALabel.TabIndex = 1;
            cODCOMPRALabel.Text = "Código Compra:";
            // 
            // dATACOMPRALabel
            // 
            dATACOMPRALabel.AutoSize = true;
            dATACOMPRALabel.Location = new System.Drawing.Point(84, 72);
            dATACOMPRALabel.Name = "dATACOMPRALabel";
            dATACOMPRALabel.Size = new System.Drawing.Size(72, 13);
            dATACOMPRALabel.TabIndex = 3;
            dATACOMPRALabel.Text = "Data Compra:";
            // 
            // cODFORNECEDOR_FKLabel
            // 
            cODFORNECEDOR_FKLabel.AutoSize = true;
            cODFORNECEDOR_FKLabel.Location = new System.Drawing.Point(43, 116);
            cODFORNECEDOR_FKLabel.Name = "cODFORNECEDOR_FKLabel";
            cODFORNECEDOR_FKLabel.Size = new System.Drawing.Size(113, 13);
            cODFORNECEDOR_FKLabel.TabIndex = 5;
            cODFORNECEDOR_FKLabel.Text = "Código FornecedorFK:";
            // 
            // cODFUNCIONARIO_FKLabel
            // 
            cODFUNCIONARIO_FKLabel.AutoSize = true;
            cODFUNCIONARIO_FKLabel.Location = new System.Drawing.Point(428, 115);
            cODFUNCIONARIO_FKLabel.Name = "cODFUNCIONARIO_FKLabel";
            cODFUNCIONARIO_FKLabel.Size = new System.Drawing.Size(114, 13);
            cODFUNCIONARIO_FKLabel.TabIndex = 7;
            cODFUNCIONARIO_FKLabel.Text = "Código FuncionárioFK:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAIRROTableAdapter = null;
            this.tableAdapterManager.CEPTableAdapter = null;
            this.tableAdapterManager.CIDADETableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.COMPRAPRODUTOTableAdapter = this.cOMPRAPRODUTOTableAdapter;
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
            // cOMPRAPRODUTOBindingNavigator
            // 
            this.cOMPRAPRODUTOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cOMPRAPRODUTOBindingNavigator.BindingSource = this.cOMPRAPRODUTOBindingSource;
            this.cOMPRAPRODUTOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cOMPRAPRODUTOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cOMPRAPRODUTOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cOMPRAPRODUTOBindingNavigatorSaveItem});
            this.cOMPRAPRODUTOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cOMPRAPRODUTOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cOMPRAPRODUTOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cOMPRAPRODUTOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cOMPRAPRODUTOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cOMPRAPRODUTOBindingNavigator.Name = "cOMPRAPRODUTOBindingNavigator";
            this.cOMPRAPRODUTOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cOMPRAPRODUTOBindingNavigator.Size = new System.Drawing.Size(1039, 25);
            this.cOMPRAPRODUTOBindingNavigator.TabIndex = 0;
            this.cOMPRAPRODUTOBindingNavigator.Text = "bindingNavigator1";
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
            // cOMPRAPRODUTOBindingNavigatorSaveItem
            // 
            this.cOMPRAPRODUTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cOMPRAPRODUTOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cOMPRAPRODUTOBindingNavigatorSaveItem.Image")));
            this.cOMPRAPRODUTOBindingNavigatorSaveItem.Name = "cOMPRAPRODUTOBindingNavigatorSaveItem";
            this.cOMPRAPRODUTOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cOMPRAPRODUTOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cOMPRAPRODUTOBindingNavigatorSaveItem.Click += new System.EventHandler(this.cOMPRAPRODUTOBindingNavigatorSaveItem_Click);
            // 
            // cODCOMPRALabel1
            // 
            this.cODCOMPRALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPRAPRODUTOBindingSource, "CODCOMPRA", true));
            this.cODCOMPRALabel1.Location = new System.Drawing.Point(162, 35);
            this.cODCOMPRALabel1.Name = "cODCOMPRALabel1";
            this.cODCOMPRALabel1.Size = new System.Drawing.Size(200, 23);
            this.cODCOMPRALabel1.TabIndex = 2;
            this.cODCOMPRALabel1.Text = "label1";
            // 
            // dATACOMPRADateTimePicker
            // 
            this.dATACOMPRADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cOMPRAPRODUTOBindingSource, "DATACOMPRA", true));
            this.dATACOMPRADateTimePicker.Location = new System.Drawing.Point(162, 72);
            this.dATACOMPRADateTimePicker.Name = "dATACOMPRADateTimePicker";
            this.dATACOMPRADateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dATACOMPRADateTimePicker.TabIndex = 4;
            // 
            // cODFORNECEDOR_FKComboBox
            // 
            this.cODFORNECEDOR_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cOMPRAPRODUTOBindingSource, "CODFORNECEDOR_FK", true));
            this.cODFORNECEDOR_FKComboBox.DataSource = this.fORNECEDORBindingSource;
            this.cODFORNECEDOR_FKComboBox.DisplayMember = "NOMEFORNECEDOR";
            this.cODFORNECEDOR_FKComboBox.FormattingEnabled = true;
            this.cODFORNECEDOR_FKComboBox.Location = new System.Drawing.Point(162, 111);
            this.cODFORNECEDOR_FKComboBox.Name = "cODFORNECEDOR_FKComboBox";
            this.cODFORNECEDOR_FKComboBox.Size = new System.Drawing.Size(200, 21);
            this.cODFORNECEDOR_FKComboBox.TabIndex = 6;
            this.cODFORNECEDOR_FKComboBox.ValueMember = "CODFORNECEDOR";
            // 
            // cODFUNCIONARIO_FKComboBox
            // 
            this.cODFUNCIONARIO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cOMPRAPRODUTOBindingSource, "CODFUNCIONARIO_FK", true));
            this.cODFUNCIONARIO_FKComboBox.DataSource = this.fUNCIONARIOSBindingSource;
            this.cODFUNCIONARIO_FKComboBox.DisplayMember = "NOMEFUNCIONARIO";
            this.cODFUNCIONARIO_FKComboBox.FormattingEnabled = true;
            this.cODFUNCIONARIO_FKComboBox.Location = new System.Drawing.Point(548, 112);
            this.cODFUNCIONARIO_FKComboBox.Name = "cODFUNCIONARIO_FKComboBox";
            this.cODFUNCIONARIO_FKComboBox.Size = new System.Drawing.Size(200, 21);
            this.cODFUNCIONARIO_FKComboBox.TabIndex = 8;
            this.cODFUNCIONARIO_FKComboBox.ValueMember = "CODFUNCIONARIOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(754, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cOMPRAPRODUTODataGridView
            // 
            this.cOMPRAPRODUTODataGridView.AutoGenerateColumns = false;
            this.cOMPRAPRODUTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cOMPRAPRODUTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cOMPRAPRODUTODataGridView.DataSource = this.cOMPRAPRODUTOBindingSource;
            this.cOMPRAPRODUTODataGridView.Location = new System.Drawing.Point(12, 154);
            this.cOMPRAPRODUTODataGridView.Name = "cOMPRAPRODUTODataGridView";
            this.cOMPRAPRODUTODataGridView.ReadOnly = true;
            this.cOMPRAPRODUTODataGridView.Size = new System.Drawing.Size(844, 220);
            this.cOMPRAPRODUTODataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODCOMPRA";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Compra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DATACOMPRA";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data Compra";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CODFORNECEDOR_FK";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código FornecedorFK";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CODFUNCIONARIO_FK";
            this.dataGridViewTextBoxColumn4.HeaderText = "Código FuncionárioFK";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // fORNECEDORBindingSource
            // 
            this.fORNECEDORBindingSource.DataMember = "FORNECEDOR";
            this.fORNECEDORBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // fORNECEDORTableAdapter
            // 
            this.fORNECEDORTableAdapter.ClearBeforeFill = true;
            // 
            // fUNCIONARIOSBindingSource
            // 
            this.fUNCIONARIOSBindingSource.DataMember = "FUNCIONARIOS";
            this.fUNCIONARIOSBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // fUNCIONARIOSTableAdapter
            // 
            this.fUNCIONARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCompraProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 391);
            this.Controls.Add(this.cOMPRAPRODUTODataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cODCOMPRALabel);
            this.Controls.Add(this.cODCOMPRALabel1);
            this.Controls.Add(dATACOMPRALabel);
            this.Controls.Add(this.dATACOMPRADateTimePicker);
            this.Controls.Add(cODFORNECEDOR_FKLabel);
            this.Controls.Add(this.cODFORNECEDOR_FKComboBox);
            this.Controls.Add(cODFUNCIONARIO_FKLabel);
            this.Controls.Add(this.cODFUNCIONARIO_FKComboBox);
            this.Controls.Add(this.cOMPRAPRODUTOBindingNavigator);
            this.Name = "FrmCompraProduto";
            this.Text = "FrmCompraProduto";
            this.Load += new System.EventHandler(this.FrmCompraProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingNavigator)).EndInit();
            this.cOMPRAPRODUTOBindingNavigator.ResumeLayout(false);
            this.cOMPRAPRODUTOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource cOMPRAPRODUTOBindingSource;
        private ATIVIDADEDataSetTableAdapters.COMPRAPRODUTOTableAdapter cOMPRAPRODUTOTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cOMPRAPRODUTOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cOMPRAPRODUTOBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODCOMPRALabel1;
        private System.Windows.Forms.DateTimePicker dATACOMPRADateTimePicker;
        private System.Windows.Forms.ComboBox cODFORNECEDOR_FKComboBox;
        private System.Windows.Forms.ComboBox cODFUNCIONARIO_FKComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView cOMPRAPRODUTODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource fORNECEDORBindingSource;
        private ATIVIDADEDataSetTableAdapters.FORNECEDORTableAdapter fORNECEDORTableAdapter;
        private System.Windows.Forms.BindingSource fUNCIONARIOSBindingSource;
        private ATIVIDADEDataSetTableAdapters.FUNCIONARIOSTableAdapter fUNCIONARIOSTableAdapter;
    }
}