namespace ProjetoBancoDAD
{
    partial class FrmTelefone
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
            System.Windows.Forms.Label cODTELEFONELabel;
            System.Windows.Forms.Label nUMEROLabel;
            System.Windows.Forms.Label cODOPERADORA_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelefone));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.tELEFONEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tELEFONETableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TELEFONETableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.tELEFONEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tELEFONEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODTELEFONELabel1 = new System.Windows.Forms.Label();
            this.nUMEROTextBox = new System.Windows.Forms.TextBox();
            this.cODOPERADORA_FKComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tELEFONEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERADORABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPERADORATableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.OPERADORATableAdapter();
            cODTELEFONELabel = new System.Windows.Forms.Label();
            nUMEROLabel = new System.Windows.Forms.Label();
            cODOPERADORA_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingNavigator)).BeginInit();
            this.tELEFONEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODTELEFONELabel
            // 
            cODTELEFONELabel.AutoSize = true;
            cODTELEFONELabel.Location = new System.Drawing.Point(37, 43);
            cODTELEFONELabel.Name = "cODTELEFONELabel";
            cODTELEFONELabel.Size = new System.Drawing.Size(88, 13);
            cODTELEFONELabel.TabIndex = 1;
            cODTELEFONELabel.Text = "Código Telefone:";
            // 
            // nUMEROLabel
            // 
            nUMEROLabel.AutoSize = true;
            nUMEROLabel.Location = new System.Drawing.Point(78, 72);
            nUMEROLabel.Name = "nUMEROLabel";
            nUMEROLabel.Size = new System.Drawing.Size(47, 13);
            nUMEROLabel.TabIndex = 3;
            nUMEROLabel.Text = "Número:";
            // 
            // cODOPERADORA_FKLabel
            // 
            cODOPERADORA_FKLabel.AutoSize = true;
            cODOPERADORA_FKLabel.Location = new System.Drawing.Point(16, 98);
            cODOPERADORA_FKLabel.Name = "cODOPERADORA_FKLabel";
            cODOPERADORA_FKLabel.Size = new System.Drawing.Size(109, 13);
            cODOPERADORA_FKLabel.TabIndex = 5;
            cODOPERADORA_FKLabel.Text = "Código OperadoraFK:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tELEFONEBindingSource
            // 
            this.tELEFONEBindingSource.DataMember = "TELEFONE";
            this.tELEFONEBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // tELEFONETableAdapter
            // 
            this.tELEFONETableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TELEFONETableAdapter = this.tELEFONETableAdapter;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // tELEFONEBindingNavigator
            // 
            this.tELEFONEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tELEFONEBindingNavigator.BindingSource = this.tELEFONEBindingSource;
            this.tELEFONEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tELEFONEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tELEFONEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tELEFONEBindingNavigatorSaveItem});
            this.tELEFONEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tELEFONEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tELEFONEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tELEFONEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tELEFONEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tELEFONEBindingNavigator.Name = "tELEFONEBindingNavigator";
            this.tELEFONEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tELEFONEBindingNavigator.Size = new System.Drawing.Size(392, 25);
            this.tELEFONEBindingNavigator.TabIndex = 0;
            this.tELEFONEBindingNavigator.Text = "bindingNavigator1";
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
            // tELEFONEBindingNavigatorSaveItem
            // 
            this.tELEFONEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tELEFONEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tELEFONEBindingNavigatorSaveItem.Image")));
            this.tELEFONEBindingNavigatorSaveItem.Name = "tELEFONEBindingNavigatorSaveItem";
            this.tELEFONEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tELEFONEBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tELEFONEBindingNavigatorSaveItem.Click += new System.EventHandler(this.tELEFONEBindingNavigatorSaveItem_Click);
            // 
            // cODTELEFONELabel1
            // 
            this.cODTELEFONELabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tELEFONEBindingSource, "CODTELEFONE", true));
            this.cODTELEFONELabel1.Location = new System.Drawing.Point(131, 43);
            this.cODTELEFONELabel1.Name = "cODTELEFONELabel1";
            this.cODTELEFONELabel1.Size = new System.Drawing.Size(121, 23);
            this.cODTELEFONELabel1.TabIndex = 2;
            this.cODTELEFONELabel1.Text = "label1";
            // 
            // nUMEROTextBox
            // 
            this.nUMEROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tELEFONEBindingSource, "NUMERO", true));
            this.nUMEROTextBox.Location = new System.Drawing.Point(131, 69);
            this.nUMEROTextBox.Name = "nUMEROTextBox";
            this.nUMEROTextBox.Size = new System.Drawing.Size(121, 20);
            this.nUMEROTextBox.TabIndex = 4;
            // 
            // cODOPERADORA_FKComboBox
            // 
            this.cODOPERADORA_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tELEFONEBindingSource, "CODOPERADORA_FK", true));
            this.cODOPERADORA_FKComboBox.DataSource = this.oPERADORABindingSource;
            this.cODOPERADORA_FKComboBox.DisplayMember = "NOMEOPERADORA";
            this.cODOPERADORA_FKComboBox.FormattingEnabled = true;
            this.cODOPERADORA_FKComboBox.Location = new System.Drawing.Point(131, 95);
            this.cODOPERADORA_FKComboBox.Name = "cODOPERADORA_FKComboBox";
            this.cODOPERADORA_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODOPERADORA_FKComboBox.TabIndex = 6;
            this.cODOPERADORA_FKComboBox.ValueMember = "CODOPERADORA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tELEFONEDataGridView
            // 
            this.tELEFONEDataGridView.AutoGenerateColumns = false;
            this.tELEFONEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tELEFONEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tELEFONEDataGridView.DataSource = this.tELEFONEBindingSource;
            this.tELEFONEDataGridView.Location = new System.Drawing.Point(11, 137);
            this.tELEFONEDataGridView.Name = "tELEFONEDataGridView";
            this.tELEFONEDataGridView.ReadOnly = true;
            this.tELEFONEDataGridView.Size = new System.Drawing.Size(361, 220);
            this.tELEFONEDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODTELEFONE";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Telefone";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NUMERO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Número";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CODOPERADORA_FK";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código OperadoraFK";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // oPERADORABindingSource
            // 
            this.oPERADORABindingSource.DataMember = "OPERADORA";
            this.oPERADORABindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // oPERADORATableAdapter
            // 
            this.oPERADORATableAdapter.ClearBeforeFill = true;
            // 
            // FrmTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 373);
            this.Controls.Add(this.tELEFONEDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(cODTELEFONELabel);
            this.Controls.Add(this.cODTELEFONELabel1);
            this.Controls.Add(nUMEROLabel);
            this.Controls.Add(this.nUMEROTextBox);
            this.Controls.Add(cODOPERADORA_FKLabel);
            this.Controls.Add(this.cODOPERADORA_FKComboBox);
            this.Controls.Add(this.tELEFONEBindingNavigator);
            this.Name = "FrmTelefone";
            this.Text = "FrmTelefone";
            this.Load += new System.EventHandler(this.FrmTelefone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingNavigator)).EndInit();
            this.tELEFONEBindingNavigator.ResumeLayout(false);
            this.tELEFONEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource tELEFONEBindingSource;
        private ATIVIDADEDataSetTableAdapters.TELEFONETableAdapter tELEFONETableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tELEFONEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tELEFONEBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODTELEFONELabel1;
        private System.Windows.Forms.TextBox nUMEROTextBox;
        private System.Windows.Forms.ComboBox cODOPERADORA_FKComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tELEFONEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource oPERADORABindingSource;
        private ATIVIDADEDataSetTableAdapters.OPERADORATableAdapter oPERADORATableAdapter;
    }
}