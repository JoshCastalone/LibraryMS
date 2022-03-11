Imports MySql.Data.MySqlClient
Module CRUD
    Public Function strstrconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=BananaF1Sh;database=test3;persistsecurityinfo=True;port=3306")
    End Function
    Public strcon As MySqlConnection = strstrconnection()
    'DECLARING CLASSES AND VARIABLE
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public inc As Integer = 0
    Public maxrows As Integer
    Public sql As String


    'THIS METHOD IS FOR INSERTING DATA IN THE DATABASE
    Public Sub create(ByVal sql As String)
        Try
            strcon.Open()
            'HOLDS THE DATA TO BE EXECUTED
            With cmd
                .Connection = strcon
                .CommandText = sql
                'EXECUTE THE DATA
                result = cmd.ExecuteNonQuery
                'CHECKING IF THE DATA HAS EXECUTED OR NOT AND THEN THE POP UP MESSAGE WILL APPEAR
                If result = 0 Then
                    MsgBox("FAILED TO SAVE THE DATA", MsgBoxStyle.Information)
                Else
                    MsgBox("DATA HAS BEEN SAVED IN THE DATABASE")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strcon.Close()
    End Sub
    'THIS METHOD IS FOR RETRIEVING DATA IN THE DATABASE
    Public Sub reload(ByVal sql As String, ByVal dtgSelections As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            dtgSelections.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strcon.Close()
        da.Dispose()
    End Sub
    'THIS METHOD IS FOR UPDATING THE DATA IN THE DATABASE.
    Public Sub updates(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("DATA IS FAILED TO UPPDATE.", MsgBoxStyle.Information)
                Else
                    MsgBox("THE DATA HAS BEEN UPDATED IN THE DATABASE.")
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strcon.Close()
    End Sub
    'THIS METHOD IS FOR DELETING THE DATA IN THE DATABASE
    Public Sub delete(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("FAILED TO DELETE THE DATA IN THE DATABASE.", MsgBoxStyle.Critical)
                Else
                    MsgBox("DATA HAS BEEN DELETED IN THE DATABASE.")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strcon.Close()
    End Sub
    Public Sub select_navigation(ByVal sql As String)
        Try
            Try
                strcon.Open()
                With cmd
                    .Connection = strcon
                    .CommandText = sql
                End With
                dt = New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)
                maxrows = dt.Rows.Count
            Catch ex As Exception
                MsgBox(ex.Message & "select_navigation")
            End Try

            strcon.Close()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Module
