<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(31, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(254, 33)
        Me.ComboBox1.TabIndex = 2
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(21, 30)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(87, 29)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "High"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(21, 65)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(82, 29)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Low"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(65, 516)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 111)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pin 1"
        Me.GroupBox1.Visible = False
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.RadioButton15)
        Me.GroupBox14.Controls.Add(Me.RadioButton16)
        Me.GroupBox14.Location = New System.Drawing.Point(97, 396)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(134, 111)
        Me.GroupBox14.TabIndex = 7
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Pin 0"
        Me.GroupBox14.Visible = False
        '
        'RadioButton15
        '
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.Location = New System.Drawing.Point(21, 30)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(87, 29)
        Me.RadioButton15.TabIndex = 3
        Me.RadioButton15.TabStop = True
        Me.RadioButton15.Text = "High"
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.Location = New System.Drawing.Point(21, 65)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(82, 29)
        Me.RadioButton16.TabIndex = 4
        Me.RadioButton16.TabStop = True
        Me.RadioButton16.Text = "Low"
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Location = New System.Drawing.Point(344, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 111)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pin 2"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(21, 30)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(87, 29)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "High"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(21, 65)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(82, 29)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Low"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox1.Location = New System.Drawing.Point(6, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 31)
        Me.TextBox1.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton3)
        Me.GroupBox3.Controls.Add(Me.RadioButton6)
        Me.GroupBox3.Location = New System.Drawing.Point(676, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(134, 111)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pin 4"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(21, 30)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(87, 29)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "High"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(21, 65)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(82, 29)
        Me.RadioButton6.TabIndex = 4
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Low"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(508, 48)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(134, 84)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pin 3"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(92, 72)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 12)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button8)
        Me.GroupBox5.Controls.Add(Me.TextBox2)
        Me.GroupBox5.Location = New System.Drawing.Point(344, 175)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(134, 84)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Pin 5"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(92, 72)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(42, 12)
        Me.Button8.TabIndex = 19
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox2.Location = New System.Drawing.Point(6, 30)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(122, 31)
        Me.TextBox2.TabIndex = 8
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton7)
        Me.GroupBox6.Controls.Add(Me.RadioButton8)
        Me.GroupBox6.Location = New System.Drawing.Point(676, 165)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(134, 111)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Pin 7"
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(21, 30)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(87, 29)
        Me.RadioButton7.TabIndex = 3
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "High"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(21, 65)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(82, 29)
        Me.RadioButton8.TabIndex = 4
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Low"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button7)
        Me.GroupBox7.Controls.Add(Me.TextBox3)
        Me.GroupBox7.Location = New System.Drawing.Point(508, 175)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(134, 84)
        Me.GroupBox7.TabIndex = 11
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Pin 6"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(92, 72)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(42, 12)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox3.Location = New System.Drawing.Point(6, 30)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(122, 31)
        Me.TextBox3.TabIndex = 8
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.RadioButton9)
        Me.GroupBox8.Controls.Add(Me.RadioButton10)
        Me.GroupBox8.Location = New System.Drawing.Point(344, 288)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(134, 111)
        Me.GroupBox8.TabIndex = 10
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Pin 8"
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(21, 30)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(87, 29)
        Me.RadioButton9.TabIndex = 3
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "High"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(21, 65)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(82, 29)
        Me.RadioButton10.TabIndex = 4
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "Low"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Button6)
        Me.GroupBox9.Controls.Add(Me.TextBox4)
        Me.GroupBox9.Location = New System.Drawing.Point(508, 298)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(134, 84)
        Me.GroupBox9.TabIndex = 12
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Pin 9"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(92, 72)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(42, 12)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox4.Location = New System.Drawing.Point(6, 30)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(122, 31)
        Me.TextBox4.TabIndex = 8
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Button4)
        Me.GroupBox10.Controls.Add(Me.TextBox5)
        Me.GroupBox10.Location = New System.Drawing.Point(676, 298)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(134, 84)
        Me.GroupBox10.TabIndex = 13
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Pin 10"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(92, 72)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(42, 12)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox5.Location = New System.Drawing.Point(6, 30)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(122, 31)
        Me.TextBox5.TabIndex = 8
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Button5)
        Me.GroupBox11.Controls.Add(Me.TextBox6)
        Me.GroupBox11.Location = New System.Drawing.Point(344, 423)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(134, 84)
        Me.GroupBox11.TabIndex = 14
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Pin 11"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(92, 72)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(42, 12)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TextBox6.Location = New System.Drawing.Point(6, 30)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(122, 31)
        Me.TextBox6.TabIndex = 8
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(21, 65)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(82, 29)
        Me.RadioButton12.TabIndex = 4
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = "Low"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(21, 30)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(87, 29)
        Me.RadioButton11.TabIndex = 3
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.Text = "High"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.RadioButton11)
        Me.GroupBox12.Controls.Add(Me.RadioButton12)
        Me.GroupBox12.Location = New System.Drawing.Point(508, 413)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(134, 111)
        Me.GroupBox12.TabIndex = 11
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Pin 12"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.RadioButton13)
        Me.GroupBox13.Controls.Add(Me.RadioButton14)
        Me.GroupBox13.Location = New System.Drawing.Point(676, 413)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(134, 111)
        Me.GroupBox13.TabIndex = 12
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Pin 13"
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.Location = New System.Drawing.Point(21, 30)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(87, 29)
        Me.RadioButton13.TabIndex = 3
        Me.RadioButton13.TabStop = True
        Me.RadioButton13.Text = "High"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.Location = New System.Drawing.Point(21, 65)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(82, 29)
        Me.RadioButton14.TabIndex = 4
        Me.RadioButton14.TabStop = True
        Me.RadioButton14.Text = "Low"
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 563)
        Me.Controls.Add(Me.GroupBox14)
        Me.Controls.Add(Me.GroupBox13)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Public WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents RadioButton14 As RadioButton
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents RadioButton15 As RadioButton
    Friend WithEvents RadioButton16 As RadioButton
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
