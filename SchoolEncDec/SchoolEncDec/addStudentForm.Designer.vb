<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStudentForm
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
        Me.components = New System.ComponentModel.Container()
        Me.addStudentB = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.studentName = New System.Windows.Forms.TextBox()
        Me.studentClass = New System.Windows.Forms.TextBox()
        Me.studentYear = New System.Windows.Forms.TextBox()
        Me.dateLbl = New System.Windows.Forms.Label()
        Me.tmrDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.savedLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'addStudentB
        '
        Me.addStudentB.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.addStudentB.Location = New System.Drawing.Point(134, 397)
        Me.addStudentB.Name = "addStudentB"
        Me.addStudentB.Size = New System.Drawing.Size(75, 28)
        Me.addStudentB.TabIndex = 0
        Me.addStudentB.Text = "حفظ"
        Me.addStudentB.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(268, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "الأسم"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(268, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "الصف"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(208, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "السنة الدراسية"
        '
        'studentName
        '
        Me.studentName.BackColor = System.Drawing.Color.LightCyan
        Me.studentName.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.studentName.Location = New System.Drawing.Point(31, 151)
        Me.studentName.Name = "studentName"
        Me.studentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.studentName.Size = New System.Drawing.Size(284, 24)
        Me.studentName.TabIndex = 4
        '
        'studentClass
        '
        Me.studentClass.BackColor = System.Drawing.Color.LightCyan
        Me.studentClass.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.studentClass.Location = New System.Drawing.Point(30, 215)
        Me.studentClass.Name = "studentClass"
        Me.studentClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.studentClass.Size = New System.Drawing.Size(284, 24)
        Me.studentClass.TabIndex = 5
        '
        'studentYear
        '
        Me.studentYear.BackColor = System.Drawing.Color.LightCyan
        Me.studentYear.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.studentYear.Location = New System.Drawing.Point(30, 299)
        Me.studentYear.Name = "studentYear"
        Me.studentYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.studentYear.Size = New System.Drawing.Size(284, 24)
        Me.studentYear.TabIndex = 6
        '
        'dateLbl
        '
        Me.dateLbl.AutoSize = True
        Me.dateLbl.BackColor = System.Drawing.Color.DarkOrange
        Me.dateLbl.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dateLbl.Location = New System.Drawing.Point(28, 30)
        Me.dateLbl.Name = "dateLbl"
        Me.dateLbl.Size = New System.Drawing.Size(49, 17)
        Me.dateLbl.TabIndex = 7
        Me.dateLbl.Text = "التاريخ"
        '
        'tmrDateTime
        '
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.DarkOrange
        Me.lblID.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblID.Location = New System.Drawing.Point(28, 78)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(81, 17)
        Me.lblID.TabIndex = 8
        Me.lblID.Text = "رقم الطالب"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(267, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "التاريخ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(233, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "رقم الطالب"
        '
        'savedLbl
        '
        Me.savedLbl.AutoSize = True
        Me.savedLbl.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.savedLbl.ForeColor = System.Drawing.Color.Green
        Me.savedLbl.Location = New System.Drawing.Point(143, 358)
        Me.savedLbl.Name = "savedLbl"
        Me.savedLbl.Size = New System.Drawing.Size(54, 17)
        Me.savedLbl.TabIndex = 11
        Me.savedLbl.Text = "Saving"
        '
        'addStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 437)
        Me.Controls.Add(Me.savedLbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.dateLbl)
        Me.Controls.Add(Me.studentYear)
        Me.Controls.Add(Me.studentClass)
        Me.Controls.Add(Me.studentName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addStudentB)
        Me.Name = "addStudentForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents addStudentB As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents studentName As System.Windows.Forms.TextBox
    Friend WithEvents studentClass As System.Windows.Forms.TextBox
    Friend WithEvents studentYear As System.Windows.Forms.TextBox
    Friend WithEvents dateLbl As System.Windows.Forms.Label
    Friend WithEvents tmrDateTime As System.Windows.Forms.Timer
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents savedLbl As System.Windows.Forms.Label
End Class
