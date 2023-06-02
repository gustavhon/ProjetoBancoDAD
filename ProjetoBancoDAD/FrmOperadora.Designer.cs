namespace ProjetoBancoDAD
{
    partial class FrmOperadora
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
            System.Windows.Forms.Label cODOPERADORALabel;
            System.Windows.Forms.Label nOMEOPERADORALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOperadora));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.oPERADORABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPERADORATableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.OPERADORATableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.oPERADORABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.oPERADORABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODOPERADORALabel1 = new System.Windows.Forms.Label();
            this.nOMEOPERADORATextBox = new System.Windows.Forms.TextBox();
            this.oPERADORADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cODOPERADORALabel = new System.Windows.Forms.Label();
            nOMEOPERADORALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORABindingNavigator)).BeginInit();
            this.oPERADORABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cODOPERADORALabel
            // 
            cODOPERADORALabel.AutoSize = true;
            cODOPERADORALabel.Location = new System.Drawing.Point(12, 53);
            cODOPERADORALabel.Name = "cODOPERADORALabel";
            cODOPERADORALabel.Size = new System.Drawing.Size(96, 13);
            cODOPERADORALabel.TabIndex = 1;
            cODOPERADORALabel.Text = "Código Operadora:";
            // 
            // nOMEOPERADORALabel
            // 
            nOMEOPERADORALabel.AutoSize = true;
            nOMEOPERADORALabel.Location = new System.Drawing.Point(12, 82);
            nOMEOPERADORALabel.Name = "nOMEOPERADORALabel";
            nOMEOPERADORALabel.Size = new System.Drawing.Size(91, 13);
            nOMEOPERADORALabel.TabIndex = 3;
            nOMEOPERADORALabel.Text = "Nome Operadora:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oPERADORABindingSource
            // 
            this.oPERADORABindingSource.DataMember = "OPERADORA";
            this.oPERADORABindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // oPERADORATableAdapter
            // 
            this.oPERADORATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.OPERADORATableAdapter = this.oPERADORATableAdapter;
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
            // oPERADORABindingNavigator
            // 
            this.oPERADORABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oPERADORABindingNavigator.BindingSource = this.oPERADORABindingSource;
            this.oPERADORABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.oPERADORABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.oPERADORABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.oPERADORABindingNavigatorSaveItem});
            this.oPERADORABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.oPERADORABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.oPERADORABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.oPERADORABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.oPERADORABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.oPERADORABindingNavigator.Name = "oPERADORABindingNavigator";
            this.oPERADORABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.oPERADORABindingNavigator.Size = new System.Drawing.Size(484, 25);
            this.oPERADORABindingNavigator.TabIndex = 0;
            this.oPERADORABindingNavigator.Text = "bindingNavigator1";
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
            // oPERADORABindingNavigatorSaveItem
            // 
            this.oPERADORABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oPERADORABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oPERADORABindingNavigatorSaveItem.Image")));
            this.oPERADORABindingNavigatorSaveItem.Name = "oPERADORABindingNavigatorSaveItem";
            this.oPERADORABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.oPERADORABindingNavigatorSaveItem.Text = "Salvar Dados";
            this.oPERADORABindingNavigatorSaveItem.Click += new System.EventHandler(this.oPERADORABindingNavigatorSaveItem_Click);
            // 
            // cODOPERADORALabel1
            // 
            this.cODOPERADORALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPERADORABindingSource, "CODOPERADORA", true));
            this.cODOPERADORALabel1.Location = new System.Drawing.Point(128, 53);
            this.cODOPERADORALabel1.Name = "cODOPERADORALabel1";
            this.cODOPERADORALabel1.Size = new System.Drawing.Size(100, 23);
            this.cODOPERADORALabel1.TabIndex = 2;
            this.cODOPERADORALabel1.Text = "label1";
            // 
            // nOMEOPERADORATextBox
            // 
            this.nOMEOPERADORATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPERADORABindingSource, "NOMEOPERADORA", true));
            this.nOMEOPERADORATextBox.Location = new System.Drawing.Point(109, 79);
            this.nOMEOPERADORATextBox.Name = "nOMEOPERADORATextBox";
            this.nOMEOPERADORATextBox.Size = new System.Drawing.Size(154, 20);
            this.nOMEOPERADORATextBox.TabIndex = 4;
            // 
            // oPERADORADataGridView
            // 
            this.oPERADORADataGridView.AutoGenerateColumns = false;
            this.oPERADORADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oPERADORADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.oPERADORADataGridView.DataSource = this.oPERADORABindingSource;
            this.oPERADORADataGridView.Location = new System.Drawing.Point(15, 125);
            this.oPERADORADataGridView.Name = "oPERADORADataGridView";
            this.oPERADORADataGridView.ReadOnly = true;
            this.oPERADORADataGridView.Size = new System.Drawing.Size(457, 220);
            this.oPERADORADataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODOPERADORA";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Operadora";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMEOPERADORA";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Operadora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // FrmOperadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 350);
            this.Controls.Add(this.oPERADORADataGridView);
            this.Controls.Add(cODOPERADORALabel);
            this.Controls.Add(this.cODOPERADORALabel1);
            this.Controls.Add(nOMEOPERADORALabel);
            this.Controls.Add(this.nOMEOPERADORATextBox);
            this.Controls.Add(this.oPERADORABindingNavigator);
            this.Name = "FrmOperadora";
            this.Text = "FrmOperadora";
            this.Load += new System.EventHandler(this.FrmOperadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORABindingNavigator)).EndInit();
            this.oPERADORABindingNavigator.ResumeLayout(false);
            this.oPERADORABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORADataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource oPERADORABindingSource;
        private ATIVIDADEDataSetTableAdapters.OPERADORATableAdapter oPERADORATableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator oPERADORABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton oPERADORABindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODOPERADORALabel1;
        private System.Windows.Forms.TextBox nOMEOPERADORATextBox;
        private System.Windows.Forms.DataGridView oPERADORADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}