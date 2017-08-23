Public Class K_Booking_Login
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
    Friend WithEvents lbxUsers As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(K_Booking_Login))
        Me.lbxUsers = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lbxUsers
        '
        Me.lbxUsers.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.lbxUsers.Location = New System.Drawing.Point(24, 120)
        Me.lbxUsers.Name = "lbxUsers"
        Me.lbxUsers.Size = New System.Drawing.Size(248, 108)
        Me.lbxUsers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Velkommen til Dansk KFUK i London"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 80)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "For at benytte K-booking skal du vælge dit navn i listen herunder. Finder du ikke" & _
        " dit navn skal du først oprettes i systemet af en eksisterende bruger."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(160, 240)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Luk systemet"
        '
        'K_Booking_Login
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(296, 278)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbxUsers)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "K_Booking_Login"
        Me.Text = "Dansk KFUK - login"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mObjMain As K.Booking.K_Booking_Main

    Public Property FormMain() As K.Booking.K_Booking_Main
        Get
            Return mObjMain
        End Get
        Set(ByVal Value As K.Booking.K_Booking_Main)
            mObjMain = Value
        End Set
    End Property

    Private Sub lbxUsers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbxUsers.Click
        Login()
    End Sub

    Private Sub Login()
        Dim u As New Elements.User(CInt(lbxUsers.SelectedValue))
        mObjMain.LoggedInUserFullName = u.FullName
        mObjMain.LoggedInUser_ID = u.ID

        u = Nothing

        mObjMain.Welcome()
        Me.Close()
    End Sub

    Private Sub lbxUsers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lbxUsers.KeyDown
        If e.KeyValue = 13 Then 'enter 
            Login()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        mObjMain.Close()
    End Sub

    Private Sub K_Booking_Login_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If mObjMain.LoggedInUser_ID < 1 Then
            mObjMain.Close()
        End If
    End Sub

    Private Sub K_Booking_Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strSQL As String

        Dim u As New Elements.User

        strSQL = "SELECT K_UserID, K_UserFullname " &
        "FROM K_User " &
        "WHERE K_UserActive = true"

        Dim ds As DataSet = u.List(strSQL)

        If Not ds Is Nothing AndAlso ds.Tables.Count > 0 Then
            lbxUsers.DataSource = ds.Tables(0).DefaultView

            lbxUsers.ValueMember = "K_UserID"
            lbxUsers.DisplayMember = "K_UserFullname"
        Else
            Dim result As DialogResult = MessageBox.Show("Booking systemet kan ikke kontakte databasen og lukker nu. Du kan opdatere config filen med databasens navn, bruger og password og prøve igen.")
            If result = DialogResult.OK Then
                mObjMain.Close()
            End If
        End If

        u = Nothing
    End Sub
End Class
