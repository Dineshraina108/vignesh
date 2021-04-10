Imports Oracle.DataAccess.Client
Public Class FTdate
    Dim ora As New OracleConnection
    Public Shared dtdata As DataTable
    Public Shared dtdate As New DataTable
    Public Shared dt1 As DataTable
    Private Sub FTdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ora.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        ora.Open()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        Dim query As String
        Dim dt, dtdcgrid, dtdcdetails As New DataTable
        Dim dr As DataRow

        'SNO,PNAME,COLOR,PSIZE,QTY,

        query = "SELECT DCNO,SUPPLIERNAME,TOCONCERN,REFER,VEHICLENO,PURPOSE FROM DCDETAILS WHERE  DCDATE BETWEEN '" & dtfromdate.Value.Date & "' AND '" & dttodate.Value.Date & "' ORDER BY DCNO"
        Using cmd As New OracleCommand(query, ora)
            Using ada As New OracleDataAdapter(cmd)
                ada.Fill(dtdcdetails)
            End Using
        End Using
        query = "SELECT PNAME,COLOR,PSIZE,QTY FROM DCGRID WHERE CRDATE BETWEEN '" & dtfromdate.Value.Date & "' AND '" & dttodate.Value.Date & "'"
        Using cmd As New OracleCommand(query, ora)
            Using ada As New OracleDataAdapter(cmd)
                ada.Fill(dtdcgrid)
            End Using
        End Using
        dtdata = dtdcdetails
        dt1 = dtdcgrid
        dtdate = GetTable()
        dr = dtdate.NewRow()
        dr("FROMDATE") = dtfromdate.Value.Date
        dr("TODATE") = dttodate.Value.Date
        dtdate.Rows.Add(dr)
        Dim re As New reportdc
        re.Repdc.Visible = False
        re.Show()
    End Sub
    Public Function GetTable()
        Dim tabl As New DataTable
        tabl.Columns.Add("FROMDATE", GetType(String))
        tabl.Columns.Add("TODATE", GetType(String))
        Return tabl
    End Function
End Class