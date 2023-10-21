Module Modulo

    Public Const LV = 10  'Max. cant. Vendedores
    Public Const LF = 100 'Max. cant. Facturas


    Public Structure VENDEDORES
        Public vendedor As Integer
        Public nombre As String
        Public comision As Decimal
    End Structure

    Public Structure FACTURAS
        Public factura As Integer
        Public fecha As Date
        Public vendedor As Integer
        Public importe As Decimal
        Public ganancia As Decimal
    End Structure

    'Arrays con su estructura correspondiente.
    Public ArrayVendedores(LV) As VENDEDORES
    Public ArrayFacturas(LF) As FACTURAS

End Module
