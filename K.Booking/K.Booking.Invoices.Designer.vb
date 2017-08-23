<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class K_Booking_Invoices
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(K_Booking_Invoices))
        Me.lblResidentInvoices = New System.Windows.Forms.Label
        Me.lbxInvoices = New System.Windows.Forms.ListBox
        Me.lblInvoiceHeader = New System.Windows.Forms.Label
        Me.lblTotalAmount = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.chkIncludeFoodStamps = New System.Windows.Forms.CheckBox
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.printInvoice = New System.Drawing.Printing.PrintDocument
        Me.chkPrintCopy = New System.Windows.Forms.CheckBox
        Me.dgInvoiceLines = New System.Windows.Forms.DataGrid
        CType(Me.dgInvoiceLines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResidentInvoices
        '
        Me.lblResidentInvoices.AutoSize = True
        Me.lblResidentInvoices.Location = New System.Drawing.Point(12, 9)
        Me.lblResidentInvoices.Name = "lblResidentInvoices"
        Me.lblResidentInvoices.Size = New System.Drawing.Size(0, 13)
        Me.lblResidentInvoices.TabIndex = 0
        '
        'lbxInvoices
        '
        Me.lbxInvoices.FormattingEnabled = True
        Me.lbxInvoices.Location = New System.Drawing.Point(13, 26)
        Me.lbxInvoices.Name = "lbxInvoices"
        Me.lbxInvoices.Size = New System.Drawing.Size(282, 108)
        Me.lbxInvoices.TabIndex = 1
        '
        'lblInvoiceHeader
        '
        Me.lblInvoiceHeader.AutoSize = True
        Me.lblInvoiceHeader.Location = New System.Drawing.Point(12, 147)
        Me.lblInvoiceHeader.Name = "lblInvoiceHeader"
        Me.lblInvoiceHeader.Size = New System.Drawing.Size(0, 13)
        Me.lblInvoiceHeader.TabIndex = 2
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(295, 472)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalAmount.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(484, 467)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Luk"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(484, 26)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Udskriv"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'chkIncludeFoodStamps
        '
        Me.chkIncludeFoodStamps.AutoSize = True
        Me.chkIncludeFoodStamps.Checked = True
        Me.chkIncludeFoodStamps.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeFoodStamps.Location = New System.Drawing.Point(457, 55)
        Me.chkIncludeFoodStamps.Name = "chkIncludeFoodStamps"
        Me.chkIncludeFoodStamps.Size = New System.Drawing.Size(102, 17)
        Me.chkIncludeFoodStamps.TabIndex = 7
        Me.chkIncludeFoodStamps.Text = "Inkl. madbilletter"
        Me.chkIncludeFoodStamps.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'printInvoice
        '
        '
        'chkPrintCopy
        '
        Me.chkPrintCopy.AutoSize = True
        Me.chkPrintCopy.Checked = True
        Me.chkPrintCopy.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintCopy.Location = New System.Drawing.Point(457, 79)
        Me.chkPrintCopy.Name = "chkPrintCopy"
        Me.chkPrintCopy.Size = New System.Drawing.Size(70, 17)
        Me.chkPrintCopy.TabIndex = 8
        Me.chkPrintCopy.Text = "Print kopi"
        Me.chkPrintCopy.UseVisualStyleBackColor = True
        '
        'dgInvoiceLines
        '
        Me.dgInvoiceLines.AllowSorting = False
        Me.dgInvoiceLines.DataMember = ""
        Me.dgInvoiceLines.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgInvoiceLines.Location = New System.Drawing.Point(12, 213)
        Me.dgInvoiceLines.Name = "dgInvoiceLines"
        Me.dgInvoiceLines.Size = New System.Drawing.Size(542, 248)
        Me.dgInvoiceLines.TabIndex = 9
        '
        'K_Booking_Invoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 496)
        Me.Controls.Add(Me.dgInvoiceLines)
        Me.Controls.Add(Me.chkPrintCopy)
        Me.Controls.Add(Me.chkIncludeFoodStamps)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblInvoiceHeader)
        Me.Controls.Add(Me.lbxInvoices)
        Me.Controls.Add(Me.lblResidentInvoices)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "K_Booking_Invoices"
        Me.Text = "Betalingsoversigt"
        CType(Me.dgInvoiceLines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResidentInvoices As System.Windows.Forms.Label
    Friend WithEvents lbxInvoices As System.Windows.Forms.ListBox
    Friend WithEvents lblInvoiceHeader As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents chkIncludeFoodStamps As System.Windows.Forms.CheckBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents printInvoice As System.Drawing.Printing.PrintDocument
    Friend WithEvents chkPrintCopy As System.Windows.Forms.CheckBox
    Friend WithEvents dgInvoiceLines As System.Windows.Forms.DataGrid
End Class
