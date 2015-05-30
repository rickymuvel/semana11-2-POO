Public Class frmPedidosCliente
    Dim modelo As New Negocios2015DataContext

    Private Sub frmPedidosCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lista = From c In modelo.clientes Select c

        cboClientes.DataSource = lista.ToList()
        cboClientes.DisplayMember = "nomCliente"
        cboClientes.ValueMember = "idCliente"
    End Sub

    Private Sub cboClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClientes.SelectedIndexChanged
        Try
            'Dim lista = From c In modelo.pedidoscabe
            'Where c.IdCliente = cboClientes.SelectedValue.ToString
            'Select c.IdPedido, c.FechaEntrega, c.Destinatario, c.PaiDestinatario

            Dim lista = From c In modelo.usp_PedidosCliente_LINQ(cboClientes.SelectedValue.ToString)


            dgPedidos.DataSource = lista.ToList()
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Catch ex As Exception

        End Try
    End Sub
End Class