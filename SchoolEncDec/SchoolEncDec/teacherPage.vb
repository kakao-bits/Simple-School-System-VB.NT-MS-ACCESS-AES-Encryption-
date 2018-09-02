Public Class teacherPage
    Public dataQuery As String
    Public Sub dataLoad()
        islstvwDataUpdated = True
        dataQuery = "SELECT * FROM students ORDER BY ID ASC"
        loadDataListView()
    End Sub

    'LOAD STUDENTS LIST VIEW
    Public Sub loadDataListView()
        If islstvwDataUpdated = True Then
            checkDbConn()
            tableListView.MultiSelect = False
            tableListView.GridLines = True
            tableListView.FullRowSelect = True
            tableListView.View = View.Details
            tableListView.Items.Clear()
            tableListView.Clear()

            tableListView.Columns.Add("رقم الطالب", 100, HorizontalAlignment.Left)
            tableListView.Columns.Add("أسم الطالب", 200, HorizontalAlignment.Left)
            tableListView.Columns.Add("الصف", 150, HorizontalAlignment.Left)
            tableListView.Columns.Add("السنة الدراسية", 150, HorizontalAlignment.Left)
            tableListView.Columns.Add("تاريخ التسجيل", 130, HorizontalAlignment.Left)
            tableListView.Columns.Add("الرقم الدراسي", 130, HorizontalAlignment.Left)

            With selectCmd
                .CommandText = dataQuery
            End With
            Dim dbTbl As New DataTable
            dbTbl.TableName = "students"

            With dbAdptr
                .SelectCommand = selectCmd
                .SelectCommand.Connection = dbConn
                .Fill(dbTbl)
            End With

            For i = 0 To dbTbl.Rows.Count - 1
                With tableListView
                    .Items.Add(dbTbl.Rows(i)("ID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(dbTbl.Rows(i)("name"))
                        .Add(dbTbl.Rows(i)("class"))
                        .Add(dbTbl.Rows(i)("classyear"))
                        .Add(dbTbl.Rows(i)("register"))
                        .Add(dbTbl.Rows(i)("stdcode"))
                    End With
                End With
            Next
        End If
        closeDbConn()
        islstvwDataUpdated = False
    End Sub

    Private Sub teacherPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        dataLoad()
    End Sub

    Private Sub addStudent_Click(sender As Object, e As EventArgs) Handles addStudent.Click
        addStudentForm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        loadDataListView()
    End Sub

    
    'DISABLE ENABLE THE EDIT AND DELETE BUTTON
    Private Sub tableListView_LostFocus(sender As Object, e As EventArgs) Handles tableListView.LostFocus
        If deleteStudentB.Focused Or editStudentB.Focused Then
        Else
            deleteStudentB.Enabled = False
            editStudentB.Enabled = False
        End If
    End Sub

    Private Sub tableListView_MouseClick(sender As Object, e As MouseEventArgs) Handles tableListView.MouseClick
        If Val(tableListView.SelectedItems(0).SubItems(1).Text) > 0 Then
            If Val(tableListView.SelectedItems(0).SubItems(1).Text) > 0 Then
                deleteStudentB.Enabled = False
            Else
                deleteStudentB.Enabled = True
            End If
        End If
        editStudentB.Enabled = True
    End Sub

    Private Sub tableListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tableListView.SelectedIndexChanged
        If tableListView.SelectedItems.Count > 0 Then
            If Val(tableListView.SelectedItems(0).SubItems(1).Text) > 0 Then
                deleteStudentB.Enabled = False
            Else
                deleteStudentB.Enabled = True
            End If
        End If
        editStudentB.Enabled = True
    End Sub

    Private Sub editStudentB_Click(sender As Object, e As EventArgs) Handles editStudentB.Click
        If tableListView.Items.Count > 0 Then
            editStudentForm.Show()
            editStudentB.Enabled = False
            deleteStudentB.Enabled = False
        Else
            MessageBox.Show("No selected member")
        End If
        editStudentB.Enabled = False

    End Sub

    Private Sub deleteStudentB_Click(sender As Object, e As EventArgs) Handles deleteStudentB.Click
        If tableListView.SelectedItems.Count > 0 Then
            Dim result As Integer = MessageBox.Show("ستقوم بمسح الطالب", "المسح", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                'MessageBox.Show("Cancel pressed")
            ElseIf result = DialogResult.No Then
                'MessageBox.Show("No pressed")
            ElseIf result = DialogResult.Yes Then
                Dim IDx As Integer = CInt(tableListView.SelectedItems(0).Text)
                checkDbConn()
                With deleteCmd
                    .CommandText = "DELETE FROM students WHERE ID =" & IDx
                    .Connection = dbConn
                    .ExecuteNonQuery()
                End With
                closeDbConn()
                islstvwDataUpdated = True
                loadDataListView()
            End If    
        Else
            MessageBox.Show("No selected member")
        End If
        deleteStudentB.Enabled = False
        editStudentB.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If tableListView.Items.Count > 0 Then
            addResultsForm.Show()
            editStudentB.Enabled = False
            deleteStudentB.Enabled = False
        Else
            MessageBox.Show("No selected member")
        End If
        editStudentB.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If tableListView.Items.Count > 0 Then
            showResultsForm.Show()
            editStudentB.Enabled = False
            deleteStudentB.Enabled = False
        Else
            MessageBox.Show("No selected member")
        End If
        editStudentB.Enabled = False
    End Sub
End Class