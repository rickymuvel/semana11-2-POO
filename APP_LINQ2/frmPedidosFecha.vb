Public Class frmPedidosFecha
    Dim modelo As New Negocios2015DataContext

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        dgPedidos.DataSource = modelo.usp_PedidosFecha_LINQ( _
            dtIniciar.Value.Date, dtFinal.Value.Date)
    End Sub
End Class