<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManualInformation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblHeader1 = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.txtMajor = New System.Windows.Forms.TextBox()
        Me.lblMinor = New System.Windows.Forms.Label()
        Me.txtMinor = New System.Windows.Forms.TextBox()
        Me.lblStudentUNI = New System.Windows.Forms.Label()
        Me.btnRdYes = New System.Windows.Forms.RadioButton()
        Me.btnRdNo = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeader1
        '
        Me.lblHeader1.Font = New System.Drawing.Font("Trajan Pro 3", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader1.Location = New System.Drawing.Point(60, 9)
        Me.lblHeader1.Name = "lblHeader1"
        Me.lblHeader1.Size = New System.Drawing.Size(400, 50)
        Me.lblHeader1.TabIndex = 1
        Me.lblHeader1.Text = "Enter your Information below"
        Me.lblHeader1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLastName
        '
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(95, 128)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(100, 23)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(251, 130)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(251, 83)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 3
        '
        'lblMajor
        '
        Me.lblMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.Location = New System.Drawing.Point(95, 176)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(100, 23)
        Me.lblMajor.TabIndex = 2
        Me.lblMajor.Text = "Major"
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(251, 178)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(100, 20)
        Me.txtMajor.TabIndex = 3
        '
        'lblMinor
        '
        Me.lblMinor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinor.Location = New System.Drawing.Point(95, 225)
        Me.lblMinor.Name = "lblMinor"
        Me.lblMinor.Size = New System.Drawing.Size(100, 23)
        Me.lblMinor.TabIndex = 2
        Me.lblMinor.Text = "Major/Minor"
        '
        'txtMinor
        '
        Me.txtMinor.Location = New System.Drawing.Point(251, 227)
        Me.txtMinor.Name = "txtMinor"
        Me.txtMinor.Size = New System.Drawing.Size(100, 20)
        Me.txtMinor.TabIndex = 3
        '
        'lblStudentUNI
        '
        Me.lblStudentUNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentUNI.Location = New System.Drawing.Point(95, 279)
        Me.lblStudentUNI.Name = "lblStudentUNI"
        Me.lblStudentUNI.Size = New System.Drawing.Size(100, 23)
        Me.lblStudentUNI.TabIndex = 2
        Me.lblStudentUNI.Text = "UNI Student"
        '
        'btnRdYes
        '
        Me.btnRdYes.AutoSize = True
        Me.btnRdYes.Location = New System.Drawing.Point(251, 284)
        Me.btnRdYes.Name = "btnRdYes"
        Me.btnRdYes.Size = New System.Drawing.Size(43, 17)
        Me.btnRdYes.TabIndex = 4
        Me.btnRdYes.TabStop = True
        Me.btnRdYes.Text = "Yes"
        Me.btnRdYes.UseVisualStyleBackColor = True
        '
        'btnRdNo
        '
        Me.btnRdNo.AutoSize = True
        Me.btnRdNo.Location = New System.Drawing.Point(309, 284)
        Me.btnRdNo.Name = "btnRdNo"
        Me.btnRdNo.Size = New System.Drawing.Size(39, 17)
        Me.btnRdNo.TabIndex = 5
        Me.btnRdNo.TabStop = True
        Me.btnRdNo.Text = "No"
        Me.btnRdNo.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Trajan Pro 3", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(203, 327)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(118, 39)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'ManualInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 396)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnRdNo)
        Me.Controls.Add(Me.btnRdYes)
        Me.Controls.Add(Me.txtMinor)
        Me.Controls.Add(Me.txtMajor)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblStudentUNI)
        Me.Controls.Add(Me.lblMinor)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblHeader1)
        Me.Name = "ManualInformation"
        Me.Text = "ManualInformation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader1 As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblMajor As Label
    Friend WithEvents txtMajor As TextBox
    Friend WithEvents lblMinor As Label
    Friend WithEvents txtMinor As TextBox
    Friend WithEvents lblStudentUNI As Label
    Friend WithEvents btnRdYes As RadioButton
    Friend WithEvents btnRdNo As RadioButton
    Friend WithEvents btnSubmit As Button
End Class
