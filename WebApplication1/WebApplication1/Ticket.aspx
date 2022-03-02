<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ticket.aspx.cs" Inherits="PasteleriaProyect.Ticket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
      <asp:ScriptManager ID="ScriptManager1" runat="server" />
  <div id="printear">
      <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
              <div id="generarFactura" runat="server" class="padding-space">
     <div class="form-box" runat="server">
        <div class="form-row d-flex justify-content-center mt-5">
            <div class="form-group col-md-4">
                 <div class="d-flex justify-content-between">
                <p>Numero de Ticket: &nbsp;  </p>
                <asp:Label ID="lblIdTicket" runat="server" Text=""></asp:Label>
            </div>
                <div class="d-flex justify-content-center">
                    <asp:Label ID="lblFechaEmision" runat="server" Text="Fecha de Emision"></asp:Label>
                </div>
                <div class="d-flex justify-content-center">
                     <asp:TextBox ID="txtDate" runat="server" CssClass="form-control" name="" TextMode="Date"></asp:TextBox>
                    </div>
            </div>
        </div>
        <div class="form-row d-flex justify-content-center mt-5" id="formvalid">
            <div class="form-group col-md-4 ml-1">
                <asp:Label ID="lblLocal" runat="server" Text="Local"></asp:Label>
                <asp:DropDownList ID="dropLocal" runat="server" CssClass="form-control" >
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-row d-flex justify-content-center mt-5" id="formvalid1">
            <div class="form-group col-md-4 ml-1">
                <asp:Label ID="lblMozo" runat="server" Text="Mozo"></asp:Label>
                <asp:DropDownList ID="dropMozo" runat="server" CssClass="form-control" >
                </asp:DropDownList>
            </div>
        </div>
        </div>
         </div>
            </ContentTemplate>
    </asp:UpdatePanel>
   
    
       <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
             <div id="generarDetalle" runat="server" class="padding-space">
               <div class="form-box" runat="server">
    <div class="d-flex justify-content-center">
        <h1 class="titulo">Agregue articulos a su Venta</h1>
    </div>
         
            <asp:TextBox ID="txtIdTicket" runat="server" CssClass="form-control" name="idTicket" Visible="true" Style="display: none"></asp:TextBox>
            <div class="form-row d-flex justify-content-center mt-5">
                <div class="form-group col-md-4 ml-1">
                    <asp:Label ID="lblArticulo" runat="server" Text="Articulo"></asp:Label>
                    <asp:DropDownList ID="dropArticulo" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="d-flex flex-column-reverse">
                <div class="form-row d-flex justify-content-center mt-5">
                    <div class="d-flex justify-content-end">
          
                   </div>
                    <div class="form-group col-md-4">
                        <div>
                            <asp:Label ID="lblCantidad" runat="server" Text="Cantidad:"></asp:Label>
                        </div>
                        <div class="d-flex justify-content-center">
                            <asp:TextBox ID="txtQuantity" runat="server" CssClass="form-control" name="cantidad"></asp:TextBox>
                        </div>

                    </div>
                    <div class="form-group col-md-4">
                        <div>
                            <asp:Label ID="LblPrecio" runat="server" Text="Precio:"></asp:Label>
                        </div>
                        <div class="d-flex justify-content-center">
                            <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" name="Precio"></asp:TextBox>
                        </div>

                    </div>

                </div>

            </div>


            <div class="modal-footer d-flex flex-row-reverse justify-content-center">
                <asp:Button  ID="btnCancelar" runat="server" type="button" class="btn btn-secondary" Text="Cancelar" OnClick="btnCancelar_Click"/>
                <asp:Button ID="btnArticulo" runat="server" Text="Agregar Articulo" CssClass="btn btn-light" UseSubmitBehavior="False" OnClick="btnArticulo_Click" />
            </div>
      </div>
                   </div>
              </ContentTemplate>
    </asp:UpdatePanel>
      
    <asp:UpdatePanel ID="Upadate1" runat="server">
        <ContentTemplate>
 <div class="padding-spacegrillas">
            <asp:GridView ID="gvTicket" runat="server" AutoGenerateColumns="False" CssClass="table mt-5" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None">
                <HeaderStyle BackColor="#DCDCDC" Font-Bold="True" ForeColor="black" />
                <RowStyle BackColor="White" />
                <Columns>  
                     <asp:BoundField DataField="idTicket" HeaderText="ID" />
                    <asp:BoundField DataField="articulo" HeaderText="Articulo" />
                       <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                        <asp:BoundField DataField="precio" HeaderText="Precio" />
                </Columns>
            </asp:GridView>
   </div>
        </ContentTemplate>
    </asp:UpdatePanel>

           <asp:UpdatePanel runat="server">
                <ContentTemplate>
                     <div class="padding-space">
                    <div class="d-flex justify-content-center">
                        <div>
                            <p class="parrafo">Total: &nbsp; </p>
                        </div>
                        <div class="d-flex justify-content-center">
                            <asp:Label Text="Total" runat="server" CssClass="parrafo" ID="lblTotal" />
                        </div>
                    </div>
                    </div>
                 
                </ContentTemplate>
            </asp:UpdatePanel>
         </div>
             

         <asp:UpdatePanel runat="server">
                <ContentTemplate>
                     <div class="padding-space">
      <div class="d-flex justify-content-center pl-4">
            <asp:Button ID="btnGenerarFac" runat="server" type="button" Text="Cargar Ticket" CssClass="btn btn-light" OnClick="GenerarFac_Click" />
               </div>
                         </div>
                    </ContentTemplate>
            </asp:UpdatePanel>
     
          <asp:UpdatePanel runat="server">
        <ContentTemplate>
             <div class="padding-space">
            <div class="modal-footer d-flex flex-row-reverse justify-content-center">
                <asp:Button Text="Descargar" class="btn btn-dark" ID="btnGenerarPdf" runat="server" OnClientClick="printDiv('printear')" />
            </div>
                 </div>
        </ContentTemplate>
    </asp:UpdatePanel>
   
    </asp:Content>