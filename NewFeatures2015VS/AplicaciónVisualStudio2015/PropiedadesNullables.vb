Imports Model

Module PropiedadesNullables


    Sub Main()


        Dim estudiante As Estudiante
        estudiante = Nothing

        'estudiante = as new Estudiante
        'estudiante.CentroEducativo = Nothing

        If String.IsNullOrEmpty(estudiante.Nombre) Then
            Console.WriteLine("Nombre de estudiante sin contenido")
            Console.ReadLine()
        End If


























    End Sub

End Module
