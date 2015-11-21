Imports System.Data.OleDb
Public Class Asrama_Lelaki_Aras_Lima



    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Me.Hide()
        akaun_pengguna.Show()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        Me.Hide()
        Aras_Asrama_Lelaki.Show()

    End Sub
    Public Sub a51()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a51"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a51")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label125.BackColor = Color.Red
        Else
            Label125.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label96.BackColor = Color.Red
        Else
            Label96.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a52()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a52"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a52")
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
    Public Sub a53()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a53"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a53")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label128.BackColor = Color.Red
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label129.BackColor = Color.Red
        End If
    End Sub
    Public Sub a54()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a54"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a54")
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
    Public Sub a55()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a55"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a55")
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
    Public Sub a56()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a56"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a56")
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
    Public Sub a57()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a57"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a57")
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
    Public Sub a58()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a58"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a58")
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
    Public Sub a59()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a59"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a59")
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
    Public Sub a510()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a510"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a510")
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
    Public Sub a511()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a511"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a511")
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
    Public Sub a512()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a512"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a512")
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
    Public Sub a513()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a513"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a513")
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
    Public Sub a514()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a514"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a514")
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
    Public Sub a515()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a515"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a515")
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
    Public Sub a516()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a516"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a516")
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
    Public Sub a517()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a517"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a517")
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
    Public Sub a518()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a518"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a518")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label95.BackColor = Color.Red
        Else
            Label95.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label158.BackColor = Color.Red
        Else
            Label158.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a519()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a519"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a519")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label160.BackColor = Color.Red
        Else
            Label160.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label159.BackColor = Color.Red
        Else
            Label159.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a520()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a520"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a520")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label94.BackColor = Color.Red
        Else
            Label94.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label161.BackColor = Color.Red
        Else
            Label161.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a521()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a521"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a521")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label93.BackColor = Color.Red
        Else
            Label93.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label162.BackColor = Color.Red
        Else
            Label162.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a522()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a522"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a522")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label92.BackColor = Color.Red
        Else
            Label92.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label163.BackColor = Color.Red
        Else
            Label163.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a523()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a523"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a523")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label91.BackColor = Color.Red
        Else
            Label91.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label164.BackColor = Color.Red
        Else
            Label164.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a524()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a524"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a524")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label90.BackColor = Color.Red
        Else
            Label90.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label165.BackColor = Color.Red
        Else
            Label165.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a525()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a525"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a525")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label89.BackColor = Color.Red
        Else
            Label89.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label166.BackColor = Color.Red
        Else
            Label166.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a526()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a526"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a526")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label88.BackColor = Color.Red
        Else
            Label88.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label167.BackColor = Color.Red
        Else
            Label167.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a527()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a527"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a527")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label186.BackColor = Color.Red
        Else
            Label186.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label187.BackColor = Color.Red
        Else
            Label187.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a528()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a520"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a520")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label81.BackColor = Color.Red
        Else
            Label81.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label82.BackColor = Color.Red
        Else
            Label82.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a529()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a529"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a529")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label79.BackColor = Color.Red
        Else
            Label79.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label80.BackColor = Color.Red
        Else
            Label80.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a530()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a530"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a530")
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
    Public Sub a531()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a531"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a531")
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
    Public Sub a532()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a532"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a532")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label71.BackColor = Color.Red
        Else
            Label71.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label72.BackColor = Color.Red
        Else
            Label72.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a533()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a533"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a533")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label69.BackColor = Color.Red
        Else
            Label69.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label70.BackColor = Color.Red
        Else
            Label70.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a534()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a534"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a534")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label67.BackColor = Color.Red
        Else
            Label67.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label68.BackColor = Color.Red
        Else
            Label68.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a535()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a535"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a535")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label65.BackColor = Color.Red
        Else
            Label65.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label66.BackColor = Color.Red
        Else
            Label66.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a536()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a536"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a536")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label63.BackColor = Color.Red
        Else
            Label63.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label64.BackColor = Color.Red
        Else
            Label64.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a537()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a537"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a537")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label61.BackColor = Color.Red
        Else
            Label61.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label62.BackColor = Color.Red
        Else
            Label62.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a538()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a538"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a538")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label59.BackColor = Color.Red
        Else
            Label59.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label60.BackColor = Color.Red
        Else
            Label60.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a539()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a537"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a537")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label57.BackColor = Color.Red
        Else
            Label57.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label58.BackColor = Color.Red
        Else
            Label58.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a540()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a540"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a540")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label55.BackColor = Color.Red
        Else
            Label55.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label56.BackColor = Color.Red
        Else
            Label56.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a541()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a541"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a541")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label169.BackColor = Color.Red
        Else
            Label169.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label170.BackColor = Color.Red
        Else
            Label170.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label171.BackColor = Color.Red
        Else
            Label171.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a542()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a542"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a542")
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
        If dtable.Rows(2)("status") = "yes" Then
            Label174.BackColor = Color.Red
        Else
            Label174.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a543()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a543"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a543")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label175.BackColor = Color.Red
        Else
            Label175.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label176.BackColor = Color.Red
        Else
            Label176.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label177.BackColor = Color.Red
        Else
            Label177.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a544()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a544"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a544")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label178.BackColor = Color.Red
        Else
            Label178.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label179.BackColor = Color.Red
        Else
            Label179.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(2)("status") = "yes" Then
            Label180.BackColor = Color.Red
        Else
            Label180.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a545()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a545"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a545")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label53.BackColor = Color.Red
        Else
            Label53.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label54.BackColor = Color.Red
        Else
            Label54.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a546()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a546"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a546")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label51.BackColor = Color.Red
        Else
            Label51.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label52.BackColor = Color.Red
        Else
            Label52.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a547()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a547"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a547")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label49.BackColor = Color.Red
        Else
            Label49.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label50.BackColor = Color.Red
        Else
            Label50.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a548()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a548"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a548")
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
    End Sub
    Public Sub a549()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a549"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a549")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label45.BackColor = Color.Red
        Else
            Label45.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label46.BackColor = Color.Red
        Else
            Label46.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a550()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a550"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a550")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label41.BackColor = Color.Red
        Else
            Label41.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label42.BackColor = Color.Red
        Else
            Label42.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a551()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a551"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a551")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label39.BackColor = Color.Red
        Else
            Label39.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label40.BackColor = Color.Red
        Else
            Label40.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a552()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a552"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a552")
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
    End Sub
    Public Sub a553()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a553"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a553")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label35.BackColor = Color.Red
        Else
            Label35.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label36.BackColor = Color.Red
        Else
            Label36.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a554()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a554"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a554")
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
    End Sub
    Public Sub a555()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a555"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a555")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label31.BackColor = Color.Red
        Else
            Label31.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label32.BackColor = Color.Red
        Else
            Label32.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a556()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a552"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a552")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label29.BackColor = Color.Red
        Else
            Label29.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label30.BackColor = Color.Red
        Else
            Label30.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a557()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a557"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a557")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label78.BackColor = Color.Red
        Else
            Label78.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label28.BackColor = Color.Red
        Else
            Label28.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a558()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a558"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a558")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()
        If dtable.Rows(0)("status") = "yes" Then
            Label85.BackColor = Color.Red
        Else
            Label85.BackColor = Color.LimeGreen
        End If
        If dtable.Rows(1)("status") = "yes" Then
            Label86.BackColor = Color.Red
        Else
            Label86.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub operationlevel5()
        a51()
        a52()
        a53()
        a54()
        a55()
        a56()
        a57()
        a58()
        a59()
        a510()
        a511()
        a512()
        a513()
        a514()
        a515()
        a516()
        a517()
        a518()
        a519()
        a520()
        a521()
        a522()
        a523()
        a524()
        a525()
        a526()
        a527()
        a528()
        a529()
        a530()
        a531()
        a532()
        a533()
        a534()
        a535()
        a536()
        a537()
        a538()
        a539()
        a540()
        a541()
        a542()
        a543()
        a544()
        a545()
        a546()
        a547()
        a548()
        a549()
        a550()
        a551()
        a552()
        a553()
        a554()
        a555()
        a556()
        a557()
        a558()

    End Sub

    Private Sub Asrama_Lelaki_Aras_Empat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        operationlevel5()
    End Sub

    Private Sub Label97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label97.Click
        penetapanbilik.bilik = "a51"
        penetapanbilik.Label2.Text = Label97.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label98.Click
        penetapanbilik.bilik = "a52"
        penetapanbilik.Label2.Text = Label98.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label99.Click
        penetapanbilik.bilik = "a53"
        penetapanbilik.Label2.Text = Label99.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label100.Click
        penetapanbilik.bilik = "a54"
        penetapanbilik.Label2.Text = Label100.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label101.Click
        penetapanbilik.bilik = "a55"
        penetapanbilik.Label2.Text = Label101.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label102.Click
        penetapanbilik.bilik = "a56"
        penetapanbilik.Label2.Text = Label102.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label103.Click
        penetapanbilik.bilik = "a57"
        penetapanbilik.Label2.Text = Label103.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label104.Click
        penetapanbilik.bilik = "a58"
        penetapanbilik.Label2.Text = Label104.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label105_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label105.Click
        penetapanbilik.bilik = "a59"
        penetapanbilik.Label2.Text = Label105.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label106.Click
        penetapanbilik.bilik = "a510"
        penetapanbilik.Label2.Text = Label106.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label107.Click
        penetapanbilik.bilik = "a511"
        penetapanbilik.Label2.Text = Label107.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label108.Click
        penetapanbilik.bilik = "a512"
        penetapanbilik.Label2.Text = Label108.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label109_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label109.Click
        penetapanbilik.bilik = "a513"
        penetapanbilik.Label2.Text = Label109.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label110.Click
        penetapanbilik.bilik = "a514"
        penetapanbilik.Label2.Text = Label110.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label111.Click
        penetapanbilik.bilik = "a515"
        penetapanbilik.Label2.Text = Label111.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label112.Click
        penetapanbilik.bilik = "a516"
        penetapanbilik.Label2.Text = Label112.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label113.Click
        penetapanbilik.bilik = "a517"
        penetapanbilik.Label2.Text = Label113.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label114.Click
        penetapanbilik.bilik = "a518"
        penetapanbilik.Label2.Text = Label114.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label115.Click
        penetapanbilik.bilik = "a519"
        penetapanbilik.Label2.Text = Label115.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label116.Click
        penetapanbilik.bilik = "a520"
        penetapanbilik.Label2.Text = Label116.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label117_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label117.Click
        penetapanbilik.bilik = "a521"
        penetapanbilik.Label2.Text = Label117.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label118.Click
        penetapanbilik.bilik = "a522"
        penetapanbilik.Label2.Text = Label118.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label119.Click
        penetapanbilik.bilik = "a523"
        penetapanbilik.Label2.Text = Label119.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label120.Click
        penetapanbilik.bilik = "a524"
        penetapanbilik.Label2.Text = Label120.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label121.Click
        penetapanbilik.bilik = "a525"
        penetapanbilik.Label2.Text = Label121.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label122_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label122.Click
        penetapanbilik.bilik = "a526"
        penetapanbilik.Label2.Text = Label122.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label185_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label185.Click
        penetapanbilik.bilik = "a527"
        penetapanbilik.Label2.Text = Label185.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click
        penetapanbilik.bilik = "a528"
        penetapanbilik.Label2.Text = Label26.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label25.Click
        penetapanbilik.bilik = "a529"
        penetapanbilik.Label2.Text = Label25.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click
        penetapanbilik.bilik = "a530"
        penetapanbilik.Label2.Text = Label24.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click
        penetapanbilik.bilik = "a531"
        penetapanbilik.Label2.Text = Label23.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click
        penetapanbilik.bilik = "a532"
        penetapanbilik.Label2.Text = Label22.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
        penetapanbilik.bilik = "a533"
        penetapanbilik.Label2.Text = Label21.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        penetapanbilik.bilik = "a534"
        penetapanbilik.Label2.Text = Label20.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        penetapanbilik.bilik = "a535"
        penetapanbilik.Label2.Text = Label19.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        penetapanbilik.bilik = "a536"
        penetapanbilik.Label2.Text = Label18.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        penetapanbilik.bilik = "a537"
        penetapanbilik.Label2.Text = Label17.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        penetapanbilik.bilik = "a538"
        penetapanbilik.Label2.Text = Label16.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        penetapanbilik.bilik = "a539"
        penetapanbilik.Label2.Text = Label15.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        penetapanbilik.bilik = "a540"
        penetapanbilik.Label2.Text = Label14.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label87.Click
        penetapanbilik.bilik = "a541"
        penetapanbilik.Label2.Text = Label87.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label123_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label123.Click
        penetapanbilik.bilik = "a542"
        penetapanbilik.Label2.Text = Label123.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label124.Click
        penetapanbilik.bilik = "a543"
        penetapanbilik.Label2.Text = Label124.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label168_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label168.Click
        penetapanbilik.bilik = "a544"
        penetapanbilik.Label2.Text = Label168.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        penetapanbilik.bilik = "a545"
        penetapanbilik.Label2.Text = Label13.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        penetapanbilik.bilik = "a546"
        penetapanbilik.Label2.Text = Label12.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        penetapanbilik.bilik = "a547"
        penetapanbilik.Label2.Text = Label11.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        penetapanbilik.bilik = "a548"
        penetapanbilik.Label2.Text = Label10.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        penetapanbilik.bilik = "a549"
        penetapanbilik.Label2.Text = Label9.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        penetapanbilik.bilik = "a550"
        penetapanbilik.Label2.Text = Label7.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        penetapanbilik.bilik = "a551"
        penetapanbilik.Label2.Text = Label6.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        penetapanbilik.bilik = "a552"
        penetapanbilik.Label2.Text = Label5.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        penetapanbilik.bilik = "a553"
        penetapanbilik.Label2.Text = Label4.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        penetapanbilik.bilik = "a554"
        penetapanbilik.Label2.Text = Label3.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        penetapanbilik.bilik = "a555"
        penetapanbilik.Label2.Text = Label2.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        penetapanbilik.bilik = "a556"
        penetapanbilik.Label2.Text = Label1.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label73.Click
        penetapanbilik.bilik = "a557"
        penetapanbilik.Label2.Text = Label73.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click
        penetapanbilik.bilik = "a558"
        penetapanbilik.Label2.Text = Label27.Text
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
    Public Sub emptyroom()
        updatedb("a51", "1")
        updatedb("a51", "2")
        updatedb("a52", "1")
        updatedb("a52", "2")
        updatedb("a53", "1")
        updatedb("a53", "2")
        updatedb("a54", "1")
        updatedb("a54", "2")
        updatedb("a55", "1")
        updatedb("a55", "2")
        updatedb("a56", "1")
        updatedb("a56", "2")
        updatedb("a57", "1")
        updatedb("a57", "2")
        updatedb("a58", "1")
        updatedb("a58", "2")
        updatedb("a59", "1")
        updatedb("a59", "2")
        updatedb("a510", "1")
        updatedb("a510", "2")
        updatedb("a511", "1")
        updatedb("a511", "2")
        updatedb("a512", "1")
        updatedb("a512", "2")
        updatedb("a513", "1")
        updatedb("a513", "2")
        updatedb("a514", "1")
        updatedb("a514", "2")
        updatedb("a515", "1")
        updatedb("a515", "2")
        updatedb("a516", "1")
        updatedb("a516", "2")
        updatedb("a517", "1")
        updatedb("a517", "2")
        updatedb("a518", "1")
        updatedb("a518", "2")
        updatedb("a519", "1")
        updatedb("a519", "2")
        updatedb("a520", "1")
        updatedb("a520", "2")
        updatedb("a521", "1")
        updatedb("a521", "2")
        updatedb("a522", "1")
        updatedb("a522", "2")
        updatedb("a523", "1")
        updatedb("a523", "2")
        updatedb("a524", "1")
        updatedb("a524", "2")
        updatedb("a525", "1")
        updatedb("a525", "2")
        updatedb("a526", "1")
        updatedb("a526", "2")
        updatedb("a527", "1")
        updatedb("a527", "2")
        updatedb("a528", "1")
        updatedb("a528", "2")
        updatedb("a529", "1")
        updatedb("a529", "2")
        updatedb("a530", "1")
        updatedb("a530", "2")
        updatedb("a531", "1")
        updatedb("a531", "2")
        updatedb("a532", "1")
        updatedb("a532", "2")
        updatedb("a533", "1")
        updatedb("a533", "2")
        updatedb("a534", "1")
        updatedb("a534", "2")
        updatedb("a535", "1")
        updatedb("a535", "2")
        updatedb("a536", "1")
        updatedb("a536", "2")
        updatedb("a537", "1")
        updatedb("a537", "2")
        updatedb("a538", "1")
        updatedb("a538", "2")
        updatedb("a539", "1")
        updatedb("a539", "2")
        updatedb("a540", "1")
        updatedb("a540", "2")
        updatedb("a541", "1")
        updatedb("a541", "2")
        updatedb("a541", "3")
        updatedb("a542", "1")
        updatedb("a542", "2")
        updatedb("a542", "3")
        updatedb("a543", "1")
        updatedb("a543", "2")
        updatedb("a543", "3")
        updatedb("a544", "1")
        updatedb("a544", "2")
        updatedb("a544", "3")
        updatedb("a545", "1")
        updatedb("a545", "2")
        updatedb("a546", "1")
        updatedb("a546", "2")
        updatedb("a547", "1")
        updatedb("a547", "2")
        updatedb("a548", "1")
        updatedb("a548", "2")
        updatedb("a549", "1")
        updatedb("a549", "2")
        updatedb("a550", "1")
        updatedb("a550", "2")
        updatedb("a551", "1")
        updatedb("a551", "2")
        updatedb("a552", "1")
        updatedb("a552", "2")
        updatedb("a553", "1")
        updatedb("a553", "2")
        updatedb("a554", "1")
        updatedb("a554", "2")
        updatedb("a555", "1")
        updatedb("a555", "2")
        updatedb("a556", "1")
        updatedb("a556", "2")
        updatedb("a557", "1")
        updatedb("a557", "2")
        updatedb("a558", "1")
        updatedb("a558", "2")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        emptyroom()
        operationlevel5()
    End Sub
End Class

