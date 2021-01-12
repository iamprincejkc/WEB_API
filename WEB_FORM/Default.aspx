<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEB_FORM.Default" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" />
 <script src="https://code.jquery.com/jquery-3.3.1.js"></script>
      <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" ></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js" ></script>

</head>
<body>
    <div class="container justify-content-center">
        <form id="form1" method="post" runat="server">
            <%--<div id="popup" style="max-height: 300px; overflow-y: scroll;">--%>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>  
            <asp:Button ID="add" CssClass="btn btn-primary" Text="Add User" runat="server" OnClick="add_Click1" />
            <asp:GridView ID="GridView1" runat="server" CellPadding="20" GridLines="None" Width="93%" CssClass="gridView" HeaderStyle-HorizontalAlign="Center"
                AllowPaging="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound"
                PageSize="5"
                DataKeyNames="id"
                OnPageIndexChanging="GridView1_PageIndexChanging"
                OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" 
                OnRowUpdating="GridView1_RowUpdating" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellSpacing="1" AutoGenerateColumns="False">
                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="#E7E7FF" />
                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#ffffff" ForeColor="Black" />
                <SelectedRowStyle BackColor="#5b5b5c" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#33276A" />
                <Columns>

                    <asp:CommandField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ShowSelectButton="True" ControlStyle-CssClass="btn btn-outline-dark" />
                    <asp:CommandField ShowEditButton="True" ControlStyle-CssClass="btn btn-outline-dark" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" CssClass="btn btn-danger" runat="server" OnClick="LinkButton1_Click">Remove</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="ID" DataField="id" />
                    <asp:BoundField HeaderText="Firstname" DataField="fname" />
                    <asp:BoundField HeaderText="Lastname" DataField="lname" />
                    <asp:BoundField HeaderText="Email" DataField="email" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="LBDetails" CssClass="btn btn-info" runat="server" OnClick="LBDetails_Click">View Details</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>


      <div id="myModal" class="modal" tabindex="-1" role="dialog">
     <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title">Selected Data</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
          <asp:Label ID="Label2" runat="server" Text="Name:" />
          <asp:Label ID="Label1" runat="server" Text="" />
          <br />
          <asp:Label ID="Label4" runat="server" Text="ID:" />
          <asp:Label ID="Label3" runat="server" Text=""/>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <%--<button type="button" class="btn btn-primary">Save changes</button>--%>
      </div>
    </div>
  </div>
</div>
            <asp:Label ID="lblstatus" runat="server"></asp:Label>
                    </ContentTemplate>  
            </asp:UpdatePanel>
            <%--</div>--%>
        </form>
    </div>

</body>
</html>
