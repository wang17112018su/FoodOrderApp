<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FoodOrder.aspx.cs" Inherits="WebApplication1.FoodOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Label ID="Label1" runat="server" Text="User Name: "></asp:Label>
			<asp:TextBox ID="user" runat="server"></asp:TextBox>
        </div>
    	<asp:Panel ID="Panel1" runat="server">
			<asp:Label ID="Label2" runat="server" Text="Food : "></asp:Label>
			<asp:DropDownList ID="DropDownList1" runat="server">
			</asp:DropDownList>
			<br />
			<asp:Label ID="Label3" runat="server" Text="Size of Meal"></asp:Label>
			<asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
			</asp:RadioButtonList>
			Extra Seasoning<br />
			<asp:CheckBox ID="CheckBox1" runat="server" Text="Pepper" />
			<br />
			<asp:CheckBox ID="CheckBox2" runat="server" Text="Salt" />
			<br />
			<asp:CheckBox ID="CheckBox3" runat="server" Text="Chilli" />
			<br />
			<asp:CheckBox ID="CheckBox4" runat="server" Text="Ketchup" />
			<br />
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
			<br />
			<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
		</asp:Panel>
		<p>
			&nbsp;</p>
    </form>
</body>
</html>
