namespace ProjetoBancoDAD
{
    partial class FrmItensTelefoneLoja
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
            System.Windows.Forms.Label cODLOJA_FKLabel;
            System.Windows.Forms.Label cODTELEFONE_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensTelefoneLoja));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.iTENSTELEFONELOJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENSTELEFONELOJATableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.ITENSTELEFONELOJATableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.iTENSTELEFONELOJABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iTENSTELEFONELOJABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODLOJA_FKTextBox = new System.Windows.Forms.TextBox();
            this.cODTELEFONE_FKTextBox = new System.Windows.Forms.TextBox();
            this.iTENSTELEFONELOJADataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cODLOJA_FKLabel = new System.Windows.Forms.Label();
            cODTELEFONE_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONELOJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONELOJABindingNavigator)).BeginInit();
            this.iTENSTELEFONELOJABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONELOJADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cODLOJA_FKLabel
            // 
            cODLOJA_FKLabel.AutoSize = true;
            cODLOJA_FKLabel.Location = new System.Drawing.Point(12, 67);
            cODLOJA_FKLabel.Name = "cODLOJA_FKLabel";
            cODLOJA_FKLabel.Size = new System.Drawing.Size(75, 13);
            cODLOJA_FKLabel.TabIndex = 1;
            cODLOJA_FKLabel.Text = "CODLOJA FK:";
            // 
            // cODTELEFONE_FKLabel
            // 
            cODTELEFONE_FKLabel.AutoSize = true;
            cODTELEFONE_FKLabel.Location = new System.Drawing.Point(300, 67);
            cODTELEFONE_FKLabel.Name = "cODTELEFONE_FKLabel";
            cODTELEFONE_FKLabel.Size = new System.Drawing.Size(105, 13);
            cODTELEFONE_FKLabel.TabIndex = 3;
            cODTELEFONE_FKLabel.Text = "CODTELEFONE FK:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTENSTELEFONELOJABindingSource
            // 
            this.iTENSTELEFONELOJABindingSource.DataMember = "ITENSTELEFONELOJA";
            this.iTENSTELEFONELOJABindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // iTENSTELEFONELOJATableAdapter
            // 
            this.iTENSTELEFONELOJATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ITENSTELEFONELOJATableAdapter = this.iTENSTELEFONELOJATableAdapter;
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
            // iTENSTELEFONELOJABindingNavigator
            // 
            this.iTENSTELEFONELOJABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTENSTELEFONELOJABindingNavigator.BindingSource = this.iTENSTELEFONELOJABindingSource;
            this.iTENSTELEFONELOJABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTENSTELEFONELOJABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTENSTELEFONELOJABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iTENSTELEFONELOJABindingNavigatorSaveItem});
            this.iTENSTELEFONELOJABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTENSTELEFONELOJABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTENSTELEFONELOJABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTENSTELEFONELOJABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTENSTELEFONELOJABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTENSTELEFONELOJABindingNavigator.Name = "iTENSTELEFONELOJABindingNavigator";
            this.iTENSTELEFONELOJABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTENSTELEFONELOJABindingNavigator.Size = new System.Drawing.Size(587, 25);
            this.iTENSTELEFONELOJABindingNavigator.TabIndex = 0;
            this.iTENSTELEFONELOJABindingNavigator.Text = "bindingNavigator1";
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
            // iTENSTELEFONELOJABindingNavigatorSaveItem
            // 
            this.iTENSTELEFONELOJABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTENSTELEFONELOJABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iTENSTELEFONELOJABindingNavigatorSaveItem.Image")));
            this.iTENSTELEFONELOJABindingNavigatorSaveItem.Name = "iTENSTELEFONELOJABindingNavigatorSaveItem";
            this.iTENSTELEFONELOJABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iTENSTELEFONELOJABindingNavigatorSaveItem.Text = "Salvar Dados";
            this.iTENSTELEFONELOJABindingNavigatorSaveItem.Click += new System.EventHandler(this.iTENSTELEFONELOJABindingNavigatorSaveItem_Click);
            // 
            // cODLOJA_FKTextBox
            // 
            this.cODLOJA_FKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENSTELEFONELOJABindingSource, "CODLOJA_FK", true));
            this.cODLOJA_FKTextBox.Location = new System.Drawing.Point(123, 64);
            this.cODLOJA_FKTextBox.Name = "cODLOJA_FKTextBox";
            this.cODLOJA_FKTextBox.Size = new System.Drawing.Size(100, 20);
            this.cODLOJA_FKTextBox.TabIndex = 2;
            // 
            // cODTELEFONE_FKTextBox
            // 
            this.cODTELEFONE_FKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENSTELEFONELOJABindingSource, "CODTELEFONE_FK", true));
            this.cODTELEFONE_FKTextBox.Location = new System.Drawing.Point(411, 64);
            this.cODTELEFONE_FKTextBox.Name = "cODTELEFONE_FKTextBox";
            this.cODTELEFONE_FKTextBox.Size = new System.Drawing.Size(100, 20);
            this.cODTELEFONE_FKTextBox.TabIndex = 4;
            // 
            // iTENSTELEFONELOJADataGridView
            // 
            this.iTENSTELEFONELOJADataGridView.AutoGenerateColumns = false;
            this.iTENSTELEFONELOJADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iTENSTELEFONELOJADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.iTENSTELEFONELOJADataGridView.DataSource = this.iTENSTELEFONELOJABindingSource;
            this.iTENSTELEFONELOJADataGridView.Location = new System.Drawing.Point(6, 106);
            this.iTENSTELEFONELOJADataGridView.Name = "iTENSTELEFONELOJADataGridView";
            this.iTENSTELEFONELOJADataGridView.ReadOnly = true;
            this.iTENSTELEFONELOJADataGridView.Size = new System.Drawing.Size(560, 220);
            this.iTENSTELEFONELOJADataGridView.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(517, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODLOJA_FK";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código LojaFK";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CODTELEFONE_FK";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código TelefoneFK";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 265;
            // 
            // FrmItensTelefoneLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 355);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iTENSTELEFONELOJADataGridView);
            this.Controls.Add(cODLOJA_FKLabel);
            this.Controls.Add(this.cODLOJA_FKTextBox);
            this.Controls.Add(cODTELEFONE_FKLabel);
            this.Controls.Add(this.cODTELEFONE_FKTextBox);
            this.Controls.Add(this.iTENSTELEFONELOJABindingNavigator);
            this.Name = "FrmItensTelefoneLoja";
            this.Text = "ItensTelefoneLoja";
            this.Load += new System.EventHandler(this.ItensTelefoneLoja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONELOJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONELOJABindingNavigator)).EndInit();
            this.iTENSTELEFONELOJABindingNavigator.ResumeLayout(false);
            this.iTENSTELEFONELOJABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSTELEFONELOJADataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource iTENSTELEFONELOJABindingSource;
        private ATIVIDADEDataSetTableAdapters.ITENSTELEFONELOJATableAdapter iTENSTELEFONELOJATableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iTENSTELEFONELOJABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iTENSTELEFONELOJABindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cODLOJA_FKTextBox;
        private System.Windows.Forms.TextBox cODTELEFONE_FKTextBox;
        private System.Windows.Forms.DataGridView iTENSTELEFONELOJADataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}