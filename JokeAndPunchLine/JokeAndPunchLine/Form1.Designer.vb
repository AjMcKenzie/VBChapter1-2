<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnPunchLine = New System.Windows.Forms.Button()
        Me.lblJoke = New System.Windows.Forms.Label()
        Me.btnNextJoke = New System.Windows.Forms.Button()
        Me.btnSteup2 = New System.Windows.Forms.Button()
        Me.btnPunchLine2 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(17, 109)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnPunchLine
        '
        Me.btnPunchLine.Location = New System.Drawing.Point(122, 109)
        Me.btnPunchLine.Name = "btnPunchLine"
        Me.btnPunchLine.Size = New System.Drawing.Size(75, 23)
        Me.btnPunchLine.TabIndex = 1
        Me.btnPunchLine.Text = "Punch Line"
        Me.btnPunchLine.UseVisualStyleBackColor = True
        '
        'lblJoke
        '
        Me.lblJoke.AutoSize = True
        Me.lblJoke.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoke.Location = New System.Drawing.Point(12, 9)
        Me.lblJoke.Name = "lblJoke"
        Me.lblJoke.Size = New System.Drawing.Size(203, 27)
        Me.lblJoke.TabIndex = 2
        Me.lblJoke.Text = "Click setup for joke."
        '
        'btnNextJoke
        '
        Me.btnNextJoke.Location = New System.Drawing.Point(232, 109)
        Me.btnNextJoke.Name = "btnNextJoke"
        Me.btnNextJoke.Size = New System.Drawing.Size(75, 23)
        Me.btnNextJoke.TabIndex = 3
        Me.btnNextJoke.Text = "Next Joke"
        Me.btnNextJoke.UseVisualStyleBackColor = True
        '
        'btnSteup2
        '
        Me.btnSteup2.Location = New System.Drawing.Point(17, 109)
        Me.btnSteup2.Name = "btnSteup2"
        Me.btnSteup2.Size = New System.Drawing.Size(75, 23)
        Me.btnSteup2.TabIndex = 4
        Me.btnSteup2.Text = "Setup"
        Me.btnSteup2.UseVisualStyleBackColor = True
        Me.btnSteup2.Visible = False
        '
        'btnPunchLine2
        '
        Me.btnPunchLine2.Location = New System.Drawing.Point(122, 109)
        Me.btnPunchLine2.Name = "btnPunchLine2"
        Me.btnPunchLine2.Size = New System.Drawing.Size(75, 23)
        Me.btnPunchLine2.TabIndex = 5
        Me.btnPunchLine2.Text = "Punch Line"
        Me.btnPunchLine2.UseVisualStyleBackColor = True
        Me.btnPunchLine2.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(232, 109)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 181)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPunchLine2)
        Me.Controls.Add(Me.btnSteup2)
        Me.Controls.Add(Me.btnNextJoke)
        Me.Controls.Add(Me.lblJoke)
        Me.Controls.Add(Me.btnPunchLine)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents btnPunchLine As System.Windows.Forms.Button
    Friend WithEvents lblJoke As System.Windows.Forms.Label
    Friend WithEvents btnNextJoke As System.Windows.Forms.Button
    Friend WithEvents btnSteup2 As System.Windows.Forms.Button
    Friend WithEvents btnPunchLine2 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
