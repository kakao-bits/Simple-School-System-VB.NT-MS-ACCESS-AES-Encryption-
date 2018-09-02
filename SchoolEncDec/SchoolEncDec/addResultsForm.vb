Imports System.Security.Cryptography
Public Class addResultsForm
    Dim cel1 As Integer
    Dim cel2 As Integer
    Dim cel3 As Integer
    Dim cel4 As Integer
    Dim cel5 As Integer
    Dim IDx As Integer
    Dim studentCode As String
    Dim studentName As String
    Dim Grade As Integer
    Dim lettergrade As Char
    Dim gradeLabel As String
    Public checkText As String
    Private myKey As String = "x0456663332892"

    Private Sub saveResults_Click(sender As Object, e As EventArgs) Handles saveResults.Click
        calculations()
        Dim totaly As String = Grade.ToString()
        Dim encName As String = AESE(studentName, myKey)
        Dim encSub1 As String = AESE(sub1.Text, myKey)
        Dim encSub2 As String = AESE(sub2.Text, myKey)
        Dim encSub3 As String = AESE(sub3.Text, myKey)
        Dim encSub4 As String = AESE(sub4.Text, myKey)
        Dim encSub5 As String = AESE(sub5.Text, myKey)
        Dim enctotaly As String = AESE(totaly, myKey)
        Dim encgradeLabel As String = AESE(lettergrade, myKey)



        checkText = "INSERT INTO results VALUES('" & IDx & "','" & encName & "', '" & encSub1 & "', '" & _
                                encSub2 & "', '" & encSub3 & "', '" & encSub4 & "', '" & encSub5 & "', '" & enctotaly & "', '" & encgradeLabel & "', '" & studentCode & "')"
        Console.WriteLine(checkText)

        checkDbConn()
        Try
            With insertCmd
                .CommandText = "INSERT INTO results VALUES('" & IDx & "','" & encName & "', '" & encSub1 & "', '" & _
                                encSub2 & "', '" & encSub3 & "', '" & encSub4 & "', '" & encSub5 & "', '" & enctotaly & "', '" & encgradeLabel & "', '" & studentCode & "')"
                Console.WriteLine(insertCmd)
                .Connection = dbConn
                .ExecuteNonQuery()
            End With
            closeDbConn()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        savedLbl.Text = "تم الحفظ بنجاح"
        Me.Close()
    End Sub


    Private Sub addStudentResults_Load(sender As Object, e As EventArgs) Handles Me.Load
        IDx = CInt(teacherPage.tableListView.SelectedItems(0).Text())
        studentName = teacherPage.tableListView.SelectedItems(0).SubItems(1).Text
        studentCode = teacherPage.tableListView.SelectedItems(0).SubItems(5).Text
        Label1.Text = studentName
    End Sub

    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        calculations()
    End Sub

    Private Sub calculations()
        cel1 = CInt(sub1.Text)
        cel2 = CInt(sub2.Text)
        cel3 = CInt(sub3.Text)
        cel4 = CInt(sub4.Text)
        cel5 = CInt(sub5.Text)
        Grade = cel1 + cel2 + cel3 + cel4 + cel5

        total.Text = Grade

        If Grade >= 230 And Grade < 250 Then
            lettergrade = "A"
        ElseIf Grade >= 200 And Grade < 229 Then
            lettergrade = "B"
        ElseIf Grade >= 150 And Grade < 199 Then
            lettergrade = "C"
        ElseIf Grade >= 125 And Grade < 149 Then
            lettergrade = "D"
        Else
            lettergrade = "F"
        End If

        Select Case lettergrade
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
        xtotal.Text = gradeLabel
    End Sub

    Private Function AESE(ByVal plaintext As String, ByVal key As String) As String
        Dim AES As New RijndaelManaged
        Dim SHA256 As New SHA256Cng
        Dim ciphertext As String = ""
        Try
            AES.GenerateIV()
            AES.Key = SHA256.ComputeHash(System.Text.Encoding.ASCII.GetBytes(key))

            AES.Mode = CipherMode.CBC
            Dim DESEncrypter As ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.Encoding.ASCII.GetBytes(plaintext)
            ciphertext = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))

            Return Convert.ToBase64String(AES.IV) & Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))

        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    

End Class