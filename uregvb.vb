Imports Oracle.DataAccess.Client
Imports System.Text.RegularExpressions
Public Class uregvb
    Dim emailformat As Regex = New Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,6}$")
    Dim uid, uname, pass, repass, emailid, mobileno, usrivillage As String

    Private Sub txtusid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtuname.Focus()
        End If
    End Sub

    Private Sub txtuname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtupass.Focus()
        End If
    End Sub

    Private Sub txtupass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtupass.KeyDown
        If e.KeyCode = Keys.Enter Then
            txturepass.Focus()
        End If
    End Sub

    Private Sub txturepass_KeyDown(sender As Object, e As KeyEventArgs) Handles txturepass.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtemail.Focus()
        End If
    End Sub

    Private Sub txtemail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtemail.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmobno.Focus()
        End If
    End Sub

    Private Sub llblallogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblallogin.LinkClicked
        login.pnllog.Show()


    End Sub

    Private Sub RDS_CheckedChanged(sender As Object, e As EventArgs) Handles RDS.CheckedChanged
        If RDS.Checked = True Then
            RDN.Checked = False
            usrivillage = "Y"
        End If
    End Sub

    Private Sub RDN_CheckedChanged(sender As Object, e As EventArgs) Handles RDN.CheckedChanged
        If RDN.Checked = True Then
            RDS.Checked = False
            usrivillage = "N"
        End If
    End Sub

    Dim ora_con As New OracleConnection
    Private Sub uregvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ora_con.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        ora_con.Open()
        RDN.Checked = True
        ora_con.Close()

    End Sub

    Dim QRY As String
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()

    End Sub
    Public Sub clear()
        txtusid.Text = ""
        txtuname.Text = ""
        txtupass.Text = ""
        txturepass.Text = ""
        txtemail.Text = ""
        txtmobno.Text = ""

    End Sub

    Private Sub btnreg_Click(sender As Object, e As EventArgs) Handles btnreg.Click
        uid = txtusid.Text
        uname = txtuname.Text
        pass = txtupass.Text
        repass = txturepass.Text
        emailid = txtemail.Text
        mobileno = txtmobno.Text
        ora_con.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        ora_con.Open()
        Dim dt As New DataTable
        If pass = repass Then
            QRY = "SELECT count(*) from dcureg where userid=" & uid & "AND USERNAME='" & uname & "'"
            Using cmd As New OracleCommand(QRY, ora_con)
                Using ora_ada As New OracleDataAdapter(cmd)
                    ora_ada.Fill(dt)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            If dt.Rows(0)("count(*)").ToString = "1" Then
                QRY = "UPDATE DCUREG SET UPASS='" & pass & "', REPASS='" & repass & "' WHERE USERID=" & uid & "AND USERNAME='" & uname & "'"
                ' Updatequery(q)
            Else
                If emailformat.IsMatch(emailid) Then
                    If Len(txtmobno.Text) > 10 Or Len(txtmobno.Text) < 10 Then
                        MsgBox("INVALID MOBILE NUMBER")
                        clear()
                    Else

                        QRY = "INSERT INTO DCUREG VALUES (" & uid & ",'" & uname & "','" & pass & "','" & repass & "','" & emailid & "'," & txtmobno.Text & ",'" & usrivillage & "')"
                        Using cmd As New OracleCommand(QRY, ora_con)
                            cmd.ExecuteNonQuery()
                            Dim log As New login
                            log.Show()
                        End Using
                    End If
                Else
                    MsgBox("INVALID EMAIL ID")
                    clear()
                End If
            End If
        Else
            MsgBox("PASSWORD AND REPASSWORD NOT MATCH")
            clear()
        End If
        ora_con.Close()
    End Sub
End Class