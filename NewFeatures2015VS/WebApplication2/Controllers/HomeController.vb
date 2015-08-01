Imports Microsoft.AspNet.Identity
Imports Microsoft.CodeDom.Providers
Imports System.Collections
Imports Negocio

Public Class HomeController
    Inherits Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function



    Function AgregueElemento(item As Inversion)
        Dim elemento As New AdministradorInversiones
        elemento.AgregueInversionConValidaciones(item)

        Dim datoGuadar As ICollection(Of Inversion)

        Dim nuevo As inversionEspecialNueva

        'Dim administradorTransacciones As New AdministradorTransacciones
        'administradorTransacciones.GenereNuevaTransaccion()

        Return View()
    End Function

End Class
