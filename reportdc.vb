Imports Oracle.DataAccess.Client
Public Class reportdc
    Dim ora As New OracleConnection
    Dim query As String
    Private Sub reportdc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'Dts1.DCGRID' table. You can move, or remove it, as needed.

        ora.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        ora.Open()
        'Dim dt, DT1 As New DataTable
        'query = "select dcno,suppliername,toconcern,refer,vehicleno,purpose from dcdetails where dcno= " & Form1.dno & ""
        'Using cmd As New OracleCommand(query, ora)
        '    Using Ora_ada As New OracleDataAdapter(cmd)
        '        Ora_ada.Fill(dt)
        '    End Using
        'End Using
        'query = "select * FROM DCGRID"
        'Using cmd As New OracleCommand(query, ora)
        '    Using Ora_ada As New OracleDataAdapter(cmd)
        '        Ora_ada.Fill(dt1)
        '    End Using
        'End Using
        'With Me.Repdc.LocalReport
        '    .DataSources.Clear()
        '    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dsgridvalue", DT1))
        '    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dsformdata", dt))
        'End With
        With Me.Repday.LocalReport
            .DataSources.Clear()
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dsdate", FTdate.dtdate))
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dsrep", FTdate.dtdata))
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dsdcgrid", FTdate.dt1))
        End With
        Me.Repdc.RefreshReport()
        Me.Repday.RefreshReport
    End Sub


End Class