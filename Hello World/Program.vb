'Joshua Makuch
'RCET0265
'Spring 2023
'First Assignment Turn In
'https://github.com/JoshuaMakuch/Hello-World.git
'##############################################################################

Imports System

Module Program
    Sub Main(args As String())
        'You need to have a main as this is the starting point
        Console.WriteLine("Type a word plz")
        Dim message As String = ""
        message = Console.ReadLine()
        Console.WriteLine($"You Said: {message}?")
        Console.WriteLine("Is that right? Type yes or no.")
        Dim UsrConfirm = Console.ReadLine()
        UsrConfirm = UsrConfirm.ToLower()
        If (UsrConfirm = "yes") Then
            Console.WriteLine("Awesome lol!")
            Console.Beep(2000, 1000)
        Else
            Console.WriteLine("Too Bad lol!")
            Console.Beep(200, 1000)
        End If
    End Sub
End Module
