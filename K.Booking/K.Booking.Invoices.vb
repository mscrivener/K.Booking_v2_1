Public Class K_Booking_Invoices
    Private mIntResidentID As Integer
    Private mObjResident As Elements.Resident

    Public Property ResidentID() As Integer
        Get
            Return mIntResidentID
        End Get
        Set(ByVal Value As Integer)
            mIntResidentID = Value
            mObjResident = New Elements.Resident
            mObjResident.Fetch(Value)
        End Set
    End Property

    Private bRunInvoice As Boolean

    Private Sub K_Booking_Invoices_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '##TODO: add print button and check box for with/without foodstamps
        '##TODO: write print function
        lblResidentInvoices.Text = "Betalingsoversigt for " & mObjResident.FirstName & " " & mObjResident.LastName

        Dim inv As New Elements.Invoice

        '##TODO: only list ones with lines!

        bRunInvoice = False

        lbxInvoices.DataSource = inv.ListForResidentInArray(mIntResidentID)
        lbxInvoices.DisplayMember = "DisplayMember"

        bRunInvoice = True
    End Sub

    Private Sub lbxInvoices_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbxInvoices.SelectedIndexChanged
        If bRunInvoice Then
            If lbxInvoices.SelectedIndex > -1 Then
                Dim i As Elements.Invoice = TryCast(lbxInvoices.SelectedValue, Elements.Invoice)
                Dim iLines As ArrayList = i.InvoiceLines(i.ID)

                Dim mTable As New DataTable
                mTable.TableName = "InvoiceLines"
                mTable.Columns.Add("PriceID", System.Type.GetType("System.String"))
                mTable.Columns.Add("Description", System.Type.GetType("System.String"))
                mTable.Columns.Add("Amount", System.Type.GetType("System.Decimal"))
                For Each il As Elements.InvoiceLine In iLines
                    mTable.Rows.Add(New Object() {GetPriceDesciption(il.PriceID), il.Description, FormatNumber(il.Amount, 2)})
                Next

                'add K's address
                lblInvoiceHeader.Text = "Betalingsdato: " & i.InvoiceDate & vbNewLine & _
                Data.Misc.GetHomeAddress

                Dim tableStyle As New DataGridTableStyle()

                tableStyle.MappingName = "InvoiceLines"

                For j As Integer = 0 To mTable.Columns.Count - 1

                    Select Case mTable.Columns(j).ColumnName
                        Case "PriceID"
                            Dim TextCol As New DataGridTextBoxColumn

                            With TextCol
                                .MappingName = "PriceID"
                                .HeaderText = "Pris type"
                                .Width = 100
                                
                                tableStyle.GridColumnStyles.Add(TextCol)
                            End With
                        Case "Description"
                            Dim TextCol As New DataGridTextBoxColumn
                            With TextCol
                                .MappingName = "Description"
                                .HeaderText = "Beskrivelse"
                                .Width = 300

                                tableStyle.GridColumnStyles.Add(TextCol)
                            End With
                        Case "Amount"
                            Dim TextCol As New DataGridTextBoxColumn
                            With TextCol
                                .MappingName = "Amount"
                                .HeaderText = "Beløb i £"
                                .Width = 100
                                .Alignment = HorizontalAlignment.Right

                                tableStyle.GridColumnStyles.Add(TextCol)
                            End With
                    End Select

                Next

                dgInvoiceLines.TableStyles.Clear()

                dgInvoiceLines.TableStyles.Add(tableStyle)
                
                dgInvoiceLines.DataSource = mTable

                Dim dTotal As Double = 0
                For Each il As Elements.InvoiceLine In iLines
                    dTotal += il.Amount
                Next

                'add label with total amount
                lblTotalAmount.Text = "Total £ " & FormatNumber(dTotal, 2)

                ''If dgvInvoiceLines.Columns.Count > 3 Then
                ''dgvInvoiceLines.Columns.RemoveAt(0)
                ''dgvInvoiceLines.Columns.RemoveAt(3)
                ''dgvInvoiceLines.Columns.RemoveAt(3)
                ''dgvInvoiceLines.Columns.RemoveAt(3)
                ''dgvInvoiceLines.Columns.RemoveAt(3)

                'dgvInvoiceLines.AutoResizeColumn(0)
                'dgvInvoiceLines.AutoResizeColumn(1)
                'dgvInvoiceLines.AutoResizeColumn(2)
                'End If
            End If
        End If
    End Sub

    Private Function GetPriceDesciption(ByVal iPriceDescriptionID As Integer) As String
        Select Case iPriceDescriptionID
            Case 1
                Return "Fast - høj"
            Case 2
                Return "Fast - lav"
            Case 3
                Return "Korttids"
            Case 4
                Return "Depositum"
            Case 8
                Return "Flat"
            Case 9
                Return "Gæst"
            Case 10
                Return "Fast - CC Fee"
            Case 11
                Return "Korttids - CC Fee"
            Case 12
                Return "Flat - CC Fee"
            Case 13
                Return "Fast - Late Fee"
            Case 14
                Return "Korttids - Late Fee"
            Case 15
                Return "Flat - Late Fee"
            Case 16
                Return "Fast - u madbillet"
            Case 0
                Return "Andet"
            Case Else
                Return "ERROR"
        End Select
    End Function

    'close this form and go back to main
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If lbxInvoices.SelectedIndex > -1 Then
            DoInvoicePrint(TryCast(lbxInvoices.SelectedItem, Elements.Invoice).ID, chkIncludeFoodStamps.Checked)
        Else
            MessageBox.Show("Du skal markere den linie i listen du ønsker at udskrive", "Udskrift", MessageBoxButtons.OK)
        End If
    End Sub

    Public Sub DoInvoicePrint(ByVal iInvoiceID As Integer, ByVal bInclFoodStamp As Boolean)

        mInvPrinted = False
        mNoFoodstamps = 0
        mInvCopyPrinted = False
        PrintAreaWidth = 249

        f = New Font("Arial", 11)
        sf = New Font("Arial", 9) 'small for invoice lines
        ip = New Elements.InvoicePrint(iInvoiceID, bInclFoodStamp, f.Height, chkPrintCopy.Checked)
