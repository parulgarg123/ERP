<%@ Page Title="" Language="C#" MasterPageFile="~/next/principal/principal.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="next_principal_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 ">
                <div class="form-group" style="width: 50%; margin: 0 auto;">
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" AutoPostBack="True">
                        <asp:ListItem Text="All"></asp:ListItem>
                        <asp:ListItem>HOD</asp:ListItem>
                        <asp:ListItem>Cc</asp:ListItem>
                        <asp:ListItem>Student</asp:ListItem>
                        <asp:ListItem>Computer Science Engineering</asp:ListItem>
                        <asp:ListItem>Civil Engineering</asp:ListItem>
                        <asp:ListItem>Mechanical Engineering</asp:ListItem>
                        <asp:ListItem>Electronics and Communication Engineering</asp:ListItem>
                        <asp:ListItem>Applied Science</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <hr />
                <div class="form-group" >
                    <asp:Label ID="search_label" runat="server" Style="padding-right: 73px" Text="Search by: "></asp:Label>
                    <asp:TextBox ID="txtsrch" runat="server" CssClass="btn-group-lg" placeholder="roll number" Style="height: 26px" OnDataBinding="txtsrch_TextChanged" OnTextChanged="txtsrch_TextChanged" type="Search" AutoPostBack="True"></asp:TextBox>
                  OR  <asp:TextBox ID="txtemail" runat="server"  CssClass="btn-group-lg" placeholder="email" type="Search" AutoPostBack="True" OnTextChanged="txtemail_TextChanged"></asp:TextBox>
                  OR  <asp:TextBox ID="txtname" runat="server" CssClass="btn-group-lg" placeholder="name" type="Search" AutoPostBack="True" OnTextChanged="txtname_TextChanged"></asp:TextBox>
                    
                     <%--<asp:button id="search_email" runat="server" cssclass="btn-group-lg" text="search" />--%>
                    <asp:Button ID="reset_email" runat="server" CssClass="btn-group-lg" Text="Reset" OnClick="reset_email_Click" />
                </div>
                <hr />


                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CssClass="table table-bordered table-responsive" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="regid" DataSourceID="SqlDataSource1" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="regid" HeaderText="regid" InsertVisible="False" ReadOnly="True" SortExpression="regid" />
                       <asp:TemplateField HeaderText="Name" SortExpression="fname">
                            <ItemTemplate>
                                <div style="width: 100px; overflow: hidden; white-space: nowrap; text-overflow: ellipsis">
                                    <%# Eval("fname") %> <%# Eval("lname") %>
                                </div>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="rollno" HeaderText="rollno" SortExpression="rollno" />
                        <asp:BoundField DataField="dept" HeaderText="dept" SortExpression="dept" />
                        <asp:BoundField DataField="sem" HeaderText="sem" Visible="false" SortExpression="sem" />
                        <asp:BoundField DataField="dob" HeaderText="dob" SortExpression="dob" />
                        <asp:BoundField DataField="father" HeaderText="father" Visible="false" SortExpression="father" />
                        <asp:BoundField DataField="mother" HeaderText="mother" Visible="false" SortExpression="mother" />
                        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                        <asp:BoundField DataField="contact" HeaderText="contact" SortExpression="contact" />
                        <asp:BoundField DataField="address" HeaderText="address" Visible="false" SortExpression="address" />
                        <asp:BoundField DataField="password" HeaderText="password" Visible="false" SortExpression="password" />
                        <asp:BoundField DataField="hostel" HeaderText="hostel" Visible="false" SortExpression="hostel" />
                        <asp:BoundField DataField="bus" HeaderText="bus" Visible="false" SortExpression="bus" />
                        <asp:BoundField DataField="acc_type" HeaderText="acc_type" SortExpression="acc_type" />
                        <asp:BoundField DataField="lastupd" HeaderText="lastupd" Visible="false" SortExpression="lastupd" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <EmptyDataTemplate>
                        No Records Available.
                    </EmptyDataTemplate>
                </asp:GridView>

                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=.\sqlexpress;Initial Catalog=fee1;Integrated Security=True;Pooling=False" ProviderName="System.Data.SqlClient" SelectCommand="pri_view" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" DefaultValue="" Name="rst" PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>


                <br />
            </div>

        </div>
    </div>
</asp:Content>

