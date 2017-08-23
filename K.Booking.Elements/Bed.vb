Public Class Bed

    Private mIntID As Integer
    Private mStrKey As String
    Private mStrDescription As String
    Private mIntRoomID As Integer

    Private mBooIsPermanent As Boolean

    Private mObjAccess As Data.Access

    Public Sub New()
        Reset()
        mObjAccess = New Data.Access
    End Sub

    Public Sub New(ByVal iBedID As Integer)
        Reset()
        mObjAccess = New Data.Access
        Fetch(iBedID)
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

    Public Property RoomID() As Integer
        Get
            Return mIntRoomID
        End Get
        Set(ByVal Value As Integer)
            mIntRoomID = Value
        End Set
    End Property

    Public Property IsPermanent() As Boolean
        Get
            Return mBooIsPermanent
        End Get
        Set(ByVal value As Boolean)
            mBooIsPermanent = value
        End Set
    End Property
#End Region

    Public Function ListInArray(Optional ByVal strSQL As String = "") As ArrayList
        Dim objDataset As New DataSet
        Dim objArray As New ArrayList

        objDataset = List(strSQL)

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            Dim objBed As New Bed
            objBed.FetchFromRow(objRow)
            objArray.Add(objBed)
        Next

        Return objArray
    End Function

    Public Function List(Optional ByVal strSQL As String = "") As DataSet
        Dim objDataset As New DataSet
        If Not strSQL = "" Then
            objDataset = mObjAccess.getDataset(strSQL)
        Else
            objDataset = mObjAccess.getDataset("SELECT * FROM K_Bed")
        End If
        Return objDataset
    End Function

    Public Function ListInRoom(ByVal iRoom_ID As Integer) As DataSet
        Dim objDataset As New DataSet
        objDataset = mObjAccess.getDataset("SELECT * FROM K_Bed WHERE K_RoomID = " & iRoom_ID & ";")
        Return objDataset
    End Function

    Public Sub SaveDataset(ByVal objDataset As DataSet)
        Dim objArray As New ArrayList

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            ID = Data.Misc.ConvertToInt(objRow.Item("K_BedID"))
            Key = Data.Misc.ConvertToString(objRow("K_BedKey"))
            Description = Data.Misc.ConvertToString(objRow.Item("K_BedDescription"))
            RoomID = Data.Misc.ConvertToInt(objRow.Item("K_RoomID"))
            IsPermanent = Data.Misc.ConvertToBoolean(objRow.Item("K_BedIsPermanent"))

            objArray.Add(SaveBedSQL)
        Next
        mObjAccess.SaveFromArray(objArray)
    End Sub

    Private Function SaveBedSQL() As String
        Dim strSQL As String
        If mIntID = 0 Then 'new bed
            strSQL = "INSERT INTO K_Bed " & _
            "(K_BedKey, " & _
            "K_BedDescription, " & _
            "K_RoomID, " & _
            "K_BedIsPermanent)" & _
            "VALUES('" & mStrKey & "', " & _
            "'" & mStrDescription & "', " & _
            "" & mIntRoomID & "," & _
            "" & mBooIsPermanent & ")"
        Else
            strSQL = "UPDATE K_Bed " & _
            "SET K_BedKey = '" & mStrKey & "', " & _
            "K_BedDescription = '" & mStrDescription & "', " & _
            "K_BedIsPermanent = " & mBooIsPermanent & "" & _
            "WHERE K_BedID = " & mIntID
        End If
        Return strSQL
    End Function

    Public Sub Save()
        mObjAccess.Save(SaveBedSQL)
    End Sub

    Public Function Fetch(ByVal intID As Integer) As Boolean
        Dim objDataset As DataSet
        objDataset = mObjAccess.getDataset("SELECT * FROM K_Bed WHERE K_BedID = " & intID)

        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
        End If
    End Function

    Public Function GetBedID(ByVal strRoom As String, ByVal strBed As String) As Integer
        Dim objDataset As DataSet
        Dim strSQL As String

        strSQL = "SELECT * FROM K_Bed " & _
        "WHERE K_BedKey = '" & strBed & "' " & _
        "AND K_RoomID = (SELECT K_RoomID FROM K_Room WHERE K_RoomKey = '" & strRoom & "')"
        objDataset = mObjAccess.getDataset(strSQL)

        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
        End If
        Return ID
    End Function

    Private Sub FetchFromRow(ByVal objRow As DataRow)
        ID = Data.Misc.ConvertToInt(objRow.Item("K_BedID"))
        Key = Data.Misc.ConvertToString(objRow("K_BedKey"))
        Description = Data.Misc.ConvertToString(objRow.Item("K_BedDescription"))
        RoomID = Data.Misc.ConvertToInt(objRow.Item("K_RoomID"))
        IsPermanent = Data.Misc.ConvertToBoolean(objRow.Item("K_BedIsPermanent"))
    End Sub

    Public Sub Reset()
        mIntID = 0
        mStrKey = ""
        mStrDescription = ""
        mIntRoomID = 0
        mBooIsPermanent = True
    End Sub

End Class
