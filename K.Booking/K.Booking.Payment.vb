Imports System.Drawing.Printing

Public Class K_Booking_Payment
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblPaymentForResident As System.Windows.Forms.Label
    Friend WithEvents dgInvoiceLines As System.Windows.Forms.DataGrid
    Friend WithEvents gbxLongTerm As System.Windows.Forms.GroupBox
    Friend WithEvents lblPaymentPeriode As System.Windows.Forms.Label
    Friend WithEvents txtPaymentPeriod As System.Windows.Forms.TextBox
    Friend WithEvents cbxByCard As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnSaveInvoice As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents btnAbort As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents gbxGuest As System.Windows.Forms.GroupBox
    Friend WithEvents txtNONights As System.Windows.Forms.TextBox
    Friend WithEvents txtNOGuests As System.Windows.Forms.TextBox
    Friend WithEvents cbxInclDeposit As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPricePrNight As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents lblNOGuests As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNONights As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tabResidentType As System.Windows.Forms.TabControl
    Friend WithEvents tabLongTerm As System.Windows.Forms.TabPage
    Friend WithEvents tabGuest As System.Windows.Forms.TabPage
    Friend WithEvents tabAppartement As System.Windows.Forms.TabPage
    Friend WithEvents tabStaff As System.Windows.Forms.TabPage
    Friend WithEvents lblComment As System.Windows.Forms.Label
    Friend WithEvents grbAppartement As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAppartementQty As System.Windows.Forms.TextBox
    Friend WithEvents rbnWeeks As System.Windows.Forms.RadioButton
    Friend WithEvents rbnMonths As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAppartementPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gbxDeposit As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents cbxLatePayment As System.Windows.Forms.CheckBox
    Friend WithEvents btnLongTermPayInFull As System.Windows.Forms.Button
    Friend WithEvents lblDepositStatus As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblPaymentForResident = New System.Windows.Forms.Label
        Me.dgInvoiceLines = New System.Windows.Forms.DataGrid
        Me.gbxLongTerm = New System.Windows.Forms.GroupBox
        Me.txtPaymentPeriod = New System.Windows.Forms.TextBox
        Me.lblPaymentPeriode = New System.Windows.Forms.Label
        Me.cbxByCard = New System.Windows.Forms.CheckBox
        Me.btnCalc = New System.Windows.Forms.Button
        Me.btnSaveInvoice = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTotalAmount = New System.Windows.Forms.Label
        Me.btnAbort = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.gbxGuest = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblNONights = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblNOGuests = New System.Windows.Forms.Label
        Me.txtPricePrNight = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbxInclDeposit = New System.Windows.Forms.CheckBox
        Me.label6 = New System.Windows.Forms.Label
        Me.label5 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.txtNOGuests = New System.Windows.Forms.TextBox
        Me.txtNONights = New System.Windows.Forms.TextBox
        Me.tabResidentType = New System.Windows.Forms.TabControl
        Me.tabLongTerm = New System.Windows.Forms.TabPage
        Me.btnLongTermPayInFull = New System.Windows.Forms.Button
        Me.tabGuest = New System.Windows.Forms.TabPage
        Me.gbxDeposit = New System.Windows.Forms.GroupBox
        Me.lblDepositStatus = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtDeposit = New System.Windows.Forms.TextBox
        Me.tabAppartement = New System.Windows.Forms.TabPage
        Me.grbAppartement = New System.Windows.Forms.GroupBox
        Me.txtAppartementPrice = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.rbnMonths = New System.Windows.Forms.RadioButton
        Me.rbnWeeks = New System.Windows.Forms.RadioButton
        Me.txtAppartementQty = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.tabStaff = New System.Windows.Forms.TabPage
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblComment = New System.Windows.Forms.Label
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.cbxLatePayment = New System.Windows.Forms.CheckBox
        CType(Me.dgInvoiceLines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxLongTerm.SuspendLayout()
        Me.gbxGuest.SuspendLayout()
        Me.tabResidentType.SuspendLayout()
        Me.tabLongTerm.SuspendLayout()
        Me.tabGuest.SuspendLayout()
        Me.gbxDeposit.SuspendLayout()
        Me.tabAppartement.SuspendLayout()
        Me.grbAppartement.SuspendLayout()
        Me.tabStaff.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPaymentForResident
        '
        Me.lblPaymentForResident.Location = New System.Drawing.Point(8, 8)
        Me.lblPaymentForResident.Name = "lblPaymentForResident"
        Me.lblPaymentForResident.Size = New System.Drawing.Size(200, 120)
        Me.lblPaymentForResident.TabIndex = 0
        '
        'dgInvoiceLines
        '
        Me.dgInvoiceLines.AllowSorting = False
        Me.dgInvoiceLines.DataMember = ""
        Me.dgInvoiceLines.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgInvoiceLines.Location = New System.Drawing.Point(8, 336)
        Me.dgInvoiceLines.Name = "dgInvoiceLines"
        Me.dgInvoiceLines.Size = New System.Drawing.Size(542, 248)
        Me.dgInvoiceLines.TabIndex = 1
        '
        'gbxLongTerm
        '
        Me.gbxLongTerm.Controls.Add(Me.txtPaymentPeriod)
        Me.gbxLongTerm.Controls.Add(Me.lblPaymentPeriode)
        Me.gbxLongTerm.Location = New System.Drawing.Point(8, 8)
        Me.gbxLongTerm.Name = "gbxLongTerm"
        Me.gbxLongTerm.Size = New System.Drawing.Size(200, 48)
        Me.gbxLongTerm.TabIndex = 2
        Me.gbxLongTerm.TabStop = False
        Me.gbxLongTerm.Text = "Fast beboer"
        '
        'txtPaymentPeriod
        '
        Me.txtPaymentPeriod.Location = New System.Drawing.Point(160, 16)
        Me.txtPaymentPeriod.Name = "txtPaymentPeriod"
        Me.txtPaymentPeriod.Size = New System.Drawing.Size(32, 20)
        Me.txtPaymentPeriod.TabIndex = 1
        Me.txtPaymentPeriod.Text = "1"
        '
        'lblPaymentPeriode
        '
        Me.lblPaymentPeriode.Location = New System.Drawing.Point(8, 16)
        Me.lblPaymentPeriode.Name = "lblPaymentPeriode"
        Me.lblPaymentPeriode.Size = New System.Drawing.Size(104, 23)
        Me.lblPaymentPeriode.TabIndex = 0
        Me.lblPaymentPeriode.Text = "Antal uger"
        '
        'cbxByCard
        '
        Me.cbxByCard.Location = New System.Drawing.Point(232, 294)
        Me.cbxByCard.Name = "cbxByCard"
        Me.cbxByCard.Size = New System.Drawing.Size(112, 24)
        Me.cbxByCard.TabIndex = 2
        Me.cbxByCard.Text = "Betaling med kort"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(458, 267)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(88, 23)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "Skriv regning"
        '
        'btnSaveInvoice
        '
        'Me.btnSaveInvoice.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSaveInvoice.Location = New System.Drawing.Point(424, 619)
        Me.btnSaveInvoice.Name = "btnSaveInvoice"
        Me.btnSaveInvoice.Size = New System.Drawing.Size(104, 23)
        Me.btnSaveInvoice.TabIndex = 3
        Me.btnSaveInvoice.Text = "Gem og udskriv"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 587)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total: £ "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(426, 587)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalAmount.TabIndex = 5
        '
        'btnAbort
        '
        'Me.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.btnAbort.Location = New System.Drawing.Point(344, 619)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(75, 23)
        Me.btnAbort.TabIndex = 6
        Me.btnAbort.Text = "Annullér"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(232, 619)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 23)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Opdater regning"
        '
        'gbxGuest
        '
        Me.gbxGuest.Controls.Add(Me.Label7)
        Me.gbxGuest.Controls.Add(Me.lblNONights)
        Me.gbxGuest.Controls.Add(Me.Label4)
        Me.gbxGuest.Controls.Add(Me.lblNOGuests)
        Me.gbxGuest.Controls.Add(Me.txtPricePrNight)
        Me.gbxGuest.Controls.Add(Me.Label2)
        Me.gbxGuest.Controls.Add(Me.cbxInclDeposit)
        Me.gbxGuest.Controls.Add(Me.label6)
        Me.gbxGuest.Controls.Add(Me.label5)
        Me.gbxGuest.Controls.Add(Me.label3)
        Me.gbxGuest.Controls.Add(Me.txtNOGuests)
        Me.gbxGuest.Controls.Add(Me.txtNONights)
        Me.gbxGuest.Location = New System.Drawing.Point(8, 72)
        Me.gbxGuest.Name = "gbxGuest"
        Me.gbxGuest.Size = New System.Drawing.Size(296, 144)
        Me.gbxGuest.TabIndex = 8
        Me.gbxGuest.TabStop = False
        Me.gbxGuest.Text = "Gæst"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(184, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "nætter"
        '
        'lblNONights
        '
        Me.lblNONights.Location = New System.Drawing.Point(152, 16)
        Me.lblNONights.Name = "lblNONights"
        Me.lblNONights.Size = New System.Drawing.Size(32, 23)
        Me.lblNONights.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(104, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "gæster i"
        '
        'lblNOGuests
        '
        Me.lblNOGuests.Location = New System.Drawing.Point(72, 16)
        Me.lblNOGuests.Name = "lblNOGuests"
        Me.lblNOGuests.Size = New System.Drawing.Size(32, 23)
        Me.lblNOGuests.TabIndex = 7
        '
        'txtPricePrNight
        '
        Me.txtPricePrNight.Location = New System.Drawing.Point(80, 88)
        Me.txtPricePrNight.Name = "txtPricePrNight"
        Me.txtPricePrNight.Size = New System.Drawing.Size(104, 20)
        Me.txtPricePrNight.TabIndex = 6
        Me.txtPricePrNight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pris pr. nat £"
        '
        'cbxInclDeposit
        '
        Me.cbxInclDeposit.Location = New System.Drawing.Point(8, 112)
        Me.cbxInclDeposit.Name = "cbxInclDeposit"
        Me.cbxInclDeposit.Size = New System.Drawing.Size(136, 24)
        Me.cbxInclDeposit.TabIndex = 4
        Me.cbxInclDeposit.Text = "Fratræk depositum"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(8, 64)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(72, 23)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Antal nætter"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(8, 40)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(80, 23)
        Me.label5.TabIndex = 1
        Me.label5.Text = "Antal gæster"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(8, 16)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 23)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Betaling for"
        '
        'txtNOGuests
        '
        Me.txtNOGuests.Location = New System.Drawing.Point(88, 40)
        Me.txtNOGuests.Name = "txtNOGuests"
        Me.txtNOGuests.Size = New System.Drawing.Size(32, 20)
        Me.txtNOGuests.TabIndex = 3
        Me.txtNOGuests.Text = "1"
        '
        'txtNONights
        '
        Me.txtNONights.Location = New System.Drawing.Point(88, 64)
        Me.txtNONights.Name = "txtNONights"
        Me.txtNONights.Size = New System.Drawing.Size(32, 20)
        Me.txtNONights.TabIndex = 2
        Me.txtNONights.Text = "1"
        '
        'tabResidentType
        '
        Me.tabResidentType.Controls.Add(Me.tabLongTerm)
        Me.tabResidentType.Controls.Add(Me.tabGuest)
        Me.tabResidentType.Controls.Add(Me.tabAppartement)
        Me.tabResidentType.Controls.Add(Me.tabStaff)
        Me.tabResidentType.Location = New System.Drawing.Point(230, 13)
        Me.tabResidentType.Name = "tabResidentType"
        Me.tabResidentType.SelectedIndex = 0
        Me.tabResidentType.Size = New System.Drawing.Size(320, 248)
        Me.tabResidentType.TabIndex = 9
        '
        'tabLongTerm
        '
        Me.tabLongTerm.Controls.Add(Me.btnLongTermPayInFull)
        Me.tabLongTerm.Controls.Add(Me.gbxLongTerm)
        Me.tabLongTerm.Location = New System.Drawing.Point(4, 22)
        Me.tabLongTerm.Name = "tabLongTerm"
        Me.tabLongTerm.Size = New System.Drawing.Size(312, 222)
        Me.tabLongTerm.TabIndex = 0
        Me.tabLongTerm.Text = "Fast/korttids"
        '
        'btnLongTermPayInFull
        '
        Me.btnLongTermPayInFull.Location = New System.Drawing.Point(123, 186)
        Me.btnLongTermPayInFull.Name = "btnLongTermPayInFull"
        Me.btnLongTermPayInFull.Size = New System.Drawing.Size(177, 23)
        Me.btnLongTermPayInFull.TabIndex = 3
        Me.btnLongTermPayInFull.Text = "Betaling for hele perioden"
        Me.btnLongTermPayInFull.UseVisualStyleBackColor = True
        '
        'tabGuest
        '
        Me.tabGuest.Controls.Add(Me.gbxDeposit)
        Me.tabGuest.Controls.Add(Me.gbxGuest)
        Me.tabGuest.Location = New System.Drawing.Point(4, 22)
        Me.tabGuest.Name = "tabGuest"
        Me.tabGuest.Size = New System.Drawing.Size(312, 222)
        Me.tabGuest.TabIndex = 1
        Me.tabGuest.Text = "Gæst"
        '
        'gbxDeposit
        '
        Me.gbxDeposit.Controls.Add(Me.lblDepositStatus)
        Me.gbxDeposit.Controls.Add(Me.Label11)
        Me.gbxDeposit.Controls.Add(Me.txtDeposit)
        Me.gbxDeposit.Location = New System.Drawing.Point(8, 8)
        Me.gbxDeposit.Name = "gbxDeposit"
        Me.gbxDeposit.Size = New System.Drawing.Size(296, 64)
        Me.gbxDeposit.TabIndex = 9
        Me.gbxDeposit.TabStop = False
        Me.gbxDeposit.Text = "Depositum"
        '
        'lblDepositStatus
        '
        Me.lblDepositStatus.Location = New System.Drawing.Point(8, 16)
        Me.lblDepositStatus.Name = "lblDepositStatus"
        Me.lblDepositStatus.Size = New System.Drawing.Size(272, 23)
        Me.lblDepositStatus.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 23)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Depositum: £"
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(80, 40)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(100, 20)
        Me.txtDeposit.TabIndex = 0
        '
        'tabAppartement
        '
        Me.tabAppartement.Controls.Add(Me.grbAppartement)
        Me.tabAppartement.Location = New System.Drawing.Point(4, 22)
        Me.tabAppartement.Name = "tabAppartement"
        Me.tabAppartement.Size = New System.Drawing.Size(312, 222)
        Me.tabAppartement.TabIndex = 2
        Me.tabAppartement.Text = "Kollegie"
        '
        'grbAppartement
        '
        Me.grbAppartement.Controls.Add(Me.txtAppartementPrice)
        Me.grbAppartement.Controls.Add(Me.Label9)
        Me.grbAppartement.Controls.Add(Me.rbnMonths)
        Me.grbAppartement.Controls.Add(Me.rbnWeeks)
        Me.grbAppartement.Controls.Add(Me.txtAppartementQty)
        Me.grbAppartement.Controls.Add(Me.Label8)
        Me.grbAppartement.Location = New System.Drawing.Point(8, 8)
        Me.grbAppartement.Name = "grbAppartement"
        Me.grbAppartement.Size = New System.Drawing.Size(296, 96)
        Me.grbAppartement.TabIndex = 0
        Me.grbAppartement.TabStop = False
        Me.grbAppartement.Text = "Kollegie"
        '
        'txtAppartementPrice
        '
        Me.txtAppartementPrice.Location = New System.Drawing.Point(48, 64)
        Me.txtAppartementPrice.Name = "txtAppartementPrice"
        Me.txtAppartementPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtAppartementPrice.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 23)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "á £"
        '
        'rbnMonths
        '
        Me.rbnMonths.Checked = True
        Me.rbnMonths.Location = New System.Drawing.Point(208, 32)
        Me.rbnMonths.Name = "rbnMonths"
        Me.rbnMonths.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbnMonths.Size = New System.Drawing.Size(72, 24)
        Me.rbnMonths.TabIndex = 3
        Me.rbnMonths.TabStop = True
        Me.rbnMonths.Text = "måneder"
        '
        'rbnWeeks
        '
        Me.rbnWeeks.Location = New System.Drawing.Point(160, 32)
        Me.rbnWeeks.Name = "rbnWeeks"
        Me.rbnWeeks.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbnWeeks.Size = New System.Drawing.Size(48, 24)
        Me.rbnWeeks.TabIndex = 2
        Me.rbnWeeks.Text = "uger"
        '
        'txtAppartementQty
        '
        Me.txtAppartementQty.Location = New System.Drawing.Point(112, 32)
        Me.txtAppartementQty.Name = "txtAppartementQty"
        Me.txtAppartementQty.Size = New System.Drawing.Size(40, 20)
        Me.txtAppartementQty.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Der skal betales for"
        '
        'tabStaff
        '
        Me.tabStaff.Controls.Add(Me.Label10)
        Me.tabStaff.Location = New System.Drawing.Point(4, 22)
        Me.tabStaff.Name = "tabStaff"
        Me.tabStaff.Size = New System.Drawing.Size(312, 222)
        Me.tabStaff.TabIndex = 3
        Me.tabStaff.Text = "Staff"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(296, 120)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "For beboertypen ""staff""  kan du selv skrive en regning."
        '
        'lblComment
        '
        Me.lblComment.Location = New System.Drawing.Point(8, 136)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(200, 152)
        Me.lblComment.TabIndex = 10
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'cbxLatePayment
        '
        Me.cbxLatePayment.AutoSize = True
        Me.cbxLatePayment.Location = New System.Drawing.Point(232, 271)
        Me.cbxLatePayment.Name = "cbxLatePayment"
        Me.cbxLatePayment.Size = New System.Drawing.Size(150, 17)
        Me.cbxLatePayment.TabIndex = 11
        Me.cbxLatePayment.Text = "Gebyr ved for sen betaling"
        Me.cbxLatePayment.UseVisualStyleBackColor = True
        '
        'K_Booking_Payment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(557, 653)
        Me.Controls.Add(Me.cbxLatePayment)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.tabResidentType)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAbort)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveInvoice)
        Me.Controls.Add(Me.dgInvoiceLines)
        Me.Controls.Add(Me.lblPaymentForResident)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.cbxByCard)
        Me.Name = "K_Booking_Payment"
        Me.Text = "K_Booking_Payment"
        CType(Me.dgInvoiceLines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxLongTerm.ResumeLayout(False)
        Me.gbxLongTerm.PerformLayout()
        Me.gbxGuest.ResumeLayout(False)
        Me.gbxGuest.PerformLayout()
        Me.tabResidentType.ResumeLayout(False)
        Me.tabLongTerm.ResumeLayout(False)
        Me.tabGuest.ResumeLayout(False)
        Me.gbxDeposit.ResumeLayout(False)
        Me.gbxDeposit.PerformLayout()
        Me.tabAppartement.ResumeLayout(False)
        Me.grbAppartement.ResumeLayout(False)
        Me.grbAppartement.PerformLayout()
        Me.tabStaff.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Members "

    Private mIntResidentID As Integer
    Private mObjResident As Elements.Resident

    Private mIntUserID As Integer

    Private mDblLongTermHigh As Double
    Private mDblLongTermLow As Double
    Private mDblShortTermPrNight As Double
    Private mDblGuestRoomDeposit As Double
    Private mDblLatePaymentFee As Double
    Private mDblFoodTicket As Double
    Private mDblCardFee As Double

    Private mBooAlowAbort As Boolean

    Private mIntHolidays As Integer

    Private mDatTempPaidUntil As DateTime
    Private mDblTotalAmount As Double

    'Private mArrLines As New ArrayList
    Private mTable As DataTable
    Private mObjResetLines As ArrayList
    Private mObjHandledTypes As ArrayList

    Private mAddress As String

#End Region

#Region " Close "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
#End Region

#Region " Properties "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property UserID() As Integer
        Get
            Return mIntUserID
        End Get
        Set(ByVal Value As Integer)
            mIntUserID = Value
        End Set
    End Property

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
#End Region

#Region " Load "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub K_Booking_Payment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mAddress = Data.Misc.GetHomeAddress

        Dim strComment As String = ""
        For Each row As DataRow In mObjResident.Comments.List(mObjResident.ID).Tables(0).Rows
            strComment &= row("K_ResidentCreatedDate") & ": " & row("K_ResidentComment")
            If Data.Misc.ConvertToBoolean(row("K_ResidentSpecialAttention")) Then
                strComment &= vbNewLine & " - Særlig opmærksomhed"
            End If
            strComment &= vbNewLine
        Next
        Me.lblPaymentForResident.Text = mObjResident.FirstName & " " & mObjResident.LastName & " dato: " & Format(Now, "dd-MM-yyyy") & vbNewLine & _
        mAddress

        If Not strComment = String.Empty Then
            Me.lblComment.Text = "Kommentarer:" & vbNewLine & strComment
        End If

        If mObjResident.PaidUntil = Data.Misc.DefaultDate Then
            mDatTempPaidUntil = mObjResident.ArrivalDate
        Else
            mDatTempPaidUntil = mObjResident.PaidUntil
        End If

        mDatTempPaidUntil = mDatTempPaidUntil.AddDays(1)

        mTable = New DataTable
        mTable.TableName = "InvoiceLines"
        mTable.Columns.Add("PriceID", System.Type.GetType("System.Int32"))
        mTable.Columns.Add("Description", System.Type.GetType("System.String"))
        mTable.Columns.Add("Amount", System.Type.GetType("System.Decimal"))
        mTable.Columns.Add("FromDate", System.Type.GetType("System.DateTime"))
        mTable.Columns.Add("ToDate", System.Type.GetType("System.DateTime"))
        'mTable.Columns.Add("Test", System.Type.GetType("System.String"))

        mObjResetLines = New ArrayList
        mObjHandledTypes = New ArrayList

        Dim objType As New Elements.ResidentType
        Dim objInvoiceLine As New Elements.InvoiceLine

        Dim sDistincHax As String = ""

        'for each type this resident has had
        For Each objRow As DataRow In objType.ListUnHandled(mObjResident.ID).Tables(0).Rows
            If Not sDistincHax.IndexOf(objRow("K_ResidentTypeFromDate")) > -1 Then
                'if date the status changed is before paiduntil
                'If Data.Misc.ConvertToDateTime(objRow("K_ResidentTypeFromDate")) < mDatTempPaidUntil Then
                Select Case Data.Misc.ConvertToInt(objRow("K_ResidentType"))
                    Case Data.GlobalEnums.ResidentType.LongTerm
                        'was short term, is now long term (we must assume)
                        'all lines from fromdate and on should be summed up,
                        Dim dblAmount As Double
                        For Each objRowLine As DataRow In objInvoiceLine.List(Data.Misc.ConvertToDateTime(objRow("K_ResidentTypeFromDate")), mObjResident.ID).Tables(0).Rows
                            dblAmount += Data.Misc.ConvertToDouble(objRowLine("K_InvoiceLineAmount"))
                            mObjResetLines.Add(Data.Misc.ConvertToInt(objRowLine("K_InvoiceLineID")))
                        Next
                        If dblAmount > 0 Then
                            mTable.Rows.Add(New Object() {CInt(Data.GlobalEnums.PriceDesctiption.Other), "Old rent (" & Data.Misc.ConvertToDateTime(objRow("K_ResidentTypeFromDate")) & " - " & mDatTempPaidUntil & ") incl.", FormatNumber(-dblAmount, 2), Data.Misc.ConvertToDateTime(objRow("K_ResidentTypeFromDate")), mDatTempPaidUntil})
                            mDatTempPaidUntil = Data.Misc.ConvertToDateTime(objRow("K_ResidentTypeFromDate"))
                        End If
                        'resident is considered longterm from that date
                        'write new bill and subtract sum
                        'upon save old lines should be set to -1
                    Case Data.GlobalEnums.ResidentType.ShortTerm
                        'was long term, resident is leaving before time
                        'sum up entire amount, write new bill for whole period in short term, subtract sum
                        Dim dblAmount As Double
                        Dim dFoodStamps As Double = 0
                        Dim iCount As Integer = 0
                        Dim oPrice As New Elements.Price
                        'For Each objRowLine As DataRow In objInvoiceLine.List(objRow("K_InvoiceID"), mObjResident.ArrivalDate).Tables(0).Rows
                        For Each objRowLine As DataRow In objInvoiceLine.List(mObjResident.ArrivalDate, mObjResident.ID).Tables(0).Rows
                            dblAmount += Data.Misc.ConvertToDouble(objRowLine("K_InvoiceLineAmount"))
                            dFoodStamps += oPrice.GetFoodstampPrice(Data.Misc.ConvertToDateTime(objRowLine("K_InvoiceLineFrom")))
                            iCount += 1
                            mObjResetLines.Add(Data.Misc.ConvertToInt(objRowLine("K_InvoiceLineID")))
                        Next
                        If dblAmount > 0 Then
                            mTable.Rows.Add(New Object() {CInt(Data.GlobalEnums.PriceDesctiption.Other), "Old rent (" & mObjResident.ArrivalDate & " - " & mDatTempPaidUntil.AddDays(-1) & ") incl.", FormatNumber(-dblAmount, 2), mObjResident.ArrivalDate, mDatTempPaidUntil})
                            mTable.Rows.Add(New Object() {CInt(Data.GlobalEnums.PriceDesctiption.Other), "Mealvouchers (" & iCount & ")", FormatNumber(dFoodStamps, 2), mObjResident.ArrivalDate, mDatTempPaidUntil})
                            mDatTempPaidUntil = mObjResident.ArrivalDate
                        End If
                        'upon save set old lines to -1
                End Select
                sDistincHax &= "¦" & objRow("K_ResidentTypeFromDate")
            End If

            mObjHandledTypes.Add(Data.Misc.ConvertToInt(objRow("K_ResidentTypeID")))
        Next

        Me.lblTotalAmount.Text = "0.00"

        Select Case mObjResident.Type.Type
            Case Data.GlobalEnums.ResidentType.Guest
                Me.tabResidentType.SelectedTab = Me.tabGuest
                Me.tabAppartement.Enabled = False
                Me.tabLongTerm.Enabled = False
                Me.tabStaff.Enabled = False
                Me.txtPricePrNight.Focus()

                Dim iNightsPaid As Integer = mObjResident.PaidUntil.Subtract(mObjResident.ArrivalDate).TotalDays

                WriteGuestSummary(mObjResident.Type.NumberOfGuests, mObjResident.DepartureDate.Subtract(mObjResident.ArrivalDate).TotalDays - 1 - iNightsPaid, mObjResident.PaidUntil)
                Me.txtNOGuests.Focus()
                txtNOGuests.Enabled = False
                If Not objInvoiceLine.HasPaidDeposit(mObjResident.ID) Then
                    UpdatePrices(mObjResident.ArrivalDate)
                    Me.txtDeposit.Text = mDblGuestRoomDeposit
                    Me.lblDepositStatus.Text = "Der er endnu ikke betalt depositum for værelset."
                    'Me.cbxInclDeposit.Enabled = False
                Else
                    Me.txtDeposit.Enabled = False
                    Me.lblDepositStatus.Text = "Der er betalt £ " & objInvoiceLine.Amount & " i depositum."
                End If
            Case Data.GlobalEnums.ResidentType.ShortTerm
                Me.tabResidentType.SelectedTab = Me.tabLongTerm
                Me.tabAppartement.Enabled = False
                Me.tabGuest.Enabled = False
                Me.tabStaff.Enabled = False
                Me.gbxLongTerm.Text = "Korttidsbeboer"
                Me.lblPaymentPeriode.Text = "Antal dage"
                Me.txtPaymentPeriod.Focus()
            Case Data.GlobalEnums.ResidentType.LongTerm
                Me.tabResidentType.SelectedTab = Me.tabLongTerm
                Me.tabAppartement.Enabled = False
                Me.tabGuest.Enabled = False
                Me.tabStaff.Enabled = False
                Me.gbxLongTerm.Text = "Fast beboer"
                Me.lblPaymentPeriode.Text = "Antal uger"
                Me.txtPaymentPeriod.Focus()
            Case Data.GlobalEnums.ResidentType.Appartement
                Me.tabResidentType.SelectedTab = Me.tabAppartement
                Me.tabGuest.Enabled = False
                Me.tabLongTerm.Enabled = False
                Me.tabStaff.Enabled = False
                Me.txtAppartementQty.Focus()
            Case Data.GlobalEnums.ResidentType.Staff
                Me.tabResidentType.SelectedTab = Me.tabStaff
                Me.tabAppartement.Enabled = False
                Me.tabLongTerm.Enabled = False
                Me.tabGuest.Enabled = False
        End Select

        'Dim objTable As New DataTable
        'objTable.Columns.Add("Beskrivelse")
        'objTable.Columns.Add("Pris")
        'objTable.Rows.Add(New Object() {"test", "£200"})
        'objTable.Rows.Add(New Object() {"mere test", "£15,00"})
        'objTable.AcceptChanges()

        'Me.dgInvoiceLines.DataSource = objTable

        mBooAlowAbort = True
    End Sub
#End Region

#Region " Prices "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="datValidDate"></param>
    ''' <remarks></remarks>
    Private Sub UpdatePrices(ByVal datValidDate As DateTime)
        Dim objPriceSet As New Elements.PriceSet
        Dim objPrice As New Elements.Price
        Dim objDataset As DataSet

        objPriceSet.FetchValidPriceSet(datValidDate)
        objDataset = objPrice.GetPrices(objPriceSet.ID)

        mDblLongTermLow = Data.Misc.ConvertToDouble(objDataset.Tables(0).Rows(Data.GlobalEnums.PriceDesctiption.LongTermLow - 1).Item("K_PriceAmount"))
        mDblLongTermHigh = Data.Misc.ConvertToDouble(objDataset.Tables(0).Rows(Data.GlobalEnums.PriceDesctiption.LongTermHigh - 1).Item("K_PriceAmount"))
        mDblShortTermPrNight = Data.Misc.ConvertToDouble(objDataset.Tables(0).Rows(Data.GlobalEnums.PriceDesctiption.ShortTerm - 1).Item("K_PriceAmount"))
        mDblGuestRoomDeposit = Data.Misc.ConvertToDouble(objDataset.Tables(0).Rows(Data.GlobalEnums.PriceDesctiption.GuestRoomDeposit - 1).Item("K_PriceAmount"))
        mDblFoodTicket = Data.Misc.ConvertToDouble(objDataset.Tables(0).Rows(Data.GlobalEnums.PriceDesctiption.FoodTicket - 1).Item("K_PriceAmount"))
        mDblLatePaymentFee = Data.Misc.ConvertToDouble(objDataset.Tables(0).Rows(Data.GlobalEnums.PriceDesctiption.LatePaymentFee - 1).Item("K_PriceAmount"))
        mDblCardFee = Data.Misc.ConvertToDouble(objDataset.Tables(0).Rows(Data.GlobalEnums.PriceDesctiption.CardPaymentFee - 1).Item("K_PriceAmount"))
    End Sub
#End Region

#Region " Guests "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="intNOGuests"></param>
    ''' <param name="intNONights"></param>
    ''' <param name="datPaidUntil"></param>
    ''' <remarks></remarks>
    Private Sub WriteGuestSummary(ByVal intNOGuests As Integer, ByVal intNONights As Integer, ByVal datPaidUntil As DateTime)
        Me.txtNOGuests.Text = intNOGuests
        Me.txtNONights.Text = intNONights
        Me.lblNOGuests.Text = intNOGuests
        Me.lblNONights.Text = intNONights
        If intNOGuests = 0 Then
            mBooAlowAbort = True
        End If
    End Sub
#End Region

#Region " Calculate payment "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        CalculatePayment()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CalculatePayment()
        mIntHolidays = 0

        Select Case mObjResident.Type.Type
            Case Data.GlobalEnums.ResidentType.Guest
                mBooAlowAbort = False
                If Not Me.txtDeposit.Text = String.Empty Then
                    If IsNumeric(Me.txtDeposit.Text) Then
                        mTable.Rows.Add(New Object() {CInt(Data.GlobalEnums.PriceDesctiption.GuestRoomDeposit), "Deposit", FormatNumber(Me.txtDeposit.Text, 2), Data.Misc.DefaultDate, Data.Misc.DefaultDate})
                    Else
                        MessageBox.Show("Prisen for et depositum skal angives med beløb i £")
                        Exit Sub
                    End If
                End If
                If IsNumeric(Me.txtNONights.Text) AndAlso IsNumeric(Me.txtNONights.Text) AndAlso IsNumeric(Me.txtPricePrNight.Text) Then
                    Dim intNOGuests As Integer = CInt(Me.txtNOGuests.Text)
                    Dim intNONights As Integer = CInt(Me.txtNONights.Text)
                    Dim dblPricePrNight As Double = CDbl(Me.txtPricePrNight.Text)

                    If intNOGuests > CInt(Me.lblNOGuests.Text) OrElse intNONights > CInt(Me.lblNONights.Text) Then
                        MessageBox.Show("Du kan ikke betale for flere gæster end der er tilknyttet." & vbNewLine & "Du kan ikke betale for flere nætter end angivet.")
                        Exit Sub
                    Else
                        UpdatePrices(mDatTempPaidUntil)
                        'Dim objLine As New Elements.InvoiceLine
                        'objLine.Description = "Rent (" & mDatTempPaidUntil & " - " & mDatTempPaidUntil.AddDays(intNONights) & " for " & intNOGuests & " gæster á £ " & dblPricePrNight & " pr. nat)"
                        'objLine.Amount = intNOGuests * intNONights * dblpriceprnight
                        'objLine.PriceID = Data.GlobalEnums.PriceDesctiption.Other
                        'mTable.Rows.Add(New Object() {Data.GlobalEnums.PriceDesctiption.Guest, "Rent (" & mDatTempPaidUntil & " - " & mDatTempPaidUntil.AddDays(intNONights) & " incl. for " & intNOGuests & " á £ " & dblPricePrNight & " pr. nat)", FormatNumber(intNOGuests * intNONights * dblPricePrNight, 2), Data.Misc.DefaultDate, Data.Misc.DefaultDate})
                        'mTable.Rows.Add(New Object() {Data.GlobalEnums.PriceDesctiption.Guest, "Rent (" & mDatTempPaidUntil & " - " & mDatTempPaidUntil.AddDays(intNONights) & ") incl.", FormatNumber(intNOGuests * intNONights * dblPricePrNight, 2), Data.Misc.DefaultDate, Data.Misc.DefaultDate})
                        mTable.Rows.Add(New Object() {CInt(Data.GlobalEnums.PriceDesctiption.Guest), "Rent (" & mDatTempPaidUntil & " - " & mDatTempPaidUntil.AddDays(intNONights - 1) & ") incl.", FormatNumber(intNONights * dblPricePrNight, 2), Data.Misc.DefaultDate, Data.Misc.DefaultDate})
                        mDatTempPaidUntil = mDatTempPaidUntil.AddDays(intNONights)
                        'mArrLines.Add(objLine)
                        WriteGuestSummary(mObjResident.Type.NumberOfGuests - intNOGuests, lblNONights.Text - txtNONights.Text, mDatTempPaidUntil)
                    End If

                    If Me.cbxInclDeposit.Checked Then
                        GuestRoomDeposit()
                    End If
                End If
                'If Me.cbxInclDeposit.Checked Then
                '    GuestRoomDeposit()
                '    'Else
                '    '    MessageBox.Show("Både antallet af gæster, nætter og priser skal angives med tal.")
                '    '    Exit Sub
                'End If

                If Me.cbxByCard.Checked Then
                    CreditCardFee(Data.GlobalEnums.PriceDesctiption.CCFeeShortTerm)
                End If

                If Me.cbxLatePayment.Checked Then
                    LatePaymentFee(Data.GlobalEnums.PriceDesctiption.LateFeeShortTerm)
                End If

            Case Data.GlobalEnums.ResidentType.ShortTerm
                'validate input
                If IsNumeric(Me.txtPaymentPeriod.Text) Then
                    Dim intNumberOfNights As Integer = Math.Min(CInt(Me.txtPaymentPeriod.Text), mObjResident.DepartureDate.Subtract(mDatTempPaidUntil).TotalDays)
                    Dim dblPricePrNight As Double = 0
                    Dim iDaysPaidFor As Integer = 0

                    'Dim objLine As New Elements.InvoiceLine
                    'objLine.Description = "Rent (" & mDatTempPaidUntil & " - " & mDatTempPaidUntil.AddDays(intNumberOfNights) & " á £ " & mDblShortTermPrNight & " pr. nat)"
                    'objLine.Amount = mDblShortTermPrNight * intNumberOfNights
                    'objLine.PriceID = Data.GlobalEnums.PriceDesctiption.ShortTerm


                    For iDay As Integer = 0 To intNumberOfNights
                        If dblPricePrNight <> mDblShortTermPrNight Then
                            If dblPricePrNight > 0 Then
                                'mTable.Rows.Add(New Object() {Data.GlobalEnums.PriceDesctiption.ShortTerm, "Rent (" & mDatTempPaidUntil & " - " & mDatTempPaidUntil.AddDays(iDay) & " á £ " & mDblShortTermPrNight & " pr. nat)", FormatNumber(mDblShortTermPrNight * iDay - iDaysPaidFor, 2), mDatTempPaidUntil, mDatTempPaidUntil.AddDays(iDay - iDaysPaidFor)})
                                mTable.Rows.Add(New Object() {CInt(Data.GlobalEnums.PriceDesctiption.ShortTerm), "Rent (" & mDatTempPaidUntil & " - " & mDatTempPaidUntil.AddDays(iDay - 1) & ") incl.", FormatNumber(mDblShortTermPrNight * iDay - iDaysPaidFor, 2), mDatTempPaidUntil, mDatTempPaidUntil.AddDays(iDay - iDaysPaidFor - 1)})
                                mDatTempPaidUntil = mDatTempPaidUntil.AddDays(iDay - iDaysPaidFor)
                                iDaysPaidFor = iDay
                            End If
                            dblPricePrNight = mDblShortTermPrNight
                        End If
                        'set prices
                        UpdatePrices(mDatTempPaidUntil.AddDays(iDay))
                    Next
                    If intNumberOfNights > iDaysPaidFor Then
                        'mTable.Rows.Add(New Object() {Data.GlobalEnums.PriceDesctiption.ShortTerm, "Rent (" & mDatTempPaidUntil & " - " & mDatTempPaidUntil.AddDays(intNumberOfNights - iDaysPaidFor) & " á £ " & mDblShortTermPrNight & " pr. nat)", FormatNumber(mDblShortTermPrNight * intNumberOfNights - iDaysPaidFor, 2), mDatTempPaidUntil, mDatTempPaidUntil.AddDays(intNumberOfNights - iDaysPaidFor)})
                        mTable.Rows.Add(New Object() {CInt(Data.GlobalEnums.PriceDesctiption.ShortTerm), "Rent (" & mDatTempPaidUntil & " - " & mDatTempPaidUntil.AddDays(intNumberOfNights - iDaysPaidFor - 1) & ") incl.", FormatNumber(mDblShortTermPrNight * intNumberOfNights - iDaysPaidFor, 2), mDatTempPaidUntil, mDatTempPaidUntil.AddDays(intNumberOfNights - iDaysPaidFor - 1)})
                        mDatTempPaidUntil = mDatTempPaidUntil.AddDays(intNumberOfNights - iDaysPaidFor)
                    End If
                    'mArrLines.Add(objLine)
                Else
                    MessageBox.Show("Du skal angive med heltal hvor mange nætter " & mObjResident.FirstName & " ønsker at betale for.")
                End If

                If Me.cbxByCard.Checked Then
                    CreditCardFee(Data.GlobalEnums.PriceDesctiption.CCFeeShortTerm)
                End If

                If Me.cbxLatePayment.Checked Then
                    LatePaymentFee(Data.GlobalEnums.PriceDesctiption.LateFeeShortTerm)
                End If

            Case Data.GlobalEnums.ResidentType.LongTerm
                Dim bUnder4 As Boolean = False
                'validate input
                If IsNumeric(Me.txtPaymentPeriod.Text) Then
                    'check for holiday
                    Dim objDataset As DataSet = mObjResident.CheckHoliday(mDatTempPaidUntil, mDatTempPaidUntil.AddDays(6 * CInt(Me.txtPaymentPeriod.Text)))
                    Dim datFrom As DateTime
                    Dim datTo As DateTime

                    Dim datHolidayStart As DateTime

                    Dim iHolidays As Integer = 0
                    mIntHolidays = 0

                    If objDataset.Tables(0).Rows.Count > 0 Then
                        'the resident has a holiday coming up
                        For Each row As DataRow In objDataset.Tables(0).Rows
                            datFrom = Data.Misc.ConvertToDateTime(row("K_HolidayFromDate"))
                            datTo = Data.Misc.ConvertToDateTime(row("K_HolidayToDate"))

                            datHolidayStart = datFrom
                            While datFrom < datTo.AddDays(1)
                                If datFrom >= mDatTempPaidUntil Then ' AndAlso datFrom < mDatTempPaidUntil.AddDays(6 * CInt(Me.txtPaymentPeriod.Text)) Then
                                    iHolidays += 1
                                End If
                                datFrom = datFrom.AddDays(1)
                            End While
                        Next
                    End If

                    For intI As Integer = 1 To CInt(Me.txtPaymentPeriod.Text)
                        Dim intNights As Integer
                        intNights = mObjResident.DepartureDate.Subtract(mDatTempPaidUntil).TotalDays() '- 1 '-1 because the departure date is set to the day they are leaving not the day of the last night there
                        If intNights > 0 Then 'only if there are more nights

                            'set prices for week
                            UpdatePrices(mDatTempPaidUntil)

                            If Not IsLowRate(mDatTempPaidUntil) Then
                                bUnder4 = True
                            Else
                                bUnder4 = False
                            End If

                            If datHolidayStart >= mDatTempPaidUntil AndAlso datHolidayStart <= mDatTempPaidUntil.AddDays(6) Then
                                mIntHolidays = iHolidays
                            Else
                                mIntHolidays = 0
                            End If

                            objDataset.Clear()

                            If IsPartialWeek(mDatTempPaidUntil) Then

                                Dim dblPricePrNight As Double


                                dblPricePrNight = mDblShortTermPrNight

                                Dim dblPricePrWeek As Double
                                dblPricePrWeek = mDblLongTermLow

                                Dim result As DialogResult
                                If dblPricePrWeek > intNights * mDblShortTermPrNight Then
                                    'cheaper to pay pr night
                                    'ask what user wants
                                    result = MessageBox.Show("Ønsker beboeren madbilletten?" & vbNewLine & "(Hel uge incl. madbillet: " & dblPricePrWeek & ")" & vbNewLine & "(" & intNights & " nætter á " & dblPricePrNight & ": " & intNights * dblPricePrNight & ")", "Vælg betalings periode", MessageBoxButtons.YesNoCancel)
                                    If result = DialogResult.Yes Then
                                        WholeWeek()
                                    ElseIf result = DialogResult.No Then
                                        PartialWeek()
                                    End If
                                Else
                                    'cheaper to pay for whole week
                                    WholeWeek()
                                End If
                            Else
                                WholeWeek()
                            End If
                        End If
                    Next
                Else
                    MessageBox.Show("Du skal angive med heltal hvor mange uger " & mObjResident.FirstName & " ønsker at betale for.")
                End If

                If Me.cbxByCard.Checked Then
                    If bUnder4 Then
                        CreditCardFee(Data.GlobalEnums.PriceDesctiption.CCFeeShortTerm)
                    Else
                        CreditCardFee(Data.GlobalEnums.PriceDesctiption.CCFeeLongTerm)
                    End If
                End If

                If Me.cbxLatePayment.Checked Then
                    If bUnder4 Then
                        LatePaymentFee(Data.GlobalEnums.PriceDesctiption.LateFeeShortTerm)
                    Else
                        LatePaymentFee(Data.GlobalEnums.PriceDesctiption.LateFeeLongTerm)
                    End If
                End If

            Case Data.GlobalEnums.ResidentType.Appartement
                If IsNumeric(Me.txtAppartementQty.Text) Then
                    If IsNumeric(Me.txtAppartementPrice.Text) Then
                        Dim sPeriod As String
                        Dim bIsWeek As Boolean
                        If Me.rbnWeeks.Checked Then
                            sPeriod = "uge"
                            bIsWeek = True
                        ElseIf Me.rbnMonths.Checked Then
                            sPeriod = "måned"
                            bIsWeek = False
                        End If
                        UpdatePrices(mDatTempPaidUntil)
                        For iQty As Integer = 1 To CInt(Me.txtAppartementQty.Text)
                            If bIsWeek Then
                                'mTable.Rows.Add(New Object() {Data.GlobalEnums.PriceDesctiption.Flat, "Rent (" & mDatTempPaidUntil & " - " & mDatTempPaidUntil.AddDays(6) & " á £ " & Me.txtAppartementPrice.Text & ")", FormatNumber(Me.txtAppartementPrice.Text, 2), mDatTempPaidUntil, mDatTempPaidUntil.AddDays(6)})
                                mTable.Rows.Add(New Object() {CInt(Data.GlobalEnums.PriceDesctiption.Flat), "Rent (" & mDatTempPaidUntil & " - " & mDatTempPaidUntil.AddDays(6) & ") incl.", FormatNumber(Me.txtAppartementPrice.Text, 2), mDatTempPaidUntil, mDatTempPaidUntil.AddDays(6)})
                                mDatTempPaidUntil = mDatTempPaidUntil.AddDays(7)
                            Else
                                'mTable.Rows.Add(New Object() {Data.GlobalEnums.PriceDesctiption.Flat, "Rent (" & mDatTempPaidUntil & " - " & mDatTempPaidUntil.Date.AddMonths(1).AddDays(-1) & " á £ " & Me.txtAppartementPrice.Text & ")", FormatNumber(Me.txtAppartementPrice.Text, 2), mDatTempPaidUntil, mDatTempPaidUntil.Date.AddMonths(1).AddDays(-1)})
                                mTable.Rows.Add(New Object() {CInt(Data.GlobalEnums.PriceDesctiption.Flat), "Rent (" & mDatTempPaidUntil & " - " & mDatTempPaidUntil.Date.AddMonths(1).AddDays(-1) & ") incl.", FormatNumber(Me.txtAppartementPrice.Text, 2), mDatTempPaidUntil, mDatTempPaidUntil.Date.AddMonths(1).AddDays(-1)})
                                mDatTempPaidUntil = mDatTempPaidUntil.AddMonths(1)
                            End If
                        Next
                    Else
                        MessageBox.Show("Du skal angive med tal hvad prisen er pr. uge/måned.", "Betaling", MessageBoxButtons.OK)
                    End If
                Else
                    MessageBox.Show("Du skal angive med heltal hvormange uger/måneder " & mObjResident.FirstName & " ønsker at betale for.", "Betaling", MessageBoxButtons.OK)
                End If

                If Me.cbxByCard.Checked Then
                    CreditCardFee(Data.GlobalEnums.PriceDesctiption.CCFeeFlat)
                End If

                If Me.cbxLatePayment.Checked Then
                    LatePaymentFee(Data.GlobalEnums.PriceDesctiption.LateFeeFlat)
                End If
        End Select

        'Me.btnCalc.Enabled = False
        'Me.cbxByCard.Enabled = False
        'Me.txtPaymentPeriod.Enabled = False

        ListLines()
    End Sub

#End Region

#Region " Pay in full "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnLongTermPayInFull_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLongTermPayInFull.Click
        Select Case mObjResident.Type.Type
            Case Data.GlobalEnums.ResidentType.LongTerm
                txtPaymentPeriod.Text = Math.Ceiling((mObjResident.DepartureDate.Subtract(mDatTempPaidUntil).TotalDays) / 7)
            Case Data.GlobalEnums.ResidentType.ShortTerm
                txtPaymentPeriod.Text = Math.Ceiling((mObjResident.DepartureDate.Subtract(mDatTempPaidUntil).TotalDays))
        End Select

        CalculatePayment()
    End Sub
#End Region

#Region " Fees "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="iPriceDescriptionID"></param>
    ''' <remarks></remarks>
    Private Sub CreditCardFee(ByVal iPriceDescriptionID As Integer)
        'Dim objLine As Elements.InvoiceLine
        'objLine = New Elements.InvoiceLine
        'objLine.Amount = mDblCardFee
        'objLine.PriceID = Data.GlobalEnums.PriceDesctiption.CardPaymentFee
        'objLine.Description = "Gebyr for betaling med kort."
        'mArrLines.Add(objLine)
        mTable.Rows.Add(New Object() {iPriceDescriptionID, "Credit Card Fee", FormatNumber(mDblCardFee, 2), Data.Misc.DefaultDate, Data.Misc.DefaultDate})
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="iPriceDescriptionID"></param>
    ''' <remarks></remarks>
    Private Sub LatePaymentFee(ByVal iPriceDescriptionID As Integer)
        'Dim objLine As Elements.InvoiceLine
        'objLine = New Elements.InvoiceLine
        'objLine.Amount = mDblCardFee
        'objLine.PriceID = Data.GlobalEnums.PriceDesctiption.CardPaymentFee
        'objLine.Description = "Gebyr for betaling med kort."
        'mArrLines.Add(objLine)
        mTable.Rows.Add(New Object() {iPriceDescriptionID, "Surcharge", FormatNumber(mDblLatePaymentFee, 2), Data.Misc.DefaultDate, Data.Misc.DefaultDate})
    End Sub
#End Region

#Region " Deposits for guest rooms "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GuestRoomDeposit()
        'Dim objLine As Elements.InvoiceLine
        'objLine = New Elements.InvoiceLine
        'objLine.Amount = mDblGuestRoomDeposit
        'objLine.PriceID = Data.GlobalEnums.PriceDesctiption.GuestRoomDeposit
        'objLine.Description = "Depositum for gæsteværelse."
        'mArrLines.Add(objLine)
        Dim objInvoiceLine As New Elements.InvoiceLine
        If objInvoiceLine.HasPaidDeposit(mObjResident.ID) Then
            mTable.Rows.Add(New Object() {CInt(Data.GlobalEnums.PriceDesctiption.GuestRoomDeposit), "Deposit for guest room.", FormatNumber(-objInvoiceLine.Amount, 2), Data.Misc.DefaultDate, Data.Misc.DefaultDate})
        Else
            mTable.Rows.Add(New Object() {CInt(Data.GlobalEnums.PriceDesctiption.GuestRoomDeposit), "Deposit for guest room.", FormatNumber(-mDblGuestRoomDeposit, 2), Data.Misc.DefaultDate, Data.Misc.DefaultDate})
        End If
    End Sub
#End Region

#Region " Whole week payment "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub WholeWeek()
        Dim dblAmount As Double = 0
        Dim intPriceID As Integer = 0
        'Dim objLine As Elements.InvoiceLine
        'objLine = New Elements.InvoiceLine
        'objLine.Description = "Rent (" & mDatTempPaidUntil & " - " & mDatTempPaidUntil.AddDays(7) & ")"
        If IsLowRate(mDatTempPaidUntil) Then
            'objLine.Amount = mDblLongTermLow
            'objLine.PriceID = Data.GlobalEnums.PriceDesctiption.LongTermLow
            dblAmount = mDblLongTermLow
            intPriceID = Data.GlobalEnums.PriceDesctiption.LongTermLow
        Else
            'objLine.Amount = mDblLongTermHigh
            'objLine.PriceID = Data.GlobalEnums.PriceDesctiption.LongTermHigh
            dblAmount = mDblLongTermHigh
            intPriceID = Data.GlobalEnums.PriceDesctiption.LongTermHigh
        End If
        Dim strExtraDescription As String = ""
        If mIntHolidays > 0 Then
            strExtraDescription = " (inkl. " & mIntHolidays & " feriedage)"
        End If

        Dim iNights As Integer = 7
        If mObjResident.DepartureDate.Subtract(mDatTempPaidUntil).TotalDays < 6 Then
            iNights = mObjResident.DepartureDate.Subtract(mDatTempPaidUntil).TotalDays
        End If

        mTable.Rows.Add(New Object() {intPriceID, "Rent (" & mDatTempPaidUntil & " - " & mDatTempPaidUntil.AddDays(iNights - 1).AddDays(mIntHolidays) & ") incl." & strExtraDescription, FormatNumber(dblAmount, 2), mDatTempPaidUntil, mDatTempPaidUntil.AddDays(iNights - 1).AddDays(mIntHolidays)})
        mDatTempPaidUntil = mDatTempPaidUntil.AddDays(iNights).AddDays(mIntHolidays)
        'mArrLines.Add(objLine)
    End Sub
#End Region

#Region " List lines "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ListLines()
        'add one empty row
        'mArrLines.Add(New Elements.InvoiceLine)
        Me.dgInvoiceLines.TableStyles.Clear()

        'Me.dgInvoiceLines.DataSource = mArrLines

        'Me.dgInvoiceLines.DataMember
        Me.dgInvoiceLines.Enabled = True

        mDblTotalAmount = 0
        'For Each objLine As Elements.InvoiceLine In mArrLines
        '    mDblTotalAmount += objLine.Amount
        'Next
        For Each row As DataRow In mTable.Rows
            mDblTotalAmount += row(2)
        Next
        Me.lblTotalAmount.Text = FormatNumber(mDblTotalAmount, 2)

        ''Me.dgInvoiceLines.SetDataBinding(mTable, "Table")
        'Me.dgInvoiceLines.DataSource = mTable
        'Dim ts As DataGridTableStyle = New DataGridTableStyle

        'ts.MappingName = Me.dgInvoiceLines.DataMember
        'Me.dgInvoiceLines.TableStyles.Add(ts)
        'Me.dgInvoiceLines.TableStyles(0).GridColumnStyles.RemoveAt(0)
        'Me.dgInvoiceLines.TableStyles(0).GridColumnStyles(0).Width = 385
        'Me.dgInvoiceLines.TableStyles(0).GridColumnStyles(1).Width = 115
        'Me.dgInvoiceLines.TableStyles(0).GridColumnStyles(1).Alignment = HorizontalAlignment.Right
        'Me.dgInvoiceLines.TableStyles(0).GridColumnStyles.RemoveAt(2)
        'Me.dgInvoiceLines.TableStyles(0).GridColumnStyles.RemoveAt(2)

        ''Me.dgInvoiceLines.TableStyles(0).GridColumnStyles(0).HeaderText = "Type"
        'Me.dgInvoiceLines.TableStyles(0).GridColumnStyles(0).HeaderText = "Beskrivelse"
        'Me.dgInvoiceLines.TableStyles(0).GridColumnStyles(1).HeaderText = "Beløb i £"

        Dim dtTypes As New DataTable
        dtTypes.Columns.Add("PriceDescription", System.Type.GetType("System.String"))
        dtTypes.Columns.Add("PriceID", System.Type.GetType("System.Int32"))

        dtTypes.Rows.Add(New Object() {"Fast - høj", 1})
        dtTypes.Rows.Add(New Object() {"Fast - lav", 2})
        dtTypes.Rows.Add(New Object() {"Fast - u madbillet", 16})
        dtTypes.Rows.Add(New Object() {"Fast - CC Fee", 10})
        dtTypes.Rows.Add(New Object() {"Fast - Late Fee", 13})
        dtTypes.Rows.Add(New Object() {"Korttids", 3})
        dtTypes.Rows.Add(New Object() {"Korttids - CC Fee", 11})
        dtTypes.Rows.Add(New Object() {"Korttids - Late Fee", 14})
        'dtTypes.Rows.Add(New Object() {"Madbillet", 5})
        'dtTypes.Rows.Add(New Object() {"Late fee", 6})
        'dtTypes.Rows.Add(New Object() {"Kort betaling", 7})
        dtTypes.Rows.Add(New Object() {"Gæst", 9})
        dtTypes.Rows.Add(New Object() {"Depositum", 4})
        dtTypes.Rows.Add(New Object() {"Flat", 8})
        dtTypes.Rows.Add(New Object() {"Flat - CC Fee", 12})
        dtTypes.Rows.Add(New Object() {"Flat - Late Fee", 15})
        dtTypes.Rows.Add(New Object() {"Andet", 0})
        dtTypes.TableName = "PriceID"
        dtTypes.AcceptChanges()

        Dim tableStyle As New DataGridTableStyle()

        tableStyle.MappingName = "InvoiceLines"

        For i As Integer = 0 To mTable.Columns.Count - 1

            Select Case mTable.Columns(i).ColumnName
                Case "PriceID"
                    Dim ComboTextCol As New DataGridComboBoxColumn()

                    With ComboTextCol
                        .MappingName = "PriceID"
                        .HeaderText = "Pris type"
                        .Width = 100
                        .ColumnComboBox.DataSource = dtTypes.DefaultView
                        .ColumnComboBox.DisplayMember = "PriceDescription"
                        .ColumnComboBox.ValueMember = "PriceID"

                        tableStyle.PreferredRowHeight = .ColumnComboBox.Height
                        tableStyle.GridColumnStyles.Add(ComboTextCol)
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
    End Sub
#End Region

#Region " Partial week payment "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PartialWeek()
        'Dim objLine As New Elements.InvoiceLine
        Dim dblAmount As Double = 0
        Dim intPriceID As Integer = 0

        Dim dblPricePrNight As Double
        dblPricePrNight = (mObjResident.DepartureDate.Subtract(mDatTempPaidUntil).TotalDays()) * mDblShortTermPrNight

        'Dim dblPricePrWeek As Double
        'dblPricePrWeek = mDblLongTermLow

        'If dblPricePrWeek > dblPricePrNight Then
        '    'cheaper to pay pr night
        '    'objLine.Amount = dblPricePrNight
        '    'objLine.PriceID = Data.GlobalEnums.PriceDesctiption.ShortTerm
        dblAmount = dblPricePrNight
        If IsLowRate(mDatTempPaidUntil) Then
            intPriceID = Data.GlobalEnums.PriceDesctiption.LongTermNoFoodTicket
        Else
            intPriceID = Data.GlobalEnums.PriceDesctiption.ShortTerm
        End If
        'Else
        '    'cheaper to pay for whole week
        '    'objLine.Amount = dblPricePrNight
        '    'objLine.PriceID = Data.GlobalEnums.PriceDesctiption.LongTermLow
        '    dblAmount = dblPricePrWeek
        '    intPriceID = Data.GlobalEnums.PriceDesctiption.LongTermLow
        'End If

        'objLine.Description = "Rent (" & mObjResident.PaidUntil & " - " & mObjResident.DepartureDate & ")"
        Dim strExtraDescription As String = ""
        If mIntHolidays > 0 Then
            strExtraDescription = " (incl. " & mIntHolidays & " holidays)"
        End If
        mTable.Rows.Add(New Object() {intPriceID, "Rent (" & mDatTempPaidUntil & " - " & mObjResident.DepartureDate.AddDays(mIntHolidays - 1) & ") incl." & strExtraDescription, FormatNumber(dblAmount, 2), mDatTempPaidUntil, mObjResident.DepartureDate.AddDays(mIntHolidays)})
        mDatTempPaidUntil = mObjResident.DepartureDate.AddDays(mIntHolidays)
        'mArrLines.Add(objLine)
    End Sub

#End Region

#Region " Helpers "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="datFirstInWeek"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function IsLowRate(ByVal datFirstInWeek As DateTime) As Boolean
        If mObjResident.ArrivalDate.AddDays((7 * 4) - mIntHolidays) <= datFirstInWeek Then
            Return True
        End If
        Return False
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="datFirstInWeek"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function IsPartialWeek(ByVal datFirstInWeek As DateTime) As Boolean
        If datFirstInWeek.AddDays(7 + mIntHolidays) > mObjResident.DepartureDate Then
            Return True
        End If
        Return False
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function IsLate() As Boolean
        If mObjResident.PaidUntil > Now Then
            Return True
        End If
        Return False
    End Function

#End Region

#Region " Save "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSaveInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveInvoice.Click

        'first make sure pricetype is selected for _all_ lines
        Dim bSave As Boolean = True

        For Each row As DataRow In mTable.Rows
            If Data.Misc.ConvertToInt(row(0)) < 0 Then
                bSave = False
                Exit For
            End If
        Next

        If bSave Then
            'save
            Dim objInvoice As New Elements.Invoice
            objInvoice.FetchLatest(mObjResident.ID)
            objInvoice.CreatedBy = mIntUserID
            objInvoice.InvoiceDate = Now
            objInvoice.ResidentID = mObjResident.ID
            objInvoice.Save()

            mObjResident.PaidUntil = mDatTempPaidUntil.AddDays(-1)
            mObjResident.SaveResidentSQL()

            If objInvoice.FetchLatest(mObjResident.ID) Then
                'For Each objLine As Elements.InvoiceLine In mArrLines
                '    objLine.InvoiceID = objInvoice.ID
                '    objLine.Save()
                'Next
                For Each row As DataRow In mTable.Rows
                    Dim objLine As New Elements.InvoiceLine
                    objLine.InvoiceID = objInvoice.ID
                    objLine.PriceID = Data.Misc.ConvertToInt(row(0))
                    objLine.Description = Data.Misc.ConvertToString(row(1))
                    objLine.Amount = Data.Misc.ConvertToDouble(row(2))
                    objLine.DatFrom = Data.Misc.ConvertToDateTime(row(3))
                    objLine.DatTo = Data.Misc.ConvertToDateTime(row(4))
                    objLine.Save()
                Next
                If mObjHandledTypes.Count > 0 Then
                    Dim objType As New Elements.ResidentType
                    For Each iID As Integer In mObjHandledTypes
                        objType.SetHandled(iID)
                    Next
                End If
                If mObjResetLines.Count > 0 Then
                    Dim objLine As New Elements.InvoiceLine
                    For Each iID As Integer In mObjResetLines
                        objLine.UpdateStatus(iID)
                    Next
                End If
            Else
                MessageBox.Show("Regningen kunne ikke gemmes i systemet. Du kan lukke systemet og prøve igen, men du bør under alle omstændigheder tage kontakt til udvikler.")
            End If


            Dim formInvoices As New K_Booking_Invoices
            formInvoices.ResidentID = mObjResident.ID
            formInvoices.DoInvoicePrint(objInvoice.ID, True)
            formInvoices.ShowDialog()

            ''print invoice
            'If PrintDialog1.ShowDialog = DialogResult.OK Then
            '    'showDialog method makes the dialog box visible at run time
            '    PrintDocument1.Print()
            'End If
            ''##TODO: save to db that has been printed and date of print (in case print fucks up we might need to allow user to print with foodstamps again?)
            formInvoices.Close()
            Me.Close()
        Else
            If MessageBox.Show("Du skal udfylde pristypen for alle linierne i regningen inden systemet kan gemme den", "Gem Regning") = Windows.Forms.DialogResult.OK Then

            End If
        End If
    End Sub
#End Region

#Region " Print "

    'print document
    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'PrintPage is the foundational printing event. This event gets fired for every 
        ' page that will be printed
        Static intCurrentChar As Int32
        ' declaring a static variable to hold the position of the last printed char
        Dim font As New Font("Arial", 9)
        ' initializing the font to be used for printing
        Dim PrintAreaHeight, PrintAreaWidth, marginLeft, marginTop As Int32
        With PrintDocument1.DefaultPageSettings
            ' initializing local variables that contain the bounds of the printing area rectangle
            PrintAreaHeight = .PaperSize.Height - .Margins.Top - .Margins.Bottom
            PrintAreaWidth = .PaperSize.Width - .Margins.Left - .Margins.Right
            ' initializing local variables to hold margin values that will serve
            ' as the X and Y coordinates for the upper left corner of the printing 
            ' area rectangle.
            marginLeft = .Margins.Left
            marginTop = .Margins.Top
            ' X and Y coordinate
        End With

        If PrintDocument1.DefaultPageSettings.Landscape Then
            Dim intTemp As Int32
            intTemp = PrintAreaHeight
            PrintAreaHeight = PrintAreaWidth
            PrintAreaWidth = intTemp
            ' if the user selects landscape mode, swap the printing area height and width
        End If

        'the text to print
        Dim s As String = ""
        'add addressheader
        s = lblPaymentForResident.Text

        Dim intLineCount As Int32 = CInt(PrintAreaHeight / font.Height)
        ' calculating the total number of lines in the document based on the height of
        ' the printing area and the height of the font
        Dim rectPrintingArea As New RectangleF(marginLeft, marginTop, PrintAreaWidth, PrintAreaHeight)
        ' initializing the rectangle structure that defines the printing area
        Dim fmt As New StringFormat(StringFormatFlags.LineLimit)
        'instantiating the StringFormat class, which encapsulates text layout information
        Dim intLinesFilled, intCharsFitted As Int32
        e.Graphics.MeasureString(Mid(s, intCurrentChar + 1), font, New SizeF(PrintAreaWidth, PrintAreaHeight), fmt, intCharsFitted, intLinesFilled)
        ' calling MeasureString to determine the number of characters that will fit in
        ' the printing area rectangle
        e.Graphics.DrawString(Mid(s, intCurrentChar + 1), font, Brushes.Black, rectPrintingArea, fmt)
        ' print the text to the page
        intCurrentChar += intCharsFitted
        'advancing the current char to the last char printed on this page < TextBox1.Text.Length Then 

        'we are done writing the header - write the table
        Dim x As Integer = marginLeft 'the staring x of the table
        Dim y As Integer = (intLinesFilled * font.Height) + marginTop + 20 'the starting y of the table (20 spacing)
        Dim rc As Integer = 0 'row counter
        Dim cc As Integer = 0 'cell counter
        'string for foodstamps
        Dim fs As New ArrayList

        Dim int() As Integer = {1, 2} 'the index's in the table to write
        'write table header
        e.Graphics.DrawString(mTable.Columns(1).Caption, font, Brushes.Black, x, y)
        e.Graphics.DrawString(mTable.Columns(1).Caption, font, Brushes.Black, x + (PrintAreaWidth * 0.8), y)
        'For Each c As Integer In int
        '    e.Graphics.DrawString(mTable.Columns(c).Caption, font, Brushes.Black, x + (PrintAreaWidth / mTable.Columns.Count * cc), y)
        '    cc += 1
        'Next

        'line under table header
        e.Graphics.DrawLine(Pens.Black, CSng(x), CSng((y + (rc + 1) * font.Height)), CSng(x + PrintAreaWidth), CSng((y + (rc + 1) * font.Height)))

        rc = 1
        cc = 0
        For Each row As DataRow In mTable.Rows
            'we need to draw a table with all the inner lines
            'we will draw a rectangle around the table afterwards
            'For Each c As Integer In int
            'description
            e.Graphics.DrawString(row(1), font, Brushes.Black, x, (y + (rc * font.Height)))
            If rc < mTable.Rows.Count Then
                e.Graphics.DrawLine(Pens.Black, CSng(x), CSng((y + (rc + 1) * font.Height)), CSng(x + PrintAreaWidth), CSng((y + (rc + 1) * font.Height)))
            End If
            cc += 1

            'amount
            e.Graphics.DrawString(row(2), font, Brushes.Black, x + (PrintAreaWidth * 0.8), (y + (rc * font.Height)))
            If rc < mTable.Rows.Count Then
                e.Graphics.DrawLine(Pens.Black, CSng(x), CSng((y + (rc + 1) * font.Height)), CSng(x + PrintAreaWidth), CSng((y + (rc + 1) * font.Height)))
            End If
            cc += 1
            'Next

            If Data.Misc.ConvertToInt(row(0)) = K.Booking.Data.GlobalEnums.PriceDesctiption.LongTermHigh OrElse Data.Misc.ConvertToInt(row(0)) = K.Booking.Data.GlobalEnums.PriceDesctiption.LongTermLow Then
                'this is a long term payer - give them food stamp for this line
                UpdatePrices(Data.Misc.ConvertToDateTime(row(3)))
                fs.Add(New Elements.FoodStamp(Data.Misc.ConvertToDateTime(row(3)), Data.Misc.ConvertToDateTime(row(4)), mDblFoodTicket))
            End If

            'objLine.PriceID = Data.Misc.ConvertToInt(row(0))
            'objLine.Description = Data.Misc.ConvertToString(row(1))
            'objLine.Amount = Data.Misc.ConvertToDouble(row(2))
            'objLine.DatFrom = Data.Misc.ConvertToDateTime(row(3))
            'objLine.DatTo = Data.Misc.ConvertToDateTime(row(4))

            'e.Graphics.DrawString(row(cc), font, Brushes.Black, (x + (PrintAreaWidth / mTable.Columns.Count * cc)), (y + (rc * font.Height)))
            'If rc < mTable.Rows.Count Then
            '    e.Graphics.DrawLine(Pens.Black, CSng(x), CSng((y + (rc + 1) * font.Height)), CSng(x + PrintAreaWidth), CSng((y + (rc + 1) * font.Height)))
            'End If
            'cc += 1

            'e.Graphics.DrawString(row(cc), font, Brushes.Black, (x + (PrintAreaWidth / mTable.Columns.Count * cc)), (y + (rc * font.Height)))
            'If rc < mTable.Rows.Count Then
            '    e.Graphics.DrawLine(Pens.Black, CSng(x), CSng((y + (rc + 1) * font.Height)), CSng(x + PrintAreaWidth), CSng((y + (rc + 1) * font.Height)))
            'End If
            cc = 0
            rc += 1
        Next
        'border arount table
        e.Graphics.DrawRectangle(Pens.Black, New Drawing.Rectangle(x, y, PrintAreaWidth, (rc) * font.Height))
        'vertical lines
        'For Each c As Integer In int
        '    If cc < int.Length - 1 Then
        '        cc += 1
        '        e.Graphics.DrawLine(Pens.Black, CSng(x + (PrintAreaWidth / mTable.Columns.Count * cc)), CSng(y), CSng(x + (PrintAreaWidth / mTable.Columns.Count * cc)), CSng(y + (rc) * font.Height))
        '    End If
        'Next

        e.Graphics.DrawLine(Pens.Black, CSng(x + PrintAreaWidth * 0.8), CSng(y), CSng(x + PrintAreaWidth * 0.8), CSng(y + (rc) * font.Height))

        'set new y
        y = y + (rc) * font.Height + 20

        'draw invoice total
        Dim t As String = "Total: £ " & lblTotalAmount.Text
        e.Graphics.DrawString(t, font, Brushes.Black, x, y)

        'set new y
        y = y + 1 * font.Height + 30

        'draw foodstamps
        For Each f As Elements.FoodStamp In fs
            'draw recangle around whole thing
            e.Graphics.DrawRectangle(Pens.Black, x, y, PrintAreaWidth, font.Height * 5)
            'valid dates
            e.Graphics.DrawString("Gyldig fra " & Format(f.ValidFrom, "dd MMMMM") & " til " & Format(f.ValidTo, "dd MMMMM yyyy"), font, Brushes.Black, x + 10, y + 10)
            'to lines to cross out
            e.Graphics.DrawLine(Pens.Black, x + 5, y + 15 + (font.Height * 2), x + 35, y + 15 + (font.Height * 2))
            e.Graphics.DrawLine(Pens.Black, x + 40, y + 15 + (font.Height * 2), x + 70, y + 15 + (font.Height * 2))
            'draw value
            e.Graphics.DrawString("Vaerdi: 2 maaltider a £ 3,5", New Font("Arial", 8), Brushes.Black, x + 10, y + 15 + (font.Height * 3))

            'set new y
            y = y + font.Height * 5 + 10
        Next

        'If intCurrentChar < s.Length Then
        '    e.HasMorePages = True
        '    'HasMorePages tells the printing module whether another PrintPage event should be fired
        'Else
        e.HasMorePages = False
        intCurrentChar = 0
        'End If
    End Sub

#End Region

#Region " Clear "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAbort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbort.Click
        If mBooAlowAbort Then
            'mArrLines.Clear()
            mTable.Rows.Clear()
            Me.Dispose()
        End If
    End Sub
#End Region

#Region " Update "
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        'AddNewLinesToArray()
        ListLines()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgInvoiceLines_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgInvoiceLines.KeyUp
        If e.KeyData = Keys.Enter Then
            ListLines()
        End If
    End Sub
#End Region

#Region " DataGridComboColumn Class "
    Public Class DataGridComboBoxColumn

#Region " Declarations "

        Inherits DataGridTextBoxColumn

        Public ColumnComboBox As NoKeyUpCombo

        Private mcmSource As System.Windows.Forms.CurrencyManager
        Private mintRowNum As Integer
        Private mblnEditing As Boolean

#End Region

#Region " Constructor "

        Public Sub New()

            mcmSource = Nothing
            mblnEditing = False

            ColumnComboBox = New NoKeyUpCombo()
            ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDownList

            AddHandler ColumnComboBox.Leave, AddressOf LeaveComboBox
            AddHandler ColumnComboBox.SelectionChangeCommitted, AddressOf ComboStartEditing

        End Sub

#End Region

#Region " Private Methods "

        Private Sub HandleScroll(ByVal sender As Object, ByVal e As EventArgs)

            If ColumnComboBox.Visible Then ColumnComboBox.Hide()

        End Sub

        Private Sub ComboStartEditing(ByVal sender As Object, ByVal e As EventArgs)

            mblnEditing = True
            MyBase.ColumnStartedEditing(sender)

        End Sub

        Private Sub LeaveComboBox(ByVal sender As Object, ByVal e As EventArgs)

            If mblnEditing Then
                SetColumnValueAtRow(mcmSource, mintRowNum, ColumnComboBox.Text)
                mblnEditing = False
                Invalidate()
            End If

            ColumnComboBox.Hide()
            AddHandler Me.DataGridTableStyle.DataGrid.Scroll, New EventHandler(AddressOf HandleScroll)

        End Sub

#End Region

#Region " Overridden Methods "

        Protected Overloads Overrides Sub Edit( _
                    ByVal [source] As System.Windows.Forms.CurrencyManager, _
                    ByVal rowNum As Integer, _
                    ByVal bounds As System.Drawing.Rectangle, _
                    ByVal [readOnly] As Boolean, _
                    ByVal instantText As String, _
                    ByVal cellIsVisible As Boolean)

            MyBase.Edit([source], rowNum, bounds, [readOnly], instantText, cellIsVisible)

            mintRowNum = rowNum
            mcmSource = [source]

            With ColumnComboBox
                .Parent = Me.TextBox.Parent
                .Location = Me.TextBox.Location
                .Size = New Size(Me.TextBox.Size.Width, .Size.Height)
                .SelectedIndex = .FindStringExact(Me.TextBox.Text)
                .Text = Me.TextBox.Text

                Me.TextBox.Visible = False
                .Visible = True

                AddHandler Me.DataGridTableStyle.DataGrid.Scroll, AddressOf HandleScroll

                .BringToFront()
                .Focus()
            End With

        End Sub

        Protected Overrides Function Commit( _
                    ByVal dataSource As System.Windows.Forms.CurrencyManager, _
                    ByVal rowNum As Integer) As Boolean

            If mblnEditing Then
                mblnEditing = False
                SetColumnValueAtRow(dataSource, rowNum, ColumnComboBox.Text)
            End If

            Return True

        End Function

        Protected Overrides Sub ConcedeFocus()

            Console.WriteLine("ConcedeFocus")
            MyBase.ConcedeFocus()

        End Sub

        Protected Overrides Function GetColumnValueAtRow( _
                    ByVal [source] As System.Windows.Forms.CurrencyManager, _
                    ByVal rowNum As Integer) As Object

            Dim s As Object = MyBase.GetColumnValueAtRow([source], rowNum)
            Dim dv As DataView = CType(Me.ColumnComboBox.DataSource, DataView)
            Dim rowCount As Integer = dv.Count
            Dim i As Integer = 0
            Dim obj As Object

            While i < rowCount
                obj = dv(i)(Me.ColumnComboBox.ValueMember)
                If (Not obj Is DBNull.Value) AndAlso _
                   (Not s Is DBNull.Value) AndAlso _
                   (s = obj) Then

                    Exit While
                End If

                i += 1
            End While

            If i < rowCount Then
                Return dv(i)(Me.ColumnComboBox.DisplayMember)
            End If

            Return DBNull.Value

        End Function

        Protected Overrides Sub SetColumnValueAtRow( _
                    ByVal [source] As System.Windows.Forms.CurrencyManager, _
                    ByVal rowNum As Integer, ByVal value As Object)

            Dim s As Object = value
            Dim dv As DataView = CType(Me.ColumnComboBox.DataSource, DataView)
            Dim rowCount As Integer = dv.Count
            Dim i As Integer = 0
            Dim obj As Object

            While i < rowCount
                obj = dv(i)(Me.ColumnComboBox.DisplayMember)

                If (Not obj Is DBNull.Value) AndAlso _
                    (s = obj) Then

                    Exit While
                End If

                i += 1
            End While

            If i < rowCount Then
                s = dv(i)(Me.ColumnComboBox.ValueMember)
            Else
                s = DBNull.Value
            End If

            MyBase.SetColumnValueAtRow([source], rowNum, s)
        End Sub

#End Region

    End Class




    Public Class NoKeyUpCombo
        Inherits System.Windows.Forms.ComboBox

        Private Const WM_KEYUP As Integer = &H101

        Protected Overrides Sub WndProc(ByRef theMessage As System.Windows.Forms.Message)
            '
            ' Ignore KeyUp event to avoid problem with tabbing the dropdown.
            ' Prevent tabbing through cells from leaving focus over the cell
            ' that contains the combobox.
            '
            If theMessage.Msg = WM_KEYUP Then
                Return
            Else
                MyBase.WndProc(theMessage)
            End If

        End Sub

    End Class



#End Region

End Class
