namespace ProjetoBancoDAD
{
    partial class FrmBairro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBairro));
            System.Windows.Forms.Label cODBAIRROLabel;
            System.Windows.Forms.Label nOMEBAIRROLabel;
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.bAIRROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAIRROTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.BAIRROTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.bAIRROBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bAIRROBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bAIRRODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODBAIRROLabel1 = new System.Windows.Forms.Label();
            this.nOMEBAIRROTextBox = new System.Windows.Forms.TextBox();
            cODBAIRROLabel = new System.Windows.Forms.Label();
            nOMEBAIRROLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRROBindingNavigator)).BeginInit();
            this.bAIRROBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRRODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bAIRROBindingSource
            // 
            this.bAIRROBindingSource.DataMember = "BAIRRO";
            this.bAIRROBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // bAIRROTableAdapter
            // 
            this.bAIRROTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAIRROTableAdapter = this.bAIRROTableAdapter;
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
            // bAIRROBindingNavigator
            // 
            this.bAIRROBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bAIRROBindingNavigator.BindingSource = this.bAIRROBindingSource;
            this.bAIRROBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bAIRROBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bAIRROBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bAIRROBindingNavigatorSaveItem});
            this.bAIRROBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bAIRROBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bAIRROBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bAIRROBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bAIRROBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bAIRROBindingNavigator.Name = "bAIRROBindingNavigator";
            this.bAIRROBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bAIRROBindingNavigator.Size = new System.Drawing.Size(492, 25);
            this.bAIRROBindingNavigator.TabIndex = 0;
            this.bAIRROBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bAIRROBindingNavigatorSaveItem
            // 
            this.bAIRROBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bAIRROBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bAIRROBindingNavigatorSaveItem.Image")));
            this.bAIRROBindingNavigatorSaveItem.Name = "bAIRROBindingNavigatorSaveItem";
            this.bAIRROBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.bAIRROBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.bAIRROBindingNavigatorSaveItem.Click += new System.EventHandler(this.bAIRROBindingNavigatorSaveItem_Click);
            // 
            // bAIRRODataGridView
            // 
            this.bAIRRODataGridView.AutoGenerateColumns = false;
            this.bAIRRODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bAIRRODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.bAIRRODataGridView.DataSource = this.bAIRROBindingSource;
            this.bAIRRODataGridView.Location = new System.Drawing.Point(29, 117);
            this.bAIRRODataGridView.Name = "bAIRRODataGridView";
            this.bAIRRODataGridView.ReadOnly = true;
            this.bAIRRODataGridView.Size = new System.Drawing.Size(453, 220);
            this.bAIRRODataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODBAIRRO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Bairro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMEBAIRRO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Bairro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // cODBAIRROLabel
            // 
            cODBAIRROLabel.AutoSize = true;
            cODBAIRROLabel.Location = new System.Drawing.Point(42, 38);
            cODBAIRROLabel.Name = "cODBAIRROLabel";
            cODBAIRROLabel.Size = new System.Drawing.Size(73, 13);
            cODBAIRROLabel.TabIndex = 5;
            cODBAIRROLabel.Text = "Código Bairro:";
            // 
            // cODBAIRROLabel1
            // 
            this.cODBAIRROLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAIRROBindingSource, "CODBAIRRO", true));
            this.cODBAIRROLabel1.Location = new System.Drawing.Point(121, 38);
            this.cODBAIRROLabel1.Name = "cODBAIRROLabel1";
            this.cODBAIRROLabel1.Size = new System.Drawing.Size(100, 23);
            this.cODBAIRROLabel1.TabIndex = 6;
            this.cODBAIRROLabel1.Text = "label1";
            // 
            // nOMEBAIRROLabel
            // 
            nOMEBAIRROLabel.AutoSize = true;
            nOMEBAIRROLabel.Location = new System.Drawing.Point(41, 67);
            nOMEBAIRROLabel.Name = "nOMEBAIRROLabel";
            nOMEBAIRROLabel.Size = new System.Drawing.Size(68, 13);
            nOMEBAIRROLabel.TabIndex = 7;
            nOMEBAIRROLabel.Text = "Nome Bairro:";
            // 
            // nOMEBAIRROTextBox
            // 
            this.nOMEBAIRROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAIRROBindingSource, "NOMEBAIRRO", true));
            this.nOMEBAIRROTextBox.Location = new System.Drawing.Point(115, 64);
            this.nOMEBAIRROTextBox.Name = "nOMEBAIRROTextBox";
            this.nOMEBAIRROTextBox.Size = new System.Drawing.Size(367, 20);
            this.nOMEBAIRROTextBox.TabIndex = 8;
            // 
            // FrmBairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 350);
            this.Controls.Add(cODBAIRROLabel);
            this.Controls.Add(this.cODBAIRROLabel1);
            this.Controls.Add(nOMEBAIRROLabel);
            this.Controls.Add(this.nOMEBAIRROTextBox);
            this.Controls.Add(this.bAIRRODataGridView);
            this.Controls.Add(this.bAIRROBindingNavigator);
            this.Name = "FrmBairro";
            this.Text = "FrmBairro";
            this.Load += new System.EventHandler(this.FrmBairro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRROBindingNavigator)).EndInit();
            this.bAIRROBindingNavigator.ResumeLayout(false);
            this.bAIRROBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRRODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource bAIRROBindingSource;
        private ATIVIDADEDataSetTableAdapters.BAIRROTableAdapter bAIRROTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bAIRROBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bAIRROBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bAIRRODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label cODBAIRROLabel1;
        private System.Windows.Forms.TextBox nOMEBAIRROTextBox;
    }
}