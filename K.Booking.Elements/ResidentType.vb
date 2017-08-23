Public Class ResidentType


    Private mIntID As Integer

    Private mIntNumberOfGuests As Integer
    Private mIntType As Integer
    Private mDatTypeFromDate As DateTime
    Private mIntResidentID As Integer

    Private mDatCreatedDate As DateTime
    Private mDatUpdatedDate As DateTime
    Private mIntUpdatedBy As Integer
    Private mIntCreatedBy As Integer

    Private mIntStatus As Integer

    Private mIntActive As Integer

    Private mObjAccess As Data.Access

    Public Sub New()
        Reset()
        mObjAccess = New Data.Access
    End Sub

    Public Sub New(ByVal intResidentID As Integer)
        Reset()
        mObjAccess = New Data.Access

        Dim objDataset As DataSet
        objDataset = GetActive(intResidentID)
        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
        End If
    End Sub

#Region " Properties "
    Public Property ID() As Integer
        Get
            Return mIntID
        End Get
        Set(ByVal Value As Integer)
            mIntID = Value
        End Set
    End Property
    Public Property NumberOfGuests() As Integer
        Get
            Return mIntNumberOfGuests
        End Get
        Set(ByVal Value As Integer)
            mIntNumberOfGuests = Value
        End Set
    End Property
    Public Property Type() As Integer
        Get
            Return mIntType
        End Get
        Set(ByVal Value As Integer)
            mIntType = Value
        End Set
    End Property
    Public Property TypeFrom() As DateTime
        Get
            Return mDatTypeFromDate
        End Get
        Set(ByVal Value As DateTime)
            mDatTypeFromDate = Value
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
    Public Property CreatedDate() As DateTime
        Get
            Return mDatCreatedDate
        End Get
        Set(ByVal Value As DateTime)
            mDatCreatedDate = Value
        End Set
    End Property
    Public Property UpdatedDate() As DateTime
        Get
            Return mDatUpdatedDate
        End Get
        Set(ByVal Value As DateTime)
            mDatUpdatedDate = Value
        End Set
    End Property
    Public Property CreatedBy() As Integer
        Get
            Return mIntCreatedBy
        End Get
        Set(ByVal Value As Integer)
            mIntCreatedBy = Value
        End Set
    End Property
    Public Property UpdatedBy() As Integer
        Get
            Return mIntUpdatedBy
        End Get
        Set(ByVal Value As Integer)
            mIntUpdatedBy = Value
        End Set
    End Property
    Public Property Status() As Integer
        Get
            Return mIntStatus
        End Get
        Set(ByVal Value As Integer)
            mIntStatus = Value
        End Set
    End Property
    Public Property Active() As Integer
        Get
            Return mIntActive
        End Get
        Set(ByVal value As Integer)
            mIntActive = value
        End Set
    End Property
#End Region

