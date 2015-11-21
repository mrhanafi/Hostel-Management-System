Imports System.Data.OleDb
Public Class Asrama_Lelaki_Aras_Empat

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Me.Hide()
        akaun_pengguna.Show()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        Me.Hide()
        Aras_Asrama_Lelaki.Show()

    End Sub
    Public Sub a41()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a41"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a41")
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
    Public Sub a42()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a42"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a42")
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
    Public Sub a43()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a43"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a43")
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
    Public Sub a44()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a44"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a44")
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
    Public Sub a45()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a45"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a45")
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
    Public Sub a46()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a46"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a46")
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
    Public Sub a47()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a47"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a47")
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
    Public Sub a48()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a48"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a48")
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
    Public Sub a49()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a49"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a49")
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
    Public Sub a410()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a410"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a410")
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
    Public Sub a411()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a411"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a411")
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
    Public Sub a412()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a412"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a412")
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
    Public Sub a413()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a413"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a413")
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
    Public Sub a414()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a414"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a414")
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
    Public Sub a415()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a415"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a415")
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
    Public Sub a416()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a416"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a416")
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
    Public Sub a417()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a417"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a417")
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
    Public Sub a418()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a418"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a418")
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
    Public Sub a419()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a419"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a419")
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
    Public Sub a420()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a420"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a420")
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
    Public Sub a421()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a421"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a421")
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
    Public Sub a422()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a422"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a422")
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
    Public Sub a423()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a423"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a423")
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
    Public Sub a424()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a424"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a424")
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
    Public Sub a425()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a425"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a425")
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
    Public Sub a426()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a426"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a426")
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
    Public Sub a427()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a427"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a427")
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
    Public Sub a428()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a420"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a420")
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
    Public Sub a429()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a429"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a429")
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
    Public Sub a430()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a430"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a430")
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
    Public Sub a431()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a431"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a431")
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
    Public Sub a432()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a432"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a432")
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
    Public Sub a433()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a433"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a433")
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
    Public Sub a435()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a435"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a435")
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
    Public Sub a436()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a436"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a436")
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
    Public Sub a437()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a437"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a437")
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
    Public Sub a438()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a438"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a438")
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
    Public Sub a439()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a437"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a437")
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
    Public Sub a440()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a440"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a440")
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
    Public Sub a441()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a441"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a441")
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
    Public Sub a442()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a442"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a442")
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
    Public Sub a443()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a443"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a443")
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
    Public Sub a444()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a444"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a444")
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
    Public Sub a445()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a445"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a445")
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
    Public Sub a446()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a446"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a446")
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
    Public Sub a447()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a447"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a447")
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
    Public Sub a448()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a448"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a448")
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
    Public Sub a449()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a449"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a449")
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
    Public Sub a450()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a450"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a450")
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
    Public Sub a451()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a451"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a451")
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
    Public Sub a452()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a452"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a452")
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
    Public Sub a453()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a453"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a453")
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
    Public Sub a454()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a454"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a454")
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
    Public Sub a455()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a455"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a455")
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
    Public Sub a456()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a452"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a452")
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
    Public Sub a457()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a457"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a457")
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
    Public Sub a458()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a458"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a458")
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
    Public Sub operationlevel4()
        a41()
        a42()
        a43()
        a44()
        a45()
        a46()
        a47()
        a48()
        a49()
        a410()
        a411()
        a412()
        a413()
        a414()
        a415()
        a416()
        a417()
        a418()
        a419()
        a420()
        a421()
        a422()
        a423()
        a424()
        a425()
        a426()
        a427()
        a428()
        a429()
        a430()
        a431()
        a432()
        a433()
        a434()
        a435()
        a436()
        a437()
        a438()
        a439()
        a440()
        a441()
        a442()
        a443()
        a444()
        a445()
        a446()
        a447()
        a448()
        a449()
        a450()
        a451()
        a452()
        a453()
        a454()
        a455()
        a456()
        a457()
        a458()
    End Sub

    Private Sub Asrama_Lelaki_Aras_Empat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        operationlevel4()
    End Sub

    Private Sub Label97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label97.Click
        penetapanbilik.bilik = "a41"
        penetapanbilik.Label2.Text = Label97.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label98.Click
        penetapanbilik.bilik = "a42"
        penetapanbilik.Label2.Text = Label98.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label99.Click
        penetapanbilik.bilik = "a43"
        penetapanbilik.Label2.Text = Label99.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label100.Click
        penetapanbilik.bilik = "a44"
        penetapanbilik.Label2.Text = Label100.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label101.Click
        penetapanbilik.bilik = "a45"
        penetapanbilik.Label2.Text = Label101.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label102.Click
        penetapanbilik.bilik = "a46"
        penetapanbilik.Label2.Text = Label102.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label103.Click
        penetapanbilik.bilik = "a47"
        penetapanbilik.Label2.Text = Label103.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label104.Click
        penetapanbilik.bilik = "a48"
        penetapanbilik.Label2.Text = Label104.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label105_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label105.Click
        penetapanbilik.bilik = "a49"
        penetapanbilik.Label2.Text = Label105.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label106.Click
        penetapanbilik.bilik = "a410"
        penetapanbilik.Label2.Text = Label106.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label107.Click
        penetapanbilik.bilik = "a411"
        penetapanbilik.Label2.Text = Label107.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label108.Click
        penetapanbilik.bilik = "a412"
        penetapanbilik.Label2.Text = Label108.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label109_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label109.Click
        penetapanbilik.bilik = "a413"
        penetapanbilik.Label2.Text = Label109.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label110.Click
        penetapanbilik.bilik = "a414"
        penetapanbilik.Label2.Text = Label110.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label111.Click
        penetapanbilik.bilik = "a415"
        penetapanbilik.Label2.Text = Label111.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label112.Click
        penetapanbilik.bilik = "a416"
        penetapanbilik.Label2.Text = Label112.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label113.Click
        penetapanbilik.bilik = "a417"
        penetapanbilik.Label2.Text = Label113.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label114.Click
        penetapanbilik.bilik = "a418"
        penetapanbilik.Label2.Text = Label114.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label115.Click
        penetapanbilik.bilik = "a419"
        penetapanbilik.Label2.Text = Label115.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label116.Click
        penetapanbilik.bilik = "a420"
        penetapanbilik.Label2.Text = Label116.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label117_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label117.Click
        penetapanbilik.bilik = "a421"
        penetapanbilik.Label2.Text = Label117.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label118.Click
        penetapanbilik.bilik = "a422"
        penetapanbilik.Label2.Text = Label118.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label119.Click
        penetapanbilik.bilik = "a423"
        penetapanbilik.Label2.Text = Label119.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label120.Click
        penetapanbilik.bilik = "a424"
        penetapanbilik.Label2.Text = Label120.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label121.Click
        penetapanbilik.bilik = "a425"
        penetapanbilik.Label2.Text = Label121.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label122_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label122.Click
        penetapanbilik.bilik = "a426"
        penetapanbilik.Label2.Text = Label122.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label185_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label185.Click
        penetapanbilik.bilik = "a427"
        penetapanbilik.Label2.Text = Label185.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click
        penetapanbilik.bilik = "a428"
        penetapanbilik.Label2.Text = Label26.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label25.Click
        penetapanbilik.bilik = "a429"
        penetapanbilik.Label2.Text = Label25.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click
        penetapanbilik.bilik = "a430"
        penetapanbilik.Label2.Text = Label24.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click
        penetapanbilik.bilik = "a431"
        penetapanbilik.Label2.Text = Label23.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click
        penetapanbilik.bilik = "a432"
        penetapanbilik.Label2.Text = Label22.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
        penetapanbilik.bilik = "a433"
        penetapanbilik.Label2.Text = Label21.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        penetapanbilik.bilik = "a434"
        penetapanbilik.Label2.Text = Label20.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        penetapanbilik.bilik = "a435"
        penetapanbilik.Label2.Text = Label19.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        penetapanbilik.bilik = "a436"
        penetapanbilik.Label2.Text = Label18.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        penetapanbilik.bilik = "a437"
        penetapanbilik.Label2.Text = Label17.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        penetapanbilik.bilik = "a438"
        penetapanbilik.Label2.Text = Label16.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        penetapanbilik.bilik = "a439"
        penetapanbilik.Label2.Text = Label15.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        penetapanbilik.bilik = "a440"
        penetapanbilik.Label2.Text = Label14.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label87.Click
        penetapanbilik.bilik = "a441"
        penetapanbilik.Label2.Text = Label87.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label123_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label123.Click
        penetapanbilik.bilik = "a442"
        penetapanbilik.Label2.Text = Label123.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label124.Click
        penetapanbilik.bilik = "a443"
        penetapanbilik.Label2.Text = Label124.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label168_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label168.Click
        penetapanbilik.bilik = "a444"
        penetapanbilik.Label2.Text = Label168.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        penetapanbilik.bilik = "a445"
        penetapanbilik.Label2.Text = Label13.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        penetapanbilik.bilik = "a446"
        penetapanbilik.Label2.Text = Label12.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        penetapanbilik.bilik = "a447"
        penetapanbilik.Label2.Text = Label11.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        penetapanbilik.bilik = "a448"
        penetapanbilik.Label2.Text = Label10.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        penetapanbilik.bilik = "a449"
        penetapanbilik.Label2.Text = Label9.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        penetapanbilik.bilik = "a450"
        penetapanbilik.Label2.Text = Label7.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        penetapanbilik.bilik = "a451"
        penetapanbilik.Label2.Text = Label6.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        penetapanbilik.bilik = "a452"
        penetapanbilik.Label2.Text = Label5.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        penetapanbilik.bilik = "a453"
        penetapanbilik.Label2.Text = Label4.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        penetapanbilik.bilik = "a454"
        penetapanbilik.Label2.Text = Label3.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        penetapanbilik.bilik = "a455"
        penetapanbilik.Label2.Text = Label2.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        penetapanbilik.bilik = "a456"
        penetapanbilik.Label2.Text = Label1.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label73.Click
        penetapanbilik.bilik = "a457"
        penetapanbilik.Label2.Text = Label73.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click
        penetapanbilik.bilik = "a458"
        penetapanbilik.Label2.Text = Label27.Text
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
        updatedb("a41", 2)
        updatedb("a42", 2)
        updatedb("a43", 2)
        updatedb("a44", 2)
        updatedb("a45", 2)
        updatedb("a46", 2)
        updatedb("a47", 2)
        updatedb("a48", 2)
        updatedb("a49", 2)
        updatedb("a410", 2)
        updatedb("a411", 2)
        updatedb("a412", 2)
        updatedb("a413", 2)
        updatedb("a414", 2)
        updatedb("a415", 2)
        updatedb("a416", 2)
        updatedb("a417", 2)
        updatedb("a418", 2)
        updatedb("a419", 2)
        updatedb("a420", 2)
        updatedb("a421", 2)
        updatedb("a422", 2)
        updatedb("a423", 2)
        updatedb("a424", 2)
        updatedb("a425", 2)
        updatedb("a426", 2)
        updatedb("a427", 2)
        updatedb("a428", 2)
        updatedb("a429", 2)
        updatedb("a430", 2)
        updatedb("a431", 2)
        updatedb("a432", 2)
        updatedb("a433", 2)
        updatedb("a434", 2)
        updatedb("a435", 2)
        updatedb("a436", 2)
        updatedb("a437", 2)
        updatedb("a438", 2)
        updatedb("a439", 2)
        updatedb("a440", 2)
        updatedb("a441", 3)
        updatedb("a442", 3)
        updatedb("a443", 3)
        updatedb("a444", 3)
        updatedb("a445", 2)
        updatedb("a446", 2)
        updatedb("a447", 2)
        updatedb("a448", 2)
        updatedb("a449", 2)
        updatedb("a450", 2)
        updatedb("a451", 2)
        updatedb("a452", 2)
        updatedb("a453", 2)
        updatedb("a454", 2)
        updatedb("a455", 2)
        updatedb("a456", 2)
        updatedb("a457", 2)
        updatedb("a458", 2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        emptyroom()
        operationlevel4()
    End Sub
End Class
