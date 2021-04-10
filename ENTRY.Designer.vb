<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ENTRY
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
        Me.newpnl = New System.Windows.Forms.Panel()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.btncancl = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtsize = New System.Windows.Forms.TextBox()
        Me.txtclr = New System.Windows.Forms.TextBox()
        Me.txtpname = New System.Windows.Forms.TextBox()
        Me.txtsno = New System.Windows.Forms.TextBox()
        Me.lblclr = New System.Windows.Forms.Label()
        Me.lblsize = New System.Windows.Forms.Label()
        Me.lblpname = New System.Windows.Forms.Label()
        Me.lblsno = New System.Windows.Forms.Label()
        Me.btnNentry = New System.Windows.Forms.Button()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.dcpnl1 = New System.Windows.Forms.Panel()
        Me.txtdcno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btndcadd = New System.Windows.Forms.Button()
        Me.btndccancel = New System.Windows.Forms.Button()
        Me.txtdcto = New System.Windows.Forms.TextBox()
        Me.lclconcern = New System.Windows.Forms.Label()
        Me.txtdcsupp = New System.Windows.Forms.TextBox()
        Me.lblsupplier = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnaddcom = New System.Windows.Forms.Button()
        Me.newpnl.SuspendLayout()
        Me.dcpnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'newpnl
        '
        Me.newpnl.Controls.Add(Me.txtqty)
        Me.newpnl.Controls.Add(Me.lblqty)
        Me.newpnl.Controls.Add(Me.btncancl)
        Me.newpnl.Controls.Add(Me.btnadd)
        Me.newpnl.Controls.Add(Me.txtsize)
        Me.newpnl.Controls.Add(Me.txtclr)
        Me.newpnl.Controls.Add(Me.txtpname)
        Me.newpnl.Controls.Add(Me.txtsno)
        Me.newpnl.Controls.Add(Me.lblclr)
        Me.newpnl.Controls.Add(Me.lblsize)
        Me.newpnl.Controls.Add(Me.lblpname)
        Me.newpnl.Controls.Add(Me.lblsno)
        Me.newpnl.Location = New System.Drawing.Point(13, 86)
        Me.newpnl.Name = "newpnl"
        Me.newpnl.Size = New System.Drawing.Size(366, 277)
        Me.newpnl.TabIndex = 0
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(154, 192)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(100, 20)
        Me.txtqty.TabIndex = 11
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Location = New System.Drawing.Point(35, 195)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(29, 13)
        Me.lblqty.TabIndex = 10
        Me.lblqty.Text = "QTY"
        '
        'btncancl
        '
        Me.btncancl.Location = New System.Drawing.Point(280, 234)
        Me.btncancl.Name = "btncancl"
        Me.btncancl.Size = New System.Drawing.Size(75, 23)
        Me.btncancl.TabIndex = 9
        Me.btncancl.Text = "CANCEL"
        Me.btncancl.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(188, 235)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 8
        Me.btnadd.Text = "ADD"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtsize
        '
        Me.txtsize.Location = New System.Drawing.Point(154, 151)
        Me.txtsize.Name = "txtsize"
        Me.txtsize.Size = New System.Drawing.Size(100, 20)
        Me.txtsize.TabIndex = 7
        '
        'txtclr
        '
        Me.txtclr.Location = New System.Drawing.Point(154, 107)
        Me.txtclr.Name = "txtclr"
        Me.txtclr.Size = New System.Drawing.Size(100, 20)
        Me.txtclr.TabIndex = 6
        '
        'txtpname
        '
        Me.txtpname.Location = New System.Drawing.Point(154, 69)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(100, 20)
        Me.txtpname.TabIndex = 5
        '
        'txtsno
        '
        Me.txtsno.Location = New System.Drawing.Point(154, 27)
        Me.txtsno.Name = "txtsno"
        Me.txtsno.Size = New System.Drawing.Size(100, 20)
        Me.txtsno.TabIndex = 4
        '
        'lblclr
        '
        Me.lblclr.AutoSize = True
        Me.lblclr.Location = New System.Drawing.Point(35, 107)
        Me.lblclr.Name = "lblclr"
        Me.lblclr.Size = New System.Drawing.Size(44, 13)
        Me.lblclr.TabIndex = 3
        Me.lblclr.Text = "COLOR"
        '
        'lblsize
        '
        Me.lblsize.AutoSize = True
        Me.lblsize.Location = New System.Drawing.Point(35, 151)
        Me.lblsize.Name = "lblsize"
        Me.lblsize.Size = New System.Drawing.Size(31, 13)
        Me.lblsize.TabIndex = 2
        Me.lblsize.Text = "SIZE"
        '
        'lblpname
        '
        Me.lblpname.AutoSize = True
        Me.lblpname.Location = New System.Drawing.Point(35, 72)
        Me.lblpname.Name = "lblpname"
        Me.lblpname.Size = New System.Drawing.Size(45, 13)
        Me.lblpname.TabIndex = 1
        Me.lblpname.Text = "PNAME"
        '
        'lblsno
        '
        Me.lblsno.AutoSize = True
        Me.lblsno.Location = New System.Drawing.Point(34, 30)
        Me.lblsno.Name = "lblsno"
        Me.lblsno.Size = New System.Drawing.Size(30, 13)
        Me.lblsno.TabIndex = 0
        Me.lblsno.Text = "SNO"
        '
        'btnNentry
        '
        Me.btnNentry.Location = New System.Drawing.Point(78, 32)
        Me.btnNentry.Name = "btnNentry"
        Me.btnNentry.Size = New System.Drawing.Size(88, 31)
        Me.btnNentry.TabIndex = 1
        Me.btnNentry.Text = "NEW ENTRY"
        Me.btnNentry.UseVisualStyleBackColor = True
        '
        'btnshow
        '
        Me.btnshow.Location = New System.Drawing.Point(226, 32)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(91, 31)
        Me.btnshow.TabIndex = 2
        Me.btnshow.Text = "SHOW"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'dcpnl1
        '
        Me.dcpnl1.Controls.Add(Me.txtdcno)
        Me.dcpnl1.Controls.Add(Me.Label1)
        Me.dcpnl1.Controls.Add(Me.btndcadd)
        Me.dcpnl1.Controls.Add(Me.btndccancel)
        Me.dcpnl1.Controls.Add(Me.txtdcto)
        Me.dcpnl1.Controls.Add(Me.lclconcern)
        Me.dcpnl1.Controls.Add(Me.txtdcsupp)
        Me.dcpnl1.Controls.Add(Me.lblsupplier)
        Me.dcpnl1.Location = New System.Drawing.Point(472, 86)
        Me.dcpnl1.Name = "dcpnl1"
        Me.dcpnl1.Size = New System.Drawing.Size(288, 277)
        Me.dcpnl1.TabIndex = 3
        '
        'txtdcno
        '
        Me.txtdcno.Location = New System.Drawing.Point(140, 19)
        Me.txtdcno.Name = "txtdcno"
        Me.txtdcno.Size = New System.Drawing.Size(100, 20)
        Me.txtdcno.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "DC NO"
        '
        'btndcadd
        '
        Me.btndcadd.Location = New System.Drawing.Point(48, 195)
        Me.btndcadd.Name = "btndcadd"
        Me.btndcadd.Size = New System.Drawing.Size(75, 23)
        Me.btndcadd.TabIndex = 13
        Me.btndcadd.Text = "ADD"
        Me.btndcadd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndcadd.UseVisualStyleBackColor = True
        '
        'btndccancel
        '
        Me.btndccancel.Location = New System.Drawing.Point(165, 195)
        Me.btndccancel.Name = "btndccancel"
        Me.btndccancel.Size = New System.Drawing.Size(75, 23)
        Me.btndccancel.TabIndex = 12
        Me.btndccancel.Text = "CANCEL"
        Me.btndccancel.UseVisualStyleBackColor = True
        '
        'txtdcto
        '
        Me.txtdcto.Location = New System.Drawing.Point(140, 124)
        Me.txtdcto.Name = "txtdcto"
        Me.txtdcto.Size = New System.Drawing.Size(100, 20)
        Me.txtdcto.TabIndex = 11
        '
        'lclconcern
        '
        Me.lclconcern.AutoSize = True
        Me.lclconcern.Location = New System.Drawing.Point(45, 127)
        Me.lclconcern.Name = "lclconcern"
        Me.lclconcern.Size = New System.Drawing.Size(78, 13)
        Me.lclconcern.TabIndex = 10
        Me.lclconcern.Text = "TO CONCERN"
        '
        'txtdcsupp
        '
        Me.txtdcsupp.Location = New System.Drawing.Point(140, 65)
        Me.txtdcsupp.Name = "txtdcsupp"
        Me.txtdcsupp.Size = New System.Drawing.Size(100, 20)
        Me.txtdcsupp.TabIndex = 9
        '
        'lblsupplier
        '
        Me.lblsupplier.AutoSize = True
        Me.lblsupplier.Location = New System.Drawing.Point(45, 69)
        Me.lblsupplier.Name = "lblsupplier"
        Me.lblsupplier.Size = New System.Drawing.Size(60, 13)
        Me.lblsupplier.TabIndex = 8
        Me.lblsupplier.Text = "SUPPLIER"
        '
        'btnaddcom
        '
        Me.btnaddcom.Location = New System.Drawing.Point(583, 36)
        Me.btnaddcom.Name = "btnaddcom"
        Me.btnaddcom.Size = New System.Drawing.Size(100, 23)
        Me.btnaddcom.TabIndex = 4
        Me.btnaddcom.Text = "ADD COMPANY"
        Me.btnaddcom.UseVisualStyleBackColor = True
        '
        'ENTRY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 494)
        Me.Controls.Add(Me.btnaddcom)
        Me.Controls.Add(Me.dcpnl1)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.btnNentry)
        Me.Controls.Add(Me.newpnl)
        Me.Name = "ENTRY"
        Me.Text = "ENTRY"
        Me.newpnl.ResumeLayout(False)
        Me.newpnl.PerformLayout()
        Me.dcpnl1.ResumeLayout(False)
        Me.dcpnl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents newpnl As Panel
    Friend WithEvents txtqty As TextBox
    Friend WithEvents lblqty As Label
    Friend WithEvents btncancl As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents txtsize As TextBox
    Friend WithEvents txtclr As TextBox
    Friend WithEvents txtpname As TextBox
    Friend WithEvents txtsno As TextBox
    Friend WithEvents lblclr As Label
    Friend WithEvents lblsize As Label
    Friend WithEvents lblpname As Label
    Friend WithEvents lblsno As Label
    Friend WithEvents btnNentry As Button
    Friend WithEvents btnshow As Button
    Friend WithEvents dcpnl1 As Panel
    Friend WithEvents txtdcsupp As TextBox
    Friend WithEvents lblsupplier As Label
    Friend WithEvents txtdcto As TextBox
    Friend WithEvents lclconcern As Label
    Friend WithEvents btndcadd As Button
    Friend WithEvents btndccancel As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtdcno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnaddcom As Button
End Class
