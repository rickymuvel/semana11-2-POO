<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidosAño
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboAño = New System.Windows.Forms.ComboBox()
        Me.dgPedidos = New System.Windows.Forms.DataGridView()
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CLIENTE"
        '
        'cboAño
        '
        Me.cboAño.FormattingEnabled = True
        Me.cboAño.Items.AddRange(New Object() {"1996", "1997", "1998", "2007", "2008", "2009", "2010", "2011"})
        Me.cboAño.Location = New System.Drawing.Point(97, 30)
        Me.cboAño.Name = "cboAño"
        Me.cboAño.Size = New System.Drawing.Size(140, 21)
        Me.cboAño.TabIndex = 2
        '
        'dgPedidos
        '
        Me.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPedidos.Location = New System.Drawing.Point(23, 83)
        Me.dgPedidos.Name = "dgPedidos"
        Me.dgPedidos.Size = New System.Drawing.Size(438, 172)
        Me.dgPedidos.TabIndex = 3
        '
        'frmPedidosAño
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 278)
        Me.Controls.Add(Me.dgPedidos)
        Me.Controls.Add(Me.cboAño)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPedidosAño"
        Me.Text = "CLIENTE"
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboAño As System.Windows.Forms.ComboBox
    Friend WithEvents dgPedidos As System.Windows.Forms.DataGridView
End Class
