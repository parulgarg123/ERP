<%@ Page Title="" Language="C#" MasterPageFile="~/next/hod/hod.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="next_hod_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 ">
                <div class="form-group" style="width: 50%; margin: 0 auto;">
                    <asp:Label ID="search" runat="server" Text="Search by Roll Number:" Style="padding-right: 30px"></asp:Label>
                    <asp:TextBox ID="txtSearch" CssClass="form-control-static" runat="server" AutoPostBack="True" />
                    <asp:Button Text="Search" runat="server" CssClass="btn-group-lg" OnClick="Unnamed1_Click1" Style="height: 26px" />
                    <asp:Button ID="Button1" runat="server" Text="Reset" CssClass="btn-group-lg" OnClick="Button1_Click" />
                </div>
                <br />
                <div class="form-group" style="width: 50%; margin: 0 auto;">
                    <asp:Label ID="search_email_label" runat="server" Style="padding-right: 73px" Text="Search by Email:"></asp:Label>
                    <asp:TextBox ID="txtsrch" runat="server" CssClass="btn-group-lg" Style="height: 26px" OnTextChanged="txtsrch_TextChanged"></asp:TextBox>
                    <asp:Button ID="search_email" runat="server" CssClass="btn-group-lg" Text="Search" OnClick="search_email_Click" />
                    <asp:Button ID="reset_email" runat="server" CssClass="btn-group-lg" Text="Reset" OnClick="reset_email_Click" />
                </div>
                <br />
                <div class="form-group"  style="width: 30%; margin: 0 auto;">
                    <asp:Button ID="excel" runat="server" Text="Export to Excel" CssClass="btn-group-lg" OnClick="excel_Click" />
                    <asp:Button ID="doc" runat="server" Text="Export to Word" CssClass="btn-group-lg" OnClick="doc_Click" />
                </div>
                <hr />
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CssClass="table table-bordered table-responsive" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="regid" DataSourceID="SqlDataSource1" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnPageIndexChanging="GridView1_PageIndexChanging1" OnSorting="GridView1_Sorting1">
                    <Columns>
                        <asp:BoundField DataField="regid" HeaderText="Reg. Id" InsertVisible="False" ReadOnly="True" SortExpression="regid" />
                        <asp:TemplateField HeaderText="Name" SortExpression="fname">
                            <ItemTemplate>
                                <div style="width: 100px; overflow: hidden; white-space: nowrap; text-overflow: ellipsis">
                                    <%# Eval("fname") %> <%# Eval("lname") %>
                                </div>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="rollno" HeaderText="Roll No." SortExpression="rollno" />
                        <asp:TemplateField HeaderText="Department">
                            <ItemTemplate>
                                <div style="width: 100px; overflow: hidden; white-space: nowrap; text-overflow: ellipsis">
                                    <%# Eval("dept") %>
                                </div>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="sem" HeaderText="Semester" SortExpression="sem" />
                        <asp:BoundField DataField="dob" HeaderText="dob" Visible="false" SortExpression="dob" />
                        <asp:BoundField DataField="father" HeaderText="father" Visible="false" SortExpression="father" />
                        <asp:BoundField DataField="mother" HeaderText="mother" Visible="false" SortExpression="mother" />
                        <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                        <asp:BoundField DataField="contact" HeaderText="Contact No." />
                        <asp:BoundField DataField="address" HeaderText="address" Visible="false" SortExpression="address" />
                        <asp:BoundField DataField="password" HeaderText="password" Visible="false" SortExpression="password" />
                        <asp:BoundField DataField="hostel" HeaderText="hostel" Visible="false" SortExpression="hostel" />
                        <asp:BoundField DataField="bus" HeaderText="bus" Visible="false" SortExpression="bus" />
                        <asp:BoundField DataField="acc_type" HeaderText="Account Type" SortExpression="acc_type" />
                        <asp:BoundField DataField="lastupd" HeaderText="lastupd" Visible="false" SortExpression="lastupd" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <EmptyDataTemplate>
                        No Records Available.
                    </EmptyDataTemplate>
                </asp:GridView>

                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=.\sqlexpress;Initial Catalog=fee;Integrated Security=True;Pooling=False" ProviderName="System.Data.SqlClient" SelectCommand="select * from register where acc_type='Student' or acc_type='Cc'"></asp:SqlDataSource>
                <br />
            </div>

        </div>
    </div>
</asp:Content>

