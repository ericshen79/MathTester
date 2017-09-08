<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Me.txtMinus = New System.Windows.Forms.TextBox()
        Me.lblQuestion4 = New System.Windows.Forms.Label()
        Me.txtPlus = New System.Windows.Forms.TextBox()
        Me.lblQuestion3 = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.lblQuestion2 = New System.Windows.Forms.Label()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.lblQuestion1 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSeconds = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbOpt = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtMinus
        '
        Me.txtMinus.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinus.Location = New System.Drawing.Point(437, 253)
        Me.txtMinus.Name = "txtMinus"
        Me.txtMinus.Size = New System.Drawing.Size(100, 47)
        Me.txtMinus.TabIndex = 12
        '
        'lblQuestion4
        '
        Me.lblQuestion4.AutoSize = True
        Me.lblQuestion4.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion4.Location = New System.Drawing.Point(26, 253)
        Me.lblQuestion4.Name = "lblQuestion4"
        Me.lblQuestion4.Size = New System.Drawing.Size(304, 39)
        Me.lblQuestion4.TabIndex = 5
        Me.lblQuestion4.Text = "Mininum Minus Value"
        '
        'txtPlus
        '
        Me.txtPlus.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlus.Location = New System.Drawing.Point(437, 177)
        Me.txtPlus.Name = "txtPlus"
        Me.txtPlus.Size = New System.Drawing.Size(100, 47)
        Me.txtPlus.TabIndex = 11
        '
        'lblQuestion3
        '
        Me.lblQuestion3.AutoSize = True
        Me.lblQuestion3.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion3.Location = New System.Drawing.Point(26, 177)
        Me.lblQuestion3.Name = "lblQuestion3"
        Me.lblQuestion3.Size = New System.Drawing.Size(267, 39)
        Me.lblQuestion3.TabIndex = 6
        Me.lblQuestion3.Text = "Max Add Up Value"
        '
        'txtMin
        '
        Me.txtMin.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.Location = New System.Drawing.Point(437, 101)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(100, 47)
        Me.txtMin.TabIndex = 10
        '
        'lblQuestion2
        '
        Me.lblQuestion2.AutoSize = True
        Me.lblQuestion2.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion2.Location = New System.Drawing.Point(26, 101)
        Me.lblQuestion2.Name = "lblQuestion2"
        Me.lblQuestion2.Size = New System.Drawing.Size(261, 39)
        Me.lblQuestion2.TabIndex = 7
        Me.lblQuestion2.Text = "Minimum Number"
        '
        'txtMax
        '
        Me.txtMax.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMax.Location = New System.Drawing.Point(437, 24)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(100, 47)
        Me.txtMax.TabIndex = 8
        '
        'lblQuestion1
        '
        Me.lblQuestion1.AutoSize = True
        Me.lblQuestion1.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion1.Location = New System.Drawing.Point(26, 24)
        Me.lblQuestion1.Name = "lblQuestion1"
        Me.lblQuestion1.Size = New System.Drawing.Size(269, 39)
        Me.lblQuestion1.TabIndex = 9
        Me.lblQuestion1.Text = "Maximum Number"
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(33, 485)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(155, 42)
        Me.btnOK.TabIndex = 31
        Me.btnOK.Text = "OK, Apply"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Time Limit in Seconds"
        '
        'txtSeconds
        '
        Me.txtSeconds.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeconds.Location = New System.Drawing.Point(437, 332)
        Me.txtSeconds.Name = "txtSeconds"
        Me.txtSeconds.Size = New System.Drawing.Size(100, 47)
        Me.txtSeconds.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 407)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 39)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Operator Selection"
        '
        'cmbOpt
        '
        Me.cmbOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOpt.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOpt.FormattingEnabled = True
        Me.cmbOpt.Location = New System.Drawing.Point(316, 407)
        Me.cmbOpt.Name = "cmbOpt"
        Me.cmbOpt.Size = New System.Drawing.Size(224, 34)
        Me.cmbOpt.TabIndex = 33
        '
        'frmConfig
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 549)
        Me.Controls.Add(Me.cmbOpt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtSeconds)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMinus)
        Me.Controls.Add(Me.lblQuestion4)
        Me.Controls.Add(Me.txtPlus)
        Me.Controls.Add(Me.lblQuestion3)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.lblQuestion2)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.lblQuestion1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmConfig"
        Me.Text = "Configuration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMinus As TextBox
    Friend WithEvents lblQuestion4 As Label
    Friend WithEvents txtPlus As TextBox
    Friend WithEvents lblQuestion3 As Label
    Friend WithEvents txtMin As TextBox
    Friend WithEvents lblQuestion2 As Label
    Friend WithEvents txtMax As TextBox
    Friend WithEvents lblQuestion1 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSeconds As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbOpt As ComboBox
End Class
