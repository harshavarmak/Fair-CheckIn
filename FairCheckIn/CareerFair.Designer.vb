<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CareerFair
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
        Me.lblHeader1 = New System.Windows.Forms.Label()
        Me.lblSID = New System.Windows.Forms.Label()
        Me.txtSID = New System.Windows.Forms.TextBox()
        Me.btnRdUnknownSID = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeader1
        '
        Me.lblHeader1.Font = New System.Drawing.Font("Trajan Pro 3", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader1.Location = New System.Drawing.Point(60, 9)
        Me.lblHeader1.Name = "lblHeader1"
        Me.lblHeader1.Size = New System.Drawing.Size(400, 50)
        Me.lblHeader1.TabIndex = 0
        Me.lblHeader1.Text = "Enter your Information below"
        Me.lblHeader1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSID
        '
        Me.lblSID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSID.Location = New System.Drawing.Point(62, 131)
        Me.lblSID.Name = "lblSID"
        Me.lblSID.Size = New System.Drawing.Size(268, 46)
        Me.lblSID.TabIndex = 1
        Me.lblSID.Text = "Enter your UNI student ID number"
        Me.lblSID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSID
        '
        Me.txtSID.Location = New System.Drawing.Point(337, 147)
        Me.txtSID.Name = "txtSID"
        Me.txtSID.Size = New System.Drawing.Size(100, 20)
        Me.txtSID.TabIndex = 2
        '
        'btnRdUnknownSID
        '
        Me.btnRdUnknownSID.AutoSize = True
        Me.btnRdUnknownSID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRdUnknownSID.Location = New System.Drawing.Point(94, 223)
        Me.btnRdUnknownSID.Name = "btnRdUnknownSID"
        Me.btnRdUnknownSID.Size = New System.Drawing.Size(316, 21)
        Me.btnRdUnknownSID.TabIndex = 3
        Me.btnRdUnknownSID.TabStop = True
        Me.btnRdUnknownSID.Text = "Don't know/Don't have UNI Student ID number"
        Me.btnRdUnknownSID.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Trajan Pro 3", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(201, 318)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(105, 38)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'CareerFair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 396)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnRdUnknownSID)
        Me.Controls.Add(Me.txtSID)
        Me.Controls.Add(Me.lblSID)
        Me.Controls.Add(Me.lblHeader1)
        Me.Name = "CareerFair"
        Me.Text = "CareerFair"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader1 As Label
    Friend WithEvents lblSID As Label
    Friend WithEvents txtSID As TextBox
    Friend WithEvents btnRdUnknownSID As RadioButton
    Friend WithEvents btnNext As Button
End Class
