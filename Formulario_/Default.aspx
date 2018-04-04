<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Formulario_._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
    <div>
    <h2>
        formulario de cadastro
    </h2>
        <p>
            &nbsp;</p>

        <div>
            <asp:Label ID="lblnome" runat="server" Text="Nome"
            ></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtnome" runat="server"></asp:TextBox>

            &nbsp;&nbsp;&nbsp;

            <asp:Label ID="lblsobrenome" runat="server" Text="Sobrenome"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtsobrenome" runat="server"></asp:TextBox>

            &nbsp;

            <asp:Label ID="lbldtnasc" runat="server" Text="Data de Nascimento"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtdcnasc" runat="server"></asp:TextBox>

            <br />

            <br />

            <asp:Label ID="lblemail" runat="server" Text="E-mail"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>

            &nbsp;&nbsp;

            <asp:Label ID="lblend" runat="server" Text="Endereço"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtend" runat="server"></asp:TextBox>

            &nbsp;

            <asp:Label ID="lblsalario" runat="server" Text="Salário"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtsalario" runat="server" style="margin-left: 0px">0</asp:TextBox>
            <br />
            <br />
            &nbsp;<asp:Label ID="lblidusuario" runat="server" Text="Label"></asp:Label>
            <br />
           &nbsp;<asp:Button ID="btnaincluir" runat="server" Text="Incluir" 
                Width="63px" onclick="btnaincluir_Click" />
            &nbsp;&nbsp;&nbsp;
            &nbsp;<asp:Button ID="btnatualizar" runat="server" Text="Atualizar" 
                Width="63px" onclick="btnatualizar_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;<asp:Button ID="btnpesquisar" runat="server" Text="Pesquisar" 
                Width="63px" onclick="btnpesquisar_Click" />

        </div>
       
    
    





    </div>
    <p>
        <asp:GridView ID="GridView1" runat="server" 
            AutoGenerateColumns="False" DataKeyNames="IDUSUARIO" 
            onrowcommand="GridView1_RowCommand" BackColor="#CCCCCC" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
            CellSpacing="2" ForeColor="Black" Width="674px">
            <Columns>
                <asp:BoundField DataField="Nome" HeaderText="Usuarios" />
                <asp:ButtonField CommandName="Excluir" Text="Excluir" />
                <asp:ButtonField CommandName="Editar" Text="Editar" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
