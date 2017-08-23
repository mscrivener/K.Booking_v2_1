Public Class FoodStamp
    Private mValidFrom As DateTime
    Private mValidTo As DateTime

    Private mValue As Double

    Public Sub New(ByVal dValidFrom As DateTime, ByVal dValidTo As DateTime, ByVal dValue As Double)
        ValidFrom = dValidFrom
        ValidTo = dValidTo
        Value = dValue
    End Sub

    Public Property ValidFrom() As DateTime
        Get
            Return mValidFrom
        End Get
        Set(ByVal value As DateTime)
            mValidFrom = value
        End Set
    End Property

    Public Property ValidTo() As DateTime
        Get
            Return mValidTo
        End Get
        Set(ByVal value As DateTime)
            mValidTo = value
        End Set
    End Property

    Public Property Value() As Double
        Get
            Return mValue
        End Get
        Set(ByVal value As Double)
            mValue = value
        End Set
    End Property
End Class
