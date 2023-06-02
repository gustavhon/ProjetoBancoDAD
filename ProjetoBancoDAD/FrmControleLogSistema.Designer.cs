namespace ProjetoBancoDAD
{
    partial class FrmControleLogSistema
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
            System.Windows.Forms.Label cODCONTROLELabel;
            System.Windows.Forms.Label cODLOGIN_FKLabel;
            System.Windows.Forms.Label dATALabel;
            System.Windows.Forms.Label hORALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControleLogSistema));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.cONTROLELOGSISTEMABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONTROLELOGSISTEMATableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.CONTROLELOGSISTEMATableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.cONTROLELOGSISTEMABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cONTROLELOGSISTEMABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODCONTROLELabel1 = new System.Windows.Forms.Label();
            this.cODLOGIN_FKComboBox = new System.Windows.Forms.ComboBox();
            this.dATADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hORAMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cONTROLELOGSISTEMADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGINTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.LOGINTableAdapter();
            cODCONTROLELabel = new System.Windows.Forms.Label();
            cODLOGIN_FKLabel = new System.Windows.Forms.Label();
            dATALabel = new System.Windows.Forms.Label();
            hORALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTROLELOGSISTEMABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTROLELOGSISTEMABindingNavigator)).BeginInit();
            this.cONTROLELOGSISTEMABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONTROLELOGSISTEMADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODCONTROLELabel
            // 
            cODCONTROLELabel.AutoSize = true;
            cODCONTROLELabel.Location = new System.Drawing.Point(12, 36);
            cODCONTROLELabel.Name = "cODCONTROLELabel";
            cODCONTROLELabel.Size = new System.Drawing.Size(92, 13);
            cODCONTROLELabel.TabIndex = 1;
            cODCONTROLELabel.Text = "CODCONTROLE:";
            // 
            // cODLOGIN_FKLabel
            // 
            cODLOGIN_FKLabel.AutoSize = true;
            cODLOGIN_FKLabel.Location = new System.Drawing.Point(328, 66);
            cODLOGIN_FKLabel.Name = "cODLOGIN_FKLabel";
            cODLOGIN_FKLabel.Size = new System.Drawing.Size(85, 13);
            cODLOGIN_FKLabel.TabIndex = 3;
            cODLOGIN_FKLabel.Text = "Código LoginFK:";
            // 
            // dATALabel
            // 
            dATALabel.AutoSize = true;
            dATALabel.Location = new System.Drawing.Point(12, 66);
            dATALabel.Name = "dATALabel";
            dATALabel.Size = new System.Drawing.Size(39, 13);
            dATALabel.TabIndex = 5;
            dATALabel.Text = "DATA:";
            // 
            // hORALabel
            // 
            hORALabel.AutoSize = true;
            hORALabel.Location = new System.Drawing.Point(12, 99);
            hORALabel.Name = "hORALabel";
            hORALabel.Size = new System.Drawing.Size(41, 13);
            hORALabel.TabIndex = 7;
            hORALabel.Text = "HORA:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONTROLELOGSISTEMABindingSource
            // 
            this.cONTROLELOGSISTEMABindingSource.DataMember = "CONTROLELOGSISTEMA";
            this.cONTROLELOGSISTEMABindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // cONTROLELOGSISTEMATableAdapter
            // 
            this.cONTROLELOGSISTEMATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.CONTROLELOGSISTEMATableAdapter = this.cONTROLELOGSISTEMATableAdapter;
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
            // cONTROLELOGSISTEMABindingNavigator
            // 
            this.cONTROLELOGSISTEMABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cONTROLELOGSISTEMABindingNavigator.BindingSource = this.cONTROLELOGSISTEMABindingSource;
            this.cONTROLELOGSISTEMABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cONTROLELOGSISTEMABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cONTROLELOGSISTEMABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cONTROLELOGSISTEMABindingNavigatorSaveItem});
            this.cONTROLELOGSISTEMABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cONTROLELOGSISTEMABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cONTROLELOGSISTEMABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cONTROLELOGSISTEMABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cONTROLELOGSISTEMABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cONTROLELOGSISTEMABindingNavigator.Name = "cONTROLELOGSISTEMABindingNavigator";
            this.cONTROLELOGSISTEMABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cONTROLELOGSISTEMABindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.cONTROLELOGSISTEMABindingNavigator.TabIndex = 0;
            this.cONTROLELOGSISTEMABindingNavigator.Text = "bindingNavigator1";
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
            // cONTROLELOGSISTEMABindingNavigatorSaveItem
            // 
            this.cONTROLELOGSISTEMABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cONTROLELOGSISTEMABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cONTROLELOGSISTEMABindingNavigatorSaveItem.Image")));
            this.cONTROLELOGSISTEMABindingNavigatorSaveItem.Name = "cONTROLELOGSISTEMABindingNavigatorSaveItem";
            this.cONTROLELOGSISTEMABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cONTROLELOGSISTEMABindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cONTROLELOGSISTEMABindingNavigatorSaveItem.Click += new System.EventHandler(this.cONTROLELOGSISTEMABindingNavigatorSaveItem_Click);
            // 
            // cODCONTROLELabel1
            // 
            this.cODCONTROLELabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONTROLELOGSISTEMABindingSource, "CODCONTROLE", true));
            this.cODCONTROLELabel1.Location = new System.Drawing.Point(110, 36);
            this.cODCONTROLELabel1.Name = "cODCONTROLELabel1";
            this.cODCONTROLELabel1.Size = new System.Drawing.Size(200, 23);
            this.cODCONTROLELabel1.TabIndex = 2;
            this.cODCONTROLELabel1.Text = "label1";
            // 
            // cODLOGIN_FKComboBox
            // 
            this.cODLOGIN_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cONTROLELOGSISTEMABindingSource, "CODLOGIN_FK", true));
            this.cODLOGIN_FKComboBox.DataSource = this.lOGINBindingSource;
            this.cODLOGIN_FKComboBox.DisplayMember = "USUARIO";
            this.cODLOGIN_FKComboBox.FormattingEnabled = true;
            this.cODLOGIN_FKComboBox.Location = new System.Drawing.Point(426, 63);
            this.cODLOGIN_FKComboBox.Name = "cODLOGIN_FKComboBox";
            this.cODLOGIN_FKComboBox.Size = new System.Drawing.Size(200, 21);
            this.cODLOGIN_FKComboBox.TabIndex = 4;
            this.cODLOGIN_FKComboBox.ValueMember = "CODLOGIN";
            // 
            // dATADateTimePicker
            // 
            this.dATADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cONTROLELOGSISTEMABindingSource, "DATA", true));
            this.dATADateTimePicker.Location = new System.Drawing.Point(110, 62);
            this.dATADateTimePicker.Name = "dATADateTimePicker";
            this.dATADateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dATADateTimePicker.TabIndex = 6;
            // 
            // hORAMaskedTextBox
            // 
            this.hORAMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONTROLELOGSISTEMABindingSource, "HORA", true));
            this.hORAMaskedTextBox.Location = new System.Drawing.Point(110, 96);
            this.hORAMaskedTextBox.Mask = "00:00";
            this.hORAMaskedTextBox.Name = "hORAMaskedTextBox";
            this.hORAMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.hORAMaskedTextBox.TabIndex = 8;
            // 
            // cONTROLELOGSISTEMADataGridView
            // 
            this.cONTROLELOGSISTEMADataGridView.AutoGenerateColumns = false;
            this.cONTROLELOGSISTEMADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cONTROLELOGSISTEMADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2});
            this.cONTROLELOGSISTEMADataGridView.DataSource = this.cONTROLELOGSISTEMABindingSource;
            this.cONTROLELOGSISTEMADataGridView.Location = new System.Drawing.Point(15, 164);
            this.cONTROLELOGSISTEMADataGridView.Name = "cONTROLELOGSISTEMADataGridView";
            this.cONTROLELOGSISTEMADataGridView.ReadOnly = true;
            this.cONTROLELOGSISTEMADataGridView.Size = new System.Drawing.Size(748, 220);
            this.cONTROLELOGSISTEMADataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODCONTROLE";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Controle";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DATA";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HORA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Hora:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CODLOGIN_FK";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código LoginFK:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lOGINBindingSource
            // 
            this.lOGINBindingSource.DataMember = "LOGIN";
            this.lOGINBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // lOGINTableAdapter
            // 
            this.lOGINTableAdapter.ClearBeforeFill = true;
            // 
            // FrmControleLogSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cONTROLELOGSISTEMADataGridView);
            this.Controls.Add(cODCONTROLELabel);
            this.Controls.Add(this.cODCONTROLELabel1);
            this.Controls.Add(cODLOGIN_FKLabel);
            this.Controls.Add(this.cODLOGIN_FKComboBox);
            this.Controls.Add(dATALabel);
            this.Controls.Add(this.dATADateTimePicker);
            this.Controls.Add(hORALabel);
            this.Controls.Add(this.hORAMaskedTextBox);
            this.Controls.Add(this.cONTROLELOGSISTEMABindingNavigator);
            this.Name = "FrmControleLogSistema";
            this.Text = "FrmControleLogSistema";
            this.Load += new System.EventHandler(this.FrmControleLogSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTROLELOGSISTEMABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTROLELOGSISTEMABindingNavigator)).EndInit();
            this.cONTROLELOGSISTEMABindingNavigator.ResumeLayout(false);
            this.cONTROLELOGSISTEMABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONTROLELOGSISTEMADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource cONTROLELOGSISTEMABindingSource;
        private ATIVIDADEDataSetTableAdapters.CONTROLELOGSISTEMATableAdapter cONTROLELOGSISTEMATableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cONTROLELOGSISTEMABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cONTROLELOGSISTEMABindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODCONTROLELabel1;
        private System.Windows.Forms.ComboBox cODLOGIN_FKComboBox;
        private System.Windows.Forms.DateTimePicker dATADateTimePicker;
        private System.Windows.Forms.MaskedTextBox hORAMaskedTextBox;
        private System.Windows.Forms.DataGridView cONTROLELOGSISTEMADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource lOGINBindingSource;
        private ATIVIDADEDataSetTableAdapters.LOGINTableAdapter lOGINTableAdapter;
    }
}