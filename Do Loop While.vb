    Sub Main()
        Dim a, b As Single 

        Do
            'Pulisce lo schermo
            Console.Clear()
            'L'underscore serve per andare a capo nel codice
            Console.WriteLine("Inserire le misure di base e altezza " &
                "di un rettangolo:")
            a = Console.ReadLine
            b = Console.ReadLine

            'Controlla che a e b non siano nulli. In quel caso, esce
            'dal ciclo. Se non ci fosse questo If in mezzo al codice,
            'verrebbe scritto a schermo il messaggio:
            ' "L'area del rettangolo è: 0"
            'cosa che noi vogliamo evitare. Se si usasse un'altra
            'variante di Do Loop, questo succederebbe sempre. Ecco
            'perchè, in questa situazione, è meglio
            'servirsi del semplice Do Loop


            Console.WriteLine("L'area del rettangolo è: " & (a * b))
            Console.ReadKey()
        Loop While a Or b = 0
        Console.WriteLine("0 è l'elemento assorbente")
    End Sub
