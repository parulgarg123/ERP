<%@ Page Title="" Language="C#" MasterPageFile="~/next/admin new/MasterPage.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="next_admin_new_Default" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    


    
        <!DOCTYPE html>
       

        
            <div class="row">
                <div class="col-lg-12">
                    <h1>Dashboard <small>Statistics and more</small></h1>
                    <div class="alert alert-dismissable alert-warning">
                        <button data-dismiss="alert" class="close" type="button">&times;</button>
                        Welcome to the admin dashboard! Feel free to ADD , UPDATE or DELETE ANY PERSON. 
                        <br />
                        According to Your Need and Requirments. 
                        BUT PLEASE ALWAYS GET PERMISSIONS TO DO ANY THING OR YOU MAY BE PUNISHED.
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-mod-8">
                    </>
                </div>
            </div>
            <div class="row">
                <div class="col-mod-8">

                    <div class="col-xs-3">
                        <h3 class="panel-title" style="padding-right: 50px;">Enter Roll No.   
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Roll No."></asp:TextBox><asp:Button runat="server" Text="Search" OnClick="Unnamed1_Click"></asp:Button>
                            &nbsp;&nbsp;<asp:Button ID="reset" runat="server" OnClick="reset_Click" Text="Reset" />
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label16" runat="server" style="color: #FF0000" Text="No Results " Visible="False"></asp:Label>
&nbsp;&nbsp;
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="regid" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" OnRowDataBound="GridView1_RowDataBound1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Width="1335px">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>
                                    <asp:BoundField DataField="regid" HeaderText="Regid" InsertVisible="False" ReadOnly="True" SortExpression="regid" />
                                    <asp:BoundField DataField="fname" HeaderText="First Name" SortExpression="fname" />
                                    <asp:BoundField DataField="lname" HeaderText="Last Name" SortExpression="lname" />
                                    <asp:BoundField DataField="rollno" HeaderText="Roll No." SortExpression="rollno" />
                                    <asp:BoundField DataField="dept" HeaderText="Department" SortExpression="dept" />
                                    <asp:BoundField DataField="sem" HeaderText="Semester" SortExpression="sem" />
                                    <asp:BoundField DataField="acc_type" HeaderText="Position" SortExpression="acc_type" />
                                    <asp:BoundField DataField="lastupd" HeaderText="Last Update" SortExpression="lastupd" />
                                </Columns>
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=.\sqlexpress;Initial Catalog=fee1;Integrated Security=True;Pooling=False" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [regid], [fname], [lname], [rollno], [dept], [sem], [acc_type], [lastupd] FROM [register] WHERE ([rollno] = @rollno)">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="TextBox1" Name="rollno" PropertyName="Text" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                            <%--<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:feeConnectionString %>" SelectCommand="SELECT [regid], [fname], [lname], [rollno], [dept], [sem], [acc_type], [lastupd] FROM [register] WHERE ([rollno] = @rollno)" ProviderName="System.Data.SqlClient">
                            --%>    
                            <%--</asp:SqlDataSource>--%>
                        </h3>
                    </div>
                </div>

            </div>
            <div class="row">

                <br />
                <br />


            </div>
            <div class="row">
                <div class="col-md-8">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <h3 class="panel-title"><i class="fa fa-bar-chart-o"></i>Total No of Members We Have.....</h3>
                            <p class="panel-title">&nbsp;</p>
                            <p class="panel-title" style="margin-left: 80px">
                                <strong>DEPARTMENT&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; FACULTY&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; STUDENT&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
                            </p>
                            <p class="panel-title" style="margin-left: 80px">
                                &nbsp;
                            </p>
                            <p class="panel-title" style="margin-left: 80px">
                                <strong>Applied Science&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label2" runat="server"></asp:Label>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:Label ID="Label3" runat="server"></asp:Label>
                                </strong>
                            </p>
                            <p class="panel-title" style="margin-left: 80px">
                                &nbsp;
                            </p>
                            <p class="panel-title" style="margin-left: 80px">
                                <strong>Computer Science&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label5" runat="server"></asp:Label>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label6" runat="server"></asp:Label>
                                </strong>
                            </p>
                            <p class="panel-title" style="margin-left: 80px">
                                <strong>&nbsp; </strong>
                            </p>
                            <p class="panel-title" style="margin-left: 80px">
                                <strong>Civil Engineering&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label8" runat="server"></asp:Label>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:Label ID="Label9" runat="server"></asp:Label>
                                </strong>
                            </p>
                            <p class="panel-title" style="margin-left: 80px">
                                &nbsp;
                            </p>
                            <p class="panel-title" style="margin-left: 80px">
                                <strong>Mechanical Engineering&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                                <asp:Label ID="Label10" runat="server"></asp:Label>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label11" runat="server"></asp:Label>
                                </strong>
                            </p>
                            <p class="panel-title" style="margin-left: 80px">
                                &nbsp;
                            </p>
                            <p class="panel-title" style="margin-left: 80px">
                                <strong>Electronic &amp; Comm.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label12" runat="server"></asp:Label>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label13" runat="server"></asp:Label>
                                </strong>
                            </p>
                            <p class="panel-title" style="margin-left: 80px">
                                &nbsp;
                            </p>
                            <hr />
                            <p class="panel-title" style="margin-left: 80px">
                                <strong>Total:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
                                <asp:Label ID="Label14" runat="server" Style="font-weight: 700"></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                                <asp:Label ID="Label15" runat="server" Style="font-weight: 700"></asp:Label>
                            </p>
                            <p class="panel-title" style="margin-left: 80px">
                                <strong>
                            </p>
                        </div>
                    </div>

                </div>
            </div>
            <!-- /#wrapper -->


 
      
    
    </div>
   
</strong>
   
</asp:Content>

