namespace CKK.UI
{
    partial class AddNewItemForm_IMS
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
            CreateNewItemButton = new Button();
            ItemInfoLabel = new Label();
            ItemInfoMenuBox = new GroupBox();
            CancelButton = new Button();
            CreateItemInformationBox = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            ItemIdBox = new TextBox();
            EditItemQuantityTextBox = new TextBox();
            EditItemPriceTextBox = new TextBox();
            EditItemNameTextBox = new TextBox();
            ItemInfoMenuBox.SuspendLayout();
            CreateItemInformationBox.SuspendLayout();
            SuspendLayout();
            // 
            // CreateNewItemButton
            // 
            CreateNewItemButton.Location = new Point(8, 31);
            CreateNewItemButton.Margin = new Padding(3, 7, 3, 7);
            CreateNewItemButton.Name = "CreateNewItemButton";
            CreateNewItemButton.Size = new Size(130, 67);
            CreateNewItemButton.TabIndex = 4;
            CreateNewItemButton.Text = "Create New Item";
            CreateNewItemButton.UseVisualStyleBackColor = true;
            CreateNewItemButton.Click += CreateNewItemButton_Click;
            // 
            // ItemInfoLabel
            // 
            ItemInfoLabel.AutoSize = true;
            ItemInfoLabel.Font = new Font("Segoe UI", 10F);
            ItemInfoLabel.Location = new Point(196, 9);
            ItemInfoLabel.Name = "ItemInfoLabel";
            ItemInfoLabel.Size = new Size(120, 23);
            ItemInfoLabel.TabIndex = 14;
            ItemInfoLabel.Text = "Add New Item";
            // 
            // ItemInfoMenuBox
            // 
            ItemInfoMenuBox.Controls.Add(CreateNewItemButton);
            ItemInfoMenuBox.Controls.Add(CancelButton);
            ItemInfoMenuBox.Location = new Point(363, 36);
            ItemInfoMenuBox.Margin = new Padding(3, 4, 3, 4);
            ItemInfoMenuBox.Name = "ItemInfoMenuBox";
            ItemInfoMenuBox.Padding = new Padding(3, 4, 3, 4);
            ItemInfoMenuBox.Size = new Size(144, 199);
            ItemInfoMenuBox.TabIndex = 0;
            ItemInfoMenuBox.TabStop = false;
            ItemInfoMenuBox.Text = "Menu";
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(8, 112);
            CancelButton.Margin = new Padding(3, 7, 3, 7);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(130, 67);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // CreateItemInformationBox
            // 
            CreateItemInformationBox.Controls.Add(label12);
            CreateItemInformationBox.Controls.Add(label11);
            CreateItemInformationBox.Controls.Add(label10);
            CreateItemInformationBox.Controls.Add(label9);
            CreateItemInformationBox.Controls.Add(ItemIdBox);
            CreateItemInformationBox.Controls.Add(EditItemQuantityTextBox);
            CreateItemInformationBox.Controls.Add(EditItemPriceTextBox);
            CreateItemInformationBox.Controls.Add(EditItemNameTextBox);
            CreateItemInformationBox.Location = new Point(12, 36);
            CreateItemInformationBox.Margin = new Padding(3, 4, 3, 4);
            CreateItemInformationBox.Name = "CreateItemInformationBox";
            CreateItemInformationBox.Padding = new Padding(3, 4, 3, 4);
            CreateItemInformationBox.Size = new Size(345, 199);
            CreateItemInformationBox.TabIndex = 15;
            CreateItemInformationBox.TabStop = false;
            CreateItemInformationBox.Text = "Create Item Information";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(62, 158);
            label12.Name = "label12";
            label12.Size = new Size(24, 20);
            label12.TabIndex = 14;
            label12.Text = "ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 117);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 14;
            label11.Text = "Quantity";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 77);
            label10.Name = "label10";
            label10.Size = new Size(53, 20);
            label10.TabIndex = 14;
            label10.Text = "Price $";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 35);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 14;
            label9.Text = "Name";
            // 
            // ItemIdBox
            // 
            ItemIdBox.Enabled = false;
            ItemIdBox.Location = new Point(89, 152);
            ItemIdBox.Margin = new Padding(3, 4, 3, 4);
            ItemIdBox.Name = "ItemIdBox";
            ItemIdBox.PlaceholderText = "Id Will Auto-Generate";
            ItemIdBox.Size = new Size(249, 27);
            ItemIdBox.TabIndex = 17;
            // 
            // EditItemQuantityTextBox
            // 
            EditItemQuantityTextBox.Location = new Point(89, 111);
            EditItemQuantityTextBox.Margin = new Padding(3, 4, 3, 4);
            EditItemQuantityTextBox.Name = "EditItemQuantityTextBox";
            EditItemQuantityTextBox.Size = new Size(249, 27);
            EditItemQuantityTextBox.TabIndex = 16;
            // 
            // EditItemPriceTextBox
            // 
            EditItemPriceTextBox.Location = new Point(89, 72);
            EditItemPriceTextBox.Margin = new Padding(3, 4, 3, 4);
            EditItemPriceTextBox.Name = "EditItemPriceTextBox";
            EditItemPriceTextBox.Size = new Size(249, 27);
            EditItemPriceTextBox.TabIndex = 15;
            // 
            // EditItemNameTextBox
            // 
            EditItemNameTextBox.Location = new Point(89, 29);
            EditItemNameTextBox.Margin = new Padding(3, 4, 3, 4);
            EditItemNameTextBox.Name = "EditItemNameTextBox";
            EditItemNameTextBox.Size = new Size(249, 27);
            EditItemNameTextBox.TabIndex = 14;
            // 
            // AddNewItemForm_IMS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 254);
            Controls.Add(ItemInfoLabel);
            Controls.Add(CreateItemInformationBox);
            Controls.Add(ItemInfoMenuBox);
            Name = "AddNewItemForm_IMS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Item Form";
            ItemInfoMenuBox.ResumeLayout(false);
            CreateItemInformationBox.ResumeLayout(false);
            CreateItemInformationBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CreateNewItemButton;
        private Label ItemInfoLabel;
        private GroupBox ItemInfoMenuBox;
        private Button CancelButton;
        private GroupBox CreateItemInformationBox;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox ItemIdBox;
        private TextBox EditItemQuantityTextBox;
        private TextBox EditItemPriceTextBox;
        private TextBox EditItemNameTextBox;
    }
}