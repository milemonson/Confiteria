<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EstadisticaporFecha.aspx.cs" Inherits="PasteleriaProyect.EstadisticaporFecha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <asp:ScriptManager runat="server" />
     <div class="padding-spaceStadisitic">
         <div class="form-box">
            <div id="printear">

    <asp:UpdatePanel runat="server">
        <ContentTemplate>
               <div class="d-flex flex-column-reverse">
                <div class="form-row d-flex justify-content-center mt-5">
                    <div class="d-flex justify-content-end">
          
                   </div>
                    <div class="form-group col-md-4">
                        <div>
                            <asp:Label ID="lblFechaEntrada" runat="server" Text="Fecha Desde:"></asp:Label>
                        </div>
                        <div class="d-flex justify-content-center">
                     <asp:TextBox ID="txtDateEntrada" runat="server" CssClass="form-control" name="" TextMode="Date"></asp:TextBox>
                        </div>

                    </div>
                    <div class="form-group col-md-4">
                        <div>
                            <asp:Label ID="lblFechaSalida" runat="server" Text="Fecha Hasta:"></asp:Label>
                        </div>
                        <div class="d-flex justify-content-center">
                     <asp:TextBox ID="txtDateSalida" runat="server" CssClass="form-control" name="" TextMode="Date"></asp:TextBox>
                        </div>

                    </div>

                </div>

            </div>

            <div class="modal-footer d-flex flex-row-reverse justify-content-center">

                <asp:Button ID="btnVentas" runat="server" Text="Ventas Realizadas" CssClass="btn btn-light" UseSubmitBehavior="False" Onclick="btnVentas_Click" />
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>
             
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:GridView ID="gvVxFecha" runat="server" Width="100%" AutoGenerateColumns="False" CssClass="table mt-5" CellPadding="4" ForeColor="#333333" GridLines="None">
                          <HeaderStyle BackColor="#DCDCDC" Font-Bold="True" ForeColor="black" />
                           <RowStyle BackColor="White" />
                        <Columns>
                             <asp:BoundField DataField="nameArticulo" HeaderText="Articulo" />
                             <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                             <asp:BoundField DataField="precio" HeaderText="Precio" />
                      </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
             
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <div>
                      <div class="d-flex justify-content-center">
                        <asp:Label Text="Total:" ID="lblTotal" CssClass="parrafo" runat="server" />
                    </div>
                    <div class="d-flex justify-content-center">
                        <asp:Label Text="" ID="lblTotalPorFechas" CssClass="parrafo" runat="server" />
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>

                <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="modal-footer d-flex flex-row-reverse justify-content-center">
                <asp:Button Text="Descargar Ticket" class="btn btn-dark" OnClientClick="printDiv('printear')" ID="btnDescargar" runat="server" />
             </div>
        </ContentTemplate>
    </asp:UpdatePanel>
                   </div>
             </div>
         </div>

</asp:Content>

