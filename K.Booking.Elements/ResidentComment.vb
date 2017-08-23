Public Class ResidentComment

    Private mIntID As Integer

    Private mBooSpecialAttention As Boolean
    Private mStrComment As String
    Private mIntResidentID As Integer

    Private mDatCreatedDate As DateTime
    Private mDatUpdatedDate As DateTime
    Private mIntUpdatedBy As Integer
    Private mIntCreatedBy As Integer

    Private mObjAccess As Data.Access

    Public Sub New()
        Reset()
        mObjAccess = New Data.Access
    End Sub

    Public Sub New(ByVal intResidentID As Integer)
        Reset()
        mObjAccess = New Data.Access

        Dim objDataset As DataSet
        objDataset = List(intResidentID)
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
    Public Property SpecialAttention() As Boolean
        Get
            Return mBooSpecialAttention
        End Get
        Set(ByVal Value As Boolean)
            mBooSpecialAttention = Value
        End Set
    End Property
    Public Property Comment() As String
        Get
            Return mStrComment
        End Get
        Set(ByVal Value As String)
            mStrComment = Value
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
#End Region

#Region " DataAccess "
    Public Function List(ByVal intResidentID As Integer, Optional ByVal strSQL As String = "") As DataSet
        Dim objDataset As New DataSet
        If strSQL = String.Empty Then
            strSQL = "SELECT * FROM K_ResidentComment " & _
            "WHERE K_ResidentID = " & intResidentID & " " & _
            "ORDER BY K_ResidentCreatedDate DESC"
        End If
        objDataset = mObjAccess.getDataset(strSQL)
        Return objDataset
    End Function

    Public Function Fetch(ByVal intID As Integer) As Boolean
        Dim objDataset As DataSet
        objDataset = mObjAccess.getDataset("SELECT * FROM K_ResidentComment WHERE K_ResidentCommentID = " & intID)

        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
        End If
    End Function

    Public Function FetchFromResident(ByVal intResidentID As Integer) As Boolean
        Dim objDataset As DataSet
        objDataset = mObjAccess.getDataset("SELECT * FROM K_ResidentComment WHERE K_ResidentID = " & intResidentID)

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

    Public Function SaveResidentCommentSQL() As Integer
        Dim strSQL As String
        If mIntID = 0 Then
            strSQL = "INSERT INTO K_ResidentComment (" & _
            "K_ResidentID, " & _
            "K_ResidentSpecialAttention, " & _
            "K_ResidentComment, " & _
            "K_ResidentCreatedDate, " & _
            "K_ResidentUpdatedDate, " & _
            "K_ResidentCreatedBy, " & _
            "K_ResidentUpdatedBy ) " & _
            "VALUES ( " & _
            "" & mIntResidentID & ", " & _
            "" & mBooSpecialAttention & ", " & _
            "'" & mStrComment & "', " & _
            "#" & Format(mDatCreatedDate, Data.Misc.DataBaseDateFormat) & "# , " & _
            "#" & Format(mDatUpdatedDate, Data.Misc.DataBaseDateFormat) & "#, " & _
            "" & mIntCreatedBy & ", " & _
            "" & mIntUpdatedBy & ");"
        Else
            strSQL = "UPDATE K_ResidentComment SET " & _
            "K_ResidentSpecialAttention = " & mBooSpecialAttention & ", " & _
            "K_ResidentComment = '" & mStrComment & "', " & _
            "K_ResidentUpdatedDate = #" & Format(mDatUpdatedDate, Data.Misc.DataBaseDateFormat) & "#, " & _
            "K_ResidentUpdatedBy = " & mIntUpdatedBy & " " & _
            "WHERE K_ResidentCommentID = " & mIntID & ";"
        End If
        Return mObjAccess.Save(strSQL)
    End Function

    Public Sub FetchFromRow(ByVal objRow As DataRow)
        mIntID = Data.Misc.ConvertToInt(objRow.Item("K_ResidentCommentID"))
        mIntResidentID = Data.Misc.ConvertToInt(objRow.Item("K_ResidentID"))
        mBooSpecialAttention = Data.Misc.ConvertToBoolean(objRow.Item("K_ResidentSpecialAttention"))
        mStrComment = Data.Misc.ConvertToString(objRow.Item("K_ResidentComment"))
        mDatCreatedDate = Data.Misc.ConvertToDateTime(objRow.Item("K_ResidentCreatedDate"))
        mDatUpdatedDate = Data.Misc.ConvertToDateTime(objRow.Item("K_ResidentUpdatedDate"))
        mIntCreatedBy = Data.Misc.ConvertToInt(objRow.Item("K_ResidentCreatedBy"))
        mIntUpdatedBy = Data.Misc.ConvertToInt(objRow.Item("K_ResidentUpdatedBy"))
    End Sub

    Public Sub Reset()
        mIntID = 0
        mIntResidentID = 0
        mBooSpecialAttention = False
        mStrComment = ""
        mDatCreatedDate = Data.Misc.DefaultDate
        mDatUpdatedDate = Data.Misc.DefaultDate
        mIntCreatedBy = 0
        mIntUpdatedBy = 0
    End Sub
#End Region
End Class
