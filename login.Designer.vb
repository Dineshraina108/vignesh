<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.pnllog = New System.Windows.Forms.Panel()
        Me.btncnl = New System.Windows.Forms.Button()
        Me.llblsignup = New System.Windows.Forms.LinkLabel()
        Me.btnlog = New System.Windows.Forms.Button()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.lblpw = New System.Windows.Forms.Label()
        Me.lbluname = New System.Windows.Forms.Label()
        Me.ttle = New System.Windows.Forms.Label()
        Me.pnllog.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnllog
        '
        Me.pnllog.BackColor = System.Drawing.Color.AliceBlue
        Me.pnllog.Controls.Add(Me.btncnl)
        Me.pnllog.Controls.Add(Me.llblsignup)
        Me.pnllog.Controls.Add(Me.btnlog)
        Me.pnllog.Controls.Add(Me.txtpw)
        Me.pnllog.Controls.Add(Me.txtuname)
        Me.pnllog.Controls.Add(Me.lblpw)
        Me.pnllog.Controls.Add(Me.lbluname)
        Me.pnllog.Location = New System.Drawing.Point(42, 51)
        Me.pnllog.Name = "pnllog"
        Me.pnllog.Size = New System.Drawing.Size(313, 212)
        Me.pnllog.TabIndex = 0
        '
        'btncnl
        '
        Me.btncnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btncnl.Location = New System.Drawing.Point(180, 167)
        Me.btncnl.Name = "btncnl"
        Me.btncnl.Size = New System.Drawing.Size(71, 30)
        Me.btncnl.TabIndex = 11
        Me.btncnl.Text = "CANCEL"
        Me.btncnl.UseVisualStyleBackColor = False
        '
        'llblsignup
        '
        Me.llblsignup.AutoSize = True
        Me.llblsignup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblsignup.Location = New System.Drawing.Point(221, 136)
        Me.llblsignup.Name = "llblsignup"
        Me.llblsignup.Size = New System.Drawing.Size(50, 19)
        Me.llblsignup.TabIndex = 10
        Me.llblsignup.TabStop = True
        Me.llblsignup.Text = "Signup"
        '
        'btnlog
        '
        Me.btnlog.BackColor = System.Drawing.SystemColors.Info
        Me.btnlog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlog.ForeColor = System.Drawing.Color.Brown
        Me.btnlog.Location = New System.Drawing.Point(75, 166)
        Me.btnlog.Name = "btnlog"
        Me.btnlog.Size = New System.Drawing.Size(74, 31)
        Me.btnlog.TabIndex = 4
        Me.btnlog.Text = "SIGN IN"
        Me.btnlog.UseVisualStyleBackColor = False
        '
        'txtpw
        '
        Me.txtpw.Location = New System.Drawing.Point(136, 104)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.Size = New System.Drawing.Size(100, 20)
        Me.txtpw.TabIndex = 3
        '
        'txtuname
        '
        Me.txtuname.Location = New System.Drawing.Point(136, 53)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(100, 20)
        Me.txtuname.TabIndex = 2
        '
        'lblpw
        '
        Me.lblpw.AutoSize = True
        Me.lblpw.Location = New System.Drawing.Point(31, 107)
        Me.lblpw.Name = "lblpw"
        Me.lblpw.Size = New System.Drawing.Size(70, 13)
        Me.lblpw.TabIndex = 1
        Me.lblpw.Text = "PASSWORD"
        '
        'lbluname
        '
        Me.lbluname.AutoSize = True
        Me.lbluname.Location = New System.Drawing.Point(31, 53)
        Me.lbluname.Name = "lbluname"
        Me.lbluname.Size = New System.Drawing.Size(71, 13)
        Me.lbluname.TabIndex = 0
        Me.lbluname.Text = "USER NAME"
        '
        'ttle
        '
        Me.ttle.AutoSize = True
        Me.ttle.BackColor = System.Drawing.Color.LavenderBlush
        Me.ttle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttle.Location = New System.Drawing.Point(165, 15)
        Me.ttle.Name = "ttle"
        Me.ttle.Size = New System.Drawing.Size(64, 20)
        Me.ttle.TabIndex = 11
        Me.ttle.Text = "LOGIN"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(395, 296)
        Me.Controls.Add(Me.ttle)
        Me.Controls.Add(Me.pnllog)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.pnllog.ResumeLayout(False)
        Me.pnllog.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnllog As Panel
    Friend WithEvents btnlog As Button
    Friend WithEvents txtpw As TextBox
    Friend WithEvents txtuname As TextBox
    Friend WithEvents lblpw As Label
    Friend WithEvents lbluname As Label
    Friend WithEvents llblsignup As LinkLabel
    Friend WithEvents ttle As Label
    Friend WithEvents btncnl As Button
End Class
