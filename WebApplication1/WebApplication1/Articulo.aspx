<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articulo.aspx.cs" Inherits="PasteleriaProyect.Articulo" %>

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
        <asp:ScriptManager ID="Sc1" runat="server" />
        <asp:UpdatePanel ID="Updt1" runat="server">
            <ContentTemplate>
                <asp:GridView ID="gvArticulo" runat="server" AutoGenerateColumns="False" CssClass="table mt-5" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <HeaderStyle BackColor="#DCDCDC" Font-Bold="True" ForeColor="black" />
                    <RowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="idArticulo" HeaderText="ID" />
                        <asp:BoundField DataField="rubro.nameRubro" HeaderText="Nombre de Rubro" />
                        <asp:BoundField DataField="idRubro" HeaderText="IdRubro" />
                        <asp:BoundField DataField="nameArticulo" HeaderText="Nombre Articulo " />
                        <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                        <asp:BoundField DataField="precio" HeaderText="Precio" />

                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" CssClass="btn btn-warning" data-bs-toggle="modal" data-bs-target="#Modalselect" OnClick="btnSeleccionar_Click" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <div class="d-flex justify-content-center pl-4">
                    <asp:Button runat="server" ID="btnNuevo" type="button" Text="Nuevo Articulo" CssClass="btn btn-light" data-bs-toggle="modal" data-bs-target="#ModalArticulo" OnClick="btnNuevo_Click"></asp:Button>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>

        <div class="modal fade" id="Modalselect" tabindex="-1" aria-labelledby="exampleModal" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModal">Editar Articulo</h5>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                            <ContentTemplate>
                                <div class="row g-3">
                                    <div class="col-6 ">
                                        <asp:TextBox ID="input0" runat="server" Visible="false" Style="display: none"></asp:TextBox>
                                        <asp:Label ID="lb1" runat="server" Text="Nombre Rubro:"></asp:Label>
                                        <asp:TextBox ID="txtNameRubro" runat="server"></asp:TextBox>
                                    </div>

                                    <div class="col-6 ">
                                        <asp:Label ID="lb2" runat="server" Text="Nombre de Articulo:"></asp:Label>
                                        <asp:TextBox ID="txtNameArticulo" runat="server"></asp:TextBox>
                                    </div>


                                    <div class="col-6">
                                        <asp:Label ID="lb3" runat="server" Text="Cantidad:"></asp:Label>
                                        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-6">
                                        <asp:Label ID="Label6" runat="server" Text="Rubro:"></asp:Label>
                                        <asp:DropDownList ID="dropRubroEdit" runat="server"></asp:DropDownList>
                                    </div>
                                    <div class="col-6 ">
                                        <asp:Label ID="lb4" runat="server" Text="Precio:"></asp:Label>
                                        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                                        <asp:TextBox ID="txtstate" runat="server" Visible="false" Style="display: none"></asp:TextBox>
                                    </div>

                                </div>
                                <div class="modal-footer">
                                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-info" OnClick="btnModificar_Click" />
                                    <asp:Button ID="btnCambios" runat="server" Text="Agregar Cambios" CssClass="btn btn-success" OnClick="btnCambios_Click" />
                                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" />
                                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cerrar</button>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>

                </div>
            </div>
        </div>



        <div class="modal fade" id="ModalArticulo" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Nuevo Articulo:</h5>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <div class="row g-3">
                                    <div class="col-6 ">
                                        <asp:Label ID="Label2" runat="server" Text="Nombre de Articulo:"></asp:Label>
                                        <asp:TextBox ID="txtNameArticulonew" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-6">
                                        <asp:Label ID="Label3" runat="server" Text="Cantidad:"></asp:Label>
                                        <asp:TextBox ID="txtQuantitynew" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-6">
                                        <asp:Label ID="Label5" runat="server" Text="Rubro:"></asp:Label>
                                        <asp:DropDownList ID="dropRubronew" runat="server"></asp:DropDownList>
                                    </div>
                                    <div class="col-6 ">
                                        <asp:Label ID="Label4" runat="server" Text="Precio:"></asp:Label>
                                        <asp:TextBox ID="txtPricenew" runat="server"></asp:TextBox>
                                        <asp:TextBox ID="txtstatenew" runat="server" Visible="false" Style="display: none"></asp:TextBox>
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
