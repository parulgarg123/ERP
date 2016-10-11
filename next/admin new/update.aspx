<%@ Page Title="" Language="C#" MasterPageFile="~/next/admin new/MasterPage.master" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="next_admin_new_Default" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
        <div class="row text-center">
            <h2>View & Update</h2>
        </div>
        <div class="form-group">
            <label for="firstname" class="col-md-2">
                <span style="color: #FFFFCC">First Name:</span>
            </label>
            <div class="col-md-9">
                <asp:textbox id="firstname" runat="server" placeholder="Enter First Name" class="form-control" width="400px"></asp:textbox>
            </div>

        </div>
        <div>
            <span style="color: #FFFFCC">
                <label for="lastname" class="col-md-2">
                    Last Name:</label></span>
            <div class="col-md-9">
                <asp:textbox id="lastname" runat="server" class="form-control" placeholder="Enter Last Name" width="400px"></asp:textbox>
            </div>

        </div>
        <div>
            <span style="color: #FFFFCC">
                <label for="emailaddress" class="col-md-2">
                    Email address:</label></span><label for="emailaddress" class="col-md-2" style="color: #FFFFFF">
                    </label>
            <div class="col-md-9">
                <asp:textbox id="emailaddress" runat="server" class="form-control" placeholder="Enter Email Id" width="400px"></asp:textbox>
            </div>
        </div>
        <div>
            <span style="color: #FFFFCC">
                <label for="fathername" class="col-md-2">
                    Father's Name:</label></span>
            <div class="col-md-9">
                <asp:textbox id="father_name" runat="server" class="form-control" placeholder="Father's Name" width="400px"></asp:textbox>
            </div>

        </div>
        <div>
            <span style="color: #FFFFCC">
                <label for="mothername" class="col-md-2">
                    Mother's Name:</label></span>
            <div class="col-md-9">
                <asp:textbox id="mother_name" runat="server" class="form-control" placeholder="Mother's Name" width="400px"></asp:textbox>
            </div>

        </div>
        <div>
            <label for="password" class="col-md-2">
                <span class="fa-inverse" style="color: #FFFFCC">Password</span><span style="color: #FFFFFF">:
                </span>
            </label>
            <div class="col-md-9">
                <asp:textbox id="Password" runat="server" cssclass="form-control" placeholder="Enter Strong Password" textmode="Password" width="400px"></asp:textbox>
            </div>

        </div>

      <div>
            <label for="position" class="col-md-2">
                <span style="color: #FFFFCC">Position:</span>
            </label>
            <div class="col-md-9">
                <asp:dropdownlist id="DropDownList3" runat="server" class="form-control" autopostback="True" height="40px" width="161px">
                    <asp:ListItem Value="0">--Select--</asp:ListItem>
                    <asp:ListItem Value="1">C.C.</asp:ListItem>
                    <asp:ListItem Value="2">Student</asp:ListItem>
                    <asp:ListItem Value="3">Parent</asp:ListItem>
                </asp:dropdownlist>

            </div>
        </div>
        <div>
            <span style="color: #FFFFCC">
                <label for="sex" class="col-md-2">
                    Gender:
                </label>
            </span>
            <div class="col-md-10">
                <asp:dropdownlist id="DropDownList2" class="form-control" runat="server" height="39px" width="161px">
                    <asp:ListItem Value="0">--Select--</asp:ListItem>
                    <asp:ListItem Value="1">Men</asp:ListItem>
                    <asp:ListItem Value="2">Women</asp:ListItem>
                </asp:dropdownlist>
            </div>
        </div>
        <div class="form-group">
            <label for="date" class="col-md-2">
                <span style="color: #FFFFCC">D.O.B.</span>
            </label>
            <div class="col-md-9">
                <asp:textbox id="dob" runat="server" placeholder="D.O.B." class="form-control" width="161px"></asp:textbox>
            </div>
        </div>
        <div class="form-group">
            <label for="address" class="col-md-2">
                <span style="color: #FFFFCC">Adress:</span>
            </label>
            <div class="col-md-9">
                <asp:textbox id="address" runat="server" placeholder="Address" class="form-control" width="161px" height="81px" rows="4" textmode="MultiLine"></asp:textbox>
            </div>

        </div>
        <div class="form-group">
            <label for="hostel" class="col-md-2">
                <span style="color: #FFFFCC">Hostel</span>
            </label>
            <div class="col-md-9">
                <asp:textbox id="hostel" runat="server" placeholder="Hostel" class="form-control" width="161px"></asp:textbox>
            </div>

        </div>
        <div class="form-group">
            <label for="bus" class="col-md-2">
                <span style="color: #FFFFCC">Bus Facility</span>
            </label>
            <div class="col-md-9">
                <asp:textbox id="bus" runat="server" placeholder="Bus" class="form-control" width="161px"></asp:textbox>
            </div>

        </div>
        <div>
            <label for="country" class="col-md-2">
                <span style="color: #FFFFCC">Country:</span>
            </label>
            <div class="col-md-9">
                <asp:dropdownlist id="DropDownList1" runat="server" height="37px" width="161px" datasourceid="SqlDataSource1" class="form-control" datatextfield="name" datavaluefield="name">
                </asp:dropdownlist>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=.\sqlexpress;Initial Catalog=fee;Integrated Security=True;Pooling=False" ProviderName="System.Data.SqlClient" SelectCommand="select name from country"></asp:SqlDataSource>
            </div>

        </div>

      
     <%--<div>
                <span style="color: #FFFFCC">
                    <asp:Label runat="server" Text="Parent Name" class="col-md-2"></asp:Label>
                <div class="col-md-9">
                    <asp:TextBox ID="parent" runat="server" class="form-control" placeholder="Enter Parent Name" Width="400px" ReadOnly="True" ></asp:TextBox>
                </div>

            </div>--%>

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
                <asp:dropdownlist id="Sem" runat="server" class="form-control" autopostback="false" height="40px" width="161px">
                    <asp:ListItem Value="0">--Select--</asp:ListItem>
                    <asp:ListItem Value="1">1st</asp:ListItem>
                    <asp:ListItem Value="2">2nd</asp:ListItem>
                    <asp:ListItem Value="3">3rd</asp:ListItem>
                    <asp:ListItem Value="4">4th</asp:ListItem>
                    <asp:ListItem Value="5">5th</asp:ListItem>
                    <asp:ListItem Value="6">6th</asp:ListItem>
                    <asp:ListItem Value="7">7th</asp:ListItem>
                    <asp:ListItem Value="8">8th</asp:ListItem>
                </asp:dropdownlist>

            </div>
        </div>

        <div class="form-group">
            <label for="rollno" class="col-md-2">
                <span style="color: #FFFFCC">Roll No.</span>
            </label>
            <div class="col-md-9">
                <asp:textbox id="rollno" runat="server" placeholder="Roll No." class="form-control" width="161px"></asp:textbox>
            </div>

        </div>
        <div class="form-group">
            <label for="sem" class="col-md-2">
                <span style="color: #FFFFCC">Department</span>
            </label>
            <div class="col-md-9">
                <asp:dropdownlist id="DropDownList4" runat="server" class="form-control" autopostback="false" height="40px" width="161px">
                    <asp:ListItem Selected="True" Value="0">--Select--</asp:ListItem>
                    <asp:ListItem Value="1">Computer Science Engineering</asp:ListItem>
                    <asp:ListItem Value="2">Mechanical Engineering</asp:ListItem>
                    <asp:ListItem Value="3">Civil Engineering</asp:ListItem>
                    <asp:ListItem Value="5">Electronic And Communication Engineering</asp:ListItem>
                    <asp:ListItem Value="5">Applied  Science</asp:ListItem>
                </asp:dropdownlist>

            </div>
        </div>

        <div>
            <span style="color: #FFFFCC">
                <label for="contact" class="col-md-2">
                    Contact No.:
                </label>
            </span>
            <div class="col-md-9">
                <asp:textbox id="contact" runat="server" cssclass="form-control" placeholder="Enter Your Mobile No." width="400px"></asp:textbox>

            </div>

        </div>

        <div class="form-group">
            <label for="lastupd" class="col-md-2">
                <span style="color: #FFFFCC">Last Update:</span>
            </label>
            <div class="col-md-9">
                <asp:textbox id="lstupd" runat="server" placeholder="lstupd" class="form-control" width="161px" ReadOnly="True" Visible="True" Font-Bold="True" ForeColor="#FF3300" ToolTip="Last Udated By"></asp:textbox>
            </div>

        </div>

        <div>


            <div class="col-md-9">
            </div>

        </div>
        <div>


            <div class="col-md-9">
                <asp:button id="Button1" runat="server" text="Update" onclick="Button1_Click" cssclass="btn btn-succes active" style="background-color: #66FF66" />


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



    
</asp:Content>

