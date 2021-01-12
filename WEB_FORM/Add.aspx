<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="Add.aspx.cs" Inherits="WEB_FORM.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <div class="container">
    <form id="form1" runat="server" method="post">
       
        <div class="form-group">
            <label for="fname1">Firstname</label>
            <input type="text" runat="server" class="form-control" id="fname" placeholder="Firstname" />
        </div>

        <div class="form-group">
            <label for="lname1">Password</label>
            <input type="text" runat="server" class="form-control" id="lname" placeholder="Lastname" />
        </div>

         <div class="form-group">
            <label for="email1">Email address</label>
            <input type="text" runat="server" class="form-control" id="email" aria-describedby="emailHelp" placeholder="Enter email" />
            <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
        </div>
        
             <asp:Button ID="submit" CssClass="btn btn-primary" Text="Submit"  runat="server" OnClick="submit_Click"/>

    </form>
</div>
</body>
</html>
