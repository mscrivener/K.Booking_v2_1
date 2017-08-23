Public Class Price
    Private mIntID As Integer
    Private mStrDescription As String
    Private mDblAmount As Double
    Private mIntSetID As Integer

    Private mObjAccess As Data.Access

    Public Sub New()
        Reset()
        mObjAccess = New Data.Access
    End Sub

#Region "properties"
    Public Property ID() As Integer
        Get
            Return mIntID
        End Get
        Set(ByVal Value As Integer)
            mIntID = Value
        End Set
    End Property
    Public Property Description() As String
        Get
            Return mStrDescription
        End Get
        Set(ByVal Value As String)
            mStrDescription = Value
        End Set
    End Property
    Public Property Amount() As Double
        Get
            Return mDblAmount
        End Get
        Set(ByVal Value As Double)
            mDblAmount = Value
        End Set
    End Property
    Public Property SetID() As Integer
        Get
            Return mIntSetID
        End Get
        Set(ByVal Value As Integer)
            mIntSetID = Value
        End Set
    End Property
#End Region

    Public Function GetPriceDescriptions() As DataSet
        Dim strSQL As String

        strSQL = "SELECT * FROM K_PriceDescription"

        Return mObjAccess.getDataset(strSQL)
    End Function

    Public Function GetPrices(ByVal intPriceSetID As Integer) As DataSet
        Dim strSQL As String

        strSQL = "SELECT " & _
        "D.K_PriceDescriptionID, D.K_PriceDescription, P.K_PriceSetID, P.K_PriceAmount " & _
        "FROM K_Price AS P " & _
        "INNER JOIN K_PriceDescription AS D ON D.K_PriceDescriptionID = P.K_PriceDescriptionID " & _
        "WHERE P.K_PriceSetID = " & intPriceSetID & " " & _
        "ORDER BY P.K_PriceDescriptionID;"

        Return mObjAccess.getDataset(strSQL)
    End Function

    Public Sub SavePrices(ByVal arrPrices As ArrayList)
        mObjAccess.SaveFromArray(arrPrices)
    End Sub

    Public Sub FetchFromRow(ByVal objRow As DataRow)
        mIntID = Data.Misc.ConvertToInt(objRow("K_PriceDescriptionID"))
        mStrDescription = Data.Misc.ConvertToString(objRow("K_PriceDescription"))
        mIntSetID = Data.Misc.ConvertToInt(objRow("K_PriceSetID"))
        mDblAmount = Data.Misc.ConvertToDouble(objRow("K_PriceAmount"))
    End Sub

    Public Function GetFoodstampPrice(ByVal datFrom As DateTime) As Double
        Dim strSQL As String = "SELECT K_PriceAmount FROM K_Price INNER JOIN K_PriceSet ON K_PriceSet.K_PriceSetID = K_Price.K_PriceSetID WHERE K_PriceDescriptionID = " & Data.GlobalEnums.PriceDesctiption.FoodTicket & " AND K_PriceSet.K_PriceSetValidFrom < #" & Format(datFrom, Data.Misc.DataBaseDateFormat) & "# ORDER BY K_PriceSet.K_PriceSetValidFrom DESC"
        Dim objDataset As DataSet = mObjAccess.getDataset(strSQL)
        If objDataset.Tables(0).Rows.Count > 0 Then
            Return Data.Misc.ConvertToDouble(objDataset.Tables(0).Rows(0)("K_PriceAmount"))
        End If
        Return 0
    End Function

    Private Function SavePriceSQL() As String
        Dim strSQL As String

        strSQL = "INSERT INTO K_Price " & _
        "(K_PriceAmount, K_PriceSetID, K_PriceDescriptionID) " & _
        "VALUES " & _
        "(" & mDblAmount & ", " & mIntSetID & ", " & mIntID & ")"
        Return strSQL
    End Function

    Public Function Save() As Integer
        Return mObjAccess.Save(SavePriceSQL)
    End Function

    Private Sub Reset()
        mIntID = 0
        mIntSetID = 0
        mDblAmount = 0
        mStrDescription = ""
    End Sub
End Class
