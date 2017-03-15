'Steven Nim
'December 17, 2014 - January 2015
'A "cafeteria" style program created for the ICS2O final summative. Except we sell weapons. Not Food.
Public Class frmSecretShop
    Public inFile
    Public outFile
    Public goldCoin
    Public eternalTotal
    Public nam
    Public creditCard
    Public creditReader
    Public creditCheck
    Public eof
    Public cardRegistered
    Public cardRegisteredNum
    Public savings
    Public cardSave
    Dim aegislashCost As Single
    Dim aegislashNum As Integer
    Dim maximCost As Single
    Dim maximNum As Integer
    Dim masterSwordCost As Single
    Dim masterSwordNum As Integer
    Dim SSPretotal As Single
    Dim SStax As Single
    Dim SStotal As Single
    Dim SSphrase As String
    Dim SSphrase2 As String
    Dim communityChest As Single
    Dim savin As Single
    Dim commChestTake As Single
    Dim newChestAmount As Integer
    Dim newChestRand As Integer
    Dim cancelChest As String
    Dim cancelPurchaseSS As String
    Dim walletSS As Single
    Dim cashGivenSS As Single
    Dim changeSS As Single
    Dim TTss As New ToolTip
    Private Sub frmSecretShop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Calling randomization!
        Randomize()
        'Get the song playing.
        My.Computer.Audio.Play("Southern.wav", AudioPlayMode.BackgroundLoop)
        'Randomly generate an amount for the community chest and stick it into the data file. Amount ranges from $10 to $200.
        newChestRand = (Int((200 * Rnd()) + 10))
        newChestAmount = newChestRand
        'Write the chest's new amount to the data file containing its savings.
        outFile = New System.IO.StreamWriter("CHEST.txt")
        outFile.writeline(newChestAmount)
        outFile.close()
        'Load in the Community Chest's new savings.
        inFile = New System.IO.StreamReader("CHEST.txt")
        communityChest = inFile.readline
        inFile.close()
        'Change the chest image to a closed version.
        pbCommChest.Image = Image.FromFile("Picturez/ChestClosed.png")
        'Set the tooltips for the shop items.
        TTss.SetToolTip(pbAegislash, "The evolved form of Doublade. It can switch between a defensive shield form and a powerful sword form with ease.")
        TTss.SetToolTip(pbMaxim, "Not only does this Dream Land delicacy heal you more than a mushroom, it tastes fresher!")
        TTss.SetToolTip(pbMasterSword, "The legendary sword that evil itself fears.")
    End Sub
    Private Sub btnExitSS_Click(sender As System.Object, e As System.EventArgs) Handles btnExitSS.Click
        'Exit the Secret Shop menu and return to the regular shop.
        Me.Close()
        frmShop.Show()
        My.Computer.Audio.Play("ShopChannel.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub cbAegislash_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbAegislash.CheckedChanged
        'If the user clicks the checkbox for Aegislash then the NumericUpDown gets enabled.
        nudAegislash.Enabled = True
    End Sub
    Private Sub nudAegislash_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudAegislash.ValueChanged
        'The value on Aegislash's NumericUpDown determines the quantity the user wants to buy.
        aegislashNum = nudAegislash.Value
    End Sub
    Private Sub cbMaxim_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbMaxim.CheckedChanged
        'If the user clicks the checkbox for the Maxim Tomato then the NumericUpDown gets enabled.
        nudMaxim.Enabled = True
    End Sub
    Private Sub nudMaxim_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudMaxim.ValueChanged
        'The value on the Maxim Tomato's NumericUpDown determines the quantity the user wants to buy.
        maximNum = nudMaxim.Value
    End Sub
    Private Sub cbMasterSword_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbMasterSword.CheckedChanged
        'If the user clicks the checkbox for the Master Sword then the NumericUpDown gets enabled.
        nudMasterSword.Enabled = True
    End Sub
    Private Sub nudMasterSword_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudMasterSword.ValueChanged
        'The value on the Maxim Tomato's NumericUpDown determines the quantity the user wants to buy.
        masterSwordNum = nudMasterSword.Value
    End Sub
    'Credit Card payment option.
    Private Sub btnPayCreditSS_Click(sender As System.Object, e As System.EventArgs) Handles btnPayCreditSS.Click
        'We need to ask the user if they're sure of their purchase. If not, all of this is cancelled.
        cancelPurchaseSS = MessageBox.Show("Are you sure you want to make this purchase?", "Confirm Purchase", MessageBoxButtons.YesNo)
        If cancelPurchaseSS = vbYes Then
            'Connect to the data file containing Banned Credit Card numbers.
            inFile = New System.IO.StreamReader("BANNEDCARDS.txt")
            'Ask user for their name and credit card number.
            nam = InputBox("Please input your name. (Ex. John Doe, Larry Beige)")
            creditCard = InputBox("Please enter in your 16 digit credit card number. (Ex. 5555-5555-5555-5555)")
            'Read in all of the banned credit card numbers. Continue to do so until the end of the file.
            Do While Not eof
                creditReader = inFile.ReadLine()
                If creditReader = Nothing Then
                    eof = True
                Else
                    'If the user's card numbers match one of the banned credit cards, the loop ends immediately and
                    'the user will be flagged for bad credit.
                    If creditReader = creditCard Then
                        creditCheck = True
                        eof = True
                    End If
                End If
            Loop
            'Once we're done reading the file, what happens depends on whether or not the user has been flagged.
            'If the user has been flagged, then they will be removed from the shop.
            If creditCheck = True Then
                MessageBox.Show("CREDIT CARD REJECTED. YOUR CREDIT IS BAD. YOUR PURCHASE HAS BEEN UNDONE AND YOU " & _
                                "HAVE BEEN EJECTED FROM THE SHOP.", "BAD CREDIT ALERT")
                Me.Close()
                frmTitle.Show()
                'Otherwise, their purchase will be processed and the money will be removed from the user's card.
            Else
                'Close connection to the banned cards data file.
                inFile.Close()
                'Check for if the card is registered.
                inFile = New System.IO.StreamReader("CARDS.txt")
                'Read in the registered card info.
                cardRegistered = inFile.ReadLine
                cardRegisteredNum = inFile.ReadLine
                inFile.Close()
                If cardRegistered = nam And cardRegisteredNum = creditCard Then
                    'Open a new connection to the data file containing the user's money.
                    inFile = New System.IO.StreamReader("SAVINGS.txt")
                    'Read in the user's money.
                    savings = inFile.ReadLine
                    'MOAR IF STATEMENTS! Only subtract from the user's savings if they have enough to do so.
                    If savings - SStotal <= 0 Then
                        MessageBox.Show("You don't have enough money to buy this! Your purchase has been cancelled.", _
                                        "Unable to Process Purchase")
                        inFile.Close()
                    Else
                        'Remove the money spent from the savings.
                        savings = savings - SStotal
                        'Write to the savings file witht he new amount; replace the old one.
                        inFile.Close()
                        outFile = New System.IO.StreamWriter("SAVINGS.txt")
                        outFile.WriteLine(savings)
                        'Close connection once done.
                        outFile.Close()
                        'Print to the user the money they have spent
                        SSphrase2 = "Thank you for your purchase! You spent " & FormatCurrency(SStotal) & " and you have " & _
                                   FormatCurrency(savings) & " left in your savings."
                        MessageBox.Show(SSphrase2, "Purchase Successful!")
                        'Read in the user's total money spent. For when the user visits more than once.
                        inFile = New System.IO.StreamReader("GRANDTOTALSPENT.txt")
                        eternalTotal = inFile.ReadLine
                        'Add your total money spent to a grand total that is stored for access to the Secret Shop.
                        eternalTotal = eternalTotal + SStotal
                        inFile.Close()
                        'Write the new all-time total money spent to the data file. This will replace the old number.
                        outFile = New System.IO.StreamWriter("GRANDTOTALSPENT.txt")
                        outFile.WriteLine(eternalTotal)
                        outFile.Close()
                        'Read in the user's new Card savings and record it on the shop form's label display.
                        inFile = New System.IO.StreamReader("SAVINGS.txt")
                        cardSave = inFile.ReadLine
                        inFile.Close()
                        'Disable the payment options and change colour.
                        btnPayCreditSS.Enabled = False
                        btnPayCreditSS.BackColor = Color.White
                        btnPayCashSS.Enabled = False
                        btnPayCashSS.BackColor = Color.White
                    End If
                    'If the user doesn't enter the right credit card info then DENY THEM
                Else
                    MessageBox.Show("Your card did not match the one registered. You can register a credit card on the title screen")
                End If
            End If
        Else
            'Close connection when the user says no.
            inFile.Close()
            MessageBox.Show("Your purchase has been cancelled.", "Purchase Cancelled")
            'Disable the payment options and change colour.
            btnPayCreditSS.Enabled = False
            btnPayCreditSS.BackColor = Color.White
            btnPayCashSS.Enabled = False
            btnPayCashSS.BackColor = Color.White
        End If
    End Sub
    Private Sub btnPreviewSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviewSS.Click
        'Set up headers for the receipt.
        SSphrase = "Item Name" & vbTab & "Quantity" & vbTab & "Cost ($)" & vbCrLf
        'Calculate the cost of Aegislashes, Master Swords, and Maxim Tomatoes the user wants.
        aegislashCost = aegislashNum * 54.99
        maximCost = maximNum * 9.99
        masterSwordCost = masterSwordNum * 39.99
        'Calculate the total before taxes.
        SSPretotal = aegislashCost + maximCost + masterSwordCost
        'Calculate the tax amount.
        SStax = SSPretotal * 0.13
        'Calculate the final total.
        SStotal = SSPretotal + SStax
        'Print the ordered items on the receipt. Do not print them if the user is not buying any.
        If aegislashNum <> 0 Then
            SSphrase = SSphrase & "Aegislash" & vbTab & vbTab & aegislashNum & vbTab & FormatCurrency(aegislashCost) & vbCrLf
        End If
        If maximNum <> 0 Then
            SSphrase = SSphrase & "Maxim Tomato" & vbTab & maximNum & vbTab & FormatCurrency(maximCost) & vbCrLf
        End If
        If masterSwordNum <> 0 Then
            SSphrase = SSphrase & "Master Sword" & vbTab & masterSwordNum & vbTab & FormatCurrency(masterSwordCost) & vbCrLf
        End If
        'Only print a proper receipt if the user has bought something.
        If aegislashNum = 0 And maximNum = 0 And masterSwordNum = 0 Then
            SSphrase = "Please order at least one item to get a proper receipt!"
        Else
            'Here's the proper receipt.
            SSphrase = SSphrase & vbCrLf & "Pre-Tax Total ($)" & vbTab & vbTab & FormatCurrency(SSPretotal) & vbCrLf & _
            "HST Tax Amount ($)" & vbTab & vbTab & FormatCurrency(SStax) & vbCrLf & "Final Total ($)" & vbTab & vbTab & _
            FormatCurrency(SStotal)
        End If
        'If the user didn't buy anything then don't enable the buttons. This is in a different If statement because I said so.
        If SStotal <> 0 Then
            'Enable the disabled payment options and change their colours.
            btnPayCashSS.Enabled = True
            btnPayCashSS.BackColor = Color.Green
            btnPayCreditSS.Enabled = True
            btnPayCreditSS.BackColor = Color.Green
        End If
        'Display receipt.
        lblReceiptSS.Text = SSphrase
    End Sub
    Private Sub pbCommChest_Click(sender As System.Object, e As System.EventArgs) Handles pbCommChest.Click
        'Clicking the chest will make you take its savings and store it into your credit card. Somehow.
        'Ask the user if they want to take from the chest. If yes, let them. If no, close message.
        cancelChest = MessageBox.Show("Would you like to take from the chest? Current savings: " & FormatCurrency(communityChest), _
                        "You Sure About This?", MessageBoxButtons.YesNo)
        If cancelChest = vbYes Then
            'Open a connection to your credit card savings ans read it in. Add the current savings to the amount take from the
            'Community Chest and store it back into the text file.
            inFile = New System.IO.StreamReader("SAVINGS.txt")
            savin = inFile.readline
            commChestTake = savin + communityChest
            inFile.close()
            outFile = New System.IO.StreamWriter("SAVINGS.txt")
            outFile.writeline(commChestTake)
            outFile.close()
            'Change the picture to an opened chest.
            pbCommChest.Image = Image.FromFile("Picturez/ChestOpen.png")
            'Prevent them from clicking again.
            pbCommChest.Enabled = False
            'Tell the user how much has been added.
            MessageBox.Show("You recieved " & FormatCurrency(communityChest) & "! It has been added to your Credit Card savings.", _
                            "Run Straight to the Bank With This")
        Else
            'Give the user a dnial message.
            MessageBox.Show("You decide to not take from the community chest.", "Too Rich For This")
        End If
    End Sub

    Private Sub btnPayCashSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayCashSS.Click
        'You can only pay with cash in the secret storage. HAVE FUN WITH FWUMP
        'We need to ask the user if they're sure of their purchase. If not, all of this is cancelled.
        cancelPurchaseSS = MessageBox.Show("Are you sure you want to make this purchase?", "Confirm Purchase", MessageBoxButtons.YesNo)
        If cancelPurchaseSS = vbYes Then
            'Make a connection to the wallet savings file.
            inFile = New System.IO.StreamReader("WALLET.txt")
            'Store the money in the user's wallet into a variable.
            walletSS = inFile.ReadLine
            'Ask the user for how much they want to pay with.
            cashGivenSS = InputBox("Please enter the amount you would like to pay with.", "Amount Tendered")
            'Close connection to the file.
            inFile.Close()
            'If the user has given enough money and they have enough in their wallet, then take thier payment and give them change.
            If cashGivenSS >= SStotal And walletSS >= cashGivenSS Then
                outFile = New System.IO.StreamWriter("WALLET.txt")
                walletSS = walletSS - cashGivenSS
                changeSS = cashGivenSS - SStotal
                walletSS = walletSS + changeSS
                outFile.WriteLine(walletSS)
                MessageBox.Show("Thanks for your purchase! You gave " & FormatCurrency(cashGivenSS) & " and you recieved " & _
                                FormatCurrency(changeSS) & " in change.", "Purchase Successful!")
                outFile.Close()
                'Read in the user's total money spent. For when the user visits more than once.
                inFile = New System.IO.StreamReader("GRANDTOTALSPENT.txt")
                eternalTotal = inFile.ReadLine
                'Add your total money spent to a grand total that is stored for access to the Secret Shop.
                eternalTotal = eternalTotal + SStotal
                inFile.Close()
                'Write the new all-time total money spent to the data file. This will replace the old number.
                outFile = New System.IO.StreamWriter("GRANDTOTALSPENT.txt")
                outFile.WriteLine(eternalTotal)
                outFile.Close()
                'If the user doesn't give enough money, REJECT THAT
            ElseIf cashGivenSS < SStotal Then
                MessageBox.Show("Purchase failed because you did not give enough money.", "Purchase Declined")
                'If the user gives the right amount but doesn't have enough in their wallet, REJECT THAT
            ElseIf cashGivenSS >= SStotal And walletSS < cashGivenSS Then
                MessageBox.Show("Purchase failed because you do not have the sufficient funds in your wallet.", _
                                "Purchase Declined")
            End If
            'Disable the payment options and change colour.
            btnPayCashSS.Enabled = False
            btnPayCashSS.BackColor = Color.White
            'Otherwise, if the purchase is cancelled, then stop it all.
        Else
            MessageBox.Show("Your purchase has been cancelled.", "Purchase Cancelled")
            'Disable the payment options and change colour.
            btnPayCashSS.Enabled = False
            btnPayCashSS.BackColor = Color.White
        End If
    End Sub
    'Handles all close button in program.
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Ask the user if they want to close the form.
        e.Cancel = (MessageBox.Show("Confirm close?", "Closing Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel)
    End Sub
    Private Sub lblReceiptTitleSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReceiptTitleSS.Click
        'S E C R E T L A B E L B O Y S
        MessageBox.Show("<:::::[]=¤༼ຈل͜ຈ༽ﾉ I am the knight of spamerino. Stand back foul moderino. Please no copypasterino <:::::[]=¤༼ຈل͜ຈ༽ﾉ", _
                        "please no copypasterino")
    End Sub
End Class