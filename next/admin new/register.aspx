<%@ Page Title="" Language="C#" MasterPageFile="~/next/admin new/MasterPage.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="next_admin_new_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
        <div>
            <div class="row text-center">
                <h2>New Registration</h2>
            </div>
            <div class="form-group">
                <label for="firstname" class="col-md-2">
                    <span style="color: #FFFFCC">First Name:</span>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="firstname" runat="server" placeholder="Enter First Name" class="form-control" Width="400px"></asp:TextBox>
                </div>

            </div>
            <div>
                <span style="color: #FFFFCC">
                    <label for="lastname" class="col-md-2">
                        Last Name:</label></span>
                <div class="col-md-9">
                    <asp:TextBox ID="lastname" runat="server" class="form-control" placeholder="Enter Last Name" Width="400px"></asp:TextBox>
                </div>

            </div>


            <div>
                <span style="color: #FFFFCC">
                    <label for="emailaddress" class="col-md-2">
                        Email address:</label></span><label for="emailaddress" class="col-md-2" style="color: #FFFFFF">
                        </label>
                <div class="col-md-9">
                    <asp:TextBox ID="emailaddress" runat="server" Class="form-control" placeholder="Enter Email Id" Width="400px"></asp:TextBox>
                </div>
            </div>

            <div>
                <label for="password" class="col-md-2">
                    <span class="fa-inverse" style="color: #FFFFCC">Password</span><span style="color: #FFFFFF">:
                    </span>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="Password" runat="server" CssClass="form-control" Placeholder="Enter Strong Password" TextMode="Password" Width="400px"></asp:TextBox>
                </div>

            </div>
            <div>
                <span style="color: #FFFFCC">
                    <label for="sex" class="col-md-2">
                        Gender:
                    </label>
                </span>
                <div class="col-md-10">
                    <asp:DropDownList ID="DropDownList2" class="form-control" runat="server" Height="39px" Width="161px">
                        <asp:ListItem Value="0">--Select--</asp:ListItem>
                        <asp:ListItem Value="1">Men</asp:ListItem>
                        <asp:ListItem Value="2">Women</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div>
                <label for="country" class="col-md-2">
                    <span style="color: #FFFFCC">Country:</span>
                </label>
                <div class="col-md-9">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="37px" Width="161px" DataSourceID="SqlDataSource1" class="form-control" DataTextField="name" DataValueField="name">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=.\sqlexpress;Initial Catalog=fee;Integrated Security=True;Pooling=False" ProviderName="System.Data.SqlClient" SelectCommand="select name from country"></asp:SqlDataSource>
                </div>

            </div>

            <div>
                <label for="position" class="col-md-2">
                    <span style="color: #FFFFCC">Position:</span>
                </label>
                <div class="col-md-9">
                    <asp:DropDownList ID="DropDownList3" runat="server" class="form-control" AutoPostBack="True" Height="40px" Width="161px">
                        <asp:ListItem Value="0">--Select--</asp:ListItem>
                        <asp:ListItem Value="1">C.C.</asp:ListItem>
                        <asp:ListItem Value="2">Student</asp:ListItem>
                        <asp:ListItem Value="3">Parent</asp:ListItem>
                    </asp:DropDownList>

                </div>
            </div>
            <div>
                <span style="color: #FFFFCC">
                    <asp:Label runat="server" Text="Parent Name" class="col-md-2"></asp:Label>
                <div class="col-md-9">
                    <asp:TextBox ID="parent" runat="server" class="form-control" placeholder="Enter Parent Name" Width="400px" ReadOnly="True" ></asp:TextBox>
                </div>

            </div>

            <div>
                <span style="color: #FFFFCC">
                    <asp:Label runat="server" Text="Parent E-mail" class="col-md-2"></asp:Label>
                <div class="col-md-9">
                    <asp:TextBox ID="parentemail" runat="server" class="form-control" placeholder="Enter Parent E-mail" Width="400px" ReadOnly="True"></asp:TextBox>
                </div>

            </div>

            <div>
                <span style="color: #FFFFCC">
                    <asp:Label runat="server" Text="Parent Contact" class="col-md-2"></asp:Label>
                <div class="col-md-9">
                    <asp:TextBox ID="parentcontact" runat="server" class="form-control" placeholder="Enter Parent Contact" Width="400px" ReadOnly="True"></asp:TextBox>
                </div>

            </div>
            <div>
                <label for="sem" class="col-md-2">
                    <span style="color: #FFFFCC">Semester:</span>
                </label>
                <div class="col-md-9">
                    <asp:DropDownList ID="Sem" runat="server" class="form-control" AutoPostBack="false"  Enabled="false" Height="40px" Width="161px">
                        <asp:ListItem Value="0">--Select--</asp:ListItem>
                        <asp:ListItem Value="1">1st</asp:ListItem>
                        <asp:ListItem Value="2">2nd</asp:ListItem>
                        <asp:ListItem Value="3">3rd</asp:ListItem>
                        <asp:ListItem Value="4">4th</asp:ListItem>
                        <asp:ListItem Value="5">5th</asp:ListItem>
                        <asp:ListItem Value="6">6th</asp:ListItem>
                        <asp:ListItem Value="7">7th</asp:ListItem>
                        <asp:ListItem Value="8">8th</asp:ListItem>
                    </asp:DropDownList>

                </div>
            </div>

            <div class="form-group">
                <label for="rollno" class="col-md-2">
                    <span style="color: #FFFFCC">Roll No.</span>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="rollno" runat="server" placeholder="Roll No." class="form-control" Width="161px" ReadOnly="True"></asp:TextBox>
                </div>

            </div>
            <div class="form-group">
                <label for="sem" class="col-md-2">
                    <span style="color: #FFFFCC">Department</span>
                </label>
                <div class="col-md-9">
                    <asp:DropDownList ID="DropDownList4" runat="server" class="form-control" AutoPostBack="false" Height="40px" Width="161px">
                        <asp:ListItem Selected="True" Value="0">--Select--</asp:ListItem>
                        <asp:ListItem Value="1">Computer Science Engineering</asp:ListItem>
                        <asp:ListItem Value="2">Mechanical Engineering</asp:ListItem>
                        <asp:ListItem Value="3">Civil Engineering</asp:ListItem>
                        <asp:ListItem Value="5">Electronic And Communication Engineering</asp:ListItem>
                        <asp:ListItem Value="5">Applied  Science</asp:ListItem>
                    </asp:DropDownList>

                </div>
            </div>

            <div>
                <span style="color: #FFFFCC">
                    <label for="country" class="col-md-2">
                        Contact No.:
                    </label>
                </span>
                <div class="col-md-9">
                    <asp:TextBox ID="contact" runat="server" CssClass="form-control" placeholder="Enter Your Mobile No." Width="400px"></asp:TextBox>

                </div>

            </div>


                
        <div>


            <div class="col-md-9">
            </div>

        </div>
        <div>


            <div class="col-md-9">
                <asp:button id="Button1" runat="server" text="Register" onclick="Button1_Click" cssclass="btn btn-succes active" style="background-color: #0000CC" />


            </div>

        </div>
        <div>


            <div class="col-md-9">
            </div>

        </div>
        <div>


            <div class="col-md-9">
                <asp:label id="success" runat="server" text="" visible="False" cssclass="alert alert-success glyphicon glyphicon-ok"></asp:label>


            </div>

        </div>
    

            </span></span></span>
    

</asp:Content>

