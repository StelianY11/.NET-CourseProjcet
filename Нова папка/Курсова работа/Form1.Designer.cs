namespace Курсова_работа
{
    partial class Form1
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
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label kolichestvoLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stokaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.stokaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cenaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.iDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kolichestvoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.stokaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cenaLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            kolichestvoLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stokaBindingNavigator)).BeginInit();
            this.stokaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cenaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolichestvoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(64, 293);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(42, 16);
            cenaLabel.TabIndex = 2;
            cenaLabel.Text = "Cena:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(64, 321);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 16);
            iDLabel.TabIndex = 4;
            iDLabel.Text = "ID:";
            // 
            // kolichestvoLabel
            // 
            kolichestvoLabel.AutoSize = true;
            kolichestvoLabel.Location = new System.Drawing.Point(64, 349);
            kolichestvoLabel.Name = "kolichestvoLabel";
            kolichestvoLabel.Size = new System.Drawing.Size(79, 16);
            kolichestvoLabel.TabIndex = 6;
            kolichestvoLabel.Text = "Kolichestvo:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(64, 380);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 16);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // stokaBindingNavigator
            // 
            this.stokaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stokaBindingNavigator.BindingSource = this.stokaBindingSource;
            this.stokaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stokaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stokaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stokaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.stokaBindingNavigatorSaveItem});
            this.stokaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stokaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stokaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stokaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stokaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stokaBindingNavigator.Name = "stokaBindingNavigator";
            this.stokaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stokaBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.stokaBindingNavigator.TabIndex = 0;
            this.stokaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // stokaBindingNavigatorSaveItem
            // 
            this.stokaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stokaBindingNavigatorSaveItem.Enabled = false;
            this.stokaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stokaBindingNavigatorSaveItem.Image")));
            this.stokaBindingNavigatorSaveItem.Name = "stokaBindingNavigatorSaveItem";
            this.stokaBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.stokaBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // cenaNumericUpDown
            // 
            this.cenaNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.stokaBindingSource, "Cena", true));
            this.cenaNumericUpDown.Location = new System.Drawing.Point(149, 293);
            this.cenaNumericUpDown.Name = "cenaNumericUpDown";
            this.cenaNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.cenaNumericUpDown.TabIndex = 3;
            // 
            // iDNumericUpDown
            // 
            this.iDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.stokaBindingSource, "ID", true));
            this.iDNumericUpDown.Location = new System.Drawing.Point(149, 321);
            this.iDNumericUpDown.Name = "iDNumericUpDown";
            this.iDNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.iDNumericUpDown.TabIndex = 5;
            // 
            // kolichestvoNumericUpDown
            // 
            this.kolichestvoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.stokaBindingSource, "Kolichestvo", true));
            this.kolichestvoNumericUpDown.Location = new System.Drawing.Point(149, 349);
            this.kolichestvoNumericUpDown.Name = "kolichestvoNumericUpDown";
            this.kolichestvoNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.kolichestvoNumericUpDown.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stokaBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(149, 377);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(120, 22);
            this.nameTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(671, 243);
            this.dataGridView1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(663, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stokaBindingSource
            // 
            this.stokaBindingSource.DataSource = typeof(Курсова_работа.Stoka);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.cenaNumericUpDown);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDNumericUpDown);
            this.Controls.Add(kolichestvoLabel);
            this.Controls.Add(this.kolichestvoNumericUpDown);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.stokaBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stokaBindingNavigator)).EndInit();
            this.stokaBindingNavigator.ResumeLayout(false);
            this.stokaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cenaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolichestvoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource stokaBindingSource;
        private System.Windows.Forms.BindingNavigator stokaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton stokaBindingNavigatorSaveItem;
        private System.Windows.Forms.NumericUpDown cenaNumericUpDown;
        private System.Windows.Forms.NumericUpDown iDNumericUpDown;
        private System.Windows.Forms.NumericUpDown kolichestvoNumericUpDown;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}

