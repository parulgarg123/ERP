<%@ Page Title="" Language="C#" MasterPageFile="~/next/admin new/MasterPage.master" AutoEventWireup="true" CodeFile="fee.aspx.cs" Inherits="next_admin_new_Default" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
        Import Excel File:  
        <asp:FileUpload ID="FileUpload1" runat="server" />  
        <br />  
        <br />  
        <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Open To View" />  
        <br />  
    
        <asp:Button ID="Button1" runat="server" Text="Upload to Database" OnClick="Button1_Click" />
    
        <br />  
        <asp:Label ID="Label1" runat="server"></asp:Label>  
        <br />  
    <asp:RadioButtonList ID="rbHDR" runat="server" Visible="false">
    <asp:ListItem Text = "Yes" Value = "Yes" Selected = "True"  >
    </asp:ListItem>
    
</asp:RadioButtonList>
    
    <asp:GridView ID="GridView1" runat="server" OnPageIndexChanging = "PageIndexChanging" AllowPaging = "true">


    </asp:GridView>


    

</asp:Content>

