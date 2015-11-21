Public Class Aras_Asrama_Lelaki

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        penetapanbilik.lelaki = True
        Me.Hide()
        Asrama_Lelaki_Aras_Satu.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        penetapanbilik.lelaki = True
        Me.Hide()
        Asrama_Lelaki_Aras_Dua.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        penetapanbilik.lelaki = True
        Me.Hide()
        Asrama_Lelaki_Aras_Tiga.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        penetapanbilik.lelaki = True
        Me.Hide()
        Asrama_Lelaki_Aras_Empat.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        penetapanbilik.lelaki = True
        Me.Hide()
        Asrama_Lelaki_Aras_Lima.Show()

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        penetapanbilik.lelaki = False
        Me.Hide()
        Halaman_Penyelia.Show()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        penetapanbilik.lelaki = False
        Me.Hide()
        akaun_pengguna.Show()

    End Sub


    Private Sub Aras_Asrama_Lelaki_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class