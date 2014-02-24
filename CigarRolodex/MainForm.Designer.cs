namespace CigarRolodex {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label styleLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label countLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cigarListDataSet = new CigarRolodex.cigarListDataSet();
            this.cigarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cigarsTableAdapter = new CigarRolodex.cigarListDataSetTableAdapters.cigarsTableAdapter();
            this.tableAdapterManager = new CigarRolodex.cigarListDataSetTableAdapters.TableAdapterManager();
            this.cigarsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cigarsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.styleTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.labelPictureBox = new System.Windows.Forms.PictureBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.queryLbl = new System.Windows.Forms.Label();
            this.topQueryBtn = new System.Windows.Forms.Button();
            this.priceQueryBtn = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            styleLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cigarListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cigarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cigarsBindingNavigator)).BeginInit();
            this.cigarsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(21, 104);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new System.Drawing.Point(21, 130);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(38, 13);
            brandLabel.TabIndex = 3;
            brandLabel.Text = "Brand:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(21, 156);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // styleLabel
            // 
            styleLabel.AutoSize = true;
            styleLabel.Location = new System.Drawing.Point(21, 182);
            styleLabel.Name = "styleLabel";
            styleLabel.Size = new System.Drawing.Size(33, 13);
            styleLabel.TabIndex = 7;
            styleLabel.Text = "Style:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(21, 208);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Price:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(226, 104);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(41, 13);
            ratingLabel.TabIndex = 11;
            ratingLabel.Text = "Rating:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(174, 208);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(38, 13);
            countLabel.TabIndex = 15;
            countLabel.Text = "Count:";
            // 
            // cigarListDataSet
            // 
            this.cigarListDataSet.DataSetName = "cigarListDataSet";
            this.cigarListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cigarsBindingSource
            // 
            this.cigarsBindingSource.DataMember = "cigars";
            this.cigarsBindingSource.DataSource = this.cigarListDataSet;
            // 
            // cigarsTableAdapter
            // 
            this.cigarsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cigarsTableAdapter = this.cigarsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CigarRolodex.cigarListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cigarsBindingNavigator
            // 
            this.cigarsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cigarsBindingNavigator.BindingSource = this.cigarsBindingSource;
            this.cigarsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cigarsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cigarsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cigarsBindingNavigatorSaveItem});
            this.cigarsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cigarsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cigarsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cigarsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cigarsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cigarsBindingNavigator.Name = "cigarsBindingNavigator";
            this.cigarsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cigarsBindingNavigator.Size = new System.Drawing.Size(404, 25);
            this.cigarsBindingNavigator.TabIndex = 0;
            this.cigarsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cigarsBindingNavigatorSaveItem
            // 
            this.cigarsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cigarsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cigarsBindingNavigatorSaveItem.Image")));
            this.cigarsBindingNavigatorSaveItem.Name = "cigarsBindingNavigatorSaveItem";
            this.cigarsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cigarsBindingNavigatorSaveItem.Text = "Save Data";
            this.cigarsBindingNavigatorSaveItem.Click += new System.EventHandler(this.cigarsBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cigarsBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(68, 101);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(53, 20);
            this.iDTextBox.TabIndex = 2;
            this.iDTextBox.TabStop = false;
            // 
            // brandTextBox
            // 
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cigarsBindingSource, "Brand", true));
            this.brandTextBox.Location = new System.Drawing.Point(68, 127);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(233, 20);
            this.brandTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cigarsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(68, 153);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(233, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // styleTextBox
            // 
            this.styleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cigarsBindingSource, "Style", true));
            this.styleTextBox.Location = new System.Drawing.Point(68, 179);
            this.styleTextBox.Name = "styleTextBox";
            this.styleTextBox.Size = new System.Drawing.Size(144, 20);
            this.styleTextBox.TabIndex = 8;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cigarsBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(68, 205);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(76, 20);
            this.priceTextBox.TabIndex = 10;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cigarsBindingSource, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(273, 101);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(28, 20);
            this.ratingTextBox.TabIndex = 12;
            // 
            // labelPictureBox
            // 
            this.labelPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.cigarsBindingSource, "label", true));
            this.labelPictureBox.Location = new System.Drawing.Point(24, 40);
            this.labelPictureBox.Name = "labelPictureBox";
            this.labelPictureBox.Size = new System.Drawing.Size(277, 50);
            this.labelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.labelPictureBox.TabIndex = 14;
            this.labelPictureBox.TabStop = false;
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cigarsBindingSource, "Count", true));
            this.countTextBox.Location = new System.Drawing.Point(221, 205);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(80, 20);
            this.countTextBox.TabIndex = 16;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(307, 40);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(85, 23);
            this.selectBtn.TabIndex = 17;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(307, 67);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 23);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(307, 96);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(85, 23);
            this.exitBtn.TabIndex = 19;
            this.exitBtn.Text = "Close";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // queryLbl
            // 
            this.queryLbl.AutoSize = true;
            this.queryLbl.Location = new System.Drawing.Point(319, 156);
            this.queryLbl.Name = "queryLbl";
            this.queryLbl.Size = new System.Drawing.Size(58, 13);
            this.queryLbl.TabIndex = 20;
            this.queryLbl.Text = "Report List";
            // 
            // topQueryBtn
            // 
            this.topQueryBtn.Location = new System.Drawing.Point(307, 177);
            this.topQueryBtn.Name = "topQueryBtn";
            this.topQueryBtn.Size = new System.Drawing.Size(85, 23);
            this.topQueryBtn.TabIndex = 21;
            this.topQueryBtn.Text = "Top Rating";
            this.topQueryBtn.UseVisualStyleBackColor = true;
            this.topQueryBtn.Click += new System.EventHandler(this.topQueryBtn_Click);
            // 
            // priceQueryBtn
            // 
            this.priceQueryBtn.Location = new System.Drawing.Point(307, 203);
            this.priceQueryBtn.Name = "priceQueryBtn";
            this.priceQueryBtn.Size = new System.Drawing.Size(85, 23);
            this.priceQueryBtn.TabIndex = 22;
            this.priceQueryBtn.Text = "Low to High $";
            this.priceQueryBtn.UseVisualStyleBackColor = true;
            this.priceQueryBtn.Click += new System.EventHandler(this.priceQueryBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 252);
            this.Controls.Add(this.priceQueryBtn);
            this.Controls.Add(this.topQueryBtn);
            this.Controls.Add(this.queryLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(styleLabel);
            this.Controls.Add(this.styleTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.labelPictureBox);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.cigarsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cigar Rolodex";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cigarListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cigarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cigarsBindingNavigator)).EndInit();
            this.cigarsBindingNavigator.ResumeLayout(false);
            this.cigarsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cigarListDataSet cigarListDataSet;
        private System.Windows.Forms.BindingSource cigarsBindingSource;
        private cigarListDataSetTableAdapters.cigarsTableAdapter cigarsTableAdapter;
        private cigarListDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cigarsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cigarsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox styleTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.PictureBox labelPictureBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label queryLbl;
        private System.Windows.Forms.Button topQueryBtn;
        private System.Windows.Forms.Button priceQueryBtn;
    }
}

