namespace ProjetoBancoDAD
{
    partial class FrmLogin
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
            System.Windows.Forms.Label cODLOGINLabel;
            System.Windows.Forms.Label uSUARIOLabel;
            System.Windows.Forms.Label sENHALabel;
            System.Windows.Forms.Label cODFUNCIONARIO_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.lOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGINTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.LOGINTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.lOGINBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lOGINBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODLOGINLabel1 = new System.Windows.Forms.Label();
            this.uSUARIOTextBox = new System.Windows.Forms.TextBox();
            this.sENHATextBox = new System.Windows.Forms.TextBox();
            this.cODFUNCIONARIO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lOGINDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUNCIONARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCIONARIOSTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.FUNCIONARIOSTableAdapter();
            cODLOGINLabel = new System.Windows.Forms.Label();
            uSUARIOLabel = new System.Windows.Forms.Label();
            sENHALabel = new System.Windows.Forms.Label();
            cODFUNCIONARIO_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingNavigator)).BeginInit();
            this.lOGINBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODLOGINLabel
            // 
            cODLOGINLabel.AutoSize = true;
            cODLOGINLabel.Location = new System.Drawing.Point(12, 48);
            cODLOGINLabel.Name = "cODLOGINLabel";
            cODLOGINLabel.Size = new System.Drawing.Size(72, 13);
            cODLOGINLabel.TabIndex = 1;
            cODLOGINLabel.Text = "Código Login:";
            // 
            // uSUARIOLabel
            // 
            uSUARIOLabel.AutoSize = true;
            uSUARIOLabel.Location = new System.Drawing.Point(26, 80);
            uSUARIOLabel.Name = "uSUARIOLabel";
            uSUARIOLabel.Size = new System.Drawing.Size(46, 13);
            uSUARIOLabel.TabIndex = 3;
            uSUARIOLabel.Text = "Usuário:";
            // 
            // sENHALabel
            // 
            sENHALabel.AutoSize = true;
            sENHALabel.Location = new System.Drawing.Point(26, 111);
            sENHALabel.Name = "sENHALabel";
            sENHALabel.Size = new System.Drawing.Size(41, 13);
            sENHALabel.TabIndex = 5;
            sENHALabel.Text = "Senha:";
            // 
            // cODFUNCIONARIO_FKLabel
            // 
            cODFUNCIONARIO_FKLabel.AutoSize = true;
            cODFUNCIONARIO_FKLabel.Location = new System.Drawing.Point(299, 51);
            cODFUNCIONARIO_FKLabel.Name = "cODFUNCIONARIO_FKLabel";
            cODFUNCIONARIO_FKLabel.Size = new System.Drawing.Size(114, 13);
            cODFUNCIONARIO_FKLabel.TabIndex = 7;
            cODFUNCIONARIO_FKLabel.Text = "Código FuncionárioFK:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.LOGINTableAdapter = this.lOGINTableAdapter;
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
            // lOGINBindingNavigator
            // 
            this.lOGINBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lOGINBindingNavigator.BindingSource = this.lOGINBindingSource;
            this.lOGINBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lOGINBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lOGINBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lOGINBindingNavigatorSaveItem});
            this.lOGINBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lOGINBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lOGINBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lOGINBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lOGINBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lOGINBindingNavigator.Name = "lOGINBindingNavigator";
            this.lOGINBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lOGINBindingNavigator.Size = new System.Drawing.Size(878, 25);
            this.lOGINBindingNavigator.TabIndex = 0;
            this.lOGINBindingNavigator.Text = "bindingNavigator1";
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
            // lOGINBindingNavigatorSaveItem
            // 
            this.lOGINBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lOGINBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lOGINBindingNavigatorSaveItem.Image")));
            this.lOGINBindingNavigatorSaveItem.Name = "lOGINBindingNavigatorSaveItem";
            this.lOGINBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lOGINBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.lOGINBindingNavigatorSaveItem.Click += new System.EventHandler(this.lOGINBindingNavigatorSaveItem_Click);
            // 
            // cODLOGINLabel1
            // 
            this.cODLOGINLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOGINBindingSource, "CODLOGIN", true));
            this.cODLOGINLabel1.Location = new System.Drawing.Point(90, 48);
            this.cODLOGINLabel1.Name = "cODLOGINLabel1";
            this.cODLOGINLabel1.Size = new System.Drawing.Size(121, 23);
            this.cODLOGINLabel1.TabIndex = 2;
            this.cODLOGINLabel1.Text = "label1";
            // 
            // uSUARIOTextBox
            // 
            this.uSUARIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOGINBindingSource, "USUARIO", true));
            this.uSUARIOTextBox.Location = new System.Drawing.Point(78, 77);
            this.uSUARIOTextBox.Name = "uSUARIOTextBox";
            this.uSUARIOTextBox.Size = new System.Drawing.Size(121, 20);
            this.uSUARIOTextBox.TabIndex = 4;
            // 
            // sENHATextBox
            // 
            this.sENHATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOGINBindingSource, "SENHA", true));
            this.sENHATextBox.Location = new System.Drawing.Point(78, 108);
            this.sENHATextBox.Name = "sENHATextBox";
            this.sENHATextBox.Size = new System.Drawing.Size(121, 20);
            this.sENHATextBox.TabIndex = 6;
            this.sENHATextBox.TextChanged += new System.EventHandler(this.sENHATextBox_TextChanged);
            // 
            // cODFUNCIONARIO_FKComboBox
            // 
            this.cODFUNCIONARIO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lOGINBindingSource, "CODFUNCIONARIO_FK", true));
            this.cODFUNCIONARIO_FKComboBox.DataSource = this.fUNCIONARIOSBindingSource;
            this.cODFUNCIONARIO_FKComboBox.DisplayMember = "NOMEFUNCIONARIO";
            this.cODFUNCIONARIO_FKComboBox.FormattingEnabled = true;
            this.cODFUNCIONARIO_FKComboBox.Location = new System.Drawing.Point(428, 48);
            this.cODFUNCIONARIO_FKComboBox.Name = "cODFUNCIONARIO_FKComboBox";
            this.cODFUNCIONARIO_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODFUNCIONARIO_FKComboBox.TabIndex = 8;
            this.cODFUNCIONARIO_FKComboBox.ValueMember = "CODFUNCIONARIOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Revelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lOGINDataGridView
            // 
            this.lOGINDataGridView.AutoGenerateColumns = false;
            this.lOGINDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lOGINDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.lOGINDataGridView.DataSource = this.lOGINBindingSource;
            this.lOGINDataGridView.Location = new System.Drawing.Point(29, 154);
            this.lOGINDataGridView.Name = "lOGINDataGridView";
            this.lOGINDataGridView.ReadOnly = true;
            this.lOGINDataGridView.Size = new System.Drawing.Size(849, 220);
            this.lOGINDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODLOGIN";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Login";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "USUARIO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Usuário";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SENHA";
            this.dataGridViewTextBoxColumn3.HeaderText = "Senha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CODFUNCIONARIO_FK";
            this.dataGridViewTextBoxColumn4.HeaderText = "Código FuncionárioFK";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // fUNCIONARIOSBindingSource
            // 
            this.fUNCIONARIOSBindingSource.DataMember = "FUNCIONARIOS";
            this.fUNCIONARIOSBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // fUNCIONARIOSTableAdapter
            // 
            this.fUNCIONARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 393);
            this.Controls.Add(this.lOGINDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cODLOGINLabel);
            this.Controls.Add(this.cODLOGINLabel1);
            this.Controls.Add(uSUARIOLabel);
            this.Controls.Add(this.uSUARIOTextBox);
            this.Controls.Add(sENHALabel);
            this.Controls.Add(this.sENHATextBox);
            this.Controls.Add(cODFUNCIONARIO_FKLabel);
            this.Controls.Add(this.cODFUNCIONARIO_FKComboBox);
            this.Controls.Add(this.lOGINBindingNavigator);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingNavigator)).EndInit();
            this.lOGINBindingNavigator.ResumeLayout(false);
            this.lOGINBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource lOGINBindingSource;
        private ATIVIDADEDataSetTableAdapters.LOGINTableAdapter lOGINTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lOGINBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lOGINBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODLOGINLabel1;
        private System.Windows.Forms.TextBox uSUARIOTextBox;
        private System.Windows.Forms.TextBox sENHATextBox;
        private System.Windows.Forms.ComboBox cODFUNCIONARIO_FKComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView lOGINDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource fUNCIONARIOSBindingSource;
        private ATIVIDADEDataSetTableAdapters.FUNCIONARIOSTableAdapter fUNCIONARIOSTableAdapter;
    }
}