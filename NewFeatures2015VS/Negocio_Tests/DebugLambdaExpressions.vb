Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class DebugLambdaExpressions

    <TestMethod()> Public Sub DebugLambdaExpressions_True()

        Dim elementos As List(Of Integer) = {10, 20, 31, 40}.ToList()


        Dim filtroItems = elementos.Where(Function(i) i > 30)

        Dim inversionesSinElementos = filtroItems.ToList()


    End Sub

End Class