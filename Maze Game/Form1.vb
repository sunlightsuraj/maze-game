Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Movetostart()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub mousein(sender As Object, e As EventArgs) Handles Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        Movetostart()
    End Sub

    Private Sub Movetostart()
        Dim startingpoint = Panel1.Location
        startingpoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingpoint)
    End Sub

    Private Sub finish_MouseEnter(sender As Object, e As EventArgs) Handles finish.MouseEnter
        MsgBox("Congrats")
        End
    End Sub
End Class