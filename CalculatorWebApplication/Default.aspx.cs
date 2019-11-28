using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void bCalculateSum_Click(object sender, EventArgs e)
    {
        CalculatorServiceReference.CalculatorWebServiceSoapClient service = new CalculatorServiceReference.CalculatorWebServiceSoapClient();
        lResult.Text = Convert.ToString(service.Add(Convert.ToInt32(tbFirstNumber.Text), Convert.ToInt32(tbSecondNumber.Text)));

        gvCalculations.DataSource = service.GetCalculations();
        gvCalculations.DataBind();

        gvCalculations.HeaderRow.Cells[0].Text = "Recent Calculations";
    }

    protected void tbFirstNumber_TextChanged(object sender, EventArgs e)
    {

    }
}