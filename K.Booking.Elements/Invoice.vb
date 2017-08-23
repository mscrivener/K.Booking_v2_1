Public Class Invoice

    Private mIntID As Integer
    Private mIntResidentID As Integer
    Private mDatInvoiceDate As DateTime
    Private mIntCreatedBy As Integer

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
    Public Property ResidentID() As Integer
        Get
            Return mIntResidentID
        End Get
        Set(ByVal Value As Integer)
            mIntResidentID = Value
        End Set
    End Property
    Public Property InvoiceDate() As DateTime
        Get
            Return mDatInvoiceDate
        End Get
        Set(ByVal Value As DateTime)
            mDatInvoiceDate = Value
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

    Public ReadOnly Property DisplayMember() As String
        Get
            Return Format(InvoiceDate, "dd/MM/yyyy") & " - " & ID & " - " & GetTotalAmount()
        End Get
    End Property
#End Region

    Public Function InvoiceLines(ByVal intInvoiceID As Integer) As ArrayList
        Dim objDataset As New DataSet
        Dim objArray As New ArrayList
        Dim objInvoiceLine As New InvoiceLine

        objDataset = objInvoiceLine.List(intInvoiceID)

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            objInvoiceLine = New InvoiceLine
            objInvoiceLine.FetchFromRow(objRow)
            objArray.Add(objInvoiceLine)
        Next

        Return objArray
    End Function

    Private Function GetTotalAmount() As String
        Dim objDataset As New DataSet
        Dim strSQL As String

        strSQL = "SELECT SUM(K_InvoiceLineAmount) FROM K_InvoiceLine WHERE K_InvoiceID =" & ID & ";"

        objDataset = mObjAccess.getDataset(strSQL)
        If objDataset.Tables(0).Rows.Count > 0 Then
            Return objDataset.Tables(0).Rows(0)(0).ToString
        Else
            Return 0
        End If
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="iInvoiceID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetFlatDescription(ByVal iInvoiceID As Integer) As DataTable
        Dim sSQL As String = "SELECT K_Room.K_RoomDescription, K_Bed.K_BedID " & _
        "FROM K_Invoice, K_Resident, K_ResidentInBed, K_Bed, K_Room " & _
        "WHERE K_Invoice.K_ResidentID = K_Resident.K_ResidentID " & _
        "AND K_ResidentInBed.K_ResidentID = K_Resident.K_ResidentID " & _
        "AND K_ResidentInBed.K_BedID = K_Bed.K_BedID " & _
        "AND K_Bed.K_RoomID = K_Room.K_RoomID " & _
        "AND K_Invoice.K_InvoiceID = " & iInvoiceID

        Return mObjAccess.getDataset(sSQL).Tables(0)
    End Function

    Public Function ListForResidentInArray(ByVal iResidentID As Integer) As ArrayList
        Dim objDataset As New DataSet
        Dim objArray As New ArrayList
        Dim strSQL As String

        strSQL = "SELECT * FROM K_Invoice WHERE K_ResidentID = " & iResidentID & " ORDER BY K_InvoiceDate DESC;"

        objDataset = mObjAccess.getDataset(strSQL)

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            Dim objInvoice As New Invoice
            objInvoice.FetchFromRow(objRow)
            objArray.Add(objInvoice)
        Next

        Return objArray
    End Function

    Public Function ListForStatsInArray(ByVal datFromDate As DateTime, ByVal datToDate As DateTime) As ArrayList
        Dim objDataset As New DataSet
        Dim objArray As New ArrayList
        Dim strSQL As String

        strSQL = "SELECT * FROM K_Invoice WHERE K_InvoiceDate >= #" & Format(datFromDate, Data.Misc.DataBaseDateFormat) & "# AND K_InvoiceDate <= #" & Format(datToDate, Data.Misc.DataBaseDateFormat) & "# ;"

        objDataset = mObjAccess.getDataset(strSQL)

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            Dim objInvoice As New Invoice
            objInvoice.FetchFromRow(objRow)
            objArray.Add(objInvoice)
        Next

        Return objArray
    End Function
    
    Private Function SaveInvoiceSQL() As String
        Dim strSQL As String
        If mIntID = 0 Then 'new invoice
            strSQL = "INSERT INTO K_Invoice " & _
            "(K_ResidentID, K_InvoiceDate, K_InvoiceCreatedBy)" & _
            "VALUES(" & mIntResidentID & ", #" & Format(mDatInvoiceDate, Data.Misc.DataBaseDateFormat) & "#, " & mIntCreatedBy & ")"
        Else
            strSQL = "UPDATE K_Invoice " & _
            "SET K_ResidentID = '" & mIntResidentID & "', " & _
            "K_InvoiceDate = #" & Format(mDatInvoiceDate, Data.Misc.DataBaseDateFormat) & "#, " & _
            "K_InvoiceCreatedBy = '" & mIntCreatedBy & "' " & _
            "WHERE K_InvoiceID = " & mIntID
        End If
        Return strSQL
    End Function

    Public Sub Save()
        mObjAccess.Save(SaveInvoiceSQL)
    End Sub

    Public Function FetchLatest(ByVal intResidentID As Integer) As Boolean
        Dim objDataset As DataSet
        objDataset = mObjAccess.getDataset("SELECT * FROM K_Invoice WHERE K_ResidentID = " & intResidentID & " AND K_InvoiceID NOT IN (SELECT K_InvoiceID FROM K_InvoiceLine);")

        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
            Return True
        End If
        Return False
    End Function

    Public Function FetchFirst() As Boolean
        Dim objDataset As DataSet
        objDataset = mObjAccess.getDataset("SELECT TOP 1 * FROM K_Invoice ORDER BY K_InvoiceID;")

        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
            Return True
        End If
        Return False
    End Function

    Public Function Fetch(ByVal intID As Integer) As Boolean
        Dim objDataset As DataSet
        objDataset = mObjAccess.getDataset("SELECT * FROM K_Invoice WHERE K_InvoiceID = " & intID)

        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
            Return True
        End If
        Return False
    End Function

    Public Sub FetchFromRow(ByVal objRow As DataRow)
        mIntID = Data.Misc.ConvertToInt(objRow.Item("K_InvoiceID"))
        mIntResidentID = Data.Misc.ConvertToInt(objRow.Item("K_ResidentID"))
        mDatInvoiceDate = Data.Misc.ConvertToDateTime(objRow.Item("K_InvoiceDate"))
        mIntCreatedBy = Data.Misc.ConvertToInt(objRow.Item("K_InvoiceCreatedBy"))
    End Sub

    Public Sub Reset()
        mIntID = 0
        mIntResidentID = 0
        mDatInvoiceDate = Data.Misc.DefaultDate
        mIntCreatedBy = 0
    End Sub

End Class
