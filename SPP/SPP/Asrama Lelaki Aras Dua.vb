Imports System.Data.OleDb
Public Class Asrama_Lelaki_Aras_Dua
    Dim baris As Integer

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        Me.Hide()
        akaun_pengguna.Show()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Me.Hide()
        Aras_Asrama_Lelaki.Show()

    End Sub
    Public Sub a21()
       Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a21"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a21")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label96.BackColor = Color.Red
        Else
            Label96.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label97.BackColor = Color.Red
        Else
            Label97.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label98.BackColor = Color.Red
        Else
            Label98.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label99.BackColor = Color.Red
        Else
            Label99.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label100.BackColor = Color.Red
        Else
            Label100.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(5)("status") = "yes" Then
            Label101.BackColor = Color.Red
        End If
    End Sub

    Public Sub a22()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a22"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a22")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label102.BackColor = Color.Red
        Else
            Label102.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label103.BackColor = Color.Red
        Else
            Label103.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label104.BackColor = Color.Red
        Else
            Label104.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label105.BackColor = Color.Red
        Else
            Label105.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label106.BackColor = Color.Red
        Else
            Label106.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(5)("status") = "yes" Then
            Label107.BackColor = Color.Red
        Else
            Label107.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a23()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a23"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a23")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label108.BackColor = Color.Red
        Else
            Label108.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label109.BackColor = Color.Red
        Else
            Label109.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label110.BackColor = Color.Red
        Else
            Label110.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label111.BackColor = Color.Red
        Else
            Label111.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label112.BackColor = Color.Red
        Else
            Label112.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(5)("status") = "yes" Then
            Label113.BackColor = Color.Red
        Else
            Label113.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a24()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a24"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a24")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label114.BackColor = Color.Red
        Else
            Label114.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label115.BackColor = Color.Red
        Else
            Label115.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label116.BackColor = Color.Red
        Else
            Label116.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label117.BackColor = Color.Red
        Else
            Label117.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label118.BackColor = Color.Red
        Else
            Label118.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(5)("status") = "yes" Then
            Label119.BackColor = Color.Red
        Else
            Label119.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a25()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a25"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a25")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label120.BackColor = Color.Red
        Else
            Label120.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label121.BackColor = Color.Red
        Else
            Label121.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label122.BackColor = Color.Red
        Else
            Label122.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label123.BackColor = Color.Red
        Else
            Label123.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label124.BackColor = Color.Red
        Else
            Label124.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(5)("status") = "yes" Then
            Label125.BackColor = Color.Red
        Else
            Label125.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a26()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a26"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a26")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label126.BackColor = Color.Red
        Else
            Label126.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label127.BackColor = Color.Red
        Else
            Label127.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label128.BackColor = Color.Red
        Else
            Label128.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label129.BackColor = Color.Red
        Else
            Label129.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label130.BackColor = Color.Red
        Else
            Label130.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(5)("status") = "yes" Then
            Label131.BackColor = Color.Red
        Else
            Label131.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a27()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a27"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a27")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label132.BackColor = Color.Red
        Else
            Label132.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label133.BackColor = Color.Red
        Else
            Label133.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label134.BackColor = Color.Red
        Else
            Label134.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label135.BackColor = Color.Red
        Else
            Label135.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label136.BackColor = Color.Red
        Else
            Label136.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(5)("status") = "yes" Then
            Label137.BackColor = Color.Red
        Else
            Label137.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a28()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a28"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a28")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label138.BackColor = Color.Red
        Else
            Label138.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label139.BackColor = Color.Red
        Else
            Label139.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label140.BackColor = Color.Red
        Else
            Label140.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label141.BackColor = Color.Red
        Else
            Label141.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label142.BackColor = Color.Red
        Else
            Label142.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(5)("status") = "yes" Then
            Label143.BackColor = Color.Red
        Else
            Label143.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a29()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a29"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a29")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label144.BackColor = Color.Red
        Else
            Label144.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label145.BackColor = Color.Red
        Else
            Label145.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label146.BackColor = Color.Red
        Else
            Label146.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label147.BackColor = Color.Red
        Else
            Label147.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label148.BackColor = Color.Red
        Else
            Label148.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(5)("status") = "yes" Then
            Label149.BackColor = Color.Red
        Else
            Label149.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a210()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a210"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a210")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label150.BackColor = Color.Red
        Else
            Label150.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label151.BackColor = Color.Red
        Else
            Label151.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label152.BackColor = Color.Red
        Else
            Label152.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label153.BackColor = Color.Red
        Else
            Label153.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label154.BackColor = Color.Red
        Else
            Label154.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(5)("status") = "yes" Then
            Label155.BackColor = Color.Red
        Else
            Label155.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a211()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a211"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a211")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label156.BackColor = Color.Red
        Else
            Label156.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label157.BackColor = Color.Red
        Else
            Label157.BackColor = Color.LimeGreen
        End If
       
    End Sub
    Public Sub a212()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a212"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a212")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label158.BackColor = Color.Red
        Else
            Label158.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label159.BackColor = Color.Red
        Else
            Label159.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a213()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a213"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a213")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label160.BackColor = Color.Red
        Else
            Label160.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label161.BackColor = Color.Red
        Else
            Label161.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a214()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a214"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a214")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label162.BackColor = Color.Red
        Else
            Label162.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label163.BackColor = Color.Red
        Else
            Label163.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a215()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a215"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a215")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label78.BackColor = Color.Red
        Else
            Label78.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label79.BackColor = Color.Red
        Else
            Label79.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a216()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a216"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a216")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label76.BackColor = Color.Red
        Else
            Label76.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label77.BackColor = Color.Red
        Else
            Label77.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a217()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a217"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a217")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label74.BackColor = Color.Red
        Else
            Label74.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label75.BackColor = Color.Red
        Else
            Label75.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a218()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a218"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a218")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label72.BackColor = Color.Red
        Else
            Label72.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label73.BackColor = Color.Red
        Else
            Label73.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a219()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a219"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a219")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label70.BackColor = Color.Red
        Else
            Label70.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label71.BackColor = Color.Red
        Else
            Label71.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a220()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a220"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a220")
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
    Public Sub a221()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a221"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a221")
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
    Public Sub a222()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a222"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a222")
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
    Public Sub a223()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a223"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a223")
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
    Public Sub a224()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a224"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a224")
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
    Public Sub a225()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a225"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a225")
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
    Public Sub a226()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a226"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a226")
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
    Public Sub a227()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a227"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a227")
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
    Public Sub a228()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a228"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a228")
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
    Public Sub a229()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a229"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a229")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label47.BackColor = Color.Red
        Else
            Label47.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label48.BackColor = Color.Red
        Else
            Label48.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label49.BackColor = Color.Red
        Else
            Label49.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label50.BackColor = Color.Red
        Else
            Label50.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label51.BackColor = Color.Red
        Else
            Label51.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a230()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a230"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a230")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label42.BackColor = Color.Red
        Else
            Label42.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label43.BackColor = Color.Red
        Else
            Label43.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label44.BackColor = Color.Red
        Else
            Label44.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label45.BackColor = Color.Red
        Else
            Label45.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label46.BackColor = Color.Red
        Else
            Label46.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a231()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a231"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a231")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label37.BackColor = Color.Red
        Else
            Label37.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label38.BackColor = Color.Red
        Else
            Label38.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label39.BackColor = Color.Red
        Else
            Label39.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label40.BackColor = Color.Red
        Else
            Label40.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label41.BackColor = Color.Red
        Else
            Label41.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a232()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a232"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a232")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label32.BackColor = Color.Red
        Else
            Label32.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label33.BackColor = Color.Red
        Else
            Label33.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label34.BackColor = Color.Red
        Else
            Label34.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label35.BackColor = Color.Red
        Else
            Label35.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label36.BackColor = Color.Red
        Else
            Label36.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a233()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a233"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a233")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label27.BackColor = Color.Red
        Else
            Label27.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label28.BackColor = Color.Red
        Else
            Label28.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label29.BackColor = Color.Red
        Else
            Label29.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label30.BackColor = Color.Red
        Else
            Label30.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label31.BackColor = Color.Red
        Else
            Label31.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a234()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a234"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a234")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label22.BackColor = Color.Red
        Else
            Label22.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label23.BackColor = Color.Red
        Else
            Label23.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label24.BackColor = Color.Red
        Else
            Label24.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label25.BackColor = Color.Red
        Else
            Label25.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label26.BackColor = Color.Red
        Else
            Label26.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a133()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a133"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a133")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label170.BackColor = Color.Red
        Else
            Label170.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label173.BackColor = Color.Red
        Else
            Label173.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label176.BackColor = Color.Red
        Else
            Label176.BackColor = Color.LimeGreen
        End If
      
    End Sub
    Public Sub a434()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a434"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a434")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label171.BackColor = Color.Red
        Else
            Label171.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label174.BackColor = Color.Red
        Else
            Label174.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label177.BackColor = Color.Red
        Else
            Label177.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a235()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a235"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a235")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label172.BackColor = Color.Red
        Else
            Label172.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label175.BackColor = Color.Red
        Else
            Label175.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label178.BackColor = Color.Red
        Else
            Label178.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(3)("status") = "yes" Then
            Label179.BackColor = Color.Red
        Else
            Label179.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(4)("status") = "yes" Then
            Label180.BackColor = Color.Red
        Else
            Label180.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(5)("status") = "yes" Then
            Label181.BackColor = Color.Red
        Else
            Label181.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(6)("status") = "yes" Then
            Label182.BackColor = Color.Red
        Else
            Label182.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(7)("status") = "yes" Then
            Label183.BackColor = Color.Red
        Else
            Label183.BackColor = Color.LimeGreen
        End If
    End Sub
    Private Sub Asrama_Lelaki_Aras_Dua_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        operationlevel2()

    End Sub
    Public Sub operationlevel2()
        a21()
        a22()
        a23()
        a24()
        a25()
        a26()
        a27()
        a28()
        a29()
        a210()
        a211()
        a212()
        a213()
        a214()
        a215()
        a216()
        a217()
        a218()
        a219()
        a220()
        a221()
        a222()
        a223()
        a224()
        a225()
        a226()
        a227()
        a228()
        a229()
        a230()
        a231()
        a232()
        a233()
        a234()
        a235()
        a133()
        a434()
    End Sub

    Private Sub Label80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label80.Click
        penetapanbilik.bilik = "a21"
        penetapanbilik.Label2.Text = Label80.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label81.Click
        penetapanbilik.bilik = "a22"
        penetapanbilik.Label2.Text = Label81.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label82.Click
        penetapanbilik.bilik = "a23"
        penetapanbilik.Label2.Text = Label82.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label83.Click
        penetapanbilik.bilik = "a24"
        penetapanbilik.Label2.Text = Label83.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label84.Click
        penetapanbilik.bilik = "a25"
        penetapanbilik.Label2.Text = Label84.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label85.Click
        penetapanbilik.bilik = "a26"
        penetapanbilik.Label2.Text = Label85.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label86.Click
        penetapanbilik.bilik = "a27"
        penetapanbilik.Label2.Text = Label86.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label87.Click
        penetapanbilik.bilik = "a28"
        penetapanbilik.Label2.Text = Label87.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label88.Click
        penetapanbilik.bilik = "a29"
        penetapanbilik.Label2.Text = Label88.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label90.Click
        penetapanbilik.bilik = "a210"
        penetapanbilik.Label2.Text = Label90.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label91.Click
        penetapanbilik.bilik = "a211"
        penetapanbilik.Label2.Text = Label91.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label92.Click
        penetapanbilik.bilik = "a212"
        penetapanbilik.Label2.Text = Label92.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label93.Click
        penetapanbilik.bilik = "a213"
        penetapanbilik.Label2.Text = Label93.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label94.Click
        penetapanbilik.bilik = "a214"
        penetapanbilik.Label2.Text = Label94.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
        penetapanbilik.bilik = "a215"
        penetapanbilik.Label2.Text = Label21.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        penetapanbilik.bilik = "a216"
        penetapanbilik.Label2.Text = Label20.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        penetapanbilik.bilik = "a217"
        penetapanbilik.Label2.Text = Label19.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        penetapanbilik.bilik = "a218"
        penetapanbilik.Label2.Text = Label18.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        penetapanbilik.bilik = "a219"
        penetapanbilik.Label2.Text = Label17.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        penetapanbilik.bilik = "a220"
        penetapanbilik.Label2.Text = Label16.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        penetapanbilik.bilik = "a221"
        penetapanbilik.Label2.Text = Label15.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        penetapanbilik.bilik = "a222"
        penetapanbilik.Label2.Text = Label14.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        penetapanbilik.bilik = "a223"
        penetapanbilik.Label2.Text = Label13.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        penetapanbilik.bilik = "a224"
        penetapanbilik.Label2.Text = Label12.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        penetapanbilik.bilik = "a225"
        penetapanbilik.Label2.Text = Label11.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        penetapanbilik.bilik = "a226"
        penetapanbilik.Label2.Text = Label10.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        penetapanbilik.bilik = "a227"
        penetapanbilik.Label2.Text = Label9.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        penetapanbilik.bilik = "a228"
        penetapanbilik.Label2.Text = Label8.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        penetapanbilik.bilik = "a229"
        penetapanbilik.Label2.Text = Label7.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        penetapanbilik.bilik = "a230"
        penetapanbilik.Label2.Text = Label6.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        penetapanbilik.bilik = "a231"
        penetapanbilik.Label2.Text = Label4.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        penetapanbilik.bilik = "a232"
        penetapanbilik.Label2.Text = Label3.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        penetapanbilik.bilik = "a233"
        penetapanbilik.Label2.Text = Label2.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        penetapanbilik.bilik = "a234"
        penetapanbilik.Label2.Text = Label1.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label166_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label166.Click
        penetapanbilik.bilik = "a133"
        penetapanbilik.Label2.Text = Label166.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label167_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label167.Click
        penetapanbilik.bilik = "a434"
        penetapanbilik.Label2.Text = Label167.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label168_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label168.Click
        penetapanbilik.bilik = "a235"
        penetapanbilik.Label2.Text = Label168.Text
        penetapanbilik.lelaki = True
        penetapanbilik.Show()
    End Sub
    Public Sub updatedb(ByVal upbilik As String, ByVal q As Integer)
        For x As Integer = 1 To q
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
                cmd.Parameters.AddWithValue("@c", x)
                cmd.ExecuteNonQuery()
                acsconn.Close()


            Catch ex As Exception
                MsgBox("gagal ubah")
            End Try
        Next

    End Sub
    Public Sub emptyroom()
        updatedb("a21", 6)
        updatedb("a22", 6)
        updatedb("a23", 6)
        updatedb("a24", 6)
        updatedb("a25", 6)
        updatedb("a26", 6)
        updatedb("a27", 6)
        updatedb("a28", 6)
        updatedb("a29", 6)
        updatedb("a210", 6)
        updatedb("a211", 2)
        updatedb("a212", 2)
        updatedb("a213", 2)
        updatedb("a214", 2)
        updatedb("a215", 2)
        updatedb("a216", 2)
        updatedb("a217", 2)
        updatedb("a218", 2)
        updatedb("a219", 2)
        updatedb("a220", 2)
        updatedb("a221", 2)
        updatedb("a222", 2)
        updatedb("a223", 2)
        updatedb("a224", 2)
        updatedb("a225", 2)
        updatedb("a226", 2)
        updatedb("a227", 2)
        updatedb("a228", 2)
        updatedb("a229", 5)
        updatedb("a230", 5)
        updatedb("a231", 5)
        updatedb("a232", 5)
        updatedb("a233", 5)
        updatedb("a234", 5)
        updatedb("a235", 8)
        updatedb("a133", 3)
        updatedb("a434", 3)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        emptyroom()
        operationlevel2()
    End Sub
End Class