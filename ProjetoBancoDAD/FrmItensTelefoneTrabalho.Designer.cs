namespace ProjetoBancoDAD
{
    partial class FrmItensTelefoneTrabalho
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
            System.Windows.Forms.Label cODTRABALHO_FKLabel;
            System.Windows.Forms.Label cODTELEFONE_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensTelefoneTrabalho));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.iTENSTELEFONETRABALHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENSTELEFONETRABALHOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.ITENSTELEFONETRABALHOTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.iTENSTELEFONETRABALHOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iTENSTELEFONETRABALHOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODTRABALHO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cODTELEFONE_FKComboBox = new System.Windows.Forms.ComboBox();
            this.iTENSTELEFONETRABALHODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tRABALHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRABALHOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TRABALHOTableAdapter();
            this.tELEFONEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tELEFONETableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TELEFONETableAdapter();
            cODTRABALHO_FKLabel = new System.Windows.Forms.Label();
            cODTELEFONE_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONETRABALHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONETRABALHOBindingNavigator)).BeginInit();
            this.iTENSTELEFONETRABALHOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONETRABALHODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODTRABALHO_FKLabel
            // 
            cODTRABALHO_FKLabel.AutoSize = true;
            cODTRABALHO_FKLabel.Location = new System.Drawing.Point(9, 55);
            cODTRABALHO_FKLabel.Name = "cODTRABALHO_FKLabel";
            cODTRABALHO_FKLabel.Size = new System.Drawing.Size(101, 13);
            cODTRABALHO_FKLabel.TabIndex = 1;
            cODTRABALHO_FKLabel.Text = "Código TrabalhoFK:";
            // 
            // cODTELEFONE_FKLabel
            // 
            cODTELEFONE_FKLabel.AutoSize = true;
            cODTELEFONE_FKLabel.Location = new System.Drawing.Point(311, 57);
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
            // iTENSTELEFONETRABALHOBindingSource
            // 
            this.iTENSTELEFONETRABALHOBindingSource.DataMember = "ITENSTELEFONETRABALHO";
            this.iTENSTELEFONETRABALHOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // iTENSTELEFONETRABALHOTableAdapter
            // 
            this.iTENSTELEFONETRABALHOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ITENSTELEFONETRABALHOTableAdapter = this.iTENSTELEFONETRABALHOTableAdapter;
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
            // iTENSTELEFONETRABALHOBindingNavigator
            // 
            this.iTENSTELEFONETRABALHOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTENSTELEFONETRABALHOBindingNavigator.BindingSource = this.iTENSTELEFONETRABALHOBindingSource;
            this.iTENSTELEFONETRABALHOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTENSTELEFONETRABALHOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTENSTELEFONETRABALHOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iTENSTELEFONETRABALHOBindingNavigatorSaveItem});
            this.iTENSTELEFONETRABALHOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTENSTELEFONETRABALHOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTENSTELEFONETRABALHOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTENSTELEFONETRABALHOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTENSTELEFONETRABALHOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTENSTELEFONETRABALHOBindingNavigator.Name = "iTENSTELEFONETRABALHOBindingNavigator";
            this.iTENSTELEFONETRABALHOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTENSTELEFONETRABALHOBindingNavigator.Size = new System.Drawing.Size(617, 25);
            this.iTENSTELEFONETRABALHOBindingNavigator.TabIndex = 0;
            this.iTENSTELEFONETRABALHOBindingNavigator.Text = "bindingNavigator1";
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
            // iTENSTELEFONETRABALHOBindingNavigatorSaveItem
            // 
            this.iTENSTELEFONETRABALHOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTENSTELEFONETRABALHOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iTENSTELEFONETRABALHOBindingNavigatorSaveItem.Image")));
            this.iTENSTELEFONETRABALHOBindingNavigatorSaveItem.Name = "iTENSTELEFONETRABALHOBindingNavigatorSaveItem";
            this.iTENSTELEFONETRABALHOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iTENSTELEFONETRABALHOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.iTENSTELEFONETRABALHOBindingNavigatorSaveItem.Click += new System.EventHandler(this.iTENSTELEFONETRABALHOBindingNavigatorSaveItem_Click);
            // 
            // cODTRABALHO_FKComboBox
            // 
            this.cODTRABALHO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENSTELEFONETRABALHOBindingSource, "CODTRABALHO_FK", true));
            this.cODTRABALHO_FKComboBox.DataSource = this.tRABALHOBindingSource;
            this.cODTRABALHO_FKComboBox.DisplayMember = "NOMETRABALHO";
            this.cODTRABALHO_FKComboBox.FormattingEnabled = true;
            this.cODTRABALHO_FKComboBox.Location = new System.Drawing.Point(122, 52);
            this.cODTRABALHO_FKComboBox.Name = "cODTRABALHO_FKComboBox";
            this.cODTRABALHO_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODTRABALHO_FKComboBox.TabIndex = 2;
            this.cODTRABALHO_FKComboBox.ValueMember = "CODTRABALHO";
            // 
            // cODTELEFONE_FKComboBox
            // 
            this.cODTELEFONE_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENSTELEFONETRABALHOBindingSource, "CODTELEFONE_FK", true));
            this.cODTELEFONE_FKComboBox.DataSource = this.tELEFONEBindingSource;
            this.cODTELEFONE_FKComboBox.DisplayMember = "NUMERO";
            this.cODTELEFONE_FKComboBox.FormattingEnabled = true;
            this.cODTELEFONE_FKComboBox.Location = new System.Drawing.Point(419, 53);
            this.cODTELEFONE_FKComboBox.Name = "cODTELEFONE_FKComboBox";
            this.cODTELEFONE_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODTELEFONE_FKComboBox.TabIndex = 4;
            this.cODTELEFONE_FKComboBox.ValueMember = "CODTELEFONE";
            // 
            // iTENSTELEFONETRABALHODataGridView
            // 
            this.iTENSTELEFONETRABALHODataGridView.AutoGenerateColumns = false;
            this.iTENSTELEFONETRABALHODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iTENSTELEFONETRABALHODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.iTENSTELEFONETRABALHODataGridView.DataSource = this.iTENSTELEFONETRABALHOBindingSource;
            this.iTENSTELEFONETRABALHODataGridView.Location = new System.Drawing.Point(12, 83);
            this.iTENSTELEFONETRABALHODataGridView.Name = "iTENSTELEFONETRABALHODataGridView";
            this.iTENSTELEFONETRABALHODataGridView.ReadOnly = true;
            this.iTENSTELEFONETRABALHODataGridView.Size = new System.Drawing.Size(592, 220);
            this.iTENSTELEFONETRABALHODataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODTRABALHO_FK";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código TrabalhoFK";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 290;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CODTELEFONE_FK";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código TelefoneFK";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 255;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // tELEFONEBindingSource
            // 
            this.tELEFONEBindingSource.DataMember = "TELEFONE";
            this.tELEFONEBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // tELEFONETableAdapter
            // 
            this.tELEFONETableAdapter.ClearBeforeFill = true;
            // 
            // FrmItensTelefoneTrabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 321);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iTENSTELEFONETRABALHODataGridView);
            this.Controls.Add(cODTRABALHO_FKLabel);
            this.Controls.Add(this.cODTRABALHO_FKComboBox);
            this.Controls.Add(cODTELEFONE_FKLabel);
            this.Controls.Add(this.cODTELEFONE_FKComboBox);
            this.Controls.Add(this.iTENSTELEFONETRABALHOBindingNavigator);
            this.Name = "FrmItensTelefoneTrabalho";
            this.Text = "FrmItensTelefoneTrabalho";
            this.Load += new System.EventHandler(this.FrmItensTelefoneTrabalho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONETRABALHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONETRABALHOBindingNavigator)).EndInit();
            this.iTENSTELEFONETRABALHOBindingNavigator.ResumeLayout(false);
            this.iTENSTELEFONETRABALHOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONETRABALHODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource iTENSTELEFONETRABALHOBindingSource;
        private ATIVIDADEDataSetTableAdapters.ITENSTELEFONETRABALHOTableAdapter iTENSTELEFONETRABALHOTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iTENSTELEFONETRABALHOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iTENSTELEFONETRABALHOBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox cODTRABALHO_FKComboBox;
        private System.Windows.Forms.ComboBox cODTELEFONE_FKComboBox;
        private System.Windows.Forms.DataGridView iTENSTELEFONETRABALHODataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource tRABALHOBindingSource;
        private ATIVIDADEDataSetTableAdapters.TRABALHOTableAdapter tRABALHOTableAdapter;
        private System.Windows.Forms.BindingSource tELEFONEBindingSource;
        private ATIVIDADEDataSetTableAdapters.TELEFONETableAdapter tELEFONETableAdapter;
    }
}