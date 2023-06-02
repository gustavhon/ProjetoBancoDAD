namespace ProjetoBancoDAD
{
    partial class FrmFuncao
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
            System.Windows.Forms.Label cODFUNCAOLabel;
            System.Windows.Forms.Label nOMEFUNCAOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncao));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.fUNCAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCAOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.FUNCAOTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.fUNCAOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fUNCAOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODFUNCAOLabel1 = new System.Windows.Forms.Label();
            this.nOMEFUNCAOTextBox = new System.Windows.Forms.TextBox();
            this.fUNCAODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cODFUNCAOLabel = new System.Windows.Forms.Label();
            nOMEFUNCAOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAOBindingNavigator)).BeginInit();
            this.fUNCAOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cODFUNCAOLabel
            // 
            cODFUNCAOLabel.AutoSize = true;
            cODFUNCAOLabel.Location = new System.Drawing.Point(15, 49);
            cODFUNCAOLabel.Name = "cODFUNCAOLabel";
            cODFUNCAOLabel.Size = new System.Drawing.Size(82, 13);
            cODFUNCAOLabel.TabIndex = 1;
            cODFUNCAOLabel.Text = "Código Função:";
            // 
            // nOMEFUNCAOLabel
            // 
            nOMEFUNCAOLabel.AutoSize = true;
            nOMEFUNCAOLabel.Location = new System.Drawing.Point(15, 83);
            nOMEFUNCAOLabel.Name = "nOMEFUNCAOLabel";
            nOMEFUNCAOLabel.Size = new System.Drawing.Size(77, 13);
            nOMEFUNCAOLabel.TabIndex = 3;
            nOMEFUNCAOLabel.Text = "Nome Função:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fUNCAOBindingSource
            // 
            this.fUNCAOBindingSource.DataMember = "FUNCAO";
            this.fUNCAOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // fUNCAOTableAdapter
            // 
            this.fUNCAOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FUNCAOTableAdapter = this.fUNCAOTableAdapter;
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
            // fUNCAOBindingNavigator
            // 
            this.fUNCAOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fUNCAOBindingNavigator.BindingSource = this.fUNCAOBindingSource;
            this.fUNCAOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fUNCAOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fUNCAOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fUNCAOBindingNavigatorSaveItem});
            this.fUNCAOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fUNCAOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fUNCAOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fUNCAOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fUNCAOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fUNCAOBindingNavigator.Name = "fUNCAOBindingNavigator";
            this.fUNCAOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fUNCAOBindingNavigator.Size = new System.Drawing.Size(481, 25);
            this.fUNCAOBindingNavigator.TabIndex = 0;
            this.fUNCAOBindingNavigator.Text = "bindingNavigator1";
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
            // fUNCAOBindingNavigatorSaveItem
            // 
            this.fUNCAOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fUNCAOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fUNCAOBindingNavigatorSaveItem.Image")));
            this.fUNCAOBindingNavigatorSaveItem.Name = "fUNCAOBindingNavigatorSaveItem";
            this.fUNCAOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fUNCAOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.fUNCAOBindingNavigatorSaveItem.Click += new System.EventHandler(this.fUNCAOBindingNavigatorSaveItem_Click);
            // 
            // cODFUNCAOLabel1
            // 
            this.cODFUNCAOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fUNCAOBindingSource, "CODFUNCAO", true));
            this.cODFUNCAOLabel1.Location = new System.Drawing.Point(107, 49);
            this.cODFUNCAOLabel1.Name = "cODFUNCAOLabel1";
            this.cODFUNCAOLabel1.Size = new System.Drawing.Size(100, 23);
            this.cODFUNCAOLabel1.TabIndex = 2;
            this.cODFUNCAOLabel1.Text = "label1";
            // 
            // nOMEFUNCAOTextBox
            // 
            this.nOMEFUNCAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fUNCAOBindingSource, "NOMEFUNCAO", true));
            this.nOMEFUNCAOTextBox.Location = new System.Drawing.Point(98, 80);
            this.nOMEFUNCAOTextBox.Name = "nOMEFUNCAOTextBox";
            this.nOMEFUNCAOTextBox.Size = new System.Drawing.Size(360, 20);
            this.nOMEFUNCAOTextBox.TabIndex = 4;
            // 
            // fUNCAODataGridView
            // 
            this.fUNCAODataGridView.AutoGenerateColumns = false;
            this.fUNCAODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fUNCAODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.fUNCAODataGridView.DataSource = this.fUNCAOBindingSource;
            this.fUNCAODataGridView.Location = new System.Drawing.Point(12, 122);
            this.fUNCAODataGridView.Name = "fUNCAODataGridView";
            this.fUNCAODataGridView.ReadOnly = true;
            this.fUNCAODataGridView.Size = new System.Drawing.Size(455, 220);
            this.fUNCAODataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODFUNCAO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome Função";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMEFUNCAO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Função";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // FrmFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 367);
            this.Controls.Add(this.fUNCAODataGridView);
            this.Controls.Add(cODFUNCAOLabel);
            this.Controls.Add(this.cODFUNCAOLabel1);
            this.Controls.Add(nOMEFUNCAOLabel);
            this.Controls.Add(this.nOMEFUNCAOTextBox);
            this.Controls.Add(this.fUNCAOBindingNavigator);
            this.Name = "FrmFuncao";
            this.Text = "FrmFuncao";
            this.Load += new System.EventHandler(this.FrmFuncao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAOBindingNavigator)).EndInit();
            this.fUNCAOBindingNavigator.ResumeLayout(false);
            this.fUNCAOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource fUNCAOBindingSource;
        private ATIVIDADEDataSetTableAdapters.FUNCAOTableAdapter fUNCAOTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fUNCAOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fUNCAOBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODFUNCAOLabel1;
        private System.Windows.Forms.TextBox nOMEFUNCAOTextBox;
        private System.Windows.Forms.DataGridView fUNCAODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}