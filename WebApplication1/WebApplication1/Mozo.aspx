<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mozo.aspx.cs" Inherits="PasteleriaProyect.Mozo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
 <div class="padding-spacegrillas">
    <asp:ScriptManager ID="Script1" runat="server"/>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:GridView ID="gvMozos" runat="server" Width="100%" AutoGenerateColumns="False" CssClass="table mt-5" CellPadding="4" GridLines="None" Height="232px"  >
                  <HeaderStyle BackColor="#DCDCDC" Font-Bold="True" ForeColor="black" />
                <RowStyle BackColor="White" />
                 <Columns>
                  
                    <asp:BoundField DataField="mozo" HeaderText="ID" />
                    <asp:BoundField DataField="name" HeaderText="Nombre" />
                    <asp:BoundField DataField="lastname" HeaderText="Apellido" />
                    <asp:BoundField DataField="cellphone" HeaderText="Telefono" />
                     <asp:BoundField DataField="email" HeaderText="Email" />
                    <asp:BoundField DataField="usuario.idUser" HeaderText="Usuario" />
                      <asp:BoundField DataField="usuario.nameUser" HeaderText="Nombre Usuario" />
                     <asp:BoundField DataField="estado" HeaderText="Estado" />
                    <asp:BoundField DataField="comision" HeaderText="Comision" />
                   <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" CssClass="btn btn-warning" data-bs-toggle="modal" data-bs-target="#Modalselect" OnClick="btnSeleccionar_Click"  />
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
                    <h5 class="modal-title" id="exampleModal">Editar Mozo</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                           <asp:UpdatePanel ID="Upadate3" runat="server">
                          <ContentTemplate>
                                 <div class="row g-3">
                                <div class="col-6 ">
                                     <asp:TextBox ID="txtId" runat="server" Visible="false" Style="display:none"></asp:TextBox>
                                    <asp:Label ID="lb1" runat="server" Text="Nombre:"></asp:Label>
                                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                                </div>
                                
                                <div class="col-6 ">
                                    <asp:Label ID="lb2" runat="server" Text="Apellido:"></asp:Label>
                                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                                </div>
                                     
                                       
                                 <div class="col-6">
                                    <asp:Label ID="lb3" runat="server" Text="Telefono:"></asp:Label>
                                    <asp:TextBox ID="txtCellphone" runat="server"></asp:TextBox>
                                </div>
                                 <div class="col-6 ">
                                    <asp:Label ID="lb4" runat="server" Text="Email:"></asp:Label>
                                    <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
                                </div>
                                     <div class="col-6 ">              
                                        <asp:TextBox ID="txtidUser" runat="server" Visible="false" Style="display: none"></asp:TextBox>
                                    <asp:Label ID="lb5" runat="server" Text="Nombre de Usuario:"></asp:Label>
                                    <asp:TextBox ID="txtNameUser" runat="server"></asp:TextBox>
                                          </div>
                                 <div class="col-6">
                                    <asp:Label ID="lb6" runat="server" Text="Comision:"></asp:Label>
                                   <label><asp:TextBox ID="txtComision" runat="server"></asp:TextBox>%</label>
                                       <asp:TextBox ID="txtstate" runat="server" Visible="false" Style="display:none"></asp:TextBox>
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
     <Button type="button" class="btn btn-light" data-bs-toggle="modal" data-bs-target="#ModalMozo">Nuevo Mozo</Button>
   </div>
            <div class="modal fade" id="ModalMozo" tabindex="-1" aria-labelledby="exampleMo" aria-hidden="true">
                <div class="modal-dialog">
                 <div class="modal-content">
                  <div class="modal-header">
                    <h5 class="modal-title" id="exampleMo">Agregar Mozo</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                           <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                          <ContentTemplate>
                                 <div class="row g-3">
                                <div class="col-6 ">
                                    <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                                    <asp:TextBox ID="txtNamenew" runat="server"></asp:TextBox>
                                </div>
                                
                                <div class="col-6 ">
                                    <asp:Label ID="Label2" runat="server" Text="Apellido:"></asp:Label>
                                    <asp:TextBox ID="txtLastNamenew" runat="server"></asp:TextBox>
                                </div>
                                     
                                       
                                 <div class="col-6">
                                    <asp:Label ID="Label3" runat="server" Text="Telefono:"></asp:Label>
                                    <asp:TextBox ID="txtCellphonenew" runat="server"></asp:TextBox>
                                </div>
                                 <div class="col-6 ">
                                    <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
                                    <asp:TextBox ID="txtMailnew" runat="server"></asp:TextBox>
                                </div>
                                   <div class="col-6 ">
                                     <asp:TextBox ID="txtidUsernew" runat="server" Visible="false" Style="display: none"></asp:TextBox>
                                   <asp:Label ID="Label6" runat="server" Text="Nombre de Usuario:"></asp:Label>
                                    <asp:TextBox ID="txtNameUsernew" runat="server"></asp:TextBox>
                                          </div>
                                     <div class="col-6 ">
                                         <asp:TextBox ID="txtstatenew" runat="server" Visible="false" Style="display:none"></asp:TextBox>
                                    <asp:Label ID="Label5" runat="server" Text="Comision:"></asp:Label>
                                  <label><asp:TextBox ID="txtComisionnew" runat="server"></asp:TextBox>%</label>
                                </div>
                                     </div>
                               <div class="modal-footer">
                     <asp:Button ID="btnPlus" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="btnPlus_Click" />
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