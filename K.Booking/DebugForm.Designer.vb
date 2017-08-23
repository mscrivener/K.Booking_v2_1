<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DebugForm
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
        Me.btnPrices = New System.Windows.Forms.Button
        Me.lblPrices = New System.Windows.Forms.Label
        Me.btnResidentTypeList = New System.Windows.Forms.Button
        Me.btnDeleteStats = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnPrices
        '
        Me.btnPrices.Location = New System.Drawing.Point(12, 12)
        Me.btnPrices.Name = "btnPrices"
        Me.btnPrices.Size = New System.Drawing.Size(145, 23)
        Me.btnPrices.TabIndex = 0
        Me.btnPrices.Text = "Udskriv gyldigt prissaet"
        Me.btnPrices.UseVisualStyleBackColor = True
        '
        'lblPrices
        '
        Me.lblPrices.AutoSize = True
        Me.lblPrices.Location = New System.Drawing.Point(163, 17)
        Me.lblPrices.Name = "lblPrices"
        Me.lblPrices.Size = New System.Drawing.Size(0, 13)
        Me.lblPrices.TabIndex = 1
        '
        'btnResidentTypeList
        '
        Me.btnResidentTypeList.Location = New System.Drawing.Point(13, 42)
        Me.btnResidentTypeList.Name = "btnResidentTypeList"
        Me.btnResidentTypeList.Size = New System.Drawing.Size(144, 23)
        Me.btnResidentTypeList.TabIndex = 2
        Me.btnResidentTypeList.Text = "Beboer type"
        Me.btnResidentTypeList.UseVisualStyleBackColor = True
        '
        'btnDeleteStats
        '
        Me.btnDeleteStats.Location = New System.Drawing.Point(13, 72)
        Me.btnDeleteStats.Name = "btnDeleteStats"
        Me.btnDeleteStats.Size = New System.Drawing.Size(144, 23)
        Me.btnDeleteStats.TabIndex = 3
        Me.btnDeleteStats.Text = "Slet statistik"
        Me.btnDeleteStats.UseVisualStyleBackColor = True
        '
        'DebugForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 387)
        Me.Controls.Add(Me.btnDeleteStats)
        Me.Controls.Add(Me.btnResidentTypeList)
        Me.Controls.Add(Me.lblPrices)
        Me.Controls.Add(Me.btnPrices)
        Me.Name = "DebugForm"
        Me.Text = "DebugForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrices As System.Windows.Forms.Button
    Friend WithEvents lblPrices As System.Windows.Forms.Label
    Friend WithEvents btnResidentTypeList As System.Windows.Forms.Button
    Friend WithEvents btnDeleteStats As System.Windows.Forms.Button
End Class
