Public Class Form11

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Imagenum = imagenum + 1
        If imagenum > 18 Then then imagenum=13
        Select Case Imagenum
            Case 13
                picMyImage.image = My.Resources.img13_small
            Case 14
                picMyIMage()

        End Select
    End Sub

    Private Sub chkslideshow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkslideshow.CheckedChanged
        If chkslideshow.Enabled = True Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class