Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Module DBAccessModule


    Public dbConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\School.accdb")
    Public selectCmd As New OleDbCommand(dbConn.ConnectionString, dbConn)
    Public insertCmd As New OleDbCommand(dbConn.ConnectionString, dbConn)
    Public deleteCmd As New OleDbCommand(dbConn.ConnectionString, dbConn)
    Public updateCmd As New OleDbCommand(dbConn.ConnectionString, dbConn)
    Public dbRdr As OleDbDataReader
    Public dbAdptr As New OleDbDataAdapter


    Public islstvwDataUpdated As Boolean
    Public islstvwStudentListUpdated As Boolean
    Public islstvwBorrowBookListUpdated As Boolean
    Public islstvwBorrowersListUpdated As Boolean
    Public islstvwReturnBookListUpdated As Boolean
    Public islstvwBooksBorrowedUpdated As Boolean
    Public islstvwReceiptReturnBookListUpdated As Boolean
    'Check Database Connection
    Public Sub checkDbConn()
        If dbConn.State = ConnectionState.Closed Then
            dbConn.Open()
        End If
    End Sub

    'Close Database Connection
    Public Sub closeDbConn()
        If dbConn.State = ConnectionState.Open Then
            dbConn.Close()
            selectCmd.CommandText = ""
            insertCmd.CommandText = ""
            selectCmd.Dispose()
            insertCmd.Dispose()
            deleteCmd.Dispose()
            dbAdptr.Dispose()
        End If
    End Sub


End Module

