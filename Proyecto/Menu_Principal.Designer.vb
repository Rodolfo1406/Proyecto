<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Principal
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.bntVer = New System.Windows.Forms.Button()
        Me.bntSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(17, 30)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 64)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(181, 30)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(109, 64)
        Me.btnCrear.TabIndex = 1
        Me.btnCrear.Text = "Crear "
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'bntVer
        '
        Me.bntVer.Location = New System.Drawing.Point(17, 113)
        Me.bntVer.Name = "bntVer"
        Me.bntVer.Size = New System.Drawing.Size(112, 64)
        Me.bntVer.TabIndex = 2
        Me.bntVer.Text = "Ver"
        Me.bntVer.UseVisualStyleBackColor = True
        '
        'bntSalir
        '
        Me.bntSalir.Location = New System.Drawing.Point(181, 113)
        Me.bntSalir.Name = "bntSalir"
        Me.bntSalir.Size = New System.Drawing.Size(109, 64)
        Me.bntSalir.TabIndex = 3
        Me.bntSalir.Text = "Salir"
        Me.bntSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.bntSalir)
        Me.GroupBox1.Controls.Add(Me.bntVer)
        Me.GroupBox1.Controls.Add(Me.btnCrear)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 198)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu de identificación:"
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Menu_Principal"
        Me.Text = "Menu_Principal"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents bntVer As Button
    Friend WithEvents bntSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
