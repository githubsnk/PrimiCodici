    Sub main()
        Dim voto As Single
        Console.WriteLine("inserisci il tuo voto:")
        voto = Console.ReadLine()
        If voto < 3 Then
            Console.WriteLine("sei senza speranze!")
        ElseIf voto < 5 Then
            Console.WriteLine("ancora un piccolo sforzo...")
        ElseIf voto < 7 Then
            Console.WriteLine("stai andando discretamente")
        ElseIf voto < 9 Then
            Console.WriteLine("molto bene, continua così")
        Else
            Console.WriteLine("sei praticamente perfetto")
        End If
        Console.ReadKey()
    End Sub
   
