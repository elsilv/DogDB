<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="DogDB.index" %>

<!DOCTYPE html>
<script runat="server">
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>Dog Database</h1>
                <asp:Label ID="Label1" runat="server" TextColor="#33CC33"></asp:Label>
                <hr />

                 <div> 
                 <h2>Add new Dog</h2>
            <table class="auto-style1">  
                <tr>  
                    <td>Name :</td>  
                    <td>  
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
                    </td>  
  
               </tr>  
                <tr>  
                    <td>Birthday</td>  
                     <td> <asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox></td>  
                </tr>  
                <tr>  
                    <td>Gender</td>  
                    <td>  
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">  
                            <asp:ListItem>Male</asp:ListItem>  
                            <asp:ListItem>Female</asp:ListItem>  
                        </asp:RadioButtonList>  
                    </td>  
               </tr>  
                <tr>  
                    <td>Owner id</td>  
                    <td>  
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                        <input id="Submit2" type="submit" value="submit"/> 
                    </td>  
                </tr>  
            </table>  
        </div>  

                <p> Search by </p>

                  <asp:DropDownList ID="DropDowntList1" runat="server">
                    <asp:ListItem Selected="True" Value="name"> Dog name </asp:ListItem>
                    <asp:ListItem Value="gender"> Dog gender </asp:ListItem>
                    <asp:ListItem Value="dog_id"> Dog id </asp:ListItem>
                    <asp:ListItem Value="owner_id"> Dog by Owner id </asp:ListItem>
                    <asp:ListItem Value="user_id"> User by Owner id </asp:ListItem>
                      <asp:ListItem Value="username"> User by name </asp:ListItem>
                  </asp:DropDownList>

                <asp:TextBox ID="Text1search" runat="server"></asp:TextBox>
                <input id="Submit1" type="submit" value="submit"/>

                 <p> Delete dog using id</p>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <input id="Submit3" type="submit" value="delete"/>
                <hr />

                <br />

                <asp:GridView ID="GridView1" runat="server"></asp:GridView>

            </center>
        </div>
    </form>
</body>
</html>
