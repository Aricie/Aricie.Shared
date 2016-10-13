<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ViewDetails.ascx.vb"
    Inherits="Aricie.Shared.ViewDetails" %>
<div>
    <asp:Label ID="lblIntro" runat="server" resourcekey="lblIntro"></asp:Label>
</div>
<asp:GridView ID="Mdl" runat="server" AutoGenerateColumns="False">
    <RowStyle Height="35px" />
    <Columns>
        <asp:TemplateField>
            <HeaderTemplate>
                <asp:Label ID="Label1" runat="server" resourcekey="colHeader0.Text"></asp:Label>
            </HeaderTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("FriendlyName") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField>
            <HeaderTemplate>
                <asp:Label ID="Label5" runat="server" resourcekey="colHeader2.Text"></asp:Label>
            </HeaderTemplate>
            <ItemTemplate>
                <asp:Image ID="Image3" runat="server" ImageUrl="~/images/green-ok.gif" Visible='<%# Bind("Installed") %>' />
            </ItemTemplate>
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:TemplateField>
        <asp:TemplateField>
            <HeaderTemplate>
                <asp:Label ID="Label3" runat="server" resourcekey="colHeader1.Text"></asp:Label>
            </HeaderTemplate>
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%# Bind("Version") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
