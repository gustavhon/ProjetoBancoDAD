namespace ProjetoBancoDAD
{
    partial class FrmImagens
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
            System.Windows.Forms.Label cODIMAGENSLabel;
            System.Windows.Forms.Label iMAGEMLabel;
            System.Windows.Forms.Label dESCRICAOLabel;
            System.Windows.Forms.Label cODPRODUTO_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImagens));
            this.aTIVIDADEDataSet = new ProjetoBancoDAD.ATIVIDADEDataSet();
            this.iMAGENSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iMAGENSTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.IMAGENSTableAdapter();
            this.tableAdapterManager = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.TableAdapterManager();
            this.iMAGENSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iMAGENSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cODIMAGENSLabel1 = new System.Windows.Forms.Label();
            this.iMAGEMPictureBox = new System.Windows.Forms.PictureBox();
            this.dESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.cODPRODUTO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.iMAGENSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.pRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOTableAdapter = new ProjetoBancoDAD.ATIVIDADEDataSetTableAdapters.PRODUTOTableAdapter();
            cODIMAGENSLabel = new System.Windows.Forms.Label();
            iMAGEMLabel = new System.Windows.Forms.Label();
            dESCRICAOLabel = new System.Windows.Forms.Label();
            cODPRODUTO_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGENSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGENSBindingNavigator)).BeginInit();
            this.iMAGENSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGEMPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGENSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODIMAGENSLabel
            // 
            cODIMAGENSLabel.AutoSize = true;
            cODIMAGENSLabel.Location = new System.Drawing.Point(6, 62);
            cODIMAGENSLabel.Name = "cODIMAGENSLabel";
            cODIMAGENSLabel.Size = new System.Drawing.Size(82, 13);
            cODIMAGENSLabel.TabIndex = 1;
            cODIMAGENSLabel.Text = "CODIMAGENS:";
            // 
            // iMAGEMLabel
            // 
            iMAGEMLabel.AutoSize = true;
            iMAGEMLabel.Location = new System.Drawing.Point(6, 88);
            iMAGEMLabel.Name = "iMAGEMLabel";
            iMAGEMLabel.Size = new System.Drawing.Size(53, 13);
            iMAGEMLabel.TabIndex = 3;
            iMAGEMLabel.Text = "IMAGEM:";
            // 
            // dESCRICAOLabel
            // 
            dESCRICAOLabel.AutoSize = true;
            dESCRICAOLabel.Location = new System.Drawing.Point(277, 72);
            dESCRICAOLabel.Name = "dESCRICAOLabel";
            dESCRICAOLabel.Size = new System.Drawing.Size(72, 13);
            dESCRICAOLabel.TabIndex = 5;
            dESCRICAOLabel.Text = "DESCRICAO:";
            // 
            // cODPRODUTO_FKLabel
            // 
            cODPRODUTO_FKLabel.AutoSize = true;
            cODPRODUTO_FKLabel.Location = new System.Drawing.Point(526, 71);
            cODPRODUTO_FKLabel.Name = "cODPRODUTO_FKLabel";
            cODPRODUTO_FKLabel.Size = new System.Drawing.Size(103, 13);
            cODPRODUTO_FKLabel.TabIndex = 7;
            cODPRODUTO_FKLabel.Text = "CODPRODUTO FK:";
            // 
            // aTIVIDADEDataSet
            // 
            this.aTIVIDADEDataSet.DataSetName = "ATIVIDADEDataSet";
            this.aTIVIDADEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iMAGENSBindingSource
            // 
            this.iMAGENSBindingSource.DataMember = "IMAGENS";
            this.iMAGENSBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // iMAGENSTableAdapter
            // 
            this.iMAGENSTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.IMAGENSTableAdapter = this.iMAGENSTableAdapter;
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
            // iMAGENSBindingNavigator
            // 
            this.iMAGENSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iMAGENSBindingNavigator.BindingSource = this.iMAGENSBindingSource;
            this.iMAGENSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iMAGENSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iMAGENSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iMAGENSBindingNavigatorSaveItem});
            this.iMAGENSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iMAGENSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iMAGENSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iMAGENSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iMAGENSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iMAGENSBindingNavigator.Name = "iMAGENSBindingNavigator";
            this.iMAGENSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iMAGENSBindingNavigator.Size = new System.Drawing.Size(857, 25);
            this.iMAGENSBindingNavigator.TabIndex = 0;
            this.iMAGENSBindingNavigator.Text = "bindingNavigator1";
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
            // iMAGENSBindingNavigatorSaveItem
            // 
            this.iMAGENSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iMAGENSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iMAGENSBindingNavigatorSaveItem.Image")));
            this.iMAGENSBindingNavigatorSaveItem.Name = "iMAGENSBindingNavigatorSaveItem";
            this.iMAGENSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iMAGENSBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.iMAGENSBindingNavigatorSaveItem.Click += new System.EventHandler(this.iMAGENSBindingNavigatorSaveItem_Click_4);
            // 
            // cODIMAGENSLabel1
            // 
            this.cODIMAGENSLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iMAGENSBindingSource, "CODIMAGENS", true));
            this.cODIMAGENSLabel1.Location = new System.Drawing.Point(115, 62);
            this.cODIMAGENSLabel1.Name = "cODIMAGENSLabel1";
            this.cODIMAGENSLabel1.Size = new System.Drawing.Size(121, 23);
            this.cODIMAGENSLabel1.TabIndex = 2;
            this.cODIMAGENSLabel1.Text = "label1";
            // 
            // iMAGEMPictureBox
            // 
            this.iMAGEMPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.iMAGENSBindingSource, "IMAGEM", true));
            this.iMAGEMPictureBox.Location = new System.Drawing.Point(65, 88);
            this.iMAGEMPictureBox.Name = "iMAGEMPictureBox";
            this.iMAGEMPictureBox.Size = new System.Drawing.Size(121, 77);
            this.iMAGEMPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iMAGEMPictureBox.TabIndex = 4;
            this.iMAGEMPictureBox.TabStop = false;
            // 
            // dESCRICAOTextBox
            // 
            this.dESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iMAGENSBindingSource, "DESCRICAO", true));
            this.dESCRICAOTextBox.Location = new System.Drawing.Point(386, 69);
            this.dESCRICAOTextBox.Name = "dESCRICAOTextBox";
            this.dESCRICAOTextBox.Size = new System.Drawing.Size(121, 20);
            this.dESCRICAOTextBox.TabIndex = 6;
            // 
            // cODPRODUTO_FKComboBox
            // 
            this.cODPRODUTO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iMAGENSBindingSource, "CODPRODUTO_FK", true));
            this.cODPRODUTO_FKComboBox.DataSource = this.pRODUTOBindingSource;
            this.cODPRODUTO_FKComboBox.DisplayMember = "NOMEPRODUTO";
            this.cODPRODUTO_FKComboBox.FormattingEnabled = true;
            this.cODPRODUTO_FKComboBox.Location = new System.Drawing.Point(635, 68);
            this.cODPRODUTO_FKComboBox.Name = "cODPRODUTO_FKComboBox";
            this.cODPRODUTO_FKComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODPRODUTO_FKComboBox.TabIndex = 8;
            this.cODPRODUTO_FKComboBox.ValueMember = "CODPRODUTO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(762, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iMAGENSDataGridView
            // 
            this.iMAGENSDataGridView.AutoGenerateColumns = false;
            this.iMAGENSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iMAGENSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.iMAGENSDataGridView.DataSource = this.iMAGENSBindingSource;
            this.iMAGENSDataGridView.Location = new System.Drawing.Point(9, 171);
            this.iMAGENSDataGridView.Name = "iMAGENSDataGridView";
            this.iMAGENSDataGridView.ReadOnly = true;
            this.iMAGENSDataGridView.Size = new System.Drawing.Size(848, 220);
            this.iMAGENSDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODIMAGENS";
            this.dataGridViewTextBoxColumn1.HeaderText = "CODIMAGENS";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "IMAGEM";
            this.dataGridViewImageColumn1.HeaderText = "IMAGEM";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DESCRICAO";
            this.dataGridViewTextBoxColumn2.HeaderText = "DESCRICAO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CODPRODUTO_FK";
            this.dataGridViewTextBoxColumn3.HeaderText = "CODPRODUTO_FK";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Adicionar Imagem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pRODUTOBindingSource
            // 
            this.pRODUTOBindingSource.DataMember = "PRODUTO";
            this.pRODUTOBindingSource.DataSource = this.aTIVIDADEDataSet;
            // 
            // pRODUTOTableAdapter
            // 
            this.pRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmImagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.iMAGENSDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(cODIMAGENSLabel);
            this.Controls.Add(this.cODIMAGENSLabel1);
            this.Controls.Add(iMAGEMLabel);
            this.Controls.Add(this.iMAGEMPictureBox);
            this.Controls.Add(dESCRICAOLabel);
            this.Controls.Add(this.dESCRICAOTextBox);
            this.Controls.Add(cODPRODUTO_FKLabel);
            this.Controls.Add(this.cODPRODUTO_FKComboBox);
            this.Controls.Add(this.iMAGENSBindingNavigator);
            this.Name = "FrmImagens";
            this.Text = "FrmImagens";
            this.Load += new System.EventHandler(this.FrmImagens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTIVIDADEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGENSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGENSBindingNavigator)).EndInit();
            this.iMAGENSBindingNavigator.ResumeLayout(false);
            this.iMAGENSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGEMPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGENSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATIVIDADEDataSet aTIVIDADEDataSet;
        private System.Windows.Forms.BindingSource iMAGENSBindingSource;
        private ATIVIDADEDataSetTableAdapters.IMAGENSTableAdapter iMAGENSTableAdapter;
        private ATIVIDADEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iMAGENSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iMAGENSBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cODIMAGENSLabel1;
        private System.Windows.Forms.PictureBox iMAGEMPictureBox;
        private System.Windows.Forms.TextBox dESCRICAOTextBox;
        private System.Windows.Forms.ComboBox cODPRODUTO_FKComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView iMAGENSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource pRODUTOBindingSource;
        private ATIVIDADEDataSetTableAdapters.PRODUTOTableAdapter pRODUTOTableAdapter;
    }
}