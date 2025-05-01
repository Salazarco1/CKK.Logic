using CKK.Logic.Models;

namespace CKK.UI;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        
        Store store = new Store();
        InitializeProducts(store);
        InventoryManagementForm form = new InventoryManagementForm(store);
        
        Application.Run(form);
    }
    
    static void InitializeProducts(Store store)
    {
        Product prod1 = new Product();
        Product prod2 = new Product();
        Product prod3 = new Product();

        prod1.Name = "Balloons";
        prod2.Name = "Streamers";
        prod3.Name = "Confetti";

        prod1.Price = 2.50m;
        prod2.Price = 3.00m;
        prod3.Price = 4.95m;

        prod1.Id = 123;
        prod2.Id = 234;
        prod3.Id = 345;


        StoreItem storeItem1 = new StoreItem(prod1, 10);
        StoreItem storeItem2 = new StoreItem(prod2, 4);
        StoreItem storeItem3 = new StoreItem(prod3, 5);

        store.Items.Add(storeItem1);
        store.Items.Add(storeItem2);
        store.Items.Add(storeItem3);
    }
}