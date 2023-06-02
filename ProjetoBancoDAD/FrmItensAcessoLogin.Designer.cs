namespace ProjetoBancoDAD
{
    partial class FrmItensAcessoLogin
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
            System.Windows.Forms.Label cODACESSO_FKLabel;
            System.Windows.Forms.Label cODLOGIN_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensAcessoLogin));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.iTENSACESSOLOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENSACESSOLOGINTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.ITENSACESSOLOGINTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.iTENSACESSOLOGINBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iTENSACESSOLOGINBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODACESSO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cODLOGIN_FKComboBox = new System.Windows.Forms.ComboBox();
            this.iTENSACESSOLOGINDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.aCESSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCESSOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.ACESSOTableAdapter();
            this.lOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGINTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.LOGINTableAdapter();
            cODACESSO_FKLabel = new System.Windows.Forms.Label();
            cODLOGIN_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSACESSOLOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSACESSOLOGINBindingNavigator)).BeginInit();
            this.iTENSACESSOLOGINBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSACESSOLOGINDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCESSOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODACESSO_FKLabel
            // 
            cODACESSO_FKLabel.AutoSize = true;
            cODACESSO_FKLabel.Location = new System.Drawing.Point(12, 60);
            cODACESSO_FKLabel.Name = "cODACESSO_FKLabel";
            cODACESSO_FKLabel.Size = new System.Drawing.Size(92, 13);
            cODACESSO_FKLabel.TabIndex = 1;
            cODACESSO_FKLabel.Text = "CODACESSO FK:";
            // 
            // cODLOGIN_FKLabel
            // 
            cODLOGIN_FKLabel.AutoSize = true;
            cODLOGIN_FKLabel.Location = new System.Drawing.Point(12, 92);
            cODLOGIN_FKLabel.Name = "cODLOGIN_FKLabel";
            cODLOGIN_FKLabel.Size = new System.Drawing.Size(82, 13);
            cODLOGIN_FKLabel.TabIndex = 3;
            cODLOGIN_FKLabel.Text = "CODLOGIN FK:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTENSACESSOLOGINBindingSource
            // 
            this.iTENSACESSOLOGINBindingSource.DataMember = "ITENSACESSOLOGIN";
            this.iTENSACESSOLOGINBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // iTENSACESSOLOGINTableAdapter
            // 
            this.iTENSACESSOLOGINTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ITENSACESSOLOGINTableAdapter = this.iTENSACESSOLOGINTableAdapter;
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
            // iTENSACESSOLOGINBindingNavigator
            // 
            this.iTENSACESSOLOGINBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTENSACESSOLOGINBindingNavigator.BindingSource = this.iTENSACESSOLOGINBindingSource;
            this.iTENSACESSOLOGINBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTENSACESSOLOGINBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTENSACESSOLOGINBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iTENSACESSOLOGINBindingNavigatorSaveItem});
            this.iTENSACESSOLOGINBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTENSACESSOLOGINBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTENSACESSOLOGINBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTENSACESSOLOGINBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTENSACESSOLOGINBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTENSACESSOLOGINBindingNavigator.Name = "iTENSACESSOLOGINBindingNavigator";
            this.iTENSACESSOLOGINBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTENSACESSOLOGINBindingNavigator.Size = new System.Drawing.Size(479, 25);
            this.iTENSACESSOLOGINBindingNavigator.TabIndex = 0;
            this.iTENSACESSOLOGINBindingNavigator.Text = "bindingNavigator1";
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
            // iTENSACESSOLOGINBindingNavigatorSaveItem
            // 
            this.iTENSACESSOLOGINBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTENSACESSOLOGINBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iTENSACESSOLOGINBindingNavigatorSaveItem.Image")));
            this.iTENSACESSOLOGINBindingNavigatorSaveItem.Name = "iTENSACESSOLOGINBindingNavigatorSaveItem";
            this.iTENSACESSOLOGINBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iTENSACESSOLOGINBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.iTENSACESSOLOGINBindingNavigatorSaveItem.Click += new System.EventHandler(this.iTENSACESSOLOGINBindingNavigatorSaveItem_Click);
            // 
            // cODACESSO_FKComboBox
            // 
            this.cODACESSO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENSACESSOLOGINBindingSource, "CODACESSO_FK", true));
            this.cODACESSO_FKComboBox.DataSource = this.aCESSOBindingSource;
            this.cODACESSO_FKComboBox.DisplayMember = "NOMEACESSO";
            this.cODACESSO_FKComboBox.FormattingEnabled = true;
            this.cODACESSO_FKComboBox.Location = new System.Drawing.Point(110, 57);
            this.cODACESSO_FKComboBox.Name = "cODACESSO_FKComboBox";
            this.cODACESSO_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODACESSO_FKComboBox.TabIndex = 2;
            this.cODACESSO_FKComboBox.ValueMember = "CODACESSO";
            // 
            // cODLOGIN_FKComboBox
            // 
            this.cODLOGIN_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENSACESSOLOGINBindingSource, "CODLOGIN_FK", true));
            this.cODLOGIN_FKComboBox.DataSource = this.lOGINBindingSource;
            this.cODLOGIN_FKComboBox.DisplayMember = "USUARIO";
            this.cODLOGIN_FKComboBox.FormattingEnabled = true;
            this.cODLOGIN_FKComboBox.Location = new System.Drawing.Point(110, 89);
            this.cODLOGIN_FKComboBox.Name = "cODLOGIN_FKComboBox";
            this.cODLOGIN_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODLOGIN_FKComboBox.TabIndex = 4;
            this.cODLOGIN_FKComboBox.ValueMember = "CODLOGIN";
            // 
            // iTENSACESSOLOGINDataGridView
            // 
            this.iTENSACESSOLOGINDataGridView.AutoGenerateColumns = false;
            this.iTENSACESSOLOGINDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iTENSACESSOLOGINDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.iTENSACESSOLOGINDataGridView.DataSource = this.iTENSACESSOLOGINBindingSource;
            this.iTENSACESSOLOGINDataGridView.Location = new System.Drawing.Point(15, 168);
            this.iTENSACESSOLOGINDataGridView.Name = "iTENSACESSOLOGINDataGridView";
            this.iTENSACESSOLOGINDataGridView.ReadOnly = true;
            this.iTENSACESSOLOGINDataGridView.Size = new System.Drawing.Size(453, 220);
            this.iTENSACESSOLOGINDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODACESSO_FK";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código AcessoFK";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CODLOGIN_FK";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código LoginFK";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // aCESSOBindingSource
            // 
            this.aCESSOBindingSource.DataMember = "ACESSO";
            this.aCESSOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // aCESSOTableAdapter
            // 
            this.aCESSOTableAdapter.ClearBeforeFill = true;
            // 
            // lOGINBindingSource
            // 
            this.lOGINBindingSource.DataMember = "LOGIN";
            this.lOGINBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // lOGINTableAdapter
            // 
            this.lOGINTableAdapter.ClearBeforeFill = true;
            // 
            // FrmItensAcessoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iTENSACESSOLOGINDataGridView);
            this.Controls.Add(cODACESSO_FKLabel);
            this.Controls.Add(this.cODACESSO_FKComboBox);
            this.Controls.Add(cODLOGIN_FKLabel);
            this.Controls.Add(this.cODLOGIN_FKComboBox);
            this.Controls.Add(this.iTENSACESSOLOGINBindingNavigator);
            this.Name = "FrmItensAcessoLogin";
            this.Text = "FrmItensAcessoLogin";
            this.Load += new System.EventHandler(this.FrmItensAcessoLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSACESSOLOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSACESSOLOGINBindingNavigator)).EndInit();
            this.iTENSACESSOLOGINBindingNavigator.ResumeLayout(false);
            this.iTENSACESSOLOGINBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSACESSOLOGINDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCESSOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource iTENSACESSOLOGINBindingSource;
        private ATIVIDADEDataSetTableAdapters.ITENSACESSOLOGINTableAdapter iTENSACESSOLOGINTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iTENSACESSOLOGINBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iTENSACESSOLOGINBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox cODACESSO_FKComboBox;
        private System.Windows.Forms.ComboBox cODLOGIN_FKComboBox;
        private System.Windows.Forms.DataGridView iTENSACESSOLOGINDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource aCESSOBindingSource;
        private ATIVIDADEDataSetTableAdapters.ACESSOTableAdapter aCESSOTableAdapter;
        private System.Windows.Forms.BindingSource lOGINBindingSource;
        private ATIVIDADEDataSetTableAdapters.LOGINTableAdapter lOGINTableAdapter;
    }
}