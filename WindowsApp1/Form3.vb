Public Class Form3

   Private _Zug As Int32 = 1
   Private _Siegreihen As New List(Of clsSiegreihe)

   Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Try
         ' Die möglichen Siegreihen in einem Array festlegen
         _Siegreihen.Add(New clsSiegreihe(btn1, btn2, btn3))
         _Siegreihen.Add(New clsSiegreihe(btn4, btn5, btn6))
         _Siegreihen.Add(New clsSiegreihe(btn7, btn8, btn9))
         _Siegreihen.Add(New clsSiegreihe(btn1, btn4, btn7))
         _Siegreihen.Add(New clsSiegreihe(btn2, btn5, btn8))
         _Siegreihen.Add(New clsSiegreihe(btn3, btn6, btn9))
         _Siegreihen.Add(New clsSiegreihe(btn1, btn5, btn9))
         _Siegreihen.Add(New clsSiegreihe(btn3, btn5, btn7))
      Catch ex As Exception
         Stop
      End Try
   End Sub

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
      Try
         Dim Button As Button = CType(sender, Button)

         Button.Text = "X"
         txtSpieler.Text = "Computer"
         Button.Enabled = False
         _Zug += 1
         ComputerZieht()

         ' Siegesprüfung durchführen
         Dim Sieger As String = Siegesprüfung()
         If Sieger IsNot Nothing Then
            MsgBox("gewonnen hat " & Sieger)
         Else
            If _Zug = 10 Then
               MsgBox("Unentschieden")
            End If
         End If

      Catch ex As Exception

      End Try
   End Sub


   Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
      Try
         btn1.Text = ""
         btn2.Text = ""
         btn3.Text = ""
         btn4.Text = ""
         btn5.Text = ""
         btn6.Text = ""
         btn7.Text = ""
         btn8.Text = ""
         btn9.Text = ""
         btn1.Enabled = True
         btn2.Enabled = True
         btn3.Enabled = True
         btn4.Enabled = True
         btn5.Enabled = True
         btn6.Enabled = True
         btn7.Enabled = True
         btn8.Enabled = True
         btn9.Enabled = True
         txtSpieler.Text = "Mensch"
         _Zug = 1
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try
   End Sub
   Private Function Siegesprüfung() As String
      Dim Sieger As String = Nothing
      Try
         For Each Siegreihe As clsSiegreihe In _Siegreihen
            Sieger = Siegreihe.enthält3Gleiche
            If Sieger IsNot Nothing Then
               Return Sieger
            End If
         Next
      Catch ex As Exception
         Stop
      End Try
      Return Sieger
   End Function

   ' Computer
   Private Sub ComputerZieht()
      Try
         Dim Button As Button = ComputerFeldauswahl()
         Button.Text = "O"
         Button.Enabled = False
         txtSpieler.Text = "Mensch"
         _Zug += 1
      Catch ex As Exception
         Stop
      End Try
   End Sub
   Private Function ComputerFeldauswahl() As Button
      Try
         Dim feldliste As New ArrayList

         If _Zug = 2 Then
            ' 1. Zug des Computers
            ' das mittlere Feld besetzen. Ist es bereis besetzt, wird ein beliebiges Eckfeld besetzt
            If btn5.Enabled = True Then
               Return btn5
            Else
               ' Feldliste mit den 4 Eckpunkten erzeugen und eine zufällige Auswahl treffen
               feldliste.Add(btn1)
               feldliste.Add(btn3)
               feldliste.Add(btn7)
               feldliste.Add(btn9)

               'zufällige Buttonauswahl aus feldliste
               Return zufälligeFeldauswahl(feldliste)
            End If
         End If

         ' prüfen, ob der Computer 2 in einer Reihe hat, damit das 3. Feld ebenfalls vom Computer besetzt werden kann.
         ' Wenn das nicht der Fall ist, wird die Prüfung für den Mensch durchgeführt, um einen Sieg zu verhindern.
         For Each Siegreihe As clsSiegreihe In _Siegreihen
            Dim B As Button = Siegreihe.enthält2Gleiche("O")
            If B IsNot Nothing Then
               Return B
            End If
            B = Siegreihe.enthält2Gleiche("X")
            If B IsNot Nothing Then
               Return B
            End If
         Next

         ' Feldliste Erzeugen und freie Buttons einfügen
         If btn1.Enabled = True Then feldliste.Add(btn1)
         If btn2.Enabled = True Then feldliste.Add(btn2)
         If btn3.Enabled = True Then feldliste.Add(btn3)
         If btn4.Enabled = True Then feldliste.Add(btn4)
         If btn5.Enabled = True Then feldliste.Add(btn5)
         If btn6.Enabled = True Then feldliste.Add(btn6)
         If btn7.Enabled = True Then feldliste.Add(btn7)
         If btn8.Enabled = True Then feldliste.Add(btn8)
         If btn9.Enabled = True Then feldliste.Add(btn9)

         'zufällige Buttonauswahl aus feldliste
         Return zufälligeFeldauswahl(feldliste)

      Catch ex As Exception
         Stop
      End Try
   End Function
   Private Function zufälligeFeldauswahl(Feldliste As ArrayList) As Button
      Try
         Dim Zufall As New Random(Now.Millisecond)
         Dim Zufallszahl As Integer = Zufall.Next(0, Feldliste.Count - 1)
         Return Feldliste(Zufallszahl)
      Catch ex As Exception
         Stop
      End Try
      Return Nothing
   End Function

End Class