#Region " DataAccess "
    Public Function List(ByVal intResidentID As Integer, Optional ByVal strSQL As String = "") As DataSet
        Dim objDataset As New DataSet
        If strSQL = String.Empty Then
            strSQL = "SELECT * FROM K_ResidentType " & _
            "WHERE K_ResidentID = " & intResidentID & " " & _
            "AND K_ResidentTypeFromDate <= #" & Format(Now, Data.Misc.DataBaseDateFormat) & "# " & _
            "ORDER BY K_ResidentTypeFromDate DESC"
        End If
        objDataset = mObjAccess.getDataset(strSQL)
        Return objDataset
    End Function

    Public Function GetActive(ByVal iResidentID As Integer) As DataSet
        Dim strSQL As String
        Dim objDataset As New DataSet
        strSQL = "SELECT * FROM K_ResidentType " & _
            "WHERE K_ResidentID = " & iResidentID & " " & _
            "AND K_ResidentTypeActive = 1 " & _
            "AND K_ResidentTypeFromDate <= #" & Format(Now, Data.Misc.DataBaseDateFormat) & "# " & _
            "ORDER BY K_ResidentTypeFromDate DESC"
        objDataset = mObjAccess.getDataset(strSQL)
        Return objDataset
    End Function

    Public Function ListUnHandled(ByVal intResidentID As Integer) As DataSet
        Dim objDataset As New DataSet
        Dim strSQL As String
        'strSQL = "SELECT DISTINCT K_ResidentID, K_ResidentType, K_ResidentNumberOfGuests, K_ResidentTypeFromDate, K_ResidentCreatedDate, K_ResidentCreatedBy, K_ResidentTypeStatus FROM K_ResidentType " & _
        strSQL = "SELECT * FROM K_ResidentType " & _
        "WHERE K_ResidentID = " & intResidentID & " " & _
        "AND K_ResidentTypeStatus = 1 " & _
        "ORDER BY K_ResidentTypeFromDate DESC"
        objDataset = mObjAccess.getDataset(strSQL)
        Return objDataset
    End Function

    Public Function Fetch(ByVal intID As Integer) As Boolean
        Dim objDataset As DataSet
        objDataset = mObjAccess.getDataset("SELECT * FROM K_ResidentType WHERE K_ResidentTypeID = " & intID)

        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
        End If
    End Function

    Public Function ListInArray(Optional ByVal strSQL As String = "") As ArrayList
        Dim objDataset As New DataSet
        Dim objArray As New ArrayList

        objDataset = List(strSQL)

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            Me.FetchFromRow(objRow)
            objArray.Add(Me)
        Next

        Return objArray
    End Function

    Public Sub SetHandled(ByVal intID As Integer)
        Dim strSQL As String
        strSQL = "UPDATE K_ResidentType " & _
        "SET K_ResidentTypeStatus = -1 " & _
        "WHERE K_ResidentTypeID = " & intID
        mObjAccess.Save(strSQL)
    End Sub

    Public Function SaveResidentTypeSQL() As Integer
        Dim strSQL As String
        strSQL = "UPDATE K_ResidentType SET K_ResidentTypeActive = 0 WHERE K_ResidentID = " & mIntResidentID
        mObjAccess.Save(strSQL)

        strSQL = ""
        'If mIntID = 0 Then
        strSQL = "INSERT INTO K_ResidentType (" & _
        "K_ResidentID, " & _
        "K_ResidentType, " & _
        "K_ResidentNumberOfGuests, " & _
        "K_ResidentTypeFromDate, " & _
        "K_ResidentCreatedDate, " & _
        "K_ResidentUpdatedDate, " & _
        "K_ResidentCreatedBy, " & _
        "K_ResidentUpdatedBy, " & _
        "K_ResidentTypeActive, " & _
        "K_ResidentTypeStatus ) " & _
        "VALUES ( " & _
        "" & mIntResidentID & ", " & _
        "" & mIntType & ", " & _
        "" & mIntNumberOfGuests & ", " & _
        "#" & Format(mDatTypeFromDate, Data.Misc.DataBaseDateFormat) & "# ," & _
        "#" & Format(mDatCreatedDate, Data.Misc.DataBaseDateFormat) & "# , " & _
        "#" & Format(mDatUpdatedDate, Data.Misc.DataBaseDateFormat) & "#, " & _
        "" & mIntCreatedBy & ", " & _
        "" & mIntUpdatedBy & ", " & _
        "" & mIntActive & ", " & _
        "" & mIntStatus & ");"
        'Else
        '    strSQL = "UPDATE K_ResidentType SET " & _
        '    "K_ResidentNumberOfGuests = " & mIntNumberOfGuests & ", " & _
        '    "K_ResidentType = " & mIntType & ", " & _
        '    "K_ResidentUpdatedDate = #" & Format(mDatUpdatedDate, Data.Misc.DataBaseDateFormat) & "#, " & _
        '    "K_ResidentUpdatedBy = " & mIntUpdatedBy & ", " & _
        '    "K_ResidentTypeStatus = " & mIntStatus & " " & _
        '    "K_ResidentTypeActive = " & mIntActive & " " & _
        '    "WHERE K_ResidentTypeID = " & mIntID & ";"
        'End If
        Return mObjAccess.Save(strSQL)
    End Function

    Public Sub FetchFromRow(ByVal objRow As DataRow)
        mIntID = Data.Misc.ConvertToInt(objRow.Item("K_ResidentTypeID"))
        mIntResidentID = Data.Misc.ConvertToInt(objRow.Item("K_ResidentID"))
        mIntNumberOfGuests = Data.Misc.ConvertToInt(objRow.Item("K_ResidentNumberOfGuests"))
        mIntType = Data.Misc.ConvertToInt(objRow.Item("K_ResidentType"))
        mDatTypeFromDate = Data.Misc.ConvertToDateTime(objRow.Item("K_ResidentTypeFromDate"))
        mDatCreatedDate = Data.Misc.ConvertToDateTime(objRow.Item("K_ResidentCreatedDate"))
        mDatUpdatedDate = Data.Misc.ConvertToDateTime(objRow.Item("K_ResidentUpdatedDate"))
        mIntCreatedBy = Data.Misc.ConvertToInt(objRow.Item("K_ResidentCreatedBy"))
        mIntUpdatedBy = Data.Misc.ConvertToInt(objRow.Item("K_ResidentUpdatedBy"))
        mIntStatus = Data.Misc.ConvertToInt(objRow.Item("K_ResidentTypeStatus"))
        mIntActive = Data.Misc.ConvertToInt(objRow.Item("K_ResidentTypeActive"))
    End Sub

    Public Sub Reset()
        mIntID = 0
        mIntResidentID = 0
        mIntNumberOfGuests = 0
        mIntType = Data.GlobalEnums.ResidentType.Undecided
        mDatCreatedDate = Data.Misc.DefaultDate
        mDatUpdatedDate = Data.Misc.DefaultDate
        mIntCreatedBy = 0
        mIntUpdatedBy = 0
        mIntStatus = 1
    End Sub
#End Region
End Class
