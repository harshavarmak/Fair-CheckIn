<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintConfirm
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
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.lblMinor = New System.Windows.Forms.Label()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPrintLastName = New System.Windows.Forms.Label()
        Me.lblPrintFirstName = New System.Windows.Forms.Label()
        Me.lblPrintMajor = New System.Windows.Forms.Label()
        Me.lblPrintMinor = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblConfirm
        '
        Me.lblConfirm.Font = New System.Drawing.Font("Trajan Pro 3", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.Location = New System.Drawing.Point(176, 9)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(151, 42)
        Me.lblConfirm.TabIndex = 0
        Me.lblConfirm.Text = "Is this you?"
        Me.lblConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinor
        '
        Me.lblMinor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinor.Location = New System.Drawing.Point(99, 237)
        Me.lblMinor.Name = "lblMinor"
        Me.lblMinor.Size = New System.Drawing.Size(100, 23)
        Me.lblMinor.TabIndex = 3
        Me.lblMinor.Text = "Major/Minor"
        '
        'lblMajor
        '
        Me.lblMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.Location = New System.Drawing.Point(99, 188)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(100, 23)
        Me.lblMajor.TabIndex = 4
        Me.lblMajor.Text = "Major"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(99, 140)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(100, 23)
        Me.lblLastName.TabIndex = 6
        Me.lblLastName.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(275, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(275, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(275, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Major"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(275, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Major/Minor"
        '
        'lblPrintLastName
        '
        Me.lblPrintLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrintLastName.Location = New System.Drawing.Point(235, 140)
        Me.lblPrintLastName.Name = "lblPrintLastName"
        Me.lblPrintLastName.Size = New System.Drawing.Size(251, 23)
        Me.lblPrintLastName.TabIndex = 6
        Me.lblPrintLastName.Text = "lblPrintLastName"
        '
        'lblPrintFirstName
        '
        Me.lblPrintFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrintFirstName.Location = New System.Drawing.Point(235, 93)
        Me.lblPrintFirstName.Name = "lblPrintFirstName"
        Me.lblPrintFirstName.Size = New System.Drawing.Size(251, 23)
        Me.lblPrintFirstName.TabIndex = 5
        Me.lblPrintFirstName.Text = "lblPrintFirstName"
        '
        'lblPrintMajor
        '
        Me.lblPrintMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrintMajor.Location = New System.Drawing.Point(235, 188)
        Me.lblPrintMajor.Name = "lblPrintMajor"
        Me.lblPrintMajor.Size = New System.Drawing.Size(251, 23)
        Me.lblPrintMajor.TabIndex = 4
        Me.lblPrintMajor.Text = "lblPrintMajor"
        '
        'lblPrintMinor
        '
        Me.lblPrintMinor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrintMinor.Location = New System.Drawing.Point(235, 237)
        Me.lblPrintMinor.Name = "lblPrintMinor"
        Me.lblPrintMinor.Size = New System.Drawing.Size(251, 23)
        Me.lblPrintMinor.TabIndex = 3
        Me.lblPrintMinor.Text = "lblPrintMinor"
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(316, 328)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 23)
        Me.btnYes.TabIndex = 7
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(124, 328)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 23)
        Me.btnNo.TabIndex = 7
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'PrintConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 396)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblPrintMinor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblMinor)
        Me.Controls.Add(Me.lblPrintMajor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.lblPrintFirstName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPrintLastName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblConfirm)
        Me.Name = "PrintConfirm"
        Me.Text = "PrintConfirm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblConfirm As Label
    Friend WithEvents lblMinor As Label
    Friend WithEvents lblMajor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPrintLastName As Label
    Friend WithEvents lblPrintFirstName As Label
    Friend WithEvents lblPrintMajor As Label
    Friend WithEvents lblPrintMinor As Label
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
End Class
