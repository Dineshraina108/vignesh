<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportdc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DCGRIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dts1 = New DC.Dts1()
        Me.dtdcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSdc = New DC.DSdc()
        Me.DATEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsrep = New DC.Dsrep()
        Me.dsrepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Repdc = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DCGRIDTableAdapter = New DC.Dts1TableAdapters.DCGRIDTableAdapter()
        Me.Repday = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsdcgridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DCGRIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dts1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtdcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSdc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsrep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsrepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsdcgridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DCGRIDBindingSource
        '
        Me.DCGRIDBindingSource.DataMember = "DCGRID"
        Me.DCGRIDBindingSource.DataSource = Me.Dts1
        '
        'Dts1
        '
        Me.Dts1.DataSetName = "Dts1"
        Me.Dts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtdcBindingSource
        '
        Me.dtdcBindingSource.DataMember = "dtdc"
        Me.dtdcBindingSource.DataSource = Me.DSdc
        '
        'DSdc
        '
        Me.DSdc.DataSetName = "DSdc"
        Me.DSdc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DATEBindingSource
        '
        Me.DATEBindingSource.DataMember = "DATE"
        Me.DATEBindingSource.DataSource = Me.Dsrep
        '
        'Dsrep
        '
        Me.Dsrep.DataSetName = "Dsrep"
        Me.Dsrep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dsrepBindingSource
        '
        Me.dsrepBindingSource.DataMember = "dsrep"
        Me.dsrepBindingSource.DataSource = Me.Dsrep
        '
        'Repdc
        '
        ReportDataSource1.Name = "Dsgridvalue"
        ReportDataSource1.Value = Me.DCGRIDBindingSource
        ReportDataSource2.Name = "Dsformdata"
        ReportDataSource2.Value = Me.dtdcBindingSource
        Me.Repdc.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Repdc.LocalReport.DataSources.Add(ReportDataSource2)
        Me.Repdc.LocalReport.ReportEmbeddedResource = "DC.report1.rdlc"
        Me.Repdc.Location = New System.Drawing.Point(63, 52)
        Me.Repdc.Name = "Repdc"
        Me.Repdc.Size = New System.Drawing.Size(715, 414)
        Me.Repdc.TabIndex = 0
        '
        'DCGRIDTableAdapter
        '
        Me.DCGRIDTableAdapter.ClearBeforeFill = True
        '
        'Repday
        '
        ReportDataSource3.Name = "Dsdate"
        ReportDataSource3.Value = Me.DATEBindingSource
        ReportDataSource4.Name = "Dsrep"
        ReportDataSource4.Value = Me.dsrepBindingSource
        ReportDataSource5.Name = "Dsdcgrid"
        ReportDataSource5.Value = Me.dsdcgridBindingSource
        Me.Repday.LocalReport.DataSources.Add(ReportDataSource3)
        Me.Repday.LocalReport.DataSources.Add(ReportDataSource4)
        Me.Repday.LocalReport.DataSources.Add(ReportDataSource5)
        Me.Repday.LocalReport.ReportEmbeddedResource = "DC.DAYWISE.rdlc"
        Me.Repday.Location = New System.Drawing.Point(12, 12)
        Me.Repday.Name = "Repday"
        Me.Repday.Size = New System.Drawing.Size(1185, 575)
        Me.Repday.TabIndex = 1
        '
        'dsdcgridBindingSource
        '
        Me.dsdcgridBindingSource.DataMember = "dsdcgrid"
        Me.dsdcgridBindingSource.DataSource = Me.Dsrep
        '
        'reportdc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 599)
        Me.Controls.Add(Me.Repday)
        Me.Controls.Add(Me.Repdc)
        Me.Name = "reportdc"
        Me.Text = "reportdc"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DCGRIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dts1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtdcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSdc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsrep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsrepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsdcgridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Repdc As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DCGRIDBindingSource As BindingSource
    Friend WithEvents Dts1 As Dts1
    Friend WithEvents dtdcBindingSource As BindingSource
    Friend WithEvents DSdc As DSdc
    Friend WithEvents DCGRIDTableAdapter As Dts1TableAdapters.DCGRIDTableAdapter
    Friend WithEvents Repday As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DATEBindingSource As BindingSource
    Friend WithEvents Dsrep As Dsrep
    Friend WithEvents dsrepBindingSource As BindingSource
    Friend WithEvents dsdcgridBindingSource As BindingSource
End Class
