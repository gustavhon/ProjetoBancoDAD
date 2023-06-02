namespace ProjetoBancoDAD
{
    partial class FrmItensTelefoneFornecedor
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
            System.Windows.Forms.Label cODFORNECEDORLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensTelefoneFornecedor));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.iTENSTELEFONEFORNECEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENSTELEFONEFORNECEDORTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.ITENSTELEFONEFORNECEDORTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.iTENSTELEFONEFORNECEDORBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iTENSTELEFONEFORNECEDORBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODTELEFONEComboBox = new System.Windows.Forms.ComboBox();
            this.cODFORNECEDORComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.iTENSTELEFONEFORNECEDORDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tELEFONETableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TELEFONETableAdapter();
            this.fORNECEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fORNECEDORTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.FORNECEDORTableAdapter();
            cODTELEFONELabel = new System.Windows.Forms.Label();
            cODFORNECEDORLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONEFORNECEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONEFORNECEDORBindingNavigator)).BeginInit();
            this.iTENSTELEFONEFORNECEDORBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONEFORNECEDORDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODTELEFONELabel
            // 
            cODTELEFONELabel.AutoSize = true;
            cODTELEFONELabel.Location = new System.Drawing.Point(9, 48);
            cODTELEFONELabel.Name = "cODTELEFONELabel";
            cODTELEFONELabel.Size = new System.Drawing.Size(88, 13);
            cODTELEFONELabel.TabIndex = 1;
            cODTELEFONELabel.Text = "Código Telefone:";
            // 
            // cODFORNECEDORLabel
            // 
            cODFORNECEDORLabel.AutoSize = true;
            cODFORNECEDORLabel.Location = new System.Drawing.Point(284, 48);
            cODFORNECEDORLabel.Name = "cODFORNECEDORLabel";
            cODFORNECEDORLabel.Size = new System.Drawing.Size(108, 13);
            cODFORNECEDORLabel.TabIndex = 3;
            cODFORNECEDORLabel.Text = "CODFORNECEDOR:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTENSTELEFONEFORNECEDORBindingSource
            // 
            this.iTENSTELEFONEFORNECEDORBindingSource.DataMember = "ITENSTELEFONEFORNECEDOR";
            this.iTENSTELEFONEFORNECEDORBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // iTENSTELEFONEFORNECEDORTableAdapter
            // 
            this.iTENSTELEFONEFORNECEDORTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ITENSTELEFONEFORNECEDORTableAdapter = this.iTENSTELEFONEFORNECEDORTableAdapter;
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
            // iTENSTELEFONEFORNECEDORBindingNavigator
            // 
            this.iTENSTELEFONEFORNECEDORBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTENSTELEFONEFORNECEDORBindingNavigator.BindingSource = this.iTENSTELEFONEFORNECEDORBindingSource;
            this.iTENSTELEFONEFORNECEDORBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTENSTELEFONEFORNECEDORBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTENSTELEFONEFORNECEDORBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iTENSTELEFONEFORNECEDORBindingNavigatorSaveItem});
            this.iTENSTELEFONEFORNECEDORBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTENSTELEFONEFORNECEDORBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTENSTELEFONEFORNECEDORBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTENSTELEFONEFORNECEDORBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTENSTELEFONEFORNECEDORBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTENSTELEFONEFORNECEDORBindingNavigator.Name = "iTENSTELEFONEFORNECEDORBindingNavigator";
            this.iTENSTELEFONEFORNECEDORBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTENSTELEFONEFORNECEDORBindingNavigator.Size = new System.Drawing.Size(577, 25);
            this.iTENSTELEFONEFORNECEDORBindingNavigator.TabIndex = 0;
            this.iTENSTELEFONEFORNECEDORBindingNavigator.Text = "bindingNavigator1";
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
            // iTENSTELEFONEFORNECEDORBindingNavigatorSaveItem
            // 
            this.iTENSTELEFONEFORNECEDORBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTENSTELEFONEFORNECEDORBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iTENSTELEFONEFORNECEDORBindingNavigatorSaveItem.Image")));
            this.iTENSTELEFONEFORNECEDORBindingNavigatorSaveItem.Name = "iTENSTELEFONEFORNECEDORBindingNavigatorSaveItem";
            this.iTENSTELEFONEFORNECEDORBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iTENSTELEFONEFORNECEDORBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.iTENSTELEFONEFORNECEDORBindingNavigatorSaveItem.Click += new System.EventHandler(this.iTENSTELEFONEFORNECEDORBindingNavigatorSaveItem_Click);
            // 
            // cODTELEFONEComboBox
            // 
            this.cODTELEFONEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENSTELEFONEFORNECEDORBindingSource, "CODTELEFONE", true));
            this.cODTELEFONEComboBox.DataSource = this.tELEFONEBindingSource;
            this.cODTELEFONEComboBox.DisplayMember = "NUMERO";
            this.cODTELEFONEComboBox.FormattingEnabled = true;
            this.cODTELEFONEComboBox.Location = new System.Drawing.Point(101, 43);
            this.cODTELEFONEComboBox.Name = "cODTELEFONEComboBox";
            this.cODTELEFONEComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODTELEFONEComboBox.TabIndex = 2;
            this.cODTELEFONEComboBox.ValueMember = "CODTELEFONE";
            // 
            // cODFORNECEDORComboBox
            // 
            this.cODFORNECEDORComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENSTELEFONEFORNECEDORBindingSource, "CODFORNECEDOR", true));
            this.cODFORNECEDORComboBox.DataSource = this.fORNECEDORBindingSource;
            this.cODFORNECEDORComboBox.DisplayMember = "NOMEFORNECEDOR";
            this.cODFORNECEDORComboBox.FormattingEnabled = true;
            this.cODFORNECEDORComboBox.Location = new System.Drawing.Point(398, 44);
            this.cODFORNECEDORComboBox.Name = "cODFORNECEDORComboBox";
            this.cODFORNECEDORComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODFORNECEDORComboBox.TabIndex = 4;
            this.cODFORNECEDORComboBox.ValueMember = "CODFORNECEDOR";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // iTENSTELEFONEFORNECEDORDataGridView
            // 
            this.iTENSTELEFONEFORNECEDORDataGridView.AutoGenerateColumns = false;
            this.iTENSTELEFONEFORNECEDORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iTENSTELEFONEFORNECEDORDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.iTENSTELEFONEFORNECEDORDataGridView.DataSource = this.iTENSTELEFONEFORNECEDORBindingSource;
            this.iTENSTELEFONEFORNECEDORDataGridView.Location = new System.Drawing.Point(12, 83);
            this.iTENSTELEFONEFORNECEDORDataGridView.Name = "iTENSTELEFONEFORNECEDORDataGridView";
            this.iTENSTELEFONEFORNECEDORDataGridView.ReadOnly = true;
            this.iTENSTELEFONEFORNECEDORDataGridView.Size = new System.Drawing.Size(553, 220);
            this.iTENSTELEFONEFORNECEDORDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODTELEFONE";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Telefone";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CODFORNECEDOR";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código Fornecedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
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
            // fORNECEDORBindingSource
            // 
            this.fORNECEDORBindingSource.DataMember = "FORNECEDOR";
            this.fORNECEDORBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // fORNECEDORTableAdapter
            // 
            this.fORNECEDORTableAdapter.ClearBeforeFill = true;
            // 
            // FrmItensTelefoneFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 314);
            this.Controls.Add(this.iTENSTELEFONEFORNECEDORDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cODTELEFONELabel);
            this.Controls.Add(this.cODTELEFONEComboBox);
            this.Controls.Add(cODFORNECEDORLabel);
            this.Controls.Add(this.cODFORNECEDORComboBox);
            this.Controls.Add(this.iTENSTELEFONEFORNECEDORBindingNavigator);
            this.Name = "FrmItensTelefoneFornecedor";
            this.Text = "FrmItensTelefoneFornecedor";
            this.Load += new System.EventHandler(this.FrmItensTelefoneFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONEFORNECEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONEFORNECEDORBindingNavigator)).EndInit();
            this.iTENSTELEFONEFORNECEDORBindingNavigator.ResumeLayout(false);
            this.iTENSTELEFONEFORNECEDORBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONEFORNECEDORDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource iTENSTELEFONEFORNECEDORBindingSource;
        private ATIVIDADEDataSetTableAdapters.ITENSTELEFONEFORNECEDORTableAdapter iTENSTELEFONEFORNECEDORTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iTENSTELEFONEFORNECEDORBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iTENSTELEFONEFORNECEDORBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox cODTELEFONEComboBox;
        private System.Windows.Forms.ComboBox cODFORNECEDORComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView iTENSTELEFONEFORNECEDORDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource tELEFONEBindingSource;
        private ATIVIDADEDataSetTableAdapters.TELEFONETableAdapter tELEFONETableAdapter;
        private System.Windows.Forms.BindingSource fORNECEDORBindingSource;
        private ATIVIDADEDataSetTableAdapters.FORNECEDORTableAdapter fORNECEDORTableAdapter;
    }
}