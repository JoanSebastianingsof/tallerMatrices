Module Module1

    Sub Main()
        'Realizar un programa que genere una matriz 6x6, inicializarla la diagonal principal en 0, el resto de posiciones deben ser *. Imprimir la matriz.
        Dim num As Char = ""

        Dim filas As Integer
        Dim columnas As Integer
        Dim matriz(6, 6) As Char
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                If i = j Then
                    num = "0"
                    matriz(i, j) = num
                Else
                    num = "*"
                    matriz(i, j) = num
                End If
                num = num
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
