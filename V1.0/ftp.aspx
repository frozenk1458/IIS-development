<%@ Page Language="VB" CodeFile="ftp.aspx.vb" 
    Inherits="SamplePage" %>
	
<html>
<head runat="server" >
   <title>Code-Behind Page Model</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
       <asp:Label id="Label1" 
         runat="server" Text="Clic on the button to download a file" >
      </asp:Label>
      <br />
      <asp:Button id="Button1" 
         runat="server" 
         onclick="Button1_Click" 
         Text="Download" >
       </asp:Button>
    </div>
  </form>
</body>
</html>