﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(66, 144)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(78, 23)
        Me.btnOne.TabIndex = 0
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Location = New System.Drawing.Point(150, 144)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(78, 23)
        Me.btnTwo.TabIndex = 1
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Location = New System.Drawing.Point(234, 144)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(78, 23)
        Me.btnThree.TabIndex = 2
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.Location = New System.Drawing.Point(318, 144)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(78, 23)
        Me.btnFour.TabIndex = 3
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'btnFive
        '
        Me.btnFive.Location = New System.Drawing.Point(409, 144)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(78, 23)
        Me.btnFive.TabIndex = 4
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(234, 183)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 39)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Do you know the French words for the numbers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                              1 thr" & _
    "ough 5?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            Click the buttons below to see them."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 222)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOne As System.Windows.Forms.Button
    Friend WithEvents btnTwo As System.Windows.Forms.Button
    Friend WithEvents btnThree As System.Windows.Forms.Button
    Friend WithEvents btnFour As System.Windows.Forms.Button
    Friend WithEvents btnFive As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
