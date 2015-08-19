Imports Model

Module PropiedadesNullables


    Sub Main()


        Dim estudiante As Estudiante
        estudiante = Nothing

        estudiante = New Estudiante With {.Id = 1,
                                         .CentroEducativo = New CentroEducativo _
                                                      With {.CantidadEstudiantes = 100}}

        'estudiante.CentroEducativo = Nothing
        '


        If estudiante IsNot Nothing AndAlso estudiante.CentroEducativo IsNot Nothing AndAlso
                              estudiante.CentroEducativo.CantidadEstudiantes >= 100 Then
            Console.WriteLine("Validación LARGA cantidad estudiantes")
        End If

        If estudiante?.CentroEducativo?.CantidadEstudiantes >= 100 Then
            Console.WriteLine("Validación CORTA cantidad estudiantes")
        End If

        Console.Read()
        'If estudiante IsNot Nothing AndAlso estudiante.Id >= 100 Then
        '    Console.WriteLine("Validación larga")
        'End If


        'If estudiante?.Id >= 100 Then
        '    Console.WriteLine("Validación corta")
        'End If





























    End Sub

End Module
