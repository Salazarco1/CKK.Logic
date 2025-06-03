using CKK.DB.Interfaces;
using CKK.DB.Repository;
using CKK.DB.UOW;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace CKK.UI;

/// <summary>
/// Represents a form for managing inventory items.
/// Allows users to search, view, add, and edit products.
/// </summary>
public partial class InventoryManagementForm : Form
{
    private readonly IUnitOfWork _unitOfWork;

    /// <summary>
    /// Stores a list of all available inventory items.
    /// </summary>
    public List<Product> _Items = new List<Product>();

    /// <summary>
    /// Gets or sets the currently selected store item.
    /// </summary>
    public Product CurrentStoreItem { get; set; }

    /// <summary>
    /// Initializes a new instance of the InventoryManagementForm class.
    /// </summary>
    public InventoryManagementForm(UnitOfWork unitOfWork)
    {
        InitializeComponent();
        _unitOfWork = unitOfWork;
        EditItemButton.Enabled = false;
        SearchBox.Clear();
    }

    /// <summary>
    /// Handles the click event for searching inventory items by name.
    /// Displays results in the UI.
    /// </summary>
    private void SearchButton_Click(object sender, EventArgs e)
    {
        ResultBox.Items.Clear();

        if (SearchBox.Text != null)
        {
            var validItems = _unitOfWork.Products.GetByName(SearchBox.Text);

            if (validItems != null && validItems.Count > 0)
            {
                foreach (var item in validItems)
                {
                    string formattedItem = $"{item.Name,-20} {item.Price,5:C} {item.Quantity,10} {item.Id,10}";
                    ResultBox.Items.Add(formattedItem);
                }
                ResultLabel.Text = "Results: " + ResultBox.Items.Count.ToString();
                CurrentStoreItem = validItems.FirstOrDefault() as Product;
                EditItemButton.Enabled = true;
            }
            else
            {
                ResultLabel.Text = "Results: 0";
                ResultBox.Items.Add("No Results Found");
            }
        }
    }

    /// <summary>
    /// Handles the click event for viewing all inventory items.
    /// Displays all products in the UI.
    /// </summary>
    private void ViewAllInventoryButton_Click(object sender, EventArgs e)
    {
        SearchBox.Clear();
        ResultBox.Items.Clear();

        _Items = (List<Product>)_unitOfWork.Products.GetAll();

        if (_Items != null && _Items.Count > 0)
        {
            ResultLabel.Text = $"Results: {_Items.Count}";

            foreach (var item in _Items)
            {
                string formattedItem = $"{item.Name,-20} {item.Price,5:C} {item.Quantity,20} {item.Id,25}";
                ResultBox.Items.Add(formattedItem);
            }
        }
        else
        {
            ResultLabel.Text = "Results: 0";
            ResultBox.Items.Add("No Results Found");
        }
    }

    /// <summary>
    /// Handles the click event for adding a new inventory item.
    /// Opens a form for adding a new product.
    /// </summary>
    private void AddNewItemButton_Click(object sender, EventArgs e)
    {
        AddNewItemForm_IMS addNewItemForm = new AddNewItemForm_IMS(_unitOfWork);
        addNewItemForm.Show();

        ClearResultsButton_Click(sender, e);
    }

    /// <summary>
    /// Handles the click event for editing an inventory item.
    /// Opens a form for modifying an existing product.
    /// </summary>
    private void EditItemButton_Click(object sender, EventArgs e)
    {
        EditItemForm_IMS editItemForm = new EditItemForm_IMS(_unitOfWork, CurrentStoreItem);
        editItemForm.Show();

        ClearResultsButton_Click(sender, e);
    }

    /// <summary>
    /// Handles the click event for clearing the search results.
    /// Resets the UI elements.
    /// </summary>
    private void ClearResultsButton_Click(object sender, EventArgs e)
    {
        ResultBox.Items.Clear();
        ResultLabel.Text = "Results: ";
        SearchBox.Clear();
        EditItemButton.Enabled = false;
    }
}