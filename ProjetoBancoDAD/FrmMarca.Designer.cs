namespace ProjetoBancoDAD
{
    partial class FrmMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarca));
            System.Windows.Forms.Label cODMARCALabel;
            System.Windows.Forms.Label nOMEMARCALabel;
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.mARCABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mARCATableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.MARCATableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.mARCABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mARCABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODMARCALabel1 = new System.Windows.Forms.Label();
            this.nOMEMARCATextBox = new System.Windows.Forms.TextBox();
            this.mARCADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cODMARCALabel = new System.Windows.Forms.Label();
            nOMEMARCALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCABindingNavigator)).BeginInit();
            this.mARCABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mARCADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mARCABindingSource
            // 
            this.mARCABindingSource.DataMember = "MARCA";
            this.mARCABindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // mARCATableAdapter
            // 
            this.mARCATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOJATableAdapter = null;
            this.tableAdapterManager.MARCATableAdapter = this.mARCATableAdapter;
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
            // mARCABindingNavigator
            // 
            this.mARCABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mARCABindingNavigator.BindingSource = this.mARCABindingSource;
            this.mARCABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mARCABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mARCABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mARCABindingNavigatorSaveItem});
            this.mARCABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mARCABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mARCABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mARCABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mARCABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mARCABindingNavigator.Name = "mARCABindingNavigator";
            this.mARCABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mARCABindingNavigator.Size = new System.Drawing.Size(472, 25);
            this.mARCABindingNavigator.TabIndex = 0;
            this.mARCABindingNavigator.Text = "bindingNavigator1";
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
            // mARCABindingNavigatorSaveItem
            // 
            this.mARCABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mARCABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mARCABindingNavigatorSaveItem.Image")));
            this.mARCABindingNavigatorSaveItem.Name = "mARCABindingNavigatorSaveItem";
            this.mARCABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.mARCABindingNavigatorSaveItem.Text = "Salvar Dados";
            this.mARCABindingNavigatorSaveItem.Click += new System.EventHandler(this.mARCABindingNavigatorSaveItem_Click);
            // 
            // cODMARCALabel
            // 
            cODMARCALabel.AutoSize = true;
            cODMARCALabel.Location = new System.Drawing.Point(12, 85);
            cODMARCALabel.Name = "cODMARCALabel";
            cODMARCALabel.Size = new System.Drawing.Size(76, 13);
            cODMARCALabel.TabIndex = 1;
            cODMARCALabel.Text = "Código Marca:";
            // 
            // cODMARCALabel1
            // 
            this.cODMARCALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mARCABindingSource, "CODMARCA", true));
            this.cODMARCALabel1.Location = new System.Drawing.Point(86, 85);
            this.cODMARCALabel1.Name = "cODMARCALabel1";
            this.cODMARCALabel1.Size = new System.Drawing.Size(100, 23);
            this.cODMARCALabel1.TabIndex = 2;
            this.cODMARCALabel1.Text = "label1";
            // 
            // nOMEMARCALabel
            // 
            nOMEMARCALabel.AutoSize = true;
            nOMEMARCALabel.Location = new System.Drawing.Point(12, 130);
            nOMEMARCALabel.Name = "nOMEMARCALabel";
            nOMEMARCALabel.Size = new System.Drawing.Size(71, 13);
            nOMEMARCALabel.TabIndex = 3;
            nOMEMARCALabel.Text = "Nome Marca:";
            // 
            // nOMEMARCATextBox
            // 
            this.nOMEMARCATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mARCABindingSource, "NOMEMARCA", true));
            this.nOMEMARCATextBox.Location = new System.Drawing.Point(89, 127);
            this.nOMEMARCATextBox.Name = "nOMEMARCATextBox";
            this.nOMEMARCATextBox.Size = new System.Drawing.Size(356, 20);
            this.nOMEMARCATextBox.TabIndex = 4;
            // 
            // mARCADataGridView
            // 
            this.mARCADataGridView.AutoGenerateColumns = false;
            this.mARCADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mARCADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.mARCADataGridView.DataSource = this.mARCABindingSource;
            this.mARCADataGridView.Location = new System.Drawing.Point(15, 175);
            this.mARCADataGridView.Name = "mARCADataGridView";
            this.mARCADataGridView.ReadOnly = true;
            this.mARCADataGridView.Size = new System.Drawing.Size(450, 220);
            this.mARCADataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODMARCA";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Marca:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMEMARCA";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Marca:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 416);
            this.Controls.Add(this.mARCADataGridView);
            this.Controls.Add(cODMARCALabel);
            this.Controls.Add(this.cODMARCALabel1);
            this.Controls.Add(nOMEMARCALabel);
            this.Controls.Add(this.nOMEMARCATextBox);
            this.Controls.Add(this.mARCABindingNavigator);
            this.Name = "FrmMarca";
            this.Text = "FrmMarca";
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCABindingNavigator)).EndInit();
            this.mARCABindingNavigator.ResumeLayout(false);
            this.mARCABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mARCADataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource mARCABindingSource;
        private ATIVIDADEDataSetTableAdapters.MARCATableAdapter mARCATableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mARCABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mARCABindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODMARCALabel1;
        private System.Windows.Forms.TextBox nOMEMARCATextBox;
        private System.Windows.Forms.DataGridView mARCADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}