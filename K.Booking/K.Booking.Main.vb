Imports K.Booking.Data.Misc
Public Class K_Booking_Main
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
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tabUsers As System.Windows.Forms.TabPage
    Friend WithEvents dgrUsers As System.Windows.Forms.DataGrid
    Friend WithEvents tabResidents As System.Windows.Forms.TabPage
    Friend WithEvents lbxResidents As System.Windows.Forms.ListBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone2 As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents ddlGender As System.Windows.Forms.ComboBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents cbxNewsLetter As System.Windows.Forms.CheckBox
    Friend WithEvents lblComment As System.Windows.Forms.Label
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents gbxDKAddress As System.Windows.Forms.GroupBox
    Friend WithEvents lblDKAddress As System.Windows.Forms.Label
    Friend WithEvents txtDKAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblDKPostalCode As System.Windows.Forms.Label
    Friend WithEvents txtDKPostalCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDKCity As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveUsers As System.Windows.Forms.Button
    Friend WithEvents gbxDKContact As System.Windows.Forms.GroupBox
    Friend WithEvents lblDKContactName As System.Windows.Forms.Label
    Friend WithEvents txtDKContactName As System.Windows.Forms.TextBox
    Friend WithEvents lblDKContactAddress As System.Windows.Forms.Label
    Friend WithEvents txtDKContactAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblDKContactPhone As System.Windows.Forms.Label
    Friend WithEvents txtDKContactPhone As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveResident As System.Windows.Forms.Button
    Friend WithEvents btnSearchResident As System.Windows.Forms.Button
    Friend WithEvents txtSerachResident As System.Windows.Forms.TextBox
    Friend WithEvents ddlShowResidents As System.Windows.Forms.ComboBox
    Friend WithEvents tabRoomsAndBeds As System.Windows.Forms.TabPage
    Friend WithEvents lbxRooms As System.Windows.Forms.ListBox
    Friend WithEvents btnSaveRoom As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblResidentSearch As System.Windows.Forms.Label
    Friend WithEvents lblResidentLastUpdateLabel As System.Windows.Forms.Label
    Friend WithEvents lblResidentCreatedLabel As System.Windows.Forms.Label
    Friend WithEvents lblResidentLastUpdatedUser As System.Windows.Forms.Label
    Friend WithEvents lblResidentCreatedUser As System.Windows.Forms.Label
    Friend WithEvents lblBedsInRoom As System.Windows.Forms.Label
    Friend WithEvents gbxRooms As System.Windows.Forms.GroupBox
    Friend WithEvents lbxBeds As System.Windows.Forms.ListBox
    Friend WithEvents gbxBeds As System.Windows.Forms.GroupBox
    Friend WithEvents txtBedDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveBed As System.Windows.Forms.Button
    Friend WithEvents gbxRoomAndBed As System.Windows.Forms.GroupBox
    Friend WithEvents lblFromDate As System.Windows.Forms.Label
    Friend WithEvents lblToDate As System.Windows.Forms.Label
    Friend WithEvents lbxResidentInBed As System.Windows.Forms.ListBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents tabPrices As System.Windows.Forms.TabPage
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents gbxPrices As System.Windows.Forms.GroupBox
    Friend WithEvents ddlPriceSets As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPriceSeven As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceSeven As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPriceSix As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceSix As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPriceFive As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceFive As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtPriceFour As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceFour As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPriceThree As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceThree As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtPriceTwo As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceTwo As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtPriceOne As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceOne As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNewPriceSet As System.Windows.Forms.Button
    Friend WithEvents ddlResidentType As System.Windows.Forms.ComboBox
    Friend WithEvents txtRoomAndBed As System.Windows.Forms.TextBox
    Friend WithEvents btnEditResidentInBed As System.Windows.Forms.Button
    Friend WithEvents btnDeleteResidentInBed As System.Windows.Forms.Button
    Friend WithEvents lblNumberOfGuests As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfGuests As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Timers.Timer
    Friend WithEvents btnAbortResident As System.Windows.Forms.Button
    Friend WithEvents gbxPayment As System.Windows.Forms.GroupBox
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents gbxHoliday As System.Windows.Forms.GroupBox
    Friend WithEvents btnHolidayDelete As System.Windows.Forms.Button
    Friend WithEvents btnHolidayEdit As System.Windows.Forms.Button
    Friend WithEvents lbxHolidays As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents datInBedFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents datInBedTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents datHolidayFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents datHolidayTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents datPaidUntill As System.Windows.Forms.DateTimePicker
    Friend WithEvents datPriceValidFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRoomKey As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRoomDescription As System.Windows.Forms.TextBox
    Friend WithEvents ddlType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ddlStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBedKey As System.Windows.Forms.TextBox
    Friend WithEvents btnEditRoom As System.Windows.Forms.Button
    Friend WithEvents btnEditBed As System.Windows.Forms.Button
    Friend WithEvents btnWelcome As System.Windows.Forms.Button
    Friend WithEvents prdWelcomeNote As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents tabPrint As System.Windows.Forms.TabPage
    Friend WithEvents btnBlankWelcome As System.Windows.Forms.Button
    Friend WithEvents gbxResidentList As System.Windows.Forms.GroupBox
    Friend WithEvents datResidentList As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPrintResidentList As System.Windows.Forms.Button
    Friend WithEvents prdResidentLIst As System.Drawing.Printing.PrintDocument
    Friend WithEvents chkIsPermanent As System.Windows.Forms.CheckBox
    Friend WithEvents gbxStats As System.Windows.Forms.GroupBox
    Friend WithEvents btnStatsView As System.Windows.Forms.Button
    Friend WithEvents btnPrintStats As System.Windows.Forms.Button
    Friend WithEvents lbxStats As System.Windows.Forms.ListBox
    Friend WithEvents datStatsTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents datStatsFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents prdStats As System.Drawing.Printing.PrintDocument
    Friend WithEvents gbxOldStats As System.Windows.Forms.GroupBox
    Friend WithEvents gbxNewStat As System.Windows.Forms.GroupBox
    Friend WithEvents chkStatsShowAll As System.Windows.Forms.CheckBox
    Friend WithEvents datStatsShow As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbxResident As System.Windows.Forms.GroupBox
    Friend WithEvents lblCurrentRoomAndBed As System.Windows.Forms.Label
    Friend WithEvents datDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtChronicIllness As System.Windows.Forms.TextBox
    Friend WithEvents lblChronicIllness As System.Windows.Forms.Label
    Friend WithEvents lblDeparture As System.Windows.Forms.Label
    Friend WithEvents lblArrival As System.Windows.Forms.Label
    Friend WithEvents lblCPR As System.Windows.Forms.Label
    Friend WithEvents txtCPR As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents btnNewResident As System.Windows.Forms.Button
    Friend WithEvents datArrival As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnDebug As System.Windows.Forms.Button
    Friend WithEvents txtRemove As System.Windows.Forms.Button
    Friend WithEvents btnPrintSelectedList As System.Windows.Forms.Button
    Friend WithEvents prdListSelected As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnInvoiceHistory As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(K_Booking_Main))
        Me.btnLogOut = New System.Windows.Forms.Button
        Me.lblWelcome = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.tabMain = New System.Windows.Forms.TabControl
        Me.tabResidents = New System.Windows.Forms.TabPage
        Me.txtRemove = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ddlGender = New System.Windows.Forms.ComboBox
        Me.lblGender = New System.Windows.Forms.Label
        Me.lblComment = New System.Windows.Forms.Label
        Me.lblResidentLastUpdateLabel = New System.Windows.Forms.Label
        Me.lblResidentCreatedLabel = New System.Windows.Forms.Label
        Me.lblResidentLastUpdatedUser = New System.Windows.Forms.Label
        Me.txtComment = New System.Windows.Forms.TextBox
        Me.lblResidentCreatedUser = New System.Windows.Forms.Label
        Me.cbxNewsLetter = New System.Windows.Forms.CheckBox
        Me.btnWelcome = New System.Windows.Forms.Button
        Me.btnInvoiceHistory = New System.Windows.Forms.Button
        Me.gbxHoliday = New System.Windows.Forms.GroupBox
        Me.datHolidayTo = New System.Windows.Forms.DateTimePicker
        Me.lbxHolidays = New System.Windows.Forms.ListBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnHolidayDelete = New System.Windows.Forms.Button
        Me.btnHolidayEdit = New System.Windows.Forms.Button
        Me.datHolidayFrom = New System.Windows.Forms.DateTimePicker
        Me.gbxPayment = New System.Windows.Forms.GroupBox
        Me.lblPayment = New System.Windows.Forms.Label
        Me.datPaidUntill = New System.Windows.Forms.DateTimePicker
        Me.ddlResidentType = New System.Windows.Forms.ComboBox
        Me.lblType = New System.Windows.Forms.Label
        Me.txtNumberOfGuests = New System.Windows.Forms.TextBox
        Me.lblNumberOfGuests = New System.Windows.Forms.Label
        Me.btnAbortResident = New System.Windows.Forms.Button
        Me.btnPay = New System.Windows.Forms.Button
        Me.gbxRoomAndBed = New System.Windows.Forms.GroupBox
        Me.datInBedTo = New System.Windows.Forms.DateTimePicker
        Me.btnDeleteResidentInBed = New System.Windows.Forms.Button
        Me.btnEditResidentInBed = New System.Windows.Forms.Button
        Me.txtRoomAndBed = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lbxResidentInBed = New System.Windows.Forms.ListBox
        Me.lblToDate = New System.Windows.Forms.Label
        Me.lblFromDate = New System.Windows.Forms.Label
        Me.datInBedFrom = New System.Windows.Forms.DateTimePicker
        Me.lblResidentSearch = New System.Windows.Forms.Label
        Me.ddlShowResidents = New System.Windows.Forms.ComboBox
        Me.txtSerachResident = New System.Windows.Forms.TextBox
        Me.btnSearchResident = New System.Windows.Forms.Button
        Me.btnSaveResident = New System.Windows.Forms.Button
        Me.gbxDKContact = New System.Windows.Forms.GroupBox
        Me.txtDKContactPhone = New System.Windows.Forms.TextBox
        Me.lblDKContactPhone = New System.Windows.Forms.Label
        Me.txtDKContactAddress = New System.Windows.Forms.TextBox
        Me.lblDKContactAddress = New System.Windows.Forms.Label
        Me.txtDKContactName = New System.Windows.Forms.TextBox
        Me.lblDKContactName = New System.Windows.Forms.Label
        Me.gbxDKAddress = New System.Windows.Forms.GroupBox
        Me.txtDKCity = New System.Windows.Forms.TextBox
        Me.txtDKPostalCode = New System.Windows.Forms.TextBox
        Me.lblDKPostalCode = New System.Windows.Forms.Label
        Me.txtDKAddress = New System.Windows.Forms.TextBox
        Me.lblDKAddress = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.txtPhone2 = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.lblEmail = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.gbxResident = New System.Windows.Forms.GroupBox
        Me.lblCurrentRoomAndBed = New System.Windows.Forms.Label
        Me.datDeparture = New System.Windows.Forms.DateTimePicker
        Me.txtID = New System.Windows.Forms.TextBox
        Me.lblID = New System.Windows.Forms.Label
        Me.txtChronicIllness = New System.Windows.Forms.TextBox
        Me.lblChronicIllness = New System.Windows.Forms.Label
        Me.lblDeparture = New System.Windows.Forms.Label
        Me.lblArrival = New System.Windows.Forms.Label
        Me.lblCPR = New System.Windows.Forms.Label
        Me.txtCPR = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.lblLastName = New System.Windows.Forms.Label
        Me.btnNewResident = New System.Windows.Forms.Button
        Me.datArrival = New System.Windows.Forms.DateTimePicker
        Me.lbxResidents = New System.Windows.Forms.ListBox
        Me.tabUsers = New System.Windows.Forms.TabPage
        Me.dgrUsers = New System.Windows.Forms.DataGrid
        Me.btnSaveUsers = New System.Windows.Forms.Button
        Me.tabRoomsAndBeds = New System.Windows.Forms.TabPage
        Me.gbxBeds = New System.Windows.Forms.GroupBox
        Me.chkIsPermanent = New System.Windows.Forms.CheckBox
        Me.txtBedDescription = New System.Windows.Forms.TextBox
        Me.lblBedsInRoom = New System.Windows.Forms.Label
        Me.lbxBeds = New System.Windows.Forms.ListBox
        Me.btnSaveBed = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtBedKey = New System.Windows.Forms.TextBox
        Me.btnEditBed = New System.Windows.Forms.Button
        Me.gbxRooms = New System.Windows.Forms.GroupBox
        Me.btnEditRoom = New System.Windows.Forms.Button
        Me.ddlStatus = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ddlType = New System.Windows.Forms.ComboBox
        Me.txtRoomDescription = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbxRooms = New System.Windows.Forms.ListBox
        Me.txtRoomKey = New System.Windows.Forms.TextBox
        Me.btnSaveRoom = New System.Windows.Forms.Button
        Me.tabPrices = New System.Windows.Forms.TabPage
        Me.gbxPrices = New System.Windows.Forms.GroupBox
        Me.datPriceValidFrom = New System.Windows.Forms.DateTimePicker
        Me.btnNewPriceSet = New System.Windows.Forms.Button
        Me.ddlPriceSets = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtPriceSeven = New System.Windows.Forms.TextBox
        Me.lblPriceSeven = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtPriceSix = New System.Windows.Forms.TextBox
        Me.lblPriceSix = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtPriceFive = New System.Windows.Forms.TextBox
        Me.lblPriceFive = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtPriceFour = New System.Windows.Forms.TextBox
        Me.lblPriceFour = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtPriceThree = New System.Windows.Forms.TextBox
        Me.lblPriceThree = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtPriceTwo = New System.Windows.Forms.TextBox
        Me.lblPriceTwo = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtPriceOne = New System.Windows.Forms.TextBox
        Me.lblPriceOne = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.tabPrint = New System.Windows.Forms.TabPage
        Me.gbxStats = New System.Windows.Forms.GroupBox
        Me.gbxOldStats = New System.Windows.Forms.GroupBox
        Me.chkStatsShowAll = New System.Windows.Forms.CheckBox
        Me.datStatsShow = New System.Windows.Forms.DateTimePicker
        Me.btnStatsView = New System.Windows.Forms.Button
        Me.lbxStats = New System.Windows.Forms.ListBox
        Me.gbxNewStat = New System.Windows.Forms.GroupBox
        Me.datStatsFrom = New System.Windows.Forms.DateTimePicker
        Me.btnPrintStats = New System.Windows.Forms.Button
        Me.datStatsTo = New System.Windows.Forms.DateTimePicker
        Me.gbxResidentList = New System.Windows.Forms.GroupBox
        Me.datResidentList = New System.Windows.Forms.DateTimePicker
        Me.btnPrintResidentList = New System.Windows.Forms.Button
        Me.btnBlankWelcome = New System.Windows.Forms.Button
        Me.Timer1 = New System.Timers.Timer
        Me.prdWelcomeNote = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.prdResidentLIst = New System.Drawing.Printing.PrintDocument
        Me.prdStats = New System.Drawing.Printing.PrintDocument
        Me.btnDebug = New System.Windows.Forms.Button
        Me.btnPrintSelectedList = New System.Windows.Forms.Button
        Me.prdListSelected = New System.Drawing.Printing.PrintDocument
        Me.tabMain.SuspendLayout()
        Me.tabResidents.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbxHoliday.SuspendLayout()
        Me.gbxPayment.SuspendLayout()
        Me.gbxRoomAndBed.SuspendLayout()
        Me.gbxDKContact.SuspendLayout()
        Me.gbxDKAddress.SuspendLayout()
        Me.gbxResident.SuspendLayout()
        Me.tabUsers.SuspendLayout()
        CType(Me.dgrUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRoomsAndBeds.SuspendLayout()
        Me.gbxBeds.SuspendLayout()
        Me.gbxRooms.SuspendLayout()
        Me.tabPrices.SuspendLayout()
        Me.gbxPrices.SuspendLayout()
        Me.tabPrint.SuspendLayout()
        Me.gbxStats.SuspendLayout()
        Me.gbxOldStats.SuspendLayout()
        Me.gbxNewStat.SuspendLayout()
        Me.gbxResidentList.SuspendLayout()
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(928, 8)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 100
        Me.btnLogOut.Text = "Log ud"
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(8, 8)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(504, 23)
        Me.lblWelcome.TabIndex = 100
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(899, 607)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 23)
        Me.btnClose.TabIndex = 100
        Me.btnClose.Text = "Luk systemet"
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabResidents)
        Me.tabMain.Controls.Add(Me.tabUsers)
        Me.tabMain.Controls.Add(Me.tabRoomsAndBeds)
        Me.tabMain.Controls.Add(Me.tabPrices)
        Me.tabMain.Controls.Add(Me.tabPrint)
        Me.tabMain.Location = New System.Drawing.Point(8, 32)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(992, 569)
        Me.tabMain.TabIndex = 100
        '
        'tabResidents
        '
        Me.tabResidents.Controls.Add(Me.btnPrintSelectedList)
        Me.tabResidents.Controls.Add(Me.txtRemove)
        Me.tabResidents.Controls.Add(Me.GroupBox1)
        Me.tabResidents.Controls.Add(Me.btnWelcome)
        Me.tabResidents.Controls.Add(Me.btnInvoiceHistory)
        Me.tabResidents.Controls.Add(Me.gbxHoliday)
        Me.tabResidents.Controls.Add(Me.gbxPayment)
        Me.tabResidents.Controls.Add(Me.btnAbortResident)
        Me.tabResidents.Controls.Add(Me.btnPay)
        Me.tabResidents.Controls.Add(Me.gbxRoomAndBed)
        Me.tabResidents.Controls.Add(Me.lblResidentSearch)
        Me.tabResidents.Controls.Add(Me.ddlShowResidents)
        Me.tabResidents.Controls.Add(Me.txtSerachResident)
        Me.tabResidents.Controls.Add(Me.btnSearchResident)
        Me.tabResidents.Controls.Add(Me.btnSaveResident)
        Me.tabResidents.Controls.Add(Me.gbxDKContact)
        Me.tabResidents.Controls.Add(Me.gbxDKAddress)
        Me.tabResidents.Controls.Add(Me.gbxResident)
        Me.tabResidents.Controls.Add(Me.lbxResidents)
        Me.tabResidents.Location = New System.Drawing.Point(4, 22)
        Me.tabResidents.Name = "tabResidents"
        Me.tabResidents.Size = New System.Drawing.Size(984, 543)
        Me.tabResidents.TabIndex = 100
        Me.tabResidents.Text = "Beboere"
        Me.tabResidents.UseVisualStyleBackColor = True
        '
        'txtRemove
        '
        Me.txtRemove.Location = New System.Drawing.Point(873, 427)
        Me.txtRemove.Name = "txtRemove"
        Me.txtRemove.Size = New System.Drawing.Size(103, 23)
        Me.txtRemove.TabIndex = 103
        Me.txtRemove.Text = "Slet"
        Me.txtRemove.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ddlGender)
        Me.GroupBox1.Controls.Add(Me.lblGender)
        Me.GroupBox1.Controls.Add(Me.lblComment)
        Me.GroupBox1.Controls.Add(Me.lblResidentLastUpdateLabel)
        Me.GroupBox1.Controls.Add(Me.lblResidentCreatedLabel)
        Me.GroupBox1.Controls.Add(Me.lblResidentLastUpdatedUser)
        Me.GroupBox1.Controls.Add(Me.txtComment)
        Me.GroupBox1.Controls.Add(Me.lblResidentCreatedUser)
        Me.GroupBox1.Controls.Add(Me.cbxNewsLetter)
        Me.GroupBox1.Location = New System.Drawing.Point(551, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 172)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Andet"
        '
        'ddlGender
        '
        Me.ddlGender.Location = New System.Drawing.Point(189, 16)
        Me.ddlGender.Name = "ddlGender"
        Me.ddlGender.Size = New System.Drawing.Size(114, 21)
        Me.ddlGender.TabIndex = 30
        '
        'lblGender
        '
        Me.lblGender.Location = New System.Drawing.Point(131, 19)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(49, 23)
        Me.lblGender.TabIndex = 100
        Me.lblGender.Text = "Køn"
        '
        'lblComment
        '
        Me.lblComment.Location = New System.Drawing.Point(7, 38)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(67, 23)
        Me.lblComment.TabIndex = 100
        Me.lblComment.Text = "Kommentar"
        '
        'lblResidentLastUpdateLabel
        '
        Me.lblResidentLastUpdateLabel.Location = New System.Drawing.Point(7, 153)
        Me.lblResidentLastUpdateLabel.Name = "lblResidentLastUpdateLabel"
        Me.lblResidentLastUpdateLabel.Size = New System.Drawing.Size(100, 16)
        Me.lblResidentLastUpdateLabel.TabIndex = 100
        Me.lblResidentLastUpdateLabel.Text = "Sidst opdateret af: "
        '
        'lblResidentCreatedLabel
        '
        Me.lblResidentCreatedLabel.Location = New System.Drawing.Point(7, 126)
        Me.lblResidentCreatedLabel.Name = "lblResidentCreatedLabel"
        Me.lblResidentCreatedLabel.Size = New System.Drawing.Size(100, 16)
        Me.lblResidentCreatedLabel.TabIndex = 100
        Me.lblResidentCreatedLabel.Text = "Oprettet af: "
        '
        'lblResidentLastUpdatedUser
        '
        Me.lblResidentLastUpdatedUser.Location = New System.Drawing.Point(107, 153)
        Me.lblResidentLastUpdatedUser.Name = "lblResidentLastUpdatedUser"
        Me.lblResidentLastUpdatedUser.Size = New System.Drawing.Size(196, 16)
        Me.lblResidentLastUpdatedUser.TabIndex = 100
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(80, 43)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComment.Size = New System.Drawing.Size(223, 78)
        Me.txtComment.TabIndex = 100
        '
        'lblResidentCreatedUser
        '
        Me.lblResidentCreatedUser.Location = New System.Drawing.Point(104, 126)
        Me.lblResidentCreatedUser.Name = "lblResidentCreatedUser"
        Me.lblResidentCreatedUser.Size = New System.Drawing.Size(199, 16)
        Me.lblResidentCreatedUser.TabIndex = 100
        '
        'cbxNewsLetter
        '
        Me.cbxNewsLetter.Location = New System.Drawing.Point(10, 19)
        Me.cbxNewsLetter.Name = "cbxNewsLetter"
        Me.cbxNewsLetter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbxNewsLetter.Size = New System.Drawing.Size(124, 16)
        Me.cbxNewsLetter.TabIndex = 29
        Me.cbxNewsLetter.Text = "Bekræftelse"
        '
        'btnWelcome
        '
        Me.btnWelcome.Location = New System.Drawing.Point(872, 99)
        Me.btnWelcome.Name = "btnWelcome"
        Me.btnWelcome.Size = New System.Drawing.Size(104, 23)
        Me.btnWelcome.TabIndex = 102
        Me.btnWelcome.Text = "Velkomstbrev"
        Me.btnWelcome.UseVisualStyleBackColor = True
        '
        'btnInvoiceHistory
        '
        Me.btnInvoiceHistory.Location = New System.Drawing.Point(870, 45)
        Me.btnInvoiceHistory.Name = "btnInvoiceHistory"
        Me.btnInvoiceHistory.Size = New System.Drawing.Size(106, 23)
        Me.btnInvoiceHistory.TabIndex = 101
        Me.btnInvoiceHistory.Text = "Betalings historik"
        '
        'gbxHoliday
        '
        Me.gbxHoliday.Controls.Add(Me.datHolidayTo)
        Me.gbxHoliday.Controls.Add(Me.lbxHolidays)
        Me.gbxHoliday.Controls.Add(Me.Label12)
        Me.gbxHoliday.Controls.Add(Me.Label10)
        Me.gbxHoliday.Controls.Add(Me.btnHolidayDelete)
        Me.gbxHoliday.Controls.Add(Me.btnHolidayEdit)
        Me.gbxHoliday.Controls.Add(Me.datHolidayFrom)
        Me.gbxHoliday.Location = New System.Drawing.Point(554, 361)
        Me.gbxHoliday.Name = "gbxHoliday"
        Me.gbxHoliday.Size = New System.Drawing.Size(312, 146)
        Me.gbxHoliday.TabIndex = 100
        Me.gbxHoliday.TabStop = False
        Me.gbxHoliday.Text = "Ferie"
        '
        'datHolidayTo
        '
        Me.datHolidayTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datHolidayTo.Location = New System.Drawing.Point(112, 64)
        Me.datHolidayTo.Name = "datHolidayTo"
        Me.datHolidayTo.Size = New System.Drawing.Size(192, 20)
        Me.datHolidayTo.TabIndex = 36
        '
        'lbxHolidays
        '
        Me.lbxHolidays.Location = New System.Drawing.Point(8, 88)
        Me.lbxHolidays.Name = "lbxHolidays"
        Me.lbxHolidays.Size = New System.Drawing.Size(224, 56)
        Me.lbxHolidays.TabIndex = 100
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 16)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "Fra dato"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Til dato"
        '
        'btnHolidayDelete
        '
        Me.btnHolidayDelete.Location = New System.Drawing.Point(240, 120)
        Me.btnHolidayDelete.Name = "btnHolidayDelete"
        Me.btnHolidayDelete.Size = New System.Drawing.Size(64, 23)
        Me.btnHolidayDelete.TabIndex = 100
        Me.btnHolidayDelete.Text = "Slet"
        '
        'btnHolidayEdit
        '
        Me.btnHolidayEdit.Location = New System.Drawing.Point(240, 88)
        Me.btnHolidayEdit.Name = "btnHolidayEdit"
        Me.btnHolidayEdit.Size = New System.Drawing.Size(64, 23)
        Me.btnHolidayEdit.TabIndex = 100
        Me.btnHolidayEdit.Text = "Redigér"
        '
        'datHolidayFrom
        '
        Me.datHolidayFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datHolidayFrom.Location = New System.Drawing.Point(112, 40)
        Me.datHolidayFrom.Name = "datHolidayFrom"
        Me.datHolidayFrom.Size = New System.Drawing.Size(192, 20)
        Me.datHolidayFrom.TabIndex = 35
        '
        'gbxPayment
        '
        Me.gbxPayment.Controls.Add(Me.lblPayment)
        Me.gbxPayment.Controls.Add(Me.datPaidUntill)
        Me.gbxPayment.Controls.Add(Me.ddlResidentType)
        Me.gbxPayment.Controls.Add(Me.lblType)
        Me.gbxPayment.Controls.Add(Me.txtNumberOfGuests)
        Me.gbxPayment.Controls.Add(Me.lblNumberOfGuests)
        Me.gbxPayment.Location = New System.Drawing.Point(248, 462)
        Me.gbxPayment.Name = "gbxPayment"
        Me.gbxPayment.Size = New System.Drawing.Size(296, 71)
        Me.gbxPayment.TabIndex = 25
        Me.gbxPayment.TabStop = False
        Me.gbxPayment.Text = "Betalingsinformation"
        '
        'lblPayment
        '
        Me.lblPayment.Location = New System.Drawing.Point(8, 45)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(152, 23)
        Me.lblPayment.TabIndex = 100
        '
        'datPaidUntill
        '
        Me.datPaidUntill.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datPaidUntill.Location = New System.Drawing.Point(160, 45)
        Me.datPaidUntill.Name = "datPaidUntill"
        Me.datPaidUntill.Size = New System.Drawing.Size(128, 20)
        Me.datPaidUntill.TabIndex = 27
        '
        'ddlResidentType
        '
        Me.ddlResidentType.Location = New System.Drawing.Point(80, 18)
        Me.ddlResidentType.Name = "ddlResidentType"
        Me.ddlResidentType.Size = New System.Drawing.Size(104, 21)
        Me.ddlResidentType.TabIndex = 25
        '
        'lblType
        '
        Me.lblType.Location = New System.Drawing.Point(8, 18)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(64, 16)
        Me.lblType.TabIndex = 100
        Me.lblType.Text = "Type"
        '
        'txtNumberOfGuests
        '
        Me.txtNumberOfGuests.Location = New System.Drawing.Point(232, 18)
        Me.txtNumberOfGuests.Name = "txtNumberOfGuests"
        Me.txtNumberOfGuests.Size = New System.Drawing.Size(56, 20)
        Me.txtNumberOfGuests.TabIndex = 26
        Me.txtNumberOfGuests.Visible = False
        '
        'lblNumberOfGuests
        '
        Me.lblNumberOfGuests.Location = New System.Drawing.Point(192, 18)
        Me.lblNumberOfGuests.Name = "lblNumberOfGuests"
        Me.lblNumberOfGuests.Size = New System.Drawing.Size(32, 24)
        Me.lblNumberOfGuests.TabIndex = 100
        Me.lblNumberOfGuests.Text = "Antal"
        Me.lblNumberOfGuests.Visible = False
        '
        'btnAbortResident
        '
        Me.btnAbortResident.Location = New System.Drawing.Point(872, 456)
        Me.btnAbortResident.Name = "btnAbortResident"
        Me.btnAbortResident.Size = New System.Drawing.Size(104, 23)
        Me.btnAbortResident.TabIndex = 100
        Me.btnAbortResident.Text = "Annullér"
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(872, 16)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(104, 23)
        Me.btnPay.TabIndex = 100
        Me.btnPay.Text = "Betaling"
        '
        'gbxRoomAndBed
        '
        Me.gbxRoomAndBed.Controls.Add(Me.datInBedTo)
        Me.gbxRoomAndBed.Controls.Add(Me.btnDeleteResidentInBed)
        Me.gbxRoomAndBed.Controls.Add(Me.btnEditResidentInBed)
        Me.gbxRoomAndBed.Controls.Add(Me.txtRoomAndBed)
        Me.gbxRoomAndBed.Controls.Add(Me.Label11)
        Me.gbxRoomAndBed.Controls.Add(Me.lbxResidentInBed)
        Me.gbxRoomAndBed.Controls.Add(Me.lblToDate)
        Me.gbxRoomAndBed.Controls.Add(Me.lblFromDate)
        Me.gbxRoomAndBed.Controls.Add(Me.datInBedFrom)
        Me.gbxRoomAndBed.Location = New System.Drawing.Point(550, 16)
        Me.gbxRoomAndBed.Name = "gbxRoomAndBed"
        Me.gbxRoomAndBed.Size = New System.Drawing.Size(312, 160)
        Me.gbxRoomAndBed.TabIndex = 28
        Me.gbxRoomAndBed.TabStop = False
        Me.gbxRoomAndBed.Text = "Værelse og seng"
        '
        'datInBedTo
        '
        Me.datInBedTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datInBedTo.Location = New System.Drawing.Point(112, 72)
        Me.datInBedTo.Name = "datInBedTo"
        Me.datInBedTo.Size = New System.Drawing.Size(192, 20)
        Me.datInBedTo.TabIndex = 34
        '
        'btnDeleteResidentInBed
        '
        Me.btnDeleteResidentInBed.Location = New System.Drawing.Point(240, 128)
        Me.btnDeleteResidentInBed.Name = "btnDeleteResidentInBed"
        Me.btnDeleteResidentInBed.Size = New System.Drawing.Size(64, 23)
        Me.btnDeleteResidentInBed.TabIndex = 100
        Me.btnDeleteResidentInBed.Text = "Slet"
        '
        'btnEditResidentInBed
        '
        Me.btnEditResidentInBed.Location = New System.Drawing.Point(240, 96)
        Me.btnEditResidentInBed.Name = "btnEditResidentInBed"
        Me.btnEditResidentInBed.Size = New System.Drawing.Size(64, 23)
        Me.btnEditResidentInBed.TabIndex = 100
        Me.btnEditResidentInBed.Text = "Redigér"
        '
        'txtRoomAndBed
        '
        Me.txtRoomAndBed.Location = New System.Drawing.Point(120, 16)
        Me.txtRoomAndBed.Name = "txtRoomAndBed"
        Me.txtRoomAndBed.Size = New System.Drawing.Size(112, 20)
        Me.txtRoomAndBed.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 23)
        Me.Label11.TabIndex = 100
        Me.Label11.Text = "Værelse og seng"
        '
        'lbxResidentInBed
        '
        Me.lbxResidentInBed.Location = New System.Drawing.Point(8, 96)
        Me.lbxResidentInBed.Name = "lbxResidentInBed"
        Me.lbxResidentInBed.Size = New System.Drawing.Size(224, 56)
        Me.lbxResidentInBed.TabIndex = 100
        '
        'lblToDate
        '
        Me.lblToDate.Location = New System.Drawing.Point(8, 80)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(88, 16)
        Me.lblToDate.TabIndex = 100
        Me.lblToDate.Text = "Til dato"
        '
        'lblFromDate
        '
        Me.lblFromDate.Location = New System.Drawing.Point(8, 56)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(88, 16)
        Me.lblFromDate.TabIndex = 100
        Me.lblFromDate.Text = "Fra dato"
        '
        'datInBedFrom
        '
        Me.datInBedFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datInBedFrom.Location = New System.Drawing.Point(112, 48)
        Me.datInBedFrom.Name = "datInBedFrom"
        Me.datInBedFrom.Size = New System.Drawing.Size(192, 20)
        Me.datInBedFrom.TabIndex = 33
        '
        'lblResidentSearch
        '
        Me.lblResidentSearch.Location = New System.Drawing.Point(8, 88)
        Me.lblResidentSearch.Name = "lblResidentSearch"
        Me.lblResidentSearch.Size = New System.Drawing.Size(144, 32)
        Me.lblResidentSearch.TabIndex = 100
        Me.lblResidentSearch.Text = "Indtast fornavn, efternavn eller CPR og tryk ""søg""."
        '
        'ddlShowResidents
        '
        Me.ddlShowResidents.Items.AddRange(New Object() {"Alle", "Dagens afrejser", "Dagens ankomster", "Kollegie", "Kommende", "Nuværende", "Skyldnere", "Staff", "Tidligere", "Annullerede"})
        Me.ddlShowResidents.Location = New System.Drawing.Point(8, 64)
        Me.ddlShowResidents.Name = "ddlShowResidents"
        Me.ddlShowResidents.Size = New System.Drawing.Size(224, 21)
        Me.ddlShowResidents.TabIndex = 100
        Me.ddlShowResidents.Text = "Vis beboere"
        '
        'txtSerachResident
        '
        Me.txtSerachResident.Location = New System.Drawing.Point(8, 128)
        Me.txtSerachResident.Name = "txtSerachResident"
        Me.txtSerachResident.Size = New System.Drawing.Size(144, 20)
        Me.txtSerachResident.TabIndex = 100
        '
        'btnSearchResident
        '
        Me.btnSearchResident.Location = New System.Drawing.Point(160, 128)
        Me.btnSearchResident.Name = "btnSearchResident"
        Me.btnSearchResident.Size = New System.Drawing.Size(80, 23)
        Me.btnSearchResident.TabIndex = 100
        Me.btnSearchResident.Text = "Søg"
        '
        'btnSaveResident
        '
        Me.btnSaveResident.Location = New System.Drawing.Point(872, 488)
        Me.btnSaveResident.Name = "btnSaveResident"
        Me.btnSaveResident.Size = New System.Drawing.Size(104, 23)
        Me.btnSaveResident.TabIndex = 33
        Me.btnSaveResident.Text = "Gem"
        '
        'gbxDKContact
        '
        Me.gbxDKContact.Controls.Add(Me.txtDKContactPhone)
        Me.gbxDKContact.Controls.Add(Me.lblDKContactPhone)
        Me.gbxDKContact.Controls.Add(Me.txtDKContactAddress)
        Me.gbxDKContact.Controls.Add(Me.lblDKContactAddress)
        Me.gbxDKContact.Controls.Add(Me.txtDKContactName)
        Me.gbxDKContact.Controls.Add(Me.lblDKContactName)
        Me.gbxDKContact.Location = New System.Drawing.Point(246, 361)
        Me.gbxDKContact.Name = "gbxDKContact"
        Me.gbxDKContact.Size = New System.Drawing.Size(298, 96)
        Me.gbxDKContact.TabIndex = 22
        Me.gbxDKContact.TabStop = False
        Me.gbxDKContact.Text = "Kontaktperson i Danmark"
        '
        'txtDKContactPhone
        '
        Me.txtDKContactPhone.Location = New System.Drawing.Point(80, 64)
        Me.txtDKContactPhone.Name = "txtDKContactPhone"
        Me.txtDKContactPhone.Size = New System.Drawing.Size(210, 20)
        Me.txtDKContactPhone.TabIndex = 24
        '
        'lblDKContactPhone
        '
        Me.lblDKContactPhone.Location = New System.Drawing.Point(8, 72)
        Me.lblDKContactPhone.Name = "lblDKContactPhone"
        Me.lblDKContactPhone.Size = New System.Drawing.Size(72, 16)
        Me.lblDKContactPhone.TabIndex = 100
        Me.lblDKContactPhone.Text = "Tlf."
        '
        'txtDKContactAddress
        '
        Me.txtDKContactAddress.Location = New System.Drawing.Point(80, 40)
        Me.txtDKContactAddress.Name = "txtDKContactAddress"
        Me.txtDKContactAddress.Size = New System.Drawing.Size(210, 20)
        Me.txtDKContactAddress.TabIndex = 23
        '
        'lblDKContactAddress
        '
        Me.lblDKContactAddress.Location = New System.Drawing.Point(8, 48)
        Me.lblDKContactAddress.Name = "lblDKContactAddress"
        Me.lblDKContactAddress.Size = New System.Drawing.Size(72, 23)
        Me.lblDKContactAddress.TabIndex = 100
        Me.lblDKContactAddress.Text = "Adresse"
        '
        'txtDKContactName
        '
        Me.txtDKContactName.Location = New System.Drawing.Point(80, 16)
        Me.txtDKContactName.Name = "txtDKContactName"
        Me.txtDKContactName.Size = New System.Drawing.Size(210, 20)
        Me.txtDKContactName.TabIndex = 22
        '
        'lblDKContactName
        '
        Me.lblDKContactName.Location = New System.Drawing.Point(8, 24)
        Me.lblDKContactName.Name = "lblDKContactName"
        Me.lblDKContactName.Size = New System.Drawing.Size(72, 23)
        Me.lblDKContactName.TabIndex = 100
        Me.lblDKContactName.Text = "Navn"
        '
        'gbxDKAddress
        '
        Me.gbxDKAddress.Controls.Add(Me.txtDKCity)
        Me.gbxDKAddress.Controls.Add(Me.txtDKPostalCode)
        Me.gbxDKAddress.Controls.Add(Me.lblDKPostalCode)
        Me.gbxDKAddress.Controls.Add(Me.txtDKAddress)
        Me.gbxDKAddress.Controls.Add(Me.lblDKAddress)
        Me.gbxDKAddress.Controls.Add(Me.lblPhone)
        Me.gbxDKAddress.Controls.Add(Me.txtPhone2)
        Me.gbxDKAddress.Controls.Add(Me.txtEmail)
        Me.gbxDKAddress.Controls.Add(Me.lblEmail)
        Me.gbxDKAddress.Controls.Add(Me.txtPhone)
        Me.gbxDKAddress.Location = New System.Drawing.Point(248, 239)
        Me.gbxDKAddress.Name = "gbxDKAddress"
        Me.gbxDKAddress.Size = New System.Drawing.Size(296, 116)
        Me.gbxDKAddress.TabIndex = 16
        Me.gbxDKAddress.TabStop = False
        Me.gbxDKAddress.Text = "Dansk adresse"
        '
        'txtDKCity
        '
        Me.txtDKCity.Location = New System.Drawing.Point(152, 40)
        Me.txtDKCity.Name = "txtDKCity"
        Me.txtDKCity.Size = New System.Drawing.Size(136, 20)
        Me.txtDKCity.TabIndex = 18
        '
        'txtDKPostalCode
        '
        Me.txtDKPostalCode.Location = New System.Drawing.Point(80, 40)
        Me.txtDKPostalCode.Name = "txtDKPostalCode"
        Me.txtDKPostalCode.Size = New System.Drawing.Size(64, 20)
        Me.txtDKPostalCode.TabIndex = 17
        '
        'lblDKPostalCode
        '
        Me.lblDKPostalCode.Location = New System.Drawing.Point(8, 48)
        Me.lblDKPostalCode.Name = "lblDKPostalCode"
        Me.lblDKPostalCode.Size = New System.Drawing.Size(64, 16)
        Me.lblDKPostalCode.TabIndex = 100
        Me.lblDKPostalCode.Text = "Postnr/By"
        '
        'txtDKAddress
        '
        Me.txtDKAddress.Location = New System.Drawing.Point(80, 16)
        Me.txtDKAddress.Name = "txtDKAddress"
        Me.txtDKAddress.Size = New System.Drawing.Size(208, 20)
        Me.txtDKAddress.TabIndex = 16
        '
        'lblDKAddress
        '
        Me.lblDKAddress.Location = New System.Drawing.Point(8, 24)
        Me.lblDKAddress.Name = "lblDKAddress"
        Me.lblDKAddress.Size = New System.Drawing.Size(56, 23)
        Me.lblDKAddress.TabIndex = 100
        Me.lblDKAddress.Text = "Adresse"
        '
        'lblPhone
        '
        Me.lblPhone.Location = New System.Drawing.Point(8, 66)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(40, 23)
        Me.lblPhone.TabIndex = 100
        Me.lblPhone.Text = "Tlf.1/2"
        '
        'txtPhone2
        '
        Me.txtPhone2.Location = New System.Drawing.Point(184, 66)
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Size = New System.Drawing.Size(104, 20)
        Me.txtPhone2.TabIndex = 20
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(80, 92)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(208, 20)
        Me.txtEmail.TabIndex = 21
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(8, 92)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(40, 23)
        Me.lblEmail.TabIndex = 100
        Me.lblEmail.Text = "E-mail"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(80, 66)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 19
        '
        'gbxResident
        '
        Me.gbxResident.Controls.Add(Me.lblCurrentRoomAndBed)
        Me.gbxResident.Controls.Add(Me.datDeparture)
        Me.gbxResident.Controls.Add(Me.txtID)
        Me.gbxResident.Controls.Add(Me.lblID)
        Me.gbxResident.Controls.Add(Me.txtChronicIllness)
        Me.gbxResident.Controls.Add(Me.lblChronicIllness)
        Me.gbxResident.Controls.Add(Me.lblDeparture)
        Me.gbxResident.Controls.Add(Me.lblArrival)
        Me.gbxResident.Controls.Add(Me.lblCPR)
        Me.gbxResident.Controls.Add(Me.txtCPR)
        Me.gbxResident.Controls.Add(Me.txtLastName)
        Me.gbxResident.Controls.Add(Me.txtFirstName)
        Me.gbxResident.Controls.Add(Me.lblFirstName)
        Me.gbxResident.Controls.Add(Me.lblLastName)
        Me.gbxResident.Controls.Add(Me.btnNewResident)
        Me.gbxResident.Controls.Add(Me.datArrival)
        Me.gbxResident.Location = New System.Drawing.Point(248, 9)
        Me.gbxResident.Name = "gbxResident"
        Me.gbxResident.Size = New System.Drawing.Size(296, 224)
        Me.gbxResident.TabIndex = 10
        Me.gbxResident.TabStop = False
        Me.gbxResident.Text = "Beboerdata"
        '
        'lblCurrentRoomAndBed
        '
        Me.lblCurrentRoomAndBed.AutoSize = True
        Me.lblCurrentRoomAndBed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentRoomAndBed.Location = New System.Drawing.Point(7, 16)
        Me.lblCurrentRoomAndBed.Name = "lblCurrentRoomAndBed"
        Me.lblCurrentRoomAndBed.Size = New System.Drawing.Size(0, 20)
        Me.lblCurrentRoomAndBed.TabIndex = 101
        '
        'datDeparture
        '
        Me.datDeparture.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datDeparture.Location = New System.Drawing.Point(80, 195)
        Me.datDeparture.Name = "datDeparture"
        Me.datDeparture.Size = New System.Drawing.Size(208, 20)
        Me.datDeparture.TabIndex = 15
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(80, 49)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(40, 20)
        Me.txtID.TabIndex = 100
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblID
        '
        Me.lblID.Location = New System.Drawing.Point(8, 49)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(40, 23)
        Me.lblID.TabIndex = 100
        Me.lblID.Text = "ID"
        '
        'txtChronicIllness
        '
        Me.txtChronicIllness.Location = New System.Drawing.Point(128, 143)
        Me.txtChronicIllness.Name = "txtChronicIllness"
        Me.txtChronicIllness.Size = New System.Drawing.Size(160, 20)
        Me.txtChronicIllness.TabIndex = 13
        '
        'lblChronicIllness
        '
        Me.lblChronicIllness.Location = New System.Drawing.Point(8, 143)
        Me.lblChronicIllness.Name = "lblChronicIllness"
        Me.lblChronicIllness.Size = New System.Drawing.Size(88, 23)
        Me.lblChronicIllness.TabIndex = 100
        Me.lblChronicIllness.Text = "Kronisk sygdom"
        '
        'lblDeparture
        '
        Me.lblDeparture.Location = New System.Drawing.Point(8, 195)
        Me.lblDeparture.Name = "lblDeparture"
        Me.lblDeparture.Size = New System.Drawing.Size(40, 23)
        Me.lblDeparture.TabIndex = 100
        Me.lblDeparture.Text = "Afrejse"
        '
        'lblArrival
        '
        Me.lblArrival.Location = New System.Drawing.Point(8, 169)
        Me.lblArrival.Name = "lblArrival"
        Me.lblArrival.Size = New System.Drawing.Size(48, 23)
        Me.lblArrival.TabIndex = 100
        Me.lblArrival.Text = "Ankomst"
        '
        'lblCPR
        '
        Me.lblCPR.Location = New System.Drawing.Point(8, 121)
        Me.lblCPR.Name = "lblCPR"
        Me.lblCPR.Size = New System.Drawing.Size(88, 23)
        Me.lblCPR.TabIndex = 100
        Me.lblCPR.Text = "Fødselsdato"
        '
        'txtCPR
        '
        Me.txtCPR.Location = New System.Drawing.Point(128, 121)
        Me.txtCPR.Name = "txtCPR"
        Me.txtCPR.Size = New System.Drawing.Size(160, 20)
        Me.txtCPR.TabIndex = 12
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(80, 97)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(208, 20)
        Me.txtLastName.TabIndex = 11
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(80, 73)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(208, 20)
        Me.txtFirstName.TabIndex = 10
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(8, 73)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(48, 24)
        Me.lblFirstName.TabIndex = 100
        Me.lblFirstName.Text = "Fornavn"
        '
        'lblLastName
        '
        Me.lblLastName.Location = New System.Drawing.Point(8, 97)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(64, 23)
        Me.lblLastName.TabIndex = 100
        Me.lblLastName.Text = "Efternavn"
        '
        'btnNewResident
        '
        Me.btnNewResident.Location = New System.Drawing.Point(224, 41)
        Me.btnNewResident.Name = "btnNewResident"
        Me.btnNewResident.Size = New System.Drawing.Size(64, 23)
        Me.btnNewResident.TabIndex = 100
        Me.btnNewResident.Text = "Opret ny"
        '
        'datArrival
        '
        Me.datArrival.CustomFormat = "ddMMyyyy"
        Me.datArrival.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datArrival.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.datArrival.Location = New System.Drawing.Point(80, 169)
        Me.datArrival.Name = "datArrival"
        Me.datArrival.Size = New System.Drawing.Size(208, 20)
        Me.datArrival.TabIndex = 14
        '
        'lbxResidents
        '
        Me.lbxResidents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbxResidents.Location = New System.Drawing.Point(8, 152)
        Me.lbxResidents.Name = "lbxResidents"
        Me.lbxResidents.Size = New System.Drawing.Size(232, 381)
        Me.lbxResidents.TabIndex = 100
        '
        'tabUsers
        '
        Me.tabUsers.Controls.Add(Me.dgrUsers)
        Me.tabUsers.Controls.Add(Me.btnSaveUsers)
        Me.tabUsers.Location = New System.Drawing.Point(4, 22)
        Me.tabUsers.Name = "tabUsers"
        Me.tabUsers.Size = New System.Drawing.Size(984, 543)
        Me.tabUsers.TabIndex = 100
        Me.tabUsers.Text = "Brugere"
        Me.tabUsers.UseVisualStyleBackColor = True
        '
        'dgrUsers
        '
        Me.dgrUsers.DataMember = ""
        Me.dgrUsers.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgrUsers.Location = New System.Drawing.Point(0, 0)
        Me.dgrUsers.Name = "dgrUsers"
        Me.dgrUsers.PreferredColumnWidth = 274
        Me.dgrUsers.RowHeaderWidth = 100
        Me.dgrUsers.Size = New System.Drawing.Size(576, 304)
        Me.dgrUsers.TabIndex = 1
        '
        'btnSaveUsers
        '
        Me.btnSaveUsers.Location = New System.Drawing.Point(464, 312)
        Me.btnSaveUsers.Name = "btnSaveUsers"
        Me.btnSaveUsers.Size = New System.Drawing.Size(104, 23)
        Me.btnSaveUsers.TabIndex = 100
        Me.btnSaveUsers.Text = "Gem opdateringer"
        '
        'tabRoomsAndBeds
        '
        Me.tabRoomsAndBeds.Controls.Add(Me.gbxBeds)
        Me.tabRoomsAndBeds.Controls.Add(Me.gbxRooms)
        Me.tabRoomsAndBeds.Location = New System.Drawing.Point(4, 22)
        Me.tabRoomsAndBeds.Name = "tabRoomsAndBeds"
        Me.tabRoomsAndBeds.Size = New System.Drawing.Size(984, 543)
        Me.tabRoomsAndBeds.TabIndex = 100
        Me.tabRoomsAndBeds.Text = "Værelser og senge"
        Me.tabRoomsAndBeds.UseVisualStyleBackColor = True
        '
        'gbxBeds
        '
        Me.gbxBeds.Controls.Add(Me.chkIsPermanent)
        Me.gbxBeds.Controls.Add(Me.txtBedDescription)
        Me.gbxBeds.Controls.Add(Me.lblBedsInRoom)
        Me.gbxBeds.Controls.Add(Me.lbxBeds)
        Me.gbxBeds.Controls.Add(Me.btnSaveBed)
        Me.gbxBeds.Controls.Add(Me.Label6)
        Me.gbxBeds.Controls.Add(Me.Label7)
        Me.gbxBeds.Controls.Add(Me.txtBedKey)
        Me.gbxBeds.Controls.Add(Me.btnEditBed)
        Me.gbxBeds.Location = New System.Drawing.Point(552, 16)
        Me.gbxBeds.Name = "gbxBeds"
        Me.gbxBeds.Size = New System.Drawing.Size(256, 408)
        Me.gbxBeds.TabIndex = 100
        Me.gbxBeds.TabStop = False
        Me.gbxBeds.Text = "Senge"
        '
        'chkIsPermanent
        '
        Me.chkIsPermanent.AutoSize = True
        Me.chkIsPermanent.Location = New System.Drawing.Point(72, 301)
        Me.chkIsPermanent.Name = "chkIsPermanent"
        Me.chkIsPermanent.Size = New System.Drawing.Size(75, 17)
        Me.chkIsPermanent.TabIndex = 110
        Me.chkIsPermanent.Text = "Opredning"
        Me.chkIsPermanent.UseVisualStyleBackColor = True
        '
        'txtBedDescription
        '
        Me.txtBedDescription.Location = New System.Drawing.Point(72, 352)
        Me.txtBedDescription.Name = "txtBedDescription"
        Me.txtBedDescription.Size = New System.Drawing.Size(168, 20)
        Me.txtBedDescription.TabIndex = 12
        '
        'lblBedsInRoom
        '
        Me.lblBedsInRoom.Location = New System.Drawing.Point(16, 24)
        Me.lblBedsInRoom.Name = "lblBedsInRoom"
        Me.lblBedsInRoom.Size = New System.Drawing.Size(224, 23)
        Me.lblBedsInRoom.TabIndex = 100
        '
        'lbxBeds
        '
        Me.lbxBeds.Location = New System.Drawing.Point(16, 56)
        Me.lbxBeds.Name = "lbxBeds"
        Me.lbxBeds.Size = New System.Drawing.Size(224, 238)
        Me.lbxBeds.TabIndex = 100
        '
        'btnSaveBed
        '
        Me.btnSaveBed.Location = New System.Drawing.Point(184, 376)
        Me.btnSaveBed.Name = "btnSaveBed"
        Me.btnSaveBed.Size = New System.Drawing.Size(56, 23)
        Me.btnSaveBed.TabIndex = 13
        Me.btnSaveBed.Text = "Gem"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 23)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Beskrivelse"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 23)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "Kode"
        '
        'txtBedKey
        '
        Me.txtBedKey.Location = New System.Drawing.Point(72, 328)
        Me.txtBedKey.Name = "txtBedKey"
        Me.txtBedKey.Size = New System.Drawing.Size(56, 20)
        Me.txtBedKey.TabIndex = 11
        '
        'btnEditBed
        '
        Me.btnEditBed.Location = New System.Drawing.Point(104, 376)
        Me.btnEditBed.Name = "btnEditBed"
        Me.btnEditBed.Size = New System.Drawing.Size(75, 23)
        Me.btnEditBed.TabIndex = 109
        Me.btnEditBed.Text = "Opret ny"
        '
        'gbxRooms
        '
        Me.gbxRooms.Controls.Add(Me.btnEditRoom)
        Me.gbxRooms.Controls.Add(Me.ddlStatus)
        Me.gbxRooms.Controls.Add(Me.Label4)
        Me.gbxRooms.Controls.Add(Me.Label3)
        Me.gbxRooms.Controls.Add(Me.ddlType)
        Me.gbxRooms.Controls.Add(Me.txtRoomDescription)
        Me.gbxRooms.Controls.Add(Me.Label2)
        Me.gbxRooms.Controls.Add(Me.Label1)
        Me.gbxRooms.Controls.Add(Me.Label5)
        Me.gbxRooms.Controls.Add(Me.lbxRooms)
        Me.gbxRooms.Controls.Add(Me.txtRoomKey)
        Me.gbxRooms.Controls.Add(Me.btnSaveRoom)
        Me.gbxRooms.Location = New System.Drawing.Point(8, 16)
        Me.gbxRooms.Name = "gbxRooms"
        Me.gbxRooms.Size = New System.Drawing.Size(536, 408)
        Me.gbxRooms.TabIndex = 100
        Me.gbxRooms.TabStop = False
        Me.gbxRooms.Text = "Værelser og kollegier"
        '
        'btnEditRoom
        '
        Me.btnEditRoom.Location = New System.Drawing.Point(392, 376)
        Me.btnEditRoom.Name = "btnEditRoom"
        Me.btnEditRoom.Size = New System.Drawing.Size(75, 23)
        Me.btnEditRoom.TabIndex = 108
        Me.btnEditRoom.Text = "Opret ny"
        '
        'ddlStatus
        '
        Me.ddlStatus.Items.AddRange(New Object() {"Pigeværelse", "Drengeværelse", "Gæsteværelse", "Staffværelse"})
        Me.ddlStatus.Location = New System.Drawing.Point(368, 176)
        Me.ddlStatus.Name = "ddlStatus"
        Me.ddlStatus.Size = New System.Drawing.Size(160, 21)
        Me.ddlStatus.TabIndex = 13
        Me.ddlStatus.Text = "Vælg status"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(248, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Status"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(248, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Type"
        '
        'ddlType
        '
        Me.ddlType.Items.AddRange(New Object() {"Værelse", "Kollegie"})
        Me.ddlType.Location = New System.Drawing.Point(368, 152)
        Me.ddlType.Name = "ddlType"
        Me.ddlType.Size = New System.Drawing.Size(160, 21)
        Me.ddlType.TabIndex = 12
        Me.ddlType.Text = "Vælg type"
        '
        'txtRoomDescription
        '
        Me.txtRoomDescription.Location = New System.Drawing.Point(368, 128)
        Me.txtRoomDescription.Name = "txtRoomDescription"
        Me.txtRoomDescription.Size = New System.Drawing.Size(160, 20)
        Me.txtRoomDescription.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(248, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Beskrivelse"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(248, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Kode"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 72)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Du kan oprette et nyt værelse herunder ved at skrive værelsets betegnelse i felte" & _
            "t og derefter trykke gem. Ved at klikke på værelset i listen kan du se og oprett" & _
            "e nye senge på værelset. "
        '
        'lbxRooms
        '
        Me.lbxRooms.Location = New System.Drawing.Point(16, 104)
        Me.lbxRooms.Name = "lbxRooms"
        Me.lbxRooms.Size = New System.Drawing.Size(224, 290)
        Me.lbxRooms.TabIndex = 100
        '
        'txtRoomKey
        '
        Me.txtRoomKey.Location = New System.Drawing.Point(368, 104)
        Me.txtRoomKey.Name = "txtRoomKey"
        Me.txtRoomKey.Size = New System.Drawing.Size(56, 20)
        Me.txtRoomKey.TabIndex = 10
        '
        'btnSaveRoom
        '
        Me.btnSaveRoom.Location = New System.Drawing.Point(472, 376)
        Me.btnSaveRoom.Name = "btnSaveRoom"
        Me.btnSaveRoom.Size = New System.Drawing.Size(56, 23)
        Me.btnSaveRoom.TabIndex = 14
        Me.btnSaveRoom.Text = "Gem"
        '
        'tabPrices
        '
        Me.tabPrices.Controls.Add(Me.gbxPrices)
        Me.tabPrices.Location = New System.Drawing.Point(4, 22)
        Me.tabPrices.Name = "tabPrices"
        Me.tabPrices.Size = New System.Drawing.Size(984, 543)
        Me.tabPrices.TabIndex = 100
        Me.tabPrices.Text = "Priser"
        Me.tabPrices.UseVisualStyleBackColor = True
        '
        'gbxPrices
        '
        Me.gbxPrices.Controls.Add(Me.datPriceValidFrom)
        Me.gbxPrices.Controls.Add(Me.btnNewPriceSet)
        Me.gbxPrices.Controls.Add(Me.ddlPriceSets)
        Me.gbxPrices.Controls.Add(Me.Label15)
        Me.gbxPrices.Controls.Add(Me.txtPriceSeven)
        Me.gbxPrices.Controls.Add(Me.lblPriceSeven)
        Me.gbxPrices.Controls.Add(Me.Label13)
        Me.gbxPrices.Controls.Add(Me.txtPriceSix)
        Me.gbxPrices.Controls.Add(Me.lblPriceSix)
        Me.gbxPrices.Controls.Add(Me.Label14)
        Me.gbxPrices.Controls.Add(Me.txtPriceFive)
        Me.gbxPrices.Controls.Add(Me.lblPriceFive)
        Me.gbxPrices.Controls.Add(Me.Label16)
        Me.gbxPrices.Controls.Add(Me.txtPriceFour)
        Me.gbxPrices.Controls.Add(Me.lblPriceFour)
        Me.gbxPrices.Controls.Add(Me.Label17)
        Me.gbxPrices.Controls.Add(Me.txtPriceThree)
        Me.gbxPrices.Controls.Add(Me.lblPriceThree)
        Me.gbxPrices.Controls.Add(Me.Label18)
        Me.gbxPrices.Controls.Add(Me.txtPriceTwo)
        Me.gbxPrices.Controls.Add(Me.lblPriceTwo)
        Me.gbxPrices.Controls.Add(Me.Label19)
        Me.gbxPrices.Controls.Add(Me.txtPriceOne)
        Me.gbxPrices.Controls.Add(Me.lblPriceOne)
        Me.gbxPrices.Controls.Add(Me.Label22)
        Me.gbxPrices.Controls.Add(Me.btnSave)
        Me.gbxPrices.Location = New System.Drawing.Point(8, 8)
        Me.gbxPrices.Name = "gbxPrices"
        Me.gbxPrices.Size = New System.Drawing.Size(336, 392)
        Me.gbxPrices.TabIndex = 100
        Me.gbxPrices.TabStop = False
        Me.gbxPrices.Text = "Prissæt"
        '
        'datPriceValidFrom
        '
        Me.datPriceValidFrom.Location = New System.Drawing.Point(16, 352)
        Me.datPriceValidFrom.Name = "datPriceValidFrom"
        Me.datPriceValidFrom.Size = New System.Drawing.Size(208, 20)
        Me.datPriceValidFrom.TabIndex = 17
        '
        'btnNewPriceSet
        '
        Me.btnNewPriceSet.Location = New System.Drawing.Point(248, 24)
        Me.btnNewPriceSet.Name = "btnNewPriceSet"
        Me.btnNewPriceSet.Size = New System.Drawing.Size(75, 23)
        Me.btnNewPriceSet.TabIndex = 100
        Me.btnNewPriceSet.Text = "Nyt sæt"
        '
        'ddlPriceSets
        '
        Me.ddlPriceSets.Location = New System.Drawing.Point(16, 24)
        Me.ddlPriceSets.Name = "ddlPriceSets"
        Me.ddlPriceSets.Size = New System.Drawing.Size(208, 21)
        Me.ddlPriceSets.TabIndex = 100
        Me.ddlPriceSets.Text = "Prissæt"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(232, 304)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 16)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "£"
        '
        'txtPriceSeven
        '
        Me.txtPriceSeven.Location = New System.Drawing.Point(248, 296)
        Me.txtPriceSeven.Name = "txtPriceSeven"
        Me.txtPriceSeven.Size = New System.Drawing.Size(72, 20)
        Me.txtPriceSeven.TabIndex = 16
        '
        'lblPriceSeven
        '
        Me.lblPriceSeven.Location = New System.Drawing.Point(24, 296)
        Me.lblPriceSeven.Name = "lblPriceSeven"
        Me.lblPriceSeven.Size = New System.Drawing.Size(200, 24)
        Me.lblPriceSeven.TabIndex = 100
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(232, 272)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 16)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "£"
        '
        'txtPriceSix
        '
        Me.txtPriceSix.Location = New System.Drawing.Point(248, 264)
        Me.txtPriceSix.Name = "txtPriceSix"
        Me.txtPriceSix.Size = New System.Drawing.Size(72, 20)
        Me.txtPriceSix.TabIndex = 15
        '
        'lblPriceSix
        '
        Me.lblPriceSix.Location = New System.Drawing.Point(24, 264)
        Me.lblPriceSix.Name = "lblPriceSix"
        Me.lblPriceSix.Size = New System.Drawing.Size(200, 24)
        Me.lblPriceSix.TabIndex = 100
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(232, 240)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 16)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "£"
        '
        'txtPriceFive
        '
        Me.txtPriceFive.Location = New System.Drawing.Point(248, 232)
        Me.txtPriceFive.Name = "txtPriceFive"
        Me.txtPriceFive.Size = New System.Drawing.Size(72, 20)
        Me.txtPriceFive.TabIndex = 14
        '
        'lblPriceFive
        '
        Me.lblPriceFive.Location = New System.Drawing.Point(24, 232)
        Me.lblPriceFive.Name = "lblPriceFive"
        Me.lblPriceFive.Size = New System.Drawing.Size(200, 24)
        Me.lblPriceFive.TabIndex = 100
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(232, 208)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 16)
        Me.Label16.TabIndex = 100
        Me.Label16.Text = "£"
        '
        'txtPriceFour
        '
        Me.txtPriceFour.Location = New System.Drawing.Point(248, 200)
        Me.txtPriceFour.Name = "txtPriceFour"
        Me.txtPriceFour.Size = New System.Drawing.Size(72, 20)
        Me.txtPriceFour.TabIndex = 13
        '
        'lblPriceFour
        '
        Me.lblPriceFour.Location = New System.Drawing.Point(24, 200)
        Me.lblPriceFour.Name = "lblPriceFour"
        Me.lblPriceFour.Size = New System.Drawing.Size(200, 24)
        Me.lblPriceFour.TabIndex = 100
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(232, 176)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(16, 16)
        Me.Label17.TabIndex = 100
        Me.Label17.Text = "£"
        '
        'txtPriceThree
        '
        Me.txtPriceThree.Location = New System.Drawing.Point(248, 168)
        Me.txtPriceThree.Name = "txtPriceThree"
        Me.txtPriceThree.Size = New System.Drawing.Size(72, 20)
        Me.txtPriceThree.TabIndex = 12
        '
        'lblPriceThree
        '
        Me.lblPriceThree.Location = New System.Drawing.Point(24, 168)
        Me.lblPriceThree.Name = "lblPriceThree"
        Me.lblPriceThree.Size = New System.Drawing.Size(200, 24)
        Me.lblPriceThree.TabIndex = 100
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(232, 144)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(16, 16)
        Me.Label18.TabIndex = 100
        Me.Label18.Text = "£"
        '
        'txtPriceTwo
        '
        Me.txtPriceTwo.Location = New System.Drawing.Point(248, 136)
        Me.txtPriceTwo.Name = "txtPriceTwo"
        Me.txtPriceTwo.Size = New System.Drawing.Size(72, 20)
        Me.txtPriceTwo.TabIndex = 11
        '
        'lblPriceTwo
        '
        Me.lblPriceTwo.Location = New System.Drawing.Point(24, 136)
        Me.lblPriceTwo.Name = "lblPriceTwo"
        Me.lblPriceTwo.Size = New System.Drawing.Size(200, 24)
        Me.lblPriceTwo.TabIndex = 100
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(232, 112)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 16)
        Me.Label19.TabIndex = 100
        Me.Label19.Text = "£"
        '
        'txtPriceOne
        '
        Me.txtPriceOne.Location = New System.Drawing.Point(248, 104)
        Me.txtPriceOne.Name = "txtPriceOne"
        Me.txtPriceOne.Size = New System.Drawing.Size(72, 20)
        Me.txtPriceOne.TabIndex = 10
        '
        'lblPriceOne
        '
        Me.lblPriceOne.Location = New System.Drawing.Point(24, 104)
        Me.lblPriceOne.Name = "lblPriceOne"
        Me.lblPriceOne.Size = New System.Drawing.Size(200, 24)
        Me.lblPriceOne.TabIndex = 100
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(16, 328)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(216, 23)
        Me.Label22.TabIndex = 100
        Me.Label22.Text = "Opret et nyt sæt priser gyldigt fra og med "
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(248, 352)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Gem"
        '
        'tabPrint
        '
        Me.tabPrint.Controls.Add(Me.gbxStats)
        Me.tabPrint.Controls.Add(Me.gbxResidentList)
        Me.tabPrint.Controls.Add(Me.btnBlankWelcome)
        Me.tabPrint.Location = New System.Drawing.Point(4, 22)
        Me.tabPrint.Name = "tabPrint"
        Me.tabPrint.Size = New System.Drawing.Size(984, 543)
        Me.tabPrint.TabIndex = 101
        Me.tabPrint.Text = "Udskrifter"
        Me.tabPrint.UseVisualStyleBackColor = True
        '
        'gbxStats
        '
        Me.gbxStats.Controls.Add(Me.gbxOldStats)
        Me.gbxStats.Controls.Add(Me.gbxNewStat)
        Me.gbxStats.Location = New System.Drawing.Point(221, 5)
        Me.gbxStats.Name = "gbxStats"
        Me.gbxStats.Size = New System.Drawing.Size(431, 394)
        Me.gbxStats.TabIndex = 4
        Me.gbxStats.TabStop = False
        Me.gbxStats.Text = "Statistik"
        '
        'gbxOldStats
        '
        Me.gbxOldStats.Controls.Add(Me.chkStatsShowAll)
        Me.gbxOldStats.Controls.Add(Me.datStatsShow)
        Me.gbxOldStats.Controls.Add(Me.btnStatsView)
        Me.gbxOldStats.Controls.Add(Me.lbxStats)
        Me.gbxOldStats.Location = New System.Drawing.Point(6, 101)
        Me.gbxOldStats.Name = "gbxOldStats"
        Me.gbxOldStats.Size = New System.Drawing.Size(419, 282)
        Me.gbxOldStats.TabIndex = 5
        Me.gbxOldStats.TabStop = False
        Me.gbxOldStats.Text = "Vis statistik fra tidligere"
        '
        'chkStatsShowAll
        '
        Me.chkStatsShowAll.AutoSize = True
        Me.chkStatsShowAll.Location = New System.Drawing.Point(214, 22)
        Me.chkStatsShowAll.Name = "chkStatsShowAll"
        Me.chkStatsShowAll.Size = New System.Drawing.Size(59, 17)
        Me.chkStatsShowAll.TabIndex = 6
        Me.chkStatsShowAll.Text = "Vis alle"
        Me.chkStatsShowAll.UseVisualStyleBackColor = True
        '
        'datStatsShow
        '
        Me.datStatsShow.CustomFormat = "MMMMMM yyyy"
        Me.datStatsShow.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datStatsShow.Location = New System.Drawing.Point(7, 20)
        Me.datStatsShow.Name = "datStatsShow"
        Me.datStatsShow.Size = New System.Drawing.Size(200, 20)
        Me.datStatsShow.TabIndex = 5
        '
        'btnStatsView
        '
        Me.btnStatsView.Location = New System.Drawing.Point(304, 16)
        Me.btnStatsView.Name = "btnStatsView"
        Me.btnStatsView.Size = New System.Drawing.Size(108, 23)
        Me.btnStatsView.TabIndex = 4
        Me.btnStatsView.Text = "Vis"
        Me.btnStatsView.UseVisualStyleBackColor = True
        '
        'lbxStats
        '
        Me.lbxStats.FormattingEnabled = True
        Me.lbxStats.Location = New System.Drawing.Point(7, 46)
        Me.lbxStats.Name = "lbxStats"
        Me.lbxStats.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbxStats.Size = New System.Drawing.Size(405, 225)
        Me.lbxStats.TabIndex = 2
        '
        'gbxNewStat
        '
        Me.gbxNewStat.Controls.Add(Me.datStatsFrom)
        Me.gbxNewStat.Controls.Add(Me.btnPrintStats)
        Me.gbxNewStat.Controls.Add(Me.datStatsTo)
        Me.gbxNewStat.Location = New System.Drawing.Point(6, 19)
        Me.gbxNewStat.Name = "gbxNewStat"
        Me.gbxNewStat.Size = New System.Drawing.Size(419, 76)
        Me.gbxNewStat.TabIndex = 4
        Me.gbxNewStat.TabStop = False
        Me.gbxNewStat.Text = "Gem og udskriv ny statistik"
        '
        'datStatsFrom
        '
        Me.datStatsFrom.Location = New System.Drawing.Point(6, 19)
        Me.datStatsFrom.Name = "datStatsFrom"
        Me.datStatsFrom.Size = New System.Drawing.Size(200, 20)
        Me.datStatsFrom.TabIndex = 0
        '
        'btnPrintStats
        '
        Me.btnPrintStats.Location = New System.Drawing.Point(304, 45)
        Me.btnPrintStats.Name = "btnPrintStats"
        Me.btnPrintStats.Size = New System.Drawing.Size(108, 23)
        Me.btnPrintStats.TabIndex = 3
        Me.btnPrintStats.Text = "Gem og Udskriv"
        Me.btnPrintStats.UseVisualStyleBackColor = True
        '
        'datStatsTo
        '
        Me.datStatsTo.Location = New System.Drawing.Point(212, 19)
        Me.datStatsTo.Name = "datStatsTo"
        Me.datStatsTo.Size = New System.Drawing.Size(200, 20)
        Me.datStatsTo.TabIndex = 1
        '
        'gbxResidentList
        '
        Me.gbxResidentList.Controls.Add(Me.datResidentList)
        Me.gbxResidentList.Controls.Add(Me.btnPrintResidentList)
        Me.gbxResidentList.Location = New System.Drawing.Point(3, 5)
        Me.gbxResidentList.Name = "gbxResidentList"
        Me.gbxResidentList.Size = New System.Drawing.Size(212, 78)
        Me.gbxResidentList.TabIndex = 3
        Me.gbxResidentList.TabStop = False
        Me.gbxResidentList.Text = "Beboerliste"
        '
        'datResidentList
        '
        Me.datResidentList.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datResidentList.Location = New System.Drawing.Point(6, 19)
        Me.datResidentList.Name = "datResidentList"
        Me.datResidentList.Size = New System.Drawing.Size(200, 20)
        Me.datResidentList.TabIndex = 1
        '
        'btnPrintResidentList
        '
        Me.btnPrintResidentList.Location = New System.Drawing.Point(6, 45)
        Me.btnPrintResidentList.Name = "btnPrintResidentList"
        Me.btnPrintResidentList.Size = New System.Drawing.Size(200, 23)
        Me.btnPrintResidentList.TabIndex = 2
        Me.btnPrintResidentList.Text = "Udskriv beboerliste"
        Me.btnPrintResidentList.UseVisualStyleBackColor = True
        '
        'btnBlankWelcome
        '
        Me.btnBlankWelcome.Location = New System.Drawing.Point(9, 89)
        Me.btnBlankWelcome.Name = "btnBlankWelcome"
        Me.btnBlankWelcome.Size = New System.Drawing.Size(200, 23)
        Me.btnBlankWelcome.TabIndex = 0
        Me.btnBlankWelcome.Text = "Print blank velkomst"
        Me.btnBlankWelcome.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 120000
        Me.Timer1.SynchronizingObject = Me
        '
        'prdWelcomeNote
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'prdResidentLIst
        '
        '
        'prdStats
        '
        '
        'btnDebug
        '
        Me.btnDebug.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDebug.Location = New System.Drawing.Point(412, 7)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(110, 23)
        Me.btnDebug.TabIndex = 101
        Me.btnDebug.Text = "DEBUG"
        Me.btnDebug.UseVisualStyleBackColor = False
        '
        'btnPrintSelectedList
        '
        Me.btnPrintSelectedList.Location = New System.Drawing.Point(4, 35)
        Me.btnPrintSelectedList.Name = "btnPrintSelectedList"
        Me.btnPrintSelectedList.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintSelectedList.TabIndex = 104
        Me.btnPrintSelectedList.Text = "Udskriv"
        Me.btnPrintSelectedList.UseVisualStyleBackColor = True
        '
        'K_Booking_Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1013, 732)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnLogOut)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "K_Booking_Main"
        Me.Text = "Dansk KFUK - booking "
        Me.tabMain.ResumeLayout(False)
        Me.tabResidents.ResumeLayout(False)
        Me.tabResidents.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxHoliday.ResumeLayout(False)
        Me.gbxPayment.ResumeLayout(False)
        Me.gbxPayment.PerformLayout()
        Me.gbxRoomAndBed.ResumeLayout(False)
        Me.gbxRoomAndBed.PerformLayout()
        Me.gbxDKContact.ResumeLayout(False)
        Me.gbxDKContact.PerformLayout()
        Me.gbxDKAddress.ResumeLayout(False)
        Me.gbxDKAddress.PerformLayout()
        Me.gbxResident.ResumeLayout(False)
        Me.gbxResident.PerformLayout()
        Me.tabUsers.ResumeLayout(False)
        CType(Me.dgrUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRoomsAndBeds.ResumeLayout(False)
        Me.gbxBeds.ResumeLayout(False)
        Me.gbxBeds.PerformLayout()
        Me.gbxRooms.ResumeLayout(False)
        Me.gbxRooms.PerformLayout()
        Me.tabPrices.ResumeLayout(False)
        Me.gbxPrices.ResumeLayout(False)
        Me.gbxPrices.PerformLayout()
        Me.tabPrint.ResumeLayout(False)
        Me.gbxStats.ResumeLayout(False)
        Me.gbxOldStats.ResumeLayout(False)
        Me.gbxOldStats.PerformLayout()
        Me.gbxNewStat.ResumeLayout(False)
        Me.gbxResidentList.ResumeLayout(False)
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Shared Sub Main()
        Dim formMain As New K.Booking.K_Booking_Main
        formMain.KeyPreview = True
        Application.EnableVisualStyles()
        Application.Run(formMain)
    End Sub

    Public LoggedInUserFullName As String = ""
    Public LoggedInUser_ID As Integer = 0
    Private CurrentResident As Elements.Resident

#Region " Load "
    Private Sub K_Booking_Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim u As New Elements.User()
        'u.Active = 1
        'u.FullName = "Maria Skovmand"
        'u.LoginName = "maria"
        'u.Save()
        Login()
    End Sub
#End Region

#Region " Main "
    Public Sub Welcome()
#If DEBUG Then
        Me.btnDebug.Visible = True
#Else
        Me.btnDebug.Visible = False 
#End If
        Me.WindowState = FormWindowState.Maximized
        Me.lblWelcome.Text = "Velkommen " & LoggedInUserFullName

        StartResident()

        'set default date for resident list print
        Me.datResidentList.Value = Now.AddDays(1)
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        SaveResident()
        CurrentResident = Nothing
        LoggedInUser_ID = 0
        LoggedInUserFullName = ""
        Login()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        SaveResident()
        Me.Dispose()
    End Sub
#End Region

#Region " Login "
    Private Sub Login()
        Dim formLogin As New K.Booking.K_Booking_Login

        formLogin.FormMain = Me
        formLogin.ShowDialog()
        formLogin.Close()
    End Sub
#End Region

#Region " Users "
    '## Sub rutines ##
    Private Sub StartUsers()
        Dim u As New Elements.User
        Dim strSQL As String = ""

        Me.dgrUsers.SetDataBinding(u.List(strSQL), "Table")
        Me.dgrUsers.Enabled = True

        Me.dgrUsers.TableStyles.Clear()

        Dim ts As DataGridTableStyle = New DataGridTableStyle

        ts.MappingName = Me.dgrUsers.DataMember
        Me.dgrUsers.TableStyles.Add(ts)
        Me.dgrUsers.TableStyles(0).GridColumnStyles.RemoveAt(0)
        Me.dgrUsers.TableStyles(0).GridColumnStyles(0).Width = 475
        Me.dgrUsers.TableStyles(0).GridColumnStyles.RemoveAt(1)
        Me.dgrUsers.TableStyles(0).GridColumnStyles.RemoveAt(1)
        Me.dgrUsers.TableStyles(0).GridColumnStyles(1).Width = 60

        Me.dgrUsers.TableStyles(0).GridColumnStyles(0).HeaderText = "Fulde navn"
        Me.dgrUsers.TableStyles(0).GridColumnStyles(1).HeaderText = "Aktiv"

        u = Nothing
    End Sub

    Private Sub SaveUser()
        'update dataset in db
        Dim objDataset As DataSet
        Dim u As New Elements.User

        objDataset = CType(Me.dgrUsers.DataSource, DataSet)
        u.SaveDataset(objDataset)

        u = Nothing

        Me.dgrUsers.Update()
        MessageBox.Show("Brugerne er opdateret")
    End Sub

    '## Events ##
    Private Sub btnSaveUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveUsers.Click
        SaveUser()
    End Sub
#End Region

#Region " Residents "
    '## Sub rutines ##
    Private Sub StartResident()
        'load residents (1. tab)
        Me.ddlGender.Items.Clear()
        Me.ddlGender.Items.Insert(Data.GlobalEnums.Gender.Undecided, "Ikke valgt")
        Me.ddlGender.Items.Insert(Data.GlobalEnums.Gender.Male, "Mand")
        Me.ddlGender.Items.Insert(Data.GlobalEnums.Gender.Female, "Kvinde")
        Me.ddlGender.SelectedIndex = 0

        Me.ddlResidentType.Items.Clear()
        Me.ddlResidentType.Items.Insert(Data.GlobalEnums.ResidentType.Undecided, "Ikke valgt")
        Me.ddlResidentType.Items.Insert(Data.GlobalEnums.ResidentType.ShortTerm, "Korttidsbeboer")
        Me.ddlResidentType.Items.Insert(Data.GlobalEnums.ResidentType.LongTerm, "Fast beboer")
        Me.ddlResidentType.Items.Insert(Data.GlobalEnums.ResidentType.Guest, "Gæst")
        Me.ddlResidentType.Items.Insert(Data.GlobalEnums.ResidentType.Appartement, "Kollegie")
        Me.ddlResidentType.Items.Insert(Data.GlobalEnums.ResidentType.Staff, "Staff")
        Me.ddlResidentType.SelectedIndex = 0

        Dim intIndex As Integer = 5 'default current

        If Now.Hour < 11 Then 'show departures for today until 11 o'clock
            intIndex = 1 '2
        End If

        Me.ddlShowResidents.SelectedIndex = intIndex
        ListResidents()
        ResidentEnabled(False)
    End Sub

    Private Sub ResidentEnabled(ByVal bEnabled As Boolean)

        TimerRun(bEnabled)

        Me.txtID.Enabled = bEnabled
        Me.txtFirstName.Enabled = bEnabled
        Me.txtLastName.Enabled = bEnabled
        Me.txtCPR.Enabled = bEnabled
        Me.txtEmail.Enabled = bEnabled
        Me.txtPhone.Enabled = bEnabled
        Me.txtPhone2.Enabled = bEnabled
        Me.txtDKAddress.Enabled = bEnabled
        Me.txtDKPostalCode.Enabled = bEnabled
        Me.txtDKCity.Enabled = bEnabled
        Me.txtDKContactAddress.Enabled = bEnabled
        Me.txtDKContactName.Enabled = bEnabled
        Me.txtDKContactPhone.Enabled = bEnabled
        Me.txtComment.Enabled = bEnabled
        Me.txtChronicIllness.Enabled = bEnabled
        Me.ddlGender.Enabled = bEnabled
        Me.txtNumberOfGuests.Enabled = bEnabled
        Me.ddlResidentType.Enabled = bEnabled
        Me.datArrival.Enabled = bEnabled
        Me.datDeparture.Enabled = bEnabled
        Me.cbxNewsLetter.Enabled = bEnabled
        Me.txtRoomAndBed.Enabled = bEnabled
        Me.datArrival.Enabled = bEnabled
        Me.datDeparture.Enabled = bEnabled
        Me.datHolidayFrom.Enabled = bEnabled
        Me.datHolidayTo.Enabled = bEnabled
        Me.datInBedFrom.Enabled = bEnabled
        Me.datInBedTo.Enabled = bEnabled
        Me.btnEditResidentInBed.Enabled = bEnabled
        Me.btnDeleteResidentInBed.Enabled = bEnabled
        Me.lbxResidentInBed.Enabled = bEnabled
        Me.btnHolidayEdit.Enabled = bEnabled
        Me.btnHolidayDelete.Enabled = bEnabled
        Me.lbxHolidays.Enabled = bEnabled
        Me.btnSaveResident.Enabled = bEnabled
        Me.btnAbortResident.Enabled = bEnabled
        Me.datPaidUntill.Enabled = bEnabled
    End Sub

    ''' <summary>
    ''' CURRENTLY REFACTORING
    ''' Populates the resident ListBox with the relevant residents as selected by the dropdown
    ''' CAVEAT: Search terms are not currently honoured
    ''' </summary>
    Private Sub ListResidents()
        Dim res As DAL.K_Resident = New DAL.K_Resident()
        Select Case GetResidentIndex()
            Case Data.GlobalEnums.ResidentLists.All
                lbxResidents.DataSource = res.ListResidentsAll()
            Case Data.GlobalEnums.ResidentLists.Current
                lbxResidents.DataSource = res.ListResidentsCurrent()
            Case Data.GlobalEnums.ResidentLists.Arrivals
                lbxResidents.DataSource = res.ListResidentsArrivals()
            Case Data.GlobalEnums.ResidentLists.Future
                lbxResidents.DataSource = res.ListResidentsFuture()
            Case Data.GlobalEnums.ResidentLists.Departures
                lbxResidents.DataSource = res.ListResidentsDeparture()
            Case Data.GlobalEnums.ResidentLists.Staff
                lbxResidents.DataSource = res.ListResidentsStaff()
            Case Data.GlobalEnums.ResidentLists.Appartment
                lbxResidents.DataSource = res.ListResidentsAppartment()
            Case Data.GlobalEnums.ResidentLists.Former
                lbxResidents.DataSource = res.ListResidentsFormer()
            Case Data.GlobalEnums.ResidentLists.Annulled
                lbxResidents.DataSource = res.ListResidentsAnnulled()
            Case Else
                Dim r As New Elements.Resident
                Dim t As DataTable = r.List(WriteSQL).Tables(0)
                lbxResidents.DataSource = t.DefaultView
                r = Nothing
        End Select
        lbxResidents.DisplayMember = "K_ResidentDisplayMember"
        lbxResidents.ValueMember = "K_ResidentID"
        lbxResidents.SelectedIndex = -1
    End Sub

    Private Sub SetResident(ByVal iResident_ID As Integer)
        CurrentResident = New Elements.Resident(iResident_ID)

        Me.txtID.Text = CurrentResident.ID
        Me.txtFirstName.Text = CurrentResident.FirstName
        Me.txtLastName.Text = CurrentResident.LastName
        Me.txtCPR.Text = CurrentResident.CPR
        Me.txtEmail.Text = CurrentResident.Email
        Me.txtPhone.Text = CurrentResident.Phone
        Me.txtPhone2.Text = CurrentResident.Phone2
        Me.txtDKAddress.Text = CurrentResident.DKAddress
        Me.txtDKPostalCode.Text = CurrentResident.DKPostalCode
        Me.txtDKCity.Text = CurrentResident.DKCity
        Me.txtDKContactAddress.Text = CurrentResident.DKContactAddress
        Me.txtDKContactName.Text = CurrentResident.DKContactName
        Me.txtDKContactPhone.Text = CurrentResident.DKContactPhone
        Me.txtChronicIllness.Text = CurrentResident.ChronicIllnessDescription
        Me.ddlGender.SelectedIndex = CurrentResident.Gender
        Me.cbxNewsLetter.Checked = CurrentResident.NewsLetter
        If CurrentResident.ID = 0 Then
            Me.datArrival.Value = Now
            Me.datDeparture.Value = Now
            Me.datInBedFrom.Value = Now
            Me.datInBedTo.Value = Now
            Me.datHolidayFrom.Value = Now
            Me.datHolidayTo.Value = Now
        Else
            Me.datArrival.Value = CurrentResident.ArrivalDate
            Me.datDeparture.Value = CurrentResident.DepartureDate
        End If

        Me.lblResidentCreatedUser.Text = CurrentResident.CreatedByName & " (" & Format(CurrentResident.CreatedDate, "dd-MM-yyyy") & ")"

        Me.lblResidentLastUpdatedUser.Text = CurrentResident.UpdatedByName & " (" & Format(CurrentResident.UpdatedDate, "dd-MM-yyyy") & ")"

        If CurrentResident.PaidUntil = DefaultDate Then
            Me.lblPayment.Text = "Ikke betalt endnu!"
            Me.datPaidUntill.Value = CDate(Me.datArrival.Value).AddDays(-1)
        Else
            Me.lblPayment.Text = "Betalt t.o.m :"
            Me.datPaidUntill.Value = CurrentResident.PaidUntil
        End If

        Me.txtNumberOfGuests.Text = CurrentResident.Type.NumberOfGuests
        Me.ddlResidentType.SelectedIndex = CurrentResident.Type.Type


        Dim bAttention As Boolean = False
        Me.txtComment.Text = CurrentResident.Comments.Comment

        StartResidentInBed(CurrentResident)
        StartHoliday(CurrentResident.ID)

        If CurrentResident.DepartureDate < Now AndAlso CurrentResident.Comments.SpecialAttention Then
            MessageBox.Show("For denne beboer skal du være særligt opmærksom!" & vbNewLine & CurrentResident.Comments.Comment)
        End If

        Me.txtFirstName.Focus()
        Me.txtFirstName.SelectAll()

        ResidentEnabled(True)
    End Sub

    Private Sub ClearResident()
        SetResident(0)
        Me.txtFirstName.Focus()
    End Sub

    Private Function GetResidentIndex() As Integer
        Dim intIndex As Integer = 0
        If CInt(ddlShowResidents.SelectedIndex) > 0 Then
            intIndex = CInt(ddlShowResidents.SelectedIndex)
        End If
        Return intIndex
    End Function

    Private Function WriteSQL() As String

        Dim SQL As String = "" '+ ' ' + K_ResidentLastName
        SQL = "SELECT R.K_ResidentID, K_ResidentFirstName + ' ' + K_ResidentLastName + ' (' + K_ResidentCPR + ')' AS K_ResidentDisplayMember, K_ResidentArrivalDate, K_ResidentDepartureDate FROM K_Resident R " & _
        ", K_ResidentType RT "
        ' Dim strSelect As String = " AND NOT (SELECT TOP 1 K_ResidentTypeID FROM K_ResidentType WHERE K_ResidentID = K_Resident.K_ResidentID AND K_ResidentTypeFromDate <= #" & Format(Now, Data.Misc.DataBaseDateFormat) & "# ORDER BY K_ResidentTypeFromDate DESC) = 5 "
        Select Case GetResidentIndex()
            Case 4 ' 0 'kommende
                SQL &= "WHERE K_ResidentArrivalDate > #" & Format(Now, Data.Misc.DataBaseDateFormat) & "# AND K_ResidentStatus = 1"
            Case 5 ' 1 'nuværende
                SQL &= "WHERE RT.K_ResidentType <> 5 AND RT.K_ResidentType <> 4 " &
                "AND K_ResidentArrivalDate <= #" & Format(Now, Data.Misc.DataBaseDateFormat) & "# AND K_ResidentDepartureDate > #" & Format(Now, Data.Misc.DataBaseDateFormat) & "# " &
                " AND K_ResidentStatus = 1"
            Case 1 ' 2 'afrejser
                SQL &= "WHERE K_ResidentDepartureDate = #" & Format(Now, Data.Misc.DataBaseDateFormat) & "# AND K_ResidentStatus = 1"
            Case 2 ' 3 'ankomster
                SQL &= "WHERE K_ResidentArrivalDate = #" & Format(Now, Data.Misc.DataBaseDateFormat) & "# AND K_ResidentStatus = 1"
            Case 6 ' 4 'skyldnere
                SQL &= "WHERE (K_ResidentPaidUntil < #" & Format(Now.AddDays(-3), Data.Misc.DataBaseDateFormat) & "# " &
                    "AND (DateDiff(d, [K_ResidentPaidUntil], [K_ResidentDepartureDate]) > 1) " &
                    "OR (RT.K_ResidentType = 3 AND R.[K_ResidentCreatedDate] > #" & Format(New DateTime(2008, 12, 10), Data.Misc.DataBaseDateFormat) & "# AND (DateDiff(d, R.[K_ResidentCreatedDate], GETUTCDATE()) >= 3) AND R.K_ResidentID NOT IN (SELECT K_ResidentID FROM K_Invoice, K_InvoiceLine WHERE K_InvoiceLine.K_InvoiceID = K_Invoice.K_InvoiceID AND K_InvoiceLine.K_InvoicePriceID = 4))) " &
                    "AND K_ResidentStatus = 1 "

                'SQL &= "WHERE (K_ResidentPaidUntil < #" & Format(Now.AddDays(-3), Data.Misc.DataBaseDateFormat) & "# " & _
                '    "AND DateDiff('d', [K_ResidentPaidUntil], [K_ResidentDepartureDate]) > 1) "
            Case 8 ' 5 'tidligere
                SQL &= "WHERE K_ResidentDepartureDate < #" & Format(Now, Data.Misc.DataBaseDateFormat) & "# AND K_ResidentStatus = 1"
            Case 0 ' 6 'alle
                SQL &= "WHERE K_ResidentStatus = 1"
            Case 7 'staff (type 5)
                'SQL &= "WHERE 1=1"
                'strSelect = " AND (SELECT TOP 1 K_ResidentTypeID FROM K_ResidentType WHERE K_ResidentID = K_Resident.K_ResidentID AND K_ResidentTypeFromDate <= #" & Format(Now, Data.Misc.DataBaseDateFormat) & "# ORDER BY K_ResidentTypeFromDate DESC) = 5 "
                'SELECT * FROM K_Resident R, K_ResidentType RT
                'WHERE(RT.K_ResidentID = R.K_ResidentID And K_ResidentType = 5)
                SQL &= "WHERE RT.K_ResidentType = 5 AND K_ResidentStatus = 1"
            Case 3 ' 8 'appartment (type 4)
                SQL &= "WHERE RT.K_ResidentType = 4 AND K_ResidentStatus = 1"
            Case 9 'annullerede
                SQL &= "WHERE K_ResidentStatus = 0"
        End Select
        If Not Me.txtSerachResident.Text = String.Empty Then
            Dim strSearchString As String
            strSearchString = Me.txtSerachResident.Text
            SQL &= " AND(" & _
                    "K_ResidentFirstName LIKE '%" & strSearchString & "%' " & _
                    "OR K_ResidentLastName LIKE '%" & strSearchString & "%' " & _
                    "OR K_ResidentCPR LIKE '%" & strSearchString & "%')"
        End If

        'mStrSQL &= strSelect

        SQL &= "AND RT.K_ResidentID = R.K_ResidentID AND RT.K_ResidentTypeActive = 1 " & _
        " ORDER BY K_ResidentFirstName"

        Return SQL
    End Function

    '## Functions ##
    Private Function SaveResident() As Integer
        Dim intSaveResident As Integer = -1
        If Not CurrentResident Is Nothing Then
            TimerRun(False)

            Dim booSave As Boolean = True
            Dim booValidDates As Boolean = True
            Dim bUpdateList As Boolean = False

            If CurrentResident.Status = 0 Then
                CurrentResident.Status = 1
                bUpdateList = True
            End If

            CurrentResident.FirstName = Me.txtFirstName.Text
            CurrentResident.LastName = Me.txtLastName.Text
            CurrentResident.CPR = Me.txtCPR.Text
            CurrentResident.Email = Me.txtEmail.Text
            CurrentResident.Phone = Me.txtPhone.Text
            CurrentResident.Phone2 = Me.txtPhone2.Text
            CurrentResident.DKAddress = Me.txtDKAddress.Text
            CurrentResident.DKCity = Me.txtDKCity.Text
            CurrentResident.DKPostalCode = Me.txtDKPostalCode.Text
            CurrentResident.DKContactAddress = Me.txtDKContactAddress.Text
            CurrentResident.DKContactName = Me.txtDKContactName.Text
            CurrentResident.DKContactPhone = Me.txtDKContactPhone.Text
            CurrentResident.ChronicIllnessDescription = Me.txtChronicIllness.Text
            If Not CurrentResident.ChronicIllnessDescription = "" Then
                CurrentResident.ChronicIllness = True
            Else
                CurrentResident.ChronicIllness = False
            End If

            CurrentResident.NewsLetter = Me.cbxNewsLetter.Checked
            CurrentResident.CreatedBy = LoggedInUser_ID
            CurrentResident.UpdatedBy = LoggedInUser_ID
            CurrentResident.UpdatedDate = Now
            CurrentResident.CreatedDate = Now
            CurrentResident.PaidUntil = Me.datPaidUntill.Value

            Dim rib As New Elements.ResidentInBed

            'asume resident moves in again - delete old connection to bed
            If CurrentResident.ArrivalDate <> datArrival.Value AndAlso datArrival.Value > Now Then
                rib.DeleteForResident(CurrentResident.ID)
                ListResidentInBed(CurrentResident.ID)
            End If

            If CurrentResident.ArrivalDate <> datArrival.Value AndAlso CurrentResident.ID > 0 Then
                CurrentResident.PaidUntil = datArrival.Value.AddDays(-1)
                datPaidUntill.Value = CurrentResident.PaidUntil
                'arrival date has changed 
                If CurrentResident.ArrivalDate < datArrival.Value Then
                    'only if arrive later - find and change date on bed
                    rib.UpdateArrival(CurrentResident.ID, CurrentResident.ArrivalDate, datArrival.Value)
                    ListResidentInBed(CurrentResident.ID)
                End If
            End If

            If CurrentResident.DepartureDate <> datDeparture.Value AndAlso CurrentResident.ID > 0 Then
                'departure date has changed 
                'If CurrentResident.DepartureDate > datDeparture.Value Then
                'only if leaving sooner- find and change date on bed
                rib.UpdateDeparture(CurrentResident.ID, CurrentResident.DepartureDate, datDeparture.Value)
                ListResidentInBed(CurrentResident.ID)
                'End If
            End If

            CurrentResident.ArrivalDate = Me.datArrival.Value
            CurrentResident.DepartureDate = Me.datDeparture.Value
            CurrentResident.Gender = Me.ddlGender.SelectedIndex

            If CurrentResident.DepartureDate = DefaultDate OrElse CurrentResident.ArrivalDate = DefaultDate Then
                booValidDates = False
                'don't do the other checkes - this is not complete data
            End If

            If booValidDates Then
                If DateDiff(DateInterval.Day, CDate(datArrival.Value), CDate(datDeparture.Value)) < 0 Then
                    booSave = False
                    MessageBox.Show("Ankomstdatoen skal ligge før afrejse datoen")
                End If
            End If

            If Me.ddlResidentType.SelectedIndex < 1 Then
                booSave = False
                MessageBox.Show("Du skal vælge hvilken type beboer der er tale om før du kan gemme beboeren.")
                Me.ddlResidentType.Focus()
            End If

            If Me.txtFirstName.Text = String.Empty Then
                booSave = False
                MessageBox.Show("Du skal indtaste et fornavn på beboeren for at kunne gemme.")
                Me.txtFirstName.Focus()
            End If

            If booSave Then
                intSaveResident = CurrentResident.SaveResidentSQL()
                If intSaveResident > 0 Then
                    If CurrentResident.ID <= 1 Then
                        CurrentResident.GetResidentID()
                    End If

                    If Not CurrentResident.Type.Type = Me.ddlResidentType.SelectedIndex Then
                        Dim objType As New Elements.ResidentType
                        objType.UpdatedBy = LoggedInUser_ID
                        objType.CreatedBy = LoggedInUser_ID
                        objType.CreatedDate = Now
                        objType.UpdatedDate = Now
                        objType.Type = Me.ddlResidentType.SelectedIndex
                        If Me.txtID.Text = String.Empty OrElse Me.txtID.Text = 0 Then
                            'this is the first type, and we need not handle it
                            objType.Status = -1
                        Else
                            'you are trying to change type for this resident
                            'if you are staff, appartement or guest (and have already paid)
                            'you cannot change and must be warned 
                        End If
                        objType.TypeFrom = Now
                        If Me.txtNumberOfGuests.Visible = True Then
                            If IsNumeric(Me.txtNumberOfGuests.Text) AndAlso txtNumberOfGuests.Text > 0 Then
                                objType.NumberOfGuests = Me.txtNumberOfGuests.Text
                            Else
                                booSave = False
                                MessageBox.Show("Antal skal angives med et heltal, fx 2.")
                            End If
                        End If
                        objType.ResidentID = CurrentResident.ID
                        objType.Active = 1
                        objType.SaveResidentTypeSQL()
                        CurrentResident.Type.Type = ddlResidentType.SelectedIndex
                    ElseIf CurrentResident.Type.Type = K.Booking.Data.GlobalEnums.ResidentType.Guest Then
                        If Not CurrentResident.Type.NumberOfGuests = txtNumberOfGuests.Text Then
                            If IsNumeric(Me.txtNumberOfGuests.Text) AndAlso txtNumberOfGuests.Text > 0 Then
                                CurrentResident.Type.NumberOfGuests = Me.txtNumberOfGuests.Text
                                CurrentResident.Type.SaveResidentTypeSQL()
                            Else
                                booSave = False
                                MessageBox.Show("Antal skal angives med et heltal, fx 2.")
                            End If
                        End If
                    End If
                    If CurrentResident.Type.Type = Data.GlobalEnums.ResidentType.LongTerm Then
                        If CurrentResident.ArrivalDate.AddDays(4 * 7) > CurrentResident.DepartureDate Then
                            'arrival + 4 weeks
                            'resident is leaving before 4 weeks
                            Dim strGender As String = "den"
                            Select Case CurrentResident.Gender
                                Case Data.GlobalEnums.Gender.Female
                                    strGender = "hun"
                                Case Else
                                    strGender = "han"
                            End Select
                            'mObjResident.Type.Type = Data.GlobalEnums.ResidentType.ShortTerm
                            Me.ddlResidentType.SelectedIndex = Data.GlobalEnums.ResidentType.ShortTerm
                            MessageBox.Show(CurrentResident.DisplayMember & " skifter status til korttidsbeboer, da " & strGender & " afrejser inden 4 uger.")
                        End If
                    End If
                    If CurrentResident.ArrivalDate.AddMonths(6) < CurrentResident.DepartureDate AndAlso ddlResidentType.SelectedIndex < Data.GlobalEnums.ResidentType.Appartement Then
                        If CurrentResident.ID = 0 Then
                            'arrival + 6 months 
                            'resident planned for more than the allowed 6 month - warn user
                            If MessageBox.Show("Må beboeren booke i længere tid end 6 måneder?", "Beboerbooking", MessageBoxButtons.YesNo) = DialogResult.No Then
                                'do NOT save resident, user aborted
                                booSave = False
                                'Me.txtArrivalDay.Focus()
                                'Me.txtArrivalDay.SelectAll()
                                Me.datArrival.Focus()
                            End If
                        End If
                    End If

                    'If Not mObjResident.Comments.SpecialAttention = Me.cbxSpecialAttention.Checked Or Not Me.txtNewComment.Text = String.Empty Then
                    CurrentResident.Comments.UpdatedBy = LoggedInUser_ID
                    CurrentResident.Comments.CreatedBy = LoggedInUser_ID
                    CurrentResident.Comments.CreatedDate = Now
                    CurrentResident.Comments.UpdatedDate = Now
                    'objComment.SpecialAttention = Me.cbxSpecialAttention.Checked
                    CurrentResident.Comments.Comment = Me.txtComment.Text
                    CurrentResident.Comments.ResidentID = CurrentResident.ID
                    CurrentResident.Comments.SaveResidentCommentSQL()
                    'End If

                    If Not CurrentResident.ArrivalDate = Me.datHolidayFrom.Value AndAlso Not Me.datHolidayFrom.Value = Data.Misc.DefaultDate Then
                        SaveHoliday()
                    End If

                    If Not Me.txtRoomAndBed.Text = String.Empty Then
                        SaveResidentInBed(CurrentResident.ID)
                    End If

                    'ListResidents()
                    'If MessageBox.Show(mObjResident.DisplayMember & " er blevet gemt", "Beboeroplysninger", MessageBoxButtons.OK) = DialogResult.OK Then
                    '    ResidentEnabled(False)
                    'End If

                    If bUpdateList Then
                        ListResidents()
                    End If

                    'SetResident(CurrentResident.ID)
                    Me.txtFirstName.Focus()
                Else
                    MessageBox.Show(CurrentResident.DisplayMember & " kunne ikke gemmes. Systemet kan ikke finde årsagen. Check dine indtastninger og prøv igen.")
                End If
            End If
        End If

        Return intSaveResident
    End Function

    '## Events ##
    '??
    Private Sub ddlShowResidents_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlShowResidents.SelectionChangeCommitted
        SaveResident()
        ListResidents()
    End Sub

    Private Sub btnSearchResident_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchResident.Click
        WriteSQL()
        ListResidents()
    End Sub

    Private Sub btnNewResident_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewResident.Click
        ClearResident()
        ResidentEnabled(True)
    End Sub

    Private Sub lbxResidents_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbxResidents.Click
        If lbxResidents.SelectedValue > 0 Then
            SaveResident()
            SetResident(CType(Me.lbxResidents.SelectedValue, Integer))
            Me.txtFirstName.Focus()
        End If
    End Sub

    Private Sub btnSaveResident_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveResident.Click
        'ResidentEnabled(False)
        TimerRun(False)
        SaveResident()
    End Sub

    Private Sub ddlResidentType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlResidentType.SelectedIndexChanged
        If Me.ddlResidentType.SelectedIndex = 3 Then
            'this is a guest - ask for number of people staying in this guest's name
            Me.txtNumberOfGuests.Visible = True
            Me.lblNumberOfGuests.Visible = True
            If Me.txtNumberOfGuests.Text = "" Then
                Me.txtNumberOfGuests.Text = 1
            End If
            Me.txtNumberOfGuests.Focus()
            Me.txtNumberOfGuests.SelectAll()
        Else
            Me.txtNumberOfGuests.Visible = False
            Me.lblNumberOfGuests.Visible = False
        End If
    End Sub

#End Region

#Region " Rooms and Beds "
    Dim iEditRoomID As Integer = 0
    Dim iEditBedID As Integer = 0

    '## Sub rutines ##
    Private Sub StartRooms()
        Dim ro As New Elements.Room
        Me.lbxRooms.DataSource = ro.ListInArray()
        Me.lbxRooms.DisplayMember = "Description"

        RoomEnabled(False)
        BedEnabled(False)
    End Sub

    Private Sub ShowRoom()
        Me.lblBedsInRoom.Text = "Senge på værelse " & CType(Me.lbxRooms.SelectedItem, Elements.Room).Description
        SetRoom(CType(Me.lbxRooms.SelectedItem, Elements.Room))
        ListBeds()
    End Sub

    Private Sub ListBeds()
        Dim b As New Elements.Bed
        Me.lbxBeds.DataSource = b.ListInArray("SELECT * FROM K_Bed WHERE K_RoomID = " & CType(Me.lbxRooms.SelectedItem, Elements.Room).ID)
        Me.lbxBeds.DisplayMember = "Description"
    End Sub

    Private Sub SaveBed(ByVal intRoomID As Integer, ByVal strKey As String, ByVal strDescription As String, ByVal booIsPermanent As Boolean)
        'validate ##
        Dim b As New Elements.Bed
        b.ID = iEditBedID
        b.Description = strDescription
        b.Key = strKey
        b.RoomID = intRoomID
        b.IsPermanent = booIsPermanent
        b.Save()

        ListBeds()

        Me.txtBedKey.Text = ""
        Me.txtBedDescription.Text = ""
        Me.txtBedKey.Focus()
    End Sub

    Private Sub SetRoom(ByVal objRoom As Elements.Room)
        iEditRoomID = objRoom.ID
        txtRoomKey.Text = objRoom.Key
        txtRoomDescription.Text = objRoom.Description
        ddlType.SelectedIndex = objRoom.Type
        ddlStatus.SelectedIndex = objRoom.Status

        RoomEnabled(True)
    End Sub

    Private Sub RoomEnabled(ByVal bEnabled As Boolean)
        txtRoomKey.Enabled = bEnabled
        txtRoomDescription.Enabled = bEnabled
        ddlType.Enabled = bEnabled
        ddlStatus.Enabled = bEnabled
    End Sub

    Private Sub SetBed(ByVal objBed As Elements.Bed)
        iEditBedID = objBed.ID
        txtBedKey.Text = objBed.Key
        txtBedDescription.Text = objBed.Description
        chkIsPermanent.Checked = Not objBed.IsPermanent

        BedEnabled(True)
    End Sub

    Private Sub BedEnabled(ByVal bEnabled As Boolean)
        txtBedKey.Enabled = bEnabled
        txtBedDescription.Enabled = bEnabled
    End Sub

    '## Events ##
    Private Sub btnEditRoom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditRoom.Click
        SetRoom(New Elements.Room)
    End Sub

    Private Sub btnEditBed_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditBed.Click
        SetBed(New Elements.Bed)
    End Sub

    Private Sub ddlType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlType.SelectedIndexChanged
        If ddlType.SelectedIndex = 0 Then
            ddlStatus.Enabled = True
        Else
            ddlStatus.Enabled = False
        End If
    End Sub
    Private Sub btnSaveRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveRoom.Click
        Dim bSave As Boolean = True
        If ddlType.SelectedIndex = 0 AndAlso ddlStatus.SelectedIndex < 0 Then
            bSave = False
            MessageBox.Show("Hvis du opretter et værelse skal du huske at angive hvilken status værelset har.", "Værelser", MessageBoxButtons.OK)
        End If
        If Me.txtRoomKey.Text = String.Empty Then
            bSave = False
            MessageBox.Show("Du skal angive en ""kode"" for dette værelse, som du skal indtaste når du vil tildele værelset til en beboer.", "Værelser", MessageBoxButtons.OK)
        End If
        If Me.ddlType.SelectedIndex < 0 Then
            bSave = False
            MessageBox.Show("Du skal vælge om der er tale om et værelse eller et kollegie", "Værelser og senge", MessageBoxButtons.OK)
        End If
        Dim ro As New Elements.Room
        ro.Description = Me.txtRoomDescription.Text
        If bSave Then
            ro.ID = iEditRoomID
            ro.Key = Me.txtRoomKey.Text
            ro.Type = Me.ddlType.SelectedIndex
            ro.Status = Me.ddlStatus.SelectedIndex

            ro.Save()

            If ddlType.SelectedIndex = 1 Then
                If iEditRoomID = 0 Then
                    SaveBed(ro.GetRoomID(ro.Key), ro.Key, "Default bed in appartement", True)
                End If
            End If

            StartRooms()
        End If

        Me.txtRoomDescription.Focus()
        Me.txtRoomDescription.SelectAll()
    End Sub

    Private Sub txtRoomDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoomKey.Click
        Me.txtRoomDescription.SelectAll()
    End Sub

    Private Sub lbxRooms_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbxRooms.Click
        ShowRoom()
    End Sub

    Private Sub lbxBeds_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbxBeds.SelectedIndexChanged
        SetBed(CType(lbxBeds.SelectedItem, Elements.Bed))
    End Sub

    Private Sub lbxRooms_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lbxRooms.KeyDown
        If e.KeyValue = 13 Then 'enter 
            ShowRoom()
        End If
    End Sub

    Private Sub btnSaveBed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveBed.Click
        SaveBed(CType(Me.lbxRooms.SelectedItem, Elements.Room).ID, Me.txtBedKey.Text, Me.txtBedDescription.Text, Not chkIsPermanent.Checked)
        SetBed(New Elements.Bed)
    End Sub
#End Region

#Region " Resident in bed "
    '## Sub rutines ##
    Private Sub StartResidentInBed(ByVal oResident As Elements.Resident)
        Dim rib As New Elements.ResidentInBed
        
        SetResidentInBed(rib, oResident)
        ListResidentInBed(oResident.ID)

        lblCurrentRoomAndBed.Text = rib.GetCurrentBed(oResident.ID)
    End Sub

    Private Sub ListResidentInBed(ByVal intResidentID As Integer)
        Dim rib As New Elements.ResidentInBed
        Me.lbxResidentInBed.DataSource = rib.ListInArray(intResidentID)
        Me.lbxResidentInBed.DisplayMember = "DisplayMember"
    End Sub

    Private Sub SetResidentInBed(ByVal objResidentInBed As Elements.ResidentInBed, ByVal objResident As Elements.Resident)
        Me.txtRoomAndBed.Text = objResidentInBed.RoomDescription & objResidentInBed.BedDescription

        If objResident.ID > 0 Then
            Me.datInBedFrom.Value = objResident.ArrivalDate
            Me.datInBedTo.Value = objResident.DepartureDate
        End If

        'If Not objResidentInBed.FromDate = DefaultDate Then
        '    Me.txtFromDay.Text = Format(objResidentInBed.FromDate, "dd")
        '    Me.txtFromMonth.Text = Format(objResidentInBed.FromDate, "MM")
        '    Me.txtFromYear.Text = Format(objResidentInBed.FromDate, "yyyy")
        'Else
        '    Me.txtFromDay.Text = ""
        '    Me.txtFromMonth.Text = ""
        '    Me.txtFromYear.Text = ""
        'End If
        'If Not objResidentInBed.ToDate = DefaultDate Then
        '    Me.txtToDay.Text = Format(objResidentInBed.ToDate, "dd")
        '    Me.txtToMonth.Text = Format(objResidentInBed.ToDate, "MM")
        '    Me.txtToYear.Text = Format(objResidentInBed.ToDate, "yyyy")
        'Else
        '    Me.txtToDay.Text = ""
        '    Me.txtToMonth.Text = ""
        '    Me.txtToYear.Text = ""
        'End If
    End Sub

    Private Sub SaveResidentInBed(ByVal intResidentID As Integer)
        Dim booSave As Boolean = True
        Dim rib As Elements.ResidentInBed
        'If lbxResidentInBed.SelectedIndex > -1 Then
        '    rib = CType(Me.lbxResidentInBed.SelectedItem, Elements.ResidentInBed)
        'Else
        rib = New Elements.ResidentInBed
        'End If
        Dim b As New Elements.Bed
        Dim r As New Elements.Resident

        r.Fetch(intResidentID)

        rib.ResidentID = intResidentID
        If Not Me.txtRoomAndBed.Text = String.Empty Then
            'validate room and bed
            If Me.txtRoomAndBed.Text.Length <> 3 Then
                booSave = False
                MessageBox.Show("Du skal indtaste værelses navn på to bogstaver (fx 07) og et sengebogstav (fx a) for at systemet kan forstå det")
            Else
                If IsNumeric(Me.txtRoomAndBed.Text) Then
                    'appartement
                    Dim intBedID As Integer
                    intBedID = b.GetBedID(Me.txtRoomAndBed.Text, Me.txtRoomAndBed.Text)
                    If intBedID = 0 Then
                        'does not exist
                        booSave = False
                        MessageBox.Show("Det indtastede kollegie findes ikke i systemet.")
                    Else
                        rib.BedID = intBedID
                    End If
                Else
                    'room and bed
                    Dim intBedID As Integer
                    intBedID = b.GetBedID(Me.txtRoomAndBed.Text.Substring(0, 2), Me.txtRoomAndBed.Text.Substring(2))
                    If intBedID = 0 Then
                        'does not exist
                        booSave = False
                        MessageBox.Show("Den indtastede værelse/senge-kombination findes ikke i systemet.")
                    Else
                        rib.BedID = intBedID
                    End If
                End If
            End If
        Else
            booSave = False
            MessageBox.Show("Du skal vælge en seng til " & r.DisplayMember)
        End If
        'If Not CheckDate(Me.txtToDay, Me.txtToMonth, Me.txtToYear, "Tildatoen") = Nothing Then
        '    mObjResidentInBed.ToDate = CheckDate(Me.txtToDay, Me.txtToMonth, Me.txtToYear, "Tildatoen")
        'Else
        '    booSave = False
        'End If
        'If Not CheckDate(Me.txtFromDay, Me.txtFromMonth, Me.txtFromYear, "Fradatoen") = Nothing Then
        '    mObjResidentInBed.FromDate = CheckDate(Me.txtFromDay, Me.txtFromMonth, Me.txtFromYear, "Fradatoen")
        'Else
        '    booSave = False
        'End If

        rib.FromDate = Me.datInBedFrom.Value
        rib.ToDate = Me.datInBedTo.Value

        If booSave Then
            If r.ArrivalDate = DefaultDate Then
                If rib.FromDate <> DefaultDate Then
                    'no arrival date, set arrivaldate to fromdate
                    r.ArrivalDate = rib.FromDate
                    r.SaveResidentSQL()
                Else
                    MessageBox.Show("Du bliver nødt til at angive en ankomstdato eller en fra-dato for beboeren", "Sengetildeling")
                    booSave = False
                End If
            End If
        End If
        If booSave Then
            If r.DepartureDate = DefaultDate Then
                If rib.ToDate <> DefaultDate Then
                    'no departire date, set departuredate to todate
                    r.DepartureDate = rib.ToDate
                    r.SaveResidentSQL()
                Else
                    MessageBox.Show("Du bliver nødt til at angive en afrejsedato eller til-dato for beboeren før du kan tildele en seng.", "Sengetildeling")
                    booSave = False
                End If
            End If
        End If
        If booSave Then
            If DateDiff(DateInterval.DayOfYear, r.ArrivalDate, rib.FromDate) < 0 Then
                'user cannot sleep in bed before arriving
                If MessageBox.Show(r.DisplayMember & " kan ikke tildeles en seng før ankomstdatoen. Ønsker du at rette ankomstdatoen til " & rib.FromDate.ToShortDateString & "?", "Sengetildeling", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    'change arrivaldate
                    r.ArrivalDate = rib.FromDate
                    r.SaveResidentSQL()
                Else
                    booSave = False
                End If
            End If
        End If
        If booSave Then
            If DateDiff(DateInterval.DayOfYear, r.DepartureDate, rib.ToDate) > 0 Then
                'user cannot sleep in bed after leaving
                If MessageBox.Show(r.DisplayMember & " kan ikke tildeles en seng til efter afrejsedatoen. Ønsker du at rette afrejsedatoen til " & rib.ToDate & "?", "Sengetildeling", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    r.DepartureDate = rib.ToDate
                    r.SaveResidentSQL()
                Else
                    booSave = False
                End If
            End If
        End If
        If booSave Then
            If DateDiff(DateInterval.DayOfYear, rib.FromDate, rib.ToDate) < 0 Then
                MessageBox.Show("Fradatoen skal ligge før tildatoen.")
                booSave = False
            End If
        End If
        If booSave Then
            If rib.FromDate = DefaultDate AndAlso rib.ToDate = DefaultDate Then
                'nothing was entered - if resident has arrival AND departuredate, set as such
                If r.ArrivalDate <> DefaultDate AndAlso r.DepartureDate <> DefaultDate Then
                    rib.FromDate = r.ArrivalDate
                    rib.ToDate = r.DepartureDate
                Else
                    MessageBox.Show("Du bliver nødt til at angive en ankomst- og afrejsedato for beboeren før du kan tildele en seng.", "Sengetildeling")
                    booSave = False
                End If
            End If
        End If
        If booSave Then
            For Each objResidentInBed As Elements.ResidentInBed In Me.lbxResidentInBed.Items
                If Not objResidentInBed.ID = rib.ID Then
                    If booSave Then
                        If DateDiff(DateInterval.DayOfYear, objResidentInBed.FromDate, rib.FromDate) >= 0 AndAlso DateDiff(DateInterval.DayOfYear, objResidentInBed.ToDate, rib.FromDate) < 0 Then
                            'user cannot start sleeping in new bed while still in another
                            If MessageBox.Show(r.DisplayMember & " kan ikke tildeles en seng mens der er tildelt en anden. Ønsker du at rette fradatoen til " & objResidentInBed.ToDate & "?", "Sengetildeling", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                rib.FromDate = objResidentInBed.ToDate
                            Else
                                booSave = False
                            End If
                        End If
                    End If
                    If booSave Then
                        If DateDiff(DateInterval.DayOfYear, objResidentInBed.FromDate, rib.ToDate) > 0 AndAlso DateDiff(DateInterval.DayOfYear, objResidentInBed.ToDate, rib.ToDate) <= 0 Then
                            'user cannot stay in old bed while beeing asigned to new
                            If MessageBox.Show(r.DisplayMember & " er allerede tildelt en seng fra " & objResidentInBed.FromDate & ". Ønsker du at rette tildatoen til " & objResidentInBed.FromDate & "?", "Sengetildeling", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                rib.ToDate = objResidentInBed.FromDate
                            Else
                                booSave = False
                            End If
                        End If
                    End If
                End If
            Next
        End If

        If booSave Then
            'check if bed is occupied by others
            Dim objDataset As DataSet
            objDataset = rib.CheckOccupied()
            If objDataset.Tables(0).Rows.Count > 0 Then
                'bed is occupied
                Dim oRes As New Elements.Resident
                Dim strMsg As String = "Sengen er optaget:" & vbNewLine
                Dim oResInBed As New Elements.ResidentInBed
                For Each objRow As DataRow In objDataset.Tables(0).Rows
                    'if not oRes is on holiday in the selected period
                    oResInBed.FetchFromRow(objRow)
                    oRes.FetchFromRow(objRow)
                    'check if this resident is on holiday in this period
                    Dim oDS As DataSet
                    oDS = oRes.CheckHoliday(rib.FromDate, rib.ToDate)
                    For Each oRow As DataRow In oDS.Tables(0).Rows
                        'the period the new resident wants to sleep in the bed extends past the holiday
                        If Data.Misc.ConvertToDateTime(oRow("K_HolidayFromDate")) > rib.FromDate OrElse Data.Misc.ConvertToDateTime(oRow("K_HolidayToDate")) < rib.ToDate Then
                            booSave = False
                            strMsg &= oRes.DisplayMember & ": " & oResInBed.DisplayMember & vbNewLine
                        End If
                    Next
                    'end
                Next
                If Not booSave Then
                    MessageBox.Show(strMsg)
                End If
            End If
        End If
        If booSave Then
            If rib.Save() > 0 Then
                ListResidentInBed(rib.ResidentID)
                SetResident(rib.ResidentID)
                MessageBox.Show(r.DisplayMember & " er tildelt en seng")
                Me.txtFirstName.Focus()
            End If
        End If
    End Sub

    '## Events ##
    'Private Sub btnSaveResidentInBed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    SaveResidentInBed()
    'End Sub

    Private Sub btnDeleteResidentInBed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteResidentInBed.Click
        If Me.lbxResidentInBed.SelectedIndex > -1 Then
            If MessageBox.Show("Ønsker du at slette den markerede sengetildeling?", "Sletning af sengetildelig", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                'delete
                Dim rib As New Elements.ResidentInBed
                Dim r As New Elements.Resident
                Dim intNoOfRows As Integer
                intNoOfRows = rib.Delete(CType(Me.lbxResidentInBed.SelectedItem, Elements.ResidentInBed).ID)
                If intNoOfRows > 0 Then
                    rib.Reset()
                    SetResidentInBed(rib, r)
                    'MessageBox.Show("Der blev slettet " & intNoOfRows & " sengetildelinger.")
                    ListResidentInBed(r.ID)
                Else
                    MessageBox.Show("Den markerede sengetildeling kunne ikke slettes. Systemet kan ikke finde fejlen.")
                End If
            End If
        Else
            MessageBox.Show("Du skal markere den sengetildeling du ønsker at slette inden du trykker på [Slet]")
        End If
    End Sub

    Private Sub btnEditResidentInBed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditResidentInBed.Click
        If Me.lbxResidentInBed.SelectedIndex > -1 Then
            'SetResidentInBed(mObjResidentInBed)
            'SetResidentInBed(CType(Me.lbxResidentInBed.SelectedItem, Elements.ResidentInBed))
            Dim rib As Elements.ResidentInBed = CType(Me.lbxResidentInBed.SelectedItem, Elements.ResidentInBed)

            Me.txtRoomAndBed.Text = rib.RoomDescription & rib.BedDescription

            Me.datInBedFrom.Value = rib.FromDate
            Me.datInBedTo.Value = rib.ToDate

            'ListResidentInBed(mObjResident.ID)
        Else
            MessageBox.Show("Du skal markere den sengetildeling du ønsker at redigere inden du trykker på [Redigér]")
        End If
    End Sub
#End Region

#Region " Helpers "
    Private Sub K_Booking_Main_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.ControlKey OrElse e.KeyCode = Keys.Menu Then
            e.Handled = True
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.PageUp Then
            If Me.lbxResidents.SelectedIndex > 0 Then
                Dim i As Integer = Me.lbxResidents.SelectedIndex
                Me.lbxResidents.SetSelected(i - 1, True)
                'Me.lbxResidents.SelectedIndex -= 1
            End If
        ElseIf e.KeyCode = Keys.PageDown Then
            If Me.lbxResidents.Items.Count > Me.lbxResidents.SelectedIndex + 1 Then
                Dim i As Integer = Me.lbxResidents.SelectedIndex
                Me.lbxResidents.SetSelected(i + 1, True)
                'Me.lbxResidents.SelectedIndex += 1
            End If
        Else
            If e.Modifiers = Keys.Control Then
                'ctrl is held down
                Select Case e.KeyCode
                    Case Keys.S 'save
                        SaveVisible()
                    Case Keys.N 'new
                        ClearResident()
                        ResidentEnabled(True)
                    Case Keys.R 'rent
                        Pay()
                End Select
            ElseIf e.Modifiers = Keys.Alt Then
                If e.KeyCode = Keys.F4 Then
                    Me.Dispose()
                End If
            End If
        End If
    End Sub

    Private Sub SaveVisible()
        If Me.tabResidents.Visible Then
            'save resident
            SaveResident()
        ElseIf Me.tabUsers.Visible Then
            'save user
            SaveUser()
        ElseIf Me.tabRoomsAndBeds.Visible Then
            If Me.gbxRooms.Focus Then
                'save room
            ElseIf Me.gbxBeds.Focus Then
                'save bed
            End If
        End If
    End Sub

    'Private Function CheckDate(ByVal oDay As TextBox, ByVal oMonth As TextBox, ByVal oYear As TextBox, ByVal oName As String) As DateTime
    '    If Not oDay.Text = "" Or Not oMonth.Text = "" Or Not oYear.Text = "" Then
    '        'user tried to enter  date
    '        If oDay.Text.Length < 2 Or oMonth.Text.Length < 2 Or (oYear.Text.Length <> 2 And oYear.Text.Length <> 4) Then
    '            MessageBox.Show(oName & " er ikke korrekt udfyldt. Systemet forstår kun formen dd-mm-åå.")
    '            Return Nothing
    '        Else
    '            Try
    '                'Dim iYear As Integer
    '                ''complete year
    '                'If oYear.Text.Length = 2 Then
    '                '    If CInt(oYear.Text) > 90 Then
    '                '        'guessing we are in the 1900's
    '                '        iYear = 19 & CInt(oYear.Text)
    '                '    Else
    '                '        iYear = 20 & CInt(oYear.Text)
    '                '    End If
    '                'Else
    '                '    iYear = CInt(oYear.Text)
    '                'End If
    '                Dim check As New DateTime(oYear.Text, oMonth.Text, oDay.Text)
    '                Return check
    '            Catch ex As Exception
    '                MessageBox.Show(oName & " er ikke gyldig. Systemet forstår kun datoer på formen dd-mm-åå. Tjek om du har valgt en dato, som ikke findes - fx 31-04-XX")
    '                Return Nothing
    '            End Try
    '        End If
    '    Else
    '        Return DefaultDate
    '    End If
    'End Function
#End Region

#Region " Holiday "
    '##SUB ROUTINES##
    Private mIntEditHolidayID As Integer
    Private Sub StartHoliday(ByVal intResidentID As Integer)
        SetHoliday(New Elements.Holiday)
        ListHolidays(intResidentID)
    End Sub
    Private Sub SetHoliday(ByVal objHoliday As Elements.Holiday)
        'If Not objHoliday.FromDate = DefaultDate Then
        '    Me.txtHolidayFromDay.Text = Format(objHoliday.FromDate, "dd")
        '    Me.txtHolidayFromMonth.Text = Format(objHoliday.FromDate, "MM")
        '    Me.txtHolidayFromYear.Text = Format(objHoliday.FromDate, "yyyy")
        'Else
        '    Me.txtHolidayFromDay.Text = ""
        '    Me.txtHolidayFromMonth.Text = ""
        '    Me.txtHolidayFromYear.Text = ""
        'End If
        'If Not objHoliday.ToDate = DefaultDate Then
        '    Me.txtHolidayToDay.Text = Format(objHoliday.ToDate, "dd")
        '    Me.txtHolidayToMonth.Text = Format(objHoliday.ToDate, "MM")
        '    Me.txtHolidayToYear.Text = Format(objHoliday.ToDate, "yyyy")
        'Else
        '    Me.txtHolidayToDay.Text = ""
        '    Me.txtHolidayToMonth.Text = ""
        '    Me.txtHolidayToYear.Text = ""
        'End If

        mIntEditHolidayID = objHoliday.ID

        'If mObjResident.ID > 0 Then
        Me.datHolidayFrom.Value = objHoliday.FromDate
        Me.datHolidayTo.Value = objHoliday.ToDate
        'End If

    End Sub

    Private Sub ListHolidays(ByVal intResidentID As Integer)
        Dim objHoliday As New Elements.Holiday
        Me.lbxHolidays.DataSource = objHoliday.ListInArray("SELECT * FROM K_Holiday WHERE K_ResidentID = " & intResidentID & " ORDER BY K_HolidayFromDate")
        Me.lbxHolidays.DisplayMember = "DisplayMember"
    End Sub

    Private Sub SaveHoliday()
        Dim objHoliday As New Elements.Holiday
        Dim booSave As Boolean = True
        If Me.datHolidayFrom.Value = Me.datHolidayTo.Value Then
            booSave = False
        End If
        If booSave Then
            objHoliday.ID = mIntEditHolidayID
            objHoliday.FromDate = Me.datHolidayFrom.Value
            objHoliday.ToDate = Me.datHolidayTo.Value
        End If
        If booSave Then

            If CurrentResident.ArrivalDate.AddMonths(3) > objHoliday.FromDate Then
                If MessageBox.Show("Må beboeren holde ""gratis"" ferie før der er gået tre måneder?", "Ferie", MessageBoxButtons.YesNo) = DialogResult.No Then
                    booSave = False
                End If
            End If
            If objHoliday.FromDate > objHoliday.ToDate Then
                MessageBox.Show("Til-datoen skal være større end fra-datoen")
                booSave = False
            End If
            If objHoliday.FromDate.AddDays(5) > objHoliday.ToDate Then
                If MessageBox.Show("Må beboeren holde ""gratis"" ferie på mindre end fem dage?", "Ferie", MessageBoxButtons.YesNo) = DialogResult.No Then
                    booSave = False
                End If
            End If
            If objHoliday.FromDate.AddDays(14) < objHoliday.ToDate Then
                If MessageBox.Show("Må beboeren holde ""gratis"" ferie i mere end 14 dage?", "Ferie", MessageBoxButtons.YesNo) = DialogResult.No Then
                    booSave = False
                End If
            End If
        End If
        If booSave Then
            objHoliday.ResidentID = CurrentResident.ID
            If objHoliday.Save() > 0 Then
                ListHolidays(CurrentResident.ID)
                objHoliday.Reset()
                SetHoliday(objHoliday)
                MessageBox.Show("Ferieperioden er oprettet", "Ferie")
            Else
                MessageBox.Show("Ferieperioden kunne ikke oprettes. Systemet kan ikke finde fejlen. Kontakt udvikler!")
            End If
        End If
    End Sub

    Private Sub btnHolidaySave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SaveHoliday()
    End Sub

    Private Sub btnHolidayEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHolidayEdit.Click
        If lbxHolidays.SelectedIndex > -1 Then
            SetHoliday(DirectCast(lbxHolidays.SelectedItem, Elements.Holiday))
        Else
            MessageBox.Show("Du skal vælge den ferieperiode du ønsker at redigere i listen.", "Ferie")
        End If
    End Sub

    Private Sub btnHolidayDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHolidayDelete.Click
        If lbxHolidays.SelectedIndex > -1 Then
            If MessageBox.Show("Er du sikker på du vil slette denne ferieperiode?", "Ferie", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If DirectCast(lbxHolidays.SelectedItem, Elements.Holiday).Delete() > 0 Then
                    MessageBox.Show("Ferieperioden er slettet fra systemet.")
                    ListHolidays(CurrentResident.ID)
                Else
                    MessageBox.Show("Ferieperioden kunne ikke slettes fra systemet. Prøv igen senere.", "Ferie")
                End If
            End If
        Else
            MessageBox.Show("Du skal vælge den ferieperiode du ønsker at slette fra listen", "Ferie")
        End If
    End Sub
#End Region

#Region " Payment "
    '## Sub rutines ##
    Private Sub Pay()
        Dim bPay As Boolean = True
        If CurrentResident Is Nothing Then
            bPay = False
            MessageBox.Show("Du skal først vælge en beboer i listen")
            Exit Sub
        End If
        If CurrentResident.Type.Type = 0 Then 'undecided
            bPay = False
            MessageBox.Show("Du kan ikke gå til betaling før du har angivet hvilken type beboer " & CurrentResident.DisplayMember & " er")
            Me.ddlResidentType.Focus()
            Exit Sub
        End If
        Dim rib As New Elements.ResidentInBed
        If rib.List(CurrentResident.ID).Tables(0).Rows.Count = 0 Then 'not assigned to bed
            bPay = False
            MessageBox.Show("Du kan ikke gå til betaling før beboeren er tilknyttet en seng.")
            Me.txtRoomAndBed.Focus()
            Exit Sub
        End If
        If bPay Then
            SaveResident()
            Dim formPay As New K_Booking_Payment
            formPay.ResidentID = CurrentResident.ID
            formPay.UserID = LoggedInUser_ID
            formPay.Location = New System.Drawing.Point(50, 10)
            formPay.ShowDialog()
            SetResident(CurrentResident.ID)
            Me.txtFirstName.Focus()
        End If
    End Sub

    '## Events ##
    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        Pay()
    End Sub
#End Region

#Region " Prices "
    '## Sub rutines ##
    Private Sub StartPriceSets()
        Dim ps As New Elements.PriceSet

        Me.ddlPriceSets.DataSource = ps.ListInArray
        Me.ddlPriceSets.DisplayMember = "DisplayMember"

        ShowPriceSet(CType(Me.ddlPriceSets.Items.Item(0), Elements.PriceSet).ID)
        SetPriceDescriptions()
    End Sub

    Private Sub ShowPriceSet(ByVal intPriceSetID As Integer)
        Dim objDataset As DataSet
        Dim objRow As DataRow
        Dim p As New Elements.Price
        objDataset = p.GetPrices(intPriceSetID)
        objRow = objDataset.Tables(0).Rows(0)
        ShowPrice(Me.txtPriceOne, objRow)
        objRow = objDataset.Tables(0).Rows(1)
        ShowPrice(Me.txtPriceTwo, objRow)
        objRow = objDataset.Tables(0).Rows(2)
        ShowPrice(Me.txtPriceThree, objRow)
        objRow = objDataset.Tables(0).Rows(3)
        ShowPrice(Me.txtPriceFour, objRow)
        objRow = objDataset.Tables(0).Rows(4)
        ShowPrice(Me.txtPriceFive, objRow)
        objRow = objDataset.Tables(0).Rows(5)
        ShowPrice(Me.txtPriceSix, objRow)
        objRow = objDataset.Tables(0).Rows(6)
        ShowPrice(Me.txtPriceSeven, objRow)
    End Sub

    Private Sub ShowPrice(ByVal txt As TextBox, ByVal objRow As DataRow)
        Dim objString As Object = objRow("K_PriceAmount")
        txt.Text = objString.ToString
    End Sub

    Private Sub PriceWritable(ByVal bEnabled As Boolean)
        Me.txtPriceOne.Enabled = bEnabled
        Me.txtPriceTwo.Enabled = bEnabled
        Me.txtPriceThree.Enabled = bEnabled
        Me.txtPriceFour.Enabled = bEnabled
        Me.txtPriceFive.Enabled = bEnabled
        Me.txtPriceSix.Enabled = bEnabled
        Me.txtPriceSeven.Enabled = bEnabled
    End Sub

    Private Sub SetPriceDescriptions()
        Dim objDataset As New DataSet
        Dim objRow As DataRow
        Dim p As New Elements.Price
        objDataset = p.GetPriceDescriptions
        objRow = objDataset.Tables(0).Rows(0)
        SetPriceDescription(Me.lblPriceOne, objRow)
        objRow = objDataset.Tables(0).Rows(1)
        SetPriceDescription(Me.lblPriceTwo, objRow)
        objRow = objDataset.Tables(0).Rows(2)
        SetPriceDescription(Me.lblPriceThree, objRow)
        objRow = objDataset.Tables(0).Rows(3)
        SetPriceDescription(Me.lblPriceFour, objRow)
        objRow = objDataset.Tables(0).Rows(4)
        SetPriceDescription(Me.lblPriceFive, objRow)
        objRow = objDataset.Tables(0).Rows(5)
        SetPriceDescription(Me.lblPriceSix, objRow)
        objRow = objDataset.Tables(0).Rows(6)
        SetPriceDescription(Me.lblPriceSeven, objRow)

        PriceWritable(False)
    End Sub

    Private Sub SetPriceDescription(ByVal lbl As Label, ByVal objRow As DataRow)
        lbl.Text = ConvertToString(objRow("K_PriceDescription"))
    End Sub

    '## Events ##
    Private Sub ddlPriceSets_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlPriceSets.SelectedIndexChanged
        If Not Me.ddlPriceSets.SelectedIndex = -1 Then
            ShowPriceSet(CType(Me.ddlPriceSets.SelectedItem, Elements.PriceSet).ID)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim bErr As Boolean = False
        Dim ps As New Elements.PriceSet
        ps.ValidFrom = Me.datPriceValidFrom.Value
        If ps.Save > 0 Then
            If Not ps.FetchNewPriceSet Then
                bErr = True
            End If
        Else
            bErr = True
        End If
        If Not bErr Then
            If Me.txtPriceOne.Text.Length = 0 OrElse Not IsNumeric(Me.txtPriceOne.Text) Then
                bErr = True
                MessageBox.Show("Beløbet i " & Me.lblPriceOne.Text & " er ikke gyldigt!")
            End If
            If Me.txtPriceTwo.Text.Length = 0 OrElse Not IsNumeric(Me.txtPriceTwo.Text) Then
                bErr = True
                MessageBox.Show("Beløbet i " & Me.lblPriceTwo.Text & " er ikke gyldigt!")
            End If
            If Me.txtPriceThree.Text.Length = 0 OrElse Not IsNumeric(Me.txtPriceThree.Text) Then
                bErr = True
                MessageBox.Show("Beløbet i " & Me.lblPriceThree.Text & " er ikke gyldigt!")
            End If
            If Me.txtPriceFour.Text.Length = 0 OrElse Not IsNumeric(Me.txtPriceFour.Text) Then
                bErr = True
                MessageBox.Show("Beløbet i " & Me.lblPriceFour.Text & " er ikke gyldigt!")
            End If
            If Me.txtPriceFive.Text.Length = 0 OrElse Not IsNumeric(Me.txtPriceFive.Text) Then
                bErr = True
                MessageBox.Show("Beløbet i " & Me.lblPriceFive.Text & " er ikke gyldigt!")
            End If
            If Me.txtPriceSix.Text.Length = 0 OrElse Not IsNumeric(Me.txtPriceSix.Text) Then
                bErr = True
                MessageBox.Show("Beløbet i " & Me.lblPriceSix.Text & " er ikke gyldigt!")
            End If
            If Me.txtPriceSeven.Text.Length = 0 OrElse Not IsNumeric(Me.txtPriceSeven.Text) Then
                bErr = True
                MessageBox.Show("Beløbet i " & Me.lblPriceSeven.Text & " er ikke gyldigt!")
            End If
        End If
        If Not bErr Then
            Dim p As New Elements.Price
            p.Amount = ConvertToDouble(Me.txtPriceOne.Text)
            p.SetID = ps.ID
            p.ID = 1
            p.Save()

            p.Amount = ConvertToDouble(Me.txtPriceTwo.Text)
            p.SetID = ps.ID
            p.ID = 2
            p.Save()

            p.Amount = ConvertToDouble(Me.txtPriceThree.Text)
            p.SetID = ps.ID
            p.ID = 3
            p.Save()

            p.Amount = ConvertToDouble(Me.txtPriceFour.Text)
            p.SetID = ps.ID
            p.ID = 4
            p.Save()

            p.Amount = ConvertToDouble(Me.txtPriceFive.Text)
            p.SetID = ps.ID
            p.ID = 5
            p.Save()

            p.Amount = ConvertToDouble(Me.txtPriceSix.Text)
            p.SetID = ps.ID
            p.ID = 6
            p.Save()

            p.Amount = ConvertToDouble(Me.txtPriceSeven.Text)
            p.SetID = ps.ID
            p.ID = 7
            p.Save()

            PriceWritable(False)
        End If
        StartPriceSets()
    End Sub

    Private Sub btnNewPriceSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewPriceSet.Click
        Me.ddlPriceSets.SelectedIndex = -1
        PriceWritable(True)
    End Sub
#End Region

#Region " Timer "
    '## Sub rutines ##
    Private Sub TimerRun(ByVal bRun As Boolean)
        Me.Timer1.Enabled = False 'bRun
    End Sub

    '## Events ##
    Private Sub Timer1_Elapsed(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs) Handles Timer1.Elapsed
        'SaveVisible()
    End Sub
#End Region

#Region " Events "
    Private Sub datArrival_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles datArrival.Leave
        If Me.txtID.Text = 0 Then
            Me.datInBedFrom.Value = Me.datArrival.Value
            Me.datDeparture.Value = Me.datArrival.Value
            Me.datPaidUntill.Value = Me.datArrival.Value.AddDays(-1)
        End If
    End Sub

    Private Sub datDeparture_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles datDeparture.Leave
        If Me.txtID.Text = 0 Then
            Me.datInBedTo.Value = Me.datDeparture.Value
        End If
        txtDKAddress.Focus()
    End Sub
#End Region

#Region " Print Welcome Page "
    'include mobjresidents details on print
    Private m_IncludeDetails As Boolean = True

    ''' <summary>
    ''' print welcome note with residenst details
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnWelcome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWelcome.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            prdWelcomeNote.Print()
        End If
    End Sub

    ''' <summary>
    ''' print blank welcome note
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnBlankWelcome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlankWelcome.Click
        m_IncludeDetails = False
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            prdWelcomeNote.Print()
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub prdWelcomeNote_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prdWelcomeNote.PrintPage
        '#TODO: draw template and add data if m_IncludeDetails is true
        Dim font As New Font("Arial", 9)
        ' initializing the font to be used for printing
        Dim PrintAreaHeight, PrintAreaWidth, marginLeft, marginTop As Int32
        With prdWelcomeNote.DefaultPageSettings
            .Margins.Top = 50
            .Margins.Left = 50
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

        Dim iHeight As Integer

        iHeight = WriteWelcomeTemplate(e, marginLeft, marginTop, PrintAreaWidth, font)

        'draw frame
        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(marginLeft, marginTop, PrintAreaWidth, iHeight))
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="printer">PrintPageEventArgs</param>
    ''' <param name="x">the x-start value of the print</param>
    ''' <param name="y">the y-start value of the print</param>
    ''' <param name="w">width of print area</param>
    ''' <param name="f">Font</param>
    ''' <returns>the height of the template</returns>
    ''' <remarks></remarks>
    Private Function WriteWelcomeTemplate(ByVal printer As System.Drawing.Printing.PrintPageEventArgs, ByVal x As Integer, ByVal y As Integer, ByVal w As Integer, ByVal f As Font) As Integer
        Dim cw As Integer = w / 2 'column width
        Dim c As Integer = 0 '0-indexed column we are writing to
        Dim iHeight As Integer = 0 'the total height of the template

        Dim iTempY As Integer = y
        Dim sText As String = ""

        Dim fb As New Font(f, FontStyle.Bold)
        Dim fi As New Font(f, FontStyle.Italic)

        Dim res As New K.Booking.Elements.Resident

        If m_IncludeDetails Then
            res = CurrentResident
        End If
        'name
        iHeight += WriteLabel(printer, "Fulde navn: ", res.FirstName & " " & res.LastName, f, x + (c * cw), iTempY, w, True)

        'cpr
        iTempY = y + iHeight
        iHeight += WriteLabel(printer, "CPR-nr.: ", res.CPR, f, x + (c * cw), iTempY, cw, True)
        'chronic illness
        c = 1
        If res.ChronicIllness Then
            sText = "_ Nej X Ja, " & res.ChronicIllnessDescription
        Else
            sText = "_ Nej _ Ja, hvilken?"
        End If
        WriteLabel(printer, "Kronisk sygdom: ", sText, f, x + (c * cw), iTempY, cw, True)
        sText = ""

        'arrival
        iTempY = y + iHeight
        c = 0
        iHeight += WriteLabel(printer, "Ankomstdato: ", Format(res.ArrivalDate, "dd/MM/yyyy"), f, x + (c * cw), iTempY, cw, True)
        'departure
        c = 1
        WriteLabel(printer, "Afrejsedato: ", Format(res.DepartureDate, "dd/MM/yyyy"), f, x + (c * cw), iTempY, cw, True)

        'DK address
        c = 0
        iTempY = y + iHeight
        iHeight += WriteLabel(printer, "DK adresse - gade: ", res.DKAddress, f, x + (c * cw), iTempY, w, True)

        'DK address
        iTempY = y + iHeight
        iHeight += WriteLabel(printer, "DK adresse - postnr. & by: ", res.DKPostalCode & " " & res.DKCity, f, x + (c * cw), iTempY, w, True)

        'phone
        iTempY = y + iHeight
        iHeight += WriteLabel(printer, "Telefon: ", res.Phone & " " & res.Phone2, f, x + (c * cw), iTempY, w, True)

        'email
        iTempY = y + iHeight
        iHeight += WriteLabel(printer, "E-mail adresse: ", res.Email, f, x + (c * cw), iTempY, w, True)

        'DK contact person
        iTempY = y + iHeight
        iHeight += WriteLabel(printer, "Kontaktperson i DK - Navn: ", res.DKContactName, fi, x + (c * cw), iTempY, w, True)

        'DK contact address
        iTempY = y + iHeight
        iHeight += WriteLabel(printer, "Postnr. & by: ", res.DKContactAddress, fi, x + (c * cw), iTempY, w, True)

        'DK contact phone
        iTempY = y + iHeight
        iHeight += WriteLabel(printer, "Telefonnummer: ", res.DKContactPhone, fi, x + (c * cw), iTempY, w, True, 2)


        'æøå
        'terms
        iTempY = y + iHeight
        iHeight += WriteLabel(printer, "Erklæring: ", "Undertegnede bekræfter hermed at have læst og accepteret K's husregler, bl.a. følgende: ", fb, x + (c * cw), iTempY, w)
        iTempY = y + iHeight
        iHeight += WriteLabel(printer, "*", "Det er ikke tilladt at indtage/opbevare øl, vin, spiritus eller stoffer på K", f, x + (c * cw), iTempY, w)
        iTempY = y + iHeight
        iHeight += WriteLabel(printer, "*", "Det er ikke tilladt at ryge på værelserne", f, x + (c * cw), iTempY, w)
        iTempY = y + iHeight
        iHeight += WriteLabel(printer, "*", "Der skal være ro pa værelserne kl. 23.00, og resten af huset lukker kl. 00.30, herefter skal der være ro i huset. Efter kl.23.00 må der ikke være gæster på værelserne, hverken interne eller eksterne", f, x + (c * cw), iTempY, w)
        iTempY = y + iHeight
        iHeight += WriteLabel(printer, "*", "Det er forbudt at råbe, skrige, støje osv. udenfor K og på Maresfield Gardens - vis hensyn overfor vores naboer og dine medbeboere", f, x + (c * cw), iTempY, w)
        iTempY = y + iHeight
        iHeight += WriteLabel(printer, "*", "K's lejeregler og priser, som specificeret i velkomstbrochuren, herunder at jeg har en uges opsigelse som fast beboer", f, x + (c * cw), iTempY, w)
        iTempY = y + iHeight
        iHeight += WriteLabel(printer, "*", "Overtrædelse af K's husregler kan medføre bortvisning", f, x + (c * cw), iTempY, w, True)

        'news letter
        iTempY = y + iHeight
        iHeight += WriteLabel(printer, "_ Nej tak, jeg ønsker ikke at modtage K's nyhedsbrev på e-mail", "", fb, x + (c * cw), iTempY, w, True, 3)

        'signature
        iTempY = y + iHeight
        c = 0
        iHeight += WriteLabel(printer, "Underskrift: ", "", f, x + (c * cw), iTempY, cw)
        'date
        c = 1
        WriteLabel(printer, "Dato: ", "", f, x + (c * cw), iTempY, cw)

        Return iHeight
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="printer"></param>
    ''' <param name="sLabel"></param>
    ''' <param name="sText"></param>
    ''' <param name="f"></param>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <param name="w"></param>
    ''' <param name="line">add line under ?</param>
    ''' <returns>height</returns>
    ''' <remarks></remarks>
    Private Function WriteLabel(ByVal printer As System.Drawing.Printing.PrintPageEventArgs, ByVal sLabel As String, ByVal sText As String, ByVal f As Font, ByVal x As Integer, ByVal y As Integer, ByVal w As Integer, Optional ByVal line As Boolean = False, Optional ByVal space As Integer = 0) As Integer
        Dim fmt As New StringFormat(StringFormatFlags.LineLimit)
        Dim size As New System.Drawing.SizeF
        'get the size of the string printed
        size = printer.Graphics.MeasureString(sLabel & sText, f, w, fmt)

        'print the string
        'printer.Graphics.DrawString(sLabel & sText, f, Brushes.Black, x, y, fmt)
        printer.Graphics.DrawString(sLabel & sText, f, Brushes.Black, New RectangleF(x, y, w, size.Height), fmt)

        If line Then
            printer.Graphics.DrawLine(Pens.Black, x, y + size.Height, x + w, y + size.Height)
            space += 3
        End If

        'return the height of the printed string
        Return size.Height + space
    End Function

#End Region

#Region " Print Resident list "
    Private Sub btnPrintResidentList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintResidentList.Click
        '##TODO: print resident list
        'If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    prdResidentLIst.Print()
        'End If

        Dim PrintPreviewDialog1 As New PrintPreviewDialog()
        PrintPreviewDialog1.Document = prdResidentLIst
        If PrintPreviewDialog1.ShowDialog() = DialogResult.OK Then
            prdResidentLIst.Print()
        End If
    End Sub

    Private iX As Integer 'the x-coordinate 
    Private iCW As Integer 'the width of one column
    Private iHeight As Integer 'print area height
    Private iTopHeight As Integer 'the height of the top section

    Private Sub prdResidentLIst_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prdResidentLIst.PrintPage
        '##TODO: print all rooms with all beds in system
        ' initializing the font to be used for printing
        Dim PrintAreaHeight As Int32
        Dim PrintAreaWidth As Int32
        Dim marginLeft As Int32
        Dim marginTop As Int32
        Dim RoomPrintAreaHeight As Int32
        Dim FooterHeight As Int32
        With prdWelcomeNote.DefaultPageSettings
            .Margins.Left = 50
            .Margins.Top = 50
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

        Dim f As New Font("Arial", 11, FontStyle.Bold)
        Dim ff As New Font("Arial", 9)

        e.Graphics.DrawString("GÆSTELISTE " & DanishDateFormat(datResidentList.Value) & "", f, Brushes.Black, marginLeft, marginTop)
        e.Graphics.DrawLine(Pens.Black, marginLeft, marginTop + f.Height + 2, marginLeft + PrintAreaWidth, marginTop + f.Height + 2)
        e.Graphics.DrawString("A = Ankommer d.d. Tal = Afrejsedate S = Staff F = Fast beboer G = Gæsteværelse", f, Brushes.Black, marginLeft, marginTop + f.Height + 4)
        e.Graphics.DrawLine(Pens.Black, marginLeft, marginTop + (f.Height * 2) + 5, marginLeft + PrintAreaWidth, marginTop + (f.Height * 2) + 4)

        iTopHeight = (f.Height * 2) + 10

        iX = marginLeft
        iCW = PrintAreaWidth / 2
        FooterHeight = (ff.Height * 3) + 10
        RoomPrintAreaHeight = PrintAreaHeight - iTopHeight - FooterHeight
        ResetHeight()

        Dim room As New Elements.Room
        For Each r As DataRow In room.List.Tables(0).Rows
            room.Fetch(r.Item("K_RoomID"))
            If room.Type = Data.GlobalEnums.RoomType.Room Then
                WriteRoom(e, room, RoomPrintAreaHeight - iHeight, marginTop)
            End If
        Next

        'get all residents moving in or out or moving bed today for list and write list
        e.Graphics.DrawLine(Pens.Black, marginLeft, RoomPrintAreaHeight + iTopHeight, marginLeft + PrintAreaWidth, RoomPrintAreaHeight + iTopHeight)
        e.Graphics.DrawString(LeavingToday(datResidentList.Value), ff, Brushes.Black, marginLeft, RoomPrintAreaHeight + iTopHeight)
        e.Graphics.DrawString(MovingRoomToday(datResidentList.Value), ff, Brushes.Black, marginLeft, RoomPrintAreaHeight + iTopHeight + ff.Height)
    End Sub

    'Dim aLeaving As New ArrayList
    'Dim aMoving As New ArrayList

    Private Function LeavingToday(ByVal dat As DateTime) As String
        Dim s As String = ""

        Dim res As New Elements.Resident

        'get all residents leaving today
        Dim ds As DataSet = res.ListLeaving(dat)

        res = Nothing

        If ds.Tables(0).Rows.Count > 0 Then
            'at least one resident is moving beds today
            s = "Rejser i dag: "
            Dim bFirst As Boolean = True
            For Each r As DataRow In ds.Tables(0).Rows
                If Not bFirst Then
                    s &= ", "
                End If
                s &= r("K_ResidentFirstName") & " " & r("K_ResidentLastName") & " v." & r("K_RoomKey")
                bFirst = False
            Next
        End If

        Return s
    End Function

    Private Function MovingRoomToday(ByVal dat As DateTime) As String
        Dim s As String = ""

        'get all residents moving room today
        Dim res As New Elements.Resident
        Dim ds As DataSet = res.ListMoving(dat)

        res = Nothing

        If ds.Tables(0).Rows.Count > 0 Then
            'at least one resident is moving beds today
            s = "Flytter værelse: "
            Dim bFirst As Boolean = True
            For Each r As DataRow In ds.Tables(0).Rows
                If Not bFirst Then
                    s &= ", "
                End If
                s &= r("K_ResidentFirstName") & " " & r("K_ResidentLastName") & " v." & r("FromRoom") & " til v." & r("ToRoom")
                bFirst = False
            Next
        End If

        Return s
    End Function

    Private Function DanishDateFormat(ByVal dat As DateTime) As String
        Dim sDate As String = "%%DAY%% den %%DATE%%. %%MONTH%% %%YEAR%%"
        Dim sDay As String = ""
        Dim sMonth As String = ""

        Select Case dat.DayOfWeek
            Case DayOfWeek.Monday
                sDay = "Mandag"
            Case DayOfWeek.Tuesday
                sDay = "Tirsdag"
            Case DayOfWeek.Wednesday
                sDay = "Onsdag"
            Case DayOfWeek.Thursday
                sDay = "Torsdag"
            Case DayOfWeek.Friday
                sDay = "Fredag"
            Case DayOfWeek.Saturday
                sDay = "Lørdag"
            Case DayOfWeek.Sunday
                sDay = "Søndag"
        End Select

        Select Case dat.Month
            Case 1
                sMonth = "januar"
            Case 2
                sMonth = "februar"
            Case 3
                sMonth = "marts"
            Case 4
                sMonth = "april"
            Case 5
                sMonth = "maj"
            Case 6
                sMonth = "juni"
            Case 7
                sMonth = "juli"
            Case 8
                sMonth = "august"
            Case 9
                sMonth = "september"
            Case 10
                sMonth = "oktober"
            Case 11
                sMonth = "november"
            Case 12
                sMonth = "december"
        End Select

        sDate = sDate.Replace("%%DAY%%", sDay).Replace("%%MONTH%%", sMonth).Replace("%%YEAR%%", dat.Year).Replace("%%DATE%%", dat.Day)

        Return sDate
    End Function

    Private Sub ResetHeight()
        iHeight = iTopHeight
    End Sub

    Private Sub WriteRoom(ByVal printer As System.Drawing.Printing.PrintPageEventArgs, ByVal objRoom As Elements.Room, ByVal iHeightLeft As Integer, ByVal iY As Integer)
        Dim bed As New Elements.Bed
        Dim resident As New Elements.Resident
        Dim rib As New Elements.ResidentInBed
        Dim ds As DataSet = bed.ListInRoom(objRoom.ID)
        Dim f As New Font("Arial", 9)
        Dim fb As New Font(f, FontStyle.Bold)
        Dim x As Integer
        Dim y As Integer

        If ds.Tables(0).Rows.Count * fb.Height >= iHeightLeft Then
            'go to next column
            iX += iCW
            ResetHeight()
        End If

        y = iY + iHeight

        Dim bFirst As Boolean = True
        Dim iGuests As Integer = 0

        For Each r As DataRow In ds.Tables(0).Rows
            Dim b As New Elements.Bed(r.Item("K_BedID"))

            rib.BedID = b.ID
            rib.FromDate = datResidentList.Value
            rib.ToDate = datResidentList.Value
            Dim resDS As DataSet = rib.CheckOccupied

            x = iX

            If resDS.Tables(0).Rows.Count > 0 OrElse b.IsPermanent Then
                'room
                If bFirst Then 'only write room for first bed
                    iGuests = 0
                    printer.Graphics.DrawString("Værelse " & objRoom.Key & ":", fb, Brushes.Black, x, y) 'write
                    bFirst = False
                End If
                'x += printer.Graphics.MeasureString(objRoom.Key & " ", fb).Width 'meassure
                x += 90

                'bed
                printer.Graphics.DrawString(b.Key & ".", f, Brushes.Black, x, y) 'write
                'x += printer.Graphics.MeasureString(b.Key & " ", f).Width 'meassure
                x += 25

                'resident (if any)

                If resDS.Tables(0).Rows.Count > 0 Then
                    resident.Fetch(resDS.Tables(0).Rows(0).Item("K_ResidentID"))

                    If resident.Type.NumberOfGuests > 0 Then
                        iGuests = resident.Type.NumberOfGuests - 1
                    End If

                    'resident in bed (draw)
                    printer.Graphics.DrawString(resident.FirstName & " " & resident.LastName, f, Brushes.Black, x, y) 'write

                    'resident code
                    x += 180
                    printer.Graphics.DrawString(GetResidentCode(resident, rib.FromDate), f, Brushes.Black, x, y) 'write
                ElseIf iGuests > 0 Then
                    'resident in bed (draw)
                    printer.Graphics.DrawString("Ledsager", f, Brushes.Black, x, y) 'write
                    iGuests -= 1
                End If

                y += fb.Height
            End If
        Next

        iHeight += (ds.Tables(0).Rows.Count + 1) * fb.Height
    End Sub

    Private Function GetResidentCode(ByVal objResident As Elements.Resident, ByVal dat As DateTime) As String
        Dim sCode As String = ""
        'resident is arriving today?
        If objResident.ArrivalDate.Year = dat.Year AndAlso objResident.ArrivalDate.Month = dat.Month AndAlso objResident.ArrivalDate.Day = dat.Day Then
            sCode &= "A"
        End If

        'resident is guest ?
        If objResident.Type.Type = K.Booking.Data.GlobalEnums.ResidentType.Guest Then
            sCode &= "G"
        End If

        'resident is long term ?
        If objResident.Type.Type = K.Booking.Data.GlobalEnums.ResidentType.LongTerm Then
            sCode &= "F"
        End If

        'resident is staff ?
        If objResident.Type.Type = K.Booking.Data.GlobalEnums.ResidentType.Staff Then
            sCode &= "S"
        End If

        'resident leaving this month?
        If objResident.DepartureDate.Year = dat.Year AndAlso objResident.DepartureDate.Month = dat.Month Then
            sCode &= objResident.DepartureDate.Day
        End If

        Return sCode
    End Function
#End Region

#Region " Invoice History "

    Private Sub btnInvoiceHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvoiceHistory.Click
        Dim formInvoices As New K_Booking_Invoices
        formInvoices.ResidentID = CurrentResident.ID
        formInvoices.ShowDialog()
    End Sub

#End Region

#Region " Stats "
    Private StatsFromDate As DateTime
    Private iPrintStatsID As Integer

    Private Sub StartStats()
        Dim objStats As New Elements.Stats

        SetStatDates()

        'show old stats from last month (this if there are none from last)
        Dim objArray As New ArrayList
        If chkStatsShowAll.Checked Then
            objArray = objStats.ListInArray
        Else
            objArray = objStats.ListByMonth(Now.AddMonths(-1).Month, Now.Year)
            If objArray.Count < 1 Then
                'none from last month - get this month
                objArray = objStats.ListByMonth(Now.Month, Now.Year)
                datStatsShow.Value = Now
            Else
                datStatsShow.Value = Now.AddMonths(-1)
            End If
        End If

        lbxStats.DisplayMember = "DisplayMember"
        lbxStats.DataSource = objArray
    End Sub

    Private Sub SetStatDates()
        Dim objStats As New Elements.Stats
        Dim datStartDate As DateTime = objStats.GetStartDate
        If Not datStartDate = Nothing Then
            'end date = yesterday
            datStatsTo.Value = Now.AddDays(-1)
            'start date = last stast - 1 day or if no stats = first invoice
            datStatsFrom.Value = datStartDate
            StatsFromDate = datStartDate
        End If
    End Sub

    Private Sub ListStats()
        Dim objStats As New Elements.Stats
        Dim objArray As New ArrayList
        If chkStatsShowAll.Checked Then
            objArray = objStats.ListInArray
        Else
            objArray = objStats.ListByMonth(datStatsShow.Value.Month, datStatsShow.Value.Year)
        End If

        lbxStats.DisplayMember = "DisplayMember"
        lbxStats.DataSource = objArray
    End Sub

    Private Sub btnPrintStats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintStats.Click
        'save stats (all invoices) from date to date
        'validate dates
        'If datStatsFrom.Value > datStatsTo.Value Then
        '    MessageBox.Show("Startdatoen skal ligge før slutdatoen", "Udskrifter", MessageBoxButtons.OK)
        'ElseIf datStatsTo.Value > Now.AddDays(-1) Then
        '    MessageBox.Show("Systemet tillader kun at udskrive statistikker til og med i går", "Udskrifter", MessageBoxButtons.OK)
        'ElseIf datStatsFrom.Value < StatsFromDate Then
        '    MessageBox.Show("Systemet tillader kun at udskrive statistikker, der ikke er udskrevet endnu. Vælg en senere start dato.", "Udskrifter", MessageBoxButtons.OK)
        'Else
        Dim objStats As New Elements.Stats
        objStats.CreatedBy = LoggedInUser_ID
        objStats.CreatedDate = Now
        objStats.FromDate = datStatsFrom.Value
        objStats.ToDate = datStatsTo.Value
        objStats.Save()
        If objStats.FetchLatest Then
            Dim objInvoice As New Elements.Invoice
            For Each inv As Elements.Invoice In objInvoice.ListForStatsInArray(datStatsFrom.Value, datStatsTo.Value)
                Dim objStatsInvoice As New Elements.StatsInvoices
                objStatsInvoice.InvoiceID = inv.ID
                objStatsInvoice.StatsID = objStats.ID
                objStatsInvoice.Save()
            Next
        Else
            'wtf??
            MessageBox.Show("Der er sket en fejl i systemet i forbindelse med denne statistik. Luk systemet og prøv igen og kontakt udvikleren.", "Udskrifter", MessageBoxButtons.OK)
        End If


        'print this stat
        iPrintStatsID = objStats.ID
        'PrintStats()

        ShowStats()
        StartStats()
        'End If
    End Sub

    Private oStatsToPrint As ArrayList

    Private Sub btnStatsView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatsView.Click
        'print preview stats
        oStatsToPrint = New ArrayList
        If lbxStats.SelectedIndex > -1 Then
            For Each o As Object In lbxStats.SelectedItems
                oStatsToPrint.Add(TryCast(o, Elements.Stats).ID)
            Next
            'iPrintStatsID = TryCast(lbxStats.SelectedValue, Elements.Stats).ID
            ShowStats()
        End If
    End Sub

    Private Sub ShowStats()
        Dim PrintPreviewDialog1 As New PrintPreviewDialog()
        PrintPreviewDialog1.Document = prdStats
        If PrintPreviewDialog1.ShowDialog() = DialogResult.OK Then
            prdStats.Print()
        End If
    End Sub

    Private Sub PrintStats()
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            prdStats.Print()
        End If
    End Sub

    Private Sub prdStats_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prdStats.PrintPage
        Dim f As New Font("Arial", 10)

        Dim PrintAreaHeight As Int32
        Dim PrintAreaWidth As Int32
        Dim marginLeft As Int32
        Dim marginTop As Int32
        With prdStats.DefaultPageSettings
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

        Dim objStats As New Elements.Stats
        Dim objStatsInvoices As New Elements.StatsInvoices
        If Not oStatsToPrint Is Nothing AndAlso oStatsToPrint.Count > 0 Then
            iPrintStatsID = oStatsToPrint(0)
            oStatsToPrint.RemoveAt(0)
            If oStatsToPrint.Count > 0 Then
                e.HasMorePages = True
            End If
        End If
        objStats.Fetch(iPrintStatsID)

        Dim height As Integer = 0
        'write header (dates)
        e.Graphics.DrawString(Format(objStats.FromDate, "dd-MM-yyyy") & " - " & Format(objStats.ToDate, "dd-MM-yyyy"), New Font(f, FontStyle.Bold), Brushes.Black, marginLeft, marginTop)

        height += f.Height + 5

        'loop invoices
        'loop lines
        Dim dblLongTerm As Double = 0
        Dim dblLongTermFoodStamps As Double = 0
        Dim dblLongTermLateFee As Double = 0
        Dim dblLongTermCCFee As Double = 0
        Dim dblLongTermNoFoodTicket As Double = 0

        Dim dblShortTerm As Double = 0
        Dim dblShortTermFoodStamps As Double = 0
        Dim dblShortTermLateFee As Double = 0
        Dim dblShortTermCCFee As Double = 0

        Dim dblOther As Double = 0

        Dim dblFlat As Double = 0
        Dim dblFlatLateFee As Double = 0
        Dim dblFlatCCFee As Double = 0

        Dim sFromInvNo As String = ""
        Dim sToInvNo As String = ""
        Dim bIsFirst As Boolean = True

        Dim hFlats As New Hashtable
        Dim aOther As New ArrayList

        Dim objPrice As New Elements.Price

        For Each objInv As Elements.Invoice In objStatsInvoices.ListInStat(objStats.ID)

            If bIsFirst Then
                sFromInvNo = Data.Misc.GetPrintInvoiceNo(objInv.ID)
                bIsFirst = False
            End If

            sToInvNo = Data.Misc.GetPrintInvoiceNo(objInv.ID)

            For Each objLine As Elements.InvoiceLine In objInv.InvoiceLines(objInv.ID)

                Select Case objLine.PriceID
                    Case Data.GlobalEnums.PriceDesctiption.CCFeeLongTerm
                        dblLongTermCCFee += objLine.Amount
                    Case Data.GlobalEnums.PriceDesctiption.CCFeeShortTerm
                        dblShortTermCCFee += objLine.Amount
                    Case Data.GlobalEnums.PriceDesctiption.Flat 'FLAT
                        Dim dt As DataTable = objInv.GetFlatDescription(objInv.ID)
                        Dim oFlat As Flat = GetFlat(dt.Rows(0)("K_BedID"), hFlats)
                        oFlat.m_Amount += objLine.Amount
                        oFlat.m_Desctiption = dt.Rows(0)("K_RoomDescription")
                        hFlats = AddToFlats(dt.Rows(0)("K_BedID"), oFlat, hFlats)
                        dblFlat += objLine.Amount
                    Case Data.GlobalEnums.PriceDesctiption.CCFeeFlat 'FLAT
                        Dim dt As DataTable = objInv.GetFlatDescription(objInv.ID)
                        Dim oFlat As Flat = GetFlat(dt.Rows(0)("K_BedID"), hFlats)
                        oFlat.m_CCFee += objLine.Amount
                        oFlat.m_Desctiption = dt.Rows(0)("K_RoomDescription")
                        hFlats = AddToFlats(dt.Rows(0)("K_BedID"), oFlat, hFlats)
                        dblFlatCCFee += objLine.Amount
                    Case Data.GlobalEnums.PriceDesctiption.LateFeeFlat 'FLAT
                        Dim dt As DataTable = objInv.GetFlatDescription(objInv.ID)
                        Dim oFlat As Flat = GetFlat(dt.Rows(0)("K_BedID"), hFlats)
                        oFlat.m_Late += objLine.Amount
                        oFlat.m_Desctiption = dt.Rows(0)("K_RoomDescription")
                        hFlats = AddToFlats(dt.Rows(0)("K_BedID"), oFlat, hFlats)
                        dblFlatLateFee += objLine.Amount
                    Case Data.GlobalEnums.PriceDesctiption.Guest
                        dblShortTerm += objLine.Amount
                    Case Data.GlobalEnums.PriceDesctiption.GuestRoomDeposit
                        dblShortTerm += objLine.Amount
                    Case Data.GlobalEnums.PriceDesctiption.LateFeeLongTerm
                        dblLongTermLateFee += objLine.Amount
                    Case Data.GlobalEnums.PriceDesctiption.LateFeeShortTerm
                        dblShortTermLateFee += objLine.Amount
                    Case Data.GlobalEnums.PriceDesctiption.LongTermHigh
                        dblShortTerm += objLine.Amount

                        'get the price for a foodstamp that was valid on first day of this week
                        dblShortTermFoodStamps += objPrice.GetFoodstampPrice(objLine.DatFrom)
                    Case Data.GlobalEnums.PriceDesctiption.LongTermLow
                        dblLongTerm += objLine.Amount

                        'get the price for a foodstamp that was valid on first day of this week
                        dblLongTermFoodStamps += objPrice.GetFoodstampPrice(objLine.DatFrom)
                    Case Data.GlobalEnums.PriceDesctiption.LongTermNoFoodTicket
                        dblLongTermNoFoodTicket += objLine.Amount

                        'no food ticket for this payment
                    Case Data.GlobalEnums.PriceDesctiption.Other
                        Dim o As New Other
                        o.m_Amount = objLine.Amount
                        o.m_Description = objLine.Description
                        o.m_InvoiceID = objLine.InvoiceID
                        aOther.Add(o)
                        dblOther += objLine.Amount
                    Case Data.GlobalEnums.PriceDesctiption.ShortTerm
                        dblShortTerm += objLine.Amount
                End Select
            Next
        Next

        height += e.Graphics.MeasureString("1", f).Height
        e.Graphics.DrawString("FROM " & sFromInvNo & " - TO " & sToInvNo, f, Brushes.Black, marginLeft, marginTop + height)
        height += e.Graphics.MeasureString("1", f).Height
        height += e.Graphics.MeasureString("1", f).Height

        '## over 4
        e.Graphics.DrawString("Over 4 weeks (total amount incl. meal tickets) : £ " & FormatNumber(dblLongTerm + dblLongTermNoFoodTicket + dblLongTermCCFee + dblLongTermLateFee, 2), f, Brushes.Black, marginLeft, marginTop + height)
        height += e.Graphics.MeasureString("1", f).Height

        e.Graphics.DrawString(vbTab & "CC Fee : £ " & FormatNumber(dblLongTermCCFee, 2), f, Brushes.Black, marginLeft, marginTop + height)
        height += e.Graphics.MeasureString("1", f).Height

        e.Graphics.DrawString(vbTab & "Late Fee : £ " & FormatNumber(dblLongTermLateFee, 2), f, Brushes.Black, marginLeft, marginTop + height)
        height += e.Graphics.MeasureString("1", f).Height

        e.Graphics.DrawString(vbTab & "Value of meal vouchers : £ " & FormatNumber(dblLongTermFoodStamps, 2), f, Brushes.Black, marginLeft, marginTop + height)
        height += e.Graphics.MeasureString("1", f).Height

        e.Graphics.DrawString("Over 4 weeks (total amount excl. meal tickets): £ " & FormatNumber(dblLongTerm + dblLongTermNoFoodTicket + dblLongTermCCFee + dblLongTermLateFee - dblLongTermFoodStamps, 2), New Font(f, FontStyle.Bold), Brushes.Black, marginLeft, marginTop + height)
        height += e.Graphics.MeasureString("1", f).Height

        e.Graphics.DrawLine(Pens.Black, marginLeft, marginTop + height, marginLeft + PrintAreaWidth, marginTop + height)
        height += 25

        '## under 4
        e.Graphics.DrawString("Under 4 weeks (total amount incl. meal tickets) : £ " & FormatNumber(dblShortTerm + dblShortTermCCFee + dblShortTermLateFee, 2), f, Brushes.Black, marginLeft, marginTop + height)
        height += e.Graphics.MeasureString("1", f).Height

        e.Graphics.DrawString(vbTab & "CC Fee : £ " & FormatNumber(dblShortTermCCFee, 2), f, Brushes.Black, marginLeft, marginTop + height)
        height += e.Graphics.MeasureString("1", f).Height

        e.Graphics.DrawString(vbTab & "Late Fee : £ " & FormatNumber(dblShortTermLateFee, 2), f, Brushes.Black, marginLeft, marginTop + height)
        height += e.Graphics.MeasureString("1", f).Height

        e.Graphics.DrawString(vbTab & "Meal vouchers : £ " & FormatNumber(dblShortTermFoodStamps, 2), f, Brushes.Black, marginLeft, marginTop + height)
        height += e.Graphics.MeasureString("1", f).Height

        e.Graphics.DrawString("Under 4 weeks (total amount excl. meal tickets): £ " & FormatNumber(dblShortTerm + dblShortTermCCFee + dblShortTermLateFee - dblShortTermFoodStamps, 2), New Font(f, FontStyle.Bold), Brushes.Black, marginLeft, marginTop + height)
        height += e.Graphics.MeasureString("1", f).Height

        e.Graphics.DrawLine(Pens.Black, marginLeft, marginTop + height, marginLeft + PrintAreaWidth, marginTop + height)
        height += 25

        For Each i As Integer In hFlats.Keys
            Dim item As Flat = hFlats.Item(i)
            e.Graphics.DrawString(item.m_Desctiption & " : £ " & FormatNumber(item.m_Amount, 2), f, Brushes.Black, marginLeft, marginTop + height)
            height += e.Graphics.MeasureString("1", f).Height
            e.Graphics.DrawString(vbTab & "CC Fee" & " : £ " & FormatNumber(item.m_CCFee, 2), f, Brushes.Black, marginLeft, marginTop + height)
            height += e.Graphics.MeasureString("1", f).Height
            e.Graphics.DrawString(vbTab & "Late fee" & " : £ " & FormatNumber(item.m_Late, 2), f, Brushes.Black, marginLeft, marginTop + height)
            height += e.Graphics.MeasureString("1", f).Height
            e.Graphics.DrawString(vbTab & "Total" & " : £ " & FormatNumber(item.m_Late + item.m_CCFee + item.m_Amount, 2), New Font(f, FontStyle.Bold), Brushes.Black, marginLeft, marginTop + height)
            height += e.Graphics.MeasureString("1", f).Height
        Next

        e.Graphics.DrawString("Flats (total) : £ " & FormatNumber(dblFlat + dblFlatCCFee + dblFlatLateFee, 2), New Font(f, FontStyle.Bold), Brushes.Black, marginLeft, marginTop + height)
        height += e.Graphics.MeasureString("1", f).Height

        e.Graphics.DrawLine(Pens.Black, marginLeft, marginTop + height, marginLeft + PrintAreaWidth, marginTop + height)
        height += 25


        For Each o As Other In aOther
            e.Graphics.DrawString(o.m_Description & " (inv " & o.m_InvoiceID & ") : £ " & FormatNumber(o.m_Amount, 2), f, Brushes.Black, marginLeft, marginTop + height)
            height += e.Graphics.MeasureString("1", f).Height
        Next

        e.Graphics.DrawString("Other (total) : £ " & FormatNumber(dblOther, 2), New Font(f, FontStyle.Bold), Brushes.Black, marginLeft, marginTop + height)
        height += e.Graphics.MeasureString("1", f).Height

        e.Graphics.DrawLine(Pens.Black, marginLeft, marginTop + height, marginLeft + PrintAreaWidth, marginTop + height)
        height += 25

        e.Graphics.DrawString("Total : £ " & FormatNumber(dblFlat + dblFlatCCFee + dblFlatLateFee + dblLongTerm + dblLongTermNoFoodTicket + dblLongTermCCFee + dblLongTermLateFee + dblShortTerm + dblShortTermCCFee + dblShortTermLateFee + dblOther, 2), f, Brushes.Black, marginLeft, marginTop + height)
        height += e.Graphics.MeasureString("1", f).Height + 10

        e.Graphics.DrawString("Total (total amount excl. meal tickets): £ " & FormatNumber(dblFlat + dblFlatCCFee + dblFlatLateFee + dblLongTerm + dblLongTermNoFoodTicket + dblLongTermCCFee + dblLongTermLateFee + dblShortTerm + dblShortTermCCFee + dblShortTermLateFee + dblOther - dblLongTermFoodStamps - dblShortTermFoodStamps, 2), New Font("Arial", 14, FontStyle.Bold And FontStyle.Underline), Brushes.Black, marginLeft, marginTop + height)
        height += e.Graphics.MeasureString("1", f).Height

        e.Graphics.DrawLine(Pens.Black, marginLeft, marginTop + height, marginLeft + PrintAreaWidth, marginTop + height)
        height += 25
    End Sub

    Private Function GetFlat(ByVal iBedID As Integer, ByVal h As Hashtable) As Flat
        If h.ContainsKey(iBedID) Then
            Return CType(h.Item(iBedID), Flat)
        End If
        Return New Flat
    End Function

    Private Function AddToFlats(ByVal iBedID As Integer, ByVal f As Flat, ByVal h As Hashtable) As Hashtable
        If h.ContainsKey(iBedID) Then
            h.Item(iBedID) = f
        Else
            h.Add(iBedID, f)
        End If

        Return h
    End Function

    Private Class Flat
        Public m_BedID As Integer
        Public m_Desctiption As String
        Public m_Amount As Double
        Public m_Late As Double
        Public m_CCFee As Double

        Public Sub New()

        End Sub
    End Class

    Private Class Other
        Public m_InvoiceID As Integer
        Public m_Description As String
        Public m_Amount As Double

        Public Sub New()

        End Sub
    End Class
#End Region

#Region " DEBUG "
    Private Sub btnDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebug.Click
        Dim frmDebug As New DebugForm
        frmDebug.Show()
    End Sub
#End Region

    Private Sub tabMain_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabMain.Click
        If tabMain.SelectedTab Is tabResidents Then
            'StartResident()
        ElseIf tabMain.SelectedTab Is tabUsers Then
            StartUsers()
        ElseIf tabMain.SelectedTab Is tabPrint Then
            StartStats()
        ElseIf tabMain.SelectedTab Is tabPrices Then
            StartPriceSets()
        ElseIf tabMain.SelectedTab Is tabRoomsAndBeds Then
            StartRooms()
        End If
    End Sub

    Private Sub btnAbortResident_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAbortResident.Click
        SetResident(CInt(txtID.Text))
        ResidentEnabled(False)
    End Sub

    Private Sub txtRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemove.Click
        'update current resident to status 0
        If MessageBox.Show("Er du sikker på du vil fjerne denne beboer?" & vbNewLine & "(Beboren flyttes over i listen ""annullerede"" men slettes ikke fra systemet)", "Fjern beboer", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            CurrentResident.Status = 0
            CurrentResident.SaveResidentSQL()
            SetResident(0)
            CurrentResident = Nothing
            ResidentEnabled(False)
            ListResidents()
        End If
    End Sub

    Dim dtSelected As DataTable
    Private PageHeight As Integer
    Private NextRow As Integer = 0
    Private PageY As Integer = 0

    Private Sub btnPrintSelectedList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSelectedList.Click
        Dim r As New Elements.Resident
        dtSelected = r.List(WriteSQL).Tables(0)

        NextRow = 0

#If DEBUG Then
        Dim PrintPreviewDialog1 As New PrintPreviewDialog()
        PrintPreviewDialog1.Document = prdListSelected
        If PrintPreviewDialog1.ShowDialog() = DialogResult.OK Then
            prdListSelected.Print()
        End If
#Else
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            prdListSelected.Print()
        End If
#End If
    End Sub

    Private Sub prdListSelected_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prdListSelected.PrintPage
        Dim x As Integer
        Dim w As Integer
        With prdListSelected.DefaultPageSettings
            'PageHeight = .PaperSize.Height - .Margins.Top - .Margins.Bottom
            PageHeight = .PaperSize.Height - 50
            'PageY = .Margins.Top
            PageY = 25
            'x = .Margins.Left
            x = 25
            'w = .PaperSize.Width - .Margins.Left - .Margins.Right
            w = .PaperSize.Width - 50
        End With

        Dim f As New Font("Arial", 10)

        While dtSelected.Rows.Count > NextRow
            If PageY >= PageHeight Then
                e.HasMorePages = True
                Exit While
            End If
            e.Graphics.DrawString(dtSelected.Rows(NextRow)("K_ResidentDisplayMember"), f, Brushes.Black, x, PageY)
            Dim sDates As String = dtSelected.Rows(NextRow)("K_ResidentArrivalDate") & "-" & dtSelected.Rows(NextRow)("K_ResidentDepartureDate")
            e.Graphics.DrawString(sDates, f, Brushes.Black, w - e.Graphics.MeasureString(sDates, f).Width, PageY)
            NextRow += 1
            PageY += (Font.Height * 1.5)
        End While

    End Sub
End Class
