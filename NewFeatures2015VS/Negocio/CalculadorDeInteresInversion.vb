Public Module CalculadorDeInteresInversion
    Public Function ObtenerCalculoInteresesNetos(interesSimple As Decimal, plazoInversion As Decimal) As Decimal


        Dim intresNeto As Decimal = interesSimple * plazoInversion
        Return intresNeto

    End Function
End Module
