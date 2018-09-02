<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editStudentForm
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
        Me.dateLbl = New System.Windows.Forms.Label()
        Me.studentYear = New System.Windows.Forms.TextBox()
        Me.studentClass = New System.Windows.Forms.TextBox()
        Me.studentName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addStudentB = New System.Windows.Forms.Button()
        Me.tmrDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.savedLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.IdLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dateLbl
        '
        Me.dateLbl.AutoSize = True
        Me.dateLbl.BackColor = System.Drawing.Color.DarkOrange
        Me.dateLbl.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dateLbl.Location = New System.Drawing.Point(45, 25)
        Me.dateLbl.Name = "dateLbl"
        Me.dateLbl.Size = New System.Drawing.Size(49, 17)
        Me.dateLbl.TabIndex = 19
        Me.dateLbl.Text = "التاريخ"
        '
        'studentYear
        '
        Me.studentYear.BackColor = System.Drawing.Color.LightCyan
        Me.studentYear.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.studentYear.Location = New System.Drawing.Point(47, 294)
        Me.studentYear.Name = "studentYear"
        Me.studentYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.studentYear.Size = New System.Drawing.Size(284, 24)
        Me.studentYear.TabIndex = 18
        '
        'studentClass
        '
        Me.studentClass.BackColor = System.Drawing.Color.LightCyan
        Me.studentClass.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.studentClass.Location = New System.Drawing.Point(47, 210)
        Me.studentClass.Name = "studentClass"
        Me.studentClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.studentClass.Size = New System.Drawing.Size(284, 24)
        Me.studentClass.TabIndex = 17
        '
        'studentName
        '
        Me.studentName.BackColor = System.Drawing.Color.LightCyan
        Me.studentName.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.studentName.Location = New System.Drawing.Point(48, 146)
        Me.studentName.Name = "studentName"
        Me.studentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.studentName.Size = New System.Drawing.Size(284, 24)
        Me.studentName.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(225, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "السنة الدراسية"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(285, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "الصف"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(285, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "الأسم"
        '
        'addStudentB
        '
        Me.addStudentB.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.addStudentB.Location = New System.Drawing.Point(151, 392)
        Me.addStudentB.Name = "addStudentB"
        Me.addStudentB.Size = New System.Drawing.Size(75, 28)
        Me.addStudentB.TabIndex = 12
        Me.addStudentB.Text = "حفظ"
        Me.addStudentB.UseVisualStyleBackColor = True
        '
        'savedLbl
        '
        Me.savedLbl.AutoSize = True
        Me.savedLbl.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.savedLbl.ForeColor = System.Drawing.Color.Green
        Me.savedLbl.Location = New System.Drawing.Point(160, 353)
        Me.savedLbl.Name = "savedLbl"
        Me.savedLbl.Size = New System.Drawing.Size(54, 17)
        Me.savedLbl.TabIndex = 23
        Me.savedLbl.Text = "Saving"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(250, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "رقم الطالب"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(284, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "التاريخ"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.DarkOrange
        Me.lblID.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblID.Location = New System.Drawing.Point(45, 73)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(81, 17)
        Me.lblID.TabIndex = 20
        Me.lblID.Text = "رقم الطالب"
        '
        'IdLbl
        '
        Me.IdLbl.AutoSize = True
        Me.IdLbl.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.IdLbl.ForeColor = System.Drawing.Color.Red
        Me.IdLbl.Location = New System.Drawing.Point(188, 73)
        Me.IdLbl.Name = "IdLbl"
        Me.IdLbl.Size = New System.Drawing.Size(25, 17)
        Me.IdLbl.TabIndex = 24
        Me.IdLbl.Text = "ID"
        '
        'editStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 437)
        Me.Controls.Add(Me.IdLbl)
        Me.Controls.Add(Me.dateLbl)
        Me.Controls.Add(Me.studentYear)
        Me.Controls.Add(Me.studentClass)
        Me.Controls.Add(Me.studentName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addStudentB)
        Me.Controls.Add(Me.savedLbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblID)
        Me.Name = "editStudentForm"
        Me.Text = "editStudentForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dateLbl As System.Windows.Forms.Label
    Friend WithEvents studentYear As System.Windows.Forms.TextBox
    Friend WithEvents studentClass As System.Windows.Forms.TextBox
    Friend WithEvents studentName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents addStudentB As System.Windows.Forms.Button
    Friend WithEvents tmrDateTime As System.Windows.Forms.Timer
    Friend WithEvents savedLbl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents IdLbl As System.Windows.Forms.Label
End Class
