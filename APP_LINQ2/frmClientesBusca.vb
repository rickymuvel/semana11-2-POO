Public Class frmClientesBusca
    Dim modelo As New Negocios2015DataContext

    Sub consultaCliente(nomcli As String)
        Dim lista = From c In modelo.clientes
                    Where c.NomCliente.StartsWith(nomcli)
                    Select c.IdCliente, c.NomCliente, c.DirCliente, c.fonoCliente

        dgClientes.DataSource = lista.ToList()
        dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        consultaCliente(txtNombre.Text.Trim)
    End Sub

    Private Sub frmClientesBusca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaCliente(String.Empty)
    End Sub
End Class