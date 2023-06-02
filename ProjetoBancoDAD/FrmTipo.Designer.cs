namespace ProjetoBancoDAD
{
    partial class FrmTipo
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
            System.Windows.Forms.Label cODTIPOLabel;
            System.Windows.Forms.Label nOMETIPOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipo));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.tIPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TIPOTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.tIPOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tIPOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODTIPOLabel1 = new System.Windows.Forms.Label();
            this.nOMETIPOTextBox = new System.Windows.Forms.TextBox();
            this.tIPODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cODTIPOLabel = new System.Windows.Forms.Label();
            nOMETIPOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingNavigator)).BeginInit();
            this.tIPOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIPODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cODTIPOLabel
            // 
            cODTIPOLabel.AutoSize = true;
            cODTIPOLabel.Location = new System.Drawing.Point(12, 89);
            cODTIPOLabel.Name = "cODTIPOLabel";
            cODTIPOLabel.Size = new System.Drawing.Size(67, 13);
            cODTIPOLabel.TabIndex = 1;
            cODTIPOLabel.Text = "Código Tipo:";
            // 
            // nOMETIPOLabel
            // 
            nOMETIPOLabel.AutoSize = true;
            nOMETIPOLabel.Location = new System.Drawing.Point(12, 123);
            nOMETIPOLabel.Name = "nOMETIPOLabel";
            nOMETIPOLabel.Size = new System.Drawing.Size(62, 13);
            nOMETIPOLabel.TabIndex = 3;
            nOMETIPOLabel.Text = "Nome Tipo:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIPOBindingSource
            // 
            this.tIPOBindingSource.DataMember = "TIPO";
            this.tIPOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // tIPOTableAdapter
            // 
            this.tIPOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = this.tIPOTableAdapter;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // tIPOBindingNavigator
            // 
            this.tIPOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tIPOBindingNavigator.BindingSource = this.tIPOBindingSource;
            this.tIPOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tIPOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tIPOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tIPOBindingNavigatorSaveItem});
            this.tIPOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tIPOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tIPOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tIPOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tIPOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tIPOBindingNavigator.Name = "tIPOBindingNavigator";
            this.tIPOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tIPOBindingNavigator.Size = new System.Drawing.Size(480, 25);
            this.tIPOBindingNavigator.TabIndex = 0;
            this.tIPOBindingNavigator.Text = "bindingNavigator1";
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
            // tIPOBindingNavigatorSaveItem
            // 
            this.tIPOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tIPOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tIPOBindingNavigatorSaveItem.Image")));
            this.tIPOBindingNavigatorSaveItem.Name = "tIPOBindingNavigatorSaveItem";
            this.tIPOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tIPOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tIPOBindingNavigatorSaveItem.Click += new System.EventHandler(this.tIPOBindingNavigatorSaveItem_Click);
            // 
            // cODTIPOLabel1
            // 
            this.cODTIPOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tIPOBindingSource, "CODTIPO", true));
            this.cODTIPOLabel1.Location = new System.Drawing.Point(85, 89);
            this.cODTIPOLabel1.Name = "cODTIPOLabel1";
            this.cODTIPOLabel1.Size = new System.Drawing.Size(100, 23);
            this.cODTIPOLabel1.TabIndex = 2;
            this.cODTIPOLabel1.Text = "label1";
            // 
            // nOMETIPOTextBox
            // 
            this.nOMETIPOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tIPOBindingSource, "NOMETIPO", true));
            this.nOMETIPOTextBox.Location = new System.Drawing.Point(85, 120);
            this.nOMETIPOTextBox.Name = "nOMETIPOTextBox";
            this.nOMETIPOTextBox.Size = new System.Drawing.Size(383, 20);
            this.nOMETIPOTextBox.TabIndex = 4;
            // 
            // tIPODataGridView
            // 
            this.tIPODataGridView.AutoGenerateColumns = false;
            this.tIPODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tIPODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tIPODataGridView.DataSource = this.tIPOBindingSource;
            this.tIPODataGridView.Location = new System.Drawing.Point(15, 171);
            this.tIPODataGridView.Name = "tIPODataGridView";
            this.tIPODataGridView.ReadOnly = true;
            this.tIPODataGridView.Size = new System.Drawing.Size(453, 220);
            this.tIPODataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODTIPO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Tipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMETIPO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // FrmTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 406);
            this.Controls.Add(this.tIPODataGridView);
            this.Controls.Add(cODTIPOLabel);
            this.Controls.Add(this.cODTIPOLabel1);
            this.Controls.Add(nOMETIPOLabel);
            this.Controls.Add(this.nOMETIPOTextBox);
            this.Controls.Add(this.tIPOBindingNavigator);
            this.Name = "FrmTipo";
            this.Text = "FrmTipo";
            this.Load += new System.EventHandler(this.FrmTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingNavigator)).EndInit();
            this.tIPOBindingNavigator.ResumeLayout(false);
            this.tIPOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIPODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource tIPOBindingSource;
        private ATIVIDADEDataSetTableAdapters.TIPOTableAdapter tIPOTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tIPOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tIPOBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODTIPOLabel1;
        private System.Windows.Forms.TextBox nOMETIPOTextBox;
        private System.Windows.Forms.DataGridView tIPODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}