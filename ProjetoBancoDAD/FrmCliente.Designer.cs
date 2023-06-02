namespace ProjetoBancoDAD
{
    partial class FrmCliente
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
            System.Windows.Forms.Label cODCLIENTELabel;
            System.Windows.Forms.Label nOMECLIENTELabel;
            System.Windows.Forms.Label fOTOLabel;
            System.Windows.Forms.Label cODSEXO_FKLabel;
            System.Windows.Forms.Label cODRUA_FKLabel;
            System.Windows.Forms.Label cODBAIRRO_FKLabel;
            System.Windows.Forms.Label cODCEP_FKLabel;
            System.Windows.Forms.Label sALARIOLabel;
            System.Windows.Forms.Label cODTRABALHO_FKLabel;
            System.Windows.Forms.Label nUMEROCASALabel;
            System.Windows.Forms.Label dATANASCLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.CLIENTETableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.cLIENTEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cLIENTEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODCLIENTELabel1 = new System.Windows.Forms.Label();
            this.nOMECLIENTETextBox = new System.Windows.Forms.TextBox();
            this.cODSEXO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cODRUA_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cODBAIRRO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cODCEP_FKComboBox = new System.Windows.Forms.ComboBox();
            this.sALARIOTextBox = new System.Windows.Forms.TextBox();
            this.cODTRABALHO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cLIENTEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.nUMEROCASATextBox = new System.Windows.Forms.TextBox();
            this.fOTOPictureBox = new System.Windows.Forms.PictureBox();
            this.dATANASCMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.button6 = new System.Windows.Forms.Button();
            this.sEXOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEXOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.SEXOTableAdapter();
            this.rUABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rUATableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.RUATableAdapter();
            this.bAIRROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAIRROTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.BAIRROTableAdapter();
            this.cEPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cEPTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.CEPTableAdapter();
            this.tRABALHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRABALHOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TRABALHOTableAdapter();
            cODCLIENTELabel = new System.Windows.Forms.Label();
            nOMECLIENTELabel = new System.Windows.Forms.Label();
            fOTOLabel = new System.Windows.Forms.Label();
            cODSEXO_FKLabel = new System.Windows.Forms.Label();
            cODRUA_FKLabel = new System.Windows.Forms.Label();
            cODBAIRRO_FKLabel = new System.Windows.Forms.Label();
            cODCEP_FKLabel = new System.Windows.Forms.Label();
            sALARIOLabel = new System.Windows.Forms.Label();
            cODTRABALHO_FKLabel = new System.Windows.Forms.Label();
            nUMEROCASALabel = new System.Windows.Forms.Label();
            dATANASCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingNavigator)).BeginInit();
            this.cLIENTEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOTOPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEXOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODCLIENTELabel
            // 
            cODCLIENTELabel.AutoSize = true;
            cODCLIENTELabel.Location = new System.Drawing.Point(19, 25);
            cODCLIENTELabel.Name = "cODCLIENTELabel";
            cODCLIENTELabel.Size = new System.Drawing.Size(78, 13);
            cODCLIENTELabel.TabIndex = 1;
            cODCLIENTELabel.Text = "Código Cliente:";
            // 
            // nOMECLIENTELabel
            // 
            nOMECLIENTELabel.AutoSize = true;
            nOMECLIENTELabel.Location = new System.Drawing.Point(31, 52);
            nOMECLIENTELabel.Name = "nOMECLIENTELabel";
            nOMECLIENTELabel.Size = new System.Drawing.Size(73, 13);
            nOMECLIENTELabel.TabIndex = 3;
            nOMECLIENTELabel.Text = "Nome Cliente:";
            // 
            // fOTOLabel
            // 
            fOTOLabel.AutoSize = true;
            fOTOLabel.Location = new System.Drawing.Point(66, 115);
            fOTOLabel.Name = "fOTOLabel";
            fOTOLabel.Size = new System.Drawing.Size(31, 13);
            fOTOLabel.TabIndex = 5;
            fOTOLabel.Text = "Foto:";
            // 
            // cODSEXO_FKLabel
            // 
            cODSEXO_FKLabel.AutoSize = true;
            cODSEXO_FKLabel.Location = new System.Drawing.Point(506, 35);
            cODSEXO_FKLabel.Name = "cODSEXO_FKLabel";
            cODSEXO_FKLabel.Size = new System.Drawing.Size(83, 13);
            cODSEXO_FKLabel.TabIndex = 9;
            cODSEXO_FKLabel.Text = "Código SexoFK:";
            // 
            // cODRUA_FKLabel
            // 
            cODRUA_FKLabel.AutoSize = true;
            cODRUA_FKLabel.Location = new System.Drawing.Point(505, 74);
            cODRUA_FKLabel.Name = "cODRUA_FKLabel";
            cODRUA_FKLabel.Size = new System.Drawing.Size(79, 13);
            cODRUA_FKLabel.TabIndex = 11;
            cODRUA_FKLabel.Text = "Código RuaFK:";
            // 
            // cODBAIRRO_FKLabel
            // 
            cODBAIRRO_FKLabel.AutoSize = true;
            cODBAIRRO_FKLabel.Location = new System.Drawing.Point(494, 115);
            cODBAIRRO_FKLabel.Name = "cODBAIRRO_FKLabel";
            cODBAIRRO_FKLabel.Size = new System.Drawing.Size(86, 13);
            cODBAIRRO_FKLabel.TabIndex = 13;
            cODBAIRRO_FKLabel.Text = "Código BairroFK:";
            // 
            // cODCEP_FKLabel
            // 
            cODCEP_FKLabel.AutoSize = true;
            cODCEP_FKLabel.Location = new System.Drawing.Point(507, 158);
            cODCEP_FKLabel.Name = "cODCEP_FKLabel";
            cODCEP_FKLabel.Size = new System.Drawing.Size(78, 13);
            cODCEP_FKLabel.TabIndex = 15;
            cODCEP_FKLabel.Text = "Código CepFK:";
            // 
            // sALARIOLabel
            // 
            sALARIOLabel.AutoSize = true;
            sALARIOLabel.Location = new System.Drawing.Point(66, 196);
            sALARIOLabel.Name = "sALARIOLabel";
            sALARIOLabel.Size = new System.Drawing.Size(42, 13);
            sALARIOLabel.TabIndex = 17;
            sALARIOLabel.Text = "Salário:";
            // 
            // cODTRABALHO_FKLabel
            // 
            cODTRABALHO_FKLabel.AutoSize = true;
            cODTRABALHO_FKLabel.Location = new System.Drawing.Point(484, 200);
            cODTRABALHO_FKLabel.Name = "cODTRABALHO_FKLabel";
            cODTRABALHO_FKLabel.Size = new System.Drawing.Size(101, 13);
            cODTRABALHO_FKLabel.TabIndex = 19;
            cODTRABALHO_FKLabel.Text = "Código TrabalhoFK:";
            // 
            // nUMEROCASALabel
            // 
            nUMEROCASALabel.AutoSize = true;
            nUMEROCASALabel.Location = new System.Drawing.Point(30, 79);
            nUMEROCASALabel.Name = "nUMEROCASALabel";
            nUMEROCASALabel.Size = new System.Drawing.Size(74, 13);
            nUMEROCASALabel.TabIndex = 28;
            nUMEROCASALabel.Text = "Número Casa:";
            // 
            // dATANASCLabel
            // 
            dATANASCLabel.AutoSize = true;
            dATANASCLabel.Location = new System.Drawing.Point(19, 249);
            dATANASCLabel.Name = "dATANASCLabel";
            dATANASCLabel.Size = new System.Drawing.Size(92, 13);
            dATANASCLabel.TabIndex = 29;
            dATANASCLabel.Text = "Data Nascimento:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAIRROTableAdapter = null;
            this.tableAdapterManager.CEPTableAdapter = null;
            this.tableAdapterManager.CIDADETableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = this.cLIENTETableAdapter;
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
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // cLIENTEBindingNavigator
            // 
            this.cLIENTEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cLIENTEBindingNavigator.BindingSource = this.cLIENTEBindingSource;
            this.cLIENTEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cLIENTEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cLIENTEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cLIENTEBindingNavigatorSaveItem});
            this.cLIENTEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cLIENTEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cLIENTEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cLIENTEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cLIENTEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cLIENTEBindingNavigator.Name = "cLIENTEBindingNavigator";
            this.cLIENTEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cLIENTEBindingNavigator.Size = new System.Drawing.Size(1136, 25);
            this.cLIENTEBindingNavigator.TabIndex = 0;
            this.cLIENTEBindingNavigator.Text = "bindingNavigator1";
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
            // cLIENTEBindingNavigatorSaveItem
            // 
            this.cLIENTEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cLIENTEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cLIENTEBindingNavigatorSaveItem.Image")));
            this.cLIENTEBindingNavigatorSaveItem.Name = "cLIENTEBindingNavigatorSaveItem";
            this.cLIENTEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cLIENTEBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cLIENTEBindingNavigatorSaveItem.Click += new System.EventHandler(this.cLIENTEBindingNavigatorSaveItem_Click_3);
            // 
            // cODCLIENTELabel1
            // 
            this.cODCLIENTELabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CODCLIENTE", true));
            this.cODCLIENTELabel1.Location = new System.Drawing.Point(110, 25);
            this.cODCLIENTELabel1.Name = "cODCLIENTELabel1";
            this.cODCLIENTELabel1.Size = new System.Drawing.Size(200, 23);
            this.cODCLIENTELabel1.TabIndex = 2;
            this.cODCLIENTELabel1.Text = "label1";
            // 
            // nOMECLIENTETextBox
            // 
            this.nOMECLIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "NOMECLIENTE", true));
            this.nOMECLIENTETextBox.Location = new System.Drawing.Point(110, 49);
            this.nOMECLIENTETextBox.Name = "nOMECLIENTETextBox";
            this.nOMECLIENTETextBox.Size = new System.Drawing.Size(200, 20);
            this.nOMECLIENTETextBox.TabIndex = 4;
            // 
            // cODSEXO_FKComboBox
            // 
            this.cODSEXO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTEBindingSource, "CODSEXO_FK", true));
            this.cODSEXO_FKComboBox.DataSource = this.sEXOBindingSource;
            this.cODSEXO_FKComboBox.DisplayMember = "NOMESEXO";
            this.cODSEXO_FKComboBox.FormattingEnabled = true;
            this.cODSEXO_FKComboBox.Location = new System.Drawing.Point(590, 32);
            this.cODSEXO_FKComboBox.Name = "cODSEXO_FKComboBox";
            this.cODSEXO_FKComboBox.Size = new System.Drawing.Size(200, 21);
            this.cODSEXO_FKComboBox.TabIndex = 10;
            this.cODSEXO_FKComboBox.ValueMember = "CODSEXO";
            // 
            // cODRUA_FKComboBox
            // 
            this.cODRUA_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTEBindingSource, "CODRUA_FK", true));
            this.cODRUA_FKComboBox.DataSource = this.rUABindingSource;
            this.cODRUA_FKComboBox.DisplayMember = "NOMERUA";
            this.cODRUA_FKComboBox.FormattingEnabled = true;
            this.cODRUA_FKComboBox.Location = new System.Drawing.Point(590, 71);
            this.cODRUA_FKComboBox.Name = "cODRUA_FKComboBox";
            this.cODRUA_FKComboBox.Size = new System.Drawing.Size(200, 21);
            this.cODRUA_FKComboBox.TabIndex = 12;
            this.cODRUA_FKComboBox.ValueMember = "CODRUA";
            // 
            // cODBAIRRO_FKComboBox
            // 
            this.cODBAIRRO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTEBindingSource, "CODBAIRRO_FK", true));
            this.cODBAIRRO_FKComboBox.DataSource = this.bAIRROBindingSource;
            this.cODBAIRRO_FKComboBox.DisplayMember = "NOMEBAIRRO";
            this.cODBAIRRO_FKComboBox.FormattingEnabled = true;
            this.cODBAIRRO_FKComboBox.Location = new System.Drawing.Point(590, 112);
            this.cODBAIRRO_FKComboBox.Name = "cODBAIRRO_FKComboBox";
            this.cODBAIRRO_FKComboBox.Size = new System.Drawing.Size(200, 21);
            this.cODBAIRRO_FKComboBox.TabIndex = 14;
            this.cODBAIRRO_FKComboBox.ValueMember = "CODBAIRRO";
            // 
            // cODCEP_FKComboBox
            // 
            this.cODCEP_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTEBindingSource, "CODCEP_FK", true));
            this.cODCEP_FKComboBox.DataSource = this.cEPBindingSource;
            this.cODCEP_FKComboBox.DisplayMember = "NUMEROCEP";
            this.cODCEP_FKComboBox.FormattingEnabled = true;
            this.cODCEP_FKComboBox.Location = new System.Drawing.Point(590, 155);
            this.cODCEP_FKComboBox.Name = "cODCEP_FKComboBox";
            this.cODCEP_FKComboBox.Size = new System.Drawing.Size(200, 21);
            this.cODCEP_FKComboBox.TabIndex = 16;
            this.cODCEP_FKComboBox.ValueMember = "CODCEP";
            // 
            // sALARIOTextBox
            // 
            this.sALARIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "SALARIO", true));
            this.sALARIOTextBox.Location = new System.Drawing.Point(111, 193);
            this.sALARIOTextBox.Name = "sALARIOTextBox";
            this.sALARIOTextBox.Size = new System.Drawing.Size(200, 20);
            this.sALARIOTextBox.TabIndex = 18;
            // 
            // cODTRABALHO_FKComboBox
            // 
            this.cODTRABALHO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTEBindingSource, "CODTRABALHO_FK", true));
            this.cODTRABALHO_FKComboBox.DataSource = this.tRABALHOBindingSource;
            this.cODTRABALHO_FKComboBox.DisplayMember = "NOMETRABALHO";
            this.cODTRABALHO_FKComboBox.FormattingEnabled = true;
            this.cODTRABALHO_FKComboBox.Location = new System.Drawing.Point(590, 197);
            this.cODTRABALHO_FKComboBox.Name = "cODTRABALHO_FKComboBox";
            this.cODTRABALHO_FKComboBox.Size = new System.Drawing.Size(200, 21);
            this.cODTRABALHO_FKComboBox.TabIndex = 20;
            this.cODTRABALHO_FKComboBox.ValueMember = "CODTRABALHO";
            // 
            // cLIENTEDataGridView
            // 
            this.cLIENTEDataGridView.AutoGenerateColumns = false;
            this.cLIENTEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cLIENTEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.cLIENTEDataGridView.DataSource = this.cLIENTEBindingSource;
            this.cLIENTEDataGridView.Location = new System.Drawing.Point(0, 396);
            this.cLIENTEDataGridView.Name = "cLIENTEDataGridView";
            this.cLIENTEDataGridView.ReadOnly = true;
            this.cLIENTEDataGridView.Size = new System.Drawing.Size(1144, 220);
            this.cLIENTEDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODCLIENTE";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Cliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMECLIENTE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "FOTO";
            this.dataGridViewImageColumn1.HeaderText = "FOTO";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DATANASC";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data Nascimento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CODSEXO_FK";
            this.dataGridViewTextBoxColumn4.HeaderText = "Código SexoFK";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CODRUA_FK";
            this.dataGridViewTextBoxColumn5.HeaderText = "Código RuaFK";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CODBAIRRO_FK";
            this.dataGridViewTextBoxColumn6.HeaderText = "Código BairroFK";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CODCEP_FK";
            this.dataGridViewTextBoxColumn7.HeaderText = "Código CepFK";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SALARIO";
            this.dataGridViewTextBoxColumn8.HeaderText = "Salário";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CODTRABALHO_FK";
            this.dataGridViewTextBoxColumn9.HeaderText = "Código TrabalhoFK";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NUMEROCASA";
            this.dataGridViewTextBoxColumn10.HeaderText = "Número Casa";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(796, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(796, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(796, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(796, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(796, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // nUMEROCASATextBox
            // 
            this.nUMEROCASATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "NUMEROCASA", true));
            this.nUMEROCASATextBox.Location = new System.Drawing.Point(110, 76);
            this.nUMEROCASATextBox.Name = "nUMEROCASATextBox";
            this.nUMEROCASATextBox.Size = new System.Drawing.Size(201, 20);
            this.nUMEROCASATextBox.TabIndex = 29;
            // 
            // fOTOPictureBox
            // 
            this.fOTOPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.cLIENTEBindingSource, "FOTO", true));
            this.fOTOPictureBox.Location = new System.Drawing.Point(113, 105);
            this.fOTOPictureBox.Name = "fOTOPictureBox";
            this.fOTOPictureBox.Size = new System.Drawing.Size(200, 82);
            this.fOTOPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fOTOPictureBox.TabIndex = 6;
            this.fOTOPictureBox.TabStop = false;
            // 
            // dATANASCMonthCalendar
            // 
            this.dATANASCMonthCalendar.DataBindings.Add(new System.Windows.Forms.Binding("SelectionRange", this.cLIENTEBindingSource, "DATANASC", true));
            this.dATANASCMonthCalendar.Location = new System.Drawing.Point(113, 225);
            this.dATANASCMonthCalendar.Name = "dATANASCMonthCalendar";
            this.dATANASCMonthCalendar.TabIndex = 30;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(319, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 23);
            this.button6.TabIndex = 31;
            this.button6.Text = "Adicionar Imagem";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // sEXOBindingSource
            // 
            this.sEXOBindingSource.DataMember = "SEXO";
            this.sEXOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // sEXOTableAdapter
            // 
            this.sEXOTableAdapter.ClearBeforeFill = true;
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
            // cEPBindingSource
            // 
            this.cEPBindingSource.DataMember = "CEP";
            this.cEPBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // cEPTableAdapter
            // 
            this.cEPTableAdapter.ClearBeforeFill = true;
            // 
            // tRABALHOBindingSource
            // 
            this.tRABALHOBindingSource.DataMember = "TRABALHO";
            this.tRABALHOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // tRABALHOTableAdapter
            // 
            this.tRABALHOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 628);
            this.Controls.Add(this.button6);
            this.Controls.Add(dATANASCLabel);
            this.Controls.Add(this.dATANASCMonthCalendar);
            this.Controls.Add(nUMEROCASALabel);
            this.Controls.Add(this.nUMEROCASATextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cLIENTEDataGridView);
            this.Controls.Add(cODCLIENTELabel);
            this.Controls.Add(this.cODCLIENTELabel1);
            this.Controls.Add(nOMECLIENTELabel);
            this.Controls.Add(this.nOMECLIENTETextBox);
            this.Controls.Add(fOTOLabel);
            this.Controls.Add(this.fOTOPictureBox);
            this.Controls.Add(cODSEXO_FKLabel);
            this.Controls.Add(this.cODSEXO_FKComboBox);
            this.Controls.Add(cODRUA_FKLabel);
            this.Controls.Add(this.cODRUA_FKComboBox);
            this.Controls.Add(cODBAIRRO_FKLabel);
            this.Controls.Add(this.cODBAIRRO_FKComboBox);
            this.Controls.Add(cODCEP_FKLabel);
            this.Controls.Add(this.cODCEP_FKComboBox);
            this.Controls.Add(sALARIOLabel);
            this.Controls.Add(this.sALARIOTextBox);
            this.Controls.Add(cODTRABALHO_FKLabel);
            this.Controls.Add(this.cODTRABALHO_FKComboBox);
            this.Controls.Add(this.cLIENTEBindingNavigator);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingNavigator)).EndInit();
            this.cLIENTEBindingNavigator.ResumeLayout(false);
            this.cLIENTEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOTOPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEXOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private ATIVIDADEDataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cLIENTEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cLIENTEBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODCLIENTELabel1;
        private System.Windows.Forms.TextBox nOMECLIENTETextBox;
        private System.Windows.Forms.PictureBox fOTOPictureBox;
        private System.Windows.Forms.ComboBox cODSEXO_FKComboBox;
        private System.Windows.Forms.ComboBox cODRUA_FKComboBox;
        private System.Windows.Forms.ComboBox cODBAIRRO_FKComboBox;
        private System.Windows.Forms.ComboBox cODCEP_FKComboBox;
        private System.Windows.Forms.TextBox sALARIOTextBox;
        private System.Windows.Forms.ComboBox cODTRABALHO_FKComboBox;
        private System.Windows.Forms.DataGridView cLIENTEDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox nUMEROCASATextBox;
        private System.Windows.Forms.MonthCalendar dATANASCMonthCalendar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource sEXOBindingSource;
        private ATIVIDADEDataSetTableAdapters.SEXOTableAdapter sEXOTableAdapter;
        private System.Windows.Forms.BindingSource rUABindingSource;
        private ATIVIDADEDataSetTableAdapters.RUATableAdapter rUATableAdapter;
        private System.Windows.Forms.BindingSource bAIRROBindingSource;
        private ATIVIDADEDataSetTableAdapters.BAIRROTableAdapter bAIRROTableAdapter;
        private System.Windows.Forms.BindingSource cEPBindingSource;
        private ATIVIDADEDataSetTableAdapters.CEPTableAdapter cEPTableAdapter;
        private System.Windows.Forms.BindingSource tRABALHOBindingSource;
        private ATIVIDADEDataSetTableAdapters.TRABALHOTableAdapter tRABALHOTableAdapter;
    }
}