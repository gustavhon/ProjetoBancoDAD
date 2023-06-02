namespace ProjetoBancoDAD
{
    partial class FrmItensTelefoneFuncionario
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
            System.Windows.Forms.Label cODFUNCIONARIO_FKLabel;
            System.Windows.Forms.Label cODTELEFONE_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensTelefoneFuncionario));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.iTENSTELEFONEFUNCIONARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENSTELEFONEFUNCIONARIOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.ITENSTELEFONEFUNCIONARIOTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iTENSTELEFONEFUNCIONARIOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODFUNCIONARIO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cODTELEFONE_FKComboBox = new System.Windows.Forms.ComboBox();
            this.iTENSTELEFONEFUNCIONARIODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fUNCIONARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCIONARIOSTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.FUNCIONARIOSTableAdapter();
            this.tELEFONEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tELEFONETableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TELEFONETableAdapter();
            cODFUNCIONARIO_FKLabel = new System.Windows.Forms.Label();
            cODTELEFONE_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONEFUNCIONARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONEFUNCIONARIOBindingNavigator)).BeginInit();
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONEFUNCIONARIODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODFUNCIONARIO_FKLabel
            // 
            cODFUNCIONARIO_FKLabel.AutoSize = true;
            cODFUNCIONARIO_FKLabel.Location = new System.Drawing.Point(9, 54);
            cODFUNCIONARIO_FKLabel.Name = "cODFUNCIONARIO_FKLabel";
            cODFUNCIONARIO_FKLabel.Size = new System.Drawing.Size(117, 13);
            cODFUNCIONARIO_FKLabel.TabIndex = 1;
            cODFUNCIONARIO_FKLabel.Text = "Código Funcionário FK:";
            // 
            // cODTELEFONE_FKLabel
            // 
            cODTELEFONE_FKLabel.AutoSize = true;
            cODTELEFONE_FKLabel.Location = new System.Drawing.Point(316, 54);
            cODTELEFONE_FKLabel.Name = "cODTELEFONE_FKLabel";
            cODTELEFONE_FKLabel.Size = new System.Drawing.Size(101, 13);
            cODTELEFONE_FKLabel.TabIndex = 3;
            cODTELEFONE_FKLabel.Text = "Código TelefoneFK:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTENSTELEFONEFUNCIONARIOBindingSource
            // 
            this.iTENSTELEFONEFUNCIONARIOBindingSource.DataMember = "ITENSTELEFONEFUNCIONARIO";
            this.iTENSTELEFONEFUNCIONARIOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // iTENSTELEFONEFUNCIONARIOTableAdapter
            // 
            this.iTENSTELEFONEFUNCIONARIOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ITENSTELEFONEFUNCIONARIOTableAdapter = this.iTENSTELEFONEFUNCIONARIOTableAdapter;
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
            // iTENSTELEFONEFUNCIONARIOBindingNavigator
            // 
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.BindingSource = this.iTENSTELEFONEFUNCIONARIOBindingSource;
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iTENSTELEFONEFUNCIONARIOBindingNavigatorSaveItem});
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.Name = "iTENSTELEFONEFUNCIONARIOBindingNavigator";
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.Size = new System.Drawing.Size(630, 25);
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.TabIndex = 0;
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.Text = "bindingNavigator1";
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
            // iTENSTELEFONEFUNCIONARIOBindingNavigatorSaveItem
            // 
            this.iTENSTELEFONEFUNCIONARIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTENSTELEFONEFUNCIONARIOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iTENSTELEFONEFUNCIONARIOBindingNavigatorSaveItem.Image")));
            this.iTENSTELEFONEFUNCIONARIOBindingNavigatorSaveItem.Name = "iTENSTELEFONEFUNCIONARIOBindingNavigatorSaveItem";
            this.iTENSTELEFONEFUNCIONARIOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iTENSTELEFONEFUNCIONARIOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.iTENSTELEFONEFUNCIONARIOBindingNavigatorSaveItem.Click += new System.EventHandler(this.iTENSTELEFONEFUNCIONARIOBindingNavigatorSaveItem_Click);
            // 
            // cODFUNCIONARIO_FKComboBox
            // 
            this.cODFUNCIONARIO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENSTELEFONEFUNCIONARIOBindingSource, "CODFUNCIONARIO_FK", true));
            this.cODFUNCIONARIO_FKComboBox.DataSource = this.fUNCIONARIOSBindingSource;
            this.cODFUNCIONARIO_FKComboBox.DisplayMember = "NOMEFUNCIONARIO";
            this.cODFUNCIONARIO_FKComboBox.FormattingEnabled = true;
            this.cODFUNCIONARIO_FKComboBox.Location = new System.Drawing.Point(138, 51);
            this.cODFUNCIONARIO_FKComboBox.Name = "cODFUNCIONARIO_FKComboBox";
            this.cODFUNCIONARIO_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODFUNCIONARIO_FKComboBox.TabIndex = 2;
            this.cODFUNCIONARIO_FKComboBox.ValueMember = "CODFUNCIONARIOS";
            // 
            // cODTELEFONE_FKComboBox
            // 
            this.cODTELEFONE_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENSTELEFONEFUNCIONARIOBindingSource, "CODTELEFONE_FK", true));
            this.cODTELEFONE_FKComboBox.DataSource = this.tELEFONEBindingSource;
            this.cODTELEFONE_FKComboBox.DisplayMember = "NUMERO";
            this.cODTELEFONE_FKComboBox.FormattingEnabled = true;
            this.cODTELEFONE_FKComboBox.Location = new System.Drawing.Point(445, 51);
            this.cODTELEFONE_FKComboBox.Name = "cODTELEFONE_FKComboBox";
            this.cODTELEFONE_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODTELEFONE_FKComboBox.TabIndex = 4;
            this.cODTELEFONE_FKComboBox.ValueMember = "CODTELEFONE";
            // 
            // iTENSTELEFONEFUNCIONARIODataGridView
            // 
            this.iTENSTELEFONEFUNCIONARIODataGridView.AutoGenerateColumns = false;
            this.iTENSTELEFONEFUNCIONARIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iTENSTELEFONEFUNCIONARIODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.iTENSTELEFONEFUNCIONARIODataGridView.DataSource = this.iTENSTELEFONEFUNCIONARIOBindingSource;
            this.iTENSTELEFONEFUNCIONARIODataGridView.Location = new System.Drawing.Point(12, 92);
            this.iTENSTELEFONEFUNCIONARIODataGridView.Name = "iTENSTELEFONEFUNCIONARIODataGridView";
            this.iTENSTELEFONEFUNCIONARIODataGridView.ReadOnly = true;
            this.iTENSTELEFONEFUNCIONARIODataGridView.Size = new System.Drawing.Size(604, 220);
            this.iTENSTELEFONEFUNCIONARIODataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODFUNCIONARIO_FK";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código FuncionárioFK";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 270;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CODTELEFONE_FK";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código TelefoneFK";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 290;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // tELEFONEBindingSource
            // 
            this.tELEFONEBindingSource.DataMember = "TELEFONE";
            this.tELEFONEBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // tELEFONETableAdapter
            // 
            this.tELEFONETableAdapter.ClearBeforeFill = true;
            // 
            // FrmItensTelefoneFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 326);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iTENSTELEFONEFUNCIONARIODataGridView);
            this.Controls.Add(cODFUNCIONARIO_FKLabel);
            this.Controls.Add(this.cODFUNCIONARIO_FKComboBox);
            this.Controls.Add(cODTELEFONE_FKLabel);
            this.Controls.Add(this.cODTELEFONE_FKComboBox);
            this.Controls.Add(this.iTENSTELEFONEFUNCIONARIOBindingNavigator);
            this.Name = "FrmItensTelefoneFuncionario";
            this.Text = "FrmItensTelefoneFuncionario";
            this.Load += new System.EventHandler(this.FrmItensTelefoneFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONEFUNCIONARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONEFUNCIONARIOBindingNavigator)).EndInit();
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.ResumeLayout(false);
            this.iTENSTELEFONEFUNCIONARIOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONEFUNCIONARIODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource iTENSTELEFONEFUNCIONARIOBindingSource;
        private ATIVIDADEDataSetTableAdapters.ITENSTELEFONEFUNCIONARIOTableAdapter iTENSTELEFONEFUNCIONARIOTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iTENSTELEFONEFUNCIONARIOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iTENSTELEFONEFUNCIONARIOBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox cODFUNCIONARIO_FKComboBox;
        private System.Windows.Forms.ComboBox cODTELEFONE_FKComboBox;
        private System.Windows.Forms.DataGridView iTENSTELEFONEFUNCIONARIODataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource fUNCIONARIOSBindingSource;
        private ATIVIDADEDataSetTableAdapters.FUNCIONARIOSTableAdapter fUNCIONARIOSTableAdapter;
        private System.Windows.Forms.BindingSource tELEFONEBindingSource;
        private ATIVIDADEDataSetTableAdapters.TELEFONETableAdapter tELEFONETableAdapter;
    }
}