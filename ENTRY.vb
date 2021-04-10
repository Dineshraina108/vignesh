Imports Oracle.DataAccess.Client

Public Class ENTRY
    Private Sub btnNentry_Click(sender As Object, e As EventArgs) Handles btnNentry.Click
        newpnl.Visible = True
        btnNentry.Visible = False
        btnshow.Visible = False
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        Dim f1 As New Form1
        'Me.Close()
        Dim ora As New OracleConnection
        Dim query As String
        Dim dt As New DataTable
        ora.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        ora.Open()
        query = "select * from dcgrid"
        Using cmd As New OracleCommand(query, ora)
            Using ora_ada As New OracleDataAdapter(cmd)
                ora_ada.Fill(dt)
            End Using
        End Using
        f1.RDG.DataSource = dt
        'f1.dcpnl.Update()
        ora.Close()
        f1.cbosuplier.Text = Form1.sval
        f1.cboto.Text = Form1.cval
        f1.txtdcno.Text = Form1.dno
        f1.txtref.Text = Form1.ref

        f1.Show()
        Me.Close()
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim query As String
        Dim result As Long = 0
        Dim dt As New DataTable
        Dim ora As New OracleConnection
        newpnl.Visible = False
        btnNentry.Visible = True
        btnshow.Visible = True
        ora.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        ora.Open()
        query = "insert into DCGRID (sno,CRDATE,pname,color,psize,qty) values(" & txtsno.Text & ",'" & DateTime.Now.Date & "','" & txtpname.Text & "','" & txtclr.Text & "','" & txtsize.Text & "'," & txtqty.Text & ")"
        Using cmd As New OracleCommand(query, ora)
            result = cmd.ExecuteNonQuery()
            If result > 0 Then
                MsgBox("insert success")
                Dim f1 As New Form1
                query = "select * from dcgrid "
                Using cmd1 As New OracleCommand(query, ora)
                    Using ora_ada As New OracleDataAdapter(cmd1)
                        ora_ada.Fill(dt)
                    End Using
                End Using
                f1.RDG.DataSource = dt
                Me.Close()
                f1.txtdcno.Text = Form1.dno
                f1.txtref.Text = Form1.ref
                f1.Show()
            Else
                MsgBox("insert failed")
            End If
        End Using



    End Sub

    Private Sub btncancl_Click(sender As Object, e As EventArgs) Handles btncancl.Click
        txtsno.Text = ""
        txtpname.Text = ""
        txtclr.Text = ""
        txtsize.Text = ""
        txtqty.Text = ""
        newpnl.Update()
        newpnl.Visible = False
        btnNentry.Visible = True
        btnshow.Visible = True
    End Sub

    Private Sub btndcadd_Click(sender As Object, e As EventArgs) Handles btndcadd.Click
        Dim query As String
        Dim ora As New OracleConnection
        Dim result As Long = 0
        ora.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        ora.Open()
        query = "insert into dc values('" & txtdcsupp.Text & "','" & txtdcto.Text & "'," & txtdcno.Text & ")"
        Using cmd As New OracleCommand(query, ora)
            result = cmd.ExecuteNonQuery()
            If result > 0 Then
                MsgBox("insert successfully")
            Else
                MsgBox("INSERT FAILED")
            End If
        End Using
        ora.Close()

    End Sub

    Private Sub dcpnl_Paint(sender As Object, e As PaintEventArgs) Handles dcpnl1.Paint

    End Sub

    Private Sub ENTRY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ora As New OracleConnection
        ora.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        ora.Open()
        ora.Close()
        dcpnl1.Visible = False
    End Sub

    Private Sub btndccancel_Click(sender As Object, e As EventArgs) Handles btndccancel.Click
        Me.Close()
    End Sub

    Private Sub txtsno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpname.Focus()
        End If
    End Sub

    Private Sub txtpname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtclr.Focus()
        End If
    End Sub

    Private Sub txtclr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtclr.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsize.Focus()
        End If
    End Sub

    Private Sub txtsize_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsize.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtqty.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnaddcom.Click
        dcpnl1.Visible = True
    End Sub

    Private Sub txtdcno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdcno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtdcsupp.Focus()
        End If
    End Sub

    Private Sub txtdcsupp_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdcsupp.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtdcto.Focus()
        End If
    End Sub

    Private Sub txtdcto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdcto.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnaddcom.Focus()
        End If
    End Sub

    Private Sub lblsno_Click(sender As Object, e As EventArgs) Handles lblsno.Click

    End Sub

    Private Sub txtqty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqty.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnadd.Focus()
        End If
    End Sub
End Class