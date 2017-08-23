Public Class StatsInvoices

    Private mIntID As Integer
    Private mIntStatsID As Integer
    Private mIntInvoiceID As Integer

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

    Public Property StatsID() As Integer
        Get
            Return mIntStatsID
        End Get
        Set(ByVal value As Integer)
            mIntStatsID = value
        End Set
    End Property

    Public Property InvoiceID() As Integer
        Get
            Return mIntInvoiceID
        End Get
        Set(ByVal value As Integer)
            mIntInvoiceID = value
        End Set
    End Property
#End Region

    Public Function Fetch(ByVal intID As Integer) As Boolean
        Dim objDataset As DataSet
        objDataset = mObjAccess.getDataset("SELECT * FROM K_StatsInvoices WHERE K_StatsInvoicesID = " & intID)

        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
        End If
    End Function

    Public Function ListInStat(ByVal intStatsID As Integer) As ArrayList
        Dim objDataset As DataSet
        Dim objInvoices As New ArrayList
        objDataset = mObjAccess.getDataset("SELECT K_Invoice.* FROM K_Invoice INNER JOIN K_StatsInvoices ON K_Invoice.K_InvoiceID = K_StatsInvoices.K_InvoiceID WHERE K_StatsID = " & intStatsID)

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            Dim objInvoice As New Elements.Invoice
            objInvoice.FetchFromRow(objRow)
            objInvoices.Add(objInvoice)
        Next

        Return objInvoices
    End Function

    Public Sub FetchFromRow(ByVal objRow As DataRow)
        ID = Data.Misc.ConvertToInt(objRow.Item("K_StatsInvoicesID"))
        StatsID = Data.Misc.ConvertToInt(objRow.Item("K_StatsID"))
        InvoiceID = Data.Misc.ConvertToInt(objRow.Item("K_InvoiceID"))
    End Sub

    Private Function SaveStatsInvoicesSQL() As String
        Dim strSQL As String = ""
        If mIntID = 0 Then 'new bed
            strSQL = "INSERT INTO K_StatsInvoices " & _
            "(K_StatsID, " & _
            "K_InvoiceID)" & _
            "VALUES(" & mIntStatsID & ", " & _
            "" & mIntInvoiceID & ");"
        End If
        Return strSQL
    End Function

    Public Sub Save()
        mObjAccess.Save(SaveStatsInvoicesSQL)
    End Sub

    Private Sub Reset()
        mIntID = 0
        mIntStatsID = 0
        mIntInvoiceID = 0
    End Sub
End Class
