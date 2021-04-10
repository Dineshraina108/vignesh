<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uregvb
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
        Me.RDN = New System.Windows.Forms.RadioButton()
        Me.RDS = New System.Windows.Forms.RadioButton()
        Me.lblup = New System.Windows.Forms.Label()
        Me.txtusid = New System.Windows.Forms.TextBox()
        Me.lbluserid = New System.Windows.Forms.Label()
        Me.llblallogin = New System.Windows.Forms.LinkLabel()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnreg = New System.Windows.Forms.Button()
        Me.txtmobno = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txturepass = New System.Windows.Forms.TextBox()
        Me.txtupass = New System.Windows.Forms.TextBox()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.lablmobno = New System.Windows.Forms.Label()
        Me.lblemal = New System.Windows.Forms.Label()
        Me.lblrepass = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.lbluname = New System.Windows.Forms.Label()
        Me.lblusreg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RDN
        '
        Me.RDN.AutoSize = True
        Me.RDN.Location = New System.Drawing.Point(285, 295)
        Me.RDN.Name = "RDN"
        Me.RDN.Size = New System.Drawing.Size(41, 17)
        Me.RDN.TabIndex = 37
        Me.RDN.TabStop = True
        Me.RDN.Text = "NO"
        Me.RDN.UseVisualStyleBackColor = True
        '
        'RDS
        '
        Me.RDS.AutoSize = True
        Me.RDS.Location = New System.Drawing.Point(221, 297)
        Me.RDS.Name = "RDS"
        Me.RDS.Size = New System.Drawing.Size(46, 17)
        Me.RDS.TabIndex = 36
        Me.RDS.TabStop = True
        Me.RDS.Text = "YES"
        Me.RDS.UseVisualStyleBackColor = True
        '
        'lblup
        '
        Me.lblup.AutoSize = True
        Me.lblup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblup.Location = New System.Drawing.Point(47, 295)
        Me.lblup.Name = "lblup"
        Me.lblup.Size = New System.Drawing.Size(143, 18)
        Me.lblup.TabIndex = 35
        Me.lblup.Text = "USER PRIVILAGE"
        '
        'txtusid
        '
        Me.txtusid.Location = New System.Drawing.Point(221, 77)
        Me.txtusid.Name = "txtusid"
        Me.txtusid.Size = New System.Drawing.Size(104, 20)
        Me.txtusid.TabIndex = 34
        '
        'lbluserid
        '
        Me.lbluserid.AutoSize = True
        Me.lbluserid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluserid.Location = New System.Drawing.Point(44, 77)
        Me.lbluserid.Name = "lbluserid"
        Me.lbluserid.Size = New System.Drawing.Size(69, 19)
        Me.lbluserid.TabIndex = 33
        Me.lbluserid.Text = "USERID"
        '
        'llblallogin
        '
        Me.llblallogin.AutoSize = True
        Me.llblallogin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblallogin.Location = New System.Drawing.Point(231, 332)
        Me.llblallogin.Name = "llblallogin"
        Me.llblallogin.Size = New System.Drawing.Size(151, 19)
        Me.llblallogin.TabIndex = 32
        Me.llblallogin.TabStop = True
        Me.llblallogin.Text = "Already hava a account"
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(221, 377)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(83, 28)
        Me.btnclear.TabIndex = 31
        Me.btnclear.Text = "  CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnreg
        '
        Me.btnreg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreg.Location = New System.Drawing.Point(78, 377)
        Me.btnreg.Name = "btnreg"
        Me.btnreg.Size = New System.Drawing.Size(103, 28)
        Me.btnreg.TabIndex = 30
        Me.btnreg.Text = "REGISTER"
        Me.btnreg.UseVisualStyleBackColor = True
        '
        'txtmobno
        '
        Me.txtmobno.Location = New System.Drawing.Point(222, 259)
        Me.txtmobno.Name = "txtmobno"
        Me.txtmobno.Size = New System.Drawing.Size(104, 20)
        Me.txtmobno.TabIndex = 29
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(221, 221)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(104, 20)
        Me.txtemail.TabIndex = 28
        '
        'txturepass
        '
        Me.txturepass.Location = New System.Drawing.Point(221, 187)
        Me.txturepass.Name = "txturepass"
        Me.txturepass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txturepass.Size = New System.Drawing.Size(104, 20)
        Me.txturepass.TabIndex = 27
        '
        'txtupass
        '
        Me.txtupass.Location = New System.Drawing.Point(221, 149)
        Me.txtupass.Name = "txtupass"
        Me.txtupass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtupass.Size = New System.Drawing.Size(104, 20)
        Me.txtupass.TabIndex = 26
        '
        'txtuname
        '
        Me.txtuname.Location = New System.Drawing.Point(222, 112)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(104, 20)
        Me.txtuname.TabIndex = 25
        '
        'lablmobno
        '
        Me.lablmobno.AutoSize = True
        Me.lablmobno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablmobno.Location = New System.Drawing.Point(48, 259)
        Me.lablmobno.Name = "lablmobno"
        Me.lablmobno.Size = New System.Drawing.Size(102, 19)
        Me.lablmobno.TabIndex = 24
        Me.lablmobno.Text = "MOBILE NO"
        '
        'lblemal
        '
        Me.lblemal.AutoSize = True
        Me.lblemal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemal.Location = New System.Drawing.Point(48, 220)
        Me.lblemal.Name = "lblemal"
        Me.lblemal.Size = New System.Drawing.Size(83, 19)
        Me.lblemal.TabIndex = 23
        Me.lblemal.Text = "EMAIL ID"
        '
        'lblrepass
        '
        Me.lblrepass.AutoSize = True
        Me.lblrepass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrepass.Location = New System.Drawing.Point(45, 186)
        Me.lblrepass.Name = "lblrepass"
        Me.lblrepass.Size = New System.Drawing.Size(124, 19)
        Me.lblrepass.TabIndex = 22
        Me.lblrepass.Text = "RE-PASSWORD"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.Location = New System.Drawing.Point(46, 149)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(97, 19)
        Me.lblpass.TabIndex = 21
        Me.lblpass.Text = "PASSWORD"
        '
        'lbluname
        '
        Me.lbluname.AutoSize = True
        Me.lbluname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluname.Location = New System.Drawing.Point(46, 112)
        Me.lbluname.Name = "lbluname"
        Me.lbluname.Size = New System.Drawing.Size(100, 19)
        Me.lbluname.TabIndex = 20
        Me.lbluname.Text = "USERNAME"
        '
        'lblusreg
        '
        Me.lblusreg.AutoSize = True
        Me.lblusreg.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusreg.Location = New System.Drawing.Point(74, 26)
        Me.lblusreg.Name = "lblusreg"
        Me.lblusreg.Size = New System.Drawing.Size(210, 22)
        Me.lblusreg.TabIndex = 19
        Me.lblusreg.Text = "USER REGISTRATION"
        '
        'uregvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 461)
        Me.Controls.Add(Me.RDN)
        Me.Controls.Add(Me.RDS)
        Me.Controls.Add(Me.lblup)
        Me.Controls.Add(Me.txtusid)
        Me.Controls.Add(Me.lbluserid)
        Me.Controls.Add(Me.llblallogin)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnreg)
        Me.Controls.Add(Me.txtmobno)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txturepass)
        Me.Controls.Add(Me.txtupass)
        Me.Controls.Add(Me.txtuname)
        Me.Controls.Add(Me.lablmobno)
        Me.Controls.Add(Me.lblemal)
        Me.Controls.Add(Me.lblrepass)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.lbluname)
        Me.Controls.Add(Me.lblusreg)
        Me.Name = "uregvb"
        Me.Text = "uregvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RDN As RadioButton
    Friend WithEvents RDS As RadioButton
    Friend WithEvents lblup As Label
    Friend WithEvents txtusid As TextBox
    Friend WithEvents lbluserid As Label
    Friend WithEvents llblallogin As LinkLabel
    Friend WithEvents btnclear As Button
    Friend WithEvents btnreg As Button
    Friend WithEvents txtmobno As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txturepass As TextBox
    Friend WithEvents txtupass As TextBox
    Friend WithEvents txtuname As TextBox
    Friend WithEvents lablmobno As Label
    Friend WithEvents lblemal As Label
    Friend WithEvents lblrepass As Label
    Friend WithEvents lblpass As Label
    Friend WithEvents lbluname As Label
    Friend WithEvents lblusreg As Label
End Class
