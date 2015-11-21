Imports System.Data.OleDb
Public Class Asrama_Perempuan_Aras_Satu

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        Me.Hide()
        akaun_pengguna.Show()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Me.Hide()
        Aras_Asrama_Perempuan.Show()

    End Sub
    Public Sub b11()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM b11"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("b11")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label50.BackColor = Color.Red
        Else
            Label50.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label51.BackColor = Color.Red
        Else
            Label51.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub b12()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM b12"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("b12")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label52.BackColor = Color.Red
        Else
            Label52.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label53.BackColor = Color.Red
        Else
            Label53.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub b13()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM b13"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("b13")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label54.BackColor = Color.Red
        Else
            Label54.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label55.BackColor = Color.Red
        Else
            Label55.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub b14()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM b14"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("b14")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label56.BackColor = Color.Red
        Else
            Label56.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label57.BackColor = Color.Red
        Else
            Label57.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub b15()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM b15"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("b15")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label58.BackColor = Color.Red
        Else
            Label58.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label59.BackColor = Color.Red
        Else
            Label59.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub b16()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM b16"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("b16")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label60.BackColor = Color.Red
        Else
            Label60.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label61.BackColor = Color.Red
        Else
            Label61.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub b17()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM b17"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("b17")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label62.BackColor = Color.Red
        Else
            Label62.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label63.BackColor = Color.Red
        Else
            Label63.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub b18()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM b18"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("b18")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label64.BackColor = Color.Red
        Else
            Label64.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label65.BackColor = Color.Red
        Else
            Label65.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub b19()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM b19"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("b19")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label66.BackColor = Color.Red
        Else
            Label66.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label67.BackColor = Color.Red
        Else
            Label67.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub b110()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM b110"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("b110")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label68.BackColor = Color.Red
        Else
            Label68.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label69.BackColor = Color.Red
        Else
            Label69.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub b111()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM b111"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("b111")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label43.BackColor = Color.Red
        Else
            Label43.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label44.BackColor = Color.Red
        Else
            Label44.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label45.BackColor = Color.Red
        Else
            Label45.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label46.BackColor = Color.Red
        Else
            Label46.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label47.BackColor = Color.Red
        Else
            Label47.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub b112()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM b112"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("b112")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label38.BackColor = Color.Red
        Else
            Label38.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label39.BackColor = Color.Red
        Else
            Label39.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label40.BackColor = Color.Red
        Else
            Label40.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label41.BackColor = Color.Red
        Else
            Label41.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label42.BackColor = Color.Red
        Else
            Label42.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub b113()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM b113"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("b113")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label33.BackColor = Color.Red
        Else
            Label33.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label34.BackColor = Color.Red
        Else
            Label34.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label35.BackColor = Color.Red
        Else
            Label35.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label36.BackColor = Color.Red
        Else
            Label36.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label37.BackColor = Color.Red
        Else
            Label37.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub b114()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM b114"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("b114")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label28.BackColor = Color.Red
        Else
            Label28.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label29.BackColor = Color.Red
        Else
            Label29.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label30.BackColor = Color.Red
        Else
            Label30.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label31.BackColor = Color.Red
        Else
            Label31.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label32.BackColor = Color.Red
        Else
            Label32.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub b115()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM b115"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("b115")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label23.BackColor = Color.Red
        Else
            Label23.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label24.BackColor = Color.Red
        Else
            Label24.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label25.BackColor = Color.Red
        Else
            Label25.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label26.BackColor = Color.Red
        Else
            Label26.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label27.BackColor = Color.Red
        Else
            Label27.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub b116()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM b111"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("b111")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label22.BackColor = Color.Red
        Else
            Label22.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label18.BackColor = Color.Red
        Else
            Label18.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label19.BackColor = Color.Red
        Else
            Label19.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label20.BackColor = Color.Red
        Else
            Label20.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label21.BackColor = Color.Red
        Else
            Label21.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub operationblevel1()
        b11()
        b12()
        b13()
        b14()
        b15()
        b16()
        b17()
        b18()
        b19()
        b110()
        b111()
        b112()
        b113()
        b114()
        b115()
        b116()

    End Sub

    Private Sub Asrama_Perempuan_Aras_Satu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operationblevel1()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        penetapanbilik.bilik = "b11"
        penetapanbilik.Label2.Text = Label8.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        penetapanbilik.bilik = "b12"
        penetapanbilik.Label2.Text = Label9.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        penetapanbilik.bilik = "b13"
        penetapanbilik.Label2.Text = Label10.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        penetapanbilik.bilik = "b14"
        penetapanbilik.Label2.Text = Label11.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        penetapanbilik.bilik = "b15"
        penetapanbilik.Label2.Text = Label12.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        penetapanbilik.bilik = "b16"
        penetapanbilik.Label2.Text = Label13.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        penetapanbilik.bilik = "b17"
        penetapanbilik.Label2.Text = Label14.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        penetapanbilik.bilik = "b18"
        penetapanbilik.Label2.Text = Label15.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        penetapanbilik.bilik = "b19"
        penetapanbilik.Label2.Text = Label16.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        penetapanbilik.bilik = "b110"
        penetapanbilik.Label2.Text = Label17.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        penetapanbilik.bilik = "b111"
        penetapanbilik.Label2.Text = Label6.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        penetapanbilik.bilik = "b112"
        penetapanbilik.Label2.Text = Label5.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        penetapanbilik.bilik = "b113"
        penetapanbilik.Label2.Text = Label4.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        penetapanbilik.bilik = "b114"
        penetapanbilik.Label2.Text = Label3.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        penetapanbilik.bilik = "b115"
        penetapanbilik.Label2.Text = Label2.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        penetapanbilik.bilik = "b116"
        penetapanbilik.Label2.Text = Label1.Text
        penetapanbilik.Show()
    End Sub
    Public Sub updatedb(ByVal upbilik As String, ByVal upkatil As String)
        Dim acsconn As System.Data.OleDb.OleDbConnection

        acsconn = New System.Data.OleDb.OleDbConnection
        acsconn.ConnectionString = My.Settings.asramaConnectionString
        Dim cmd As New OleDb.OleDbCommand
        Try
            acsconn.Open()
            cmd.Connection = acsconn
            cmd.CommandText = "update " + upbilik + " set ndp=@a,status=@b where ID = @c;"
            cmd.Parameters.AddWithValue("@a", "")
            cmd.Parameters.AddWithValue("@b", "no")
            cmd.Parameters.AddWithValue("@c", upkatil)
            cmd.ExecuteNonQuery()
            acsconn.Close()

          
        Catch ex As Exception
            MsgBox("gagal ubah")
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        emptyroom()
        operationblevel1()
    End Sub
    Public Sub emptyroom()
        updatedb("b11", "1")
        updatedb("b11", "2")
        updatedb("b12", "1")
        updatedb("b12", "2")
        updatedb("b13", "1")
        updatedb("b13", "2")
        updatedb("b14", "1")
        updatedb("b14", "2")
        updatedb("b15", "1")
        updatedb("b15", "2")
        updatedb("b16", "1")
        updatedb("b16", "2")
        updatedb("b17", "1")
        updatedb("b17", "2")
        updatedb("b18", "1")
        updatedb("b18", "2")
        updatedb("b19", "1")
        updatedb("b19", "2")
        updatedb("b110", "1")
        updatedb("b110", "2")
        updatedb("b111", "1")
        updatedb("b111", "2")
        updatedb("b111", "3")
        updatedb("b111", "4")
        updatedb("b111", "5")
        updatedb("b112", "1")
        updatedb("b112", "2")
        updatedb("b112", "3")
        updatedb("b112", "4")
        updatedb("b112", "5")
        updatedb("b113", "1")
        updatedb("b113", "2")
        updatedb("b113", "3")
        updatedb("b113", "4")
        updatedb("b113", "5")
        updatedb("b114", "1")
        updatedb("b114", "2")
        updatedb("b114", "3")
        updatedb("b114", "4")
        updatedb("b114", "5")
        updatedb("b115", "1")
        updatedb("b115", "2")
        updatedb("b115", "3")
        updatedb("b115", "4")
        updatedb("b115", "5")
        updatedb("b116", "1")
        updatedb("b116", "2")
        updatedb("b116", "3")
        updatedb("b116", "4")
        updatedb("b116", "5")
        MsgBox("berjaya ubah")
    End Sub
End Class