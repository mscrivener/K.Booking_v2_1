Public Class ResidentInBed

    Private mIntID As Integer
    Private mIntResidentID As Integer
    Private mIntBedID As Integer
    Private mDatFromDate As DateTime
    Private mDatToDate As DateTime

    Private mStrBedDescription As String
    Private mStrRoomDescription As String

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

    Public Property BedID() As Integer
        Get
            Return mIntBedID
        End Get
        Set(ByVal Value As Integer)
            mIntBedID = Value
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
    Public Property RoomDescription() As String
        Get
            Return mStrRoomDescription
        End Get
        Set(ByVal Value As String)
            mStrRoomDescription = Value
        End Set
    End Property
    Public Property BedDescription() As String
        Get
            Return mStrBedDescription
        End Get
        Set(ByVal Value As String)
            mStrBedDescription = Value
        End Set
    End Property
    Public ReadOnly Property DisplayMember() As String
        Get
            Return Format(FromDate, "dd-MM-yyyy") & " - " & Format(ToDate, "dd-MM-yyyy") & ": " & RoomDescription & BedDescription
        End Get
    End Property
#End Region

    Public Function ListInArray(Optional ByVal intResidentID As Integer = 0, Optional ByVal strSQL As String = "") As ArrayList
        Dim objDataset As New DataSet
        Dim objArray As New ArrayList

        objDataset = List(intResidentID, strSQL)

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            Dim objResidentInBed As New ResidentInBed
            objResidentInBed.FetchFromRow(objRow)
            objArray.Add(objResidentInBed)
        Next

        Return objArray
    End Function

    Public Function List(Optional ByVal intResidentID As Integer = 0, Optional ByVal strSQL As String = "") As DataSet
        Dim objDataset As New DataSet

        If strSQL = "" Then
            strSQL = "SELECT * FROM K_ResidentInBed AS R, K_Bed AS B, K_Room AS RO " & _
            "WHERE R.K_BedID = B.K_BedID " & _
            "AND B.K_RoomID = RO.K_RoomID " & _
            "AND K_ResidentID = " & intResidentID & " " & _
            "ORDER BY K_ResidentInBedFromDate DESC;"
        End If

        objDataset = mObjAccess.getDataset(strSQL)
        Return objDataset
    End Function

    Public Function Delete(ByVal intID As Integer) As Integer
        Dim strSQL As String
        strSQL = "DELETE FROM K_ResidentInBed WHERE K_ResidentInBedID = " & intID
        Return mObjAccess.Delete(strSQL)
    End Function

    Public Function DeleteForResident(ByVal intResidentID As Integer) As Integer
        Dim strSQL As String
        strSQL = "DELETE FROM K_ResidentInBed WHERE K_ResidentID = " & intResidentID
        Return mObjAccess.Delete(strSQL)
    End Function

    Public Function GetCurrentBed(ByVal iResidentID As Integer) As String
        Dim strReturn As String = " - "
        Dim strSQL As String
        strSQL = "SELECT * FROM K_Room, K_Bed, K_ResidentInBed " & _
        "WHERE K_Room.K_RoomID = K_Bed.K_RoomID " & _
        "AND K_Bed.K_BedID = K_ResidentInBed.K_BedID " & _
        "AND K_ResidentInBed.K_ResidentID = " & iResidentID & " " & _
        "AND K_ResidentInBed.K_ResidentInBedFromDate <= #" & Format(Now, Data.Misc.DataBaseDateFormat) & "# " & _
        "AND K_ResidentInBed.K_ResidentInBedToDate > #" & Format(Now, Data.Misc.DataBaseDateFormat) & "#"

        Dim objDataset As DataSet = mObjAccess.getDataset(strSQL)
        If objDataset.Tables(0).Rows.Count > 0 Then
            Dim objRow As DataRow = objDataset.Tables(0).Rows(0)
            If CInt(objRow("K_RoomType")) = Data.GlobalEnums.RoomType.Appartement Then
                strReturn = objRow("K_RoomDescription")
            Else
                strReturn = objRow("K_RoomDescription") & objRow("K_BedDescription")
            End If
        End If
        Return strReturn
    End Function

    Public Function CheckOccupied() As DataSet
        Dim strSQL As String
        strSQL = "SELECT R.*, B.*, RO.*, RE.*, U1.K_UserFullName AS U1Name, U2.K_UserFullName AS U2Name FROM K_ResidentInBed AS R, K_Bed AS B, K_Room AS RO, K_Resident AS RE, K_User U1, K_User U2 " & _
            "WHERE R.K_BedID = B.K_BedID " & _
            "AND B.K_RoomID = RO.K_RoomID " & _
            "AND RE.K_ResidentID = R.K_ResidentID " & _
            "AND R.K_BedID = " & BedID & " " & _
            "AND U1.K_UserID = RE.K_ResidentCreatedBy AND U2.K_UserID = RE.K_ResidentUpdatedBy "
        If mIntID > 0 Then
            strSQL &= "AND R.K_ResidentInBedID <> " & mIntID & " "
        End If
        'strSQL &= "AND ((K_ResidentInBedFromDate <= #" & Format(FromDate, Data.Misc.DataBaseDateFormat) & "# AND K_ResidentInBedToDate > #" & Format(FromDate, Data.Misc.DataBaseDateFormat) & "#) " & _
        '   "OR (K_ResidentInBedFromdate <= #" & Format(ToDate, Data.Misc.DataBaseDateFormat) & "# AND K_ResidentInBedToDate > #" & Format(ToDate, Data.Misc.DataBaseDateFormat) & "#)) " & _
        '   "ORDER BY K_ResidentInBedFromDate;"
        strSQL &= "AND (K_ResidentInBedFromDate <= #" & Format(FromDate, Data.Misc.DataBaseDateFormat) & "# AND K_ResidentInBedToDate > #" & Format(ToDate, Data.Misc.DataBaseDateFormat) & "#) " & _
            "ORDER BY K_ResidentInBedFromDate;"
        Return mObjAccess.getDataset(strSQL)
    End Function

    Public Sub UpdateArrival(ByVal iResidentID As Integer, ByVal dOldArrival As DateTime, ByVal dNewArrival As DateTime)
        Dim sSQL As String = "UPDATE K_ResidentInBed SET K_ResidentInBedFromDate = #" & Format(dNewArrival, Data.Misc.DataBaseDateFormat) & "# " & _
        "WHERE K_ResidentID = " & iResidentID & " AND K_ResidentInBedFromDate = #" & Format(dOldArrival, Data.Misc.DataBaseDateFormat) & "#"

        mObjAccess.Save(sSQL)
    End Sub

    Public Sub UpdateDeparture(ByVal iResidentID As Integer, ByVal dOldDeparture As DateTime, ByVal dNewDeparture As DateTime)
        'update date on bed resident is staying in at time of departure 
        Dim sSQL As String = "UPDATE K_ResidentInBed SET K_ResidentInBedToDate = #" & Format(dNewDeparture, Data.Misc.DataBaseDateFormat) & "# " & _
        "WHERE K_ResidentID = " & iResidentID & " AND K_ResidentInBedToDate = #" & Format(dOldDeparture, Data.Misc.DataBaseDateFormat) & "#"
        mObjAccess.Save(sSQL)

        'and remove any future beds
        sSQL = "DELETE FROM K_ResidentInBed " & _
        "WHERE K_ResidentID = " & iResidentID & " AND K_ResidentInBedFromDate > #" & Format(dOldDeparture, Data.Misc.DataBaseDateFormat) & "#;"

        mObjAccess.Save(sSQL)
    End Sub

    Private Function SaveResidentInBedSQL() As String
        Dim strSQL As String
        If mIntID = 0 Then 'new residentinbed
            strSQL = "INSERT INTO K_ResidentInBed " & _
            "(K_BedID, " & _
            "K_ResidentInBedFromDate, " & _
            "K_ResidentInBedToDate, " & _
            "K_ResidentID )" & _
            "VALUES(" & mIntBedID & ", " & _
            "#" & Format(mDatFromDate, Data.Misc.DataBaseDateFormat) & "#, " & _
            "#" & Format(mDatToDate, Data.Misc.DataBaseDateFormat) & "#, " & _
            "" & mIntResidentID & ")"
        Else
            strSQL = "UPDATE K_ResidentInBed " & _
            "SET K_BedID = " & mIntBedID & ", " & _
            "K_ResidentID = " & mIntResidentID & ", " & _
            "K_ResidentInBedFromDate = #" & Format(mDatFromDate, Data.Misc.DataBaseDateFormat) & "#, " & _
            "K_ResidentInBedToDate = #" & Format(mDatToDate, Data.Misc.DataBaseDateFormat) & "# " & _
            "WHERE K_ResidentInBedID = " & mIntID
        End If
        Return strSQL
    End Function

    Public Function Save() As Integer
        Return mObjAccess.Save(SaveResidentInBedSQL)
    End Function

    Public Function Fetch(ByVal intID As Integer) As Boolean
        Dim objDataset As DataSet
        Dim strSQL As String

        strSQL = "SELECT * FROM K_ResidentInBed AS R " & _
            "INNER JOIN K_Bed AS B ON R.K_BedID = B.K_BedID " & _
            "INNER JOIN K_Room AS RO ON B.K_RoomID = RO.K_RoomID " & _
            "WHERE K_ResidentInBedID = " & intID

        objDataset = mObjAccess.getDataset(strSQL)

        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
        End If
    End Function

    Public Sub FetchFromRow(ByVal objRow As DataRow)
        ID = Data.Misc.ConvertToInt(objRow.Item("K_ResidentInBedID"))
        BedDescription = Data.Misc.ConvertToString(objRow.Item("K_BedDescription"))
        BedID = Data.Misc.ConvertToInt(objRow.Item("K_BedID"))
        ResidentID = Data.Misc.ConvertToInt(objRow.Item("K_ResidentID"))
        RoomDescription = Data.Misc.ConvertToString(objRow.Item("K_RoomDescription"))
        FromDate = Data.Misc.ConvertToDateTime(objRow.Item("K_ResidentInBedFromDate"))
        ToDate = Data.Misc.ConvertToDateTime(objRow.Item("K_ResidentInBedToDate"))
    End Sub

    Public Sub Reset()
        mIntID = 0
        mStrBedDescription = ""
        mStrRoomDescription = ""
        mIntBedID = 0
        mIntResidentID = 0
        mDatFromDate = Data.Misc.DefaultDate
        mDatToDate = Data.Misc.DefaultDate
    End Sub
End Class
