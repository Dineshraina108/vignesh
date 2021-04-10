Imports Oracle.DataAccess.Client
Public Class login
    Dim ora_con As New OracleConnection
    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        Dim usdt As New DataTable
        Dim query As String
        ora_con.Open()
        query = "SELECT * FROM Dcureg WHERE USERNAME='" & txtuname.Text & "' AND PASSWORD='" & txtpw.Text & "'"
        Using cmd As New OracleCommand(query, ora_con)
            Using ora_ada As New OracleDataAdapter(cmd)
                ora_ada.Fill(usdt)
            End Using
        End Using
        Try
            If usdt.Rows.Count > 0 Then
                'MsgBox("ok")
                Form1.Show()
                Me.Hide()
            Else
                MsgBox("iNVALID USERNAME OR PASSWORD")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        ora_con.Close()
    End Sub

    Private Sub txtuname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuname.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dt As New DataTable
            Dim query As String
            Try
                If e.KeyCode = Keys.Enter Then
                    If txtuname.Text <> "" Then
                        query = "SELECT arole FROM dcUREG WHERE USERNAME='" & txtuname.Text & "'"
                        Using cmd As New OracleCommand(query, ora_con)
                            Using ora_ada As New OracleDataAdapter(cmd)
                                ora_ada.Fill(dt)
                            End Using
                        End Using
                        If dt.Rows(0)("arole").ToString = "Y" Then
                            llblsignup.Visible = True
                            txtpw.Focus()
                        Else
                            MsgBox("user privillage deneied")
                            llblsignup.Visible = False
                            txtpw.Focus()
                        End If
                    Else
                        MsgBox("User Name is Empty.. Kindly fill user name..")
                        txtuname.Focus()
                    End If
                End If
                'dt = selquery(Query)

            Catch ex As Exception
                MsgBox(ex.ToString())
                End Try
            End If
        'txtpw.Focus()

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ora_con.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        ora_con.Open()
        llblsignup.Visible = False
        'llblsignup.Visible = True
        ora_con.Close()
    End Sub

    Private Sub llblsignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblsignup.LinkClicked
        uregvb.Show()
    End Sub

    Private Sub btncnl_Click(sender As Object, e As EventArgs) Handles btncnl.Click
        Me.Close()

    End Sub

    Private Sub txtpw_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpw.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If txtpw.Text <> "" Then
                Else
                    MsgBox("Password is Empty.. Kindly fill user password..")
                    txtuname.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
            btnlog.Focus()
        End If
    End Sub


End Class