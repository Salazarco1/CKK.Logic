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
    /// Represents a form for adding new items to the inventory.
    /// </summary>
    public partial class AddNewItemForm_IMS : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Initializes a new instance of the AddNewItemForm_IMS class.
        /// </summary>
        public AddNewItemForm_IMS(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            this.Focus();
        }

        /// <summary>
        /// Handles the click event for creating a new item.
        /// Validates input and adds a new product to the database.
        /// </summary>
        private void CreateNewItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EditItemNameTextBox.Text != null || EditItemPriceTextBox.Text != null || EditItemQuantityTextBox.Text != null)
                {
                    Product prod = new Product
                    {
                        Name = EditItemNameTextBox.Text,
                        Price = decimal.Parse(EditItemPriceTextBox.Text),
                        Quantity = int.Parse(EditItemQuantityTextBox.Text),
                        Id = 0
                    };

                    _unitOfWork.Products.Add(prod);

                    string message = $"{prod.Name} Was Added Successfully!";
                    string caption = "Item Added";

                    MessageBox.Show(message, caption, MessageBoxButtons.OK);

                    ItemInfoLabel.Visible = false;
                    EditItemNameTextBox.Clear();
                    EditItemPriceTextBox.Clear();
                    EditItemQuantityTextBox.Clear();
                    ItemIdBox.Clear();
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message, "Error: Incorrect Format", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the click event for canceling item creation and closing the form.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
