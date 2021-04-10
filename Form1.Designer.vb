<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim SortDescriptor2 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.lbldc = New System.Windows.Forms.Label()
        Me.dcpnl = New System.Windows.Forms.Panel()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.txtpurpose = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtvehno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.RDG = New Telerik.WinControls.UI.RadGridView()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.lblref = New System.Windows.Forms.Label()
        Me.cboto = New System.Windows.Forms.ComboBox()
        Me.lclconcern = New System.Windows.Forms.Label()
        Me.txtdcno = New System.Windows.Forms.TextBox()
        Me.lbldcno = New System.Windows.Forms.Label()
        Me.cbosuplier = New System.Windows.Forms.ComboBox()
        Me.lblsupplier = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.BTN = New System.Windows.Forms.Button()
        Me.btnmdy = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnext = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnview = New System.Windows.Forms.Button()
        Me.dcpnl.SuspendLayout()
        CType(Me.RDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RDG.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldc
        '
        Me.lbldc.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.lbldc.BackColor = System.Drawing.Color.SpringGreen
        Me.lbldc.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldc.Location = New System.Drawing.Point(1, 1)
        Me.lbldc.Name = "lbldc"
        Me.lbldc.Size = New System.Drawing.Size(924, 34)
        Me.lbldc.TabIndex = 0
        Me.lbldc.Text = "GENERAL DC"
        Me.lbldc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dcpnl
        '
        Me.dcpnl.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.dcpnl.Controls.Add(Me.txtdate)
        Me.dcpnl.Controls.Add(Me.txtpurpose)
        Me.dcpnl.Controls.Add(Me.Label2)
        Me.dcpnl.Controls.Add(Me.txtvehno)
        Me.dcpnl.Controls.Add(Me.Label1)
        Me.dcpnl.Controls.Add(Me.btnadd)
        Me.dcpnl.Controls.Add(Me.RDG)
        Me.dcpnl.Controls.Add(Me.txtref)
        Me.dcpnl.Controls.Add(Me.lblref)
        Me.dcpnl.Controls.Add(Me.cboto)
        Me.dcpnl.Controls.Add(Me.lclconcern)
        Me.dcpnl.Controls.Add(Me.txtdcno)
        Me.dcpnl.Controls.Add(Me.lbldcno)
        Me.dcpnl.Controls.Add(Me.cbosuplier)
        Me.dcpnl.Controls.Add(Me.lblsupplier)
        Me.dcpnl.Controls.Add(Me.lbldate)
        Me.dcpnl.Location = New System.Drawing.Point(7, 38)
        Me.dcpnl.Name = "dcpnl"
        Me.dcpnl.Size = New System.Drawing.Size(918, 406)
        Me.dcpnl.TabIndex = 1
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(130, 45)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(100, 20)
        Me.txtdate.TabIndex = 16
        '
        'txtpurpose
        '
        Me.txtpurpose.Location = New System.Drawing.Point(487, 377)
        Me.txtpurpose.Name = "txtpurpose"
        Me.txtpurpose.Size = New System.Drawing.Size(245, 20)
        Me.txtpurpose.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(416, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "PURPOSE"
        '
        'txtvehno
        '
        Me.txtvehno.Location = New System.Drawing.Point(109, 384)
        Me.txtvehno.Name = "txtvehno"
        Me.txtvehno.Size = New System.Drawing.Size(121, 20)
        Me.txtvehno.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "VEHICLE NO"
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Silver
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(657, 141)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 11
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'RDG
        '
        Me.RDG.BackColor = System.Drawing.SystemColors.Control
        Me.RDG.Cursor = System.Windows.Forms.Cursors.Default
        Me.RDG.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RDG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RDG.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RDG.Location = New System.Drawing.Point(24, 180)
        '
        '
        '
        Me.RDG.MasterTemplate.AllowAddNewRow = False
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "SNO"
        GridViewTextBoxColumn6.HeaderText = "SNO"
        GridViewTextBoxColumn6.Name = "SNO"
        GridViewTextBoxColumn6.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewTextBoxColumn6.Width = 62
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.FieldName = "PNAME"
        GridViewTextBoxColumn7.HeaderText = "PNAME"
        GridViewTextBoxColumn7.Name = "PNAME"
        GridViewTextBoxColumn7.Width = 173
        GridViewTextBoxColumn8.EnableExpressionEditor = False
        GridViewTextBoxColumn8.FieldName = "COLOR"
        GridViewTextBoxColumn8.HeaderText = "COLOR"
        GridViewTextBoxColumn8.Name = "COLOR"
        GridViewTextBoxColumn8.Width = 110
        GridViewTextBoxColumn9.EnableExpressionEditor = False
        GridViewTextBoxColumn9.FieldName = "PSIZE"
        GridViewTextBoxColumn9.HeaderText = "PSIZE"
        GridViewTextBoxColumn9.Name = "PSIZE"
        GridViewTextBoxColumn9.Width = 73
        GridViewTextBoxColumn10.EnableExpressionEditor = False
        GridViewTextBoxColumn10.FieldName = "QTY"
        GridViewTextBoxColumn10.HeaderText = "QTY"
        GridViewTextBoxColumn10.Name = "QTY"
        GridViewTextBoxColumn10.Width = 54
        Me.RDG.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10})
        Me.RDG.MasterTemplate.EnableFiltering = True
        SortDescriptor2.PropertyName = "SNO"
        Me.RDG.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor2})
        Me.RDG.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RDG.Name = "RDG"
        Me.RDG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RDG.Size = New System.Drawing.Size(708, 176)
        Me.RDG.TabIndex = 10
        '
        'txtref
        '
        Me.txtref.Location = New System.Drawing.Point(130, 125)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(100, 20)
        Me.txtref.TabIndex = 9
        '
        'lblref
        '
        Me.lblref.AutoSize = True
        Me.lblref.Location = New System.Drawing.Point(21, 125)
        Me.lblref.Name = "lblref"
        Me.lblref.Size = New System.Drawing.Size(28, 13)
        Me.lblref.TabIndex = 8
        Me.lblref.Text = "REF"
        '
        'cboto
        '
        Me.cboto.FormattingEnabled = True
        Me.cboto.Location = New System.Drawing.Point(589, 97)
        Me.cboto.Name = "cboto"
        Me.cboto.Size = New System.Drawing.Size(231, 21)
        Me.cboto.TabIndex = 7
        '
        'lclconcern
        '
        Me.lclconcern.AutoSize = True
        Me.lclconcern.Location = New System.Drawing.Point(494, 97)
        Me.lclconcern.Name = "lclconcern"
        Me.lclconcern.Size = New System.Drawing.Size(78, 13)
        Me.lclconcern.TabIndex = 6
        Me.lclconcern.Text = "TO CONCERN"
        '
        'txtdcno
        '
        Me.txtdcno.Location = New System.Drawing.Point(589, 52)
        Me.txtdcno.Name = "txtdcno"
        Me.txtdcno.Size = New System.Drawing.Size(100, 20)
        Me.txtdcno.TabIndex = 5
        '
        'lbldcno
        '
        Me.lbldcno.AutoSize = True
        Me.lbldcno.Location = New System.Drawing.Point(494, 52)
        Me.lbldcno.Name = "lbldcno"
        Me.lbldcno.Size = New System.Drawing.Size(41, 13)
        Me.lbldcno.TabIndex = 4
        Me.lbldcno.Text = "DC NO"
        '
        'cbosuplier
        '
        Me.cbosuplier.FormattingEnabled = True
        Me.cbosuplier.Location = New System.Drawing.Point(130, 89)
        Me.cbosuplier.Name = "cbosuplier"
        Me.cbosuplier.Size = New System.Drawing.Size(231, 21)
        Me.cbosuplier.TabIndex = 3
        '
        'lblsupplier
        '
        Me.lblsupplier.AutoSize = True
        Me.lblsupplier.Location = New System.Drawing.Point(21, 89)
        Me.lblsupplier.Name = "lblsupplier"
        Me.lblsupplier.Size = New System.Drawing.Size(60, 13)
        Me.lblsupplier.TabIndex = 1
        Me.lblsupplier.Text = "SUPPLIER"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(21, 52)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(36, 13)
        Me.lbldate.TabIndex = 0
        Me.lbldate.Text = "DATE"
        '
        'BTN
        '
        Me.BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN.ForeColor = System.Drawing.Color.Black
        Me.BTN.Location = New System.Drawing.Point(108, 465)
        Me.BTN.Name = "BTN"
        Me.BTN.Size = New System.Drawing.Size(75, 23)
        Me.BTN.TabIndex = 2
        Me.BTN.Text = "NEW"
        Me.BTN.UseVisualStyleBackColor = False
        '
        'btnmdy
        '
        Me.btnmdy.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnmdy.Location = New System.Drawing.Point(298, 465)
        Me.btnmdy.Name = "btnmdy"
        Me.btnmdy.Size = New System.Drawing.Size(75, 23)
        Me.btnmdy.TabIndex = 3
        Me.btnmdy.Text = "MODIFY"
        Me.btnmdy.UseVisualStyleBackColor = False
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnprint.Location = New System.Drawing.Point(483, 465)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 23)
        Me.btnprint.TabIndex = 4
        Me.btnprint.Text = "PRINT"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'btnext
        '
        Me.btnext.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnext.Location = New System.Drawing.Point(669, 465)
        Me.btnext.Name = "btnext"
        Me.btnext.Size = New System.Drawing.Size(75, 23)
        Me.btnext.TabIndex = 5
        Me.btnext.Text = "EXIT"
        Me.btnext.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsave.Location = New System.Drawing.Point(208, 465)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 6
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btndel.Location = New System.Drawing.Point(390, 465)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(75, 23)
        Me.btndel.TabIndex = 7
        Me.btndel.Text = "DELETE"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnview
        '
        Me.btnview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnview.Location = New System.Drawing.Point(573, 465)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(75, 23)
        Me.btnview.TabIndex = 8
        Me.btnview.Text = "VIEW"
        Me.btnview.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 488)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnext)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnmdy)
        Me.Controls.Add(Me.BTN)
        Me.Controls.Add(Me.dcpnl)
        Me.Controls.Add(Me.lbldc)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.dcpnl.ResumeLayout(False)
        Me.dcpnl.PerformLayout()
        CType(Me.RDG.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbldc As Label
    Friend WithEvents dcpnl As Panel
    Friend WithEvents RDG As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtref As TextBox
    Friend WithEvents lblref As Label
    Friend WithEvents lclconcern As Label
    Friend WithEvents txtdcno As TextBox
    Friend WithEvents lbldcno As Label
    Friend WithEvents lblsupplier As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents txtpurpose As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtvehno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents BTN As Button
    Friend WithEvents btnmdy As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents btnext As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cboto As ComboBox
    Friend WithEvents cbosuplier As ComboBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btndel As Button
    Friend WithEvents txtdate As TextBox
    Friend WithEvents btnview As Button
End Class
