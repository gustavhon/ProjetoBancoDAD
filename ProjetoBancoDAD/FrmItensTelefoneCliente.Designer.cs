namespace ProjetoBancoDAD
{
    partial class FrmItensTelefoneCliente
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
            System.Windows.Forms.Label cODTELEFONE_FKLabel;
            System.Windows.Forms.Label cODCLIENTE_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensTelefoneCliente));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.iTENSTELCLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENSTELCLIENTETableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.ITENSTELCLIENTETableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.iTENSTELCLIENTEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iTENSTELCLIENTEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODTELEFONE_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cODCLIENTE_FKComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.iTENSTELCLIENTEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tELEFONETableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TELEFONETableAdapter();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.CLIENTETableAdapter();
            cODTELEFONE_FKLabel = new System.Windows.Forms.Label();
            cODCLIENTE_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELCLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELCLIENTEBindingNavigator)).BeginInit();
            this.iTENSTELCLIENTEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELCLIENTEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODTELEFONE_FKLabel
            // 
            cODTELEFONE_FKLabel.AutoSize = true;
            cODTELEFONE_FKLabel.Location = new System.Drawing.Point(15, 49);
            cODTELEFONE_FKLabel.Name = "cODTELEFONE_FKLabel";
            cODTELEFONE_FKLabel.Size = new System.Drawing.Size(101, 13);
            cODTELEFONE_FKLabel.TabIndex = 1;
            cODTELEFONE_FKLabel.Text = "Código TelefoneFK:";
            // 
            // cODCLIENTE_FKLabel
            // 
            cODCLIENTE_FKLabel.AutoSize = true;
            cODCLIENTE_FKLabel.Location = new System.Drawing.Point(315, 51);
            cODCLIENTE_FKLabel.Name = "cODCLIENTE_FKLabel";
            cODCLIENTE_FKLabel.Size = new System.Drawing.Size(91, 13);
            cODCLIENTE_FKLabel.TabIndex = 3;
            cODCLIENTE_FKLabel.Text = "Código ClienteFK:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTENSTELCLIENTEBindingSource
            // 
            this.iTENSTELCLIENTEBindingSource.DataMember = "ITENSTELCLIENTE";
            this.iTENSTELCLIENTEBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // iTENSTELCLIENTETableAdapter
            // 
            this.iTENSTELCLIENTETableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ITENSTELCLIENTETableAdapter = this.iTENSTELCLIENTETableAdapter;
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
            // iTENSTELCLIENTEBindingNavigator
            // 
            this.iTENSTELCLIENTEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTENSTELCLIENTEBindingNavigator.BindingSource = this.iTENSTELCLIENTEBindingSource;
            this.iTENSTELCLIENTEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTENSTELCLIENTEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTENSTELCLIENTEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iTENSTELCLIENTEBindingNavigatorSaveItem});
            this.iTENSTELCLIENTEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTENSTELCLIENTEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTENSTELCLIENTEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTENSTELCLIENTEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTENSTELCLIENTEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTENSTELCLIENTEBindingNavigator.Name = "iTENSTELCLIENTEBindingNavigator";
            this.iTENSTELCLIENTEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTENSTELCLIENTEBindingNavigator.Size = new System.Drawing.Size(603, 25);
            this.iTENSTELCLIENTEBindingNavigator.TabIndex = 0;
            this.iTENSTELCLIENTEBindingNavigator.Text = "bindingNavigator1";
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
            // iTENSTELCLIENTEBindingNavigatorSaveItem
            // 
            this.iTENSTELCLIENTEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTENSTELCLIENTEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iTENSTELCLIENTEBindingNavigatorSaveItem.Image")));
            this.iTENSTELCLIENTEBindingNavigatorSaveItem.Name = "iTENSTELCLIENTEBindingNavigatorSaveItem";
            this.iTENSTELCLIENTEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iTENSTELCLIENTEBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.iTENSTELCLIENTEBindingNavigatorSaveItem.Click += new System.EventHandler(this.iTENSTELCLIENTEBindingNavigatorSaveItem_Click);
            // 
            // cODTELEFONE_FKComboBox
            // 
            this.cODTELEFONE_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENSTELCLIENTEBindingSource, "CODTELEFONE_FK", true));
            this.cODTELEFONE_FKComboBox.DataSource = this.tELEFONEBindingSource;
            this.cODTELEFONE_FKComboBox.DisplayMember = "NUMERO";
            this.cODTELEFONE_FKComboBox.FormattingEnabled = true;
            this.cODTELEFONE_FKComboBox.Location = new System.Drawing.Point(123, 45);
            this.cODTELEFONE_FKComboBox.Name = "cODTELEFONE_FKComboBox";
            this.cODTELEFONE_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODTELEFONE_FKComboBox.TabIndex = 2;
            this.cODTELEFONE_FKComboBox.ValueMember = "CODTELEFONE";
            // 
            // cODCLIENTE_FKComboBox
            // 
            this.cODCLIENTE_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENSTELCLIENTEBindingSource, "CODCLIENTE_FK", true));
            this.cODCLIENTE_FKComboBox.DataSource = this.cLIENTEBindingSource;
            this.cODCLIENTE_FKComboBox.DisplayMember = "NOMECLIENTE";
            this.cODCLIENTE_FKComboBox.FormattingEnabled = true;
            this.cODCLIENTE_FKComboBox.Location = new System.Drawing.Point(412, 47);
            this.cODCLIENTE_FKComboBox.Name = "cODCLIENTE_FKComboBox";
            this.cODCLIENTE_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODCLIENTE_FKComboBox.TabIndex = 4;
            this.cODCLIENTE_FKComboBox.ValueMember = "CODCLIENTE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iTENSTELCLIENTEDataGridView
            // 
            this.iTENSTELCLIENTEDataGridView.AutoGenerateColumns = false;
            this.iTENSTELCLIENTEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iTENSTELCLIENTEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.iTENSTELCLIENTEDataGridView.DataSource = this.iTENSTELCLIENTEBindingSource;
            this.iTENSTELCLIENTEDataGridView.Location = new System.Drawing.Point(18, 92);
            this.iTENSTELCLIENTEDataGridView.Name = "iTENSTELCLIENTEDataGridView";
            this.iTENSTELCLIENTEDataGridView.Size = new System.Drawing.Size(577, 220);
            this.iTENSTELCLIENTEDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CODTELEFONE_FK";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código TelefoneFK";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CODCLIENTE_FK";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código ClienteFK";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 280;
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
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // FrmItensTelefoneCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 335);
            this.Controls.Add(this.iTENSTELCLIENTEDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cODTELEFONE_FKLabel);
            this.Controls.Add(this.cODTELEFONE_FKComboBox);
            this.Controls.Add(cODCLIENTE_FKLabel);
            this.Controls.Add(this.cODCLIENTE_FKComboBox);
            this.Controls.Add(this.iTENSTELCLIENTEBindingNavigator);
            this.Name = "FrmItensTelefoneCliente";
            this.Text = "FrmItensTelefoneCliente";
            this.Load += new System.EventHandler(this.FrmItensTelefoneCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELCLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELCLIENTEBindingNavigator)).EndInit();
            this.iTENSTELCLIENTEBindingNavigator.ResumeLayout(false);
            this.iTENSTELCLIENTEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELCLIENTEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource iTENSTELCLIENTEBindingSource;
        private ATIVIDADEDataSetTableAdapters.ITENSTELCLIENTETableAdapter iTENSTELCLIENTETableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iTENSTELCLIENTEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iTENSTELCLIENTEBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox cODTELEFONE_FKComboBox;
        private System.Windows.Forms.ComboBox cODCLIENTE_FKComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView iTENSTELCLIENTEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource tELEFONEBindingSource;
        private ATIVIDADEDataSetTableAdapters.TELEFONETableAdapter tELEFONETableAdapter;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private ATIVIDADEDataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
    }
}