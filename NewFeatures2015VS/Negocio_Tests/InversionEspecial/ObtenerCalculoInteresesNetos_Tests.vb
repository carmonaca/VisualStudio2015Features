Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Negocio
Imports Model


<TestClass()> Public Class ObtenerCalculoInteresesNetos_Tests

    <TestMethod()> Public Sub ObtenerCalculoInteresesNetos_EscenarioRedondeo_DatosRedondeoHaciaDigitoMenor()

        Dim resultadoEsperado = 0.12
        Dim interesSimple As Decimal = 0.25
        Dim plazoInversion As Decimal = 0.18

        Dim resultadoObtenido As Decimal
        Dim elemento As New Estudiante 'With {.Descripcion = Nothing, .Id = 1, .Nombre = "Nombre"}
        elemento = Nothing
        Dim nombre = elemento?.Descripcion?.ToString()
        resultadoObtenido = CalculadorDeInteresInversion.ObtenerCalculoInteresesNetos(interesSimple, plazoInversion)
        Assert.AreEqual(resultadoEsperado, resultadoObtenido)

    End Sub

End Class