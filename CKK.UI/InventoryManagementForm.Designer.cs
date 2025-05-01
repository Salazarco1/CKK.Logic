namespace CKK.UI;

partial class InventoryManagementForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        splitContainer1 = new SplitContainer();
        SearchInventoryUI = new GroupBox();
        FilterGroupBox = new GroupBox();
        ClearFiltersButton = new Button();
        FilterByQuantityButton = new RadioButton();
        radioButtonPrice = new RadioButton();
        ResultLabel = new Label();
        label4 = new Label();
        label3 = new Label();
        label1 = new Label();
        Name = new Label();
        SearchMenuBox = new GroupBox();
        ClearResultsButton = new Button();
        EditItemButton = new Button();
        AddNewItemButton = new Button();
        ViewAllInventoryButton = new Button();
        ResultBox = new ListBox();
        SearchButton = new Button();
        SearchBox = new TextBox();
        ItemInfoBox = new GroupBox();
        CreateNewItemButton = new Button();
        ItemInfoLabel = new Label();
        EditItemInfoBox = new GroupBox();
        label12 = new Label();
        label11 = new Label();
        label10 = new Label();
        label9 = new Label();
        ItemIdBox = new TextBox();
        EditItemQuantityTextBox = new TextBox();
        EditItemPriceTextBox = new TextBox();
        EditItemNameTextBox = new TextBox();
        label8 = new Label();
        label7 = new Label();
        label6 = new Label();
        label5 = new Label();
        label2 = new Label();
        ItemBreakDownBox = new TextBox();
        ItemInfoMenuBox = new GroupBox();
        CancelButton = new Button();
        RemoveItemButton = new Button();
        SaveButton = new Button();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        SearchInventoryUI.SuspendLayout();
        FilterGroupBox.SuspendLayout();
        SearchMenuBox.SuspendLayout();
        ItemInfoBox.SuspendLayout();
        EditItemInfoBox.SuspendLayout();
        ItemInfoMenuBox.SuspendLayout();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Margin = new Padding(3, 4, 3, 4);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(SearchInventoryUI);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(ItemInfoBox);
        splitContainer1.Panel2.Font = new Font("Segoe UI", 9F);
        splitContainer1.Size = new Size(1038, 492);
        splitContainer1.SplitterDistance = 491;
        splitContainer1.SplitterWidth = 5;
        splitContainer1.TabIndex = 0;
        // 
        // SearchInventoryUI
        // 
        SearchInventoryUI.Controls.Add(FilterGroupBox);
        SearchInventoryUI.Controls.Add(ResultLabel);
        SearchInventoryUI.Controls.Add(label4);
        SearchInventoryUI.Controls.Add(label3);
        SearchInventoryUI.Controls.Add(label1);
        SearchInventoryUI.Controls.Add(Name);
        SearchInventoryUI.Controls.Add(SearchMenuBox);
        SearchInventoryUI.Controls.Add(ResultBox);
        SearchInventoryUI.Controls.Add(SearchButton);
        SearchInventoryUI.Controls.Add(SearchBox);
        SearchInventoryUI.Location = new Point(3, 0);
        SearchInventoryUI.Margin = new Padding(3, 4, 3, 4);
        SearchInventoryUI.Name = "SearchInventoryUI";
        SearchInventoryUI.Padding = new Padding(3, 4, 3, 4);
        SearchInventoryUI.Size = new Size(489, 492);
        SearchInventoryUI.TabIndex = 6;
        SearchInventoryUI.TabStop = false;
        SearchInventoryUI.Text = "Search Inventory";
        // 
        // FilterGroupBox
        // 
        FilterGroupBox.Controls.Add(ClearFiltersButton);
        FilterGroupBox.Controls.Add(FilterByQuantityButton);
        FilterGroupBox.Controls.Add(radioButtonPrice);
        FilterGroupBox.Location = new Point(334, 16);
        FilterGroupBox.Margin = new Padding(3, 4, 3, 4);
        FilterGroupBox.Name = "FilterGroupBox";
        FilterGroupBox.Padding = new Padding(3, 4, 3, 4);
        FilterGroupBox.Size = new Size(144, 113);
        FilterGroupBox.TabIndex = 11;
        FilterGroupBox.TabStop = false;
        FilterGroupBox.Text = "Filters";
        // 
        // ClearFiltersButton
        // 
        ClearFiltersButton.Font = new Font("Segoe UI", 7F);
        ClearFiltersButton.Location = new Point(7, 75);
        ClearFiltersButton.Margin = new Padding(3, 4, 3, 4);
        ClearFiltersButton.Name = "ClearFiltersButton";
        ClearFiltersButton.Size = new Size(130, 31);
        ClearFiltersButton.TabIndex = 3;
        ClearFiltersButton.Text = "Clear";
        ClearFiltersButton.UseVisualStyleBackColor = true;
        ClearFiltersButton.Click += ClearFiltersButton_Click;
        // 
        // FilterByQuantityButton
        // 
        FilterByQuantityButton.AutoSize = true;
        FilterByQuantityButton.Font = new Font("Segoe UI", 7F);
        FilterByQuantityButton.Location = new Point(7, 23);
        FilterByQuantityButton.Margin = new Padding(3, 4, 3, 4);
        FilterByQuantityButton.Name = "FilterByQuantityButton";
        FilterByQuantityButton.Size = new Size(117, 19);
        FilterByQuantityButton.TabIndex = 1;
        FilterByQuantityButton.TabStop = true;
        FilterByQuantityButton.Text = "Sort By: Quantity";
        FilterByQuantityButton.UseVisualStyleBackColor = true;
        FilterByQuantityButton.CheckedChanged += FilterByQuantityButton_CheckedChanged;
        // 
        // radioButtonPrice
        // 
        radioButtonPrice.AutoSize = true;
        radioButtonPrice.Font = new Font("Segoe UI", 7F);
        radioButtonPrice.Location = new Point(7, 52);
        radioButtonPrice.Margin = new Padding(3, 4, 3, 4);
        radioButtonPrice.Name = "radioButtonPrice";
        radioButtonPrice.Size = new Size(97, 19);
        radioButtonPrice.TabIndex = 0;
        radioButtonPrice.TabStop = true;
        radioButtonPrice.Text = "Sort By: Price";
        radioButtonPrice.UseVisualStyleBackColor = true;
        radioButtonPrice.CheckedChanged += radioButton1_CheckedChanged;
        // 
        // ResultLabel
        // 
        ResultLabel.AutoSize = true;
        ResultLabel.Font = new Font("Segoe UI", 7F);
        ResultLabel.Location = new Point(7, 65);
        ResultLabel.Margin = new Padding(2, 0, 2, 0);
        ResultLabel.Name = "ResultLabel";
        ResultLabel.Size = new Size(44, 15);
        ResultLabel.TabIndex = 9;
        ResultLabel.Text = "Results";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(291, 85);
        label4.Name = "label4";
        label4.Size = new Size(24, 20);
        label4.TabIndex = 8;
        label4.Text = "ID";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(200, 85);
        label3.Name = "label3";
        label3.Size = new Size(65, 20);
        label3.TabIndex = 7;
        label3.Text = "Quantity";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(101, 85);
        label1.Name = "label1";
        label1.Size = new Size(41, 20);
        label1.TabIndex = 6;
        label1.Text = "Price";
        // 
        // Name
        // 
        Name.AutoSize = true;
        Name.Location = new Point(7, 85);
        Name.Name = "Name";
        Name.Size = new Size(49, 20);
        Name.TabIndex = 5;
        Name.Text = "Name";
        // 
        // SearchMenuBox
        // 
        SearchMenuBox.Controls.Add(ClearResultsButton);
        SearchMenuBox.Controls.Add(EditItemButton);
        SearchMenuBox.Controls.Add(AddNewItemButton);
        SearchMenuBox.Controls.Add(ViewAllInventoryButton);
        SearchMenuBox.Location = new Point(334, 129);
        SearchMenuBox.Margin = new Padding(3, 4, 3, 4);
        SearchMenuBox.Name = "SearchMenuBox";
        SearchMenuBox.Padding = new Padding(3, 4, 3, 4);
        SearchMenuBox.Size = new Size(144, 345);
        SearchMenuBox.TabIndex = 4;
        SearchMenuBox.TabStop = false;
        SearchMenuBox.Text = "Menu";
        // 
        // ClearResultsButton
        // 
        ClearResultsButton.Location = new Point(7, 117);
        ClearResultsButton.Margin = new Padding(3, 7, 3, 7);
        ClearResultsButton.Name = "ClearResultsButton";
        ClearResultsButton.Size = new Size(130, 67);
        ClearResultsButton.TabIndex = 4;
        ClearResultsButton.Text = "Clear Search";
        ClearResultsButton.UseVisualStyleBackColor = true;
        ClearResultsButton.Click += ClearResultsButton_Click;
        // 
        // EditItemButton
        // 
        EditItemButton.Location = new Point(7, 271);
        EditItemButton.Margin = new Padding(3, 7, 3, 7);
        EditItemButton.Name = "EditItemButton";
        EditItemButton.Size = new Size(130, 67);
        EditItemButton.TabIndex = 3;
        EditItemButton.Text = "Edit Item";
        EditItemButton.UseVisualStyleBackColor = true;
        EditItemButton.Click += EditItemButton_Click;
        // 
        // AddNewItemButton
        // 
        AddNewItemButton.Location = new Point(7, 193);
        AddNewItemButton.Margin = new Padding(3, 4, 3, 4);
        AddNewItemButton.Name = "AddNewItemButton";
        AddNewItemButton.Size = new Size(130, 67);
        AddNewItemButton.TabIndex = 1;
        AddNewItemButton.Text = "Add New Item";
        AddNewItemButton.UseVisualStyleBackColor = true;
        AddNewItemButton.Click += AddNewItemButton_Click;
        // 
        // ViewAllInventoryButton
        // 
        ViewAllInventoryButton.Location = new Point(7, 37);
        ViewAllInventoryButton.Margin = new Padding(3, 7, 3, 7);
        ViewAllInventoryButton.Name = "ViewAllInventoryButton";
        ViewAllInventoryButton.Size = new Size(130, 67);
        ViewAllInventoryButton.TabIndex = 0;
        ViewAllInventoryButton.Text = "View All Inventory";
        ViewAllInventoryButton.UseVisualStyleBackColor = true;
        ViewAllInventoryButton.Click += ViewAllInventoryButton_Click;
        // 
        // ResultBox
        // 
        ResultBox.FormattingEnabled = true;
        ResultBox.Location = new Point(7, 109);
        ResultBox.Margin = new Padding(3, 4, 3, 4);
        ResultBox.Name = "ResultBox";
        ResultBox.Size = new Size(319, 364);
        ResultBox.TabIndex = 3;
        // 
        // SearchButton
        // 
        SearchButton.Font = new Font("Segoe UI", 8F);
        SearchButton.Location = new Point(267, 29);
        SearchButton.Margin = new Padding(3, 4, 3, 4);
        SearchButton.Name = "SearchButton";
        SearchButton.Size = new Size(59, 31);
        SearchButton.TabIndex = 1;
        SearchButton.Text = "Search";
        SearchButton.UseVisualStyleBackColor = true;
        SearchButton.Click += SearchButton_Click;
        // 
        // SearchBox
        // 
        SearchBox.Location = new Point(7, 29);
        SearchBox.Margin = new Padding(3, 4, 3, 4);
        SearchBox.Name = "SearchBox";
        SearchBox.Size = new Size(253, 27);
        SearchBox.TabIndex = 0;
        SearchBox.Text = " ";
        // 
        // ItemInfoBox
        // 
        ItemInfoBox.Controls.Add(CreateNewItemButton);
        ItemInfoBox.Controls.Add(ItemInfoLabel);
        ItemInfoBox.Controls.Add(EditItemInfoBox);
        ItemInfoBox.Controls.Add(label8);
        ItemInfoBox.Controls.Add(label7);
        ItemInfoBox.Controls.Add(label6);
        ItemInfoBox.Controls.Add(label5);
        ItemInfoBox.Controls.Add(label2);
        ItemInfoBox.Controls.Add(ItemBreakDownBox);
        ItemInfoBox.Controls.Add(ItemInfoMenuBox);
        ItemInfoBox.Location = new Point(2, 0);
        ItemInfoBox.Margin = new Padding(3, 4, 3, 4);
        ItemInfoBox.Name = "ItemInfoBox";
        ItemInfoBox.Padding = new Padding(3, 4, 3, 4);
        ItemInfoBox.Size = new Size(541, 491);
        ItemInfoBox.TabIndex = 0;
        ItemInfoBox.TabStop = false;
        ItemInfoBox.Text = "Item Information";
        // 
        // CreateNewItemButton
        // 
        CreateNewItemButton.Location = new Point(139, 383);
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
        ItemInfoLabel.Location = new Point(123, 29);
        ItemInfoLabel.Name = "ItemInfoLabel";
        ItemInfoLabel.Size = new Size(120, 23);
        ItemInfoLabel.TabIndex = 14;
        ItemInfoLabel.Text = "Add New Item";
        // 
        // EditItemInfoBox
        // 
        EditItemInfoBox.Controls.Add(label12);
        EditItemInfoBox.Controls.Add(label11);
        EditItemInfoBox.Controls.Add(label10);
        EditItemInfoBox.Controls.Add(label9);
        EditItemInfoBox.Controls.Add(ItemIdBox);
        EditItemInfoBox.Controls.Add(EditItemQuantityTextBox);
        EditItemInfoBox.Controls.Add(EditItemPriceTextBox);
        EditItemInfoBox.Controls.Add(EditItemNameTextBox);
        EditItemInfoBox.Location = new Point(7, 173);
        EditItemInfoBox.Margin = new Padding(3, 4, 3, 4);
        EditItemInfoBox.Name = "EditItemInfoBox";
        EditItemInfoBox.Padding = new Padding(3, 4, 3, 4);
        EditItemInfoBox.Size = new Size(345, 199);
        EditItemInfoBox.TabIndex = 13;
        EditItemInfoBox.TabStop = false;
        EditItemInfoBox.Text = "Edit Item Information";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(62, 156);
        label12.Name = "label12";
        label12.Size = new Size(24, 20);
        label12.TabIndex = 14;
        label12.Text = "ID";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(22, 115);
        label11.Name = "label11";
        label11.Size = new Size(65, 20);
        label11.TabIndex = 14;
        label11.Text = "Quantity";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(31, 75);
        label10.Name = "label10";
        label10.Size = new Size(53, 20);
        label10.TabIndex = 14;
        label10.Text = "Price $";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(38, 33);
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
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(307, 80);
        label8.Name = "label8";
        label8.Size = new Size(24, 20);
        label8.TabIndex = 12;
        label8.Text = "ID";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(193, 80);
        label7.Name = "label7";
        label7.Size = new Size(65, 20);
        label7.TabIndex = 11;
        label7.Text = "Quantity";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(107, 80);
        label6.Name = "label6";
        label6.Size = new Size(41, 20);
        label6.TabIndex = 10;
        label6.Text = "Price";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(7, 80);
        label5.Name = "label5";
        label5.Size = new Size(49, 20);
        label5.TabIndex = 9;
        label5.Text = "Name";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(22, 33);
        label2.Name = "label2";
        label2.Size = new Size(0, 20);
        label2.TabIndex = 9;
        // 
        // ItemBreakDownBox
        // 
        ItemBreakDownBox.Enabled = false;
        ItemBreakDownBox.Location = new Point(7, 101);
        ItemBreakDownBox.Margin = new Padding(3, 4, 3, 4);
        ItemBreakDownBox.Name = "ItemBreakDownBox";
        ItemBreakDownBox.Size = new Size(345, 27);
        ItemBreakDownBox.TabIndex = 1;
        // 
        // ItemInfoMenuBox
        // 
        ItemInfoMenuBox.Controls.Add(CancelButton);
        ItemInfoMenuBox.Controls.Add(RemoveItemButton);
        ItemInfoMenuBox.Controls.Add(SaveButton);
        ItemInfoMenuBox.Location = new Point(374, 36);
        ItemInfoMenuBox.Margin = new Padding(3, 4, 3, 4);
        ItemInfoMenuBox.Name = "ItemInfoMenuBox";
        ItemInfoMenuBox.Padding = new Padding(3, 4, 3, 4);
        ItemInfoMenuBox.Size = new Size(144, 336);
        ItemInfoMenuBox.TabIndex = 0;
        ItemInfoMenuBox.TabStop = false;
        ItemInfoMenuBox.Text = "Menu";
        // 
        // CancelButton
        // 
        CancelButton.Location = new Point(7, 192);
        CancelButton.Margin = new Padding(3, 7, 3, 7);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(130, 67);
        CancelButton.TabIndex = 3;
        CancelButton.Text = "Cancel";
        CancelButton.UseVisualStyleBackColor = true;
        CancelButton.Click += CancelButton_Click;
        // 
        // RemoveItemButton
        // 
        RemoveItemButton.Location = new Point(7, 32);
        RemoveItemButton.Margin = new Padding(3, 7, 3, 7);
        RemoveItemButton.Name = "RemoveItemButton";
        RemoveItemButton.Size = new Size(130, 67);
        RemoveItemButton.TabIndex = 2;
        RemoveItemButton.Text = "Remove Item";
        RemoveItemButton.UseVisualStyleBackColor = true;
        RemoveItemButton.Click += RemoveItemButton_Click;
        // 
        // SaveButton
        // 
        SaveButton.Location = new Point(7, 109);
        SaveButton.Margin = new Padding(3, 7, 3, 7);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new Size(130, 67);
        SaveButton.TabIndex = 0;
        SaveButton.Text = "Save";
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;
        // 
        // InventoryManagementForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1038, 492);
        Controls.Add(splitContainer1);
        Margin = new Padding(3, 4, 3, 4);
        Text = "Inventory Management Form - Coreys Knick Knacks";
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        SearchInventoryUI.ResumeLayout(false);
        SearchInventoryUI.PerformLayout();
        FilterGroupBox.ResumeLayout(false);
        FilterGroupBox.PerformLayout();
        SearchMenuBox.ResumeLayout(false);
        ItemInfoBox.ResumeLayout(false);
        ItemInfoBox.PerformLayout();
        EditItemInfoBox.ResumeLayout(false);
        EditItemInfoBox.PerformLayout();
        ItemInfoMenuBox.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer1;
    private Button SearchButton;
    private TextBox SearchBox;
    private ListBox ResultBox;
    private GroupBox SearchMenuBox;
    private Button ViewAllInventoryButton;
    private Button EditItemButton;
    private Button RemoveItemButton;
    private Button AddNewItemButton;
    private GroupBox SearchInventoryUI;
    private Label label4;
    private Label label3;
    private Label label1;
    private Label Name;
    private GroupBox ItemInfoBox;
    private GroupBox ItemInfoMenuBox;
    private Label label8;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label2;
    private TextBox ItemBreakDownBox;
    private GroupBox EditItemInfoBox;
    private TextBox ItemIdBox;
    private TextBox EditItemQuantityTextBox;
    private TextBox EditItemPriceTextBox;
    private TextBox EditItemNameTextBox;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label9;
    private Button button4;
    private Button button2;
    private Button SaveButton;
    private Label ItemInfoLabel;
    private Button CancelButton;
    private Button ClearResultsButton;
    private Button CreateNewItemButton;
    private Label ResultLabel;
    private GroupBox FilterGroupBox;
    private RadioButton FilterByQuantityButton;
    private RadioButton radioButtonPrice;
    private RadioButton radioButton1;
    private GroupBox groupBoxFilters;
    private Button ClearFiltersButton;
}
