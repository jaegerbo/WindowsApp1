Public Class Form1





   Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
      ' Zweck:    Alle Zahlen löschen
      Try
         txtZahl1.Text = "0"
         txtZahl2.Text = "0"
         txtSumme.Text = "0"
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try
   End Sub

   Private Sub btnAddieren_Click(sender As Object, e As EventArgs) Handles btnAddieren.Click
      ' Zweck:    Addieren der beiden Textfelder.
      Try
         'Textfelder überprüfen
         If TextfelderPrüfen() = False Then
            Exit Sub
         End If

         ' Summe bilden
         txtSumme.Text = MatheFunktionen.clsRechenfunktionen.addieren(CInt(txtZahl1.Text), CInt(txtZahl2.Text))
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try
   End Sub

   Private Sub btnMultiplizieren_Click(sender As Object, e As EventArgs) Handles btnMultiplizieren.Click
      ' Zweck:    Multiplizieren der beiden Textfelder.
      Try
         'Textfelder überprüfen
         If TextfelderPrüfen() = False Then
            Exit Sub
         End If

         ' Produkt bilden
         txtSumme.Text = MatheFunktionen.clsRechenfunktionen.multiplizieren(CInt(txtZahl1.Text), CInt(txtZahl2.Text))
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try
   End Sub
   Private Function TextfelderPrüfen() As Boolean
      'Zweck: Textfelder auf nummerrische Werte Überprüfen
      Try
         'Abbrechen wenn keine Zahlen vorhanden sind.
         If txtZahl1.Text = "" OrElse txtZahl2.Text = "" Then
            Return False
         End If

         ' prüfen, ob es sich um numerische Werte handelt
         If IsNumeric(txtZahl1.Text) = False Then
            MsgBox("Bitte eine Zahl eingeben")
            Return False
         End If
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try
      Return True
   End Function

End Class
