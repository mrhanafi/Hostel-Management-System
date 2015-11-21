Imports System.Data.OleDb
Public Class penetapanbilik
    Public Shared bilik As String
    Dim cari As Integer
    Dim ndp As String
    Dim status As String = "yes"

    Dim dt As New DataTable("pelajar")

    Public Shared lelaki As Boolean = False
    Public Shared perempuan As Boolean = False
    Private Sub penetapanbilik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If lelaki = True Then
            lelakino()
        ElseIf perempuan = True Then
            perempuanno()
        End If
        roomlevel1()
    End Sub
    Public Sub btnsearchl()
        dt.PrimaryKey = New DataColumn() {dt.Columns(0)}
        Dim s As String = TextBox1.Text
        Dim foundRow As DataRow = dt.Rows.Find(s)
        cari = dt.Rows.IndexOf(foundRow)
        If foundRow IsNot Nothing Then
            Label5.Text = dt.Rows(cari).Item("nama")
            ndp = dt.Rows(cari).Item("ndp")
            'MsgBox(dt.Rows.IndexOf(foundRow))
        Else
            MsgBox("pelajar telah daftar")
        End If
    End Sub
    Public Sub btnsearchp()
        dt.PrimaryKey = New DataColumn() {dt.Columns(0)}
        Dim s As String = TextBox1.Text
        Dim foundRow As DataRow = dt.Rows.Find(s)
        cari = dt.Rows.IndexOf(foundRow)
        If foundRow IsNot Nothing Then
            Label5.Text = dt.Rows(cari).Item("nama")
            ndp = dt.Rows(cari).Item("ndp")
        Else
            MsgBox("pelajar telah daftar")
        End If
        
    End Sub
    Public Sub roomlevel1()
        If Label2.Text = "A-1-24" Or Label2.Text = "A-1-25" Or Label2.Text = "A-1-26" Or Label2.Text = "A-1-27" Or Label2.Text = "A-1-28" Or Label2.Text = "A-1-29" Or Label2.Text = "A-1-30" Or Label2.Text = "A-1-31" Or Label2.Text = "A-1-32" Or Label2.Text = "A-2-1" Or Label2.Text = "A-2-2" Or Label2.Text = "A-2-3" Or Label2.Text = "A-2-4" Or Label2.Text = "A-2-5" Or Label2.Text = "A-2-6" Or Label2.Text = "A-2-7" Or Label2.Text = "A-2-8" Or Label2.Text = "A-2-9" Or Label2.Text = "A-2-10" Then
            ComboBox1.Items.Add("1")
            ComboBox1.Items.Add("2")
            ComboBox1.Items.Add("3")
            ComboBox1.Items.Add("4")
            ComboBox1.Items.Add("5")
            ComboBox1.Items.Add("6")
        ElseIf Label2.Text = "A-2-29" Or Label2.Text = "A-2-30" Or Label2.Text = "A-2-31" Or Label2.Text = "A-2-32" Or Label2.Text = "A-2-33" Or Label2.Text = "A-2-34" Or Label2.Text = "B-1-11" Or Label2.Text = "B-1-12" Or Label2.Text = "B-1-13" Or Label2.Text = "B-1-14" Or Label2.Text = "B-1-15" Or Label2.Text = "B-1-16" Then
            ComboBox1.Items.Add("1")
            ComboBox1.Items.Add("2")
            ComboBox1.Items.Add("3")
            ComboBox1.Items.Add("4")
            ComboBox1.Items.Add("5")
        ElseIf Label2.Text = "A-1-33" Or Label2.Text = "A-4-34" Or Label2.Text = "A-3-39" Or Label2.Text = "A-3-40" Or Label2.Text = "A-3-41" Or Label2.Text = "A-3-42" Or Label2.Text = "A-4-41" Or Label2.Text = "A-4-42" Or Label2.Text = "A-4-43" Or Label2.Text = "A-4-44" Or Label2.Text = "A-5-41" Or Label2.Text = "A-5-42" Or Label2.Text = "A-5-43" Or Label2.Text = "A-5-44" Or Label2.Text = "B-2-13" Or Label2.Text = "B-3-1" Or Label2.Text = "B-3-2" Or Label2.Text = "B-3-3" Or Label2.Text = "B-3-16" Then
            ComboBox1.Items.Add("1")
            ComboBox1.Items.Add("2")
            ComboBox1.Items.Add("3")
        ElseIf Label2.Text = "A-2-35" Then
            ComboBox1.Items.Add("1")
            ComboBox1.Items.Add("2")
            ComboBox1.Items.Add("3")
            ComboBox1.Items.Add("4")
            ComboBox1.Items.Add("5")
            ComboBox1.Items.Add("6")
            ComboBox1.Items.Add("7")
            ComboBox1.Items.Add("8")
        Else
            ComboBox1.Items.Add("1")
            ComboBox1.Items.Add("2")
        End If
    End Sub
  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If lelaki = True Then
            btnsearchl()
        ElseIf perempuan = True Then
            btnsearchp()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim acsconn As System.Data.OleDb.OleDbConnection
        acsconn = New System.Data.OleDb.OleDbConnection
        acsconn.ConnectionString = My.Settings.asramaConnectionString
        Dim cmd As New OleDb.OleDbCommand
        Try
            acsconn.Open()
            cmd.Connection = acsconn
            cmd.CommandText = "update " + bilik + " set ndp=@a,status=@b where ID = @c;"
            cmd.Parameters.AddWithValue("@a", ndp)
            cmd.Parameters.AddWithValue("@b", status)
            cmd.Parameters.AddWithValue("@c", ComboBox1.Text)
            cmd.ExecuteNonQuery()
            acsconn.Close()
            If lelaki = True Then
                updatetable("lelaki")
            ElseIf perempuan = True Then
                updatetable("perempuan")
            End If
            MsgBox("Penetapan Bilik Berjaya")
            'lelaki = False
            'perempuan = False
            Asrama_Lelaki_Aras_Satu.operationlevel1()
            Asrama_Lelaki_Aras_Dua.operationlevel2()
            Asrama_Lelaki_Aras_Tiga.operationlevel3()
            Asrama_Lelaki_Aras_Empat.operationlevel4()
            Asrama_Lelaki_Aras_Lima.operationlevel5()
            Asrama_Perempuan_Aras_Satu.operationblevel1()
            Asrama_Perempuan_Aras_Dua.operationlevel2()
            Asrama_Perempuan_Aras_Tiga.operationblevel3()
            Me.Close()
        Catch ex As Exception
            MsgBox("Penetapan Bilik dan Pelajar Gagal. Sila Cuba Lagi")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub lelakino()
        Dim no As String = "no"
        Try
            Dim acsconn As System.Data.OleDb.OleDbConnection
            acsconn = New System.Data.OleDb.OleDbConnection
            acsconn.ConnectionString = My.Settings.asramaConnectionString
            Dim sqlsearch As String
            sqlsearch = "SELECT ndp,nama,nokp FROM lelaki WHERE status LIKE '%" & no & "%'"
            Dim adapter As New OleDbDataAdapter(sqlsearch, acsconn)
            acsconn.Open()
            adapter.Fill(dt)
            acsconn.Close()
            DataGridView1.DataSource = dt
            Dim dgvColumnHeaderStyle As New DataGridViewCellStyle()
            dgvColumnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.ColumnHeadersDefaultCellStyle = dgvColumnHeaderStyle
        Catch ex As Exception
            MsgBox("Pelajar tiada.")
        End Try
    End Sub
    Private Sub perempuanno()
        Dim no As String = "no"
        Try
            Dim acsconn As System.Data.OleDb.OleDbConnection
            acsconn = New System.Data.OleDb.OleDbConnection
            acsconn.ConnectionString = My.Settings.asramaConnectionString
            Dim sqlsearch As String
            sqlsearch = "SELECT ndp,nama,nokp FROM perempuan WHERE status LIKE '%" & no & "%'"
            Dim adapter As New OleDbDataAdapter(sqlsearch, acsconn)
            acsconn.Open()
            adapter.Fill(dt)
            acsconn.Close()
            DataGridView1.DataSource = dt
            Dim dgvColumnHeaderStyle As New DataGridViewCellStyle()
            dgvColumnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.ColumnHeadersDefaultCellStyle = dgvColumnHeaderStyle
        Catch ex As Exception
            MsgBox("Pelajar tiada.")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim no As String = "no"
        Dim acsconn As System.Data.OleDb.OleDbConnection
        acsconn = New System.Data.OleDb.OleDbConnection
        acsconn.ConnectionString = My.Settings.asramaConnectionString
        Dim cmd As New OleDb.OleDbCommand
        Try
            acsconn.Open()
            cmd.Connection = acsconn
            cmd.CommandText = "update " + bilik + " set ndp=@a,status=@b where ID = @c;"
            cmd.Parameters.AddWithValue("@a", "")
            cmd.Parameters.AddWithValue("@b", no)
            cmd.Parameters.AddWithValue("@c", ComboBox1.Text)
            cmd.ExecuteNonQuery()
            acsconn.Close()
            MsgBox("Penetapan Bilik Berjaya")
            'lelaki = False
            'perempuan = False
            Asrama_Lelaki_Aras_Satu.operationlevel1()
            Asrama_Lelaki_Aras_Dua.operationlevel2()
            Asrama_Lelaki_Aras_Tiga.operationlevel3()
            Asrama_Lelaki_Aras_Empat.operationlevel4()
            Asrama_Lelaki_Aras_Lima.operationlevel5()
            Asrama_Perempuan_Aras_Satu.operationblevel1()
            Asrama_Perempuan_Aras_Dua.operationlevel2()
            Asrama_Perempuan_Aras_Tiga.operationblevel3()
            Me.Close()
        Catch ex As Exception
            MsgBox("Penetapan Bilik dan Pelajar Gagal. Sila Cuba Lagi")
        End Try
    End Sub

    Private Sub updatetable(ByVal gender As String)
        Dim acsconn As System.Data.OleDb.OleDbConnection
        acsconn = New System.Data.OleDb.OleDbConnection
        acsconn.ConnectionString = My.Settings.asramaConnectionString
        Dim cmd As New OleDb.OleDbCommand
        ' Try
        acsconn.Open()
        cmd.Connection = acsconn
        cmd.CommandText = "update " + gender + " set status=@a,bilik=@b where ndp = @c;"
        cmd.Parameters.AddWithValue("@a", "yes")
        cmd.Parameters.AddWithValue("@b", bilik)
        cmd.Parameters.AddWithValue("@c", TextBox1.Text)
        cmd.ExecuteNonQuery()
        acsconn.Close()
        'Catch ex As Exception
        '    MsgBox("Penetapan Bilik dan Pelajar Gagal. Sila Cuba Lagi")
        'End Try
    End Sub
End Class