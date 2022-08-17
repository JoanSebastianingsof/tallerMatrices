Module Module1

    Sub Main()
        'Realizar un programa que genere una matriz 5x6 y se rellene dinámicamente con los números impares partiendo desde 1 y se imprima.
        Dim num As Integer = 1
        Dim matriz(5, 6) As Double
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1

                If num Mod 2 = 1 Then
                    matriz(i, j) = num
                Else
                    num = num + 1
                    matriz(i, j) = num



                End If
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
