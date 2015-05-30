Public Class frmClientes
    ' Instanciar el contexto del modelo
    Dim modelo As New Negocios2015DataContext
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lista = From c In modelo.clientes
                    Select c.IdCliente, c.NomCliente, c.DirCliente, c.fonoCliente

        dgClientes.DataSource = lista.ToList()
        dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
End Class