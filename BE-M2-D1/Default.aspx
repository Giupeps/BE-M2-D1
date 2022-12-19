<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BE_M2_D1.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <h1>Prova</h1>
     <asp:GridView ID="GridDefault" CssClass="table table-bordered  table-striped table-light container-tabella " runat="server"
            AutoGenerateColumns="false" ItemType="BE_M2_D1.Dipendente" Visible="true">
            <Columns>
                <asp:TemplateField HeaderText="Nome">
                    <ItemTemplate>
                        <p class="ps-2"><%#Item.Nome %><%# Item.Cognome %></p>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Modello">
                    <ItemTemplate>
                        <p><%# Item.CodiceFiscale %></p>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Prezzo">
                    <ItemTemplate>
                        <p><%# Item.Indirizzo %></p>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Quantita">
                    <ItemTemplate>
                        <p><%# Item.Mansione %></p>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </div>
</asp:Content>
