Imports System.Drawing
'Steven Nim
'December 17, 2014 - January 2015
'A "cafeteria" style program created for the ICS2O final summative. Except we sell weapons. Not Food.

Public Class frmShop
    Public TT As New ToolTip
    Dim mushroom As Integer
    Dim mushCost As Single
    Dim fireRod As Integer
    Dim fireCost As Single
    Dim lamppost As Integer
    Dim lampCost As Single
    Dim killingEdge As Integer
    Dim killCost As Single
    Dim axe As Integer
    Dim axeCost As Single
    Dim venomshank As Integer
    Dim venomCost As Single
    Dim runeScim As Integer
    Dim runeCost As Single
    Dim portalGun As Integer
    Dim portalCost As Single
    Dim specialItemList() As String = {"Buster Sword", "Upperdash Arm", "Flame Shield", "Doublade", "Glass of Tears"}
    Dim specialItemPicker As New Random
    Dim specialNum As Integer
    Dim specialCost As Single
    Dim specialTotal As Single
    Dim tax As Single
    Dim totalPreTax As Single
    Dim finalTotal As Single
    Dim phrase As String
    Dim phrase2 As String
    Public eternalTotal As Single
    Dim walletSave As Single
    Public cardSave As Single
    Dim paymentType As String
    Public nam As String
    Public creditCard As String
    Public creditReader As String
    Public creditCheck As Boolean
    Public inFile As System.IO.StreamReader
    Public outFile As System.IO.StreamWriter
    Dim cancelPurchase As String
    Public eof As Boolean
    Dim eof2 As Boolean
    Public savings As Single
    Dim cashGiven As Single
    Dim wallet As Single
    Dim change As Single
    Public cardRegistered As String
    Public cardRegisteredNum As String
    Public goldCoin As Boolean
    Dim goldCoinCheck As Single
    Private Sub frmShop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Close the title form upon start up.
        frmTitle.Hide()
        'Read in the user's all-time total spent...
        inFile = New System.IO.StreamReader("GRANDTOTALSPENT.txt")
        goldCoinCheck = inFile.ReadLine
        '...If the total is sufficient (over $200) then they can see the Gold Coin Claim button.
        If goldCoinCheck > 200 Then
            btnClaimCoin.Visible = True
            btnClaimCoin.Enabled = True
            MessageBox.Show("An odd new button has appeared on the shop!", "Alert!")
        End If
        'Close connection to the data file.
        inFile.Close()
        'Declare each numeric value as one of the special items.
        specialItemList(0) = "Buster Sword"
        specialItemList(1) = "Upperdash Arm"
        specialItemList(2) = "Flame Shield"
        specialItemList(3) = "Doublade"
        specialItemList(4) = "Glass of Tears"
        'Pick from one of the five Special Items.
        cbSpecial.Text = specialItemList(specialItemPicker.Next(0, specialItemList.Length))
        'Change the image and price depending on the special item.
        'For Buster Sword.
        If cbSpecial.Text = specialItemList(0) Then
            pbSpecial.Image = Image.FromFile("Picturez/ShopSpecial/BusterSword.png")
            specialCost = 19.99
            lblSpec.Text = FormatCurrency(specialCost)
            TT.SetToolTip(pbSpecial, "Passed down by many previous owners, this large blade packs immense power.")
            'For Upperdash Arm.
        ElseIf cbSpecial.Text = specialItemList(1) Then
            pbSpecial.Image = Image.FromFile("Picturez/ShopSpecial/UpperdashArm.png")
            specialCost = 14.99
            lblSpec.Text = FormatCurrency(specialCost)
            TT.SetToolTip(pbSpecial, "A sturdy weapon to be worn over the arm.")
            'For Flame Shield
        ElseIf cbSpecial.Text = specialItemList(2) Then
            pbSpecial.Image = Image.FromFile("Picturez/ShopSpecial/FlameShield.png")
            specialCost = 19.99
            lblSpec.Text = FormatCurrency(specialCost)
            TT.SetToolTip(pbSpecial, "To be used against internet trolls, flamers, and whiny children." & vbCrLf & _
                          "Doesn't actually protect the wielder from fire, lava, or other intense heat sources.")
            'For Doublade.
        ElseIf cbSpecial.Text = specialItemList(3) Then
            pbSpecial.Image = Image.FromFile("Picturez/ShopSpecial/Doublade.png")
            specialCost = 29.99
            lblSpec.Text = FormatCurrency(specialCost)
            TT.SetToolTip(pbSpecial, "Two ancient swords possessed by spirits. They will obey you as long as they're well fed.")
            'For Glass of Tears.
        ElseIf cbSpecial.Text = specialItemList(4) Then
            pbSpecial.Image = Image.FromFile("Picturez/ShopSpecial/GlassOfTears.png")
            specialCost = 4.99
            lblSpec.Text = FormatCurrency(specialCost)
            TT.SetToolTip(pbSpecial, "Dangerously salty tears gathered from unknown sources. Not safe to drink.")
        End If
        'Update the "all-time total money spent" counter on the shop page.
        inFile = New System.IO.StreamReader("GRANDTOTALSPENT.txt")
        eternalTotal = inFile.ReadLine
        lblGTotal.Text = FormatCurrency(eternalTotal)
        inFile.Close()
        'Update the "Card Savings" on the shop page.
        inFile = New System.IO.StreamReader("SAVINGS.txt")
        cardSave = inFile.ReadLine
        lblCardSave.Text = FormatCurrency(cardSave)
        inFile.Close()
        'Update the "Wallet Savings" on the shop page.
        inFile = New System.IO.StreamReader("WALLET.txt")
        walletSave = inFile.ReadLine
        lblWalletSave.Text = FormatCurrency(walletSave)
        inFile.Close()
        'Set the tooltips for all of the items, excluding special items (included earlier).
        TT.SetToolTip(pbMushroom, "This odd red and white mushroom is edible, and will make you feel refreshed upon consumption.")
        TT.SetToolTip(pbFireRod, "This funny looking rod actually has the magical power to burn down entire forests and orphanages.")
        TT.SetToolTip(pbLamppost, "Imagine if this was a real weapon!")
        TT.SetToolTip(pbKillEdge, "A wickedly sharp blade able to leave devastating wounds in its target.")
        TT.SetToolTip(pbAxe, "This humble little axe was used by a man lost in the woods to chop wood and fight angry spirits of nature.")
        TT.SetToolTip(pbVenomshank, "A glowing green sword crafted to inject deadly poisons into the wounds of its victims.")
        TT.SetToolTip(pbRuneScimmy, "I'll trim your rune chestplate if you buy this nice weapon!")
        TT.SetToolTip(pbPortal, "We had to escape a sarcastic, insane robot and its neurotoxin sprayers to get this.")
    End Sub
    Private Sub btnClaimCoin_Click(sender As System.Object, e As System.EventArgs) Handles btnClaimCoin.Click
        'Once this button is enabled the user can pick up their golden coin.
        If goldCoin <> True Then
            goldCoin = True
            MessageBox.Show("You recieved a shiny golden coin! But what's it for?", "Golden Coin Recieved!")
            'If the user already took their golden coin, tell them!
        Else
            MessageBox.Show("You've aleady claimed your golden coin!", "Hey, Listen!")
        End If
    End Sub
    Private Sub cbMushroom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMushroom.CheckedChanged
        'If the user clicks on the Mushroom option, then they can pick how many shrooms (heh) they want.
        nudMushroom.Enabled = True
    End Sub
    Private Sub nudMushroom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudMushroom.ValueChanged
        'Once enabled, the number of Mushrooms will be grabbed from the value of the item's respective NumericUpDown.
        mushroom = nudMushroom.Value
    End Sub
    '-------------------------------------------------------------------------------------------------------------
    Private Sub cbFireRod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFireRod.CheckedChanged
        'If the user clicks on the Fire Rod option, then they can pick how many rods they want.
        nudFireRod.Enabled = True
    End Sub
    Private Sub nudFireRod_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudFireRod.ValueChanged
        'Once enabled, the number of Fire Rods will be grabbed from the value of the item's respective NumericUpDown.
        fireRod = nudFireRod.Value
    End Sub
    '-------------------------------------------------------------------------------------------------------------
    Private Sub cbLamppost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLamppost.CheckedChanged
        'If the user clicks on the Lamppost option, then they can pick how many deadly lampposts they want.
        nudLamppost.Enabled = True
    End Sub
    Private Sub nudLamppost_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudLamppost.ValueChanged
        'Once enabled, the number of Lampposts will be grabbed from the value of the item's respective NumericUpDown.
        lamppost = nudLamppost.Value
    End Sub
    '-------------------------------------------------------------------------------------------------------------
    Private Sub cbKillEdge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbKillEdge.CheckedChanged
        'If the user clicks on the Killing Edge option, then they can pick how many Killing Edges they want.
        nudKillEdge.Enabled = True
    End Sub
    Private Sub nudKillEdge_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudKillEdge.ValueChanged
        'Once enabled, the number of Killing Edges will be grabbed from the value of the item's respective NumericUpDown.
        killingEdge = nudKillEdge.Value
    End Sub
    '-------------------------------------------------------------------------------------------------------------
    Private Sub cbAxe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAxe.CheckedChanged
        'If the user clicks on the Axe option, then they can pick how many axes they want.
        nudAxe.Enabled = True
    End Sub
    Private Sub nudAxe_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudAxe.ValueChanged
        'Once enabled, the number of Axes will be grabbed from the value of the item's respective NumericUpDown.
        axe = nudAxe.Value
    End Sub
    '-------------------------------------------------------------------------------------------------------------
    Private Sub cbVenomshank_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbVenomshank.CheckedChanged
        'If the user clicks on the Venomshank option, then they can pick how many poisonous swords they want.
        nudVenomshank.Enabled = True
    End Sub
    Private Sub nudVenomshank_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudVenomshank.ValueChanged
        'Once enabled, the number of Venomshanks will be grabbed from the value of the item's respective NumericUpDown.
        venomshank = nudVenomshank.Value
    End Sub
    '--------------------------------------------------------------------------------------------------------------
    Private Sub cbRuneScimmy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRuneScimmy.CheckedChanged
        'If the user clicks on the Rune Scimitar option, then they can pick how many Scimmies they want.
        nudRuneScimmy.Enabled = True
    End Sub
    Private Sub nudRuneScimmy_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudRuneScimmy.ValueChanged
        'Once enabled, the number of Rune Scimmies will be grabbed from the value of the item's respective NumericUpDown.
        runeScim = nudRuneScimmy.Value
    End Sub
    '---------------------------------------------------------------------------------------------------------------
    Private Sub cbPortal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPortal.CheckedChanged
        'If the user clicks on the Portal Gun option, then they can pick how many Portal Guns they want.
        nudPortal.Enabled = True
    End Sub
    Private Sub nudPortal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudPortal.ValueChanged
        'Once enabled, the number of Portal Guns will be grabbed from the value of the item's respective NumericUpDown
        portalGun = nudPortal.Value
    End Sub
    Private Sub cbSpecial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSpecial.CheckedChanged
        'If the user clicks on the Special Item option, then they can pick how many of that item they they want.
        nudSpecial.Enabled = True
    End Sub
    Private Sub nudSpecial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudSpecial.ValueChanged
        'Once enabled, the number of Special Items will be grabbed from the value of the item's respective NumericUpDown
        specialNum = nudSpecial.Value
    End Sub
    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        'Set up headers for the receipt.
        phrase = "Item Name" & vbTab & "Quantity" & vbTab & "Cost ($)" & vbCrLf
        'Calculate how many of each item the user wants.
        'Calculate the total cost of all Mushrooms.
        mushCost = mushroom * 4.99
        'Calculate the total cost of all Fire Rods.
        fireCost = fireRod * 24.99
        'Calculate the total cost of all Lampposts.
        lampCost = lamppost * 12.99
        'Calculate the total cost of all Killing Edges.
        killCost = killingEdge * 14.99
        'Calculate the total cost of all Axes.
        axeCost = axe * 9.99
        'Calculate the total cost of all Venomshank swords.
        venomCost = venomshank * 14.99
        'Calculate the total cost of all Rune Scimitars.
        runeCost = runeScim * 19.99
        'Calculate the total cost of all Portal Guns.
        portalCost = portalGun * 19.99
        'Calculate the total cost of all Special Items.
        specialTotal = specialNum * specialCost
        'Calculate the total cost before the taxes.
        totalPreTax = mushCost + fireCost + lampCost + killCost + axeCost + venomCost + runeCost + portalCost + specialTotal
        'Find the tax (HST).
        tax = totalPreTax * 0.13
        'Find the subtotal
        finalTotal = totalPreTax + tax
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'If statements are here to prevent printing items if the user has not purchased them.
        If mushroom <> 0 Then
            phrase = phrase & "Mushroom" & vbTab & mushroom & vbTab & FormatCurrency(mushCost) & vbCrLf
        End If
        If fireRod <> 0 Then
            phrase = phrase & "Fire Rod" & vbTab & vbTab & fireRod & vbTab & FormatCurrency(fireCost) & vbCrLf
        End If
        If lamppost <> 0 Then
            phrase = phrase & "Lamppost" & vbTab & vbTab & lamppost & vbTab & FormatCurrency(lampCost) & vbCrLf
        End If
        If killingEdge <> 0 Then
            phrase = phrase & "Killing Edge" & vbTab & killingEdge & vbTab & FormatCurrency(killCost) & vbCrLf
        End If
        If axe <> 0 Then
            phrase = phrase & "Axe" & vbTab & vbTab & axe & vbTab & FormatCurrency(axeCost) & vbCrLf
        End If
        If venomshank <> 0 Then
            phrase = phrase & "Venomshank" & vbTab & venomshank & vbTab & FormatCurrency(venomCost) & vbCrLf
        End If
        If runeScim <> 0 Then
            phrase = phrase & "Rune Scimmy" & vbTab & runeScim & vbTab & FormatCurrency(runeCost) & vbCrLf
        End If
        If portalGun <> 0 Then
            phrase = phrase & "Portal Gun" & vbTab & portalGun & vbTab & FormatCurrency(portalCost) & vbCrLf
        End If
        If specialNum <> 0 Then
            phrase = phrase & cbSpecial.Text & vbTab & specialNum & vbTab & FormatCurrency(specialTotal) & vbCrLf
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'Insert totals and taxes into the phrase.
        'If the user hasn't bought anything and they try to print the receipt, then they get NOTHING.
        If mushroom = 0 And fireRod = 0 And lamppost = 0 And killingEdge = 0 And axe = 0 And venomshank = 0 And runeScim = 0 And portalGun = 0 And specialNum = 0 Then
            phrase = "Please order at least one item to get a proper receipt!"
        Else
            phrase = phrase & vbCrLf & "Total Before Tax ($)" & vbTab & vbTab & FormatCurrency(totalPreTax) & vbCrLf & _
                 "HST Tax Amount ($)" & vbTab & vbTab & FormatCurrency(tax) & vbCrLf & _
                 "Final Total ($)" & vbTab & vbTab & FormatCurrency(finalTotal)
        End If
        'If the user didn't buy anything then don't enable the buttons. This is in a different If statement because I said so.
        If finalTotal <> 0 Then
            'Enable the disabled payment options and change their colours.
            btnPay.Enabled = True
            btnPay.BackColor = Color.Green
            btnCashPay.Enabled = True
            btnCashPay.BackColor = Color.Green
        End If
        'Display either a proper receipt or a "Sorry!"-type message in the label/receipt section.
        lblReceipt.Text = phrase
    End Sub

    'This executes if the user pays with Credit.
    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        'We need to ask the user if they're sure of their purchase. If not, all of this is cancelled.
        cancelPurchase = MessageBox.Show("Are you sure you want to make this purchase?", "Confirm Purchase", MessageBoxButtons.YesNo)
        If cancelPurchase = vbYes Then
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
                    If savings - finalTotal <= 0 Then
                        MessageBox.Show("You don't have enough money to buy this! Your purchase has been cancelled.", _
                                        "Unable to Process Purchase")
                        inFile.Close()
                    Else
                        'Remove the money spent from the savings.
                        savings = savings - finalTotal
                        'Write to the savings file witht he new amount; replace the old one.
                        inFile.Close()
                        outFile = New System.IO.StreamWriter("SAVINGS.txt")
                        outFile.WriteLine(savings)
                        'Close connection once done.
                        outFile.Close()
                        'Print to the user the money they have spent
                        phrase2 = "Thank you for your purchase! You spent " & FormatCurrency(finalTotal) & " and you have " & _
                                   FormatCurrency(savings) & " left in your savings."
                        MessageBox.Show(phrase2, "Purchase Successful!")
                        'Read in the user's total money spent. For when the user visits more than once.
                        inFile = New System.IO.StreamReader("GRANDTOTALSPENT.txt")
                        eternalTotal = inFile.ReadLine
                        'Add your total money spent to a grand total that is stored for access to the Secret Shop.
                        eternalTotal = eternalTotal + finalTotal
                        inFile.Close()
                        'Write the new all-time total money spent to the data file. This will replace the old number.
                        outFile = New System.IO.StreamWriter("GRANDTOTALSPENT.txt")
                        outFile.WriteLine(eternalTotal)
                        'Update the counter on the shop page.
                        lblGTotal.Text = FormatCurrency(eternalTotal)
                        outFile.Close()
                        'Read in the user's new Card savings and record it on the shop form's label display.
                        inFile = New System.IO.StreamReader("SAVINGS.txt")
                        cardSave = inFile.ReadLine
                        inFile.Close()
                        lblCardSave.Text = FormatCurrency(cardSave)
                        'Disable the payment options and change colour.
                        btnPay.Enabled = False
                        btnPay.BackColor = Color.White
                        btnCashPay.Enabled = False
                        btnCashPay.BackColor = Color.White
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
            btnPay.Enabled = False
            btnPay.BackColor = Color.White
            btnCashPay.Enabled = False
            btnCashPay.BackColor = Color.White
        End If
    End Sub

    'This executes if the player pays with Cash.
    Private Sub btnCashPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashPay.Click
        'We need to ask the user if they're sure of their purchase. If not, all of this is cancelled.
        cancelPurchase = MessageBox.Show("Are you sure you want to make this purchase?", "Confirm Purchase", MessageBoxButtons.YesNo)
        If cancelPurchase = vbYes Then
            'Make a connection to the wallet savings file.
            inFile = New System.IO.StreamReader("WALLET.txt")
            'Store the money in the user's wallet into a variable.
            wallet = inFile.ReadLine
            'Ask the user for how much they want to pay with.
            cashGiven = InputBox("Please enter the amount you would like to pay with.")
            'Close connection to the file.
            inFile.Close()
            'If the user has given enough money and they have enough in their wallet, then take thier payment and give them change.
            If cashGiven >= finalTotal And wallet >= cashGiven Then
                outFile = New System.IO.StreamWriter("WALLET.txt")
                wallet = wallet - cashGiven
                change = cashGiven - finalTotal
                wallet = wallet + change
                outFile.WriteLine(wallet)
                MessageBox.Show("Thanks for your purchase! You gave " & FormatCurrency(cashGiven) & " and you recieved " & _
                                FormatCurrency(change) & " in change.", "Purchase Successful!")
                outFile.Close()
                'Read in the user's total money spent. For when the user visits more than once.
                inFile = New System.IO.StreamReader("GRANDTOTALSPENT.txt")
                eternalTotal = inFile.ReadLine
                'Add your total money spent to a grand total that is stored for access to the Secret Shop.
                eternalTotal = eternalTotal + finalTotal
                inFile.Close()
                'Write the new all-time total money spent to the data file. This will replace the old number.
                outFile = New System.IO.StreamWriter("GRANDTOTALSPENT.txt")
                outFile.WriteLine(eternalTotal)
                'Update the counter on the shop page.
                lblGTotal.Text = FormatCurrency(eternalTotal)
                outFile.Close()
                'Read in the user's updated wallet savings and update the total on the shop form.
                inFile = New System.IO.StreamReader("WALLET.txt")
                walletSave = inFile.ReadLine
                inFile.Close()
                lblWalletSave.Text = FormatCurrency(walletSave)
                'If the user doesn't give enough money, REJECT THAT
            ElseIf cashGiven < finalTotal Then
                MessageBox.Show("Purchase failed because you did not give enough money.", "Purchase Declined")
                'If the user gives the right amount but doesn't have enough in their wallet, REJECT THAT
            ElseIf cashGiven >= finalTotal And wallet < cashGiven Then
                MessageBox.Show("Purchase failed because you do not have the sufficient funds in your wallet.", _
                                "Purchase Declined")
            End If
            'Disable the payment options and change colour.
            btnPay.Enabled = False
            btnPay.BackColor = Color.White
            btnCashPay.Enabled = False
            btnCashPay.BackColor = Color.White
            'Otherwise, if the purchase is cancelled, then stop it all.
        Else
            MessageBox.Show("Your purchase has been cancelled.", "Purchase Cancelled")
            'Disable the payment options and change colour.
            btnPay.Enabled = False
            btnPay.BackColor = Color.White
            btnCashPay.Enabled = False
            btnCashPay.BackColor = Color.White
        End If
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Exit the shop menu and return to the title screen.
        Me.Close()
        frmTitle.Show()
    End Sub
    'Handles all close button in program.
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Ask the user if they want to close the form.
        e.Cancel = (MessageBox.Show("Confirm close?", "Closing Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel)
    End Sub
    Private Sub lblReceiptTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReceiptTitle.Click
        'Secret Shop access will be granted to those who have spent over $420 at the regular shop.
        If goldCoin = True Then
            MessageBox.Show("So you know the secret... hand that coin over and come on in, sneaky customer." _
                            , "Secret Access: GRANTED")
            frmSecretShop.Show()
            Me.Hide()
        Else
            MessageBox.Show("Do not tell anyone of this. Come back when you've got the 'key'.", _
                            "Secret Access: DENIED", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
        End If
    End Sub
End Class