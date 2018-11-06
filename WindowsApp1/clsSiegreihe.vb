Public Class clsSiegreihe

   Public Sub New(B1 As Button, B2 As Button, B3 As Button)
      _B1 = B1
      _B2 = B2
      _B3 = B3
   End Sub

   Private _B1 As Button
   Public Property B1() As Button
      Get
         Return _B1
      End Get
      Set(ByVal value As Button)
         _B1 = value
      End Set
   End Property

   Private _B2 As Button
   Public Property B2() As Button
      Get
         Return _B2
      End Get
      Set(ByVal value As Button)
         _B2 = value
      End Set
   End Property

   Private _B3 As Button
   Public Property B3() As Button
      Get
         Return _B3
      End Get
      Set(ByVal value As Button)
         _B3 = value
      End Set
   End Property

   Public Function enthält3Gleiche() As String
      ' wenn alle 3 Felder mit dem gleichen Wert versehen wird, wird der entsprechende Spieler zurückgegeben
      Try
         If B1.Text <> "" AndAlso B1.Text = B2.Text AndAlso B1.Text = B3.Text Then
            If B1.Text = "X" Then
               Return "Mensch"
            Else
               Return "Computer"
            End If
         End If
      Catch ex As Exception
         Stop
      End Try
      Return Nothing
   End Function

   Public Function enthält2Gleiche(Marker As String) As Button
      ' wenn nur 2 Felder mit dem gleichen Wert versehen sind, die dem Marker entsprechen, dann wird das fehlende Feld zurückgegeben
      Try
         If B1.Text = Marker AndAlso B2.Text = Marker AndAlso B3.Text = "" Then
            Return B3
         End If
         If B1.Text = Marker AndAlso B2.Text = "" AndAlso B3.Text = Marker Then
            Return B2
         End If
         If B1.Text = "" AndAlso B2.Text = Marker AndAlso B3.Text = Marker Then
            Return B1
         End If
      Catch ex As Exception
         Stop
      End Try
      Return Nothing
   End Function

End Class
