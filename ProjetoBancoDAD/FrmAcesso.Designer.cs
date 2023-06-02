namespace ProjetoBancoDAD
{
    partial class FrmAcesso
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
            System.Windows.Forms.Label cODACESSOLabel;
            System.Windows.Forms.Label nOMEACESSOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcesso));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.aCESSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCESSOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.ACESSOTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.aCESSOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aCESSOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODACESSOLabel1 = new System.Windows.Forms.Label();
            this.nOMEACESSOTextBox = new System.Windows.Forms.TextBox();
            this.aCESSODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cODACESSOLabel = new System.Windows.Forms.Label();
            nOMEACESSOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCESSOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCESSOBindingNavigator)).BeginInit();
            this.aCESSOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCESSODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cODACESSOLabel
            // 
            cODACESSOLabel.AutoSize = true;
            cODACESSOLabel.Location = new System.Drawing.Point(12, 44);
            cODACESSOLabel.Name = "cODACESSOLabel";
            cODACESSOLabel.Size = new System.Drawing.Size(81, 13);
            cODACESSOLabel.TabIndex = 1;
            cODACESSOLabel.Text = "Código Acesso:";
            // 
            // nOMEACESSOLabel
            // 
            nOMEACESSOLabel.AutoSize = true;
            nOMEACESSOLabel.Location = new System.Drawing.Point(21, 78);
            nOMEACESSOLabel.Name = "nOMEACESSOLabel";
            nOMEACESSOLabel.Size = new System.Drawing.Size(76, 13);
            nOMEACESSOLabel.TabIndex = 3;
            nOMEACESSOLabel.Text = "Nome Acesso:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCESSOBindingSource
            // 
            this.aCESSOBindingSource.DataMember = "ACESSO";
            this.aCESSOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // aCESSOTableAdapter
            // 
            this.aCESSOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = this.aCESSOTableAdapter;
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
            // aCESSOBindingNavigator
            // 
            this.aCESSOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aCESSOBindingNavigator.BindingSource = this.aCESSOBindingSource;
            this.aCESSOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aCESSOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aCESSOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aCESSOBindingNavigatorSaveItem});
            this.aCESSOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aCESSOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aCESSOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aCESSOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aCESSOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aCESSOBindingNavigator.Name = "aCESSOBindingNavigator";
            this.aCESSOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aCESSOBindingNavigator.Size = new System.Drawing.Size(472, 25);
            this.aCESSOBindingNavigator.TabIndex = 0;
            this.aCESSOBindingNavigator.Text = "bindingNavigator1";
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
            // aCESSOBindingNavigatorSaveItem
            // 
            this.aCESSOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aCESSOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aCESSOBindingNavigatorSaveItem.Image")));
            this.aCESSOBindingNavigatorSaveItem.Name = "aCESSOBindingNavigatorSaveItem";
            this.aCESSOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aCESSOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.aCESSOBindingNavigatorSaveItem.Click += new System.EventHandler(this.aCESSOBindingNavigatorSaveItem_Click);
            // 
            // cODACESSOLabel1
            // 
            this.cODACESSOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aCESSOBindingSource, "CODACESSO", true));
            this.cODACESSOLabel1.Location = new System.Drawing.Point(103, 44);
            this.cODACESSOLabel1.Name = "cODACESSOLabel1";
            this.cODACESSOLabel1.Size = new System.Drawing.Size(100, 23);
            this.cODACESSOLabel1.TabIndex = 2;
            this.cODACESSOLabel1.Text = "label1";
            // 
            // nOMEACESSOTextBox
            // 
            this.nOMEACESSOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aCESSOBindingSource, "NOMEACESSO", true));
            this.nOMEACESSOTextBox.Location = new System.Drawing.Point(103, 75);
            this.nOMEACESSOTextBox.Name = "nOMEACESSOTextBox";
            this.nOMEACESSOTextBox.Size = new System.Drawing.Size(363, 20);
            this.nOMEACESSOTextBox.TabIndex = 4;
            // 
            // aCESSODataGridView
            // 
            this.aCESSODataGridView.AutoGenerateColumns = false;
            this.aCESSODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aCESSODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.aCESSODataGridView.DataSource = this.aCESSOBindingSource;
            this.aCESSODataGridView.Location = new System.Drawing.Point(15, 149);
            this.aCESSODataGridView.Name = "aCESSODataGridView";
            this.aCESSODataGridView.ReadOnly = true;
            this.aCESSODataGridView.Size = new System.Drawing.Size(451, 220);
            this.aCESSODataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODACESSO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Acesso";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMEACESSO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Acesso";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // FrmAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 384);
            this.Controls.Add(this.aCESSODataGridView);
            this.Controls.Add(cODACESSOLabel);
            this.Controls.Add(this.cODACESSOLabel1);
            this.Controls.Add(nOMEACESSOLabel);
            this.Controls.Add(this.nOMEACESSOTextBox);
            this.Controls.Add(this.aCESSOBindingNavigator);
            this.Name = "FrmAcesso";
            this.Text = "FrmAcesso";
            this.Load += new System.EventHandler(this.FrmAcesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCESSOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCESSOBindingNavigator)).EndInit();
            this.aCESSOBindingNavigator.ResumeLayout(false);
            this.aCESSOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCESSODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource aCESSOBindingSource;
        private ATIVIDADEDataSetTableAdapters.ACESSOTableAdapter aCESSOTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aCESSOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aCESSOBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODACESSOLabel1;
        private System.Windows.Forms.TextBox nOMEACESSOTextBox;
        private System.Windows.Forms.DataGridView aCESSODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}