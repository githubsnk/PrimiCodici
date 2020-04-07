    Sub main()
        Dim a, b, c As Single

        Console.WriteLine("equazione ax<sup>2</sup> + bx + c = 0")
        Console.WriteLine("inserisci, in ordine, a, b e c:")
        a = Console.ReadLine
        b = Console.ReadLine
        c = Console.ReadLine

        If a = 0 Then
            Console.WriteLine("l'equazione si abbassa di grado")
            Console.ReadKey()
            Exit Sub
        End If

        Dim delta As Single = b ^ 2 - 4 * a * c

        If delta > 0 Then
            Dim x1, x2 As Single
            x1 = (-b + Math.Sqrt(delta)) / (2 * a)
            x2 = (-b - Math.Sqrt(delta)) / (2 * a)
            Console.WriteLine("soluzioni:")
            Console.WriteLine("x1 = " & x1)
            Console.WriteLine("x2 = " & x2)
        ElseIf delta = 0 Then
            Dim x As Single
            x = -b / (2 * a)
            Console.WriteLine("soluzione doppia: ")
            Console.WriteLine("x= " & x)
        Else
            Console.WriteLine("non esistono soluzioni in r")

        End If
        Console.ReadKey()
    End Sub
