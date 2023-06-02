namespace ProjetoBancoDAD
{
    partial class FrmVendaProduto
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
            System.Windows.Forms.Label cODVENDALabel;
            System.Windows.Forms.Label dATAVENDALabel;
            System.Windows.Forms.Label cODCLIENTE_FKLabel;
            System.Windows.Forms.Label cODFUNCIONARIO_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendaProduto));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.vENDAPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENDAPRODUTOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.VENDAPRODUTOTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.vENDAPRODUTOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vENDAPRODUTOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODVENDALabel1 = new System.Windows.Forms.Label();
            this.dATAVENDADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cODCLIENTE_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cODFUNCIONARIO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vENDAPRODUTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.CLIENTETableAdapter();
            this.fUNCIONARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCIONARIOSTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.FUNCIONARIOSTableAdapter();
            cODVENDALabel = new System.Windows.Forms.Label();
            dATAVENDALabel = new System.Windows.Forms.Label();
            cODCLIENTE_FKLabel = new System.Windows.Forms.Label();
            cODFUNCIONARIO_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTOBindingNavigator)).BeginInit();
            this.vENDAPRODUTOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODVENDALabel
            // 
            cODVENDALabel.AutoSize = true;
            cODVENDALabel.Location = new System.Drawing.Point(12, 49);
            cODVENDALabel.Name = "cODVENDALabel";
            cODVENDALabel.Size = new System.Drawing.Size(77, 13);
            cODVENDALabel.TabIndex = 1;
            cODVENDALabel.Text = "Código Venda:";
            // 
            // dATAVENDALabel
            // 
            dATAVENDALabel.AutoSize = true;
            dATAVENDALabel.Location = new System.Drawing.Point(12, 79);
            dATAVENDALabel.Name = "dATAVENDALabel";
            dATAVENDALabel.Size = new System.Drawing.Size(67, 13);
            dATAVENDALabel.TabIndex = 3;
            dATAVENDALabel.Text = "Data Venda:";
            // 
            // cODCLIENTE_FKLabel
            // 
            cODCLIENTE_FKLabel.AutoSize = true;
            cODCLIENTE_FKLabel.Location = new System.Drawing.Point(511, 49);
            cODCLIENTE_FKLabel.Name = "cODCLIENTE_FKLabel";
            cODCLIENTE_FKLabel.Size = new System.Drawing.Size(94, 13);
            cODCLIENTE_FKLabel.TabIndex = 5;
            cODCLIENTE_FKLabel.Text = "CODCLIENTE FK:";
            // 
            // cODFUNCIONARIO_FKLabel
            // 
            cODFUNCIONARIO_FKLabel.AutoSize = true;
            cODFUNCIONARIO_FKLabel.Location = new System.Drawing.Point(482, 82);
            cODFUNCIONARIO_FKLabel.Name = "cODFUNCIONARIO_FKLabel";
            cODFUNCIONARIO_FKLabel.Size = new System.Drawing.Size(123, 13);
            cODFUNCIONARIO_FKLabel.TabIndex = 7;
            cODFUNCIONARIO_FKLabel.Text = "CODFUNCIONARIO FK:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENDAPRODUTOBindingSource
            // 
            this.vENDAPRODUTOBindingSource.DataMember = "VENDAPRODUTO";
            this.vENDAPRODUTOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // vENDAPRODUTOTableAdapter
            // 
            this.vENDAPRODUTOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PRODUTOTableAdapter = null;
            this.tableAdapterManager.RUATableAdapter = null;
            this.tableAdapterManager.SEXOTableAdapter = null;
            this.tableAdapterManager.SITUACAOTableAdapter = null;
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = this.vENDAPRODUTOTableAdapter;
            // 
            // vENDAPRODUTOBindingNavigator
            // 
            this.vENDAPRODUTOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vENDAPRODUTOBindingNavigator.BindingSource = this.vENDAPRODUTOBindingSource;
            this.vENDAPRODUTOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vENDAPRODUTOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vENDAPRODUTOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vENDAPRODUTOBindingNavigatorSaveItem});
            this.vENDAPRODUTOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vENDAPRODUTOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vENDAPRODUTOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vENDAPRODUTOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vENDAPRODUTOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vENDAPRODUTOBindingNavigator.Name = "vENDAPRODUTOBindingNavigator";
            this.vENDAPRODUTOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vENDAPRODUTOBindingNavigator.Size = new System.Drawing.Size(876, 25);
            this.vENDAPRODUTOBindingNavigator.TabIndex = 0;
            this.vENDAPRODUTOBindingNavigator.Text = "+";
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
            // vENDAPRODUTOBindingNavigatorSaveItem
            // 
            this.vENDAPRODUTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vENDAPRODUTOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vENDAPRODUTOBindingNavigatorSaveItem.Image")));
            this.vENDAPRODUTOBindingNavigatorSaveItem.Name = "vENDAPRODUTOBindingNavigatorSaveItem";
            this.vENDAPRODUTOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vENDAPRODUTOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.vENDAPRODUTOBindingNavigatorSaveItem.Click += new System.EventHandler(this.vENDAPRODUTOBindingNavigatorSaveItem_Click);
            // 
            // cODVENDALabel1
            // 
            this.cODVENDALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDAPRODUTOBindingSource, "CODVENDA", true));
            this.cODVENDALabel1.Location = new System.Drawing.Point(95, 49);
            this.cODVENDALabel1.Name = "cODVENDALabel1";
            this.cODVENDALabel1.Size = new System.Drawing.Size(200, 23);
            this.cODVENDALabel1.TabIndex = 2;
            this.cODVENDALabel1.Text = "label1";
            // 
            // dATAVENDADateTimePicker
            // 
            this.dATAVENDADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vENDAPRODUTOBindingSource, "DATAVENDA", true));
            this.dATAVENDADateTimePicker.Location = new System.Drawing.Point(85, 76);
            this.dATAVENDADateTimePicker.Name = "dATAVENDADateTimePicker";
            this.dATAVENDADateTimePicker.Size = new System.Drawing.Size(210, 20);
            this.dATAVENDADateTimePicker.TabIndex = 4;
            // 
            // cODCLIENTE_FKComboBox
            // 
            this.cODCLIENTE_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vENDAPRODUTOBindingSource, "CODCLIENTE_FK", true));
            this.cODCLIENTE_FKComboBox.DataSource = this.cLIENTEBindingSource;
            this.cODCLIENTE_FKComboBox.DisplayMember = "NOMECLIENTE";
            this.cODCLIENTE_FKComboBox.FormattingEnabled = true;
            this.cODCLIENTE_FKComboBox.Location = new System.Drawing.Point(611, 44);
            this.cODCLIENTE_FKComboBox.Name = "cODCLIENTE_FKComboBox";
            this.cODCLIENTE_FKComboBox.Size = new System.Drawing.Size(200, 21);
            this.cODCLIENTE_FKComboBox.TabIndex = 6;
            this.cODCLIENTE_FKComboBox.ValueMember = "CODCLIENTE";
            // 
            // cODFUNCIONARIO_FKComboBox
            // 
            this.cODFUNCIONARIO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vENDAPRODUTOBindingSource, "CODFUNCIONARIO_FK", true));
            this.cODFUNCIONARIO_FKComboBox.DataSource = this.fUNCIONARIOSBindingSource;
            this.cODFUNCIONARIO_FKComboBox.DisplayMember = "NOMEFUNCIONARIO";
            this.cODFUNCIONARIO_FKComboBox.FormattingEnabled = true;
            this.cODFUNCIONARIO_FKComboBox.Location = new System.Drawing.Point(611, 79);
            this.cODFUNCIONARIO_FKComboBox.Name = "cODFUNCIONARIO_FKComboBox";
            this.cODFUNCIONARIO_FKComboBox.Size = new System.Drawing.Size(200, 21);
            this.cODFUNCIONARIO_FKComboBox.TabIndex = 8;
            this.cODFUNCIONARIO_FKComboBox.ValueMember = "CODFUNCIONARIOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(817, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vENDAPRODUTODataGridView
            // 
            this.vENDAPRODUTODataGridView.AutoGenerateColumns = false;
            this.vENDAPRODUTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vENDAPRODUTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.vENDAPRODUTODataGridView.DataSource = this.vENDAPRODUTOBindingSource;
            this.vENDAPRODUTODataGridView.Location = new System.Drawing.Point(15, 117);
            this.vENDAPRODUTODataGridView.Name = "vENDAPRODUTODataGridView";
            this.vENDAPRODUTODataGridView.ReadOnly = true;
            this.vENDAPRODUTODataGridView.Size = new System.Drawing.Size(856, 220);
            this.vENDAPRODUTODataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODVENDA";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Venda:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DATAVENDA";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data Venda:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CODCLIENTE_FK";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código ClienteFK:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CODFUNCIONARIO_FK";
            this.dataGridViewTextBoxColumn4.HeaderText = "Código FuncionárioFK:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
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
            // FrmVendaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 368);
            this.Controls.Add(this.vENDAPRODUTODataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cODVENDALabel);
            this.Controls.Add(this.cODVENDALabel1);
            this.Controls.Add(dATAVENDALabel);
            this.Controls.Add(this.dATAVENDADateTimePicker);
            this.Controls.Add(cODCLIENTE_FKLabel);
            this.Controls.Add(this.cODCLIENTE_FKComboBox);
            this.Controls.Add(cODFUNCIONARIO_FKLabel);
            this.Controls.Add(this.cODFUNCIONARIO_FKComboBox);
            this.Controls.Add(this.vENDAPRODUTOBindingNavigator);
            this.Name = "FrmVendaProduto";
            this.Text = "FrmVendaProduto";
            this.Load += new System.EventHandler(this.FrmVendaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTOBindingNavigator)).EndInit();
            this.vENDAPRODUTOBindingNavigator.ResumeLayout(false);
            this.vENDAPRODUTOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource vENDAPRODUTOBindingSource;
        private ATIVIDADEDataSetTableAdapters.VENDAPRODUTOTableAdapter vENDAPRODUTOTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vENDAPRODUTOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vENDAPRODUTOBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODVENDALabel1;
        private System.Windows.Forms.DateTimePicker dATAVENDADateTimePicker;
        private System.Windows.Forms.ComboBox cODCLIENTE_FKComboBox;
        private System.Windows.Forms.ComboBox cODFUNCIONARIO_FKComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView vENDAPRODUTODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private ATIVIDADEDataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.BindingSource fUNCIONARIOSBindingSource;
        private ATIVIDADEDataSetTableAdapters.FUNCIONARIOSTableAdapter fUNCIONARIOSTableAdapter;
    }
}