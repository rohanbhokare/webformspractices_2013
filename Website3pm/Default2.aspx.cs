using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtnumber1.Focus();
    }
    protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            float number1 = float.Parse(txtnumber1.Text.Trim());
            float number2 = float.Parse(txtnumber2.Text.Trim());
            float result = 0;
            switch (ddl1.SelectedItem.Value)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 == 0)
                        throw new DivideByZeroException("cant delete by zero");
                    result = number1 / number2;
                    break;
            }
            txtresult.Text = result.ToString();
        }
        catch (FormatException)
        {
            lblLabel.Text = "Please Enter Numberic Value Only";
            txtresult.Text = string.Empty;
        }
        catch (OverflowException)
        {
            lblLabel.Text = "valie is out of range";
            txtresult.Text = string.Empty;
        }
        catch (DivideByZeroException ex)
        {
            lblLabel.Text = ex.Message;
            txtresult.Text = string.Empty;
        }
    }
}