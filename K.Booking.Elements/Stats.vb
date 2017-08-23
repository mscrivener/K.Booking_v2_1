Public Class Stats

    Private mIntID As Integer
    Private mDatFromDate As DateTime
    Private mDatToDate As DateTime
    Private mDatCreatedDate As DateTime
    Private mIntCreatedBy As Integer

    Private mObjInvoices As ArrayList

    Private mObjAccess As Data.Access

    Public Sub New()
        Reset()
        mObjAccess = New Data.Access
    End Sub

#Region " Properties "
    Public Property ID() As Integer
        Get
            Return mIntID
        End Get
        Set(ByVal value As Integer)
            mIntID = value
        End Set
    End Property

    Public Property FromDate() As DateTime
        Get
            Return mDatFromDate
        End Get
        Set(ByVal value As DateTime)
            mDatFromDate = value
        End Set
    End Property

    Public Property ToDate() As DateTime
        Get
            Return mDatToDate
        End Get
        Set(ByVal value As DateTime)
            mDatToDate = value
        End Set
    End Property

    Public Property CreatedDate() As DateTime
        Get
            Return mDatCreatedDate
        End Get
        Set(ByVal value As DateTime)
            mDatCreatedDate = value
        End Set
    End Property

    Public Property CreatedBy() As Integer
        Get
            Return mIntCreatedBy
        End Get
        Set(ByVal value As Integer)
            mIntCreatedBy = value
        End Set
    End Property

    Public ReadOnly Property Invoices() As ArrayList
        Get
            Return mObjInvoices
        End Get
    End Property

    Public ReadOnly Property DisplayMember() As String
        Get
            Return Format(mDatFromDate, "dd/MM/yyyy") & " " & Format(mDatToDate, "dd/MM/yyyy")
        End Get
    End Property
#End Region

    Public Function List(Optional ByVal strSQL As String = "") As DataSet
        Dim objDataset As New DataSet
        If Not strSQL = "" Then
            objDataset = mObjAccess.getDataset(strSQL)
        Else
            objDataset = mObjAccess.getDataset("SELECT * FROM K_Stats")
        End If
        Return objDataset
    End Function

    Public Function ListInArray(Optional ByVal strSQL As String = "") As ArrayList
        Dim objDataset As New DataSet
        Dim objArray As New ArrayList
        If Not strSQL = "" Then
            objDataset = mObjAccess.getDataset(strSQL)
        Else
            objDataset = mObjAccess.getDataset("SELECT * FROM K_Stats ORDER BY K_StatsFromDate DESC")
        End If

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            Dim objStats As New Stats
            objStats.FetchFromRow(objRow)
            objArray.Add(objStats)
        Next
        Return objArray
    End Function

    Public Function ListByMonth(ByVal iMonth As Integer, ByVal iYear As Integer) As ArrayList
        Dim datFrom As DateTime = New DateTime(iYear, iMonth, 1)
        Dim objDataset As New DataSet
        Dim objArray As New ArrayList

        objDataset = mObjAccess.getDataset("SELECT * FROM K_Stats WHERE K_StatsToDate >= #" & Format(datFrom, Data.Misc.DataBaseDateFormat) & "# OR K_StatsFromDate < #" & Format(datFrom.AddMonths(1), Data.Misc.DataBaseDateFormat) & "# ORDER BY K_StatsFromDate DESC ")

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            Dim objStats As New Stats
            objStats.FetchFromRow(objRow)
            objArray.Add(objStats)
        Next

        Return objArray
    End Function

    Public Function ListInvoices() As ArrayList
        Dim objDataset As New DataSet
        objDataset = mObjAccess.getDataset("SELECT * FROM K_StatsInvoices WHERE K_StatsID = " & mIntID)

        mObjInvoices = New ArrayList

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            Dim objStatInvoice As New StatsInvoices
            objStatInvoice.FetchFromRow(objRow)
            mObjInvoices.Add(objStatInvoice)
        Next

        Return mObjInvoices
    End Function

    Public Function GetStartDate() As DateTime
        Dim objDataset As DataSet = List("SELECT TOP 1 * FROM K_Stats ORDER BY K_StatsID DESC")
        If objDataset.Tables(0).Rows.Count > 0 Then
            'we have stats(get newest)
            Return Data.Misc.ConvertToDateTime(objDataset.Tables(0).Rows(0)("K_StatsToDate")).AddDays(1)
        Else
            'there are no stats - get first invoice
            Dim objInvoice As New Elements.Invoice
            If objInvoice.FetchFirst() Then
                'first invoice - return date
                Return objInvoice.InvoiceDate
            End If
        End If

        Return Nothing 'there is nothing in the database yet - no stats available
    End Function

    Private Function SaveStatsSQL() As String
        Dim strSQL As String = ""
        If mIntID = 0 Then 'new bed
            strSQL = "INSERT INTO K_Stats " &
            "(K_StatsFromDate, " &
            "K_StatsToDate, " &
            "K_StatsCreatedDate, " &
            "K_StatsCreatedBy)" &
            "VALUES(#" & Format(mDatFromDate, Data.Misc.DataBaseDateFormat) & "#, " &
            "#" & Format(mDatToDate, Data.Misc.DataBaseDateFormat) & "#, " &
            "#" & Format(mDatCreatedDate, Data.Misc.DataBaseDateFormat) & "#," &
            "" & mIntCreatedBy & ")"
        End If
        Return strSQL
    End Function

    Public Sub Save()
        mObjAccess.Save(SaveStatsSQL)
    End Sub

    Public Function FetchLatest() As Boolean
        Dim objDataset As DataSet
        objDataset = mObjAccess.getDataset("SELECT * FROM K_Stats WHERE K_StatsID NOT IN (SELECT K_StatsID FROM K_StatsInvoices) ORDER BY K_StatsID DESC;")

        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
            Return True
        End If
        Return False
    End Function

    Public Function Fetch(ByVal intID As Integer) As Boolean
        Dim objDataset As DataSet
        objDataset = mObjAccess.getDataset("SELECT * FROM K_Stats WHERE K_StatsID = " & intID)

        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
        End If
    End Function

    Private Sub FetchFromRow(ByVal objRow As DataRow)
        ID = Data.Misc.ConvertToInt(objRow.Item("K_StatsID"))
        FromDate = Data.Misc.ConvertToDateTime(objRow.Item("K_StatsFromDate"))
        ToDate = Data.Misc.ConvertToDateTime(objRow.Item("K_StatsToDate"))
        CreatedDate = Data.Misc.ConvertToDateTime(objRow.Item("K_StatsCreatedDate"))
        CreatedBy = Data.Misc.ConvertToInt(objRow.Item("K_StatsCreatedBy"))
    End Sub

    Private Sub Reset()
        mIntID = 0
        mDatFromDate = Data.Misc.DefaultDate
        mDatToDate = Data.Misc.DefaultDate
        mDatCreatedDate = Data.Misc.DefaultDate
        mIntCreatedBy = 0
    End Sub

End Class
