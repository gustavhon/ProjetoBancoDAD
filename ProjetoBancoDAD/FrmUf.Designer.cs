namespace ProjetoBancoDAD
{
    partial class FrmUf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUf));
            System.Windows.Forms.Label cODUFLabel;
            System.Windows.Forms.Label nOMEUFLabel;
            System.Windows.Forms.Label sIGLALabel;
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.uFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uFTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.UFTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.uFBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.uFBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODUFLabel1 = new System.Windows.Forms.Label();
            this.nOMEUFTextBox = new System.Windows.Forms.TextBox();
            this.sIGLATextBox = new System.Windows.Forms.TextBox();
            this.uFDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cODUFLabel = new System.Windows.Forms.Label();
            nOMEUFLabel = new System.Windows.Forms.Label();
            sIGLALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uFBindingNavigator)).BeginInit();
            this.uFBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uFDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uFBindingSource
            // 
            this.uFBindingSource.DataMember = "UF";
            this.uFBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // uFTableAdapter
            // 
            this.uFTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SEXOTableAdapter = null;
            this.tableAdapterManager.SITUACAOTableAdapter = null;
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = this.uFTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // uFBindingNavigator
            // 
            this.uFBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uFBindingNavigator.BindingSource = this.uFBindingSource;
            this.uFBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uFBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uFBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uFBindingNavigatorSaveItem});
            this.uFBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uFBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uFBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uFBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uFBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uFBindingNavigator.Name = "uFBindingNavigator";
            this.uFBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uFBindingNavigator.Size = new System.Drawing.Size(668, 25);
            this.uFBindingNavigator.TabIndex = 0;
            this.uFBindingNavigator.Text = "bindingNavigator1";
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
            // uFBindingNavigatorSaveItem
            // 
            this.uFBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uFBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uFBindingNavigatorSaveItem.Image")));
            this.uFBindingNavigatorSaveItem.Name = "uFBindingNavigatorSaveItem";
            this.uFBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.uFBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.uFBindingNavigatorSaveItem.Click += new System.EventHandler(this.uFBindingNavigatorSaveItem_Click);
            // 
            // cODUFLabel
            // 
            cODUFLabel.AutoSize = true;
            cODUFLabel.Location = new System.Drawing.Point(12, 45);
            cODUFLabel.Name = "cODUFLabel";
            cODUFLabel.Size = new System.Drawing.Size(47, 13);
            cODUFLabel.TabIndex = 1;
            cODUFLabel.Text = "CODUF:";
            // 
            // cODUFLabel1
            // 
            this.cODUFLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uFBindingSource, "CODUF", true));
            this.cODUFLabel1.Location = new System.Drawing.Point(74, 45);
            this.cODUFLabel1.Name = "cODUFLabel1";
            this.cODUFLabel1.Size = new System.Drawing.Size(100, 23);
            this.cODUFLabel1.TabIndex = 2;
            this.cODUFLabel1.Text = "label1";
            // 
            // nOMEUFLabel
            // 
            nOMEUFLabel.AutoSize = true;
            nOMEUFLabel.Location = new System.Drawing.Point(12, 74);
            nOMEUFLabel.Name = "nOMEUFLabel";
            nOMEUFLabel.Size = new System.Drawing.Size(55, 13);
            nOMEUFLabel.TabIndex = 3;
            nOMEUFLabel.Text = "Nome UF:";
            // 
            // nOMEUFTextBox
            // 
            this.nOMEUFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uFBindingSource, "NOMEUF", true));
            this.nOMEUFTextBox.Location = new System.Drawing.Point(74, 71);
            this.nOMEUFTextBox.Name = "nOMEUFTextBox";
            this.nOMEUFTextBox.Size = new System.Drawing.Size(252, 20);
            this.nOMEUFTextBox.TabIndex = 4;
            // 
            // sIGLALabel
            // 
            sIGLALabel.AutoSize = true;
            sIGLALabel.Location = new System.Drawing.Point(26, 104);
            sIGLALabel.Name = "sIGLALabel";
            sIGLALabel.Size = new System.Drawing.Size(41, 13);
            sIGLALabel.TabIndex = 5;
            sIGLALabel.Text = "SIGLA:";
            // 
            // sIGLATextBox
            // 
            this.sIGLATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uFBindingSource, "SIGLA", true));
            this.sIGLATextBox.Location = new System.Drawing.Point(74, 97);
            this.sIGLATextBox.Name = "sIGLATextBox";
            this.sIGLATextBox.Size = new System.Drawing.Size(252, 20);
            this.sIGLATextBox.TabIndex = 6;
            // 
            // uFDataGridView
            // 
            this.uFDataGridView.AutoGenerateColumns = false;
            this.uFDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uFDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.uFDataGridView.DataSource = this.uFBindingSource;
            this.uFDataGridView.Location = new System.Drawing.Point(0, 137);
            this.uFDataGridView.Name = "uFDataGridView";
            this.uFDataGridView.ReadOnly = true;
            this.uFDataGridView.Size = new System.Drawing.Size(651, 220);
            this.uFDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODUF";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código UF";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMEUF";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome UF";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SIGLA";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sigla ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // FrmUf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 388);
            this.Controls.Add(this.uFDataGridView);
            this.Controls.Add(cODUFLabel);
            this.Controls.Add(this.cODUFLabel1);
            this.Controls.Add(nOMEUFLabel);
            this.Controls.Add(this.nOMEUFTextBox);
            this.Controls.Add(sIGLALabel);
            this.Controls.Add(this.sIGLATextBox);
            this.Controls.Add(this.uFBindingNavigator);
            this.Name = "FrmUf";
            this.Text = "FrmUf";
            this.Load += new System.EventHandler(this.FrmUf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uFBindingNavigator)).EndInit();
            this.uFBindingNavigator.ResumeLayout(false);
            this.uFBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uFDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource uFBindingSource;
        private ATIVIDADEDataSetTableAdapters.UFTableAdapter uFTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uFBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton uFBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODUFLabel1;
        private System.Windows.Forms.TextBox nOMEUFTextBox;
        private System.Windows.Forms.TextBox sIGLATextBox;
        private System.Windows.Forms.DataGridView uFDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}