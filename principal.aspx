<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="principal.aspx.cs" EnableEventValidation="false" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <br />
     <head>
        <meta charset="UTF-8" />
        <!-- <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">  -->
        <title>Login Principal</title>
       
        <link rel="shortcut icon" href="../favicon.ico"> 
        
        <link rel="stylesheet" type="text/css" href="css/style4.css" />
		<link rel="stylesheet" type="text/css" href="css/animate-custom.css" />
    </head>
    <body>
        <div class="container">
            <!-- Codrops top bar -->
            
            <section>				
                <div id="container_demo" >
                    <!-- hidden anchor to stop jump http://www.css3create.com/Astuce-Empecher-le-scroll-avec-l-utilisation-de-target#wrap4  -->
                    <a class="hiddenanchor" id="toregister"></a>
                    <a class="hiddenanchor" id="tologin"></a>
                    <div id="wrapper">
                        <div id="login" class="form-group">
                            <form  action="mysuperscript.php" autocomplete="on"> 
                                <h1>Log in Principal</h1> 
                                <p> 
                                    <label for="username" class="uname" data-icon="u" > Your email </label>
                                   
                                    <asp:TextBox ID="username" runat="server" CssClass="form-control" placeholder="mymail@mail.com"></asp:TextBox>
                                </p>
                                <p> 
                                    <label for="password" class="youpasswd" data-icon="p"> Your password </label>
                                    <asp:TextBox ID="password" runat="server" placeholder="eg. X8df!90EO" CssClass="form-control" TextMode="Password" ></asp:TextBox>
                                </p>
                                <p class="keeplogin"> 
								     <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged"></asp:CheckBox>
									<label for="loginkeeping">Keep me logged in</label>
								</p>
                                <p class="login button"> 
                                    
                                    <asp:Button ID="submit" runat="server" Text="Login" OnClick="submit_Click"></asp:Button><br />
                                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

								</p>
                                
                            </form>
                        </div>

                        
						
                    </div>
                </div>  
            </section>
        </div>
    </body>
</html>
</asp:Content>

