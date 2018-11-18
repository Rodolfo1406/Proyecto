Public Class Busqueda
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click



    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnMenuBusqueda_Click(sender As Object, e As EventArgs) Handles btnMenuBusqueda.Click

        Menu_Principal.Show()
        Me.Hide()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Edicion_de_Usuario.Show()
        Me.Hide()

    End Sub
End Class