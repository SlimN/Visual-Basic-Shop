'Steven Nim
'December 17, 2014 - January 2015
'A "cafeteria" style program created for the ICS2O final summative. Except we sell weapons. Not Food.

Public Class frmTitle
    Dim phrase As String
    Public inFile
    Public outFile
    Dim creditYesNo As String
    Public userName As String
    Public userCard As String
    Private Sub frmTitle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Start that music!
        My.Computer.Audio.Play("ShopChannel.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        'Clicking "Enter" will open up the main shop to the user.
        frmShop.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Clicking "Exit" will close the title form.
        Me.Close()
    End Sub
    Private Sub btnCreditRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreditRegister.Click
        'Users can register their credit card here.
        creditYesNo = MessageBox.Show("Would you like to register a credit card?", "Credit Card Register", MessageBoxButtons.YesNo)
        If creditYesNo = vbYes Then
            'Ask the user for their name and credit card number.
            userName = InputBox("Please enter your name.", "Enter Name")
            userCard = InputBox("Please enter your credit card numbers (e.g 1111-1111-1111-1111)", "Enter Card Number")
            'If the user puts in nothing then deny access.
            If userName = Nothing Or userCard = Nothing Then
                MessageBox.Show("Card Register failed because you have not entered enough information.", "FAIL")
            Else
                'Write in the user's credit card stuff.
                outFile = New System.IO.StreamWriter("CARDS.txt")
                outFile.WriteLine(userName)
                outFile.WriteLine(userCard)
                outFile.close()
                MessageBox.Show("Success! Your card has been registered, " & userName & ".", "SUCCESS")
            End If
        Else
            MessageBox.Show("Credit Card registration cancelled.", "CANCELLED")
        End If
    End Sub
    Private Sub btnMoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoney.Click
        'Open up the Fwump Machine and hide the title form.
        frmFwump.Show()
        Me.Hide()
    End Sub
    'Handles all close button in program.
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Ask the user if they want to close the form.
        e.Cancel = (MessageBox.Show("Confirm close?", "Closing Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel)
    End Sub
End Class
