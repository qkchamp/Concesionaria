Public Class NuevaFactura

    'Variable que contiene la fecha del sistema.
    Dim FechaSistema As DateTime = DateTime.Now


    Private Sub NuevaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Añadir los vendedores cargados en la matriz a la combobox.
        For Each Item As Modulo.VENDEDORES In ArrayVendedores
            If Item.vendedor <> 0 Then
                CBVendedor.Items.Add(Item.vendedor)
            End If
        Next

        'Boolean que comprueba si el ComboBox perteneciente a los vendedores está vacío.
        Dim VendedorComboBoxVacio As Boolean = (CBVendedor.Items.Count = 0)

        If VendedorComboBoxVacio Then
            CBVendedor.Enabled = False
        Else
            CBVendedor.Enabled = True
        End If

        'Establece la fecha del sistema a la TextBox a través de una variable.
        FechaBox.Text = FechaSistema

    End Sub

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click

        'Booleans para validar ciertos aspectos relacionados a la emisión de la factura.
        Dim VendedorOff As Boolean = (CBVendedor.Items.Count = 0)  'Si bien este boolean está definidio arriba se debee redefinir por temas de compilación.
        Dim CamposVacios As Boolean = (FacturaBox.Text = "" Or CBVendedor.SelectedItem = 0 Or ImporteBox.Text = "")
        Dim Existente As Boolean

        'Variable que almacenará la ganancia que obtuvo el vendedor.
        Dim CalcGanancia As Decimal


        'Si no existe ningun vendedor, se desencadenara un mensaje de error y se saldra de la ejecución del boton "Aceptar"
        If VendedorOff Then
            MsgBox("Error. Todavía no se ha cargado ningun vendedor.")
            Exit Sub
        End If

        'Si existe algun campo vacío, se desencadenara un mensaje de error y se saldra de la ejecución del boton "Aceptar"
        If CamposVacios Then
            MsgBox("Error. Se deben completar todos los campos.")
            Exit Sub
        End If

        'Bucle para recorrer la matriz y corroborar que no exista una factura con el mismo ID. En el caso de que exista sale del bucle para evitar recorrer toda
        'la matriz.
        For i As Integer = 0 To ArrayFacturas.Length - 1
            If CInt(FacturaBox.Text) = ArrayFacturas(i).factura Then
                Existente = True
                Exit For
            Else
                Existente = False
            End If
        Next

        'Bucle que sirve para encontrar la comisión correspondiente a ese vendedor y luego calcular la ganancia que le pertenece al mismo.
        For i As Integer = 0 To ArrayVendedores.Length - 1
            If ArrayVendedores(i).vendedor = CBVendedor.SelectedItem Then
                CalcGanancia = CDec(ImporteBox.Text) * ArrayVendedores(i).comision / 100
                Exit For
            End If
        Next

        'Bucle que recorre la matriz y guarda los datos en una parte de la matriz que se encuentre vacía.
        For i As Integer = 0 To ArrayFacturas.Length - 1
            If Not Existente Then
                If ArrayFacturas(i).Equals(New Modulo.FACTURAS()) Then
                    ArrayFacturas(i) = New Modulo.FACTURAS With {.factura = CInt(FacturaBox.Text), .fecha = FechaBox.Text, .vendedor = CInt(CBVendedor.SelectedItem), .importe = CDec(ImporteBox.Text), .ganancia = CalcGanancia}
                    MsgBox("Se han ingresado los datos correctamente y pueden ser visualizados en el apartado de ''Comisiones de Venta''")
                    FacturaBox.Text = ""
                    CBVendedor.SelectedItem = 0
                    ImporteBox.Text = ""
                    Exit For
                End If
            End If

            If Existente Then
                MsgBox("El nro de factura ya ha sido cargado anteriormente.")
                Exit Sub
            End If

        Next
    End Sub
End Class