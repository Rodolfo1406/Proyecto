Public Class Ingreso

    Public Password As String = "123"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Dim Nombre As String
        Dim Contraseña As String

        Nombre = txtNombredeUsuario.Text
        Contraseña = txtContrasena.Text

        If (Contraseña = Password) Then
            MessageBox.Show("Bienvenido " & Nombre)

            Menu_Principal.Show()
            Me.Hide()
        End If


    End Sub
End Class
