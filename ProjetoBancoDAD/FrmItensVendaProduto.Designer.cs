namespace ProjetoBancoDAD
{
    partial class FrmItensVendaProduto
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
            System.Windows.Forms.Label cODVENDA_FKLabel;
            System.Windows.Forms.Label cODPRODUTO_FKLabel;
            System.Windows.Forms.Label qUANTIDADELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensVendaProduto));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.iTENSVENDAPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENSVENDAPRODUTOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.ITENSVENDAPRODUTOTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.iTENSVENDAPRODUTOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iTENSVENDAPRODUTOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODVENDA_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cODPRODUTO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.qUANTIDADETextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.iTENSVENDAPRODUTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDAPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENDAPRODUTOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.VENDAPRODUTOTableAdapter();
            this.pRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.PRODUTOTableAdapter();
            cODVENDA_FKLabel = new System.Windows.Forms.Label();
            cODPRODUTO_FKLabel = new System.Windows.Forms.Label();
            qUANTIDADELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSVENDAPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSVENDAPRODUTOBindingNavigator)).BeginInit();
            this.iTENSVENDAPRODUTOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSVENDAPRODUTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODVENDA_FKLabel
            // 
            cODVENDA_FKLabel.AutoSize = true;
            cODVENDA_FKLabel.Location = new System.Drawing.Point(29, 91);
            cODVENDA_FKLabel.Name = "cODVENDA_FKLabel";
            cODVENDA_FKLabel.Size = new System.Drawing.Size(90, 13);
            cODVENDA_FKLabel.TabIndex = 1;
            cODVENDA_FKLabel.Text = "Código VendaFK:";
            // 
            // cODPRODUTO_FKLabel
            // 
            cODPRODUTO_FKLabel.AutoSize = true;
            cODPRODUTO_FKLabel.Location = new System.Drawing.Point(327, 95);
            cODPRODUTO_FKLabel.Name = "cODPRODUTO_FKLabel";
            cODPRODUTO_FKLabel.Size = new System.Drawing.Size(96, 13);
            cODPRODUTO_FKLabel.TabIndex = 3;
            cODPRODUTO_FKLabel.Text = "Código ProdutoFK:";
            // 
            // qUANTIDADELabel
            // 
            qUANTIDADELabel.AutoSize = true;
            qUANTIDADELabel.Location = new System.Drawing.Point(50, 49);
            qUANTIDADELabel.Name = "qUANTIDADELabel";
            qUANTIDADELabel.Size = new System.Drawing.Size(65, 13);
            qUANTIDADELabel.TabIndex = 5;
            qUANTIDADELabel.Text = "Quantidade:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTENSVENDAPRODUTOBindingSource
            // 
            this.iTENSVENDAPRODUTOBindingSource.DataMember = "ITENSVENDAPRODUTO";
            this.iTENSVENDAPRODUTOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // iTENSVENDAPRODUTOTableAdapter
            // 
            this.iTENSVENDAPRODUTOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ITENSVENDAPRODUTOTableAdapter = this.iTENSVENDAPRODUTOTableAdapter;
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
            // iTENSVENDAPRODUTOBindingNavigator
            // 
            this.iTENSVENDAPRODUTOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTENSVENDAPRODUTOBindingNavigator.BindingSource = this.iTENSVENDAPRODUTOBindingSource;
            this.iTENSVENDAPRODUTOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTENSVENDAPRODUTOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTENSVENDAPRODUTOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iTENSVENDAPRODUTOBindingNavigatorSaveItem});
            this.iTENSVENDAPRODUTOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTENSVENDAPRODUTOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTENSVENDAPRODUTOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTENSVENDAPRODUTOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTENSVENDAPRODUTOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTENSVENDAPRODUTOBindingNavigator.Name = "iTENSVENDAPRODUTOBindingNavigator";
            this.iTENSVENDAPRODUTOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTENSVENDAPRODUTOBindingNavigator.Size = new System.Drawing.Size(684, 25);
            this.iTENSVENDAPRODUTOBindingNavigator.TabIndex = 0;
            this.iTENSVENDAPRODUTOBindingNavigator.Text = "bindingNavigator1";
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
            // iTENSVENDAPRODUTOBindingNavigatorSaveItem
            // 
            this.iTENSVENDAPRODUTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTENSVENDAPRODUTOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iTENSVENDAPRODUTOBindingNavigatorSaveItem.Image")));
            this.iTENSVENDAPRODUTOBindingNavigatorSaveItem.Name = "iTENSVENDAPRODUTOBindingNavigatorSaveItem";
            this.iTENSVENDAPRODUTOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iTENSVENDAPRODUTOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.iTENSVENDAPRODUTOBindingNavigatorSaveItem.Click += new System.EventHandler(this.iTENSVENDAPRODUTOBindingNavigatorSaveItem_Click);
            // 
            // cODVENDA_FKComboBox
            // 
            this.cODVENDA_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENSVENDAPRODUTOBindingSource, "CODVENDA_FK", true));
            this.cODVENDA_FKComboBox.DataSource = this.vENDAPRODUTOBindingSource;
            this.cODVENDA_FKComboBox.DisplayMember = "CODVENDA";
            this.cODVENDA_FKComboBox.FormattingEnabled = true;
            this.cODVENDA_FKComboBox.Location = new System.Drawing.Point(121, 88);
            this.cODVENDA_FKComboBox.Name = "cODVENDA_FKComboBox";
            this.cODVENDA_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODVENDA_FKComboBox.TabIndex = 2;
            this.cODVENDA_FKComboBox.ValueMember = "CODVENDA";
            // 
            // cODPRODUTO_FKComboBox
            // 
            this.cODPRODUTO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENSVENDAPRODUTOBindingSource, "CODPRODUTO_FK", true));
            this.cODPRODUTO_FKComboBox.DataSource = this.pRODUTOBindingSource;
            this.cODPRODUTO_FKComboBox.DisplayMember = "NOMEPRODUTO";
            this.cODPRODUTO_FKComboBox.FormattingEnabled = true;
            this.cODPRODUTO_FKComboBox.Location = new System.Drawing.Point(433, 90);
            this.cODPRODUTO_FKComboBox.Name = "cODPRODUTO_FKComboBox";
            this.cODPRODUTO_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODPRODUTO_FKComboBox.TabIndex = 4;
            this.cODPRODUTO_FKComboBox.ValueMember = "CODPRODUTO";
            // 
            // qUANTIDADETextBox
            // 
            this.qUANTIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENSVENDAPRODUTOBindingSource, "QUANTIDADE", true));
            this.qUANTIDADETextBox.Location = new System.Drawing.Point(121, 46);
            this.qUANTIDADETextBox.Name = "qUANTIDADETextBox";
            this.qUANTIDADETextBox.Size = new System.Drawing.Size(121, 20);
            this.qUANTIDADETextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iTENSVENDAPRODUTODataGridView
            // 
            this.iTENSVENDAPRODUTODataGridView.AutoGenerateColumns = false;
            this.iTENSVENDAPRODUTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iTENSVENDAPRODUTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.iTENSVENDAPRODUTODataGridView.DataSource = this.iTENSVENDAPRODUTOBindingSource;
            this.iTENSVENDAPRODUTODataGridView.Location = new System.Drawing.Point(15, 156);
            this.iTENSVENDAPRODUTODataGridView.Name = "iTENSVENDAPRODUTODataGridView";
            this.iTENSVENDAPRODUTODataGridView.ReadOnly = true;
            this.iTENSVENDAPRODUTODataGridView.Size = new System.Drawing.Size(647, 220);
            this.iTENSVENDAPRODUTODataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "QUANTIDADE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODVENDA_FK";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Venda FK:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CODPRODUTO_FK";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código ProdutoFK:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
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
            // pRODUTOBindingSource
            // 
            this.pRODUTOBindingSource.DataMember = "PRODUTO";
            this.pRODUTOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // pRODUTOTableAdapter
            // 
            this.pRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmItensVendaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.iTENSVENDAPRODUTODataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cODVENDA_FKLabel);
            this.Controls.Add(this.cODVENDA_FKComboBox);
            this.Controls.Add(cODPRODUTO_FKLabel);
            this.Controls.Add(this.cODPRODUTO_FKComboBox);
            this.Controls.Add(qUANTIDADELabel);
            this.Controls.Add(this.qUANTIDADETextBox);
            this.Controls.Add(this.iTENSVENDAPRODUTOBindingNavigator);
            this.Name = "FrmItensVendaProduto";
            this.Text = "FrmItensVendaProduto";
            this.Load += new System.EventHandler(this.FrmItensVendaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSVENDAPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSVENDAPRODUTOBindingNavigator)).EndInit();
            this.iTENSVENDAPRODUTOBindingNavigator.ResumeLayout(false);
            this.iTENSVENDAPRODUTOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSVENDAPRODUTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource iTENSVENDAPRODUTOBindingSource;
        private ATIVIDADEDataSetTableAdapters.ITENSVENDAPRODUTOTableAdapter iTENSVENDAPRODUTOTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iTENSVENDAPRODUTOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iTENSVENDAPRODUTOBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox cODVENDA_FKComboBox;
        private System.Windows.Forms.ComboBox cODPRODUTO_FKComboBox;
        private System.Windows.Forms.TextBox qUANTIDADETextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView iTENSVENDAPRODUTODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource vENDAPRODUTOBindingSource;
        private ATIVIDADEDataSetTableAdapters.VENDAPRODUTOTableAdapter vENDAPRODUTOTableAdapter;
        private System.Windows.Forms.BindingSource pRODUTOBindingSource;
        private ATIVIDADEDataSetTableAdapters.PRODUTOTableAdapter pRODUTOTableAdapter;
    }
}