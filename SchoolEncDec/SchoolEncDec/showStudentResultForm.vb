Imports System.Security.Cryptography
Public Class showStudentResultForm

    Private myKey As String = "x0456663332892"
    Dim IDx As Integer
    
    Dim gradeLabel As String

    Private Function AESD(ByVal ciphertext As String, ByVal key As String) As String
        Dim AES As New RijndaelManaged
        Dim SHA256 As New SHA256Cng
        Dim plaintext As String = ""
        Dim iv As String = ""
        Try
            Dim ivct = ciphertext.Split({"=="}, StringSplitOptions.None)
            iv = ivct(0) & "=="
            ciphertext = If(ivct.Length = 3, ivct(1) & "==", ivct(1))

            AES.Key = SHA256.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(key))
            AES.IV = Convert.FromBase64String(iv)
            AES.Mode = CipherMode.CBC
            Dim DESDecrypter As ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(ciphertext)
            plaintext = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return plaintext
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Sub showResultsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'IDx = CInt(teacherPage.tableListView.SelectedItems(0).Text())
        'studentName = teacherPage.tableListView.SelectedItems(0).SubItems(1).Text
        'studentCode = teacherPage.tableListView.SelectedItems(0).SubItems(5).Text
        Dim studentCode As String = loginForm.txtPassword.Text
        Dim studentName As String = loginForm.txtUsername.Text
        IDx = CInt(studentCode.Substring(4, 5))
        Console.WriteLine(IDx)
        Label1.Text = studentName
        Try
            checkDbConn()
            With selectCmd
                .CommandText = "SELECT * FROM [results] WHERE ID =" & IDx
                .Connection = dbConn
            End With
            dbRdr = selectCmd.ExecuteReader
            Try
                If dbRdr.Read Then
                    Dim val1 As String = dbRdr.GetValue(0).ToString
                    Dim val2 As String = dbRdr.GetValue(1).ToString
                    Dim val3 As String = dbRdr.GetValue(2).ToString
                    Dim val4 As String = dbRdr.GetValue(3).ToString
                    Dim val5 As String = dbRdr.GetValue(4).ToString
                    Dim val6 As String = dbRdr.GetValue(5).ToString
                    Dim val7 As String = dbRdr.GetValue(6).ToString
                    Dim val8 As String = dbRdr.GetValue(7).ToString
                    Dim val9 As String = dbRdr.GetValue(8).ToString

                    'Console.WriteLine(AESD(val2, myKey))
                    'Console.WriteLine(AESD(val3, myKey))
                    'Console.WriteLine(AESD(val4, myKey))
                    'Console.WriteLine(AESD(val5, myKey))
                    'Console.WriteLine(AESD(val6, myKey))
                    'Console.WriteLine(AESD(val7, myKey))
                    'Console.WriteLine(AESD(val8, myKey))
                    'Console.WriteLine(AESD(val9, myKey))
                    Dim decName As String = AESD(val2, myKey)
                    Dim decSub1 As String = AESD(val3, myKey)
                    Dim decSub2 As String = AESD(val4, myKey)
                    Dim decSub3 As String = AESD(val5, myKey)
                    Dim decSub4 As String = AESD(val6, myKey)
                    Dim decSub5 As String = AESD(val7, myKey)
                    Dim dectotaly As String = AESD(val8, myKey)
                    Dim decgradeLabel As String = AESD(val9, myKey)

                    Select Case decgradeLabel
                        Case "A"
                            gradeLabel = "ممتاز"
                            Console.WriteLine("ممتاز")
                        Case "B"
                            Console.WriteLine("جيد جداً")
                            gradeLabel = "جيد جداً"
                        Case "C"
                            Console.WriteLine("جيد")
                            gradeLabel = "جيد"
                        Case "D"
                            Console.WriteLine("مقبول")
                            gradeLabel = "مقبول"
                        Case Else
                            Console.WriteLine("راسب")
                            gradeLabel = "راسب"
                    End Select
                    sub1.Text = decSub1
                    sub2.Text = decSub2
                    sub3.Text = decSub3
                    sub4.Text = decSub4
                    sub5.Text = decSub5
                    total.Text = dectotaly
                    xtotal.Text = gradeLabel

                Else
                    MessageBox.Show("Worng Selection")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
            dbRdr.Close()
            closeDbConn()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        
    End Sub
End Class