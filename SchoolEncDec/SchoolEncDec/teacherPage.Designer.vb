<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class teacherPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(teacherPage))
        Me.tableListView = New System.Windows.Forms.ListView()
        Me.addStudent = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.editStudentB = New System.Windows.Forms.Button()
        Me.deleteStudentB = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableListView
        '
        Me.tableListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.tableListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tableListView.GridLines = True
        Me.tableListView.HotTracking = True
        Me.tableListView.HoverSelection = True
        Me.tableListView.Location = New System.Drawing.Point(27, 119)
        Me.tableListView.Name = "tableListView"
        Me.tableListView.RightToLeftLayout = True
        Me.tableListView.Size = New System.Drawing.Size(854, 274)
        Me.tableListView.TabIndex = 0
        Me.tableListView.UseCompatibleStateImageBehavior = False
        '
        'addStudent
        '
        Me.addStudent.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.addStudent.ForeColor = System.Drawing.Color.Blue
        Me.addStudent.Location = New System.Drawing.Point(763, 32)
        Me.addStudent.Name = "addStudent"
        Me.addStudent.Size = New System.Drawing.Size(118, 35)
        Me.addStudent.TabIndex = 1
        Me.addStudent.Text = "أضافة طالب"
        Me.addStudent.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = Global.SchoolEncDec.My.Resources.Resources.refresh_icon_hi
        Me.PictureBox1.InitialImage = Global.SchoolEncDec.My.Resources.Resources.refresh_icon_hi
        Me.PictureBox1.Location = New System.Drawing.Point(847, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'editStudentB
        '
        Me.editStudentB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.editStudentB.ForeColor = System.Drawing.Color.Blue
        Me.editStudentB.Location = New System.Drawing.Point(584, 32)
        Me.editStudentB.Name = "editStudentB"
        Me.editStudentB.Size = New System.Drawing.Size(118, 35)
        Me.editStudentB.TabIndex = 3
        Me.editStudentB.Text = "تعديل طالب"
        Me.editStudentB.UseVisualStyleBackColor = True
        '
        'deleteStudentB
        '
        Me.deleteStudentB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.deleteStudentB.ForeColor = System.Drawing.Color.Blue
        Me.deleteStudentB.Location = New System.Drawing.Point(396, 32)
        Me.deleteStudentB.Name = "deleteStudentB"
        Me.deleteStudentB.Size = New System.Drawing.Size(118, 35)
        Me.deleteStudentB.TabIndex = 4
        Me.deleteStudentB.Text = "مسح طالب"
        Me.deleteStudentB.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(217, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 35)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "أدخال النتيجة"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.Blue
        Me.Button4.Location = New System.Drawing.Point(29, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 35)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "عرض النتيجة"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'teacherPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(907, 405)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.deleteStudentB)
        Me.Controls.Add(Me.editStudentB)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.addStudent)
        Me.Controls.Add(Me.tableListView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "teacherPage"
        Me.Text = "لوحة تحكم المعلم"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableListView As System.Windows.Forms.ListView
    Friend WithEvents addStudent As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents editStudentB As System.Windows.Forms.Button
    Friend WithEvents deleteStudentB As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
