Public Class creature
    Private _staminaHP As Integer
    Private _maxHP As Integer
    Private _staminaSP As Integer
    Private _maxSP As Integer
    Private _experience As Integer
    Private _expMax As Integer = 1
    Private _statStr As Integer
    Private _statDex As Integer
    Private _statCon As Integer
    Private _statInt As Integer
    Private _level As Integer
    Private _class As String
    Private _effect As String
    Private _effectList As New List(Of String)()

    Public Property maxHP As Integer
        Get
            Return _maxHP
        End Get
        Set(value As Integer)
            _maxHP = value
        End Set
    End Property
    Public Property staminaHP As Integer
        Get
            Return _staminaHP
        End Get
        Set(value As Integer)
            If _staminaHP > _maxHP Then
                _staminaHP = _maxHP
            ElseIf value > 0 Then
                _staminaHP = value
            Else
                _staminaHP = 0
            End If
        End Set
    End Property
    Public Property maxSP As Integer
        Get
            Return _maxSP
        End Get
        Set(value As Integer)
            _maxSP = value
        End Set
    End Property
    Public Property staminaSP As Integer
        Get
            Return _staminaSP
        End Get
        Set(value As Integer)
            If _staminaSP > _maxSP Then
                _staminaSP = _maxSP
            ElseIf value > 0 Then
                _staminaSP = value
            Else
                _staminaSP = 0
            End If
        End Set
    End Property
    Public Property experience As Integer
        Get
            Return _experience
        End Get
        Set(value As Integer)
            _experience = value
            If _experience / _expMax = 1 Then
                _level += 1
                _experience = 0
                _maxHP += 20
                _maxSP += 10
                _staminaHP = _maxHP
                _staminaSP = _maxSP
                _expMax += 1
            End If
        End Set
    End Property

    Public Property maxExp As Integer
        Get
            Return _expMax
        End Get
        Set(value As Integer)
            _expMax = value
        End Set
    End Property

    Public Property statStr As Integer
        Get
            Return _statStr
        End Get
        Set(value As Integer)
            _statStr = value
        End Set
    End Property

    Public Property statDex As Integer
        Get
            Return _statDex
        End Get
        Set(value As Integer)
            _statDex = value
        End Set
    End Property

    Public Property statCon As Integer
        Get
            Return _statCon
        End Get
        Set(value As Integer)
            _statCon = value
        End Set
    End Property

    Public Property statInt As Integer
        Get
            Return _statInt
        End Get
        Set(value As Integer)
            _statInt = value
        End Set
    End Property

    Public Property level As Integer
        Get
            Return _level
        End Get
        Set(value As Integer)
            _level = value
        End Set
    End Property
    Public Property creatureclass As String
        Get
            Return _class
        End Get
        Set(value As String)
            _class = value
        End Set
    End Property
    Public Property effect As String
        Get
            Return _effect
        End Get
        Set(value As String)
            _effect = value
            _effectList.Add(_effect)
        End Set
    End Property
    Public Property listEffects As List(Of String)
        Get
            Return _effectList
        End Get
        Set(value As List(Of String))
            _effectList = value
        End Set
    End Property


End Class
