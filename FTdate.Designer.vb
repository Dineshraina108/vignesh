<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FTdate
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
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsub = New System.Windows.Forms.Button()
        Me.dttodate = New System.Windows.Forms.DateTimePicker()
        Me.dtfromdate = New System.Windows.Forms.DateTimePicker()
        Me.lbltodate = New System.Windows.Forms.Label()
        Me.lblfromdate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(182, 177)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(85, 28)
        Me.btncancel.TabIndex = 17
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsub
        '
        Me.btnsub.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsub.Location = New System.Drawing.Point(76, 177)
        Me.btnsub.Name = "btnsub"
        Me.btnsub.Size = New System.Drawing.Size(85, 28)
        Me.btnsub.TabIndex = 16
        Me.btnsub.Text = "SUBMIT"
        Me.btnsub.UseVisualStyleBackColor = True
        '
        'dttodate
        '
        Me.dttodate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dttodate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttodate.Location = New System.Drawing.Point(167, 115)
        Me.dttodate.Name = "dttodate"
        Me.dttodate.Size = New System.Drawing.Size(84, 22)
        Me.dttodate.TabIndex = 15
        '
        'dtfromdate
        '
        Me.dtfromdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfromdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfromdate.Location = New System.Drawing.Point(167, 67)
        Me.dtfromdate.Name = "dtfromdate"
        Me.dtfromdate.Size = New System.Drawing.Size(84, 22)
        Me.dtfromdate.TabIndex = 14
        '
        'lbltodate
        '
        Me.lbltodate.AutoSize = True
        Me.lbltodate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltodate.Location = New System.Drawing.Point(66, 115)
        Me.lbltodate.Name = "lbltodate"
        Me.lbltodate.Size = New System.Drawing.Size(63, 19)
        Me.lbltodate.TabIndex = 13
        Me.lbltodate.Text = "To Date"
        '
        'lblfromdate
        '
        Me.lblfromdate.AutoSize = True
        Me.lblfromdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfromdate.Location = New System.Drawing.Point(66, 70)
        Me.lblfromdate.Name = "lblfromdate"
        Me.lblfromdate.Size = New System.Drawing.Size(81, 19)
        Me.lblfromdate.TabIndex = 12
        Me.lblfromdate.Text = "From Date"
        '
        'FTdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 250)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsub)
        Me.Controls.Add(Me.dttodate)
        Me.Controls.Add(Me.dtfromdate)
        Me.Controls.Add(Me.lbltodate)
        Me.Controls.Add(Me.lblfromdate)
        Me.Name = "FTdate"
        Me.Text = "FTdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncancel As Button
    Friend WithEvents btnsub As Button
    Friend WithEvents dttodate As DateTimePicker
    Friend WithEvents dtfromdate As DateTimePicker
    Friend WithEvents lbltodate As Label
    Friend WithEvents lblfromdate As Label
End Class
