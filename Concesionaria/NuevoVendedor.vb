Public Class NuevoVendedor

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click

        'Booleans que se utilizaran para validar campos.
        Dim Existente As Boolean
        Dim Vacio As Boolean = (VendedorBox.Text = "" Or NombreBox.Text = "" Or ComisionBox.Text = "")
        Dim NombreExistente As Boolean

        If Vacio Then
            MsgBox("Error. Todos los campos deben contener información")
            Exit Sub
        End If

        'Boolean que servirá para validar si el valor ingresado es válido.
        Dim Comision_Erronea As Boolean = (CInt(ComisionBox.Text) > 80)

        If Comision_Erronea Then
            MsgBox("Error. No se puede ingresar una comisión mayor al 80%.")
            Exit Sub
        End If

        'Bucle para validar que los valores ingresados en los campos "VendedorBox" y "NombreBox".
        For i As Integer = 0 To ArrayVendedores.Length - 1

            If CInt(VendedorBox.Text) = ArrayVendedores(i).vendedor Then
                Existente = True
                Exit For
            Else
                Existente = False
            End If
            'MsgBox(ArrayVendedores(i).nombre)
            If Not ArrayVendedores(i).nombre Is Nothing Then
                If NombreBox.Text.ToUpper.Replace(" ", "").Contains(ArrayVendedores(i).nombre.Replace(" ", "")) Then
                    NombreExistente = True
                    Exit For
                Else
                    NombreExistente = False
                End If
            End If
        Next

        'Si existe ese nombre en la matriz, se desencadenara un error y se saldra del procedimiento 'Aceptar'
        If NombreExistente Then
            MsgBox("Error. Ya existe un vendedor con ese nombre.")
            Exit Sub
        End If

        'Si se comprueba que no existe ese vendedor, se guarda en algun lugar vacío de la matriz.
        If Not Existente Then
            For i As Integer = 0 To ArrayVendedores.Length - 1
                If ArrayVendedores(i).Equals(New Modulo.VENDEDORES()) Then
                    ArrayVendedores(i) = New Modulo.VENDEDORES With {.vendedor = CInt(VendedorBox.Text), .nombre = NombreBox.Text.ToUpper, .comision = CDec(ComisionBox.Text)}
                    MsgBox("Se han ingresado los datos correctamente.")
                    VendedorBox.Text = ""
                    NombreBox.Text = ""
                    ComisionBox.Text = ""
                    Exit For
                End If
            Next
        End If

        If Existente Then
            MsgBox("El numero de vendedor ya existe.")
        End If

    End Sub

    Private Sub VendedorBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VendedorBox.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub NombreBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreBox.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComisionBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComisionBox.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLista.Click
        ListaVendedores.Show()
    End Sub
End Class