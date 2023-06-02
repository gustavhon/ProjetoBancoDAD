namespace ProjetoBancoDAD
{
    partial class FrmFornecedor
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
            System.Windows.Forms.Label cODFORNECEDORLabel;
            System.Windows.Forms.Label nOMEFORNECEDORLabel;
            System.Windows.Forms.Label cODRUALabel;
            System.Windows.Forms.Label cODBAIRROLabel;
            System.Windows.Forms.Label cODCEPLabel;
            System.Windows.Forms.Label cODCIDADELabel;
            System.Windows.Forms.Label nUMEROCASALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecedor));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.fORNECEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fORNECEDORTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.FORNECEDORTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.fORNECEDORBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fORNECEDORBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODFORNECEDORLabel1 = new System.Windows.Forms.Label();
            this.nOMEFORNECEDORTextBox = new System.Windows.Forms.TextBox();
            this.cODRUAComboBox = new System.Windows.Forms.ComboBox();
            this.cODBAIRROComboBox = new System.Windows.Forms.ComboBox();
            this.cODCEPComboBox = new System.Windows.Forms.ComboBox();
            this.cODCIDADEComboBox = new System.Windows.Forms.ComboBox();
            this.fORNECEDORDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.nUMEROCASATextBox = new System.Windows.Forms.TextBox();
            this.rUABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rUATableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.RUATableAdapter();
            this.bAIRROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAIRROTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.BAIRROTableAdapter();
            cODFORNECEDORLabel = new System.Windows.Forms.Label();
            nOMEFORNECEDORLabel = new System.Windows.Forms.Label();
            cODRUALabel = new System.Windows.Forms.Label();
            cODBAIRROLabel = new System.Windows.Forms.Label();
            cODCEPLabel = new System.Windows.Forms.Label();
            cODCIDADELabel = new System.Windows.Forms.Label();
            nUMEROCASALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingNavigator)).BeginInit();
            this.fORNECEDORBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRROBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODFORNECEDORLabel
            // 
            cODFORNECEDORLabel.AutoSize = true;
            cODFORNECEDORLabel.Location = new System.Drawing.Point(12, 49);
            cODFORNECEDORLabel.Name = "cODFORNECEDORLabel";
            cODFORNECEDORLabel.Size = new System.Drawing.Size(100, 13);
            cODFORNECEDORLabel.TabIndex = 1;
            cODFORNECEDORLabel.Text = "Código Fornecedor:";
            // 
            // nOMEFORNECEDORLabel
            // 
            nOMEFORNECEDORLabel.AutoSize = true;
            nOMEFORNECEDORLabel.Location = new System.Drawing.Point(12, 75);
            nOMEFORNECEDORLabel.Name = "nOMEFORNECEDORLabel";
            nOMEFORNECEDORLabel.Size = new System.Drawing.Size(95, 13);
            nOMEFORNECEDORLabel.TabIndex = 3;
            nOMEFORNECEDORLabel.Text = "Nome Fornecedor:";
            // 
            // cODRUALabel
            // 
            cODRUALabel.AutoSize = true;
            cODRUALabel.Location = new System.Drawing.Point(310, 72);
            cODRUALabel.Name = "cODRUALabel";
            cODRUALabel.Size = new System.Drawing.Size(79, 13);
            cODRUALabel.TabIndex = 7;
            cODRUALabel.Text = "Código RuaFK:";
            // 
            // cODBAIRROLabel
            // 
            cODBAIRROLabel.AutoSize = true;
            cODBAIRROLabel.Location = new System.Drawing.Point(303, 111);
            cODBAIRROLabel.Name = "cODBAIRROLabel";
            cODBAIRROLabel.Size = new System.Drawing.Size(86, 13);
            cODBAIRROLabel.TabIndex = 9;
            cODBAIRROLabel.Text = "Código BairroFK:";
            // 
            // cODCEPLabel
            // 
            cODCEPLabel.AutoSize = true;
            cODCEPLabel.Location = new System.Drawing.Point(753, 70);
            cODCEPLabel.Name = "cODCEPLabel";
            cODCEPLabel.Size = new System.Drawing.Size(78, 13);
            cODCEPLabel.TabIndex = 11;
            cODCEPLabel.Text = "Código CepFK:";
            // 
            // cODCIDADELabel
            // 
            cODCIDADELabel.AutoSize = true;
            cODCIDADELabel.Location = new System.Drawing.Point(741, 113);
            cODCIDADELabel.Name = "cODCIDADELabel";
            cODCIDADELabel.Size = new System.Drawing.Size(92, 13);
            cODCIDADELabel.TabIndex = 13;
            cODCIDADELabel.Text = "Código CidadeFK:";
            // 
            // nUMEROCASALabel
            // 
            nUMEROCASALabel.AutoSize = true;
            nUMEROCASALabel.Location = new System.Drawing.Point(33, 118);
            nUMEROCASALabel.Name = "nUMEROCASALabel";
            nUMEROCASALabel.Size = new System.Drawing.Size(74, 13);
            nUMEROCASALabel.TabIndex = 19;
            nUMEROCASALabel.Text = "Número Casa:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.FORNECEDORTableAdapter = this.fORNECEDORTableAdapter;
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
            // fORNECEDORBindingNavigator
            // 
            this.fORNECEDORBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fORNECEDORBindingNavigator.BindingSource = this.fORNECEDORBindingSource;
            this.fORNECEDORBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fORNECEDORBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fORNECEDORBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fORNECEDORBindingNavigatorSaveItem});
            this.fORNECEDORBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fORNECEDORBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fORNECEDORBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fORNECEDORBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fORNECEDORBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fORNECEDORBindingNavigator.Name = "fORNECEDORBindingNavigator";
            this.fORNECEDORBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fORNECEDORBindingNavigator.Size = new System.Drawing.Size(1370, 25);
            this.fORNECEDORBindingNavigator.TabIndex = 0;
            this.fORNECEDORBindingNavigator.Text = "bindingNavigator1";
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
            // fORNECEDORBindingNavigatorSaveItem
            // 
            this.fORNECEDORBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fORNECEDORBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fORNECEDORBindingNavigatorSaveItem.Image")));
            this.fORNECEDORBindingNavigatorSaveItem.Name = "fORNECEDORBindingNavigatorSaveItem";
            this.fORNECEDORBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fORNECEDORBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.fORNECEDORBindingNavigatorSaveItem.Click += new System.EventHandler(this.fORNECEDORBindingNavigatorSaveItem_Click);
            // 
            // cODFORNECEDORLabel1
            // 
            this.cODFORNECEDORLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORBindingSource, "CODFORNECEDOR", true));
            this.cODFORNECEDORLabel1.Location = new System.Drawing.Point(118, 46);
            this.cODFORNECEDORLabel1.Name = "cODFORNECEDORLabel1";
            this.cODFORNECEDORLabel1.Size = new System.Drawing.Size(121, 23);
            this.cODFORNECEDORLabel1.TabIndex = 2;
            this.cODFORNECEDORLabel1.Text = "label1";
            // 
            // nOMEFORNECEDORTextBox
            // 
            this.nOMEFORNECEDORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORBindingSource, "NOMEFORNECEDOR", true));
            this.nOMEFORNECEDORTextBox.Location = new System.Drawing.Point(113, 72);
            this.nOMEFORNECEDORTextBox.Name = "nOMEFORNECEDORTextBox";
            this.nOMEFORNECEDORTextBox.Size = new System.Drawing.Size(169, 20);
            this.nOMEFORNECEDORTextBox.TabIndex = 4;
            // 
            // cODRUAComboBox
            // 
            this.cODRUAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fORNECEDORBindingSource, "CODRUA", true));
            this.cODRUAComboBox.DataSource = this.rUABindingSource;
            this.cODRUAComboBox.DisplayMember = "NOMERUA";
            this.cODRUAComboBox.FormattingEnabled = true;
            this.cODRUAComboBox.Location = new System.Drawing.Point(390, 67);
            this.cODRUAComboBox.Name = "cODRUAComboBox";
            this.cODRUAComboBox.Size = new System.Drawing.Size(218, 21);
            this.cODRUAComboBox.TabIndex = 8;
            this.cODRUAComboBox.ValueMember = "CODRUA";
            // 
            // cODBAIRROComboBox
            // 
            this.cODBAIRROComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fORNECEDORBindingSource, "CODBAIRRO", true));
            this.cODBAIRROComboBox.DataSource = this.bAIRROBindingSource;
            this.cODBAIRROComboBox.DisplayMember = "NOMEBAIRRO";
            this.cODBAIRROComboBox.FormattingEnabled = true;
            this.cODBAIRROComboBox.Location = new System.Drawing.Point(390, 106);
            this.cODBAIRROComboBox.Name = "cODBAIRROComboBox";
            this.cODBAIRROComboBox.Size = new System.Drawing.Size(218, 21);
            this.cODBAIRROComboBox.TabIndex = 10;
            this.cODBAIRROComboBox.ValueMember = "CODBAIRRO";
            // 
            // cODCEPComboBox
            // 
            this.cODCEPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORBindingSource, "CODCEP", true));
            this.cODCEPComboBox.FormattingEnabled = true;
            this.cODCEPComboBox.Location = new System.Drawing.Point(837, 67);
            this.cODCEPComboBox.Name = "cODCEPComboBox";
            this.cODCEPComboBox.Size = new System.Drawing.Size(268, 21);
            this.cODCEPComboBox.TabIndex = 12;
            // 
            // cODCIDADEComboBox
            // 
            this.cODCIDADEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORBindingSource, "CODCIDADE", true));
            this.cODCIDADEComboBox.FormattingEnabled = true;
            this.cODCIDADEComboBox.Location = new System.Drawing.Point(839, 108);
            this.cODCIDADEComboBox.Name = "cODCIDADEComboBox";
            this.cODCIDADEComboBox.Size = new System.Drawing.Size(268, 21);
            this.cODCIDADEComboBox.TabIndex = 14;
            // 
            // fORNECEDORDataGridView
            // 
            this.fORNECEDORDataGridView.AutoGenerateColumns = false;
            this.fORNECEDORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fORNECEDORDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.fORNECEDORDataGridView.DataSource = this.fORNECEDORBindingSource;
            this.fORNECEDORDataGridView.Location = new System.Drawing.Point(0, 182);
            this.fORNECEDORDataGridView.Name = "fORNECEDORDataGridView";
            this.fORNECEDORDataGridView.ReadOnly = true;
            this.fORNECEDORDataGridView.Size = new System.Drawing.Size(1446, 220);
            this.fORNECEDORDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODFORNECEDOR";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Fornecedor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMEFORNECEDOR";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Fornecedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NUMEROCASA";
            this.dataGridViewTextBoxColumn3.HeaderText = "Número Casa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CODRUA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Código RuaFK";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CODBAIRRO";
            this.dataGridViewTextBoxColumn5.HeaderText = "Código BairroFK";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CODCEP";
            this.dataGridViewTextBoxColumn6.HeaderText = "Código CepFK";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CODCIDADE";
            this.dataGridViewTextBoxColumn7.HeaderText = "Código CidadeFK";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1111, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1111, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // nUMEROCASATextBox
            // 
            this.nUMEROCASATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORBindingSource, "NUMEROCASA", true));
            this.nUMEROCASATextBox.Location = new System.Drawing.Point(113, 115);
            this.nUMEROCASATextBox.Name = "nUMEROCASATextBox";
            this.nUMEROCASATextBox.Size = new System.Drawing.Size(169, 20);
            this.nUMEROCASATextBox.TabIndex = 20;
            // 
            // rUABindingSource
            // 
            this.rUABindingSource.DataMember = "RUA";
            this.rUABindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // rUATableAdapter
            // 
            this.rUATableAdapter.ClearBeforeFill = true;
            // 
            // bAIRROBindingSource
            // 
            this.bAIRROBindingSource.DataMember = "BAIRRO";
            this.bAIRROBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // bAIRROTableAdapter
            // 
            this.bAIRROTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 429);
            this.Controls.Add(nUMEROCASALabel);
            this.Controls.Add(this.nUMEROCASATextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fORNECEDORDataGridView);
            this.Controls.Add(cODFORNECEDORLabel);
            this.Controls.Add(this.cODFORNECEDORLabel1);
            this.Controls.Add(nOMEFORNECEDORLabel);
            this.Controls.Add(this.nOMEFORNECEDORTextBox);
            this.Controls.Add(cODRUALabel);
            this.Controls.Add(this.cODRUAComboBox);
            this.Controls.Add(cODBAIRROLabel);
            this.Controls.Add(this.cODBAIRROComboBox);
            this.Controls.Add(cODCEPLabel);
            this.Controls.Add(this.cODCEPComboBox);
            this.Controls.Add(cODCIDADELabel);
            this.Controls.Add(this.cODCIDADEComboBox);
            this.Controls.Add(this.fORNECEDORBindingNavigator);
            this.Name = "FrmFornecedor";
            this.Text = "FrmFornecedor";
            this.Load += new System.EventHandler(this.FrmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingNavigator)).EndInit();
            this.fORNECEDORBindingNavigator.ResumeLayout(false);
            this.fORNECEDORBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRROBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource fORNECEDORBindingSource;
        private ATIVIDADEDataSetTableAdapters.FORNECEDORTableAdapter fORNECEDORTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fORNECEDORBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fORNECEDORBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODFORNECEDORLabel1;
        private System.Windows.Forms.TextBox nOMEFORNECEDORTextBox;
        private System.Windows.Forms.ComboBox cODRUAComboBox;
        private System.Windows.Forms.ComboBox cODBAIRROComboBox;
        private System.Windows.Forms.ComboBox cODCEPComboBox;
        private System.Windows.Forms.ComboBox cODCIDADEComboBox;
        private System.Windows.Forms.DataGridView fORNECEDORDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox nUMEROCASATextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource rUABindingSource;
        private ATIVIDADEDataSetTableAdapters.RUATableAdapter rUATableAdapter;
        private System.Windows.Forms.BindingSource bAIRROBindingSource;
        private ATIVIDADEDataSetTableAdapters.BAIRROTableAdapter bAIRROTableAdapter;
    }
}