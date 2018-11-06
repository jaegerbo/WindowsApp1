<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
      Me.txtZahl1 = New System.Windows.Forms.TextBox()
      Me.txtZahl2 = New System.Windows.Forms.TextBox()
      Me.txtSumme = New System.Windows.Forms.TextBox()
      Me.btnReset = New System.Windows.Forms.Button()
      Me.btnAddieren = New System.Windows.Forms.Button()
      Me.btnMultiplizieren = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'txtZahl1
      '
      Me.txtZahl1.Location = New System.Drawing.Point(306, 27)
      Me.txtZahl1.Name = "txtZahl1"
      Me.txtZahl1.Size = New System.Drawing.Size(118, 20)
      Me.txtZahl1.TabIndex = 0
      Me.txtZahl1.Text = "0"
      Me.txtZahl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'txtZahl2
      '
      Me.txtZahl2.Location = New System.Drawing.Point(306, 65)
      Me.txtZahl2.Name = "txtZahl2"
      Me.txtZahl2.Size = New System.Drawing.Size(118, 20)
      Me.txtZahl2.TabIndex = 1
      Me.txtZahl2.Text = "0"
      Me.txtZahl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'txtSumme
      '
      Me.txtSumme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtSumme.Location = New System.Drawing.Point(306, 108)
      Me.txtSumme.Name = "txtSumme"
      Me.txtSumme.Size = New System.Drawing.Size(118, 20)
      Me.txtSumme.TabIndex = 2
      Me.txtSumme.Text = "0"
      Me.txtSumme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'btnReset
      '
      Me.btnReset.Location = New System.Drawing.Point(528, 23)
      Me.btnReset.Name = "btnReset"
      Me.btnReset.Size = New System.Drawing.Size(182, 79)
      Me.btnReset.TabIndex = 3
      Me.btnReset.Text = "reset"
      Me.btnReset.UseVisualStyleBackColor = True
      '
      'btnAddieren
      '
      Me.btnAddieren.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAddieren.Location = New System.Drawing.Point(583, 160)
      Me.btnAddieren.Name = "btnAddieren"
      Me.btnAddieren.Size = New System.Drawing.Size(75, 30)
      Me.btnAddieren.TabIndex = 4
      Me.btnAddieren.Text = "+"
      Me.btnAddieren.UseVisualStyleBackColor = True
      '
      'btnMultiplizieren
      '
      Me.btnMultiplizieren.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnMultiplizieren.Location = New System.Drawing.Point(583, 218)
      Me.btnMultiplizieren.Name = "btnMultiplizieren"
      Me.btnMultiplizieren.Size = New System.Drawing.Size(75, 28)
      Me.btnMultiplizieren.TabIndex = 5
      Me.btnMultiplizieren.Text = "*"
      Me.btnMultiplizieren.UseVisualStyleBackColor = True
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(800, 450)
      Me.Controls.Add(Me.btnMultiplizieren)
      Me.Controls.Add(Me.btnAddieren)
      Me.Controls.Add(Me.btnReset)
      Me.Controls.Add(Me.txtSumme)
      Me.Controls.Add(Me.txtZahl2)
      Me.Controls.Add(Me.txtZahl1)
      Me.Name = "Form1"
      Me.Text = "Form1"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents txtZahl1 As TextBox
   Friend WithEvents txtZahl2 As TextBox
   Friend WithEvents txtSumme As TextBox
   Friend WithEvents btnReset As Button
   Friend WithEvents btnAddieren As Button
   Friend WithEvents btnMultiplizieren As Button
End Class
