Public Class InvoicePrint

    Private mObjLines As ArrayList
    Private mBooInclFoodstamps As Boolean
    Private mObjFoodStamps As ArrayList
    Private mObjInvoice As Invoice
    Private mObjResident As Resident
    Private mDblInvoiceTotal As Double

    Private mInvoiceHeight As Integer
    Private mFoodStampHeight As Integer


    Public Sub New(ByVal iInvoiceID As Integer, ByVal bInclFoodStamps As Boolean, ByVal iLineHeight As Integer, ByVal bPrintCopy As Boolean)
        mObjInvoice = New Invoice()
        mObjInvoice.Fetch(iInvoiceID)

        mObjLines = mObjInvoice.InvoiceLines(iInvoiceID)

        mObjResident = New Resident()
        mObjResident.Fetch(mObjInvoice.ResidentID)

        mBooInclFoodstamps = bInclFoodStamps

        mObjFoodStamps = New ArrayList


        For Each il As InvoiceLine In mObjLines
            If mBooInclFoodstamps Then
                If il.PriceID = Data.GlobalEnums.PriceDesctiption.LongTermLow OrElse il.PriceID = Data.GlobalEnums.PriceDesctiption.LongTermHigh Then
                    mObjFoodStamps.Add(New FoodStamp(il.DatFrom, il.DatTo, getFoodstampValue(il.DatFrom)))
                End If
            End If

            mDblInvoiceTotal += il.Amount
        Next

        mInvoiceHeight = (11 + mObjLines.Count) * iLineHeight + 120
        mFoodStampHeight = (iLineHeight) + ((8 * iLineHeight) + 135)

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="datValidDate"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetFoodstampValue(ByVal datValidDate As DateTime) As Double
        Dim objPriceSet As New Elements.PriceSet
        Dim objPrice As New Elements.Price
        Dim objDataset As DataSet

        objPriceSet.FetchValidPriceSet(datValidDate)
        objDataset = objPrice.GetPrices(objPriceSet.ID)

        Return Data.Misc.ConvertToDouble(objDataset.Tables(0).Rows(Data.GlobalEnums.PriceDesctiption.FoodTicket - 1).Item("K_PriceAmount"))
    End Function

#Region " Properties "
    ReadOnly Property InvoiceLines() As ArrayList
        Get
            Return mObjLines
        End Get
    End Property

    ReadOnly Property FoodStamps() As ArrayList
        Get
            Return mObjFoodStamps
        End Get
    End Property

    ReadOnly Property InvoiceNumber() As String
        Get
            Return Data.Misc.GetPrintInvoiceNo(mObjInvoice.ID)
        End Get
    End Property

    ReadOnly Property TheInvoice() As Invoice
        Get
            Return mObjInvoice
        End Get
    End Property

    ReadOnly Property Resident() As Resident
        Get
            Return mObjResident
        End Get
    End Property

    ReadOnly Property InclFoodstamps() As Boolean
        Get
            Return mBooInclFoodstamps
        End Get
    End Property

    ReadOnly Property HomeAddress() As String
        Get
            Return Data.Misc.GetHomeAddress & vbNewLine
        End Get
    End Property

    ReadOnly Property VATno() As String
        Get
            Return "VAT no.: GB230439001" & vbNewLine
        End Get
    End Property

    ReadOnly Property InvoiceTotal() As Double
        Get
            Return mDblInvoiceTotal
        End Get
    End Property

    ReadOnly Property InvoiceHeight() As Integer
        Get
            Return mInvoiceHeight
        End Get
    End Property

    ReadOnly Property FoodStampHeight() As Integer
        Get
            Return mFoodStampHeight
        End Get
    End Property
#End Region
End Class
