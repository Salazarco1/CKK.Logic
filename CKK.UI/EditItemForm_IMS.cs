using CKK.DB.Interfaces;
using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKK.UI
{
    /// <summary>
    /// Represents a form for editing existing items in the inventory.
    /// </summary>
    public partial class EditItemForm_IMS : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Gets or sets the current store item being edited.
        /// </summary>
        public Product CurrentStoreItem { get; set; }

        /// <summary>
        /// Initializes a new instance of the EditItemForm_IMS class.
        /// </summary>
        public EditItemForm_IMS(IUnitOfWork unitOfWork, Product currentStoreItem)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            CurrentStoreItem = currentStoreItem;
            this.Focus();

            // Populate UI elements with current item details
            EditItemNameTextBox.Text = CurrentStoreItem.Name;
            EditItemPriceTextBox.Text = CurrentStoreItem.Price.ToString();
            EditItemQuantityTextBox.Text = CurrentStoreItem.Quantity.ToString();
            ItemIdBox.Text = CurrentStoreItem.Id.ToString();

            ItemNameBreakDownBox.Text = CurrentStoreItem.Name;
            ItemPriceBreakDownBox.Text = $"{CurrentStoreItem.Price:C}";
            ItemQuantityBreakDownBox.Text = CurrentStoreItem.Quantity.ToString();
            ItemIdBreakDownBox.Text = CurrentStoreItem.Id.ToString();
        }

        /// <summary>
        /// Handles the click event for removing an item from the inventory.
        /// Displays a confirmation dialog before deletion.
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            var storeItem = CurrentStoreItem;

            string message = "Warning: Removing an item is irreversible.\nAre you sure you want to remove this item?";
            string caption = $"Remove {storeItem.Name}?";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _unitOfWork.Products.Delete(storeItem.Id);
                var checkStoreItemDeleted = _unitOfWork.Products.GetById(storeItem.Id);

                if (checkStoreItemDeleted == null)
                {
                    message = $"{storeItem.Name} was removed successfully.";
                    caption = "Item Removed";

                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Handles the click event for saving changes to an item.
        /// Validates input and updates the product in the database.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var storeItem = CurrentStoreItem;

                if (!string.IsNullOrWhiteSpace(EditItemNameTextBox.Text) &&
                    !string.IsNullOrWhiteSpace(EditItemPriceTextBox.Text) &&
                    !string.IsNullOrWhiteSpace(EditItemQuantityTextBox.Text))
                {
                    storeItem.Name = EditItemNameTextBox.Text;
                    storeItem.Price = decimal.Parse(EditItemPriceTextBox.Text);
                    storeItem.Quantity = int.Parse(EditItemQuantityTextBox.Text);

                    _unitOfWork.Products.Update(storeItem);

                    string message = $"{storeItem.Name} was saved successfully.";
                    string caption = "Item Edited";

                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }

                // Reset UI and disable edits
                ItemInfoBox.Enabled = false;
                ItemNameBreakDownBox.Clear();
                EditItemNameTextBox.Clear();
                EditItemPriceTextBox.Clear();
                EditItemQuantityTextBox.Clear();
                ItemIdBox.Clear();

                this.Close();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message, "Error: Incorrect Format", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the click event for canceling item editing and closing the form.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
