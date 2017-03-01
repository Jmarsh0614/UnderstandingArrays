Module Module1


    Sub Main()
        'Declare Integer Array with 5 spaces
        Dim numbers(0 To 4) As Integer
        'Or
        Dim Numbers1(4) As Integer 'Does same thing as (0 to 4)

        numbers(0) = 4
        numbers(1) = 8
        numbers(2) = 15
        numbers(3) = 17
        numbers(4) = 23

        'Or

        Dim Numerals() As Integer = {23, 34, 45, 34, 23}

        Console.WriteLine("The third element of the array contains: " & numbers(2)) '& is for concat (remember)

        Console.WriteLine("Iterating through the entire array:")
        For index = 0 To numbers.Length - 1 'array has 5 elements but index stops at for 

            Console.WriteLine(numbers(index))
        Next

        Dim names() As String = {"Eddie", "Alex", "Michael", "Dave", "Bob"}

        For Each name As String In names 'For each item in then names array take one item and create variable name and use in iteration
            Console.WriteLine(name)
        Next

        'use "& _" to do a line continuation for long strings

        Dim myText As String = "You can get what you want out of life " &
            "if you help enough other people get what they want."
        Console.WriteLine(myText)

        'This creates an Char array from the myText String by breaking it into characters
        'and places them into an array

        Dim charArray() As Char = myText.ToCharArray()

        'This reverses the Char Array
        Array.Reverse(charArray)

        'For each individual char inside of our char array, we will loop through it
        'Inside the body of our for each and write characture to the current line
        For Each myChar As Char In charArray
            Console.Write(myChar)
        Next

        Console.ReadLine()




    End Sub

End Module
