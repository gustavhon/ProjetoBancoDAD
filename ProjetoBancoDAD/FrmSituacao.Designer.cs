namespace ProjetoBancoDAD
{
    partial class FrmSituacao
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
            System.Windows.Forms.Label cODSITUACAOLabel;
            System.Windows.Forms.Label nOMESITUACAOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSituacao));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.sITUACAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sITUACAOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.SITUACAOTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.sITUACAOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sITUACAOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODSITUACAOLabel1 = new System.Windows.Forms.Label();
            this.nOMESITUACAOTextBox = new System.Windows.Forms.TextBox();
            this.sITUACAODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cODSITUACAOLabel = new System.Windows.Forms.Label();
            nOMESITUACAOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAOBindingNavigator)).BeginInit();
            this.sITUACAOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cODSITUACAOLabel
            // 
            cODSITUACAOLabel.AutoSize = true;
            cODSITUACAOLabel.Location = new System.Drawing.Point(12, 55);
            cODSITUACAOLabel.Name = "cODSITUACAOLabel";
            cODSITUACAOLabel.Size = new System.Drawing.Size(88, 13);
            cODSITUACAOLabel.TabIndex = 1;
            cODSITUACAOLabel.Text = "Código Situação:";
            // 
            // nOMESITUACAOLabel
            // 
            nOMESITUACAOLabel.AutoSize = true;
            nOMESITUACAOLabel.Location = new System.Drawing.Point(25, 89);
            nOMESITUACAOLabel.Name = "nOMESITUACAOLabel";
            nOMESITUACAOLabel.Size = new System.Drawing.Size(83, 13);
            nOMESITUACAOLabel.TabIndex = 3;
            nOMESITUACAOLabel.Text = "Nome Situação:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sITUACAOBindingSource
            // 
            this.sITUACAOBindingSource.DataMember = "SITUACAO";
            this.sITUACAOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // sITUACAOTableAdapter
            // 
            this.sITUACAOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SITUACAOTableAdapter = this.sITUACAOTableAdapter;
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // sITUACAOBindingNavigator
            // 
            this.sITUACAOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sITUACAOBindingNavigator.BindingSource = this.sITUACAOBindingSource;
            this.sITUACAOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sITUACAOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sITUACAOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sITUACAOBindingNavigatorSaveItem});
            this.sITUACAOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sITUACAOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sITUACAOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sITUACAOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sITUACAOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sITUACAOBindingNavigator.Name = "sITUACAOBindingNavigator";
            this.sITUACAOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sITUACAOBindingNavigator.Size = new System.Drawing.Size(483, 25);
            this.sITUACAOBindingNavigator.TabIndex = 0;
            this.sITUACAOBindingNavigator.Text = "bindingNavigator1";
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
            // sITUACAOBindingNavigatorSaveItem
            // 
            this.sITUACAOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sITUACAOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sITUACAOBindingNavigatorSaveItem.Image")));
            this.sITUACAOBindingNavigatorSaveItem.Name = "sITUACAOBindingNavigatorSaveItem";
            this.sITUACAOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sITUACAOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.sITUACAOBindingNavigatorSaveItem.Click += new System.EventHandler(this.sITUACAOBindingNavigatorSaveItem_Click);
            // 
            // cODSITUACAOLabel1
            // 
            this.cODSITUACAOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sITUACAOBindingSource, "CODSITUACAO", true));
            this.cODSITUACAOLabel1.Location = new System.Drawing.Point(114, 55);
            this.cODSITUACAOLabel1.Name = "cODSITUACAOLabel1";
            this.cODSITUACAOLabel1.Size = new System.Drawing.Size(100, 23);
            this.cODSITUACAOLabel1.TabIndex = 2;
            this.cODSITUACAOLabel1.Text = "label1";
            // 
            // nOMESITUACAOTextBox
            // 
            this.nOMESITUACAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sITUACAOBindingSource, "NOMESITUACAO", true));
            this.nOMESITUACAOTextBox.Location = new System.Drawing.Point(114, 86);
            this.nOMESITUACAOTextBox.Name = "nOMESITUACAOTextBox";
            this.nOMESITUACAOTextBox.Size = new System.Drawing.Size(352, 20);
            this.nOMESITUACAOTextBox.TabIndex = 4;
            // 
            // sITUACAODataGridView
            // 
            this.sITUACAODataGridView.AutoGenerateColumns = false;
            this.sITUACAODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sITUACAODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.sITUACAODataGridView.DataSource = this.sITUACAOBindingSource;
            this.sITUACAODataGridView.Location = new System.Drawing.Point(15, 136);
            this.sITUACAODataGridView.Name = "sITUACAODataGridView";
            this.sITUACAODataGridView.ReadOnly = true;
            this.sITUACAODataGridView.Size = new System.Drawing.Size(451, 220);
            this.sITUACAODataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODSITUACAO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Situação";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMESITUACAO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Situação";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // FrmSituacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 382);
            this.Controls.Add(this.sITUACAODataGridView);
            this.Controls.Add(cODSITUACAOLabel);
            this.Controls.Add(this.cODSITUACAOLabel1);
            this.Controls.Add(nOMESITUACAOLabel);
            this.Controls.Add(this.nOMESITUACAOTextBox);
            this.Controls.Add(this.sITUACAOBindingNavigator);
            this.Name = "FrmSituacao";
            this.Text = "FrmSituacao";
            this.Load += new System.EventHandler(this.FrmSituacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAOBindingNavigator)).EndInit();
            this.sITUACAOBindingNavigator.ResumeLayout(false);
            this.sITUACAOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource sITUACAOBindingSource;
        private ATIVIDADEDataSetTableAdapters.SITUACAOTableAdapter sITUACAOTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sITUACAOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sITUACAOBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODSITUACAOLabel1;
        private System.Windows.Forms.TextBox nOMESITUACAOTextBox;
        private System.Windows.Forms.DataGridView sITUACAODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}