Imports Model

Module PropiedadesNullables


    Sub Main()


        Dim estudiante As Estudiante
        estudiante = Nothing

        estudiante = New Estudiante With {.Id = 1,
                                         .CentroEducativo = New CentroEducativo _
                                                      With {.CantidadEstudiantes = 100,
                                                      .Nombre = "Centro Educativo A",
                                                      .Mensualidad = 1000000
                                                             }}

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

        'Dim mensaje As String

        'mensaje = String.Format("El estudiante con id {0} asiste al centro educativo
        '                          {1} y su mensualidad es de {2:####.##} ", estudiante.Id,
        '                        estudiante.CentroEducativo.Nombre, estudiante.CentroEducativo.Mensualidad)

        'Console.WriteLine(String.Format("Mensaje LARGO {0}", mensaje))

        'mensaje = $"El estudiante con id {estudiante.Id} asiste al centro educativo
        '                          {estudiante.CentroEducativo.Nombre} y su mensualidad 
        '                          es de {estudiante.CentroEducativo.Mensualidad:####.##}"

        'Console.WriteLine($"Mensaje CORTO {mensaje}")

        'Console.Read()




























    End Sub

End Module
