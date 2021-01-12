<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="WEB_FORM.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <style>
        html, body {
            width: 100%;
            height: 100%;
        }

        .container1 {
            width: 100px;
            height: 100px;
            position: absolute;
            top: 30%;
            left: 40%;
            margin: auto;
        }
    </style>
</head>
<body>
    <div class="container1">
        <div class="container justify-content-center ">
            <form id="form1" runat="server">
                <div class="card text-center" style="width: 18rem;">
                    <div class="card-body">
                        <h5 id="fname" class="card-title" runat="server">Card title</h5>
                        <h6 id="email" runat="server" class="card-subtitle mb-2 text-muted">Card subtitle</h6>
                        <p class="card-text">. . . </p>
                        <asp:Button ID="back" CssClass="card-text btn btn-dark" Text="Back" runat="server" OnClick="back_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>
    <script src="Scripts/jquery-3.4.1.min.js"></script>
</body>
</html>
