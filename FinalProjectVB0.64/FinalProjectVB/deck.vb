Option Explicit On
Option Strict On
Option Infer Off

Public Class deck
    Public Structure _cardDeck
        Public cardSuit As String
        Public cardValue As Integer
        Public cardEffect As String
        Public cardPercent As Integer
        Public cardDescription As String
    End Structure

    Private _newCard As card
    Private _drawnCard As card
    Private _arrCardDeck(9) As card
    Private maxDeckSize As Integer
    Private blnDeckSized As Boolean
    Dim numberCard As Integer
    Private _index As Integer
    Private cardIndex As Integer
    Private _newGame As Boolean

    Public Property newGame As Boolean
        Get
            Return _newGame
        End Get
        Set(value As Boolean)
            _newGame = value
            If _newGame = True Then
                numberCard = 0
            End If
            _newGame = False
        End Set
    End Property

    Public ReadOnly Property currentCardsInDeck As Integer
        Get
            Return numberCard

        End Get
    End Property

    Public ReadOnly Property getCard As card
        Get
            Return _arrCardDeck(_index)
        End Get
    End Property

    'Index for arrays
    Public Property arrIndex As Integer
        Get
            Return _index
        End Get
        Set(value As Integer)
            _index = value
        End Set
    End Property

    Public Property arrCardDeck As card()
        Get
            Return _arrCardDeck
        End Get
        Set(value As card())
            _arrCardDeck = value
        End Set
    End Property

    Public WriteOnly Property maximumCards As Integer
        'Take a value for deck size, then make this function unavailable
        'May remove in final product.
        Set(value As Integer)
            maxDeckSize = value
            ReDim _arrCardDeck(maxDeckSize)
            blnDeckSized = True
        End Set
    End Property

    Public Property newCard As card
        Get
            Return _newCard
        End Get
        Set(value As card)
            'Checks if the deck is full, if it is not then store a card into the deck.
            If numberCard <= maxDeckSize Then
                _newCard = value
                addToDeck()
            End If

        End Set
    End Property

    Private Sub addToDeck()
        'Stores the card into an array, then increases the numberCard by 1
        'The increase of the variable prevents the new card from overwriting other cards in the array.
        _arrCardDeck(numberCard) = _newCard
        numberCard += 1
    End Sub

    Public Sub New()

    End Sub
End Class
