using CKK.Logic.Models;
using CKK.Logic.Interfaces;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Linq;
namespace CKK.UI;

public partial class InventoryManagementForm : Form
{
    private IStore _Store;

    public List<StoreItem> _Items { get; private set; }

    public StoreItem _CurrentStoreItem;

    public InventoryManagementForm(Store store)
    {
        _Store = store;
        InitializeComponent();
        _Items = store.Items;
        ItemInfoBox.Enabled = false;
        ItemInfoLabel.Visible = false;
        EditItemButton.Enabled = false;
        CreateNewItemButton.Visible = false;
    }

    public StoreItem CurrentStoreItem
    {
        get { return _CurrentStoreItem; }

        set { _CurrentStoreItem = value; }
    }



    private void SearchButton_Click(object sender, EventArgs e)
    {
        ResultBox.Items.Clear();

        if (SearchBox.Text != null)
        {
            string search = SearchBox.Text;

            var validItems = _Store.GetAllProductsByName(search);

            if (validItems != null && validItems.Count > 0)
            {
                foreach (var item in validItems)
                {
                    string itemInfo = $"{item.Product.Name}        {item.Product.Price:C}       {item.Quantity}      {item.Product.Id}";
                    ResultBox.Items.Add(itemInfo);
                }

                ItemInfoBox.Enabled = true;
                ResultLabel.Text = "Results: " + ResultBox.Items.Count.ToString();
                
                //if (validItems[0] == null) { validItems = null; }

                EditItemButton.Enabled = true;
            }
            else if (validItems == null || validItems.Count == 0)
            {
                ResultLabel.Text = "Results: 0";
                ItemInfoBox.Enabled = false;
                string noItemFoundInfo = $"No Results Found";
                ResultBox.Items.Add(noItemFoundInfo);
            }
        }
    }

    private void ViewAllInventoryButton_Click(object sender, EventArgs e)
    {
        ResultBox.Items.Clear();

        ItemInfoBox.Enabled = false;

        if (_Items != null || _Items.Count > 0)
        {
            ResultLabel.Text = $"Resutls: {_Items.Count}";

            foreach (var item in _Items)
            {
                string validItemInfo = $"{item.Product.Name}        {item.Product.Price:C}       {item.Quantity}      {item.Product.Id}";
                ResultBox.Items.Add(validItemInfo);
            }
        }
        else if (_Items == null || _Items.Count == 0)
        {
            ResultLabel.Text = "Resutls: 0";
            string noItemFoundInfo = $"No Results Found";
            ResultBox.Items.Add(noItemFoundInfo);
        }
    }

    private void AddNewItemButton_Click(object sender, EventArgs e)
    {
        ItemInfoBox.Enabled = true;
        SearchInventoryUI.Enabled = false;
        ItemInfoLabel.Text = "Add New Item";
        ItemInfoLabel.Visible = true;
        RemoveItemButton.Enabled = false;
        SaveButton.Enabled = false;
        CreateNewItemButton.Visible = true;
    }

