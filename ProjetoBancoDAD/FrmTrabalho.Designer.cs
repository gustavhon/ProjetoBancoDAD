namespace ProjetoBancoDAD
{
    partial class FrmTrabalho
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
            System.Windows.Forms.Label cODTRABALHOLabel;
            System.Windows.Forms.Label nOMETRABALHOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrabalho));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.tRABALHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRABALHOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TRABALHOTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.tRABALHOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tRABALHOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODTRABALHOLabel1 = new System.Windows.Forms.Label();
            this.nOMETRABALHOTextBox = new System.Windows.Forms.TextBox();
            this.tRABALHODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cODTRABALHOLabel = new System.Windows.Forms.Label();
            nOMETRABALHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHOBindingNavigator)).BeginInit();
            this.tRABALHOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cODTRABALHOLabel
            // 
            cODTRABALHOLabel.AutoSize = true;
            cODTRABALHOLabel.Location = new System.Drawing.Point(12, 36);
            cODTRABALHOLabel.Name = "cODTRABALHOLabel";
            cODTRABALHOLabel.Size = new System.Drawing.Size(91, 13);
            cODTRABALHOLabel.TabIndex = 1;
            cODTRABALHOLabel.Text = "CODTRABALHO:";
            // 
            // nOMETRABALHOLabel
            // 
            nOMETRABALHOLabel.AutoSize = true;
            nOMETRABALHOLabel.Location = new System.Drawing.Point(12, 65);
            nOMETRABALHOLabel.Name = "nOMETRABALHOLabel";
            nOMETRABALHOLabel.Size = new System.Drawing.Size(83, 13);
            nOMETRABALHOLabel.TabIndex = 3;
            nOMETRABALHOLabel.Text = "Nome Trabalho:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = this.tRABALHOTableAdapter;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // tRABALHOBindingNavigator
            // 
            this.tRABALHOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tRABALHOBindingNavigator.BindingSource = this.tRABALHOBindingSource;
            this.tRABALHOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tRABALHOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tRABALHOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tRABALHOBindingNavigatorSaveItem});
            this.tRABALHOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tRABALHOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tRABALHOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tRABALHOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tRABALHOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tRABALHOBindingNavigator.Name = "tRABALHOBindingNavigator";
            this.tRABALHOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tRABALHOBindingNavigator.Size = new System.Drawing.Size(490, 25);
            this.tRABALHOBindingNavigator.TabIndex = 0;
            this.tRABALHOBindingNavigator.Text = "bindingNavigator1";
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
            // tRABALHOBindingNavigatorSaveItem
            // 
            this.tRABALHOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tRABALHOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tRABALHOBindingNavigatorSaveItem.Image")));
            this.tRABALHOBindingNavigatorSaveItem.Name = "tRABALHOBindingNavigatorSaveItem";
            this.tRABALHOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tRABALHOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tRABALHOBindingNavigatorSaveItem.Click += new System.EventHandler(this.tRABALHOBindingNavigatorSaveItem_Click);
            // 
            // cODTRABALHOLabel1
            // 
            this.cODTRABALHOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABALHOBindingSource, "CODTRABALHO", true));
            this.cODTRABALHOLabel1.Location = new System.Drawing.Point(118, 36);
            this.cODTRABALHOLabel1.Name = "cODTRABALHOLabel1";
            this.cODTRABALHOLabel1.Size = new System.Drawing.Size(100, 23);
            this.cODTRABALHOLabel1.TabIndex = 2;
            this.cODTRABALHOLabel1.Text = "label1";
            // 
            // nOMETRABALHOTextBox
            // 
            this.nOMETRABALHOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABALHOBindingSource, "NOMETRABALHO", true));
            this.nOMETRABALHOTextBox.Location = new System.Drawing.Point(101, 62);
            this.nOMETRABALHOTextBox.Name = "nOMETRABALHOTextBox";
            this.nOMETRABALHOTextBox.Size = new System.Drawing.Size(367, 20);
            this.nOMETRABALHOTextBox.TabIndex = 4;
            // 
            // tRABALHODataGridView
            // 
            this.tRABALHODataGridView.AutoGenerateColumns = false;
            this.tRABALHODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tRABALHODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tRABALHODataGridView.DataSource = this.tRABALHOBindingSource;
            this.tRABALHODataGridView.Location = new System.Drawing.Point(15, 98);
            this.tRABALHODataGridView.Name = "tRABALHODataGridView";
            this.tRABALHODataGridView.ReadOnly = true;
            this.tRABALHODataGridView.Size = new System.Drawing.Size(453, 220);
            this.tRABALHODataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODTRABALHO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Trabalho";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMETRABALHO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Trabalho";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // FrmTrabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 347);
            this.Controls.Add(this.tRABALHODataGridView);
            this.Controls.Add(cODTRABALHOLabel);
            this.Controls.Add(this.cODTRABALHOLabel1);
            this.Controls.Add(nOMETRABALHOLabel);
            this.Controls.Add(this.nOMETRABALHOTextBox);
            this.Controls.Add(this.tRABALHOBindingNavigator);
            this.Name = "FrmTrabalho";
            this.Text = "FrmTrabalho";
            this.Load += new System.EventHandler(this.FrmTrabalho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHOBindingNavigator)).EndInit();
            this.tRABALHOBindingNavigator.ResumeLayout(false);
            this.tRABALHOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource tRABALHOBindingSource;
        private ATIVIDADEDataSetTableAdapters.TRABALHOTableAdapter tRABALHOTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tRABALHOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tRABALHOBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODTRABALHOLabel1;
        private System.Windows.Forms.TextBox nOMETRABALHOTextBox;
        private System.Windows.Forms.DataGridView tRABALHODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}