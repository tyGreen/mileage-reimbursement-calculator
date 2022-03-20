<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblKmTravLiBx = New System.Windows.Forms.Label()
        Me.libxKmTrav = New System.Windows.Forms.ListBox()
        Me.lblDailyKmTxtBx = New System.Windows.Forms.Label()
        Me.txtbxDailyKm = New System.Windows.Forms.TextBox()
        Me.btnAddDailyKm = New System.Windows.Forms.Button()
        Me.btnInit = New System.Windows.Forms.Button()
        Me.lblTotalKmTravOutput = New System.Windows.Forms.Label()
        Me.lblTotalDaysOutput = New System.Windows.Forms.Label()
        Me.lblTotalReimburseOutput = New System.Windows.Forms.Label()
        Me.lblTotalFlatKmOutput = New System.Windows.Forms.Label()
        Me.lblTotalFlatDaysOutput = New System.Windows.Forms.Label()
        Me.lblTotalFlatReimburseOutput = New System.Windows.Forms.Label()
        Me.lblTotalKmTrav = New System.Windows.Forms.Label()
        Me.lblTotalDays = New System.Windows.Forms.Label()
        Me.lblTotalReimburse = New System.Windows.Forms.Label()
        Me.lblTotalFlatKm = New System.Windows.Forms.Label()
        Me.lblTotalFlatDays = New System.Windows.Forms.Label()
        Me.lblTotalFlatAmount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblKmTravLiBx
        '
        Me.lblKmTravLiBx.AutoSize = True
        Me.lblKmTravLiBx.Location = New System.Drawing.Point(13, 13)
        Me.lblKmTravLiBx.Name = "lblKmTravLiBx"
        Me.lblKmTravLiBx.Size = New System.Drawing.Size(136, 17)
        Me.lblKmTravLiBx.TabIndex = 0
        Me.lblKmTravLiBx.Text = "Enter KMs Travelled"
        '
        'libxKmTrav
        '
        Me.libxKmTrav.FormattingEnabled = True
        Me.libxKmTrav.ItemHeight = 16
        Me.libxKmTrav.Location = New System.Drawing.Point(12, 33)
        Me.libxKmTrav.Name = "libxKmTrav"
        Me.libxKmTrav.Size = New System.Drawing.Size(137, 148)
        Me.libxKmTrav.TabIndex = 1
        '
        'lblDailyKmTxtBx
        '
        Me.lblDailyKmTxtBx.AutoSize = True
        Me.lblDailyKmTxtBx.Location = New System.Drawing.Point(13, 189)
        Me.lblDailyKmTxtBx.Name = "lblDailyKmTxtBx"
        Me.lblDailyKmTxtBx.Size = New System.Drawing.Size(28, 17)
        Me.lblDailyKmTxtBx.TabIndex = 2
        Me.lblDailyKmTxtBx.Text = "KM"
        '
        'txtbxDailyKm
        '
        Me.txtbxDailyKm.Location = New System.Drawing.Point(16, 212)
        Me.txtbxDailyKm.Name = "txtbxDailyKm"
        Me.txtbxDailyKm.Size = New System.Drawing.Size(100, 22)
        Me.txtbxDailyKm.TabIndex = 3
        '
        'btnAddDailyKm
        '
        Me.btnAddDailyKm.Location = New System.Drawing.Point(16, 240)
        Me.btnAddDailyKm.Name = "btnAddDailyKm"
        Me.btnAddDailyKm.Size = New System.Drawing.Size(116, 23)
        Me.btnAddDailyKm.TabIndex = 4
        Me.btnAddDailyKm.Text = "Add Daily KM"
        Me.btnAddDailyKm.UseVisualStyleBackColor = True
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(16, 269)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(116, 23)
        Me.btnInit.TabIndex = 5
        Me.btnInit.Text = "Initialize"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'lblTotalKmTravOutput
        '
        Me.lblTotalKmTravOutput.AutoSize = True
        Me.lblTotalKmTravOutput.Location = New System.Drawing.Point(171, 33)
        Me.lblTotalKmTravOutput.Name = "lblTotalKmTravOutput"
        Me.lblTotalKmTravOutput.Size = New System.Drawing.Size(51, 17)
        Me.lblTotalKmTravOutput.TabIndex = 0
        Me.lblTotalKmTravOutput.Text = "Label1"
        '
        'lblTotalDaysOutput
        '
        Me.lblTotalDaysOutput.AutoSize = True
        Me.lblTotalDaysOutput.Location = New System.Drawing.Point(171, 76)
        Me.lblTotalDaysOutput.Name = "lblTotalDaysOutput"
        Me.lblTotalDaysOutput.Size = New System.Drawing.Size(51, 17)
        Me.lblTotalDaysOutput.TabIndex = 0
        Me.lblTotalDaysOutput.Text = "Label1"
        '
        'lblTotalReimburseOutput
        '
        Me.lblTotalReimburseOutput.AutoSize = True
        Me.lblTotalReimburseOutput.Location = New System.Drawing.Point(171, 120)
        Me.lblTotalReimburseOutput.Name = "lblTotalReimburseOutput"
        Me.lblTotalReimburseOutput.Size = New System.Drawing.Size(51, 17)
        Me.lblTotalReimburseOutput.TabIndex = 0
        Me.lblTotalReimburseOutput.Text = "Label1"
        '
        'lblTotalFlatKmOutput
        '
        Me.lblTotalFlatKmOutput.AutoSize = True
        Me.lblTotalFlatKmOutput.Location = New System.Drawing.Point(171, 163)
        Me.lblTotalFlatKmOutput.Name = "lblTotalFlatKmOutput"
        Me.lblTotalFlatKmOutput.Size = New System.Drawing.Size(51, 17)
        Me.lblTotalFlatKmOutput.TabIndex = 0
        Me.lblTotalFlatKmOutput.Text = "Label1"
        '
        'lblTotalFlatDaysOutput
        '
        Me.lblTotalFlatDaysOutput.AutoSize = True
        Me.lblTotalFlatDaysOutput.Location = New System.Drawing.Point(171, 203)
        Me.lblTotalFlatDaysOutput.Name = "lblTotalFlatDaysOutput"
        Me.lblTotalFlatDaysOutput.Size = New System.Drawing.Size(51, 17)
        Me.lblTotalFlatDaysOutput.TabIndex = 0
        Me.lblTotalFlatDaysOutput.Text = "Label1"
        '
        'lblTotalFlatReimburseOutput
        '
        Me.lblTotalFlatReimburseOutput.AutoSize = True
        Me.lblTotalFlatReimburseOutput.Location = New System.Drawing.Point(171, 246)
        Me.lblTotalFlatReimburseOutput.Name = "lblTotalFlatReimburseOutput"
        Me.lblTotalFlatReimburseOutput.Size = New System.Drawing.Size(51, 17)
        Me.lblTotalFlatReimburseOutput.TabIndex = 0
        Me.lblTotalFlatReimburseOutput.Text = "Label1"
        '
        'lblTotalKmTrav
        '
        Me.lblTotalKmTrav.AutoSize = True
        Me.lblTotalKmTrav.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalKmTrav.Location = New System.Drawing.Point(171, 16)
        Me.lblTotalKmTrav.Name = "lblTotalKmTrav"
        Me.lblTotalKmTrav.Size = New System.Drawing.Size(153, 17)
        Me.lblTotalKmTrav.TabIndex = 0
        Me.lblTotalKmTrav.Text = "Total KMs Travelled"
        '
        'lblTotalDays
        '
        Me.lblTotalDays.AutoSize = True
        Me.lblTotalDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDays.Location = New System.Drawing.Point(171, 59)
        Me.lblTotalDays.Name = "lblTotalDays"
        Me.lblTotalDays.Size = New System.Drawing.Size(86, 17)
        Me.lblTotalDays.TabIndex = 0
        Me.lblTotalDays.Text = "Total Days"
        '
        'lblTotalReimburse
        '
        Me.lblTotalReimburse.AutoSize = True
        Me.lblTotalReimburse.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalReimburse.Location = New System.Drawing.Point(171, 103)
        Me.lblTotalReimburse.Name = "lblTotalReimburse"
        Me.lblTotalReimburse.Size = New System.Drawing.Size(247, 17)
        Me.lblTotalReimburse.TabIndex = 0
        Me.lblTotalReimburse.Text = "Total Reimbursement Amount ($)"
        '
        'lblTotalFlatKm
        '
        Me.lblTotalFlatKm.AutoSize = True
        Me.lblTotalFlatKm.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFlatKm.Location = New System.Drawing.Point(171, 146)
        Me.lblTotalFlatKm.Name = "lblTotalFlatKm"
        Me.lblTotalFlatKm.Size = New System.Drawing.Size(224, 17)
        Me.lblTotalFlatKm.TabIndex = 0
        Me.lblTotalFlatKm.Text = "Total Flat Rate KMs Travelled"
        '
        'lblTotalFlatDays
        '
        Me.lblTotalFlatDays.AutoSize = True
        Me.lblTotalFlatDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFlatDays.Location = New System.Drawing.Point(171, 189)
        Me.lblTotalFlatDays.Name = "lblTotalFlatDays"
        Me.lblTotalFlatDays.Size = New System.Drawing.Size(157, 17)
        Me.lblTotalFlatDays.TabIndex = 0
        Me.lblTotalFlatDays.Text = "Total Flat Rate Days"
        '
        'lblTotalFlatAmount
        '
        Me.lblTotalFlatAmount.AutoSize = True
        Me.lblTotalFlatAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFlatAmount.Location = New System.Drawing.Point(171, 229)
        Me.lblTotalFlatAmount.Name = "lblTotalFlatAmount"
        Me.lblTotalFlatAmount.Size = New System.Drawing.Size(201, 17)
        Me.lblTotalFlatAmount.TabIndex = 0
        Me.lblTotalFlatAmount.Text = "Total Flat Rate Amount ($)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 333)
        Me.Controls.Add(Me.btnInit)
        Me.Controls.Add(Me.btnAddDailyKm)
        Me.Controls.Add(Me.txtbxDailyKm)
        Me.Controls.Add(Me.lblDailyKmTxtBx)
        Me.Controls.Add(Me.libxKmTrav)
        Me.Controls.Add(Me.lblTotalFlatReimburseOutput)
        Me.Controls.Add(Me.lblTotalFlatDaysOutput)
        Me.Controls.Add(Me.lblTotalFlatKmOutput)
        Me.Controls.Add(Me.lblTotalReimburseOutput)
        Me.Controls.Add(Me.lblTotalDaysOutput)
        Me.Controls.Add(Me.lblTotalFlatAmount)
        Me.Controls.Add(Me.lblTotalFlatDays)
        Me.Controls.Add(Me.lblTotalFlatKm)
        Me.Controls.Add(Me.lblTotalReimburse)
        Me.Controls.Add(Me.lblTotalDays)
        Me.Controls.Add(Me.lblTotalKmTrav)
        Me.Controls.Add(Me.lblTotalKmTravOutput)
        Me.Controls.Add(Me.lblKmTravLiBx)
        Me.Name = "Form1"
        Me.Text = "KM Tracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblKmTravLiBx As Label
    Friend WithEvents libxKmTrav As ListBox
    Friend WithEvents lblDailyKmTxtBx As Label
    Friend WithEvents txtbxDailyKm As TextBox
    Friend WithEvents btnAddDailyKm As Button
    Friend WithEvents btnInit As Button
    Friend WithEvents lblTotalKmTravOutput As Label
    Friend WithEvents lblTotalDaysOutput As Label
    Friend WithEvents lblTotalReimburseOutput As Label
    Friend WithEvents lblTotalFlatKmOutput As Label
    Friend WithEvents lblTotalFlatDaysOutput As Label
    Friend WithEvents lblTotalFlatReimburseOutput As Label
    Friend WithEvents lblTotalKmTrav As Label
    Friend WithEvents lblTotalDays As Label
    Friend WithEvents lblTotalReimburse As Label
    Friend WithEvents lblTotalFlatKm As Label
    Friend WithEvents lblTotalFlatDays As Label
    Friend WithEvents lblTotalFlatAmount As Label
End Class
