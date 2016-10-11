<%@ Page Title="" Language="C#" MasterPageFile="~/next/student/student.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="profilesu.aspx.cs" Inherits="next_student_Default" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"><br />
      <br />
    <div class="container">
        <div class="row">
            <form role="form">
                <div class="col-md-6 col-md-offset-3">
                    <div class="well well-sm"><strong><span class="glyphicon glyphicon-asterisk"></span>YOUR DETAIL'S</strong></div>
                    <div class="form-group">
                        <label for="InputName">First Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   <asp:Label ID="firstname" runat="server" style="font-weight: 700" ></asp:Label></label>
                     
                    </div>
                    <div class="form-group">
                        <label for="InputEmail">Last Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>
                        <asp:Label ID="lastname" runat="server"  style="font-weight: 700"></asp:Label>
                        
                    </div>

                    <div class="form-group">
                        <label for="InputEmail" >Roll No.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>
                        <asp:Label ID="rollno" runat="server" style="font-weight: 700"></asp:Label>
                       
                    </div>
                    <div class="form-group">
                        <label for="InputEmail" >Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>
                        <asp:Label ID="email" runat="server" style="font-weight: 700"></asp:Label>
                       
                    </div>
                    <div class="form-group">
                        <label for="InputName">Date of Birth</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;     <asp:Label ID="dob" runat="server" style="font-weight: 700"></asp:Label>
                       
                    </div>
                    <div class="form-group">
                        <label for="InputEmail">Contact Number</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   <asp:Label ID="contact" runat="server" style="font-weight: 700"></asp:Label>
                       
                    </div>
                    <div class="form-group">
                        <label for="InputEmail">Department</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;        <asp:Label ID="department" runat="server" style="font-weight: 700"></asp:Label>
                       
                    </div>
                    <div class="form-group">
                        <label for="InputEmail">Father Name</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;            <asp:Label ID="fathername" runat="server" style="font-weight: 700"></asp:Label>
                        
                    </div>
                    <div class="form-group">
                        <label for="InputEmail">Mother Name</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;             <asp:Label ID="mothername" runat="server" style="font-weight: 700"></asp:Label>
                      
                    </div>
                    <div class="form-group">
                        <label for="InputEmail">Address</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;     <asp:Label ID="address" runat="server" style="font-weight: 700"></asp:Label>
                        
                    </div>
                    <div class="form-group">
                        <label for="InputEmail">Last Updated</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    <asp:Label ID="lastupdate" runat="server" style="font-weight: 700"></asp:Label>
                        
                    </div>
                    <div class="form-group">
                        <div class="input-group">
                            <asp:Button ID="changepassword" runat="server" Text="Change Password" CssClass="btn btn-info pull-right" OnClick="change_Click" />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="passwordlbl" runat="server" Text="Password" Visible="False"></asp:Label> 
                        <div class="input-group">
                            <asp:TextBox ID="password" runat="server" CssClass="form-control" placeholder="Password" TextMode="Password"  Visible="False"></asp:TextBox>
                            <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="cnfrmpasswordlbl" runat="server" Text="Confirm Password" Visible="False"></asp:Label> 
                        <div class="input-group">
                            <asp:TextBox ID="cpassword" runat="server" CssClass="form-control" placeholder="Confirm Password" TextMode="Password"  Visible="False" ></asp:TextBox>
                            <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="input-group">
                            <asp:Button ID="submit" runat="server" Text="Update" CssClass="btn btn-info pull-right" OnClick="submit_Click" Visible="False" />
                            <asp:Button ID="cancel" runat="server" Text="Cancel" CssClass="btn btn-info pull-right" OnClick="cancel_Click"  Visible="false"/>
                        </div>
                    </div>


                    <asp:Label ID="success" runat="server" CssClass="alert alert-success glyphicon glyphicon-ok " Visible="False"></asp:Label>
            </form>
            <%--    <div class="col-lg-5 col-md-push-1">
            <div class="col-md-12">
                <div class="alert alert-success">
                    <strong><span class="glyphicon glyphicon-ok"></span> Success! Message sent.</strong>
                </div>
                <div class="alert alert-danger">
                    <span class="glyphicon glyphicon-remove"></span><strong> Error! Please check all page inputs.</strong>
                </div>
            </div>
        </div>--%>
        </div>
    </div>
</asp:Content>

