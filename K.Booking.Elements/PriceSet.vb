Public Class PriceSet
    Private mIntID As Integer
    Private mDatValidFrom As DateTime

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
    Public Property ValidFrom() As DateTime
        Get
            Return mDatValidFrom
        End Get
        Set(ByVal Value As DateTime)
            mDatValidFrom = Value
        End Set
    End Property
    Public ReadOnly Property DisplayMember() As String
        Get
            Return "Priser gyldige fra " & ValidFrom
        End Get
    End Property
#End Region

    Public Function GetPriceSets() As DataSet
        Dim strSQL As String

        strSQL = "SELECT * FROM K_PriceSet " & _
        "ORDER BY K_PriceSetValidFrom DESC;"

        Return mObjAccess.getDataset(strSQL)
    End Function

    Public Function FetchNewPriceSet() As Boolean
        Dim strSQL As String
        Dim objDataset As DataSet

        strSQL = "SELECT * FROM K_PriceSet " & _
        "WHERE K_PriceSetID NOT IN " & _
        "(SELECT K_PriceSetID FROM K_Price) " & _
        "ORDER BY K_PriceSetValidFrom"

        objDataset = mObjAccess.getDataset(strSQL)
        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
            Return True
        Else
            Return False
        End If
    End Function

    Public Function FetchValidPriceSet(ByVal datValidDate As DateTime) As Boolean
        Dim strSQL As String
        Dim objDataset As DataSet

        strSQL = "SELECT TOP 1 * FROM K_PriceSet " & _
        "WHERE K_PriceSetValidFrom <= #" & Format(datValidDate, Data.Misc.DataBaseDateFormat) & "# " & _
        "ORDER BY K_PriceSetValidFrom DESC "

        objDataset = mObjAccess.getDataset(strSQL)
        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ListInArray(Optional ByVal strSQL As String = "") As ArrayList
        Dim objDataset As New DataSet
        Dim objArray As New ArrayList

        objDataset = GetPriceSets()

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            Dim objPriceSet As New PriceSet
            objPriceSet.FetchFromRow(objRow)
            objArray.Add(objPriceSet)
        Next

        Return objArray
    End Function

    Public Sub FetchFromRow(ByVal objRow As DataRow)
        mIntID = Data.Misc.ConvertToInt(objRow.Item("K_PriceSetID"))
        mDatValidFrom = Data.Misc.ConvertToDateTime(objRow.Item("K_PriceSetValidFrom"))
    End Sub

    Private Function SavePriceSetSQL() As String
        Dim strSQL As String
        'always save new set
        strSQL = "INSERT INTO K_PriceSet " & _
        "(K_PriceSetValidFrom) VALUES " & _
        "(#" & Format(mDatValidFrom, Data.Misc.DataBaseDateFormat) & "#)"
        Return strSQL
    End Function

    Public Function Save() As Integer
        Return mObjAccess.Save(SavePriceSetSQL)
    End Function

    Private Sub Reset()
        mIntID = 0
        mDatValidFrom = Data.Misc.DefaultDate
    End Sub
End Class
