Public Class clsSplicerConfigure
    Private _seq As Integer
    Private _name As String
    Private _fiber As String
    Private _program As Integer
    Private _maxloss As Double

    Public Property seq() As Integer
        Get
            Return _seq
        End Get
        Set(ByVal value As Integer)
            _seq = value
        End Set
    End Property

    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property fiber() As String
        Get
            Return _fiber
        End Get
        Set(ByVal value As String)
            _fiber = value
        End Set
    End Property

    Public Property program() As Integer
        Get
            Return _program
        End Get
        Set(ByVal value As Integer)
            _program = value
        End Set
    End Property

    Public Property maxLoss() As Double
        Get
            Return _maxloss
        End Get
        Set(ByVal value As Double)
            _maxloss = value
        End Set
    End Property

End Class
