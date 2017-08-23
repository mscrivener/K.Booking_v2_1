Public Class Room

    Private mIntID As Integer
    Private mStrKey As String
    Private mStrDescription As String
    Private mIntType As Integer
    Private mIntStatus As Integer
    
    Private mObjAccess As Data.Access

    Public Sub New()
        Reset()
        mObjAccess = New Data.Access
    End Sub

    Public Sub New(ByVal iRoomID As Integer)
        Reset()
        mObjAccess = New Data.Access
        Fetch(iRoomID)
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
    Public Property Key() As String
        Get
            Return mStrKey
        End Get
        Set(ByVal Value As String)
            mStrKey = Value
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
    Public Property Type() As Integer
        Get
            Return mIntType
        End Get
        Set(ByVal Value As Integer)
            mIntType = Value
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
#End Region

    Public Function ListInArray(Optional ByVal strSQL As String = "") As ArrayList
        Dim objDataset As New DataSet
        Dim objArray As New ArrayList

        objDataset = List(strSQL)

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            Dim objRoom As New Room
            objRoom.FetchFromRow(objRow)
            objArray.Add(objRoom)
        Next

        Return objArray
    End Function

    Public Function List(Optional ByVal strSQL As String = "") As DataSet
        Dim objDataset As New DataSet
        If Not strSQL = "" Then
            objDataset = mObjAccess.getDataset(strSQL)
        Else
            objDataset = mObjAccess.getDataset("SELECT * FROM K_Room ORDER BY K_RoomKey")
        End If
        Return objDataset
    End Function

    Public Function GetRoomID(ByVal strKey As String) As Integer
        Dim strSQL As String
        Dim objDataset As New DataSet

        strSQL = "SELECT * FROM K_Room WHERE K_RoomKey LIKE '" & strKey & "'"

        objDataset = mObjAccess.getDataset(strSQL)
        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
        End If
        Return mIntID
    End Function

    Public Sub SaveDataset(ByVal objDataset As DataSet)
        Dim objArray As New ArrayList

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            ID = Data.Misc.ConvertToInt(objRow.Item("K_RoomID"))
            Description = Data.Misc.ConvertToString(objRow.Item("K_RoomDescription"))

            objArray.Add(SaveRoomSQL)
        Next
        mObjAccess.SaveFromArray(objArray)
    End Sub

    Private Function SaveRoomSQL() As String
        Dim strSQL As String
        If mIntID = 0 Then 'new room
            strSQL = "INSERT INTO K_Room " & _
            "(K_RoomKey, " & _
            "K_RoomDescription, " & _
            "K_RoomType, " & _
            "K_RoomStatus)" & _
            "VALUES('" & mStrKey & "', " & _
            "'" & mStrDescription & "', " & _
            "" & mIntType & ", " & _
            "" & mIntStatus & ")"
        Else
            strSQL = "UPDATE K_Room " & _
            "SET K_RoomKey = '" & mStrKey & "', " & _
            "K_RoomDescription = '" & mStrDescription & "', " & _
            "K_RoomType = " & mIntType & ", " & _
            "K_RoomStatus = " & mIntStatus & " " & _
            "WHERE K_RoomID = " & mIntID
        End If
        Return strSQL
    End Function

    Public Sub Save()
        mObjAccess.Save(SaveRoomSQL)
    End Sub

    Public Function Fetch(ByVal intID As Integer) As Boolean
        Dim objDataset As DataSet
        objDataset = mObjAccess.getDataset("SELECT * FROM K_Room WHERE K_RoomID = " & intID)

        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
        End If
    End Function

    Private Sub FetchFromRow(ByVal objRow As DataRow)
        mIntID = Data.Misc.ConvertToInt(objRow("K_RoomID"))
        mStrKey = Data.Misc.ConvertToString(objRow("K_RoomKey"))
        mStrDescription = Data.Misc.ConvertToString(objRow("K_RoomDescription"))
        mIntType = Data.Misc.ConvertToInt(objRow("K_RoomType"))
        mIntStatus = Data.Misc.ConvertToInt(objRow("K_RoomStatus"))
    End Sub

    Public Sub Reset()
        mIntID = 0
        mStrKey = ""
        mStrDescription = ""
        mIntType = -1
        mIntStatus = -1
    End Sub

End Class
