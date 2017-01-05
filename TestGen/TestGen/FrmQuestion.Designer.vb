<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuestion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblQnum = New System.Windows.Forms.Label()
        Me.rdoT = New System.Windows.Forms.RadioButton()
        Me.rdoF = New System.Windows.Forms.RadioButton()
        Me.btnNextQuestion = New System.Windows.Forms.Button()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.GroupBoxTF = New System.Windows.Forms.GroupBox()
        Me.GroupBoxTF.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the correct answer:"
        '
        'lblQnum
        '
        Me.lblQnum.AutoSize = True
        Me.lblQnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQnum.Location = New System.Drawing.Point(41, 54)
        Me.lblQnum.Name = "lblQnum"
        Me.lblQnum.Size = New System.Drawing.Size(19, 15)
        Me.lblQnum.TabIndex = 1
        Me.lblQnum.Text = "1."
        '
        'rdoT
        '
        Me.rdoT.AutoSize = True
        Me.rdoT.Location = New System.Drawing.Point(17, 19)
        Me.rdoT.Name = "rdoT"
        Me.rdoT.Size = New System.Drawing.Size(32, 17)
        Me.rdoT.TabIndex = 3
        Me.rdoT.Text = "T"
        Me.rdoT.UseVisualStyleBackColor = True
        '
        'rdoF
        '
        Me.rdoF.AutoSize = True
        Me.rdoF.Location = New System.Drawing.Point(17, 42)
        Me.rdoF.Name = "rdoF"
        Me.rdoF.Size = New System.Drawing.Size(31, 17)
        Me.rdoF.TabIndex = 4
        Me.rdoF.Text = "F"
        Me.rdoF.UseVisualStyleBackColor = True
        '
        'btnNextQuestion
        '
        Me.btnNextQuestion.Location = New System.Drawing.Point(144, 209)
        Me.btnNextQuestion.Name = "btnNextQuestion"
        Me.btnNextQuestion.Size = New System.Drawing.Size(126, 23)
        Me.btnNextQuestion.TabIndex = 5
        Me.btnNextQuestion.Text = "Next Question"
        Me.btnNextQuestion.UseVisualStyleBackColor = True
        '
        'lblQuestion
        '
        Me.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(102, 54)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(237, 47)
        Me.lblQuestion.TabIndex = 6
        Me.lblQuestion.Text = "Question"
        '
        'GroupBoxTF
        '
        Me.GroupBoxTF.Controls.Add(Me.rdoT)
        Me.GroupBoxTF.Controls.Add(Me.rdoF)
        Me.GroupBoxTF.Location = New System.Drawing.Point(105, 118)
        Me.GroupBoxTF.Name = "GroupBoxTF"
        Me.GroupBoxTF.Size = New System.Drawing.Size(68, 85)
        Me.GroupBoxTF.TabIndex = 7
        Me.GroupBoxTF.TabStop = False
        '
        'FrmQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBoxTF)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnNextQuestion)
        Me.Controls.Add(Me.lblQnum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQuestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "rfk wishes you good Luck!"
        Me.GroupBoxTF.ResumeLayout(False)
        Me.GroupBoxTF.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblQnum As System.Windows.Forms.Label
    Friend WithEvents rdoT As System.Windows.Forms.RadioButton
    Friend WithEvents rdoF As System.Windows.Forms.RadioButton
    Friend WithEvents btnNextQuestion As System.Windows.Forms.Button
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents GroupBoxTF As System.Windows.Forms.GroupBox
End Class
