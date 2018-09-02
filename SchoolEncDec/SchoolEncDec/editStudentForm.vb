Imports System.Data.OleDb

Public Class editStudentForm
    Public checkText As String
    Private myqry As String
    Private Cmd As OleDbCommand

    Private Sub addStudentB_Click(sender As Object, e As EventArgs) Handles addStudentB.Click
        checkDbConn()
        Dim IDx As Integer = CInt(IdLbl.Text)

        savedLbl.Visible = True
        checkText = "UPDATE students SET name='" & studentName.Text & _
                            "', class='" & studentClass.Text & "', year='" & studentYear.Text & _
                            "', register='" & dateLbl.Text & _
                            "' WHERE stdcode='" & lblID.Text & "'"
        Console.WriteLine(checkText)
        Try
            myqry = "UPDATE students SET name=@p1, class=@p2, classyear=@p3 WHERE [ID]=@p4"
            Cmd = New OleDbCommand(myqry, dbConn)
            Cmd.Parameters.AddWithValue("@p1", studentName.Text)
            Cmd.Parameters.AddWithValue("@p2", studentClass.Text)
            Cmd.Parameters.AddWithValue("@p3", studentYear.Text)
            Cmd.Parameters.AddWithValue("@p4", [IDx])
            Cmd.ExecuteNonQuery()
            'With updateCmd
            '    .CommandText = "UPDATE students SET name='" & studentName.Text & _
            '               "', [class]='" & studentClass.Text & "', year='" & studentYear.Text & _
            '              "', register='" & dateLbl.Text & _
            '             "' WHERE stdcode='" & lblID.Text & "'"
            '    .Connection = dbConn
            '    .ExecuteNonQuery()
            'End With
            closeDbConn()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Console.WriteLine(ex.Message)
        End Try
        islstvwDataUpdated = True
        savedLbl.Text = "تم التعديل بنجاح"
        studentName.Text = ""
        studentClass.Text = ""
        studentYear.Text = ""
        teacherPage.loadDataListView()
        Me.Close()
    End Sub
    Private Sub editStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        savedLbl.Visible = False
        IdLbl.Text = teacherPage.tableListView.SelectedItems(0).Text()
        studentName.Text = teacherPage.tableListView.SelectedItems(0).SubItems(1).Text
        studentClass.Text = teacherPage.tableListView.SelectedItems(0).SubItems(2).Text
        studentYear.Text = teacherPage.tableListView.SelectedItems(0).SubItems(3).Text
        dateLbl.Text = teacherPage.tableListView.SelectedItems(0).SubItems(4).Text
        lblID.Text = teacherPage.tableListView.SelectedItems(0).SubItems(5).Text
    End Sub
End Class