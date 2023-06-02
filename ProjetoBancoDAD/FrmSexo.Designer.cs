namespace ProjetoBancoDAD
{
    partial class FrmSexo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSexo));
            System.Windows.Forms.Label cODSEXOLabel;
            System.Windows.Forms.Label nOMESEXOLabel;
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.sEXOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEXOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.SEXOTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.sEXOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sEXOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODSEXOLabel1 = new System.Windows.Forms.Label();
            this.nOMESEXOTextBox = new System.Windows.Forms.TextBox();
            this.sEXODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cODSEXOLabel = new System.Windows.Forms.Label();
            nOMESEXOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEXOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEXOBindingNavigator)).BeginInit();
            this.sEXOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sEXODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEXOBindingSource
            // 
            this.sEXOBindingSource.DataMember = "SEXO";
            this.sEXOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // sEXOTableAdapter
            // 
            this.sEXOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MARCATableAdapter = null;
            this.tableAdapterManager.OPERADORATableAdapter = null;
            this.tableAdapterManager.PARCELACOMPRATableAdapter = null;
            this.tableAdapterManager.PARCELAVENDATableAdapter = null;
            this.tableAdapterManager.PRODUTOTableAdapter = null;
            this.tableAdapterManager.RUATableAdapter = null;
            this.tableAdapterManager.SEXOTableAdapter = this.sEXOTableAdapter;
            this.tableAdapterManager.SITUACAOTableAdapter = null;
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // sEXOBindingNavigator
            // 
            this.sEXOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sEXOBindingNavigator.BindingSource = this.sEXOBindingSource;
            this.sEXOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sEXOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sEXOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sEXOBindingNavigatorSaveItem});
            this.sEXOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sEXOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sEXOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sEXOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sEXOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sEXOBindingNavigator.Name = "sEXOBindingNavigator";
            this.sEXOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sEXOBindingNavigator.Size = new System.Drawing.Size(365, 25);
            this.sEXOBindingNavigator.TabIndex = 0;
            this.sEXOBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // sEXOBindingNavigatorSaveItem
            // 
            this.sEXOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sEXOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sEXOBindingNavigatorSaveItem.Image")));
            this.sEXOBindingNavigatorSaveItem.Name = "sEXOBindingNavigatorSaveItem";
            this.sEXOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sEXOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.sEXOBindingNavigatorSaveItem.Click += new System.EventHandler(this.sEXOBindingNavigatorSaveItem_Click);
            // 
            // cODSEXOLabel
            // 
            cODSEXOLabel.AutoSize = true;
            cODSEXOLabel.Location = new System.Drawing.Point(12, 81);
            cODSEXOLabel.Name = "cODSEXOLabel";
            cODSEXOLabel.Size = new System.Drawing.Size(43, 13);
            cODSEXOLabel.TabIndex = 1;
            cODSEXOLabel.Text = "Código:";
            // 
            // cODSEXOLabel1
            // 
            this.cODSEXOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sEXOBindingSource, "CODSEXO", true));
            this.cODSEXOLabel1.Location = new System.Drawing.Point(89, 81);
            this.cODSEXOLabel1.Name = "cODSEXOLabel1";
            this.cODSEXOLabel1.Size = new System.Drawing.Size(259, 23);
            this.cODSEXOLabel1.TabIndex = 2;
            this.cODSEXOLabel1.Text = "label1";
            // 
            // nOMESEXOLabel
            // 
            nOMESEXOLabel.AutoSize = true;
            nOMESEXOLabel.Location = new System.Drawing.Point(12, 110);
            nOMESEXOLabel.Name = "nOMESEXOLabel";
            nOMESEXOLabel.Size = new System.Drawing.Size(34, 13);
            nOMESEXOLabel.TabIndex = 3;
            nOMESEXOLabel.Text = "Sexo:";
            // 
            // nOMESEXOTextBox
            // 
            this.nOMESEXOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sEXOBindingSource, "NOMESEXO", true));
            this.nOMESEXOTextBox.Location = new System.Drawing.Point(89, 107);
            this.nOMESEXOTextBox.Name = "nOMESEXOTextBox";
            this.nOMESEXOTextBox.Size = new System.Drawing.Size(259, 20);
            this.nOMESEXOTextBox.TabIndex = 4;
            // 
            // sEXODataGridView
            // 
            this.sEXODataGridView.AutoGenerateColumns = false;
            this.sEXODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sEXODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.sEXODataGridView.DataSource = this.sEXOBindingSource;
            this.sEXODataGridView.Location = new System.Drawing.Point(15, 152);
            this.sEXODataGridView.Name = "sEXODataGridView";
            this.sEXODataGridView.ReadOnly = true;
            this.sEXODataGridView.Size = new System.Drawing.Size(346, 220);
            this.sEXODataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODSEXO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMESEXO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // FrmSexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 374);
            this.Controls.Add(this.sEXODataGridView);
            this.Controls.Add(cODSEXOLabel);
            this.Controls.Add(this.cODSEXOLabel1);
            this.Controls.Add(nOMESEXOLabel);
            this.Controls.Add(this.nOMESEXOTextBox);
            this.Controls.Add(this.sEXOBindingNavigator);
            this.Name = "FrmSexo";
            this.Text = "FrmSexo";
            this.Load += new System.EventHandler(this.FrmSexo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEXOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEXOBindingNavigator)).EndInit();
            this.sEXOBindingNavigator.ResumeLayout(false);
            this.sEXOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sEXODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource sEXOBindingSource;
        private ATIVIDADEDataSetTableAdapters.SEXOTableAdapter sEXOTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sEXOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sEXOBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODSEXOLabel1;
        private System.Windows.Forms.TextBox nOMESEXOTextBox;
        private System.Windows.Forms.DataGridView sEXODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}