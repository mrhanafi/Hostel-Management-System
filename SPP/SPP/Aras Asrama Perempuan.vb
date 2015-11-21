Public Class Aras_Asrama_Perempuan

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        penetapanbilik.perempuan = True
        Me.Hide()
        Asrama_Perempuan_Aras_Satu.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        penetapanbilik.perempuan = True
        Me.Hide()
        Asrama_Perempuan_Aras_Dua.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        penetapanbilik.perempuan = True
        Me.Hide()
        Asrama_Perempuan_Aras_Tiga.Show()

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        penetapanbilik.perempuan = False
        Me.Hide()
        Halaman_Penyelia.Show()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        penetapanbilik.perempuan = False
        Me.Hide()
        akaun_pengguna.Show()

    End Sub

    Private Sub Aras_Asrama_Perempuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class