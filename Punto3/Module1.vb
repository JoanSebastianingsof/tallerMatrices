Module Module1

    Sub Main()
        '.Realizar un programa que genere un arreglo de 15 posiciones y se rellene de forma dinámica (no deben ser asignados los valores sino utilizar un bucle para llenar el arreglo) con los números empezando desde 1, luego imprimir.
        Dim num As Integer = 1
        Dim arreglo(15) As Integer

        For i = 0 To 14 Step 1
            arreglo(i) = num
            num += 1


        Next
        For i = 0 To 14 Step 1
            'Variable iteradora indica la posicion del valor
            Console.WriteLine(arreglo(i))
        Next

    End Sub

End Module
