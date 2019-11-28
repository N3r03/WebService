<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    First Number:
                </td>
                <td>
                    <asp:TextBox ID="tbFirstNumber" runat="server" OnTextChanged="tbFirstNumber_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Second Number:</td>
                <td><asp:TextBox ID="tbSecondNumber" runat="server"></asp:TextBox></td>

            </tr>
            <tr>
                <td>Result:</td>
                <td><asp:Label ID="lResult" runat="server" Text=""></asp:Label></td>
                
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="bCalculateSum" runat="server" Text="Button" OnClick="bCalculateSum_Click" />
                </td>
                <td>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gvCalculations" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
        
    </div>
    </form>
</body>
</html>
