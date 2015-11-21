Imports System.Data.OleDb
Public Class Asrama_Lelaki_Aras_Tiga

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Me.Hide()
        akaun_pengguna.Show()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        Me.Hide()
        Aras_Asrama_Lelaki.Show()

    End Sub
    Public Sub a31()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a31"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a31")
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
    End Sub
    Public Sub a32()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a32"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a32")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label128.BackColor = Color.Red
        Else
            Label128.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label129.BackColor = Color.Red
        Else
            Label129.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a33()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a33"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a33")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label130.BackColor = Color.Red
        Else
            Label130.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label131.BackColor = Color.Red
        Else
            Label131.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a34()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a34"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a34")
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
    End Sub
    Public Sub a35()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a35"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a35")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label134.BackColor = Color.Red
        Else
            Label134.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label135.BackColor = Color.Red
        Else
            Label135.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a36()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a36"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a36")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label136.BackColor = Color.Red
        Else
            Label136.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label137.BackColor = Color.Red
        Else
            Label137.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a37()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a37"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a37")
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
    End Sub
    Public Sub a38()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a38"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a38")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label140.BackColor = Color.Red
        Else
            Label140.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label141.BackColor = Color.Red
        Else
            Label141.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a39()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a39"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a39")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label142.BackColor = Color.Red
        Else
            Label142.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label143.BackColor = Color.Red
        Else
            Label143.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a310()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a310"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a310")
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
    End Sub
    Public Sub a311()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a311"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a311")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label146.BackColor = Color.Red
        Else
            Label146.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label147.BackColor = Color.Red
        Else
            Label147.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a312()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a312"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a312")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label148.BackColor = Color.Red
        Else
            Label148.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label149.BackColor = Color.Red
        Else
            Label149.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a313()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a313"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a313")
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
    End Sub
    Public Sub a314()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a314"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a314")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label152.BackColor = Color.Red
        Else
            Label152.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label153.BackColor = Color.Red
        Else
            Label153.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a315()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a315"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a315")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label154.BackColor = Color.Red
        Else
            Label154.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label155.BackColor = Color.Red
        Else
            Label155.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a316()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a316"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a311")
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
    Public Sub a317()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a317"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a317")
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
    Public Sub a318()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a318"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a318")
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
    Public Sub a319()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a319"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a319")
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
    Public Sub a320()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a320"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a320")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label164.BackColor = Color.Red
        Else
            Label164.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label165.BackColor = Color.Red
        Else
            Label165.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a321()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a321"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a321")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label166.BackColor = Color.Red
        Else
            Label166.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label167.BackColor = Color.Red
        Else
            Label167.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a322()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a322"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a322")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label168.BackColor = Color.Red
        Else
            Label168.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label169.BackColor = Color.Red
        Else
            Label169.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a323()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a323"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a323")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label170.BackColor = Color.Red
        Else
            Label170.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label171.BackColor = Color.Red
        Else
            Label171.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a324()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a324"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a324")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label172.BackColor = Color.Red
        Else
            Label172.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label173.BackColor = Color.Red
        Else
            Label173.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a325()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a325"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a325")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label174.BackColor = Color.Red
        Else
            Label174.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label175.BackColor = Color.Red
        Else
            Label175.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a326()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a326"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a326")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label113.BackColor = Color.Red
        Else
            Label113.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label114.BackColor = Color.Red
        Else
            Label114.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a327()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a327"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a327")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label111.BackColor = Color.Red
        Else
            Label111.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label112.BackColor = Color.Red
        Else
            Label112.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a328()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a328"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a328")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label109.BackColor = Color.Red
        Else
            Label109.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label110.BackColor = Color.Red
        Else
            Label110.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a329()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a329"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a329")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label107.BackColor = Color.Red
        Else
            Label107.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label108.BackColor = Color.Red
        Else
            Label108.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a330()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a330"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a330")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label105.BackColor = Color.Red
        Else
            Label105.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label106.BackColor = Color.Red
        Else
            Label106.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a331()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a331"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a331")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label103.BackColor = Color.Red
        Else
            Label103.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label104.BackColor = Color.Red
        Else
            Label104.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a332()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a332"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a332")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label101.BackColor = Color.Red
        Else
            Label101.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label102.BackColor = Color.Red
        Else
            Label102.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a333()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a333"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a333")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label99.BackColor = Color.Red
        Else
            Label99.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label100.BackColor = Color.Red
        Else
            Label100.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a334()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a334"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a334")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label97.BackColor = Color.Red
        Else
            Label97.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label98.BackColor = Color.Red
        Else
            Label98.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a335()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a330"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a330")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label95.BackColor = Color.Red
        Else
            Label95.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label96.BackColor = Color.Red
        Else
            Label96.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a336()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a336"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a336")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label93.BackColor = Color.Red
        Else
            Label93.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label94.BackColor = Color.Red
        Else
            Label94.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a337()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a337"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a337")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label91.BackColor = Color.Red
        Else
            Label91.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label92.BackColor = Color.Red
        Else
            Label92.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a338()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a338"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a338")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label88.BackColor = Color.Red
        Else
            Label88.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label89.BackColor = Color.Red
        Else
            Label89.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a339()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a339"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a339")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label123.BackColor = Color.Red
        Else
            Label123.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label124.BackColor = Color.Red
        Else
            Label124.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label125.BackColor = Color.Red
        Else
            Label125.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a340()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a340"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a340")
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
        If dtable.Rows(1)("status") = "yes" Then
            Label122.BackColor = Color.Red
        Else
            Label122.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a341()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a341"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a341")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label117.BackColor = Color.Red
        Else
            Label117.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label118.BackColor = Color.Red
        Else
            Label118.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label119.BackColor = Color.Red
        Else
            Label119.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a342()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a342"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a342")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label90.BackColor = Color.Red
        Else
            Label90.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label115.BackColor = Color.Red
        Else
            Label115.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label116.BackColor = Color.Red
        Else
            Label115.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a343()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a343"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a343")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label86.BackColor = Color.Red
        Else
            Label86.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label87.BackColor = Color.Red
        Else
            Label87.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a344()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a344"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a344")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label84.BackColor = Color.Red
        Else
            Label84.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label85.BackColor = Color.Red
        Else
            Label85.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a345()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a345"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a345")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label82.BackColor = Color.Red
        Else
            Label82.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label83.BackColor = Color.Red
        Else
            Label83.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a346()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a346"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a346")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label80.BackColor = Color.Red
        Else
            Label80.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label81.BackColor = Color.Red
        Else
            Label81.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a347()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a347"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a347")
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
    Public Sub a348()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a348"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a348")
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
    Public Sub a349()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a349"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a349")
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
    Public Sub a350()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a350"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a350")
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
    Public Sub a351()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a351"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a351")
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
    Public Sub a352()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a352"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a352")
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
    Public Sub a353()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a353"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a353")
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
    Public Sub a354()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a354"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a354")
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

    Private Sub Asrama_Lelaki_Aras_Tiga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        operationlevel3()
    End Sub
    Public Sub operationlevel3()
        a31()
        a32()
        a33()
        a34()
        a35()
        a36()
        a37()
        a38()
        a39()
        a310()
        a311()
        a312()
        a313()
        a314()
        a315()
        a316()
        a317()
        a318()
        a319()
        a320()
        a321()
        a322()
        a323()
        a324()
        a325()
        a326()
        a327()
        a328()
        a329()
        a330()
        a331()
        a332()
        a333()
        a334()
        a335()
        a336()
        a337()
        a338()
        a339()
        a340()
        a341()
        a342()
        a343()
        a344()
        a345()
        a346()
        a347()
        a348()
        a349()
        a350()
        a351()
        a352()
        a353()
        a354()

    End Sub

    Private Sub Label38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label38.Click
        penetapanbilik.bilik = "a31"
        penetapanbilik.Label2.Text = Label38.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label39.Click
        penetapanbilik.bilik = "a32"
        penetapanbilik.Label2.Text = Label39.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label40.Click
        penetapanbilik.bilik = "a33"
        penetapanbilik.Label2.Text = Label40.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label41.Click
        penetapanbilik.bilik = "a34"
        penetapanbilik.Label2.Text = Label41.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label42.Click
        penetapanbilik.bilik = "a35"
        penetapanbilik.Label2.Text = Label42.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label43.Click
        penetapanbilik.bilik = "a36"
        penetapanbilik.Label2.Text = Label43.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label44.Click
        penetapanbilik.bilik = "a37"
        penetapanbilik.Label2.Text = Label44.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label45.Click
        penetapanbilik.bilik = "a38"
        penetapanbilik.Label2.Text = Label45.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label46.Click
        penetapanbilik.bilik = "a39"
        penetapanbilik.Label2.Text = Label46.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label47.Click
        penetapanbilik.bilik = "a310"
        penetapanbilik.Label2.Text = Label47.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label48.Click
        penetapanbilik.bilik = "a311"
        penetapanbilik.Label2.Text = Label48.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label49.Click
        penetapanbilik.bilik = "a312"
        penetapanbilik.Label2.Text = Label49.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label50.Click
        penetapanbilik.bilik = "a313"
        penetapanbilik.Label2.Text = Label50.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label51.Click
        penetapanbilik.bilik = "a314"
        penetapanbilik.Label2.Text = Label51.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label52.Click
        penetapanbilik.bilik = "a315"
        penetapanbilik.Label2.Text = Label52.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label53.Click
        penetapanbilik.bilik = "a316"
        penetapanbilik.Label2.Text = Label53.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label54.Click
        penetapanbilik.bilik = "a317"
        penetapanbilik.Label2.Text = Label54.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label55.Click
        penetapanbilik.bilik = "a318"
        penetapanbilik.Label2.Text = Label55.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label57.Click
        penetapanbilik.bilik = "a319"
        penetapanbilik.Label2.Text = Label57.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label58.Click
        penetapanbilik.bilik = "a320"
        penetapanbilik.Label2.Text = Label58.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label59.Click
        penetapanbilik.bilik = "a321"
        penetapanbilik.Label2.Text = Label59.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label60.Click
        penetapanbilik.bilik = "a322"
        penetapanbilik.Label2.Text = Label60.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label61.Click
        penetapanbilik.bilik = "a323"
        penetapanbilik.Label2.Text = Label61.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label62.Click
        penetapanbilik.bilik = "a324"
        penetapanbilik.Label2.Text = Label62.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label63.Click
        penetapanbilik.bilik = "a325"
        penetapanbilik.Label2.Text = Label63.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click
        penetapanbilik.bilik = "a326"
        penetapanbilik.Label2.Text = Label26.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label25.Click
        penetapanbilik.bilik = "a327"
        penetapanbilik.Label2.Text = Label25.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click
        penetapanbilik.bilik = "a328"
        penetapanbilik.Label2.Text = Label24.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click
        penetapanbilik.bilik = "a329"
        penetapanbilik.Label2.Text = Label23.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click
        penetapanbilik.bilik = "a330"
        penetapanbilik.Label2.Text = Label22.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
        penetapanbilik.bilik = "a331"
        penetapanbilik.Label2.Text = Label21.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        penetapanbilik.bilik = "a332"
        penetapanbilik.Label2.Text = Label20.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        penetapanbilik.bilik = "a333"
        penetapanbilik.Label2.Text = Label19.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        penetapanbilik.bilik = "a334"
        penetapanbilik.Label2.Text = Label18.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        penetapanbilik.bilik = "a335"
        penetapanbilik.Label2.Text = Label17.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        penetapanbilik.bilik = "a336"
        penetapanbilik.Label2.Text = Label16.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        penetapanbilik.bilik = "a337"
        penetapanbilik.Label2.Text = Label15.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        penetapanbilik.bilik = "a338"
        penetapanbilik.Label2.Text = Label14.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label32.Click
        penetapanbilik.bilik = "a339"
        penetapanbilik.Label2.Text = Label32.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label31.Click
        penetapanbilik.bilik = "a340"
        penetapanbilik.Label2.Text = Label31.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label30.Click
        penetapanbilik.bilik = "a341"
        penetapanbilik.Label2.Text = Label30.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click
        penetapanbilik.bilik = "a342"
        penetapanbilik.Label2.Text = Label29.Text
        penetapanbilik.Show()
    End Sub


    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        penetapanbilik.bilik = "a343"
        penetapanbilik.Label2.Text = Label13.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        penetapanbilik.bilik = "a344"
        penetapanbilik.Label2.Text = Label12.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        penetapanbilik.bilik = "a345"
        penetapanbilik.Label2.Text = Label11.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        penetapanbilik.bilik = "a346"
        penetapanbilik.Label2.Text = Label10.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        penetapanbilik.bilik = "a347"
        penetapanbilik.Label2.Text = Label9.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        penetapanbilik.bilik = "a348"
        penetapanbilik.Label2.Text = Label7.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        penetapanbilik.bilik = "a349"
        penetapanbilik.Label2.Text = Label6.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        penetapanbilik.bilik = "a350"
        penetapanbilik.Label2.Text = Label5.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        penetapanbilik.bilik = "a351"
        penetapanbilik.Label2.Text = Label4.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        penetapanbilik.bilik = "a352"
        penetapanbilik.Label2.Text = Label3.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        penetapanbilik.bilik = "a353"
        penetapanbilik.Label2.Text = Label2.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        penetapanbilik.bilik = "a354"
        penetapanbilik.Label2.Text = Label1.Text
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
        updatedb("a31", 2)
        updatedb("a32", 2)
        updatedb("a33", 2)
        updatedb("a34", 2)
        updatedb("a35", 2)
        updatedb("a36", 2)
        updatedb("a37", 2)
        updatedb("a38", 2)
        updatedb("a39", 2)
        updatedb("a310", 2)
        updatedb("a311", 2)
        updatedb("a312", 2)
        updatedb("a313", 2)
        updatedb("a314", 2)
        updatedb("a315", 2)
        updatedb("a316", 2)
        updatedb("a317", 2)
        updatedb("a318", 2)
        updatedb("a319", 2)
        updatedb("a320", 2)
        updatedb("a321", 2)
        updatedb("a322", 2)
        updatedb("a323", 2)
        updatedb("a324", 2)
        updatedb("a325", 2)
        updatedb("a326", 2)
        updatedb("a327", 2)
        updatedb("a328", 2)
        updatedb("a329", 2)
        updatedb("a330", 2)
        updatedb("a331", 2)
        updatedb("a332", 2)
        updatedb("a333", 2)
        updatedb("a334", 2)
        updatedb("a335", 2)
        updatedb("a336", 2)
        updatedb("a337", 2)
        updatedb("a338", 2)
        updatedb("a339", 3)
        updatedb("a340", 3)
        updatedb("a341", 3)
        updatedb("a342", 3)
        updatedb("a343", 2)
        updatedb("a344", 2)
        updatedb("a345", 2)
        updatedb("a346", 2)
        updatedb("a347", 2)
        updatedb("a348", 2)
        updatedb("a349", 2)
        updatedb("a350", 2)
        updatedb("a351", 2)
        updatedb("a352", 2)
        updatedb("a353", 2)
        updatedb("a354", 2)

      
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        emptyroom()
        operationlevel3()
    End Sub
End Class