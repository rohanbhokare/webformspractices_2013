<%@ Page Language="C#" %>

<!DOCTYPE html>
<script type="text/javascript">
    function validate()
    {
        var value1 = document.getElementById("txtNumber1").value;
        var value2 = document.getElementById("txtNumber2").value;
        var err = "";
  
        if (value1 == "" || value2 == "")
        {
            if (value1== "") {
                err += " Please Enter Number 1"+"\n";
            }
            if (value2 == "") {
                err += " Please Enter Number 2"+"\n";
            }
        }
        if (err != "")
        {
            alert(err);
            return false;
        }
    }

</script>

<script runat="server">
    protected void Page_Load(Object sender, EventArgs e)
    {
        txtNumber1.Focus();
    }
    void calc(string op)
    {
        try
        {
            float num1 = float.Parse(txtNumber1.Text.Trim());
            float num2 = float.Parse(txtNumber2.Text.Trim());
            float result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            txtResult.Text = result.ToString();
        }
        catch (FormatException ex1)
        {
                lblresult.Text=ex1.Message;
                txtResult.Text=string.Empty;
        }
         catch (OverflowException ex2)
        {
             lblresult.Text=ex2.Message;
             txtResult.Text=string.Empty;
         }
        catch (DivideByZeroException ex3)
        {
            lblresult.Text = ex3.Message;
            txtResult.Text = string.Empty;
        }
                
    }
    protected void btnAdd_click(object sender, EventArgs e)
    {
        calc("+");
    }
    protected void btnSub_click(object sender, EventArgs e)
    {
        calc("-");
    }
    protected void btnMul_click(object sender, EventArgs e)
    {
        calc("*");
    }
    protected void btnDiv_click(object sender, EventArgs e)
    {
        calc("/");
    }
        
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to asp.net website</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lblresult" runat="server" />
        <b>Enter the First Number</b>
        <asp:TextBox ID="txtNumber1" runat="server" />
        <asp:TextBox ID="txtNumber2" runat="server" />
        <asp:Button ID="btnAdd" runat="server" Text="ADD" OnClientClick="validate()" OnClick="btnAdd_click"  />
        <asp:Button ID="btnSub" runat="server" Text="Sub" OnClick="btnSub_click" />
        <asp:Button ID="btnMul" runat="server" Text="Mul" OnClick="btnMul_click" />
        <asp:Button ID="btnDiv" runat="server" Text="Div" OnClick="btnDiv_click" />
        <asp:TextBox ID="txtResult" runat="server" />
    </div>
    </form>
</body>
</html>

