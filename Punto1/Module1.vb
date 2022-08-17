Module Module1

    Sub Main()
        'Realizar un programa que genere una matriz 3x3, inicializarla en 0 e imprimirla.
        Dim num As Integer = 0

        Dim matriz(3, 3) As Double
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                matriz(i, j) = num
                num = num + 1
            Next

        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")

            Next
            Console.WriteLine()

        Next
    End Sub

End Module
