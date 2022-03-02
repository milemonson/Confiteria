<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Estadistica.aspx.cs" Inherits="PasteleriaProyect.Estadistica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
   <asp:ScriptManager runat="server" />
     <div class="padding-spaceStadisitic">
         <div class="form-box">
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
   
            <div class="d-flex justify-content-center">
                <div class="form-group col-md-4 ">
                    <div class="d-flex justify-content-center">
                        <asp:Label ID="lblFecha" runat="server" Text="Fecha"></asp:Label>
                    </div>
                    <div class="d-flex justify-content-center">
                        <asp:Calendar ID="dtpFechaVxDia" runat="server" SelectedDate=""></asp:Calendar>
                    </div>

                </div>
            </div>

            <div class="modal-footer d-flex flex-row-reverse justify-content-center">

                <asp:Button ID="btnVentasPorDia" runat="server" Text="Ventas del Dia" CssClass="btn btn-light" UseSubmitBehavior="False" Onclick="btnVentasPorDia_Click" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

           
      <div id="printear2">
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <div class="d-flex justify-content-center">

                    <asp:Label Text="Informe de ventas del Dia:" CssClass="parrafo" ID="lblInforme" runat="server" />
                </div>
                <div class="d-flex justify-content-center">

                    <asp:Label Text="" ID="lblFechaxV" runat="server" CssClass="parrafo" />
                </div>

            </ContentTemplate>
        </asp:UpdatePanel>

            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:GridView ID="gvVxDia" runat="server" Width="100%" AutoGenerateColumns="False" CssClass="table mt-5" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                        <asp:Label Text="Total:" ID="lblTotalPorDia" CssClass="parrafo" runat="server" />
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
          
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="d-flex justify-content-center">
                <div class="form-group col-md-4 ">
                    <div class="d-flex justify-content-center">
                        <asp:Label ID="Label1" runat="server" Text="Fecha"></asp:Label>
                    </div>
                    <div class="d-flex justify-content-center">
                        <asp:Calendar ID="dtpFechaVxMozo" runat="server" SelectedDate=""></asp:Calendar>
                    </div>

                </div>
            </div>

            <div class="modal-footer d-flex flex-row-reverse justify-content-center">

                <asp:Button ID="btnVentasPorMozo" runat="server" Text="Ver Ventas Por Mozo" CssClass="btn btn-light" UseSubmitBehavior="False" OnClick="btnVentasPorMozo_Click" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
 
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <div class="d-flex justify-content-center">

                    <asp:Label Text="Informe de ventas por Mozo del Dia:" runat="server" CssClass="parrafo" ID="lblVentasPorMozo" />
                </div>
                <div class="d-flex justify-content-center">

                    <asp:Label Text="" ID="lblfechamozo" runat="server" CssClass="parrafo" />
                </div>

            </ContentTemplate>
        </asp:UpdatePanel>
        
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:GridView ID="gvVxM" runat="server" Width="100%" AutoGenerateColumns="False" CssClass="table mt-5" CellPadding="4" ForeColor="#333333" GridLines="None">
                          <HeaderStyle BackColor="#DCDCDC" Font-Bold="True" ForeColor="black" />
                           <RowStyle BackColor="White" />

                        <Columns>

                            <asp:BoundField DataField="Mozo" HeaderText="Mozo" />
                            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                            <asp:BoundField DataField="Total" HeaderText="Total" />
                            <asp:BoundField DataField="Comision" HeaderText="Comision" />
                            <asp:BoundField DataField="Pago" HeaderText="A Pagar" />

                        </Columns>
                          </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
                 <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <div>
                      <div class="d-flex justify-content-center">
                        <asp:Label Text="Total:" ID="Label3" CssClass="parrafo" runat="server" />
                    </div>
                    <div class="d-flex justify-content-center">
                        <asp:Label Text="" ID="lblTotalaPagar" CssClass="parrafo" runat="server" />
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>

                    </div>

              <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="modal-footer d-flex flex-row-reverse justify-content-center">
                <asp:Button Text="Descargar Ticket" class="btn btn-dark" OnClientClick="printDiv('printear2')" ID="btnDescargar" runat="server" />
             </div>
        </ContentTemplate>
    </asp:UpdatePanel>

              </div>
        </div>
    </asp:Content>