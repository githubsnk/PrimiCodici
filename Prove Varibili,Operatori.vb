 Sub Main(Prova Utilizzo Operatori, Variabili)
        Dim intero, ese As Int16
        Dim decimale As Single
        Dim vero As Boolean
        Dim frase As String

        intero = 90
        ese = intero * 2 / 68 ' = ‭2,6470588235294117647058823529412‬
        intero = ese - intero * intero ' = -8097,3529411764705882352941176471‬
        decimale = 90.76
        decimale = ese / intero ' = -0,00032690421706440013076168682576005‬
        vero = True
        frase = "ciao"
        frase = "Buon giorno" + "ciao"
        frase = "il valore decimale è: " & decimale
        Console.WriteLine(frase) '= -0,0003705076
        Console.ReadKey()
    End Sub
