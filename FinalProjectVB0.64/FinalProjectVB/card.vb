Option Explicit On
Option Strict On
Option Infer Off

Public Class card
    Private RandGen As New Random(TimeOfDay.Millisecond)
    Private _cardSuit As String
    Private _cardValue As Integer
    Private _cardEffect As String
    Private _cardPercent As Integer
    Private _cardDescription As String
    Private strSuit As String

    Public Structure EffectDesc
        Public strucEffect As String
        Public strucDesc As String
        Public strucPercent As Integer
    End Structure


    Public arrCardType(9) As EffectDesc


    Public Property Suit As String
        Get
            Return _cardSuit
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Value As Integer

        Get
            Return _cardValue
        End Get
        Set(value As Integer)
            _cardValue = value
        End Set
    End Property

    Public Property Effect As String
        Get
            Return _cardEffect
        End Get
        Set(value As String)
            _cardEffect = value
        End Set
    End Property

    Public Property Percent As Integer
        Get
            Return _cardPercent
        End Get
        Set(value As Integer)
            _cardPercent = value
        End Set

    End Property

    Public ReadOnly Property Description As String
        Get
            Return _cardDescription
        End Get
    End Property

    Private Function getDesc(number As Integer, rng As Random) As EffectDesc

        Dim intPercent As Integer

        intPercent = rng.Next(1, 101)
        arrCardType(number).strucPercent = intPercent

        arrCardType(0).strucEffect = "Drain"
        arrCardType(1).strucEffect = "Poison"
        arrCardType(2).strucEffect = "Stun"
        arrCardType(3).strucEffect = "Sleep"
        arrCardType(4).strucEffect = "Weaken"
        arrCardType(5).strucEffect = "Stupify"
        arrCardType(6).strucEffect = "Slow"
        arrCardType(7).strucEffect = "Cripple"
        arrCardType(8).strucEffect = "Heal"
        arrCardType(9).strucEffect = "Energize"

        arrCardType(0).strucDesc = "When your character deals damage, half damage dealt is restored as HP"
        arrCardType(1).strucDesc = intPercent & "% chance to poison target, target takes 10% damage per turn"
        arrCardType(2).strucDesc = intPercent & "% chance to stun. stunned targets cannot act next turn"
        arrCardType(3).strucDesc = intPercent & "% chance to sleep. When target is sleeping, will not act until they wake up."
        arrCardType(4).strucDesc = intPercent & "% chance to weaken. Halves strength stat for three turns."
        arrCardType(5).strucDesc = intPercent & "% chance to stupify. Halves intelligence stat for three turns."
        arrCardType(6).strucDesc = intPercent & "% chance to slow. Halves strength stat for three turns."
        arrCardType(7).strucDesc = intPercent & "% chance to cripple. Halves intelligence stat for three turns."
        arrCardType(8).strucDesc = "Heals HP equal to double the value of the card"
        arrCardType(9).strucDesc = "Heals MP equal to double the value of the card"

        Return arrCardType(number)
    End Function



    Public Sub New(ByRef rng As Random)
        'Randomized integers that choose effects on card

        Dim intSuit As Integer
        Dim intValue As Integer
        Dim intDescEffect As Integer
        'Picks suit 

        'intSuit = RandGen.Next(1, 5)/m
        intSuit = rng.Next(1, 5)

        intValue = rng.Next(1, 16)
        intDescEffect = rng.Next(0, 10)

        Select Case intSuit
            Case 1
                _cardSuit = "Strength"
            Case 2
                _cardSuit = "Dexterity"
            Case 3
                _cardSuit = "Constitution"
            Case 4
                _cardSuit = "Intelligence"
        End Select

        _cardValue = intValue

        _cardEffect = getDesc(intDescEffect, rng).strucEffect

        Select Case getDesc(intDescEffect, rng).strucEffect
            Case "Drain"
                _cardPercent = 100
            Case "Heal"
                _cardPercent = 100
            Case "Energize"
                _cardPercent = 100
            Case Else
                _cardPercent = getDesc(intDescEffect, rng).strucPercent
        End Select

        _cardDescription = getDesc(intDescEffect, rng).strucDesc

    End Sub
End Class
