Public Class Halaman_Akaun_Penyelia
    Dim id As String
    Dim pwd As String
    Dim msg As String


    Private Sub Halaman_Akaun_Penyelia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        id = txtid.Text
        pwd = txtkatalaluan.Text

        If id = "admin" And pwd = "123456" Then
            msg = MsgBox("Anda Berjaya Log In", vbOKOnly + vbInformation, " Log In")

            If msg = vbOK Then
                Me.Hide()
                Halaman_Penyelia.Show()

            End If

        Else
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Hide()
        akaun_pengguna.Show()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        Me.Hide()
        akaun_pengguna.Show()

    End Sub
End Class