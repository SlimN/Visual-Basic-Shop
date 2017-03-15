'Steven Nim
'December 17, 2014 - January 2015
'A "cafeteria" style program created for the ICS2O final summative. Except we sell weapons. Not Food.

'The Fwump Machine is the place to go if you run outta spending money.
Public Class frmFwump
    Dim ranNumGoal As Integer
    Dim ranNumPick As Integer
    Dim earn As Single = 30.0
    Dim streak As Integer
    Dim readInMoney As Single
    Dim lossBlurbPick As Integer
    Dim lossBlurb As String
    Public inFile
    Public outFile
    Private Sub frmFwump_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Randomize all random numbers to be random.
        Randomize()
        'Turn up
        My.Computer.Audio.Play("GameCorner.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub btnFwump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFwump.Click
        'Change the user's amount of winnings based on their streak.
        'A streak of 2 gets you $25 per win.
        If streak = 2 Then
            earn = 69.0
            MessageBox.Show("If you win, you'll get " & FormatCurrency(earn) & " instead of $10.", "Note: Increased Winnings")
            'A streak of 3 or more gets you $42 per win.
        ElseIf streak >= 3 Then
            earn = 133.37
            MessageBox.Show("If you win, you'll get " & FormatCurrency(earn) & " instead of $10.", "Note: Increased Winnings")
        End If
        'Check the user's chosen number.
        ranNumPick = nudYourNum.Value
        'Pick the random number the user wants and display it.
        ranNumGoal = (Int((9 * Rnd()) + 1))
        lblGetThis.Text = ranNumGoal
        lblGetThis.Visible = True
        lblNum.Visible = True
        'If the user got it right, they get money.
        If ranNumPick = ranNumGoal Then
            'Read in the user's savings ans store it in a variable.
            inFile = New System.IO.StreamReader("WALLET.txt")
            readInMoney = inFile.ReadLine
            inFile.close()
            'Calculate their new total savings in their wallet.
            readInMoney = readInMoney + earn
            'Write the new savings amount into the wallet text file.
            outFile = New System.IO.StreamWriter("WALLET.txt")
            outFile.WriteLine(readInMoney)
            outFile.close()
            'Show their user's winnings!
            MessageBox.Show("Correct guess! You won " & FormatCurrency(earn) & " dollars! Your winnings have been added to your wallet.", "Victory!")
            'Add to the user's streak.
            streak = streak + 1
            'Change to happy face :) and change colour
            If streak >= 2 Then
                lblIndicator.Text = ":D"
                lblIndicator.BackColor = Color.Green
            Else
                lblIndicator.BackColor = Color.DarkSeaGreen
                lblIndicator.Text = ":)"
            End If
            'Display current streak.
            MessageBox.Show("You are currently on a streak of " & streak & ". Keep winning to increase your profit!", "Streak Indicator")
        Else
            'Generate a number between 1 and 5...
            lossBlurbPick = (Int((5 * Rnd()) + 1))
            '...To determine the loss message!
            If lossBlurbPick = 1 Then
                MessageBox.Show("You guessed incorrectly! Better luck next time!", "Loss!")
            ElseIf lossBlurbPick = 2 Then
                MessageBox.Show("Wrong! You terrible at this!", "You Suck!")
            ElseIf lossBlurbPick = 3 Then
                MessageBox.Show("cause you baaaaaaad", "are you a sheep")
            ElseIf lossBlurbPick = 4 Then
                MessageBox.Show("u trash tear top kek", "kek")
            ElseIf lossBlurbPick = 5 Then
                MessageBox.Show("Usted es realmente malo hue hue hue hue", "Usted es el último")
            End If
            '...and break their streak if needed.
            streak = 0
            'Change to sad face :( and change colour.
            lblIndicator.BackColor = Color.Red
            lblIndicator.Text = ":("
        End If
    End Sub
    Private Sub btnExitFwump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitFwump.Click
        'When Exit is clicked, go back to the title screen.
        Me.Close()
        frmTitle.Show()
        'Change the music back to the regular track.
        My.Computer.Audio.Play("ShopChannel.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    'Handles all close button in program.
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Ask the user if they want to close the form.
        e.Cancel = (MessageBox.Show("Confirm close?", "Closing Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel)
    End Sub
End Class