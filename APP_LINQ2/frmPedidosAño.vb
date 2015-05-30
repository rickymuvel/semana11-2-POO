Public Class frmPedidosAño
    Dim modelo As New Negocios2015DataContext

    Private Sub cboAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAño.SelectedIndexChanged
        Try
            Dim lista = From c In modelo.usp_PedidosAño_LINQ(Integer.Parse(cboAño.Text))

            dgPedidos.DataSource = lista.ToList()
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Catch ex As Exception

        End Try
    End Sub
End Class