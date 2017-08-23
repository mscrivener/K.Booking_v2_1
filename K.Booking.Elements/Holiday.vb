Public Class Holiday

    Private mIntID As Integer
    Private mIntResidentID As Integer
    Private mDatFromDate As DateTime
    Private mDatToDate As DateTime
    
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

    Public Property ResidentID() As Integer
        Get
            Return mIntResidentID
        End Get
        Set(ByVal Value As Integer)
            mIntResidentID = Value
        End Set
    End Property

    Public Property FromDate() As DateTime
        Get
            Return mDatFromDate
        End Get
        Set(ByVal Value As DateTime)
            mDatFromDate = Value
        End Set
    End Property

    Public Property ToDate() As DateTime
        Get
            Return mDatToDate
        End Get
        Set(ByVal Value As DateTime)
            mDatToDate = Value
        End Set
    End Property

    Public ReadOnly Property DisplayMember() As String
        Get
            Return Format(FromDate, "dd-MM-yyyy") & " - " & Format(ToDate, "dd-MM-yyyy")
        End Get
    End Property
#End Region

    Public Function ListInArray(Optional ByVal strSQL As String = "") As ArrayList
        Dim objDataset As New DataSet
        Dim objArray As New ArrayList

        objDataset = List(strSQL)

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            Dim objHoliday As New Holiday
            objHoliday.FetchFromRow(objRow)
            objArray.Add(objHoliday)
        Next

        Return objArray
    End Function

    Public Function List(Optional ByVal strSQL As String = "") As DataSet
        Dim objDataset As New DataSet
        If Not strSQL = "" Then
            objDataset = mObjAccess.getDataset(strSQL)
        Else
            objDataset = mObjAccess.getDataset("SELECT * FROM K_Holiday")
        End If
        Return objDataset
    End Function

    Private Function SaveHolidaySQL() As String
        Dim strSQL As String
        If mIntID = 0 Then 'new bed
            strSQL = "INSERT INTO K_Holiday " & _
            "(K_ResidentID, " & _
            "K_HolidayFromDate, " & _
            "K_HolidayToDate)" & _
            "VALUES(" & mIntResidentID & ", " & _
            "#" & Format(mDatFromDate, Data.Misc.DataBaseDateFormat) & "#, " & _
            "#" & Format(mDatToDate, Data.Misc.DataBaseDateFormat) & "#)"
        Else
            strSQL = "UPDATE K_Holiday " & _
            "SET K_ResidentID = " & mIntResidentID & ", " & _
            "K_HolidayFromDate = #" & Format(mDatFromDate, Data.Misc.DataBaseDateFormat) & "#, " & _
            "K_HolidayToDate = #" & Format(mDatToDate, Data.Misc.DataBaseDateFormat) & "# " & _
            "WHERE K_HolidayID = " & mIntID
        End If
        Return strSQL
    End Function

    Public Function Save() As Integer
        Return mObjAccess.Save(SaveHolidaySQL)
    End Function

    Public Function Delete() As Integer
        Return mObjAccess.Delete("DELETE FROM K_Holiday WHERE K_HolidayID = " & mIntID)
    End Function

    Public Function Fetch(ByVal intID As Integer) As Boolean
        Dim objDataset As DataSet
        objDataset = mObjAccess.getDataset("SELECT * FROM K_Holiday WHERE K_HolidayID = " & intID)

        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
        End If
    End Function

    Private Sub FetchFromRow(ByVal objRow As DataRow)
        ID = Data.Misc.ConvertToInt(objRow.Item("K_HolidayID"))
        ResidentID = Data.Misc.ConvertToInt(objRow.Item("K_ResidentID"))
        FromDate = Data.Misc.ConvertToDateTime(objRow.Item("K_HolidayFromDate"))
        ToDate = Data.Misc.ConvertToDateTime(objRow.Item("K_HolidayToDate"))
    End Sub

    Public Sub Reset()
        mIntID = 0
        mIntResidentID = 0
        mDatFromDate = Data.Misc.DefaultDate
        mDatToDate = Data.Misc.DefaultDate
    End Sub
End Class
