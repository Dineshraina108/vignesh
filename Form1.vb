Imports Oracle.DataAccess.Client
Public Class Form1
    Dim query As String
    Dim ora As New OracleConnection
    Public Shared dno, ref, sval, cval As String
    Private Sub RadGridView1_Click(sender As Object, e As EventArgs) Handles RDG.Click

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim query As String
        Dim dt As New DataTable
        dno = txtdcno.Text
        ref = txtref.Text
        sval = cbosuplier.Text
        cval = cboto.Text
        ''query = "insert into dc values(seqq.nextval,'to_date('" & DateTime.Value.Date & "','dd/mm/yyyy')'," & cbosuplier.SelectedValue & "," & cboto.SelectedValue & "," & txtref.Text & "," & txtvehno.Text & "," & txtpurpose.Text & "")
        Dim inpnl As New ENTRY
        inpnl.newpnl.Visible = False
        inpnl.Show()
        Me.Hide()
    End Sub

    Private Sub btnext_Click(sender As Object, e As EventArgs) Handles btnext.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdate.Text = Date.Now.Date
    End Sub

    Private Sub BTN_Click(sender As Object, e As EventArgs) Handles BTN.Click
        Dim dt As New DataTable
        txtdcno.Text = ""
        txtref.Text = ""
        txtvehno.Text = ""
        txtpurpose.Text = ""
        RDG.DataSource = dt
        dcpnl.Update()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim QUERY As String
        Dim ora As New OracleConnection
        Dim RESULT As Long = 0
        ora.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        ora.Open()
        'QUERY = "insert into dcdetails(dcno,dcdate,suppliername,toconcern,reference,vehicleno,purpose) values(" & txtdcno.Text & ",'to_date('" & DateTime.Value.Date & "','dd/mm/yyyy')','" & cbosuplier.SelectedValue & "','" & cboto.SelectedValue & "','" & txtref.Text & "'," & txtvehno.Text & ",'" & txtpurpose.Text & "')"
        QUERY = "insert into dcdetails(dcno,dcdate,suppliername,toconcern,refer,vehicleno,purpose) values (" & txtdcno.Text & ",'" & txtdate.Text & "','" & cbosuplier.Text & "','" & cboto.Text & "','" & txtref.Text & "','" & txtvehno.Text & "','" & txtpurpose.Text & "')"
        Using cmd As New OracleCommand(QUERY, ora)
            RESULT = cmd.ExecuteNonQuery()
            If RESULT > 0 Then
                MsgBox("insert successfully")
            Else
                MsgBox("INSERT FAILED")
            End If
            ora.Close()

        End Using
    End Sub

    Private Sub btnmdy_Click(sender As Object, e As EventArgs) Handles btnmdy.Click
        Dim Sno As String
        Dim PNAME As String
        Dim color As String
        Dim Psize As String
        Dim qty As String
        Dim q As String
        Dim RESULT As String
        ora.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        ora.Open()
        Sno = RDG.CurrentRow.Cells("SNO").Value
        PNAME = RDG.CurrentRow.Cells("PNAME").Value.ToString
        color = RDG.CurrentRow.Cells("COLOR").Value.ToString
        Psize = RDG.CurrentRow.Cells("PSIZE").Value
        qty = RDG.CurrentRow.Cells("QTY").Value
        q = "UPDATE dcgrid SET PNAME='" & PNAME & "',COLOR='" & color & "',PSIZE=" & Psize & ",QTY='" & qty & "' WHERE SNO =" & Sno & ""
        Using cmd As New OracleCommand(q, ora)
            RESULT = cmd.ExecuteNonQuery()
            If RESULT > 0 Then
                MsgBox("update successfully")
                dcpnl.Update()
            Else
                MsgBox("update FAILED")
            End If
        End Using
        ora.Close()
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim q As String
        Dim delt As String
        Dim RESULT As Long = 0
        Dim dt, dt1 As New DataTable
        ora.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        ora.Open()
        delt = RDG.CurrentRow.Cells("SNO").Value
        q = "DELETE FROM DCGRID WHERE SNO='" & delt & "'"
        Using cmd As New OracleCommand(q, ora)
            RESULT = cmd.ExecuteNonQuery()
            If RESULT > 0 Then
                MsgBox("DELETE SUCCESS")
                query = "select * from dcgrid"
                Using cmd1 As New OracleCommand(query, ora)
                    Using ora_ada As New OracleDataAdapter(cmd1)
                        ora_ada.Fill(dt)
                    End Using
                End Using
                RDG.DataSource = dt
                dcpnl.Update()
            Else
                MsgBox("DELETE FAILED")
            End If
        End Using
        ora.Close()
    End Sub
    Private Sub txtdate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtdcno.Focus()
        End If
    End Sub

    Private Sub txtdcno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdcno.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dt, dt1 As New DataTable

            ora.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
            ora.Open()
            query = "SELECT SUPPLIERNAME FROM DC"
            Using cmd As New OracleCommand(query, ora)
                Using ora_ada As New OracleDataAdapter(cmd)
                    ora_ada.Fill(dt)
                End Using
            End Using

            cbosuplier.DataSource = dt
            Dim Irow As DataRow = dt.NewRow()
            Irow(0) = ""
            dt.Rows.InsertAt(Irow, 0)
            cbosuplier.DisplayMember = "SUPPLIERNAME"
            cbosuplier.ValueMember = "SUPPLIERNAME"
            'cbosuplier.SelectedIndex = 0
            query = "SELECT TOCONCERN FROM DC"
            Using cmd As New OracleCommand(query, ora)
                Using ora_ada As New OracleDataAdapter(cmd)
                    ora_ada.Fill(dt1)
                End Using
            End Using
            cboto.DataSource = dt1
            Dim row As DataRow = dt1.NewRow()
            row(0) = ""
            dt1.Rows.InsertAt(row, 0)
            cboto.DisplayMember = "TOCONCERN"
            cboto.ValueMember = "TOCONCERN"
            'cboto.SelectedIndex = 0
            dcpnl.Update()
            ora.Close()
            cbosuplier.Focus()
        End If
    End Sub

    Private Sub cbosuplier_KeyDown(sender As Object, e As KeyEventArgs) Handles cbosuplier.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboto.Focus()
        End If
    End Sub

    Private Sub cboto_KeyDown(sender As Object, e As KeyEventArgs) Handles cboto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtref.Focus()
        End If
    End Sub

    Private Sub dcpnl_Paint(sender As Object, e As PaintEventArgs) Handles dcpnl.Paint

    End Sub


    Private Sub txtvehno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvehno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpurpose.Focus()
        End If
    End Sub

    Private Sub txtref_KeyDown(sender As Object, e As KeyEventArgs) Handles txtref.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnadd.Focus()
        End If
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnprint.Click



        Dim filename As String = "DC"
        Dim dt As New DataTable
        Dim path As String
        Dim gridvalue As String = ""
        Dim dt1 As New DataTable

        ora.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        ora.Open()

        path = "E:\VIGNESH\GENERAL DC\Bill Report" & filename & ".txt"
        query = "SELECT * FROM dcgrid ORDER BY  SNO"

        Using cmd As New OracleCommand(query, ora)
            Using ora_ada As New OracleDataAdapter(cmd)
                ora_ada.Fill(dt)
            End Using
        End Using
        Dim fwrite As New System.IO.StreamWriter(path)
        fwrite.WriteLine(" ")
        fwrite.WriteLine(" " & Space(50) & "GENERAL DC" & Space(68) & "")
        fwrite.WriteLine(" " & Space(50) & "-----------------------------------")
        fwrite.WriteLine(" ")
        fwrite.WriteLine(" " & Space(5) & "DATE :" & txtdate.Text & " " & Space(60) & " DC NO : " & txtdcno.Text & "")
        fwrite.WriteLine(" ")
        fwrite.WriteLine(" " & Space(5) & "SUPPLIER MAME :" & cbosuplier.Text & " " & Space(60) & " TO CONCERN : " & cboto.Text & "")
        fwrite.WriteLine(" ")
        fwrite.WriteLine(" " & Space(5) & "REFERENCE : " & txtref.Text & "")
        fwrite.WriteLine(" ")
        For Each cell As DataColumn In dt.Columns
            gridvalue += cell.ToString + vbTab & vbTab
        Next
        fwrite.WriteLine("" & Space(5) & " " & gridvalue & "" & vbTab & "")
        gridvalue = ""
        For Each row As DataRow In dt.Rows
            For Each cell As DataColumn In dt.Columns
                gridvalue += row(cell).ToString + vbTab
                gridvalue += vbTab
            Next
            fwrite.WriteLine("" & Space(5) & " " & gridvalue & "" & vbTab & "")
            gridvalue = ""
        Next
        fwrite.WriteLine(" " & Space(50) & "-----------------------------------")
        fwrite.WriteLine(" ")
        fwrite.WriteLine(" " & Space(5) & "VEHICLE NO :" & txtvehno.Text & " " & Space(60) & " PURPOSE : " & txtpurpose.Text & "")
        fwrite.WriteLine(" " & Space(50) & "-----------------------------------")
        fwrite.Close()
        Dim fread As String
        fread = My.Computer.FileSystem.ReadAllText(path)
        Dim pr As New report
        pr.txtfile.Text = fread
        Me.Hide()
        pr.Show()
        'reportdc.Show()

    End Sub




    Private Sub btnview_Click_1(sender As Object, e As EventArgs) Handles btnview.Click
        FTdate.Show()
        'Dim re As New reportdc
        're.Show()
    End Sub
End Class
