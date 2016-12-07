namespace NerdBlock.Engine.LogicLayer.Implementation.Actions
{
    [BusinessActionContainer]
    public class Reports
    {
        /// <summary>
        /// Handles moving to the employee breakdown report
        /// </summary>
        [BusinessAction("goto_employee_breakdown")]
        [AuthAttrib("General Manager", "Human Resources")]
        public void ShowEmployeeBreakdown()
        {

        }

        /// <summary>
        /// Handles moving to the block series breakdown report
        /// </summary>
        [BusinessAction("goto_series_breakdown")]
        [AuthAttrib("General Manager","Planning", "Shipper")]
        public void ShowSeriesBreakdown()
        {

        }

        /// <summary>
        /// Handles moving to the product inventory breakdown report
        /// </summary>
        [BusinessAction("goto_inventory_breakdown")]
        [AuthAttrib("General Manager", "Planning", "Shipper")]
        public void ShowInventoryBreakdown()
        {

        }
    }
}
