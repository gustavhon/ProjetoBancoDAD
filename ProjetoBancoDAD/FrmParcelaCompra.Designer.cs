namespace ProjetoBancoDAD
{
    partial class FrmParcelaCompra
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
            System.Windows.Forms.Label cODPARCELALabel;
            System.Windows.Forms.Label dATAVENCIMENTOLabel;
            System.Windows.Forms.Label vALORLabel;
            System.Windows.Forms.Label cODSITUACAO_FKLabel;
            System.Windows.Forms.Label cODVENDA_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParcelaCompra));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.pARCELAVENDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pARCELAVENDATableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.PARCELAVENDATableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.pARCELAVENDABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pARCELAVENDABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODPARCELALabel1 = new System.Windows.Forms.Label();
            this.dATAVENCIMENTODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vALORTextBox = new System.Windows.Forms.TextBox();
            this.cODSITUACAO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cODVENDA_FKComboBox = new System.Windows.Forms.ComboBox();
            this.pARCELAVENDADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vENDAPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENDAPRODUTOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.VENDAPRODUTOTableAdapter();
            this.sITUACAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sITUACAOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.SITUACAOTableAdapter();
            cODPARCELALabel = new System.Windows.Forms.Label();
            dATAVENCIMENTOLabel = new System.Windows.Forms.Label();
            vALORLabel = new System.Windows.Forms.Label();
            cODSITUACAO_FKLabel = new System.Windows.Forms.Label();
            cODVENDA_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELAVENDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELAVENDABindingNavigator)).BeginInit();
            this.pARCELAVENDABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELAVENDADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODPARCELALabel
            // 
            cODPARCELALabel.AutoSize = true;
            cODPARCELALabel.Location = new System.Drawing.Point(12, 72);
            cODPARCELALabel.Name = "cODPARCELALabel";
            cODPARCELALabel.Size = new System.Drawing.Size(82, 13);
            cODPARCELALabel.TabIndex = 1;
            cODPARCELALabel.Text = "CODPARCELA:";
            // 
            // dATAVENCIMENTOLabel
            // 
            dATAVENCIMENTOLabel.AutoSize = true;
            dATAVENCIMENTOLabel.Location = new System.Drawing.Point(30, 102);
            dATAVENCIMENTOLabel.Name = "dATAVENCIMENTOLabel";
            dATAVENCIMENTOLabel.Size = new System.Drawing.Size(92, 13);
            dATAVENCIMENTOLabel.TabIndex = 3;
            dATAVENCIMENTOLabel.Text = "Data Vencimento:";
            // 
            // vALORLabel
            // 
            vALORLabel.AutoSize = true;
            vALORLabel.Location = new System.Drawing.Point(88, 127);
            vALORLabel.Name = "vALORLabel";
            vALORLabel.Size = new System.Drawing.Size(34, 13);
            vALORLabel.TabIndex = 5;
            vALORLabel.Text = "Valor:";
            // 
            // cODSITUACAO_FKLabel
            // 
            cODSITUACAO_FKLabel.AutoSize = true;
            cODSITUACAO_FKLabel.Location = new System.Drawing.Point(379, 102);
            cODSITUACAO_FKLabel.Name = "cODSITUACAO_FKLabel";
            cODSITUACAO_FKLabel.Size = new System.Drawing.Size(90, 13);
            cODSITUACAO_FKLabel.TabIndex = 7;
            cODSITUACAO_FKLabel.Text = "Cod Situação FK:";
            // 
            // cODVENDA_FKLabel
            // 
            cODVENDA_FKLabel.AutoSize = true;
            cODVENDA_FKLabel.Location = new System.Drawing.Point(393, 141);
            cODVENDA_FKLabel.Name = "cODVENDA_FKLabel";
            cODVENDA_FKLabel.Size = new System.Drawing.Size(76, 13);
            cODVENDA_FKLabel.TabIndex = 9;
            cODVENDA_FKLabel.Text = "Cod VendaFK:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pARCELAVENDABindingSource
            // 
            this.pARCELAVENDABindingSource.DataMember = "PARCELAVENDA";
            this.pARCELAVENDABindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // pARCELAVENDATableAdapter
            // 
            this.pARCELAVENDATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PARCELAVENDATableAdapter = this.pARCELAVENDATableAdapter;
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
            // pARCELAVENDABindingNavigator
            // 
            this.pARCELAVENDABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pARCELAVENDABindingNavigator.BindingSource = this.pARCELAVENDABindingSource;
            this.pARCELAVENDABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pARCELAVENDABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pARCELAVENDABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pARCELAVENDABindingNavigatorSaveItem});
            this.pARCELAVENDABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pARCELAVENDABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pARCELAVENDABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pARCELAVENDABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pARCELAVENDABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pARCELAVENDABindingNavigator.Name = "pARCELAVENDABindingNavigator";
            this.pARCELAVENDABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pARCELAVENDABindingNavigator.Size = new System.Drawing.Size(1084, 25);
            this.pARCELAVENDABindingNavigator.TabIndex = 0;
            this.pARCELAVENDABindingNavigator.Text = "bindingNavigator1";
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
            // pARCELAVENDABindingNavigatorSaveItem
            // 
            this.pARCELAVENDABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pARCELAVENDABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pARCELAVENDABindingNavigatorSaveItem.Image")));
            this.pARCELAVENDABindingNavigatorSaveItem.Name = "pARCELAVENDABindingNavigatorSaveItem";
            this.pARCELAVENDABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pARCELAVENDABindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pARCELAVENDABindingNavigatorSaveItem.Click += new System.EventHandler(this.pARCELAVENDABindingNavigatorSaveItem_Click);
            // 
            // cODPARCELALabel1
            // 
            this.cODPARCELALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pARCELAVENDABindingSource, "CODPARCELA", true));
            this.cODPARCELALabel1.Location = new System.Drawing.Point(128, 72);
            this.cODPARCELALabel1.Name = "cODPARCELALabel1";
            this.cODPARCELALabel1.Size = new System.Drawing.Size(200, 23);
            this.cODPARCELALabel1.TabIndex = 2;
            this.cODPARCELALabel1.Text = "label1";
            // 
            // dATAVENCIMENTODateTimePicker
            // 
            this.dATAVENCIMENTODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pARCELAVENDABindingSource, "DATAVENCIMENTO", true));
            this.dATAVENCIMENTODateTimePicker.Location = new System.Drawing.Point(128, 99);
            this.dATAVENCIMENTODateTimePicker.Name = "dATAVENCIMENTODateTimePicker";
            this.dATAVENCIMENTODateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dATAVENCIMENTODateTimePicker.TabIndex = 4;
            // 
            // vALORTextBox
            // 
            this.vALORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pARCELAVENDABindingSource, "VALOR", true));
            this.vALORTextBox.Location = new System.Drawing.Point(128, 125);
            this.vALORTextBox.Name = "vALORTextBox";
            this.vALORTextBox.Size = new System.Drawing.Size(200, 20);
            this.vALORTextBox.TabIndex = 6;
            // 
            // cODSITUACAO_FKComboBox
            // 
            this.cODSITUACAO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pARCELAVENDABindingSource, "CODSITUACAO_FK", true));
            this.cODSITUACAO_FKComboBox.DataSource = this.sITUACAOBindingSource;
            this.cODSITUACAO_FKComboBox.DisplayMember = "NOMESITUACAO";
            this.cODSITUACAO_FKComboBox.FormattingEnabled = true;
            this.cODSITUACAO_FKComboBox.Location = new System.Drawing.Point(470, 98);
            this.cODSITUACAO_FKComboBox.Name = "cODSITUACAO_FKComboBox";
            this.cODSITUACAO_FKComboBox.Size = new System.Drawing.Size(200, 21);
            this.cODSITUACAO_FKComboBox.TabIndex = 8;
            this.cODSITUACAO_FKComboBox.ValueMember = "CODSITUACAO";
            // 
            // cODVENDA_FKComboBox
            // 
            this.cODVENDA_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pARCELAVENDABindingSource, "CODVENDA_FK", true));
            this.cODVENDA_FKComboBox.DataSource = this.vENDAPRODUTOBindingSource;
            this.cODVENDA_FKComboBox.DisplayMember = "CODVENDA";
            this.cODVENDA_FKComboBox.FormattingEnabled = true;
            this.cODVENDA_FKComboBox.Location = new System.Drawing.Point(470, 138);
            this.cODVENDA_FKComboBox.Name = "cODVENDA_FKComboBox";
            this.cODVENDA_FKComboBox.Size = new System.Drawing.Size(200, 21);
            this.cODVENDA_FKComboBox.TabIndex = 10;
            this.cODVENDA_FKComboBox.ValueMember = "CODVENDA";
            // 
            // pARCELAVENDADataGridView
            // 
            this.pARCELAVENDADataGridView.AutoGenerateColumns = false;
            this.pARCELAVENDADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pARCELAVENDADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pARCELAVENDADataGridView.DataSource = this.pARCELAVENDABindingSource;
            this.pARCELAVENDADataGridView.Location = new System.Drawing.Point(28, 187);
            this.pARCELAVENDADataGridView.Name = "pARCELAVENDADataGridView";
            this.pARCELAVENDADataGridView.ReadOnly = true;
            this.pARCELAVENDADataGridView.Size = new System.Drawing.Size(1048, 220);
            this.pARCELAVENDADataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODPARCELA";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Parcela";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DATAVENCIMENTO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data Vencimento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VALOR";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CODSITUACAO_FK";
            this.dataGridViewTextBoxColumn4.HeaderText = "Código SituaçãoFK";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CODVENDA_FK";
            this.dataGridViewTextBoxColumn5.HeaderText = "Código VendaFK";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // sITUACAOBindingSource
            // 
            this.sITUACAOBindingSource.DataMember = "SITUACAO";
            this.sITUACAOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // sITUACAOTableAdapter
            // 
            this.sITUACAOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmParcelaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pARCELAVENDADataGridView);
            this.Controls.Add(cODPARCELALabel);
            this.Controls.Add(this.cODPARCELALabel1);
            this.Controls.Add(dATAVENCIMENTOLabel);
            this.Controls.Add(this.dATAVENCIMENTODateTimePicker);
            this.Controls.Add(vALORLabel);
            this.Controls.Add(this.vALORTextBox);
            this.Controls.Add(cODSITUACAO_FKLabel);
            this.Controls.Add(this.cODSITUACAO_FKComboBox);
            this.Controls.Add(cODVENDA_FKLabel);
            this.Controls.Add(this.cODVENDA_FKComboBox);
            this.Controls.Add(this.pARCELAVENDABindingNavigator);
            this.Name = "FrmParcelaCompra";
            this.Text = "FrmParcelaCompra";
            this.Load += new System.EventHandler(this.FrmParcelaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELAVENDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELAVENDABindingNavigator)).EndInit();
            this.pARCELAVENDABindingNavigator.ResumeLayout(false);
            this.pARCELAVENDABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELAVENDADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource pARCELAVENDABindingSource;
        private ATIVIDADEDataSetTableAdapters.PARCELAVENDATableAdapter pARCELAVENDATableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pARCELAVENDABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pARCELAVENDABindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODPARCELALabel1;
        private System.Windows.Forms.DateTimePicker dATAVENCIMENTODateTimePicker;
        private System.Windows.Forms.TextBox vALORTextBox;
        private System.Windows.Forms.ComboBox cODSITUACAO_FKComboBox;
        private System.Windows.Forms.ComboBox cODVENDA_FKComboBox;
        private System.Windows.Forms.DataGridView pARCELAVENDADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource vENDAPRODUTOBindingSource;
        private ATIVIDADEDataSetTableAdapters.VENDAPRODUTOTableAdapter vENDAPRODUTOTableAdapter;
        private System.Windows.Forms.BindingSource sITUACAOBindingSource;
        private ATIVIDADEDataSetTableAdapters.SITUACAOTableAdapter sITUACAOTableAdapter;
    }
}