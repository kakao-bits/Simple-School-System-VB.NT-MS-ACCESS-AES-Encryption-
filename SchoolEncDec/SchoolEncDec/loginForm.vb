Public Class loginForm

    Private usrType As Boolean


    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        'Me.Hide()
        'MainMenu.tabGrp.SelectTab(0)
        'MainMenu.Show()
        'txtUsername.Text = ""
        'txtPassword.Text = ""
        lblError.Visible = False
        If usrType Then
            checkDbConn()
            With selectCmd
                .CommandText = "SELECT * from Admin where username = '" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'"
                .Connection = dbConn
            End With
            dbRdr = selectCmd.ExecuteReader
            Try
                If dbRdr.Read Then
                    dbRdr.Close()
                    Me.Hide()
                    teacherPage.Show()
                    'loginButton.Enabled = True
                    lblError.Visible = False
                Else
                    'loginButton.Enabled = False
                    lblError.Visible = True
                End If
            Catch ex As Exception

            End Try
            dbRdr.Close()
            closeDbConn()

        ElseIf usrType = False Then
            checkDbConn()
            With selectCmd
                .CommandText = "SELECT * from students where name = '" & txtUsername.Text & "' and stdcode = '" & txtPassword.Text & "'"
                .Connection = dbConn
            End With
            dbRdr = selectCmd.ExecuteReader
            Try
                If dbRdr.Read Then
                    dbRdr.Close()
                    Me.Hide()
                    showStudentResultForm.Show()
                    'loginButton.Enabled = True
                    lblError.Visible = False
                Else
                    'loginButton.Enabled = False
                    lblError.Visible = True
                End If
            Catch ex As Exception

            End Try
            dbRdr.Close()
            closeDbConn()
        End If


    End Sub

    Private Sub passWord_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        'checkDbConn()
        'With selectCmd
        '    .CommandText = "SELECT * from Admin where username = '" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'"
        '    .Connection = dbConn
        'End With
        'dbRdr = selectCmd.ExecuteReader
        'Try
        '    If dbRdr.Read Then
        '        loginButton.Enabled = True
        '        lblError.Visible = False
        '    Else
        '        loginButton.Enabled = False
        '        lblError.Visible = True
        '    End If
        'Catch ex As Exception

        'End Try
        'dbRdr.Close()
        'closeDbConn()
    End Sub

 
    Private Sub techR_CheckedChanged(sender As Object, e As EventArgs) Handles techR.CheckedChanged
        If techR.Checked Then
            stuR.Checked = False
            usrLbl.Text = "معلم"
            usrType = True
        Else
            stuR.Checked = True
            usrLbl.Text = "طالب"
            usrType = False
        End If
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        stuR.Checked = True
        usrLbl.Text = "طالب"
        usrType = False
        loginButton.Enabled = True
    End Sub
End Class
