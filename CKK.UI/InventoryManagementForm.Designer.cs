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
        SearchInventoryUI = new GroupBox();
        ResultBox = new ListBox();
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
        SearchButton = new Button();
        SearchBox = new TextBox();
        SearchInventoryUI.SuspendLayout();
        SearchMenuBox.SuspendLayout();
        SuspendLayout();
        // 
        // SearchInventoryUI
        // 
        SearchInventoryUI.Controls.Add(ResultBox);
        SearchInventoryUI.Controls.Add(ResultLabel);
        SearchInventoryUI.Controls.Add(label4);
        SearchInventoryUI.Controls.Add(label3);
        SearchInventoryUI.Controls.Add(label1);
        SearchInventoryUI.Controls.Add(Name);
        SearchInventoryUI.Controls.Add(SearchMenuBox);
        SearchInventoryUI.Controls.Add(SearchButton);
        SearchInventoryUI.Controls.Add(SearchBox);
        SearchInventoryUI.Location = new Point(12, 13);
        SearchInventoryUI.Margin = new Padding(3, 4, 3, 4);
        SearchInventoryUI.Name = "SearchInventoryUI";
        SearchInventoryUI.Padding = new Padding(3, 4, 3, 4);
        SearchInventoryUI.Size = new Size(494, 470);
        SearchInventoryUI.TabIndex = 7;
        SearchInventoryUI.TabStop = false;
        SearchInventoryUI.Text = "Search Inventory";
        // 
        // ResultBox
        // 
        ResultBox.FormattingEnabled = true;
        ResultBox.Location = new Point(7, 104);
        ResultBox.Name = "ResultBox";
        ResultBox.Size = new Size(321, 324);
        ResultBox.TabIndex = 24;
        // 
        // ResultLabel
        // 
        ResultLabel.AutoSize = true;
        ResultLabel.Font = new Font("Segoe UI", 9F);
        ResultLabel.Location = new Point(7, 437);
        ResultLabel.Margin = new Padding(2, 0, 2, 0);
        ResultLabel.Name = "ResultLabel";
        ResultLabel.Size = new Size(55, 20);
        ResultLabel.TabIndex = 9;
        ResultLabel.Text = "Results";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(291, 81);
        label4.Name = "label4";
        label4.Size = new Size(24, 20);
        label4.TabIndex = 8;
        label4.Text = "ID";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(200, 81);
        label3.Name = "label3";
        label3.Size = new Size(65, 20);
        label3.TabIndex = 7;
        label3.Text = "Quantity";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(101, 81);
        label1.Name = "label1";
        label1.Size = new Size(41, 20);
        label1.TabIndex = 6;
        label1.Text = "Price";
        // 
        // Name
        // 
        Name.AutoSize = true;
        Name.Location = new Point(7, 81);
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
        SearchMenuBox.Location = new Point(334, 85);
        SearchMenuBox.Margin = new Padding(3, 4, 3, 4);
        SearchMenuBox.Name = "SearchMenuBox";
        SearchMenuBox.Padding = new Padding(3, 4, 3, 4);
        SearchMenuBox.Size = new Size(144, 343);
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
        // SearchButton
        // 
        SearchButton.Font = new Font("Segoe UI", 8F);
        SearchButton.Location = new Point(382, 28);
        SearchButton.Margin = new Padding(3, 4, 3, 4);
        SearchButton.Name = "SearchButton";
        SearchButton.Size = new Size(96, 31);
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
        SearchBox.PlaceholderText = "Search By Name...";
        SearchBox.Size = new Size(369, 27);
        SearchBox.TabIndex = 23;
        SearchBox.Text = " ";
        // 
        // InventoryManagementForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(518, 496);
        Controls.Add(SearchInventoryUI);
        Margin = new Padding(3, 4, 3, 4);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Inventory Management Form - Corey's Knick Knacks";
        SearchInventoryUI.ResumeLayout(false);
        SearchInventoryUI.PerformLayout();
        SearchMenuBox.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Button button4;
    private Button button2;
    private RadioButton radioButton1;
    private GroupBox groupBoxFilters;
    private GroupBox SearchInventoryUI;
    private Label ResultLabel;
    private Label label4;
    private Label label3;
    private Label label1;
    private Label Name;
    private GroupBox SearchMenuBox;
    private Button ClearResultsButton;
    private Button EditItemButton;
    private Button AddNewItemButton;
    private Button ViewAllInventoryButton;
    private Button SearchButton;
    private TextBox SearchBox;
    private ListBox ResultBox;
}
