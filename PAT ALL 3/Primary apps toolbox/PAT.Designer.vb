<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PAT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PAT))
        Me.calcbtn = New System.Windows.Forms.Button()
        Me.animalbtn = New System.Windows.Forms.Button()
        Me.highlowbtn = New System.Windows.Forms.Button()
        Me.timetablebtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.endbtn = New System.Windows.Forms.Button()
        Me.userbtn = New System.Windows.Forms.Button()
        Me.hellolbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Helpbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'calcbtn
        '
        Me.calcbtn.Location = New System.Drawing.Point(21, 168)
        Me.calcbtn.Name = "calcbtn"
        Me.calcbtn.Size = New System.Drawing.Size(97, 69)
        Me.calcbtn.TabIndex = 2
        Me.calcbtn.Text = "Calculator"
        Me.calcbtn.UseVisualStyleBackColor = True
        '
        'animalbtn
        '
        Me.animalbtn.Location = New System.Drawing.Point(21, 318)
        Me.animalbtn.Name = "animalbtn"
        Me.animalbtn.Size = New System.Drawing.Size(97, 69)
        Me.animalbtn.TabIndex = 4
        Me.animalbtn.Text = "Animal Game"
        Me.animalbtn.UseVisualStyleBackColor = True
        '
        'highlowbtn
        '
        Me.highlowbtn.Location = New System.Drawing.Point(21, 243)
        Me.highlowbtn.Name = "highlowbtn"
        Me.highlowbtn.Size = New System.Drawing.Size(97, 69)
        Me.highlowbtn.TabIndex = 3
        Me.highlowbtn.Text = "Number Guessing game"
        Me.highlowbtn.UseVisualStyleBackColor = True
        '
        'timetablebtn
        '
        Me.timetablebtn.Location = New System.Drawing.Point(21, 93)
        Me.timetablebtn.Name = "timetablebtn"
        Me.timetablebtn.Size = New System.Drawing.Size(97, 69)
        Me.timetablebtn.TabIndex = 1
        Me.timetablebtn.Text = "Timestable"
        Me.timetablebtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(143, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(818, 535)
        Me.Panel1.TabIndex = 4
        '
        'endbtn
        '
        Me.endbtn.Location = New System.Drawing.Point(895, 653)
        Me.endbtn.Name = "endbtn"
        Me.endbtn.Size = New System.Drawing.Size(97, 69)
        Me.endbtn.TabIndex = 7
        Me.endbtn.Text = "Quit"
        Me.endbtn.UseVisualStyleBackColor = True
        '
        'userbtn
        '
        Me.userbtn.Location = New System.Drawing.Point(792, 653)
        Me.userbtn.Name = "userbtn"
        Me.userbtn.Size = New System.Drawing.Size(97, 69)
        Me.userbtn.TabIndex = 6
        Me.userbtn.Text = "change user"
        Me.userbtn.UseVisualStyleBackColor = True
        '
        'hellolbl
        '
        Me.hellolbl.AutoSize = True
        Me.hellolbl.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hellolbl.Location = New System.Drawing.Point(117, 33)
        Me.hellolbl.Name = "hellolbl"
        Me.hellolbl.Size = New System.Drawing.Size(94, 40)
        Me.hellolbl.TabIndex = 7
        Me.hellolbl.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 40)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Hello"
        '
        'Helpbtn
        '
        Me.Helpbtn.Location = New System.Drawing.Point(21, 653)
        Me.Helpbtn.Name = "Helpbtn"
        Me.Helpbtn.Size = New System.Drawing.Size(97, 69)
        Me.Helpbtn.TabIndex = 5
        Me.Helpbtn.Text = "Help ???"
        Me.Helpbtn.UseVisualStyleBackColor = True
        '
        'PAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1008, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.Helpbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hellolbl)
        Me.Controls.Add(Me.timetablebtn)
        Me.Controls.Add(Me.userbtn)
        Me.Controls.Add(Me.endbtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.highlowbtn)
        Me.Controls.Add(Me.animalbtn)
        Me.Controls.Add(Me.calcbtn)
        Me.Name = "PAT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calcbtn As Button
    Friend WithEvents animalbtn As Button
    Friend WithEvents highlowbtn As Button
    Friend WithEvents timetablebtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents endbtn As Button
    Friend WithEvents userbtn As Button
    Friend WithEvents hellolbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Helpbtn As Button
End Class
