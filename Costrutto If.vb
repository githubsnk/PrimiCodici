    Sub main()
        Dim lato As Single
        Console.WriteLine("inserire il lato di un quadrato:")
        lato = Console.ReadLine
        If lato < 0 Then
            Console.WriteLine("Il lato non può avere una misura negativa")
        Else
            Console.WriteLine("l'area del quadrato è: " & lato * lato & "Mt")
        End If
        Console.ReadKey()
    End Sub
