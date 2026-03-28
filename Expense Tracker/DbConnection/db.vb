Imports System.Data.SqlClient

Imports Microsoft.Data.SqlClient

Public Class db
    Dim conn As SqlConnection
    Public Function OpenConn()
        If conn Is Nothing Then
            conn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\ar464\OneDrive\Documents\Expense Tracker.mdf';Integrated Security=True;Connect Timeout=30;Encrypt=True")
        End If

        'If conn.State = ConnectionState.Closed Then
        'End If
        conn.Open()
        Return conn
    End Function

    Public Sub CloseConnection()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

End Class
