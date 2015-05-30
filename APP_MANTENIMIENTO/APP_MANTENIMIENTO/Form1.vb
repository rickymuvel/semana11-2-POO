Public Class Form1
    'Instanciar la clase AccesoDatos
    Dim modelo As New Negocios2015DataContext

    Sub PaisListar()
        cboPais.DataSource = modelo.usp_PaisListar
        cboPais.DisplayMember = "NombrePais"
        cboPais.ValueMember = "IdPais"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PaisListar()
        dgClientes.DataSource = modelo.usp_ClienteListado
        dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub dgClientes_SelectionChanged(sender As Object, e As EventArgs) Handles dgClientes.SelectionChanged
        txtCodigo.Text = dgClientes.Rows(dgClientes.CurrentRow.Index).Cells(0).Value()
        txtCliente.Text = dgClientes.Rows(dgClientes.CurrentRow.Index).Cells(1).Value()
        txtDireccion.Text = dgClientes.Rows(dgClientes.CurrentRow.Index).Cells(2).Value()
        cboPais.Text = dgClientes.Rows(dgClientes.CurrentRow.Index).Cells(3).Value()
        txtTelefono.Text = dgClientes.Rows(dgClientes.CurrentRow.Index).Cells(4).Value()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        For Each objeto As Object In Me.Controls
            If TypeOf objeto Is TextBox Then objeto.Text = String.Empty
        Next
        cboPais.SelectedIndex = -1
        txtCodigo.Focus()
    End Sub

    'Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
    '    Try
    '        obj.ClienteInsertar(txtCodigo.Text.ToUpper, txtCliente.Text,
    '                             txtDireccion.Text.ToUpper, cboPais.SelectedValue.ToString,
    '                             txtTelefono.Text)
    '        dgClientes.DataSource = obj.ClienteListar.Tables(0)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message + "ERROR....")
    '    End Try
    'End Sub

    'Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
    '    Try
    '        obj.ClienteActualizar(txtCodigo.Text.ToUpper, txtCliente.Text,
    '                             txtDireccion.Text.ToUpper, cboPais.SelectedValue.ToString,
    '                             txtTelefono.Text)
    '        dgClientes.DataSource = obj.ClienteListar.Tables(0)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message + "ERROR....")
    '    End Try
    'End Sub

    'Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
    '    Try
    '        obj.ClienteBaja(txtCodigo.Text.ToUpper)
    '        dgClientes.DataSource = obj.ClienteListar.Tables(0)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message + "ERROR....")
    '    End Try
    'End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Form2.Show()
        'Me.Hide()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim objCliente As New clientes
        objCliente.IdCliente = txtCodigo.Text
        objCliente.NomCliente = txtCliente.Text
        objCliente.DirCliente = txtDireccion.Text
        objCliente.idpais = cboPais.SelectedValue.ToString
        objCliente.fonoCliente = txtTelefono.Text
        objCliente.Activo = True

        Try
            modelo.clientes.InsertOnSubmit(objCliente)
            modelo.SubmitChanges()
            dgClientes.DataSource = modelo.usp_ClienteListado
            dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            MessageBox.Show("Cliente registrado", "AVISO")
        Catch ex As Exception
            MessageBox.Show("Error en la transacción, verificar", "AVISO")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim cliente = From cli In modelo.clientes Where cli.IdCliente = txtCodigo.Text

        Dim objCliente As New clientes
        objCliente = cliente.First
        objCliente.IdCliente = txtCodigo.Text
        objCliente.NomCliente = txtCliente.Text
        objCliente.DirCliente = txtDireccion.Text
        objCliente.idpais = cboPais.SelectedValue.ToString
        objCliente.fonoCliente = txtTelefono.Text
        objCliente.Activo = True

        Try
            modelo.SubmitChanges()
            dgClientes.DataSource = modelo.usp_ClienteListado
            dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            MessageBox.Show("Cliente actualizado", "AVISO")
        Catch ex As Exception
            MessageBox.Show("Error en la transacción, verificar", "AVISO")
        End Try
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click

    End Sub
End Class