#If DEBUG Then
        Dim PrintPreviewDialog1 As New PrintPreviewDialog()
        PrintPreviewDialog1.Document = printInvoice
        If PrintPreviewDialog1.ShowDialog() = DialogResult.OK Then
            printInvoice.Print()
        End If
#Else
            If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                printInvoice.Print()
            End If
#End If
    End Sub

    Private Function PrintInvoicePart(ByVal printer As System.Drawing.Printing.PrintPageEventArgs) As Integer
        'we are done writing the header - write the table
        Dim x As Integer = 0 'the staring x of the table
        Dim rc As Integer = 0 'row counter
        Dim y As Integer = 10
        Dim marginLeft As Integer = 0

        '##TEST
#If DEBUG Then
        'put a rectangle around the whole printed area
        printer.Graphics.DrawRectangle(Pens.Red, marginLeft, x, PrintAreaWidth, ip.InvoiceHeight)
#End If

        'k address
        printer.Graphics.DrawString(ip.HomeAddress & ip.VATno & vbNewLine & ip.InvoiceNumber, sf, Brushes.Black, marginLeft, y)

        y += printer.Graphics.MeasureString(ip.HomeAddress & ip.VATno & vbNewLine & ip.InvoiceNumber, sf).Height

        'name and date
        Dim iDateWidth As Integer = printer.Graphics.MeasureString("Date: " & Format(ip.TheInvoice.InvoiceDate, "dd-MM-yyyy"), f).Width + 5
        printer.Graphics.DrawString("Date: " & Format(ip.TheInvoice.InvoiceDate, "dd-MM-yyyy"), f, Brushes.Black, PrintAreaWidth - iDateWidth, y)

        y += printer.Graphics.MeasureString("Date: " & Format(ip.TheInvoice.InvoiceDate, "dd-MM-yyyy"), f).Height
        printer.Graphics.DrawString(ip.Resident.FirstName & " " & ip.Resident.LastName, f, Brushes.Black, marginLeft, y)

        y += f.Height

        'write table header
        'printer.Graphics.DrawString("Item", New Font(f, FontStyle.Bold), Brushes.Black, x, y)
        'printer.Graphics.DrawString("Price", New Font(f, FontStyle.Bold), Brushes.Black, x + (PrintAreaWidth * 0.8), y)

        'line under table header
        'printer.Graphics.DrawLine(Pens.Black, CSng(x), CSng((y + (rc + 1) * f.Height)), CSng(x + PrintAreaWidth), CSng((y + (rc + 1) * f.Height)))

        rc = 1

        Dim iTop As Integer = y

        y += 5

        Dim lines As ArrayList = ip.InvoiceLines
        For Each il As Elements.InvoiceLine In lines
            'we need to draw a table with all the inner lines
            'we will draw a rectangle around the table afterwards
            'For Each c As Integer In int
            'description
            printer.Graphics.DrawString(il.Description, sf, Brushes.Black, New Drawing.RectangleF(x, y, (PrintAreaWidth * 0.8), f.Height * 5))
            'If rc < lines.Count Then
            '    printer.Graphics.DrawLine(Pens.Black, CSng(x), CSng(y), CSng(x + PrintAreaWidth), CSng(y))
            'End If

            'amount
            printer.Graphics.DrawString(FormatNumber(il.Amount, 2), sf, Brushes.Black, New Drawing.RectangleF(x + (PrintAreaWidth * 0.8), y, (PrintAreaWidth * 0.2), f.Height * 5))
            'If rc < lines.Count Then
            '    printer.Graphics.DrawLine(Pens.Black, CSng(x), CSng(y), CSng(x + PrintAreaWidth), CSng(y))
            'End If
            'Next

            y += Math.Max(printer.Graphics.MeasureString(il.Description, sf, (PrintAreaWidth * 0.8)).Height, printer.Graphics.MeasureString(FormatNumber(il.Amount, 2), sf, (PrintAreaWidth * 0.2)).Height)

            If rc < lines.Count Then
                printer.Graphics.DrawLine(Pens.Black, CSng(x), CSng(y), CSng(x + PrintAreaWidth), CSng(y))
                y += 5
            End If

            rc += 1
        Next
        'border arount table
        printer.Graphics.DrawRectangle(Pens.Black, New Drawing.Rectangle(x, iTop, PrintAreaWidth, y - iTop))

        printer.Graphics.DrawLine(Pens.Black, CSng(x + PrintAreaWidth * 0.8), CSng(iTop), CSng(x + PrintAreaWidth * 0.8), CSng(y))

        ''set new y
        'y = y + (rc) * f.Height

        'draw invoice total
        Dim t As String = ""

        If ip.InclFoodstamps AndAlso ip.FoodStamps.Count > 0 Then
            t = "Incl. " & ip.FoodStamps.Count & " foodstamps"
            printer.Graphics.DrawString(t, sf, Brushes.Black, x, y)
        End If

        y += sf.Height + 20

        t = "Total: £ " & FormatNumber(ip.InvoiceTotal, 2)
        printer.Graphics.DrawString(t, New Font(f, FontStyle.Bold), Brushes.Black, x, y)

        y += f.Height + 50

        Dim iDots As Integer = x
        While iDots < PrintAreaWidth
            Dim iDot As Integer = 5
            printer.Graphics.DrawLine(Pens.Black, iDots, y, iDots + iDot, y)
            iDots += (iDot * 2)
        End While

        Return y
    End Function

    'Private Sub PrintInvoiceContent(ByVal printer As System.Drawing.Printing.PrintPageEventArgs)


    '    Dim PrintAreaHeight As Int32
    '    Dim PrintAreaWidth As Int32
    '    Dim marginLeft As Int32
    '    Dim marginTop As Int32

    '    'set the height and width of the entire print area
    '    PrintAreaHeight = ip.InvoiceHeight
    '    If chkPrintCopy.Checked Then
    '        PrintAreaHeight += ip.InvoiceHeight
    '    End If
    '    If bInclFoodstampInPrint Then
    '        PrintAreaHeight += ip.FoodStamps.Count * ip.FoodStampHeight
    '    End If

    '    PrintAreaWidth = 249

    '    ' initializing local variables to hold margin values that will serve
    '    ' as the X and Y coordinates for the upper left corner of the printing 
    '    ' area rectangle.
    '    marginLeft = 0
    '    marginTop = 5

    '    '##TEST
    '    If Data.Misc.IsDebugMode Then
    '        'put a rectangle around the whole printed area
    '        printer.Graphics.DrawRectangle(Pens.Red, marginLeft, marginTop, PrintAreaWidth, PrintAreaHeight)
    '    End If

    '    Dim y As Integer = marginTop

    '    '##
    '    y = PrintInvoicePart(printer, ip, PrintAreaWidth, marginTop, marginLeft, y, f, sf)
    '    y += 70

    '    Dim x As Integer = marginLeft 'the staring x of the table

    '    If ip.InclFoodstamps AndAlso ip.FoodStamps.Count > 0 Then
    '        'draw foodstamps
    '        For Each fs As Elements.FoodStamp In ip.FoodStamps

    '        Next
    '    End If

    '    y = y + 20

    '    '##
    '    If chkPrintCopy.Checked Then
    '        PrintInvoicePart(printer, ip, PrintAreaWidth, marginTop, marginLeft, y, f, sf)
    '    End If
    'End Sub

    Private Sub PrintFoodStamp(ByVal printer As System.Drawing.Printing.PrintPageEventArgs, ByVal iIndex As Integer)
        Dim x As Integer = 30 'the staring x of the table
        Dim y As Integer = 30
        Dim marginLeft As Integer = 0

        Dim iTop As Integer = x

        '##TEST
