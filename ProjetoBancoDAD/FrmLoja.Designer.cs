namespace ProjetoBancoDAD
{
    partial class FrmLoja
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
            System.Windows.Forms.Label cODLOJALabel;
            System.Windows.Forms.Label nOMELOJALabel;
            System.Windows.Forms.Label cNPJLabel;
            System.Windows.Forms.Label nOMEFANTASIALabel;
            System.Windows.Forms.Label rAZAOSOCIALLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoja));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.lOJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOJATableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.LOJATableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.lOJABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lOJABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODLOJALabel1 = new System.Windows.Forms.Label();
            this.nOMELOJATextBox = new System.Windows.Forms.TextBox();
            this.cNPJMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nOMEFANTASIATextBox = new System.Windows.Forms.TextBox();
            this.rAZAOSOCIALTextBox = new System.Windows.Forms.TextBox();
            this.lOJADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cODLOJALabel = new System.Windows.Forms.Label();
            nOMELOJALabel = new System.Windows.Forms.Label();
            cNPJLabel = new System.Windows.Forms.Label();
            nOMEFANTASIALabel = new System.Windows.Forms.Label();
            rAZAOSOCIALLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOJABindingNavigator)).BeginInit();
            this.lOJABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOJADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cODLOJALabel
            // 
            cODLOJALabel.AutoSize = true;
            cODLOJALabel.Location = new System.Drawing.Point(12, 52);
            cODLOJALabel.Name = "cODLOJALabel";
            cODLOJALabel.Size = new System.Drawing.Size(59, 13);
            cODLOJALabel.TabIndex = 1;
            cODLOJALabel.Text = "CODLOJA:";
            // 
            // nOMELOJALabel
            // 
            nOMELOJALabel.AutoSize = true;
            nOMELOJALabel.Location = new System.Drawing.Point(12, 83);
            nOMELOJALabel.Name = "nOMELOJALabel";
            nOMELOJALabel.Size = new System.Drawing.Size(61, 13);
            nOMELOJALabel.TabIndex = 3;
            nOMELOJALabel.Text = "Nome Loja:";
            // 
            // cNPJLabel
            // 
            cNPJLabel.AutoSize = true;
            cNPJLabel.Location = new System.Drawing.Point(43, 111);
            cNPJLabel.Name = "cNPJLabel";
            cNPJLabel.Size = new System.Drawing.Size(37, 13);
            cNPJLabel.TabIndex = 5;
            cNPJLabel.Text = "CNPJ:";
            // 
            // nOMEFANTASIALabel
            // 
            nOMEFANTASIALabel.AutoSize = true;
            nOMEFANTASIALabel.Location = new System.Drawing.Point(246, 83);
            nOMEFANTASIALabel.Name = "nOMEFANTASIALabel";
            nOMEFANTASIALabel.Size = new System.Drawing.Size(81, 13);
            nOMEFANTASIALabel.TabIndex = 7;
            nOMEFANTASIALabel.Text = "Nome Fantasia:";
            // 
            // rAZAOSOCIALLabel
            // 
            rAZAOSOCIALLabel.AutoSize = true;
            rAZAOSOCIALLabel.Location = new System.Drawing.Point(254, 114);
            rAZAOSOCIALLabel.Name = "rAZAOSOCIALLabel";
            rAZAOSOCIALLabel.Size = new System.Drawing.Size(73, 13);
            rAZAOSOCIALLabel.TabIndex = 9;
            rAZAOSOCIALLabel.Text = "Razão Social:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOJABindingSource
            // 
            this.lOJABindingSource.DataMember = "LOJA";
            this.lOJABindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // lOJATableAdapter
            // 
            this.lOJATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ITENSACESSOLOGINTableAdapter = null;
            this.tableAdapterManager.ITENSCOMPRAPRODUTOTableAdapter = null;
            this.tableAdapterManager.ITENSTELCLIENTETableAdapter = null;
            this.tableAdapterManager.ITENSTELEFONEFORNECEDORTableAdapter = null;
            this.tableAdapterManager.ITENSTELEFONEFUNCIONARIOTableAdapter = null;
            this.tableAdapterManager.ITENSTELEFONELOJATableAdapter = null;
            this.tableAdapterManager.ITENSTELEFONETRABALHOTableAdapter = null;
            this.tableAdapterManager.ITENSVENDAPRODUTOTableAdapter = null;
            this.tableAdapterManager.LOGINTableAdapter = null;
            this.tableAdapterManager.LOJATableAdapter = this.lOJATableAdapter;
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
            // lOJABindingNavigator
            // 
            this.lOJABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lOJABindingNavigator.BindingSource = this.lOJABindingSource;
            this.lOJABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lOJABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lOJABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lOJABindingNavigatorSaveItem});
            this.lOJABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lOJABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lOJABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lOJABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lOJABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lOJABindingNavigator.Name = "lOJABindingNavigator";
            this.lOJABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lOJABindingNavigator.Size = new System.Drawing.Size(1067, 25);
            this.lOJABindingNavigator.TabIndex = 0;
            this.lOJABindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // lOJABindingNavigatorSaveItem
            // 
            this.lOJABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lOJABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lOJABindingNavigatorSaveItem.Image")));
            this.lOJABindingNavigatorSaveItem.Name = "lOJABindingNavigatorSaveItem";
            this.lOJABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lOJABindingNavigatorSaveItem.Text = "Salvar Dados";
            this.lOJABindingNavigatorSaveItem.Click += new System.EventHandler(this.lOJABindingNavigatorSaveItem_Click);
            // 
            // cODLOJALabel1
            // 
            this.cODLOJALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOJABindingSource, "CODLOJA", true));
            this.cODLOJALabel1.Location = new System.Drawing.Point(112, 52);
            this.cODLOJALabel1.Name = "cODLOJALabel1";
            this.cODLOJALabel1.Size = new System.Drawing.Size(100, 23);
            this.cODLOJALabel1.TabIndex = 2;
            this.cODLOJALabel1.Text = "label1";
            // 
            // nOMELOJATextBox
            // 
            this.nOMELOJATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOJABindingSource, "NOMELOJA", true));
            this.nOMELOJATextBox.Location = new System.Drawing.Point(86, 80);
            this.nOMELOJATextBox.Name = "nOMELOJATextBox";
            this.nOMELOJATextBox.Size = new System.Drawing.Size(109, 20);
            this.nOMELOJATextBox.TabIndex = 4;
            // 
            // cNPJMaskedTextBox
            // 
            this.cNPJMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOJABindingSource, "CNPJ", true));
            this.cNPJMaskedTextBox.Location = new System.Drawing.Point(86, 111);
            this.cNPJMaskedTextBox.Mask = "00.000.000/0000-00";
            this.cNPJMaskedTextBox.Name = "cNPJMaskedTextBox";
            this.cNPJMaskedTextBox.Size = new System.Drawing.Size(109, 20);
            this.cNPJMaskedTextBox.TabIndex = 6;
            // 
            // nOMEFANTASIATextBox
            // 
            this.nOMEFANTASIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOJABindingSource, "NOMEFANTASIA", true));
            this.nOMEFANTASIATextBox.Location = new System.Drawing.Point(333, 80);
            this.nOMEFANTASIATextBox.Name = "nOMEFANTASIATextBox";
            this.nOMEFANTASIATextBox.Size = new System.Drawing.Size(100, 20);
            this.nOMEFANTASIATextBox.TabIndex = 8;
            // 
            // rAZAOSOCIALTextBox
            // 
            this.rAZAOSOCIALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOJABindingSource, "RAZAOSOCIAL", true));
            this.rAZAOSOCIALTextBox.Location = new System.Drawing.Point(333, 111);
            this.rAZAOSOCIALTextBox.Name = "rAZAOSOCIALTextBox";
            this.rAZAOSOCIALTextBox.Size = new System.Drawing.Size(100, 20);
            this.rAZAOSOCIALTextBox.TabIndex = 10;
            // 
            // lOJADataGridView
            // 
            this.lOJADataGridView.AutoGenerateColumns = false;
            this.lOJADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lOJADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.lOJADataGridView.DataSource = this.lOJABindingSource;
            this.lOJADataGridView.Location = new System.Drawing.Point(15, 188);
            this.lOJADataGridView.Name = "lOJADataGridView";
            this.lOJADataGridView.ReadOnly = true;
            this.lOJADataGridView.Size = new System.Drawing.Size(1048, 220);
            this.lOJADataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODLOJA";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Loja";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMELOJA";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Loja";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CNPJ";
            this.dataGridViewTextBoxColumn3.HeaderText = "CNPJ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NOMEFANTASIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nome Fantasia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RAZAOSOCIAL";
            this.dataGridViewTextBoxColumn5.HeaderText = "Razão Social";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // FrmLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 424);
            this.Controls.Add(this.lOJADataGridView);
            this.Controls.Add(cODLOJALabel);
            this.Controls.Add(this.cODLOJALabel1);
            this.Controls.Add(nOMELOJALabel);
            this.Controls.Add(this.nOMELOJATextBox);
            this.Controls.Add(cNPJLabel);
            this.Controls.Add(this.cNPJMaskedTextBox);
            this.Controls.Add(nOMEFANTASIALabel);
            this.Controls.Add(this.nOMEFANTASIATextBox);
            this.Controls.Add(rAZAOSOCIALLabel);
            this.Controls.Add(this.rAZAOSOCIALTextBox);
            this.Controls.Add(this.lOJABindingNavigator);
            this.Name = "FrmLoja";
            this.Text = "FrmLoja";
            this.Load += new System.EventHandler(this.FrmLoja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOJABindingNavigator)).EndInit();
            this.lOJABindingNavigator.ResumeLayout(false);
            this.lOJABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOJADataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource lOJABindingSource;
        private ATIVIDADEDataSetTableAdapters.LOJATableAdapter lOJATableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lOJABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lOJABindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODLOJALabel1;
        private System.Windows.Forms.TextBox nOMELOJATextBox;
        private System.Windows.Forms.MaskedTextBox cNPJMaskedTextBox;
        private System.Windows.Forms.TextBox nOMEFANTASIATextBox;
        private System.Windows.Forms.TextBox rAZAOSOCIALTextBox;
        private System.Windows.Forms.DataGridView lOJADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}