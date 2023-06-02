namespace ProjetoBancoDAD
{
    partial class FrmCidade
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
            System.Windows.Forms.Label cODCIDADELabel;
            System.Windows.Forms.Label nOMECIDADELabel;
            System.Windows.Forms.Label cODUF_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCidade));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.cIDADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cIDADETableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.CIDADETableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.cIDADEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cIDADEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODCIDADELabel1 = new System.Windows.Forms.Label();
            this.nOMECIDADETextBox = new System.Windows.Forms.TextBox();
            this.cODUF_FKComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cIDADEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uFTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.UFTableAdapter();
            cODCIDADELabel = new System.Windows.Forms.Label();
            nOMECIDADELabel = new System.Windows.Forms.Label();
            cODUF_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingNavigator)).BeginInit();
            this.cIDADEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uFBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODCIDADELabel
            // 
            cODCIDADELabel.AutoSize = true;
            cODCIDADELabel.Location = new System.Drawing.Point(38, 66);
            cODCIDADELabel.Name = "cODCIDADELabel";
            cODCIDADELabel.Size = new System.Drawing.Size(79, 13);
            cODCIDADELabel.TabIndex = 1;
            cODCIDADELabel.Text = "Código Cidade:";
            // 
            // nOMECIDADELabel
            // 
            nOMECIDADELabel.AutoSize = true;
            nOMECIDADELabel.Location = new System.Drawing.Point(38, 95);
            nOMECIDADELabel.Name = "nOMECIDADELabel";
            nOMECIDADELabel.Size = new System.Drawing.Size(74, 13);
            nOMECIDADELabel.TabIndex = 3;
            nOMECIDADELabel.Text = "Nome Cidade:";
            // 
            // cODUF_FKLabel
            // 
            cODUF_FKLabel.AutoSize = true;
            cODUF_FKLabel.Location = new System.Drawing.Point(44, 132);
            cODUF_FKLabel.Name = "cODUF_FKLabel";
            cODUF_FKLabel.Size = new System.Drawing.Size(67, 13);
            cODUF_FKLabel.TabIndex = 5;
            cODUF_FKLabel.Text = "Código UfFK";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cIDADEBindingSource
            // 
            this.cIDADEBindingSource.DataMember = "CIDADE";
            this.cIDADEBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // cIDADETableAdapter
            // 
            this.cIDADETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAIRROTableAdapter = null;
            this.tableAdapterManager.CEPTableAdapter = null;
            this.tableAdapterManager.CIDADETableAdapter = this.cIDADETableAdapter;
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
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // cIDADEBindingNavigator
            // 
            this.cIDADEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cIDADEBindingNavigator.BindingSource = this.cIDADEBindingSource;
            this.cIDADEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cIDADEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cIDADEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cIDADEBindingNavigatorSaveItem});
            this.cIDADEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cIDADEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cIDADEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cIDADEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cIDADEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cIDADEBindingNavigator.Name = "cIDADEBindingNavigator";
            this.cIDADEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cIDADEBindingNavigator.Size = new System.Drawing.Size(411, 25);
            this.cIDADEBindingNavigator.TabIndex = 0;
            this.cIDADEBindingNavigator.Text = "bindingNavigator1";
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
            // cIDADEBindingNavigatorSaveItem
            // 
            this.cIDADEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cIDADEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cIDADEBindingNavigatorSaveItem.Image")));
            this.cIDADEBindingNavigatorSaveItem.Name = "cIDADEBindingNavigatorSaveItem";
            this.cIDADEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cIDADEBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cIDADEBindingNavigatorSaveItem.Click += new System.EventHandler(this.cIDADEBindingNavigatorSaveItem_Click);
            // 
            // cODCIDADELabel1
            // 
            this.cODCIDADELabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cIDADEBindingSource, "CODCIDADE", true));
            this.cODCIDADELabel1.Location = new System.Drawing.Point(117, 66);
            this.cODCIDADELabel1.Name = "cODCIDADELabel1";
            this.cODCIDADELabel1.Size = new System.Drawing.Size(121, 23);
            this.cODCIDADELabel1.TabIndex = 2;
            this.cODCIDADELabel1.Text = "label1";
            // 
            // nOMECIDADETextBox
            // 
            this.nOMECIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cIDADEBindingSource, "NOMECIDADE", true));
            this.nOMECIDADETextBox.Location = new System.Drawing.Point(117, 92);
            this.nOMECIDADETextBox.Name = "nOMECIDADETextBox";
            this.nOMECIDADETextBox.Size = new System.Drawing.Size(239, 20);
            this.nOMECIDADETextBox.TabIndex = 4;
            // 
            // cODUF_FKComboBox
            // 
            this.cODUF_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cIDADEBindingSource, "CODUF_FK", true));
            this.cODUF_FKComboBox.DataSource = this.uFBindingSource;
            this.cODUF_FKComboBox.DisplayMember = "NOMEUF";
            this.cODUF_FKComboBox.FormattingEnabled = true;
            this.cODUF_FKComboBox.Location = new System.Drawing.Point(117, 127);
            this.cODUF_FKComboBox.Name = "cODUF_FKComboBox";
            this.cODUF_FKComboBox.Size = new System.Drawing.Size(239, 21);
            this.cODUF_FKComboBox.TabIndex = 6;
            this.cODUF_FKComboBox.ValueMember = "CODUF";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cIDADEDataGridView
            // 
            this.cIDADEDataGridView.AutoGenerateColumns = false;
            this.cIDADEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cIDADEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.cIDADEDataGridView.DataSource = this.cIDADEBindingSource;
            this.cIDADEDataGridView.Location = new System.Drawing.Point(41, 182);
            this.cIDADEDataGridView.Name = "cIDADEDataGridView";
            this.cIDADEDataGridView.ReadOnly = true;
            this.cIDADEDataGridView.Size = new System.Drawing.Size(360, 220);
            this.cIDADEDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODCIDADE";
            this.dataGridViewTextBoxColumn1.HeaderText = "CODCIDADE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMECIDADE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMECIDADE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CODUF_FK";
            this.dataGridViewTextBoxColumn3.HeaderText = "CODUF_FK";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // uFBindingSource
            // 
            this.uFBindingSource.DataMember = "UF";
            this.uFBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // uFTableAdapter
            // 
            this.uFTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 413);
            this.Controls.Add(this.cIDADEDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(cODCIDADELabel);
            this.Controls.Add(this.cODCIDADELabel1);
            this.Controls.Add(nOMECIDADELabel);
            this.Controls.Add(this.nOMECIDADETextBox);
            this.Controls.Add(cODUF_FKLabel);
            this.Controls.Add(this.cODUF_FKComboBox);
            this.Controls.Add(this.cIDADEBindingNavigator);
            this.Name = "FrmCidade";
            this.Text = "FrmCidade";
            this.Load += new System.EventHandler(this.FrmCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingNavigator)).EndInit();
            this.cIDADEBindingNavigator.ResumeLayout(false);
            this.cIDADEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uFBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource cIDADEBindingSource;
        private ATIVIDADEDataSetTableAdapters.CIDADETableAdapter cIDADETableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cIDADEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cIDADEBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODCIDADELabel1;
        private System.Windows.Forms.TextBox nOMECIDADETextBox;
        private System.Windows.Forms.ComboBox cODUF_FKComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView cIDADEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource uFBindingSource;
        private ATIVIDADEDataSetTableAdapters.UFTableAdapter uFTableAdapter;
    }
}