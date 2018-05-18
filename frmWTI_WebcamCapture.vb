Public Class frmWTI_WebcamCapture

    Private Sub btn_Select_Click(sender As Object, e As EventArgs) Handles btn_Select.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

End Class