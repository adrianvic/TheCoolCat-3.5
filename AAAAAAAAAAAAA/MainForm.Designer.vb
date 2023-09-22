<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.lbSub = New System.Windows.Forms.Label()
        Me.pbPayload = New System.Windows.Forms.ProgressBar()
        Me.PayloadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lbPayDesc = New System.Windows.Forms.Label()
        Me.lbDescription = New System.Windows.Forms.Label()
        Me.btThanks = New System.Windows.Forms.Button()
        Me.btFakeCancel = New System.Windows.Forms.Button()
        Me.btSecTrap = New System.Windows.Forms.Button()
        Me.btTrap = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.lbVer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbSub
        '
        Me.lbSub.AutoSize = True
        Me.lbSub.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbSub.ForeColor = System.Drawing.Color.White
        Me.lbSub.Location = New System.Drawing.Point(12, 9)
        Me.lbSub.Name = "lbSub"
        Me.lbSub.Size = New System.Drawing.Size(99, 19)
        Me.lbSub.TabIndex = 1
        Me.lbSub.Text = "THECOOLCAT!"
        '
        'pbPayload
        '
        Me.pbPayload.BackColor = System.Drawing.Color.Black
        Me.pbPayload.ForeColor = System.Drawing.Color.White
        Me.pbPayload.Location = New System.Drawing.Point(12, 220)
        Me.pbPayload.Maximum = 3500
        Me.pbPayload.Name = "pbPayload"
        Me.pbPayload.Size = New System.Drawing.Size(350, 23)
        Me.pbPayload.TabIndex = 2
        '
        'PayloadTimer
        '
        Me.PayloadTimer.Enabled = True
        '
        'lbPayDesc
        '
        Me.lbPayDesc.AutoSize = True
        Me.lbPayDesc.Location = New System.Drawing.Point(9, 204)
        Me.lbPayDesc.Name = "lbPayDesc"
        Me.lbPayDesc.Size = New System.Drawing.Size(158, 13)
        Me.lbPayDesc.TabIndex = 3
        Me.lbPayDesc.Text = "Making your computer cool..."
        '
        'lbDescription
        '
        Me.lbDescription.AutoSize = True
        Me.lbDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescription.Location = New System.Drawing.Point(13, 74)
        Me.lbDescription.Name = "lbDescription"
        Me.lbDescription.Size = New System.Drawing.Size(344, 78)
        Me.lbDescription.TabIndex = 4
        Me.lbDescription.Text = resources.GetString("lbDescription.Text")
        '
        'btThanks
        '
        Me.btThanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btThanks.Location = New System.Drawing.Point(173, 191)
        Me.btThanks.Name = "btThanks"
        Me.btThanks.Size = New System.Drawing.Size(108, 23)
        Me.btThanks.TabIndex = 5
        Me.btThanks.Text = "Thanks Cool Cat!"
        Me.btThanks.UseVisualStyleBackColor = True
        '
        'btFakeCancel
        '
        Me.btFakeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFakeCancel.Location = New System.Drawing.Point(287, 191)
        Me.btFakeCancel.Name = "btFakeCancel"
        Me.btFakeCancel.Size = New System.Drawing.Size(75, 23)
        Me.btFakeCancel.TabIndex = 8
        Me.btFakeCancel.Text = "Cancel"
        Me.btFakeCancel.UseVisualStyleBackColor = True
        '
        'btSecTrap
        '
        Me.btSecTrap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSecTrap.Location = New System.Drawing.Point(36, 116)
        Me.btSecTrap.Name = "btSecTrap"
        Me.btSecTrap.Size = New System.Drawing.Size(75, 23)
        Me.btSecTrap.TabIndex = 9
        Me.btSecTrap.Text = "Cancel"
        Me.btSecTrap.UseVisualStyleBackColor = True
        Me.btSecTrap.Visible = False
        '
        'btTrap
        '
        Me.btTrap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTrap.Location = New System.Drawing.Point(220, 47)
        Me.btTrap.Name = "btTrap"
        Me.btTrap.Size = New System.Drawing.Size(75, 23)
        Me.btTrap.TabIndex = 10
        Me.btTrap.Text = "Cancel"
        Me.btTrap.UseVisualStyleBackColor = True
        Me.btTrap.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Black
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(-1, 241)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(34, 13)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "OwO"
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.lbTitle.ForeColor = System.Drawing.Color.White
        Me.lbTitle.Location = New System.Drawing.Point(6, 20)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(449, 54)
        Me.lbTitle.TabIndex = 12
        Me.lbTitle.Text = "installing+the+cool+cat"
        '
        'lbVer
        '
        Me.lbVer.AutoSize = True
        Me.lbVer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbVer.ForeColor = System.Drawing.Color.White
        Me.lbVer.Location = New System.Drawing.Point(327, 7)
        Me.lbVer.Name = "lbVer"
        Me.lbVer.Size = New System.Drawing.Size(35, 19)
        Me.lbVer.TabIndex = 13
        Me.lbVer.Text = "v3.5"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(372, 256)
        Me.Controls.Add(Me.lbVer)
        Me.Controls.Add(Me.btTrap)
        Me.Controls.Add(Me.btSecTrap)
        Me.Controls.Add(Me.btFakeCancel)
        Me.Controls.Add(Me.btThanks)
        Me.Controls.Add(Me.lbDescription)
        Me.Controls.Add(Me.lbPayDesc)
        Me.Controls.Add(Me.pbPayload)
        Me.Controls.Add(Me.lbSub)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lbTitle)
        Me.Cursor = System.Windows.Forms.Cursors.PanNorth
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TheCoolCat!"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbSub As System.Windows.Forms.Label
    Friend WithEvents pbPayload As System.Windows.Forms.ProgressBar
    Friend WithEvents PayloadTimer As System.Windows.Forms.Timer
    Friend WithEvents lbPayDesc As System.Windows.Forms.Label
    Friend WithEvents lbDescription As System.Windows.Forms.Label
    Friend WithEvents btThanks As System.Windows.Forms.Button
    Friend WithEvents btFakeCancel As System.Windows.Forms.Button
    Friend WithEvents btSecTrap As System.Windows.Forms.Button
    Friend WithEvents btTrap As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lbTitle As Label
    Friend WithEvents lbVer As Label
End Class