#If DEBUG Then
        'put a rectangle around the whole printed area
        printer.Graphics.DrawRectangle(Pens.Red, marginLeft, x, PrintAreaWidth, ip.FoodStampHeight)
#End If

        Dim fs As Elements.FoodStamp = ip.FoodStamps(iIndex)

        'header
        printer.Graphics.DrawString("MEAL VOUCHER", New Font(f, FontStyle.Bold), Brushes.Black, x, y)
        y += printer.Graphics.MeasureString("MEAL VOUCHER", New Font(f, FontStyle.Bold), PrintAreaWidth).Height

        'name
        'printer.Graphics.DrawString(ip.Resident.FirstName & " " & ip.Resident.LastName, f, Brushes.Black, x + 5, y + 5 + 18)
        printer.Graphics.DrawString(ip.Resident.FirstName & " " & ip.Resident.LastName, f, Brushes.Black, New Drawing.RectangleF(x, y, PrintAreaWidth - 10, ip.FoodStampHeight))
        y += printer.Graphics.MeasureString(ip.Resident.FirstName & " " & ip.Resident.LastName, New Font(f, FontStyle.Bold), PrintAreaWidth).Height

        'valid dates
        'printer.Graphics.DrawString("Gyldig i perioden " & Format(fs.ValidFrom, "dd MMMMM") & " - " & Format(fs.ValidTo, "dd MMMMM yyyy") & " incl.", sf, Brushes.Black, x + 5, y + 5 + 18 + 20)
        printer.Graphics.DrawString("Gyldig i perioden " & Format(fs.ValidFrom, "dd/MM") & " - " & Format(fs.ValidTo, "dd/MM yy") & " incl.", sf, Brushes.Black, New Drawing.RectangleF(x, y, PrintAreaWidth - 10, ip.FoodStampHeight))
        y += printer.Graphics.MeasureString("Gyldig i perioden " & Format(fs.ValidFrom, "dd/MM") & " - " & Format(fs.ValidTo, "dd/MM yy") & " incl.", New Font(f, FontStyle.Bold), PrintAreaWidth).Height

        'space before lines
        y += 45

        'to lines to cross out
        printer.Graphics.DrawLine(Pens.Black, CSng(x + (PrintAreaWidth * 0.15)), y, CSng(x + (PrintAreaWidth * 0.45)), y)
        printer.Graphics.DrawLine(Pens.Black, CSng(x + (PrintAreaWidth * 0.55)), y, CSng(x + (PrintAreaWidth * 0.85)), y)

        'space under lines
        y += 15

        'draw value
        'printer.Graphics.DrawString("Kuponen er personlig og kun gyldig i ovenstående periode.", sf, Brushes.Black, x + 5, y + 5 + 18 + 20 + 45 + 15)
        printer.Graphics.DrawString("Kuponen er personlig og kun gyldig i ovenstående periode.", sf, Brushes.Black, New Drawing.RectangleF(x, y, PrintAreaWidth - 10, ip.FoodStampHeight))
        y += printer.Graphics.MeasureString("Kuponen er personlig og kun gyldig i ovenstående periode.", New Font(f, FontStyle.Bold), PrintAreaWidth).Height
        'printer.Graphics.DrawString("Værdi £ 7.00 (frokost og aftensmad £ 3.50/1 kryds).", sf, Brushes.Black, x + 5, y + 5 + 18 + 20 + 45 + 15 + 10)
        Dim strFSValue As String = "Værdi £ " & fs.Value.ToString() & " (frokost og aftensmad £ " & (fs.Value / 2).ToString() & "/1 kryds)."
        printer.Graphics.DrawString(strFSValue, sf, Brushes.Black, New Drawing.RectangleF(x, y, PrintAreaWidth - 10, ip.FoodStampHeight))
        y += printer.Graphics.MeasureString(strFSValue, New Font(f, FontStyle.Bold), PrintAreaWidth).Height

        'draw recangle around whole thing
        printer.Graphics.DrawRectangle(Pens.Black, marginLeft, iTop, PrintAreaWidth, y - iTop)

        'set new y
        'space between foodstamps
        y += 10
    End Sub

    Private mInvPrinted As Boolean
    Private mNoFoodstamps As Integer
    Private mInvCopyPrinted As Boolean
    Private ip As Elements.InvoicePrint
    Private f As Font
    Private sf As Font 'small for invoice lines
    Private PrintAreaWidth As Integer

    Private Sub printInvoice_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printInvoice.PrintPage
        If Not mInvPrinted Then
            'PrintInvoiceContent(e)
            PrintInvoicePart(e)
            mInvPrinted = True
            If ip.InclFoodstamps Or chkPrintCopy.Checked Then
                e.HasMorePages = True
            End If
        ElseIf ip.FoodStamps.Count > mNoFoodstamps Then
            PrintFoodStamp(e, mNoFoodstamps)
            mNoFoodstamps += 1
            If ip.FoodStamps.Count > mNoFoodstamps Or (chkPrintCopy.Checked And Not mInvCopyPrinted) Then
                e.HasMorePages = True
            End If
        ElseIf chkPrintCopy.Checked And Not mInvCopyPrinted Then
            PrintInvoicePart(e)
            e.HasMorePages = False
        Else
            e.HasMorePages = False
        End If

    End Sub
End Class