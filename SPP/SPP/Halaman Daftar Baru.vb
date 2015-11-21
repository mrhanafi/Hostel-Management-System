Imports System.Data.OleDb
Public Class Halaman_Daftar_Pelajar
    Dim id As String
    Public Shared j As Integer
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        Me.Close()
        akaun_pengguna.Show()

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Paparan_Data_Pelajar.alrdyindb = False
        Paparan_Data_Pelajar.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim acsconn As System.Data.OleDb.OleDbConnection
            acsconn = New System.Data.OleDb.OleDbConnection
            acsconn.ConnectionString = My.Settings.asramaConnectionString
            Dim sqlsearch As String
            sqlsearch = "SELECT nama,nokp,jantina,kodkursus,semester,sesi,tempoh,penjaga,alamat,telefon,hubungan FROM pelajar WHERE ndp = '%" & TextBox1.Text & "%';"
            Dim adapter As New OleDbDataAdapter(sqlsearch, acsconn)
            Dim dt As New DataTable("pelajar")
            acsconn.Open()
            adapter.Fill(dt)
            acsconn.Close()
            'alrdyindb = True
        Catch ex As Exception
            MsgBox("Pelajar tiada.")
            'alrdyindb = False
        End Try

    End Sub

    Private Sub Halaman_Daftar_Pelajar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Paparan_Data_Pelajar.alrdyindb = False Then
            Button2.Visible = False
            Button3.Visible = False
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox4.Text = ""
            ComboBox5.Text = ""
            ComboBox6.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""
            TextBox12.Text = ""
            Paparan_Data_Pelajar.add = False
        Else
            id = Paparan_Data_Pelajar.DataGridView1.Item(0, j).Value
            TextBox1.Text = Paparan_Data_Pelajar.DataGridView1.Item(1, j).Value
            TextBox2.Text = Paparan_Data_Pelajar.DataGridView1.Item(2, j).Value
            TextBox3.Text = Paparan_Data_Pelajar.DataGridView1.Item(3, j).Value
            ComboBox1.Text = Paparan_Data_Pelajar.DataGridView1.Item(4, j).Value
            ComboBox2.Text = Paparan_Data_Pelajar.DataGridView1.Item(5, j).Value
            ComboBox3.Text = Paparan_Data_Pelajar.DataGridView1.Item(6, j).Value
            ComboBox4.Text = Paparan_Data_Pelajar.DataGridView1.Item(7, j).Value
            ComboBox5.Text = Paparan_Data_Pelajar.DataGridView1.Item(8, j).Value
            ComboBox6.Text = Paparan_Data_Pelajar.DataGridView1.Item(9, j).Value
            TextBox9.Text = Paparan_Data_Pelajar.DataGridView1.Item(10, j).Value
            TextBox10.Text = Paparan_Data_Pelajar.DataGridView1.Item(11, j).Value
            TextBox11.Text = Paparan_Data_Pelajar.DataGridView1.Item(12, j).Value
            TextBox12.Text = Paparan_Data_Pelajar.DataGridView1.Item(13, j).Value
            Button1.Visible = False
            Label16.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim acsconn As System.Data.OleDb.OleDbConnection
        acsconn = New System.Data.OleDb.OleDbConnection
        acsconn.ConnectionString = My.Settings.asramaConnectionString
        Dim cmd As New OleDb.OleDbCommand
        acsconn.Open()
        cmd.Connection = acsconn
        cmd.CommandText = "insert into pelajar(ndp,nama,nokp,jantina,kodkursus,semester,sesi,tempoh,penjaga,alamat,telefon,hubungan,biaya) values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m);"
        cmd.Parameters.AddWithValue("@a", "161" + TextBox1.Text)
        cmd.Parameters.AddWithValue("@b", TextBox2.Text)
        cmd.Parameters.AddWithValue("@c", TextBox3.Text)
        cmd.Parameters.AddWithValue("@d", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@e", ComboBox2.Text)
        cmd.Parameters.AddWithValue("@f", ComboBox3.Text)
        cmd.Parameters.AddWithValue("@g", ComboBox4.Text)
        cmd.Parameters.AddWithValue("@h", ComboBox5.Text)
        cmd.Parameters.AddWithValue("@i", TextBox9.Text)
        cmd.Parameters.AddWithValue("@j", TextBox10.Text)
        cmd.Parameters.AddWithValue("@k", TextBox11.Text)
        cmd.Parameters.AddWithValue("@l", TextBox12.Text)
        cmd.Parameters.AddWithValue("@m", ComboBox6.Text)
        cmd.ExecuteNonQuery()
        acsconn.Close()
        MsgBox("berjaya daftar")
        If ComboBox1.Text = "LELAKI" Then
            lelaki()
        Else
            perempuan()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1
        ComboBox6.SelectedIndex = -1
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        Paparan_Data_Pelajar.alldata()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim acsconn As System.Data.OleDb.OleDbConnection
        acsconn = New System.Data.OleDb.OleDbConnection
        acsconn.ConnectionString = My.Settings.asramaConnectionString
        Dim cmd As New OleDb.OleDbCommand
        Try
            acsconn.Open()
            cmd.Connection = acsconn
            cmd.CommandText = "update pelajar set ndp=@a,nama=@b,nokp=@c,jantina=@d,kodkursus=@e,semester=@f,sesi=@g,tempoh=@h,penjaga=@i,alamat=@j,telefon=@k,hubungan=@l,biaya=@m where ID = @n;"
            cmd.Parameters.AddWithValue("@a", TextBox1.Text)
            cmd.Parameters.AddWithValue("@b", TextBox2.Text)
            cmd.Parameters.AddWithValue("@c", TextBox3.Text)
            cmd.Parameters.AddWithValue("@d", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@e", ComboBox2.Text)
            cmd.Parameters.AddWithValue("@f", ComboBox3.Text)
            cmd.Parameters.AddWithValue("@g", ComboBox4.Text)
            cmd.Parameters.AddWithValue("@h", ComboBox5.Text)
            cmd.Parameters.AddWithValue("@i", TextBox9.Text)
            cmd.Parameters.AddWithValue("@j", TextBox10.Text)
            cmd.Parameters.AddWithValue("@k", TextBox11.Text)
            cmd.Parameters.AddWithValue("@l", TextBox12.Text)
            cmd.Parameters.AddWithValue("@m", ComboBox6.Text)
            cmd.Parameters.AddWithValue("@n", id)
            ' cmd.Parameters.AddWithValue("@m", j)
            cmd.ExecuteNonQuery()
            acsconn.Close()
            MsgBox("berjaya ubah")
            
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
            ComboBox3.SelectedIndex = -1
            ComboBox4.SelectedIndex = -1
            ComboBox5.SelectedIndex = -1
            ComboBox6.SelectedIndex = -1
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""
            TextBox12.Text = ""
            Paparan_Data_Pelajar.alrdyindb = False
            Paparan_Data_Pelajar.alldata()
            Me.Close()
        Catch ex As Exception
            MsgBox("gagal ubah")
        End Try
    End Sub

  
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Masuk Nombor Sahaja")
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Masuk Nombor Sahaja")
            TextBox11.Text = ""
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dbconn As System.Data.OleDb.OleDbConnection
        dbconn = New System.Data.OleDb.OleDbConnection
        dbconn.ConnectionString = My.Settings.asramaConnectionString
        Dim cmd As New OleDb.OleDbCommand
        Try
            dbconn.Open()
            cmd.Connection = dbconn
            cmd.CommandText = "delete * from pelajar where [ID]=@a"
            cmd.Parameters.AddWithValue("@a", id)
            cmd.ExecuteNonQuery()
            dbconn.Close()
            If ComboBox1.Text = "LELAKI" Then
                buanglelaki()
            Else
                buangperempuan()
            End If
            Paparan_Data_Pelajar.alldata()
            Me.Close()
        Catch ex As Exception
            'MsgBox("Gagal Menyimpan Data. Sila Cuba Lagi")
        End Try
    End Sub
    Private Sub lelaki()
        Dim acsconn As System.Data.OleDb.OleDbConnection
        acsconn = New System.Data.OleDb.OleDbConnection
        acsconn.ConnectionString = My.Settings.asramaConnectionString
        Dim cmd As New OleDb.OleDbCommand
        acsconn.Open()
        cmd.Connection = acsconn
        cmd.CommandText = "insert into lelaki(ndp,nama,nokp,jantina,kodkursus,semester,status,bilik) values(@a,@b,@c,@d,@e,@f,@g,@h);"
        cmd.Parameters.AddWithValue("@a", "161" + TextBox1.Text)
        cmd.Parameters.AddWithValue("@b", TextBox2.Text)
        cmd.Parameters.AddWithValue("@c", TextBox3.Text)
        cmd.Parameters.AddWithValue("@d", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@e", ComboBox2.Text)
        cmd.Parameters.AddWithValue("@f", ComboBox3.Text)
        cmd.Parameters.AddWithValue("@g", "no")
        cmd.Parameters.AddWithValue("@h", "")
       
        cmd.ExecuteNonQuery()
        acsconn.Close()
    End Sub
    Private Sub perempuan()
        Dim acsconn As System.Data.OleDb.OleDbConnection
        acsconn = New System.Data.OleDb.OleDbConnection
        acsconn.ConnectionString = My.Settings.asramaConnectionString
        Dim cmd As New OleDb.OleDbCommand
        acsconn.Open()
        cmd.Connection = acsconn
        cmd.CommandText = "insert into perempuan(ndp,nama,nokp,jantina,kodkursus,semester,status,bilik) values(@a,@b,@c,@d,@e,@f,@g,@h);"
        cmd.Parameters.AddWithValue("@a", "161" + TextBox1.Text)
        cmd.Parameters.AddWithValue("@b", TextBox2.Text)
        cmd.Parameters.AddWithValue("@c", TextBox3.Text)
        cmd.Parameters.AddWithValue("@d", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@e", ComboBox2.Text)
        cmd.Parameters.AddWithValue("@f", ComboBox3.Text)
        cmd.Parameters.AddWithValue("@g", "no")
        cmd.Parameters.AddWithValue("@h", "")

        cmd.ExecuteNonQuery()
        acsconn.Close()
    End Sub
    Private Sub buanglelaki()
        Dim dbconn As System.Data.OleDb.OleDbConnection
        dbconn = New System.Data.OleDb.OleDbConnection
        dbconn.ConnectionString = My.Settings.asramaConnectionString
        Dim cmd As New OleDb.OleDbCommand
        Try
            dbconn.Open()
            cmd.Connection = dbconn
            cmd.CommandText = "delete * from lelaki where [ndp]=@a"
            cmd.Parameters.AddWithValue("@a", TextBox1.Text)
            cmd.ExecuteNonQuery()
            dbconn.Close()
            Paparan_Data_Pelajar.alldata()
            Me.Close()
        Catch ex As Exception
            'MsgBox("Gagal Menyimpan Data. Sila Cuba Lagi")
        End Try
    End Sub
    Private Sub buangperempuan()
        Dim dbconn As System.Data.OleDb.OleDbConnection
        dbconn = New System.Data.OleDb.OleDbConnection
        dbconn.ConnectionString = My.Settings.asramaConnectionString
        Dim cmd As New OleDb.OleDbCommand
        Try
            dbconn.Open()
            cmd.Connection = dbconn
            cmd.CommandText = "delete * from perempuan where [ndp]=@a"
            cmd.Parameters.AddWithValue("@a", TextBox1.Text)
            cmd.ExecuteNonQuery()
            dbconn.Close()
            Paparan_Data_Pelajar.alldata()
            Me.Close()
        Catch ex As Exception
            'MsgBox("Gagal Menyimpan Data. Sila Cuba Lagi")
        End Try
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Masuk Nombor Sahaja")
            TextBox11.Text = ""
        End If
    End Sub
End Class