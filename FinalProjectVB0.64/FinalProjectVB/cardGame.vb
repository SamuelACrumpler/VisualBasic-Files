Option Explicit On
Option Strict On
Option Infer Off

Public Class cardGame
    'Create an array of controls
    Private picCard(5) As PictureBox
    Private lblCardValue(5) As Label
    Private lblCardPercent(5) As Label
    Private lblCardType(5) As Label
    'Player Driven Variables
    Dim playerDeck As New deck
    Dim reserveDeck As New deck
    Dim playerChar As New creature
    Dim playerTurn As Boolean
    Dim playerRand As New Random
    Dim eventCount As Integer
    Dim currentCards As Integer
    Dim currentDeck(currentCards) As card
    Dim playerTempDeck As New List(Of card)()
    Dim playerHand As New List(Of card)()
    Dim clickedCard As playerCards
    Dim blnDisableClick As Boolean
    Dim intPlayerAtk As Integer
    Dim intPAtkPer As Integer
    Dim intPlayerDodge As Integer
    Dim blnPlayerDead As Boolean
    Dim blnPlayerDefend As Boolean
    Dim blnPlayerStrike As Boolean


    'Monster Related variables
    Dim monChar As New creature
    Dim intMonAtk As New Integer
    Dim intMonRandNum As New Integer
    Dim monRand As New Random
    Dim blnMonDead As Boolean
    Dim blnMonDodge As Boolean
    'Monster Status Effect boolens
    Dim intMonDodge As Integer
    '
    Dim strTextEntered As String
    Dim blnEnterClicked As Boolean = False






    Structure playerCards
        Public newSuit As String
        Public newValue As Integer
        Public newEffect As String
        Public newPercent As Integer
        Public newDescription As String
        Public cardNum As Integer
    End Structure 'structure for the card


    Private Sub cardGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load player into game
        playerTempDeck.Clear()
        playerHand.Clear()
        playerDeck.maximumCards = 29
        playerChar.level = 1
        playerChar.statStr = 1
        playerChar.statInt = 1
        playerChar.statDex = 1
        playerChar.statCon = 1
        playerChar.maxHP = 100
        playerChar.staminaHP = 100
        playerChar.maxSP = 50
        playerChar.staminaSP = 50
        lblHpCurLabel.Text = CType(playerChar.staminaHP, String)
        lblHpMaxLabel.Text = CType(playerChar.maxHP, String)
        lblSpCurLabel.Text = CType(playerChar.staminaSP, String)
        lblSpMaxLabel.Text = CType(playerChar.maxSP, String)
        lblStrNum.Text = CType(playerChar.statStr, String)
        lblDexNum.Text = CType(playerChar.statDex, String)
        lblConNum.Text = CType(playerChar.statCon, String)
        lblIntNum.Text = CType(playerChar.statInt, String)




        ' need to make a script that rapidly generates cards for a deck
        For index As Integer = 0 To 29
            Dim NewPlayerCard As New card(playerRand)
            playerDeck.newCard = NewPlayerCard
        Next

        Console.WriteLine("Deck complete")
        Dim newpicCard As PictureBox
        Dim newCardValue As Label
        Dim newCardPercent As Label
        Dim newCardType As Label
        For i As Integer = 0 To 4
            'create a new control and set its properties
            newpicCard = New PictureBox
            newpicCard.Size = New Drawing.Size(120, 220)
            newpicCard.Location = New Point(12 + 126 * (i), 292)
            newpicCard.Name = "picCard" & i
            newpicCard.SizeMode = PictureBoxSizeMode.StretchImage
            picCard(i) = newpicCard
            'connect it to a handler, save a reference to the array and add it to the form controls
            AddHandler picCard(i).Click, AddressOf picCard_Click
            Me.Controls.Add(newpicCard)

            'Start labels
            'Value labels
            newCardValue = New Label
            newCardValue.Location = New Point(22 + 126 * (i), 302)
            newCardValue.Name = "lblCardValue" & i
            newCardValue.BackColor = Color.Transparent
            newCardValue.Text = "XXXX-" & i
            newCardValue.TextAlign = ContentAlignment.MiddleCenter
            newCardValue.Enabled = False
            lblCardValue(i) = newCardValue
            Me.Controls.Add(newCardValue)
            'Percent Label
            newCardPercent = New Label
            newCardPercent.Location = New Point(22 + 126 * (i), 352)
            newCardPercent.Name = "lblCardPercent" & i
            newCardPercent.BackColor = Color.Transparent
            newCardPercent.Text = "XXXX-" & i
            newCardPercent.TextAlign = ContentAlignment.MiddleCenter
            newCardPercent.Enabled = False
            lblCardPercent(i) = newCardPercent
            Me.Controls.Add(newCardPercent)
            'Type Labels
            newCardType = New Label
            newCardType.Location = New Point(22 + 126 * (i), 412)
            newCardType.Name = "lblCardType" & i
            newCardType.BackColor = Color.Transparent
            newCardType.Text = "XXXX-" & i
            newCardType.TextAlign = ContentAlignment.MiddleCenter
            newCardType.Enabled = False
            lblCardType(i) = newCardType
            Me.Controls.Add(newCardType)

            lblCardValue(i).BringToFront()
            lblCardPercent(i).BringToFront()
            lblCardType(i).BringToFront()
        Next
        comEvent()
    End Sub 'All things that need to be done when the game first loads.


    Private Sub comEvent()
        monChar.maxHP = 50 + (playerChar.level * 2)
        monChar.staminaHP = 50 + (playerChar.level * 5)
        monChar.listEffects.Clear()
        intMonRandNum = monRand.Next(1, 6)
        'pick a monster
        'turn into a struc, then place in a list if it is planned to add more monsters
        Select Case intMonRandNum
            Case 1
                txtLog.AppendText("Incoming deadly goblin!" & Environment.NewLine)
                picMonster.Image = My.Resources.monGobS
                monChar.creatureclass = "S_Goblin"
            Case 2
                txtLog.AppendText("Alert! A mystic orc approaches!" & Environment.NewLine)
                picMonster.Image = My.Resources.monOrcM
                monChar.creatureclass = "M_Orc"
            Case 3
                txtLog.AppendText("Watch out! A scorpion is here!" & Environment.NewLine)
                picMonster.Image = My.Resources.monScorp
                monChar.creatureclass = "Scorpion"
            Case 4
                txtLog.AppendText("The dead have arisen, a skeleton attacks!" & Environment.NewLine)
                picMonster.Image = My.Resources.monSkel
                monChar.creatureclass = "S_Skeleton"
            Case 5
                txtLog.AppendText("Usually comes in swarms.. but a lone zombie attacks" & Environment.NewLine)
                picMonster.Image = My.Resources.monZombie
                monChar.creatureclass = "Zombie"
        End Select
        eventCount += 1
        lblBattlesNum.Text = CType(eventCount, String)


        playerTurn = True
        'Start combat phase
        loadDeck()
        loadHand()

        'Clear hand and deck after battle concludes

    End Sub 'Combat events
    Private Sub monsterAttack()
        'Start monster attack phase

        Dim intMonAtk As Integer
        intMonAtk = playerRand.Next(1, 20) + playerChar.level 'Scales damage up for monsters
        If (monChar.listEffects.Contains("Stun")) Then
            monChar.listEffects.Remove("Stun")
            txtLog.AppendText("The monster was stunned!" & Environment.NewLine)
        ElseIf (monChar.listEffects.Contains("Sleep")) Then
            Dim intPlayerSleep As Integer
            intPlayerSleep = playerRand.Next(1, 101)
            If intPlayerSleep <= 50 Then
                monChar.listEffects.Remove("Sleep")
                txtLog.AppendText("The monster awakens!" & Environment.NewLine)
            Else
                txtLog.AppendText("The monster sleeps still." & Environment.NewLine) 'Target is still sleeping, let player know
            End If

        ElseIf (blnMonDodge = True) Then
            'Do nothing
            If intMonAtk < clickedCard.newValue Then
                txtLog.AppendText("You dodged the attack!" & Environment.NewLine)
            End If
        Else
            If blnPlayerDefend = True Then
                playerChar.staminaHP -= CType(Math.Round(intMonAtk / 2), Integer)
                blnPlayerDefend = False
                txtLog.AppendText("You put your guard up! The monster deals " & Math.Round(intMonAtk / 2) & " damage to you." & Environment.NewLine)
            Else
                playerChar.staminaHP -= intMonAtk
                txtLog.AppendText("The monster deals " & intMonAtk & " damage to you." & Environment.NewLine)
            End If
            endGame()

            pbarHP.Value = CInt((playerChar.staminaHP / playerChar.maxHP) * 100)
                lblHpCurLabel.Text = CType(playerChar.staminaHP, String)
            'pbarHP.Value = CInt((Math.Round(playerChar.staminaHP / playerChar.maxHP)) * 100)

        End If

        'enable click actions
        'Check if player is dead
    End Sub 'Monster Attack sequence

    Private Sub playerAttack()
        'disable click actions for cards until the monster attack resolves
        Dim blnStunFlag As Boolean
        Dim blnSleepFlag As Boolean

        'Player attack function handles things in this order
        'Check if user can hit target -> Apply damage if user can -> Status Effect Phase
        'Conditions to check before damage goes through
        '-------Check Attack Phase
        If (clickedCard.newEffect = "Heal") Then 'Check for heal
            playerChar.staminaHP += intPlayerAtk * 4
            lblHpCurLabel.Text = CType(playerChar.staminaHP, String)
            txtLog.AppendText("You heal for " & intPlayerAtk * 2 & " HP." & Environment.NewLine)
        ElseIf (clickedCard.newEffect = "Energize") Then 'Check for energize
            playerChar.staminaSP += intPlayerAtk * 2
            lblSpCurLabel.Text = CType(playerChar.staminaSP, String)
            txtLog.AppendText("You energize for " & intPlayerAtk * 2 & " SP." & Environment.NewLine)
        ElseIf (playerChar.listEffects.Contains("Stun")) Then 'Check for stun
            'do nothing/Stun needs to be checked BEFORE clicking a card.
            'Or if card is removed from hand after turn is resolved this can be ignored
            blnStunFlag = True
            playerChar.listEffects.Remove("Stun")
            txtLog.AppendText("You were stunned this turn!" & Environment.NewLine)
        ElseIf (playerChar.listEffects.Contains("Sleep")) Then 'check for sleep
            Dim intPlayerSleep As Integer
            intPlayerSleep = playerRand.Next(1, 100)
            If intPlayerSleep <= 50 Then
                playerChar.listEffects.Remove("Sleep")
            End If
            blnSleepFlag = True
        ElseIf (intMonDodge > clickedCard.newValue) Then
            'Do nothing
        Else
            If blnPlayerStrike = True Then
                monChar.staminaHP -= (intPlayerAtk * 2)
                blnPlayerStrike = False
                btnClassPow.Enabled = True
                txtLog.AppendText("You use a powerful swing, and deal " & intPlayerAtk * 2 & " damage to the monster." & Environment.NewLine)
            Else
                monChar.staminaHP -= intPlayerAtk '------ Normal Attack
                txtLog.AppendText("You deal " & intPlayerAtk & " damage to the monster." & Environment.NewLine)
            End If
            endGame()

        End If

        '------ Start Status Effect Phase
        'Roll a randomized number
        intPAtkPer = playerRand.Next(1, 101)
        'Check if the player landed the status effect on the card.
        Dim blnEffectLanded As Boolean = False
        If (intPAtkPer <= clickedCard.newPercent) Then
            If (monChar.listEffects.Contains(clickedCard.newEffect) = False) Then
                monChar.listEffects.Add(clickedCard.newEffect)
                blnEffectLanded = True
            End If
        End If
        'Run checks for current status effects
        'For Each effect As String In monChar.listEffects

        'Next
        If (clickedCard.newEffect = "Drain") Then
            Dim intDrainDamage As Double
            intDrainDamage = Math.Round((intPlayerAtk * 2))
            playerChar.staminaHP += CType(intDrainDamage, Integer)
            txtLog.AppendText("You drained " & intDrainDamage & " from the monster" & Environment.NewLine)
        End If
        If (monChar.listEffects.Contains("Poison")) Then
            Dim dblPoisonDamage As Double
            dblPoisonDamage = Math.Round((monChar.maxHP * 0.1))
            monChar.staminaHP -= CType(dblPoisonDamage, Integer)
            txtLog.AppendText("The monster isn't looking too good, it takes " & dblPoisonDamage & " damage." & Environment.NewLine)
        End If
        'stun goes through for the enemy, it skips the damage phase
        'sleep goes through on the enemy turn as well
        If (clickedCard.newEffect = "Weaken" And blnEffectLanded = True And (monChar.listEffects.Contains("Weaken") = False)) Then
            Dim dblWeaken As Double
            dblWeaken = Math.Round((monChar.staminaHP * 0.5))
            monChar.statStr = CType(dblWeaken, Integer)
            txtLog.AppendText("Your attack weakened the monster!" & Environment.NewLine)
        End If
        If (clickedCard.newEffect = "Stupify" AndAlso blnEffectLanded = True AndAlso (monChar.listEffects.Contains("Stupify") = False)) Then
            Dim dblStupify As Double
            dblStupify = Math.Round((monChar.staminaHP * 0.5))
            monChar.statInt = CType(dblStupify, Integer)
            txtLog.AppendText("You scrambled the monster's brain!" & Environment.NewLine)
        End If
        If (clickedCard.newEffect = "Slow" AndAlso blnEffectLanded = True AndAlso (monChar.listEffects.Contains("Slow") = False)) Then
            Dim dblSlow As Double
            dblSlow = Math.Round((monChar.staminaHP * 0.5))
            monChar.statDex = CType(dblSlow, Integer)
            txtLog.AppendText("A percise attack slows down the opponent!" & Environment.NewLine)
        End If
        If (clickedCard.newEffect = "Cripple" AndAlso blnEffectLanded = True AndAlso (monChar.listEffects.Contains("Cripple") = False)) Then
            Dim dblCripple As Double
            dblCripple = Math.Round((monChar.staminaHP * 0.5))
            monChar.statCon = CType(dblCripple, Integer)
            txtLog.AppendText("You deliver a strong attack that crippled the monster!" & Environment.NewLine)
        End If

        'use function to remove card from hand.
        'Flags for sleep and stun need to be used to a card from disappearing
        If (blnSleepFlag = True Or blnStunFlag = True) Then
            If playerChar.listEffects.Contains("Sleep") = False Then
                blnSleepFlag = False
            End If
        Else
            deleteCard(clickedCard.cardNum)
        End If
        playerTurn = False
        If monChar.staminaHP = 0 Then
            gainExp()
            comEvent()
        Else
            monsterAttack()
        End If

    End Sub 'Player attack sequence
    Private Sub drawCard()
        If (playerTempDeck.Count = 0) = False Then
            If playerHand.Count < 5 Then 'if the card hand is 4 and below, the
                Dim intCardPulled As Integer
                intCardPulled = playerRand.Next(0, playerTempDeck.Count)
                playerHand.Add(playerTempDeck(intCardPulled))
                playerTempDeck.RemoveAt(intCardPulled)
                Select Case playerHand.Item(playerHand.Count() - 1).Suit
                    Case "Strength"
                        'Allows for concatentating control nammes
                        picCard(playerHand.Count() - 1).Image = My.Resources.cardstr
                        lblCardValue(playerHand.Count() - 1).Text = CType(playerHand(playerHand.Count() - 1).Value, String)
                        lblCardValue(playerHand.Count() - 1).BackColor = ColorTranslator.FromHtml("#e08585")
                        lblCardValue(playerHand.Count() - 1).Visible = True

                        lblCardPercent(playerHand.Count() - 1).Text = playerHand(playerHand.Count() - 1).Percent & "%"
                        lblCardPercent(playerHand.Count() - 1).BackColor = ColorTranslator.FromHtml("#e08585")
                        lblCardPercent(playerHand.Count() - 1).Visible = True

                        lblCardType(playerHand.Count() - 1).Text = playerHand(playerHand.Count() - 1).Effect
                        lblCardType(playerHand.Count() - 1).BackColor = ColorTranslator.FromHtml("#e08585")
                        lblCardType(playerHand.Count() - 1).Visible = True
                    Case "Dexterity"
                        picCard(playerHand.Count() - 1).Image = My.Resources.carddex
                        lblCardValue(playerHand.Count() - 1).Text = CType(playerHand(playerHand.Count() - 1).Value, String)
                        lblCardValue(playerHand.Count() - 1).BackColor = ColorTranslator.FromHtml("#85e085")
                        lblCardValue(playerHand.Count() - 1).Visible = True

                        lblCardPercent(playerHand.Count() - 1).Text = playerHand(playerHand.Count() - 1).Percent & "%"
                        lblCardPercent(playerHand.Count() - 1).BackColor = ColorTranslator.FromHtml("#85e085")
                        lblCardPercent(playerHand.Count() - 1).Visible = True

                        lblCardType(playerHand.Count() - 1).Text = playerHand(playerHand.Count() - 1).Effect
                        lblCardType(playerHand.Count() - 1).BackColor = ColorTranslator.FromHtml("#85e085")
                        lblCardType(playerHand.Count() - 1).Visible = True
                    Case "Constitution"
                        picCard(playerHand.Count() - 1).Image = My.Resources.cardcon
                        lblCardValue(playerHand.Count() - 1).Text = CType(playerHand(playerHand.Count() - 1).Value, String)
                        lblCardValue(playerHand.Count() - 1).BackColor = ColorTranslator.FromHtml("#d9e085")
                        lblCardValue(playerHand.Count() - 1).Visible = True

                        lblCardPercent(playerHand.Count() - 1).Text = playerHand(playerHand.Count() - 1).Percent & "%"
                        lblCardPercent(playerHand.Count() - 1).BackColor = ColorTranslator.FromHtml("#d9e085")
                        lblCardPercent(playerHand.Count() - 1).Visible = True

                        lblCardType(playerHand.Count() - 1).Text = playerHand(playerHand.Count() - 1).Effect
                        lblCardType(playerHand.Count() - 1).BackColor = ColorTranslator.FromHtml("#d9e085")
                        lblCardType(playerHand.Count() - 1).Visible = True
                    Case "Intelligence"
                        picCard(playerHand.Count() - 1).Image = My.Resources.cardint
                        lblCardValue(playerHand.Count() - 1).Text = CType(playerHand(playerHand.Count() - 1).Value, String)
                        lblCardValue(playerHand.Count() - 1).BackColor = ColorTranslator.FromHtml("#9585e0")
                        lblCardValue(playerHand.Count() - 1).Visible = True

                        lblCardPercent(playerHand.Count() - 1).Text = playerHand(playerHand.Count() - 1).Percent & "%"
                        lblCardPercent(playerHand.Count() - 1).BackColor = ColorTranslator.FromHtml("#9585e0")
                        lblCardPercent(playerHand.Count() - 1).Visible = True

                        lblCardType(playerHand.Count() - 1).Text = playerHand(playerHand.Count() - 1).Effect
                        lblCardType(playerHand.Count() - 1).BackColor = ColorTranslator.FromHtml("#9585e0")
                        lblCardType(playerHand.Count() - 1).Visible = True
                End Select
            Else
                'Destroys a card if the player has a full hand.
                Dim intCardPulled As Integer
                intCardPulled = playerRand.Next(0, playerTempDeck.Count)
                playerTempDeck.RemoveAt(intCardPulled)
                txtLog.AppendText("You're at capacity for hand size! The card you've drawn is lost!" & Environment.NewLine)
            End If
        Else
            txtLog.AppendText("You're out of cards in your deck!" & Environment.NewLine)
        End If

    End Sub 'Draw Card

    Private Sub loadPlayer()
        playerTempDeck.Clear()
        playerHand.Clear()
        playerDeck.maximumCards = 29
        playerChar.level = 1
        playerChar.statStr = 1
        playerChar.statInt = 1
        playerChar.statDex = 1
        playerChar.statCon = 1
        playerChar.maxHP = 100
        playerChar.staminaHP = 100
        playerChar.maxSP = 50
        playerChar.staminaSP = 50
        playerChar.experience = 0
        playerChar.maxExp = 1
        lblHpCurLabel.Text = CType(playerChar.staminaHP, String)
        lblHpMaxLabel.Text = CType(playerChar.maxHP, String)
        lblSpCurLabel.Text = CType(playerChar.staminaSP, String)
        lblSpMaxLabel.Text = CType(playerChar.maxSP, String)
        lblStrNum.Text = CType(playerChar.statStr, String)
        lblDexNum.Text = CType(playerChar.statDex, String)
        lblConNum.Text = CType(playerChar.statCon, String)
        lblIntNum.Text = CType(playerChar.statInt, String)
        btnClassPow.Enabled = True
        btnDrawCard.Enabled = True
        blnPlayerStrike = False
        pbarHP.Value = 100
        pbarSP.Value = 100
        eventCount = 0
        txtLog.Clear()

        Array.Clear(playerDeck.arrCardDeck, 0, playerDeck.arrCardDeck.Count - 1)
        playerDeck.newGame = True
        playerDeck.maximumCards = 29
        For index As Integer = 0 To 29
            Dim NewPlayerCard As New card(playerRand)
            playerDeck.newCard = NewPlayerCard
        Next

        comEvent()
    End Sub

    Private Sub deleteCard(num As Integer)
        If playerHand.Count > 0 Then
            playerHand.RemoveAt(num) 'Delete clicked card
            Dim i As Integer = 0
            For Each item As card In playerHand
                Select Case playerHand.Item(i).Suit 'Checks each slot
                    Case "Strength"
                        picCard(i).Image = My.Resources.cardstr
                        lblCardValue(i).Text = CType(playerHand(i).Value, String)
                        lblCardValue(i).BackColor = ColorTranslator.FromHtml("#e08585")
                        lblCardValue(i).Visible = True

                        lblCardPercent(i).Text = playerHand(i).Percent & "%"
                        lblCardPercent(i).BackColor = ColorTranslator.FromHtml("#e08585")
                        lblCardPercent(i).Visible = True

                        lblCardType(i).Text = playerHand(i).Effect
                        lblCardType(i).BackColor = ColorTranslator.FromHtml("#e08585")
                        lblCardType(i).Visible = True
                    Case "Dexterity"
                        picCard(i).Image = My.Resources.carddex
                        lblCardValue(i).Text = CType(playerHand(i).Value, String)
                        lblCardValue(i).BackColor = ColorTranslator.FromHtml("#85e085")
                        lblCardValue(i).Visible = True

                        lblCardPercent(i).Text = playerHand(i).Percent & "%"
                        lblCardPercent(i).BackColor = ColorTranslator.FromHtml("#85e085")
                        lblCardPercent(i).Visible = True

                        lblCardType(i).Text = playerHand(i).Effect
                        lblCardType(i).BackColor = ColorTranslator.FromHtml("#85e085")
                        lblCardType(i).Visible = True
                    Case "Constitution"
                        picCard(i).Image = My.Resources.cardcon
                        lblCardValue(i).Text = CType(playerHand(i).Value, String)
                        lblCardValue(i).BackColor = ColorTranslator.FromHtml("#d9e085")
                        lblCardValue(i).Visible = True

                        lblCardPercent(i).Text = playerHand(i).Percent & "%"
                        lblCardPercent(i).BackColor = ColorTranslator.FromHtml("#d9e085")
                        lblCardPercent(i).Visible = True

                        lblCardType(i).Text = playerHand(i).Effect
                        lblCardType(i).BackColor = ColorTranslator.FromHtml("#d9e085")
                        lblCardType(i).Visible = True
                    Case "Intelligence"
                        picCard(i).Image = My.Resources.cardint
                        lblCardValue(i).Text = CType(playerHand(i).Value, String)
                        lblCardValue(i).BackColor = ColorTranslator.FromHtml("#9585e0")
                        lblCardValue(i).Visible = True

                        lblCardPercent(i).Text = playerHand(i).Percent & "%"
                        lblCardPercent(i).BackColor = ColorTranslator.FromHtml("#9585e0")
                        lblCardPercent(i).Visible = True

                        lblCardType(i).Text = playerHand(i).Effect
                        lblCardType(i).BackColor = ColorTranslator.FromHtml("#9585e0")
                        lblCardType(i).Visible = True
                End Select
                i += 1
            Next

            For index As Integer = playerHand.Count To 4
                picCard(index).Image = Nothing
                lblCardValue(index).Visible = False
                lblCardPercent(index).Visible = False
                lblCardType(index).Visible = False
            Next
        End If

        'Script for making the rest of the cards empty.
        'playerHand.Count to 5
        'This for loop will make sure to make the rest of the values empty
    End Sub 'Deletes the card at the given position. Refreshes card images

    Private Sub loadHand()
        'Pulls the hand from the deck while removing the cards that are pulled
        playerHand.Clear()
        For index As Integer = 0 To 4
            drawCard()
        Next
    End Sub 'Loads the players hand with 5 cards

    Private Sub loadDeck()
        'clears the temp deck, then reloads the deck
        If playerTempDeck IsNot Nothing Then
            playerTempDeck.Clear()
        End If
        currentCards = playerDeck.currentCardsInDeck
        For index As Integer = 0 To currentCards - 1
            playerDeck.arrIndex = index
            Dim cardGetter As New card(playerRand)
            cardGetter = playerDeck.getCard
            playerTempDeck.Add(cardGetter)

        Next
    End Sub   'Loads the deck for the player

    Private Sub useClickedCard(num As Integer)
        If playerHand.Count > 0 Then
            clickedCard.newValue = playerHand(num).Value
            clickedCard.newSuit = playerHand(num).Suit
            clickedCard.newPercent = playerHand(num).Percent
            clickedCard.newEffect = playerHand(num).Effect
            clickedCard.cardNum = num

            Select Case clickedCard.newSuit
                Case "Strength"
                    intPlayerAtk = clickedCard.newValue + playerChar.statStr
                Case "Dexterity"
                    intPlayerAtk = clickedCard.newValue + playerChar.statDex
                Case "Constitution"
                    intPlayerAtk = clickedCard.newValue + playerChar.statCon
                Case "Intelligence"
                    intPlayerAtk = clickedCard.newValue + playerChar.statInt
            End Select
        End If
    End Sub 'Pulls data for the card that is clicked

    Private Sub gainExp()
        playerChar.experience += 1
        If playerChar.experience = 0 Then
            Dim blnButtonCheck As Boolean = False
            pbarHP.Value = 100
            pbarHP.Value = 100
            lblHpMaxLabel.Text = CType(playerChar.maxHP, String)
            lblHpCurLabel.Text = CType(playerChar.staminaHP, String)
            lblSpMaxLabel.Text = CType(playerChar.maxSP, String)
            lblSpCurLabel.Text = CType(playerChar.staminaSP, String)
            txtLog.AppendText("You leveled up! Pick a stat to increase!" & Environment.NewLine)
            'do until a key stroke equals S D C or I
            txtLog.AppendText("S for Strength, D for Dexterity, C for Constitution, I for intelligence" & Environment.NewLine)
            blnEnterClicked = False
            Do Until blnButtonCheck = True
                Threading.Thread.Sleep(50)
                Application.DoEvents()
                blnDisableClick = True
                btnClassPow.Enabled = False
                btnDrawCard.Enabled = False
                If strTextEntered = "S" Then
                    playerChar.statStr += 2
                    lblStrNum.Text = CType(playerChar.statStr, String)
                    blnButtonCheck = True
                ElseIf strTextEntered = "D" Then
                    playerChar.statDex += 2
                    lblDexNum.Text = CType(playerChar.statDex, String)
                    blnButtonCheck = True
                ElseIf strTextEntered = "C" Then
                    playerChar.statCon += 2
                    lblConNum.Text = CType(playerChar.statCon, String)
                    blnButtonCheck = True
                ElseIf strTextEntered = "I" Then
                    playerChar.statInt += 2
                    lblIntNum.Text = CType(playerChar.statInt, String)
                    blnButtonCheck = True
                Else

                End If
                strTextEntered = ""
            Loop
            btnClassPow.Enabled = True
            btnDrawCard.Enabled = True
            blnDisableClick = False
            blnEnterClicked = False

        End If
    End Sub

    Private Sub endGame()
        If playerChar.staminaHP = 0 Then
            Dim mboxGameOver As Integer = MessageBox.Show("You died. Start again?", "Card Densetsu", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If mboxGameOver = DialogResult.Yes Then
                loadPlayer()
            ElseIf mboxGameOver = DialogResult.No Then
                Me.Close()
            End If


        End If
    End Sub

    Private Sub btnDrawCard_Click(sender As Object, e As EventArgs) Handles btnDrawCard.Click
        drawCard()
        txtLog.AppendText("You ready your shield, and prepare your next attack." & Environment.NewLine)
        blnPlayerDefend = True
        monsterAttack()
    End Sub

    Private Sub btnClassPow_Click(sender As Object, e As EventArgs) Handles btnClassPow.Click
        If playerChar.staminaSP >= 10 Then
            Dim intResolveSP As Integer
            blnPlayerStrike = True
            btnClassPow.Enabled = False
            playerChar.staminaSP -= 10
            lblSpCurLabel.Text = CType(playerChar.staminaSP, String)
            intResolveSP = CInt((playerChar.staminaSP / playerChar.maxSP) * 100)
            If intResolveSP > 100 Then
                pbarSP.Value = 100
            Else
                pbarSP.Value = intResolveSP
            End If
            txtLog.AppendText("You channel energy into your weapon for the next attack, it will deal double damage." & Environment.NewLine)
        Else
            txtLog.AppendText("Not enough stamina points!" & Environment.NewLine)
        End If
    End Sub

    Public Sub picCard_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim picBox As PictureBox = DirectCast(sender, PictureBox)
        Console.WriteLine("This is working. Index: " & picBox.Name)
        If blnDisableClick = True Or picBox.Image Is Nothing Then
            'do nothing when clicked
            'This prevents the user from using too many cards at once.
        Else
            Select Case picBox.Name
                Case "picCard0"
                    useClickedCard(0)
                Case "picCard1"
                    useClickedCard(1)
                Case "picCard2"
                    useClickedCard(2)
                Case "picCard3"
                    useClickedCard(3)
                Case "picCard4"
                    useClickedCard(4)

            End Select
            playerAttack()
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        strTextEntered = txtUserInput.Text.ToUpper
        txtUserInput.Text = ""
        blnEnterClicked = True


    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        loadPlayer()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("Attack by using cards. Each card color represents a different suit which deals bonus damage based on the stat" & vbNewLine & vbNewLine &
                        "Red is Strength. Yellow is Constitution. Dexterity is Green. Purple is Intelligence" & vbNewLine & vbNewLine &
                        "The defend button will reduce damage from the monsters and draw a card." & vbNewLine & vbNewLine &
                        "Power Strike will double the amount of damage that you deal" & vbNewLine & "(This does not effect drain, poison, healing and energizing effects)",
                        "Card Densetsu: Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
