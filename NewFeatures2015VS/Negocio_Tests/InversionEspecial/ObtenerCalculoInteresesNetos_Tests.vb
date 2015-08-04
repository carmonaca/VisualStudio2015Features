Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Negocio

<TestClass()> Public Class ObtenerCalculoInteresesNetos_Tests

    <TestMethod()> Public Sub ObtenerCalculoInteresesNetos_EscenarioRedondeo_DatosRedondeoHaciaDigitoMenor()

        Dim resultadoEsperado = 0.12
        Dim interesSimple As Decimal = 0.25
        Dim plazoInversion As Decimal = 0.15

        Dim resultadoObtenido As Decimal

        resultadoObtenido = CalculadorDeInteresInversion.ObtenerCalculoInteresesNetos(interesSimple, plazoInversion)

        Assert.AreEqual(resultadoEsperado, resultadoObtenido)

    End Sub

End Class