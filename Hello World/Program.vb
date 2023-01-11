Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Type a word plz")
        Dim message As String = ""
        message = Console.ReadLine()
        Console.WriteLine($"You Said: {message}?")
        Console.WriteLine("Is that right?")
        Dim UsrConfirm = Console.ReadLine()
        If (UsrConfirm = "yes") Then
            Console.WriteLine("Awesome lol!")
        Else
            Console.WriteLine("Too Bad lol!")
        End If
    End Sub
End Module
