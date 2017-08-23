Public Class User

    Private mIntID As Integer
    Private mStrFullName As String
    Private mStrLoginName As String
    Private mStrPassWord As String
    Private mBooActive As Boolean

    Private mObjAccess As Data.Access

    Public Sub New()
        Reset()
        mObjAccess = New Data.Access
    End Sub

    Public Sub New(ByVal iUsers_ID As Integer)
        Reset()
        mObjAccess = New Data.Access

        Fetch(iUsers_ID)
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

    Public Property FullName() As String
        Get
            Return mStrFullName
        End Get
        Set(ByVal Value As String)
            mStrFullName = Value
        End Set
    End Property

    Public Property LoginName() As String
        Get
            Return mStrLoginName
        End Get
        Set(ByVal Value As String)
            mStrLoginName = Value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return mStrPassWord
        End Get
        Set(ByVal Value As String)
            mStrPassWord = Value
        End Set
    End Property

    Public Property Active() As Boolean
        Get
            Return mBooActive
        End Get
        Set(ByVal Value As Boolean)
            mBooActive = Value
        End Set
    End Property
#End Region

    Public Function ListInArray(Optional ByVal strSQL As String = "") As ArrayList
        Dim objDataset As New DataSet
        Dim objArray As New ArrayList

        objDataset = List(strSQL)

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            Dim objUser As New User
            objUser.FetchFromRow(objRow)
            objArray.Add(objUser)
        Next

        Return objArray
    End Function

    Public Function List(Optional ByVal strSQL As String = "") As DataSet
        Dim objDataset As New DataSet
        If Not strSQL = "" Then
            objDataset = mObjAccess.getDataset(strSQL)
        Else
            objDataset = mObjAccess.getDataset("SELECT * FROM K_User")
        End If
        Return objDataset
    End Function

    Public Sub SaveDataset(ByVal objDataset As DataSet)
        Dim objArray As New ArrayList

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            ID = Data.Misc.ConvertToInt(objRow.Item(0))
            FullName = Data.Misc.ConvertToString(objRow.Item(1))
            LoginName = Data.Misc.ConvertToString(objRow.Item(2))
            Password = Data.Misc.ConvertToString(objRow.Item(3))
            Active = Data.Misc.ConvertToBoolean(objRow.Item(4))

            objArray.Add(SaveUserSQL)
        Next
        mObjAccess.SaveFromArray(objArray)
    End Sub

    Private Function SaveUserSQL() As String
        Dim strSQL As String
        If mIntID = 0 Then 'new user
            strSQL = "INSERT INTO K_User " & _
            "(K_UserFullName, K_UserLoginName, K_UserPassword, K_UserActive)" & _
            "VALUES('" & mStrFullName & "', '" & mStrLoginName & "', '" & mStrPassWord & "', " & mBooActive & ")"
        Else
            strSQL = "UPDATE K_User " & _
            "SET K_UserFullName = '" & mStrFullName & "', " & _
            "K_UserLoginName = '" & mStrLoginName & "', " & _
            "K_UserPassword = '" & mStrPassWord & "', " & _
            "K_UserActive = " & mBooActive & " " & _
            "WHERE K_UserID = " & mIntID
        End If
        Return strSQL
    End Function

    Public Sub Save()
        mObjAccess.Save(SaveUserSQL)
    End Sub

    Public Function Fetch(ByVal intID As Integer) As Boolean
        Dim objDataset As DataSet
        objDataset = mObjAccess.getDataset("SELECT * FROM K_User WHERE K_UserID = " & intID)

        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
            Return True
        End If
        Return False
    End Function

    Private Sub FetchFromRow(ByVal objRow As DataRow)
        mIntID = objRow.Item(0)
        mStrFullName = objRow.Item(1)
        mStrLoginName = objRow.Item(2)
        mStrPassWord = objRow.Item(3)
        mBooActive = objRow.Item(4)
    End Sub

    Public Sub Reset()
        mIntID = 0
        mStrFullName = ""
        mStrLoginName = ""
        mStrPassWord = ""
        mBooActive = False
    End Sub

End Class
