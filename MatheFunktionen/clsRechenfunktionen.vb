Public Class clsRechenfunktionen

   Public Shared Function addieren(Zahl1 As Int32, Zahl2 As Int32) As Int32
      ' Zweck: Zahlen addieren
      Try
         Return Zahl1 + Zahl2
      Catch ex As Exception
         Stop
      End Try
      Return 0
   End Function

   Public Shared Function multiplizieren(Zahl1 As Int32, Zahl2 As Int32) As Int32
      ' Zweck: Zahlen multipliziern
      Try
         Return Zahl1 * Zahl2
      Catch ex As Exception
         Stop
      End Try
      Return 0
   End Function

End Class
