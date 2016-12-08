using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend.Winforms.Implementation;
using NerdBlock.Engine.Backend;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class EmployeeSearch : ViewBase
    {
        public EmployeeSearch()
        {
            InitializeComponent();
            
            // Add outputs
            Outputs.Add(new DataGridOutput("AllEmployees", dgvEmployeeList));

            //Controls
            btnEdit.Click += (X, Y) =>
            {
                ViewManager.CurrentMap.SetInput("Employee.Info", DataAccess.FromPrimaryKey<Employee>(dgvEmployeeList.SelectedRows[0].Cells["clmEmployeeId"].Value));
                AttemptAction("goto_employee_update");
            };
        }
    }
}
