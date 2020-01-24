<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Animal_game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Animal_game))
        Me.tbxscore = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.btnplay = New System.Windows.Forms.Button()
        Me.pbanswer3 = New System.Windows.Forms.PictureBox()
        Me.pbanswer2 = New System.Windows.Forms.PictureBox()
        Me.pbanswer4 = New System.Windows.Forms.PictureBox()
        Me.pbanswer1 = New System.Windows.Forms.PictureBox()
        CType(Me.pbanswer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbanswer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbanswer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbanswer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbxscore
        '
        Me.tbxscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxscore.Location = New System.Drawing.Point(305, 401)
        Me.tbxscore.Name = "tbxscore"
        Me.tbxscore.Size = New System.Drawing.Size(36, 29)
        Me.tbxscore.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 403)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 27)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Score"
        '
        'closebtn
        '
        Me.closebtn.Location = New System.Drawing.Point(598, 403)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(88, 54)
        Me.closebtn.TabIndex = 45
        Me.closebtn.Text = "Close"
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'btnplay
        '
        Me.btnplay.Image = CType(resources.GetObject("btnplay.Image"), System.Drawing.Image)
        Me.btnplay.Location = New System.Drawing.Point(239, 151)
        Me.btnplay.Name = "btnplay"
        Me.btnplay.Size = New System.Drawing.Size(139, 98)
        Me.btnplay.TabIndex = 44
        Me.btnplay.UseVisualStyleBackColor = True
        '
        'pbanswer3
        '
        Me.pbanswer3.BackColor = System.Drawing.Color.White
        Me.pbanswer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbanswer3.Location = New System.Drawing.Point(12, 210)
        Me.pbanswer3.Name = "pbanswer3"
        Me.pbanswer3.Size = New System.Drawing.Size(256, 168)
        Me.pbanswer3.TabIndex = 43
        Me.pbanswer3.TabStop = False
        '
        'pbanswer2
        '
        Me.pbanswer2.BackColor = System.Drawing.Color.White
        Me.pbanswer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbanswer2.Location = New System.Drawing.Point(341, 12)
        Me.pbanswer2.Name = "pbanswer2"
        Me.pbanswer2.Size = New System.Drawing.Size(256, 168)
        Me.pbanswer2.TabIndex = 42
        Me.pbanswer2.TabStop = False
        '
        'pbanswer4
        '
        Me.pbanswer4.BackColor = System.Drawing.Color.White
        Me.pbanswer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbanswer4.Location = New System.Drawing.Point(341, 210)
        Me.pbanswer4.Name = "pbanswer4"
        Me.pbanswer4.Size = New System.Drawing.Size(256, 168)
        Me.pbanswer4.TabIndex = 41
        Me.pbanswer4.TabStop = False
        '
        'pbanswer1
        '
        Me.pbanswer1.BackColor = System.Drawing.Color.White
        Me.pbanswer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbanswer1.Location = New System.Drawing.Point(12, 12)
        Me.pbanswer1.Name = "pbanswer1"
        Me.pbanswer1.Size = New System.Drawing.Size(256, 168)
        Me.pbanswer1.TabIndex = 40
        Me.pbanswer1.TabStop = False
        '
        'Animal_game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbxscore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.btnplay)
        Me.Controls.Add(Me.pbanswer3)
        Me.Controls.Add(Me.pbanswer2)
        Me.Controls.Add(Me.pbanswer4)
        Me.Controls.Add(Me.pbanswer1)
        Me.Name = "Animal_game"
        CType(Me.pbanswer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbanswer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbanswer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbanswer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxscore As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents closebtn As Button
    Friend WithEvents btnplay As Button
    Friend WithEvents pbanswer3 As PictureBox
    Friend WithEvents pbanswer2 As PictureBox
    Friend WithEvents pbanswer4 As PictureBox
    Friend WithEvents pbanswer1 As PictureBox
End Class
