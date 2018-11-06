<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
   Inherits System.Windows.Forms.Form

   'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

   'Wird vom Windows Form-Designer benötigt.
   Private components As System.ComponentModel.IContainer

   'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
   'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
   'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.btn1 = New System.Windows.Forms.Button()
      Me.btn2 = New System.Windows.Forms.Button()
      Me.btn3 = New System.Windows.Forms.Button()
      Me.btn4 = New System.Windows.Forms.Button()
      Me.btn5 = New System.Windows.Forms.Button()
      Me.btn6 = New System.Windows.Forms.Button()
      Me.btn7 = New System.Windows.Forms.Button()
      Me.btn8 = New System.Windows.Forms.Button()
      Me.btn9 = New System.Windows.Forms.Button()
      Me.btnReset = New System.Windows.Forms.Button()
      Me.txtSpieler = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'btn1
      '
      Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btn1.Location = New System.Drawing.Point(35, 42)
      Me.btn1.Name = "btn1"
      Me.btn1.Size = New System.Drawing.Size(80, 74)
      Me.btn1.TabIndex = 0
      Me.btn1.UseVisualStyleBackColor = True
      '
      'btn2
      '
      Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btn2.Location = New System.Drawing.Point(121, 42)
      Me.btn2.Name = "btn2"
      Me.btn2.Size = New System.Drawing.Size(80, 74)
      Me.btn2.TabIndex = 1
      Me.btn2.UseVisualStyleBackColor = True
      '
      'btn3
      '
      Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btn3.Location = New System.Drawing.Point(207, 42)
      Me.btn3.Name = "btn3"
      Me.btn3.Size = New System.Drawing.Size(80, 74)
      Me.btn3.TabIndex = 2
      Me.btn3.UseVisualStyleBackColor = True
      '
      'btn4
      '
      Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btn4.Location = New System.Drawing.Point(35, 122)
      Me.btn4.Name = "btn4"
      Me.btn4.Size = New System.Drawing.Size(80, 74)
      Me.btn4.TabIndex = 3
      Me.btn4.UseVisualStyleBackColor = True
      '
      'btn5
      '
      Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btn5.Location = New System.Drawing.Point(121, 122)
      Me.btn5.Name = "btn5"
      Me.btn5.Size = New System.Drawing.Size(80, 74)
      Me.btn5.TabIndex = 4
      Me.btn5.UseVisualStyleBackColor = True
      '
      'btn6
      '
      Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btn6.Location = New System.Drawing.Point(207, 122)
      Me.btn6.Name = "btn6"
      Me.btn6.Size = New System.Drawing.Size(80, 74)
      Me.btn6.TabIndex = 5
      Me.btn6.UseVisualStyleBackColor = True
      '
      'btn7
      '
      Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btn7.Location = New System.Drawing.Point(35, 202)
      Me.btn7.Name = "btn7"
      Me.btn7.Size = New System.Drawing.Size(80, 74)
      Me.btn7.TabIndex = 6
      Me.btn7.UseVisualStyleBackColor = True
      '
      'btn8
      '
      Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btn8.Location = New System.Drawing.Point(121, 202)
      Me.btn8.Name = "btn8"
      Me.btn8.Size = New System.Drawing.Size(80, 74)
      Me.btn8.TabIndex = 7
      Me.btn8.UseVisualStyleBackColor = True
      '
      'btn9
      '
      Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btn9.Location = New System.Drawing.Point(207, 202)
      Me.btn9.Name = "btn9"
      Me.btn9.Size = New System.Drawing.Size(80, 74)
      Me.btn9.TabIndex = 8
      Me.btn9.UseVisualStyleBackColor = True
      '
      'btnReset
      '
      Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnReset.Location = New System.Drawing.Point(419, 87)
      Me.btnReset.Name = "btnReset"
      Me.btnReset.Size = New System.Drawing.Size(258, 214)
      Me.btnReset.TabIndex = 10
      Me.btnReset.Text = "Reset"
      Me.btnReset.UseVisualStyleBackColor = True
      '
      'txtSpieler
      '
      Me.txtSpieler.Enabled = False
      Me.txtSpieler.Location = New System.Drawing.Point(651, 47)
      Me.txtSpieler.Name = "txtSpieler"
      Me.txtSpieler.Size = New System.Drawing.Size(134, 20)
      Me.txtSpieler.TabIndex = 11
      Me.txtSpieler.Text = "Mensch"
      Me.txtSpieler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Form3
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(800, 450)
      Me.Controls.Add(Me.txtSpieler)
      Me.Controls.Add(Me.btnReset)
      Me.Controls.Add(Me.btn9)
      Me.Controls.Add(Me.btn8)
      Me.Controls.Add(Me.btn7)
      Me.Controls.Add(Me.btn6)
      Me.Controls.Add(Me.btn5)
      Me.Controls.Add(Me.btn4)
      Me.Controls.Add(Me.btn3)
      Me.Controls.Add(Me.btn2)
      Me.Controls.Add(Me.btn1)
      Me.Name = "Form3"
      Me.Text = "Form3"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents btn1 As Button
   Friend WithEvents btn2 As Button
   Friend WithEvents btn3 As Button
   Friend WithEvents btn4 As Button
   Friend WithEvents btn5 As Button
   Friend WithEvents btn6 As Button
   Friend WithEvents btn7 As Button
   Friend WithEvents btn8 As Button
   Friend WithEvents btn9 As Button
   Friend WithEvents btnReset As Button
   Friend WithEvents txtSpieler As TextBox
End Class
