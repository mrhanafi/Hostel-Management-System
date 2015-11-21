Imports System.Data.OleDb
Public Class Paparan_Data_Pelajar
    Dim cari As Integer
    Public Shared alrdyindb As Boolean = False
    Public Shared add As Boolean = False
    Dim id As String
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        alrdyindb = False

        Halaman_Daftar_Pelajar.Show()

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        Me.Hide()
        Halaman_Penyelia.Show()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        Me.Hide()
        akaun_pengguna.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim acsconn As System.Data.OleDb.OleDbConnection
            acsconn = New System.Data.OleDb.OleDbConnection
            acsconn.ConnectionString = My.Settings.asramaConnectionString
            Dim sqlsearch As String
            sqlsearch = "SELECT ID,ndp,nama,nokp,jantina,kodkursus,semester,sesi,tempoh,biaya,penjaga,alamat,telefon,hubungan FROM pelajar WHERE ndp LIKE '%" & TextBox1.Text & "%'"
            Dim adapter As New OleDbDataAdapter(sqlsearch, acsconn)
            Dim dt As New DataTable("pelajar")
            acsconn.Open()
            adapter.Fill(dt)
            acsconn.Close()

            alrdyindb = True
            DataGridView1.DataSource = dt
            Dim dgvColumnHeaderStyle As New DataGridViewCellStyle()
            dgvColumnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.ColumnHeadersDefaultCellStyle = dgvColumnHeaderStyle
            ' id = dt.Rows(cari).Item("ID")
        Catch ex As Exception
            MsgBox("Pelajar tiada.")
            alrdyindb = False
        End Try

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        alrdyindb = True
        Halaman_Daftar_Pelajar.j = DataGridView1.CurrentRow.Index
        Halaman_Daftar_Pelajar.Show()

    End Sub

    Private Sub Paparan_Data_Pelajar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'alrdyindb = True
        alldata()
    End Sub
    Public Sub alldata()
        Dim acsconn As System.Data.OleDb.OleDbConnection
        acsconn = New System.Data.OleDb.OleDbConnection
        acsconn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT ID,ndp,nama,nokp,jantina,kodkursus,semester,sesi,tempoh,biaya,penjaga,alamat,telefon,hubungan FROM pelajar"
        Dim adapter As New OleDbDataAdapter(sqlsearch, acsconn)
        Dim dt As New DataTable("pelajar")
        acsconn.Open()
        adapter.Fill(dt)
        acsconn.Close()
        ' alrdyindb = True
        DataGridView1.DataSource = dt
        Dim dgvColumnHeaderStyle As New DataGridViewCellStyle()
        dgvColumnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.ColumnHeadersDefaultCellStyle = dgvColumnHeaderStyle
        DataGridView1.Columns(0).Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("sila letakkan ndp pada ruangan disediakan.")
        Else
            Dim acsconn As System.Data.OleDb.OleDbConnection
            acsconn = New System.Data.OleDb.OleDbConnection
            acsconn.ConnectionString = My.Settings.asramaConnectionString
            Dim sqlsearch As String
            'sqlsearch = "DELETE from DaftarAhli WHERE ID ='" & id & "'"
            sqlsearch = "DELETE FROM pelajar WHERE ndp = " + TextBox1.Text
            Dim adapter As New OleDbDataAdapter(sqlsearch, acsconn)
            Dim dt As New DataTable("delete")
            acsconn.Open()
            adapter.Fill(dt)
            acsconn.Close()

            alldata()
            TextBox1.Text = ""
        End If
       
    End Sub
End Class