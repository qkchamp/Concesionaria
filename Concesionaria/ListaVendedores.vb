Public Class ListaVendedores

    Dim tabladatos_vendedores As New DataTable()

    Private Sub ListaVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Cambiar permisos a la DataGridView
        DGV_Vendedores.AllowUserToAddRows = False
        DGV_Vendedores.AllowUserToDeleteRows = False
        DGV_Vendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        'Añadir todas las columnas necesarias.
        tabladatos_vendedores.Columns.Add("ID Vendedor", GetType(Integer))
        tabladatos_vendedores.Columns.Add("Nombre del vendedor", GetType(String))
        tabladatos_vendedores.Columns.Add("Comision(%)", GetType(Decimal))
 
        For Each vendedores As Modulo.VENDEDORES In ArrayVendedores
            If vendedores.vendedor <> 0 Then
                tabladatos_vendedores.Rows.Add(vendedores.vendedor, vendedores.nombre, vendedores.comision)
            End If

        Next

        DGV_Vendedores.DataSource = tabladatos_vendedores

        Dim sinDatos As Boolean = (DGV_Vendedores.Rows.Count = 0)

        If sinDatos Then
            LSinVendedores.Visible = True
        Else
            LSinVendedores.Visible = False
        End If

    End Sub
End Class