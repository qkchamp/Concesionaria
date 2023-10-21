Public Class ComisionesVenta

    'Se instancia la DataTable en la cual se volcaran todos los datos que luego seran ingresados a la DataGridView.
    Dim tablaDatos As New DataTable()
 
    Private Sub ComisionesVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Cambiar permisos a la DataGridView
        DGV_Comisiones.AllowUserToAddRows = False
        DGV_Comisiones.AllowUserToDeleteRows = False
        DGV_Comisiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        'Añadir todas las columnas necesarias.
        tablaDatos.Columns.Add("Nombre del Vendedor", GetType(String))
        tablaDatos.Columns.Add("Total del Importe($)", GetType(Decimal))
        tablaDatos.Columns.Add("Comisión (%)", GetType(Decimal))
        tablaDatos.Columns.Add("Ganancia ($)", GetType(Decimal))
        tablaDatos.Columns.Add("Numero de Factura", GetType(Integer))

        ' "For Each" anidados para trabajar con ambas matrices.
        For Each facturas As Modulo.FACTURAS In ArrayFacturas
            For Each vendedores As Modulo.VENDEDORES In ArrayVendedores
                If facturas.vendedor = vendedores.vendedor And facturas.vendedor <> 0 Then
                    tablaDatos.Rows.Add(vendedores.nombre, facturas.importe, vendedores.comision, facturas.ganancia, facturas.factura)
                End If
            Next
        Next


        'Se cargan los datos de la DataTable a la DataGridView (Estableciendo como su fuente de datos "tablaDatos").
        DGV_Comisiones.DataSource = tablaDatos

        'Boolean que comprueba si existen filas en la DataGridView. Si existen filas podemos deducir que existen datos cargados.
        Dim SinDatos As Boolean = (DGV_Comisiones.Rows.Count = 0)

        If SinDatos Then
            LSinDatos.Visible = True
        Else
            LSinDatos.Visible = False
        End If

    End Sub
End Class


'Backup
'

