<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Local.aspx.cs" Inherits="PasteleriaProyect.Local" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" />
     <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.0/dist/jquery.min.js"></script>
    <script type="text/javascript" src="https://cdn.jsdelivr.net/npm/jquery-validation@1.19.3/dist/jquery.validate.min.js"></script>
    <script type='text/javascript' src='https://cdn.jsdelivr.net/npm/jquery-validation@1.19.3/dist/additional-methods.js'></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <div class="padding-spacegrillas">
     <asp:ScriptManager ID="Script1" runat="server"/>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:GridView ID="gvLocal" runat="server" Width="100%" AutoGenerateColumns="False" CssClass="table mt-5" CellPadding="4" GridLines="None" >
                <HeaderStyle BackColor="#DCDCDC" Font-Bold="True" ForeColor="black" />
                <RowStyle BackColor="White" />
                 <Columns>
                    <asp:BoundField DataField="idLocal" HeaderText="ID" />
                    <asp:BoundField DataField="Entidad" HeaderText="Nombre" />
                    <asp:BoundField DataField="CUIT" HeaderText="CUIT" />
                    <asp:BoundField DataField="IIBB" HeaderText="IIBB" />
                    <asp:BoundField DataField="IVA" HeaderText="Iva" />
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
                    <h5 class="modal-title" id="exampleModal">Editar Local</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                            <asp:UpdatePanel ID="Updatepanel3" runat="server">
        <ContentTemplate>
                                 <div class="row g-3">
                                <div class="col-6 ">
                                     <asp:TextBox ID="txtId" runat="server" Style="display:none"></asp:TextBox>
                                    <asp:Label ID="lbl1" runat="server" Text="Nombre Entidad:"></asp:Label>
                                    <asp:TextBox ID="txtNameEntiti" runat="server"></asp:TextBox>
                                </div>
                                
                                <div class="col-6 ">
                                    <asp:Label ID="lbl2" runat="server" Text="CUIT:"></asp:Label>
                                    <asp:TextBox ID="txtCuit" runat="server"></asp:TextBox>
                                </div>
                                      <div class="col-6 ">
                                    <asp:Label ID="lbl3" runat="server" Text="IIBB:"></asp:Label>
                                    <asp:TextBox ID="txtIIBB" runat="server"></asp:TextBox>
                                </div>
                                
                                <div class="col-6 ">
                                    <asp:Label ID="lbl4" runat="server" Text="IVA:"></asp:Label>
                                    <asp:TextBox ID="txtIVA" runat="server"></asp:TextBox>
                                </div>
                                     
                                 </div>
                       <div class="modal-footer">
                             <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-info" OnClick="btnModificar_Click" />
                     <asp:Button ID="btnCambios" runat="server" Text="Agregar Cambios" CssClass="btn btn-success" OnClick="btnCambios_Click" />
                   <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cerrar</button>
                        </div>   
                           </ContentTemplate>
    </asp:UpdatePanel>



                            </div>
                     
                </div>
            </div>
        </div>
        <div class="d-flex justify-content-center pl-4">
     <Button type="button" class="btn btn-light" data-bs-toggle="modal" data-bs-target="#ModalLocal">Nuevo Local</Button>
    </div>
        
    <div class="modal fade" id="ModalLocal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Nuevo Local</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                      <ContentTemplate>
                      
                                 <div class="row g-3">
                                <div class="col-6 ">
                                    <asp:Label ID="Label1" runat="server" Text="Nombre Entidad:"></asp:Label>
                                    <asp:TextBox ID="txtNameEntitinew" runat="server"></asp:TextBox>
                                </div>
                                
                                <div class="col-6 ">
                                    <asp:Label ID="Label2" runat="server" Text="CUIT:"></asp:Label>
                                    <asp:TextBox ID="txtCuitnew" runat="server"></asp:TextBox>
                                </div>
                                      <div class="col-6 ">
                                    <asp:Label ID="Label3" runat="server" Text="IIBB:"></asp:Label>
                                    <asp:TextBox ID="txtIIBBnew" runat="server"></asp:TextBox>
                                </div>
                                
                                <div class="col-6 ">
                                    <asp:Label ID="Label4" runat="server" Text="IVA:"></asp:Label>
                                    <asp:TextBox ID="txtIVAnew" runat="server"></asp:TextBox>
                                </div>
                                     
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