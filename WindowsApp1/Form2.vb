Public Class Form2
   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnA.Click, btnB.Click, btnC.Click, btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnK.Click

      Dim Button As Button = CType(sender, Button)
      If btnShift.CheckState = CheckState.Checked Then
         txtText.Text &= Button.Text
      Else
         txtText.Text &= Button.Text.ToLower
      End If
   End Sub



   Private Sub btnLöschen_Click(sender As Object, e As EventArgs) Handles btnLöschen.Click
      If txtText.Text = "" Then
         Exit Sub

      End If
      txtText.Text = Microsoft.VisualBasic.Left(txtText.Text, Len(txtText.Text) - 1)

   End Sub


End Class