    private void RemoveItemButton_Click(object sender, EventArgs e)
    {
        ItemInfoBox.Enabled = true;
        SearchInventoryUI.Enabled = false;

        var storeItem = CurrentStoreItem;

        string message = "Are You Sure You Want To Remove This Item?";
        string caption = $"Remove {storeItem.Product.Name}?";

        var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            _Store.DeleteStoreItem(storeItem.Product.Id);

            var checkStoreItemDeleted = _Store.FindStoreItemById(storeItem.Product.Id);

            if (checkStoreItemDeleted == null)
            {
                message = $"{storeItem.Product.Name} was removed successfully";
                caption = "Item Removed";

                MessageBox.Show(message, caption, MessageBoxButtons.OK);

                ItemInfoBox.Enabled = false;
                SearchInventoryUI.Enabled = true;
                ItemInfoLabel.Visible = false;
                CreateNewItemButton.Visible = false;
                ItemBreakDownBox.Clear();
                EditItemNameTextBox.Clear();
                EditItemPriceTextBox.Clear();
                EditItemQuantityTextBox.Clear();
                ItemIdBox.Clear();
                ResultBox.Items.Clear();
                SearchBox.Clear();
                ResultLabel.Text = "Results: ";
            }
        }
    }

    private void EditItemButton_Click(object sender, EventArgs e)
    {
        ItemInfoBox.Enabled = true;
        SearchInventoryUI.Enabled = false;
        ItemInfoLabel.Text = "Edit Item";
        ItemInfoLabel.Visible = true;
        RemoveItemButton.Enabled = true;
        SaveButton.Enabled = true;

        var storeItem = CurrentStoreItem;

        if (storeItem != null)
        {
            ItemBreakDownBox.Text = $"{storeItem.Product.Name}        {storeItem.Product.Price:C}       {storeItem.Quantity}      {storeItem.Product.Id}";
            EditItemNameTextBox.Text = $"{storeItem.Product.Name}";
            EditItemPriceTextBox.Text = $"{storeItem.Product.Price}";
            EditItemQuantityTextBox.Text = $"{storeItem.Quantity}";
            ItemIdBox.Text = $"{storeItem.Product.Id}";
        }
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        ItemInfoBox.Enabled = false;
        SearchInventoryUI.Enabled = true;
        ItemInfoLabel.Visible = false;
        CreateNewItemButton.Visible = false;
        ItemBreakDownBox.Clear();
        EditItemNameTextBox.Clear();
        EditItemPriceTextBox.Clear();
        EditItemQuantityTextBox.Clear();
        ItemIdBox.Clear();
        ResultBox.Items.Clear();
        SearchBox.Clear();
        ResultLabel.Text = "Results: ";
    }

    private void ClearResultsButton_Click(object sender, EventArgs e)
    {
        ResultBox.Items.Clear();
        ResultLabel.Text = "Results: ";
        SearchBox.Clear();
        EditItemButton.Enabled = false;
        ItemInfoBox.Enabled = false;
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        var storeItem = CurrentStoreItem;

        if (EditItemNameTextBox.Text != null || EditItemPriceTextBox.Text != null || EditItemQuantityTextBox.Text != null)
        {
            storeItem.Product.Name = EditItemNameTextBox.Text;
            storeItem.Product.Price = decimal.Parse(EditItemPriceTextBox.Text);
            storeItem.Quantity = int.Parse(EditItemQuantityTextBox.Text);

            string message = $"{storeItem.Product.Name} was edited Successfully";
            string caption = "Item Edited";

            MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }

        ItemInfoBox.Enabled = false;
        SearchInventoryUI.Enabled = true;
        ItemInfoLabel.Visible = false;
        CreateNewItemButton.Visible = false;
        ItemBreakDownBox.Clear();
        EditItemNameTextBox.Clear();
        EditItemPriceTextBox.Clear();
        EditItemQuantityTextBox.Clear();
        ItemIdBox.Clear();
        ResultBox.Items.Clear();
        SearchBox.Clear();
        ResultLabel.Text = "Results: ";

    }

    private void CreateNewItemButton_Click(object sender, EventArgs e)
    {
        if (EditItemNameTextBox.Text != null || EditItemPriceTextBox.Text != null || EditItemQuantityTextBox.Text != null)
        {
            Product prod = new Product();

            prod.Name = EditItemNameTextBox.Text;
            prod.Price = decimal.Parse(EditItemPriceTextBox.Text);
            int quantity = int.Parse(EditItemQuantityTextBox.Text);
            prod.Id = 0;

            _Store.AddStoreItem(prod, quantity);

            string message = $"{prod.Name} Was Added Successfully!";
            string caption = "Item Added";

            MessageBox.Show(message, caption, MessageBoxButtons.OK);

            ItemInfoBox.Enabled = false;
            SearchInventoryUI.Enabled = true;
            ItemInfoLabel.Visible = false;
            CreateNewItemButton.Visible = false;
            ItemBreakDownBox.Clear();
            EditItemNameTextBox.Clear();
            EditItemPriceTextBox.Clear();
            EditItemQuantityTextBox.Clear();
            ItemIdBox.Clear();
            ResultBox.Items.Clear();
            SearchBox.Clear();
            ResultLabel.Text = "Results: ";

        }
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {

        ResultBox.Items.Clear();

        var validItems = _Store.GetProductsByPrice();

        if (validItems != null)
        {
            foreach (var item in validItems)
            {
                if(item != null)
                {
                    string itemInfo = $"{item.Product.Name}        {item.Product.Price:C}       {item.Quantity}      {item.Product.Id}";
                    ResultBox.Items.Add(itemInfo);
                }
            }
        }
    }

    private void FilterByQuantityButton_CheckedChanged(object sender, EventArgs e)
    {
        if(FilterByQuantityButton.Checked == true || radioButtonPrice.Checked == true)
        {
            ResultBox.Items.Clear();

            var validItems = _Store.GetProductsByQuantity();

            if (validItems != null)
            {
                foreach (var item in validItems)
                {
                    string itemInfo = $"{item.Product.Name}        {item.Product.Price:C}       {item.Quantity}      {item.Product.Id}";
                    ResultBox.Items.Add(itemInfo);
                }
            }
        }
    }

    private void ClearFiltersButton_Click(object sender, EventArgs e)
    {
        FilterByQuantityButton.Checked = false;
        radioButtonPrice.Checked = false;
    }
}
