Public Class InvoiceLine

    Private mIntID As Integer
    Private mIntInvoiceID As Integer
    Private mStrDescription As String
    Private mDblAmount As Double
    Private mIntPriceID As Integer
    Private mDatFrom As DateTime
    Private mDatTo As DateTime
    Private mIntStatus As Integer

    Private mObjAccess As Data.Access

    Public Sub New()
        Reset()
        mObjAccess = New Data.Access
    End Sub

#Region " properties "
    Public Property ID() As Integer
        Get
            Return mIntID
        End Get
        Set(ByVal Value As Integer)
            mIntID = Value
        End Set
    End Property
    Public Property InvoiceID() As Integer
        Get
            Return mIntInvoiceID
        End Get
        Set(ByVal Value As Integer)
            mIntInvoiceID = Value
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
    Public Property PriceID() As Integer
        Get
            Return mIntPriceID
        End Get
        Set(ByVal Value As Integer)
            mIntPriceID = Value
        End Set
    End Property
    Public Property DatFrom() As DateTime
        Get
            Return mDatFrom
        End Get
        Set(ByVal Value As DateTime)
            mDatFrom = Value
        End Set
    End Property
    Public Property DatTo() As DateTime
        Get
            Return mDatTo
        End Get
        Set(ByVal Value As DateTime)
            mDatTo = Value
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

  
    Public Function List(ByVal intInvoiceID As Integer) As DataSet
        Dim objDataset As New DataSet
        objDataset = mObjAccess.getDataset("SELECT K_InvoiceLineID, K_InvoiceID, K_InvoiceLineDescription, K_InvoiceLineAmount, K_InvoicePriceID, K_InvoiceLineFrom, K_InvoiceLineTo, K_InvoiceLineStatus FROM K_InvoiceLine WHERE K_InvoiceID = " & intInvoiceID)
        Return objDataset
    End Function

    Public Function List(ByVal datTypeChanged As DateTime, ByVal intResidentID As Integer) As DataSet
        Dim strSQL As String
        strSQL = "SELECT L.* " & _
        "FROM K_InvoiceLine L " & _
        "INNER JOIN K_Invoice I " & _
        "ON L.K_InvoiceID = I.K_InvoiceID " & _
        "WHERE I.K_ResidentID = " & intResidentID & " " & _
        "AND L.K_InvoiceLineStatus = 1 " & _
        "AND L.K_InvoiceLineTo > #" & datTypeChanged.ToString(Data.Misc.DataBaseDateFormat) & "# "
        Return mObjAccess.getDataset(strSQL)
    End Function

    Public Function List(ByVal intInvoiceID As Integer, ByVal datTypeChanged As DateTime) As DataSet
        Dim strSQL As String
        strSQL = "SELECT K_InvoiceLineID, K_InvoiceID, K_InvoiceLineDescription, K_InvoiceLineAmount, K_InvoicePriceID, K_InvoiceLineFrom, K_InvoiceLineTo, K_InvoiceLineStatus " & _
        "FROM K_InvoiceLine WHERE K_InvoiceID = " & intInvoiceID & " " & _
        "AND L.K_InvoiceLineTo > #" & datTypeChanged.ToString(Data.Misc.DataBaseDateFormat) & "# "
        Return mObjAccess.getDataset(strSQL)
    End Function

    Public Function HasPaidDeposit(ByVal intResidentID As Integer) As Boolean
        Dim ds As DataSet
        Dim strSQL As String
        strSQL = "SELECT IL.* " & _
        "FROM K_InvoiceLine IL " & _
        "INNER JOIN K_Invoice I ON IL.K_InvoiceID = I.K_InvoiceID " & _
        "WHERE I.K_ResidentID = " & intResidentID & " " & _
        "AND IL.K_InvoiceLineStatus = 1 " & _
        "AND IL.K_InvoicePriceID = 4"
        ds = mObjAccess.getDataset(strSQL)
        If ds.Tables(0).Rows.Count > 0 Then
            FetchFromRow(ds.Tables(0).Rows(0))
            Return True
        End If
        Return False
    End Function

    'Public Sub SaveDataset(ByVal objDataset As DataSet)
    '    Dim objArray As New ArrayList

    '    For Each objRow As DataRow In objDataset.Tables(0).Rows
    '        ID = Data.Misc.ConvertToInt(objRow.Item(0))
    '        FullName = Data.Misc.ConvertToString(objRow.Item(1))
    '        LoginName = Data.Misc.ConvertToString(objRow.Item(2))
    '        Password = Data.Misc.ConvertToString(objRow.Item(3))
    '        Active = Data.Misc.ConvertToBoolean(objRow.Item(4))

    '        objArray.Add(SaveUserSQL)
    '    Next
    '    mObjAccess.SaveFromArray(objArray)
    'End Sub

    Private Function SaveInvoiceLineSQL() As String
        Dim strSQL As String = ""
        If mIntID = 0 Then 'new invoiceline
            strSQL = "INSERT INTO K_InvoiceLine " & _
            "(K_InvoiceID, K_InvoiceLineDescription, K_InvoiceLineAmount, K_InvoicePriceID, K_InvoiceLineFrom, K_InvoiceLineTo, K_InvoiceLineStatus)" & _
            "VALUES(" & mIntInvoiceID & ", '" & mStrDescription & "', " & mDblAmount & ", " & mIntPriceID & ", #" & Format(mDatFrom, Data.Misc.DataBaseDateFormat) & "#, #" & Format(mDatTo, Data.Misc.DataBaseDateFormat) & "#, " & mIntStatus & ")"
        Else
            'strSQL = "UPDATE K_User " & _
            '"SET K_UserFullName = '" & mStrFullName & "', " & _
            '"K_UserLoginName = '" & mStrLoginName & "', " & _
            '"K_UserPassword = '" & mStrPassWord & "', " & _
            '"K_UserActive = " & mBooActive & " " & _
            '"WHERE K_UserID = " & mIntID
        End If
        Return strSQL
    End Function

    Public Sub UpdateStatus(ByVal intID As Integer)
        Dim strSQL As String
        strSQL = "UPDATE K_InvoiceLine " & _
        "SET K_InvoiceLineStatus = -1 " & _
        "WHERE K_InvoiceLineID = " & intID
        mObjAccess.Save(strSQL)
    End Sub

    Public Sub Save()
        mObjAccess.Save(SaveInvoiceLineSQL)
    End Sub

    'Public Function Fetch(ByVal intID As Integer) As Boolean
    '    Dim objDataset As DataSet
    '    objDataset = mObjAccess.getDataset("SELECT * FROM K_User WHERE K_UserID = " & intID)

    '    If objDataset.Tables(0).Rows.Count > 0 Then
    '        FetchFromRow(objDataset.Tables(0).Rows(0))
    '        Return True
    '    End If
    '    Return False
    'End Function

    Public Sub FetchFromRow(ByVal objRow As DataRow)
        mIntID = Data.Misc.ConvertToInt(objRow.Item("K_InvoiceLineID"))
        mIntInvoiceID = Data.Misc.ConvertToInt(objRow.Item("K_InvoiceID"))
        mStrDescription = Data.Misc.ConvertToString(objRow.Item("K_InvoiceLineDescription"))
        mDblAmount = Data.Misc.ConvertToDouble(objRow.Item("K_InvoiceLineAmount"))
        mIntPriceID = Data.Misc.ConvertToInt(objRow.Item("K_InvoicePriceID"))
        mDatFrom = Data.Misc.ConvertToDateTime(objRow.Item("K_InvoiceLineFrom"))
        mDatTo = Data.Misc.ConvertToDateTime(objRow.Item("K_InvoiceLineTo"))
        mIntStatus = Data.Misc.ConvertToInt(objRow.Item("K_InvoiceLineStatus"))
    End Sub

    Public Sub Reset()
        mIntID = 0
        mIntInvoiceID = 0
        mStrDescription = ""
        mDblAmount = 0.0
        mIntPriceID = 0
        mDatFrom = Data.Misc.DefaultDate
        mDatTo = Data.Misc.DefaultDate
        mIntStatus = 1
    End Sub


End Class
