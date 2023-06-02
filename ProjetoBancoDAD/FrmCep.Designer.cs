namespace ProjetoBancoDAD
{
    partial class FrmCep
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
            System.Windows.Forms.Label cODCEPLabel;
            System.Windows.Forms.Label nUMEROCEPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCep));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.cEPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cEPTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.CEPTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.cEPBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cODCEPLabel1 = new System.Windows.Forms.Label();
            this.nUMEROCEPMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.cEPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cEPDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cODCEPLabel = new System.Windows.Forms.Label();
            nUMEROCEPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEPBindingNavigator)).BeginInit();
            this.cEPBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cEPDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cEPBindingSource
            // 
            this.cEPBindingSource.DataMember = "CEP";
            this.cEPBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // cEPTableAdapter
            // 
            this.cEPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAIRROTableAdapter = null;
            this.tableAdapterManager.CEPTableAdapter = this.cEPTableAdapter;
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
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // cEPBindingNavigator
            // 
            this.cEPBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cEPBindingNavigator.BindingSource = this.cEPBindingSource;
            this.cEPBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cEPBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cEPBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cEPBindingNavigatorSaveItem});
            this.cEPBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cEPBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cEPBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cEPBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cEPBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cEPBindingNavigator.Name = "cEPBindingNavigator";
            this.cEPBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cEPBindingNavigator.Size = new System.Drawing.Size(510, 25);
            this.cEPBindingNavigator.TabIndex = 0;
            this.cEPBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cODCEPLabel
            // 
            cODCEPLabel.AutoSize = true;
            cODCEPLabel.Location = new System.Drawing.Point(49, 67);
            cODCEPLabel.Name = "cODCEPLabel";
            cODCEPLabel.Size = new System.Drawing.Size(67, 13);
            cODCEPLabel.TabIndex = 1;
            cODCEPLabel.Text = "Código CEP:";
            // 
            // cODCEPLabel1
            // 
            this.cODCEPLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cEPBindingSource, "CODCEP", true));
            this.cODCEPLabel1.Location = new System.Drawing.Point(134, 67);
            this.cODCEPLabel1.Name = "cODCEPLabel1";
            this.cODCEPLabel1.Size = new System.Drawing.Size(100, 23);
            this.cODCEPLabel1.TabIndex = 2;
            this.cODCEPLabel1.Text = "label1";
            // 
            // nUMEROCEPLabel
            // 
            nUMEROCEPLabel.AutoSize = true;
            nUMEROCEPLabel.Location = new System.Drawing.Point(49, 96);
            nUMEROCEPLabel.Name = "nUMEROCEPLabel";
            nUMEROCEPLabel.Size = new System.Drawing.Size(71, 13);
            nUMEROCEPLabel.TabIndex = 3;
            nUMEROCEPLabel.Text = "Número CEP:";
            // 
            // nUMEROCEPMaskedTextBox
            // 
            this.nUMEROCEPMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cEPBindingSource, "NUMEROCEP", true));
            this.nUMEROCEPMaskedTextBox.Location = new System.Drawing.Point(126, 93);
            this.nUMEROCEPMaskedTextBox.Mask = "00000-000";
            this.nUMEROCEPMaskedTextBox.Name = "nUMEROCEPMaskedTextBox";
            this.nUMEROCEPMaskedTextBox.Size = new System.Drawing.Size(70, 20);
            this.nUMEROCEPMaskedTextBox.TabIndex = 4;
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
            // cEPBindingNavigatorSaveItem
            // 
            this.cEPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cEPBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cEPBindingNavigatorSaveItem.Image")));
            this.cEPBindingNavigatorSaveItem.Name = "cEPBindingNavigatorSaveItem";
            this.cEPBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cEPBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cEPBindingNavigatorSaveItem.Click += new System.EventHandler(this.cEPBindingNavigatorSaveItem_Click);
            // 
            // cEPDataGridView
            // 
            this.cEPDataGridView.AutoGenerateColumns = false;
            this.cEPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cEPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.cEPDataGridView.DataSource = this.cEPBindingSource;
            this.cEPDataGridView.Location = new System.Drawing.Point(52, 159);
            this.cEPDataGridView.Name = "cEPDataGridView";
            this.cEPDataGridView.Size = new System.Drawing.Size(450, 220);
            this.cEPDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODCEP";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código CEP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NUMEROCEP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Número CEP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // FrmCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 400);
            this.Controls.Add(this.cEPDataGridView);
            this.Controls.Add(cODCEPLabel);
            this.Controls.Add(this.cODCEPLabel1);
            this.Controls.Add(nUMEROCEPLabel);
            this.Controls.Add(this.nUMEROCEPMaskedTextBox);
            this.Controls.Add(this.cEPBindingNavigator);
            this.Name = "FrmCep";
            this.Text = "FrmCep";
            this.Load += new System.EventHandler(this.FrmCep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEPBindingNavigator)).EndInit();
            this.cEPBindingNavigator.ResumeLayout(false);
            this.cEPBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cEPDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource cEPBindingSource;
        private ATIVIDADEDataSetTableAdapters.CEPTableAdapter cEPTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cEPBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cEPBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODCEPLabel1;
        private System.Windows.Forms.MaskedTextBox nUMEROCEPMaskedTextBox;
        private System.Windows.Forms.DataGridView cEPDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}