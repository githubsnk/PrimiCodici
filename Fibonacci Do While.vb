    Sub Main()
        Dim a, b, c As Int32
        Dim n As Int32

        Console.WriteLine("-- Successione di Fibonacci --")
        Console.WriteLine("Inserire un numero oltre il quale terminare:")
        n = Console.ReadLine

        If n = 0 Then
            Console.WriteLine("Nessun numero della successione")
            Console.ReadKey()
            Exit Sub
        End If

        a = 1
        b = 1
        Console.WriteLine(a)
        Console.WriteLine(b)
        Do While c < n
            c = a + b
            b = a
            a = c
            Console.WriteLine(c)
        Loop

        Console.ReadKey()
    End Sub
