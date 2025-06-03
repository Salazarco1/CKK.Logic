using CKK.Logic.Models;
using CKK.DB.Repository;
using CKK.DB.Interfaces;
using CKK.DB.UOW;

namespace CKK.UI;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();

        using(var dbContext = new DatabaseConnectionFactory())
        {
            var unitOfWork = new UnitOfWork(dbContext);

            InventoryManagementForm form = new InventoryManagementForm(unitOfWork);

            Application.Run(form);
        }
    }
}