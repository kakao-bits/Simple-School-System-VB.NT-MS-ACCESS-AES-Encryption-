
Public Class addStudentForm
    Public stdntIDstr As String
    Public newStdntIDstr As String
    Public newStdntDatestr As String
    Public stdntIDnum As Integer
    Public checkText As String
    
    Private Sub addStudent_Load(sender As Object, e As EventArgs) Handles Me.Load
        savedLbl.Visible = False
        tmrDateTime.Enabled = True
        tmrDateTime.Start()
        Try
            checkDbConn()
            'lblID.Text = "STDN00000"
            With selectCmd
                .CommandText = "SELECT MAX(ID) from students"
                .Connection = dbConn
            End With
            dbRdr = selectCmd.ExecuteReader
            Try
                If dbRdr.Read Then
                    stdntIDstr = dbRdr.GetValue(0).ToString
                    Console.WriteLine(stdntIDstr)
                    stdntIDnum = CInt(stdntIDstr)
                    stdntIDnum += 1
                    If stdntIDnum < 100000 Then
                        newStdntIDstr = "STDN0000" & stdntIDnum.ToString
                        lblID.Text = newStdntIDstr
                    End If
                Else
                    lblID.Text = "STDN00000"
                End If
            Catch ex As Exception

            End Try
            dbRdr.Close()
            closeDbConn()
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try

        
    End Sub

    Private Sub addStudentB_Click(sender As Object, e As EventArgs) Handles addStudentB.Click
        savedLbl.Visible = True
        checkText = "INSERT INTO students(ID,name,class,year,register,stdcode)" & _
                           " VALUES('" & stdntIDnum & "','" & studentName.Text & "', '" & studentClass.Text & "', '" & _
                            studentYear.Text & "', '" & dateLbl.Text & "', '" & lblID.Text & ")"
        Console.WriteLine(checkText)
        checkDbConn()
        Try
            With insertCmd
                .CommandText = "INSERT INTO students VALUES('" & stdntIDnum & "','" & studentName.Text & "', '" & studentClass.Text & "', '" & _
                                studentYear.Text & "', '" & dateLbl.Text & "', '" & lblID.Text & "')"
                Console.WriteLine(insertCmd)
                .Connection = dbConn
                .ExecuteNonQuery()
            End With
            closeDbConn()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try


        islstvwDataUpdated = True
        savedLbl.Text = "تم الحفظ بنجاح"
        studentName.Text = ""
        studentClass.Text = ""
        studentYear.Text = ""
        teacherPage.loadDataListView()
        Me.Close()
    End Sub

    Private Sub tmrDateTime_Tick(sender As Object, e As EventArgs) Handles tmrDateTime.Tick
        newStdntDatestr = Date.Now.ToString("dd-MM-yyyy")
        dateLbl.Text = newStdntDatestr
    End Sub

End Class