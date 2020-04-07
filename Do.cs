    Sub Main()
        Dim a As Int32 = 0

        Do
            a += 1
        Loop While (a < 2) And (a > 0)
        Console.WriteLine(a)

        Console.ReadKey()
    End Sub
