<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroUsuarios.aspx.cs" Inherits="PasteleriaProyect.RegistroUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="padding-spacegrillas">
    <asp:ScriptManager ID="Script1" runat="server" />
    <asp:UpdatePanel ID="Upadate1" runat="server">
        <ContentTemplate>
            <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateColumns="False" CssClass="table mt-5" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None">
                <HeaderStyle BackColor="#DCDCDC" Font-Bold="True" ForeColor="black" />
                <RowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="idUser" HeaderText="ID" />
                    <asp:BoundField DataField="nameUser" HeaderText="Nombre de Usuario" />
                    <asp:BoundField DataField="password" HeaderText="Contraseña" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" CssClass="btn btn-warning" data-bs-toggle="modal" data-bs-target="#Modalselect" OnClick="btnSeleccionar_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
    
     <div class="modal fade" id="Modalselect" tabindex="-1" aria-labelledby="exampleModal" aria-hidden="true">
                <div class="modal-dialog">
                 <div class="modal-content">
                   
                  <div class="modal-header">
                    <h5 class="modal-title" id="exampleModal">Editar Usuario</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                      <asp:UpdatePanel ID="Upadate3" runat="server">
                          <ContentTemplate>
                              <div class="row g-3">
                                <div class="col-6 ">
                                     <asp:TextBox ID="txtId" runat="server" Visible="false" Style="display:none"></asp:TextBox>
                                    <asp:Label ID="Label3" runat="server" Text="Nombre Usuario:"></asp:Label>
                                    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                                </div>
                                
                                <div class="col-6 ">
                                    <asp:Label ID="Label4" runat="server" Text="Contraseña:"></asp:Label>
                                    <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
                                    <asp:TextBox ID="txtState" runat="server" Visible="true" Style="display:none"> </asp:TextBox>
                                </div>
                                    
                                 </div>
                             <div class="modal-footer">
                      <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-info" OnClick="btnModificar_Click" />
                     <asp:Button ID="btnCambios" runat="server" Text="Agregar Cambios" CssClass="btn btn-success" OnClick="btnCambios_Click" />
                     <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click"/>
                     <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cerrar</button>
                         </div>  
                          </ContentTemplate>
                           </asp:UpdatePanel>
                            </div>
                    
                </div>
            </div>
        </div>
  <div class="d-flex justify-content-center pl-4">
     <Button type="button" class="btn btn-light d-flex justify-content-around" data-bs-toggle="modal" data-bs-target="#Modal">Nuevo Usuario</Button>
    </div>
        
    <div class="modal fade" id="Modal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Nuevo Usuario</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                           
                                 <div class="row g-3">
                                <div class="col-6 ">
                                    <asp:Label ID="Label1" runat="server" Text="Nombre Usuario:"></asp:Label>
                                    <asp:TextBox ID="txtNameUsernew" runat="server"></asp:TextBox>
                                </div>
                                
                                <div class="col-6 ">
                                    <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label>
                                    <asp:TextBox ID="txtPassnew" runat="server"></asp:TextBox>
                                      <asp:TextBox ID="txtStatenew" runat="server" Visible="true" Style="display:none"> </asp:TextBox>
                                </div>
                                     
                                 </div>
                            <div class="modal-footer">
                     <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="btnAgregar_Click" />
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cerrar</button>
                        </div>  
        </ContentTemplate>
                    </asp:UpdatePanel>
                            </div>
       
                </div>
            </div>
        </div>
    </div>
             
</asp:Content>
