Imports System.Data.OleDb
Public Class Asrama_Lelaki_Aras_Satu
    Dim baris As Integer
    Dim aras1 As Boolean = False

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Me.Hide()
        Aras_Asrama_Lelaki.Show()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        Me.Hide()
        akaun_pengguna.Show()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        penetapanbilik.bilik = "a132"
        penetapanbilik.Label2.Text = Label1.Text
        penetapanbilik.Show()
    End Sub

    Public Sub a132()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a132"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable132 As New DataTable("a132")
        conn.Open()
        adapter.Fill(dtable132)
        conn.Close()

        For Each dr As DataRow In dtable132.Rows
            Select Case dr(baris)
                Case 0
                    If dtable132.Rows(0)("status") = "yes" Then
                        Label17.BackColor = Color.Red
                    End If
                Case 1
                    If dtable132.Rows(1)("status") = "yes" Then
                        Label18.BackColor = Color.Red
                    End If
                Case 2
                    If dtable132.Rows(2)("status") = "yes" Then
                        Label19.BackColor = Color.Red
                    End If
                Case 3
                    If dtable132.Rows(3)("status") = "yes" Then
                        Label20.BackColor = Color.Red
                    End If
                Case 4
                    If dtable132.Rows(4)("status") = "yes" Then
                        Label21.BackColor = Color.Red
                    End If
                Case 5
                    If dtable132.Rows(5)("status") = "yes" Then
                        Label22.BackColor = Color.Red
                    End If
            End Select
        Next
    End Sub
    Public Sub a131()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a131"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable131 As New DataTable("a131")
        conn.Open()
        adapter.Fill(dtable131)
        conn.Close()

        For Each dr As DataRow In dtable131.Rows
            Select Case dr(baris)
                Case 0
                    If dtable131.Rows(0)("status") = "yes" Then
                        Label23.BackColor = Color.Red
                    End If
                Case 1
                    If dtable131.Rows(1)("status") = "yes" Then
                        Label24.BackColor = Color.Red
                    End If
                Case 2
                    If dtable131.Rows(2)("status") = "yes" Then
                        Label25.BackColor = Color.Red
                    End If
                Case 3
                    If dtable131.Rows(3)("status") = "yes" Then
                        Label26.BackColor = Color.Red
                    End If
                Case 4
                    If dtable131.Rows(4)("status") = "yes" Then
                        Label27.BackColor = Color.Red
                    End If
                Case 5
                    If dtable131.Rows(5)("status") = "yes" Then
                        Label28.BackColor = Color.Red
                    End If
            End Select
        Next
    End Sub
    Public Sub a130()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a130"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a130")
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

        If dtable.Rows(2)("status") = "yes" Then
            Label31.BackColor = Color.Red
        Else
            Label31.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(3)("status") = "yes" Then
            Label32.BackColor = Color.Red
        Else
            Label32.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(4)("status") = "yes" Then
            Label33.BackColor = Color.Red
        Else
            Label33.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(5)("status") = "yes" Then
            Label34.BackColor = Color.Red
        Else
            Label34.BackColor = Color.LimeGreen
        End If


    End Sub
    Public Sub a129()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a129"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable129 As New DataTable("a129")
        conn.Open()
        adapter.Fill(dtable129)
        conn.Close()

        If dtable129.Rows(0)("status") = "yes" Then
            Label35.BackColor = Color.Red
        Else
            Label35.BackColor = Color.LimeGreen
        End If
        If dtable129.Rows(1)("status") = "yes" Then
            Label36.BackColor = Color.Red
        Else
            Label36.BackColor = Color.LimeGreen
        End If
        If dtable129.Rows(2)("status") = "yes" Then
            Label37.BackColor = Color.Red
        Else
            Label37.BackColor = Color.LimeGreen
        End If
        If dtable129.Rows(3)("status") = "yes" Then
            Label38.BackColor = Color.Red
        Else
            Label38.BackColor = Color.LimeGreen
        End If
        If dtable129.Rows(4)("status") = "yes" Then
            Label39.BackColor = Color.Red
        Else
            Label39.BackColor = Color.LimeGreen
        End If
        If dtable129.Rows(5)("status") = "yes" Then
            Label40.BackColor = Color.Red
        Else
            Label40.BackColor = Color.LimeGreen
        End If

    End Sub
    Public Sub a128()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a128"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a128")
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

        If dtable.Rows(2)("status") = "yes" Then
            Label43.BackColor = Color.Red
        Else
            Label43.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(3)("status") = "yes" Then
            Label44.BackColor = Color.Red
        Else
            Label44.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(4)("status") = "yes" Then
            Label45.BackColor = Color.Red
        Else
            Label45.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(5)("status") = "yes" Then
            Label46.BackColor = Color.Red
        Else
            Label46.BackColor = Color.LimeGreen
        End If


    End Sub
    Public Sub a127()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a127"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a127")
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

        If dtable.Rows(5)("status") = "yes" Then
            Label52.BackColor = Color.Red
        Else
            Label52.BackColor = Color.LimeGreen
        End If


    End Sub
    Public Sub a126()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a126"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a126")
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

        If dtable.Rows(2)("status") = "yes" Then
            Label55.BackColor = Color.Red
        Else
            Label55.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(3)("status") = "yes" Then
            Label56.BackColor = Color.Red
        Else
            Label56.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(4)("status") = "yes" Then
            Label57.BackColor = Color.Red
        Else
            Label57.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(5)("status") = "yes" Then
            Label58.BackColor = Color.Red
        Else
            Label58.BackColor = Color.LimeGreen
        End If


    End Sub
    Public Sub a125()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a125"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a125")
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

        If dtable.Rows(2)("status") = "yes" Then
            Label61.BackColor = Color.Red
        Else
            Label61.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(3)("status") = "yes" Then
            Label62.BackColor = Color.Red
        Else
            Label50.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(4)("status") = "yes" Then
            Label63.BackColor = Color.Red
        Else
            Label63.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(5)("status") = "yes" Then
            Label64.BackColor = Color.Red
        Else
            Label64.BackColor = Color.LimeGreen
        End If


    End Sub
    Public Sub a124()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a124"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a124")
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

        If dtable.Rows(2)("status") = "yes" Then
            Label67.BackColor = Color.Red
        Else
            Label67.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(3)("status") = "yes" Then
            Label68.BackColor = Color.Red
        Else
            Label68.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(4)("status") = "yes" Then
            Label69.BackColor = Color.Red
        Else
            Label69.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(5)("status") = "yes" Then
            Label70.BackColor = Color.Red
        Else
            Label70.BackColor = Color.LimeGreen
        End If


    End Sub
    Public Sub a123()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a123"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a123")
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
    Public Sub a122()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a122"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a122")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()


        If dtable.Rows(0)("status") = "yes" Then
            Label73.BackColor = Color.Red
        Else
            Label73.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(1)("status") = "yes" Then
            Label74.BackColor = Color.Red
        Else
            Label74.BackColor = Color.LimeGreen
        End If


    End Sub
    Public Sub a121()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a121"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable121 As New DataTable("a121")
        conn.Open()
        adapter.Fill(dtable121)
        conn.Close()


        If dtable121.Rows(0)("status") = "yes" Then
            Label75.BackColor = Color.Red
        Else
            Label75.BackColor = Color.LimeGreen
        End If

        If dtable121.Rows(1)("status") = "yes" Then
            Label76.BackColor = Color.Red
        Else
            Label76.BackColor = Color.LimeGreen
        End If

    End Sub
    Public Sub a120()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a120"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a120")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()


        If dtable.Rows(0)("status") = "yes" Then
            Label77.BackColor = Color.Red
        Else
            Label77.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(1)("status") = "yes" Then
            Label78.BackColor = Color.Red
        Else
            Label78.BackColor = Color.LimeGreen
        End If

    End Sub
    Public Sub a119()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a119"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a119")
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
    Public Sub a11()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a11"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a111")
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
    Public Sub a12()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a12"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a12")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()


        If dtable.Rows(0)("status") = "yes" Then
            Label90.BackColor = Color.Red
        Else
            Label90.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(1)("status") = "yes" Then
            Label91.BackColor = Color.Red
        Else
            Label91.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a13()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a13"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a13")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()


        If dtable.Rows(0)("status") = "yes" Then
            Label92.BackColor = Color.Red
        Else
            Label92.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(1)("status") = "yes" Then
            Label93.BackColor = Color.Red
        Else
            Label93.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a14()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a14"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a14")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()


        If dtable.Rows(0)("status") = "yes" Then
            Label94.BackColor = Color.Red
        Else
            Label94.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(1)("status") = "yes" Then
            Label95.BackColor = Color.Red
        Else
            Label95.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a15()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a15"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a15")
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
    End Sub
    Public Sub a16()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a16"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a16")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()


        If dtable.Rows(0)("status") = "yes" Then
            Label98.BackColor = Color.Red
        Else
            Label98.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(1)("status") = "yes" Then
            Label99.BackColor = Color.Red
        Else
            Label99.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a17()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a17"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a17")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()


        If dtable.Rows(0)("status") = "yes" Then
            Label100.BackColor = Color.Red
        Else
            Label100.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(1)("status") = "yes" Then
            Label101.BackColor = Color.Red
        Else
            Label101.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a18()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a18"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a18")
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
    End Sub
    Public Sub a19()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a19"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a19")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()


        If dtable.Rows(0)("status") = "yes" Then
            Label116.BackColor = Color.Red
        Else
            Label116.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(1)("status") = "yes" Then
            Label117.BackColor = Color.Red
        Else
            Label117.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a110()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a110"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a110")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()


        If dtable.Rows(0)("status") = "yes" Then
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
    Public Sub a111()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a111"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a111")
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
    End Sub
    Public Sub a112()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a112"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a112")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()


        If dtable.Rows(0)("status") = "yes" Then
            Label122.BackColor = Color.Red
        Else
            Label122.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(1)("status") = "yes" Then
            Label123.BackColor = Color.Red
        Else
            Label123.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a113()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a113"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a113")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()


        If dtable.Rows(0)("status") = "yes" Then
            Label124.BackColor = Color.Red
        Else
            Label124.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(1)("status") = "yes" Then
            Label125.BackColor = Color.Red
        Else
            Label125.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub a114()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a114"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a114")
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
    Public Sub a115()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a115"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a115")
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
    Public Sub a116()
        Dim conn As System.Data.OleDb.OleDbConnection
        conn = New System.Data.OleDb.OleDbConnection
        conn.ConnectionString = My.Settings.asramaConnectionString
        Dim sqlsearch As String
        sqlsearch = "SELECT * FROM a116"
        Dim adapter As New OleDbDataAdapter(sqlsearch, conn)
        Dim dtable As New DataTable("a116")
        conn.Open()
        adapter.Fill(dtable)
        conn.Close()


        If dtable.Rows(0)("status") = "yes" Then
            Label141.BackColor = Color.Red
        Else
            Label141.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(1)("status") = "yes" Then
            Label142.BackColor = Color.Red
        Else
            Label142.BackColor = Color.LimeGreen
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
            Label133.BackColor = Color.Red
        Else
            Label133.BackColor = Color.LimeGreen
        End If

        If dtable.Rows(1)("status") = "yes" Then
            Label134.BackColor = Color.Red
        Else
            Label134.BackColor = Color.LimeGreen
        End If
    End Sub
    Private Sub Asrama_Lelaki_Aras_Satu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        operationlevel1()
    End Sub
    Public Sub operationlevel1()
        a132()
        a131()
        a130()
        a129()
        a128()
        a127()
        a126()
        a125()
        a124()
        a123()
        a122()
        a121()
        a120()
        a119()
        a11()
        a12()
        a13()
        a14()
        a15()
        a16()
        a17()
        a18()
        a19()
        a110()
        a111()
        a112()
        a113()
        a114()
        a116()
        a133()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        aras1 = True
        penetapanbilik.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        penetapanbilik.bilik = "a131"
        penetapanbilik.Label2.Text = Label2.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        penetapanbilik.bilik = "a130"
        penetapanbilik.Label2.Text = Label3.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        penetapanbilik.bilik = "a129"
        penetapanbilik.Label2.Text = Label4.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        penetapanbilik.bilik = "a128"
        penetapanbilik.Label2.Text = Label7.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        penetapanbilik.bilik = "a127"
        penetapanbilik.Label2.Text = Label8.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        penetapanbilik.bilik = "a126"
        penetapanbilik.Label2.Text = Label9.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        penetapanbilik.bilik = "a125"
        penetapanbilik.Label2.Text = Label10.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        penetapanbilik.bilik = "a124"
        penetapanbilik.Label2.Text = Label11.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        penetapanbilik.bilik = "a123"
        penetapanbilik.Label2.Text = Label12.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        penetapanbilik.bilik = "a122"
        penetapanbilik.Label2.Text = Label13.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        penetapanbilik.bilik = "a121"
        penetapanbilik.Label2.Text = Label14.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        penetapanbilik.bilik = "a120"
        penetapanbilik.Label2.Text = Label15.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        penetapanbilik.bilik = "a119"
        penetapanbilik.Label2.Text = Label16.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label132_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label132.Click
        penetapanbilik.bilik = "a133"
        penetapanbilik.Label2.Text = Label132.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label140_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label140.Click
        penetapanbilik.bilik = "a116"
        penetapanbilik.Label2.Text = Label40.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label81.Click
        penetapanbilik.bilik = "a11"
        penetapanbilik.Label2.Text = Label81.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label82.Click
        penetapanbilik.bilik = "a12"
        penetapanbilik.Label2.Text = Label82.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label83.Click
        penetapanbilik.bilik = "a13"
        penetapanbilik.Label2.Text = Label83.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label84.Click
        penetapanbilik.bilik = "a14"
        penetapanbilik.Label2.Text = Label84.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label85.Click
        penetapanbilik.bilik = "a15"
        penetapanbilik.Label2.Text = Label85.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label86.Click
        penetapanbilik.bilik = "a16"
        penetapanbilik.Label2.Text = Label86.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label87.Click
        penetapanbilik.bilik = "a17"
        penetapanbilik.Label2.Text = Label87.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label104.Click
        penetapanbilik.bilik = "a18"
        penetapanbilik.Label2.Text = Label104.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label107.Click
        penetapanbilik.bilik = "a19"
        penetapanbilik.Label2.Text = Label107.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label108.Click
        penetapanbilik.bilik = "a110"
        penetapanbilik.Label2.Text = Label108.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label109_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label109.Click
        penetapanbilik.bilik = "a111"
        penetapanbilik.Label2.Text = Label109.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label110.Click
        penetapanbilik.bilik = "a112"
        penetapanbilik.Label2.Text = Label110.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label111.Click
        penetapanbilik.bilik = "a113"
        penetapanbilik.Label2.Text = Label111.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label112.Click
        penetapanbilik.bilik = "a114"
        penetapanbilik.Label2.Text = Label112.Text
        penetapanbilik.Show()
    End Sub

    Private Sub Label113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label113.Click
        penetapanbilik.bilik = "a115"
        penetapanbilik.Label2.Text = Label113.Text
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
        updatedb("a11", "1")
        updatedb("a11", "2")
        updatedb("a12", "1")
        updatedb("a12", "2")
        updatedb("a13", "1")
        updatedb("a13", "2")
        updatedb("a14", "1")
        updatedb("a14", "2")
        updatedb("a15", "1")
        updatedb("a15", "2")
        updatedb("a16", "1")
        updatedb("a16", "2")
        updatedb("a17", "1")
        updatedb("a17", "2")
        updatedb("a18", "1")
        updatedb("a18", "2")
        updatedb("a19", "1")
        updatedb("a19", "2")
        updatedb("a10", "1")
        updatedb("a10", "2")
        updatedb("a111", "1")
        updatedb("a111", "2")
        updatedb("a112", "1")
        updatedb("a112", "2")
        updatedb("a113", "1")
        updatedb("a113", "2")
        updatedb("a114", "1")
        updatedb("a114", "2")
        updatedb("a115", "1")
        updatedb("a115", "2")
        updatedb("a116", "1")
        updatedb("a116", "2")
        updatedb("a117", "1")
        updatedb("a117", "2")
        updatedb("a118", "1")
        updatedb("a118", "2")
        updatedb("a119", "1")
        updatedb("a119", "2")
        updatedb("a120", "1")
        updatedb("a120", "2")
        updatedb("a121", "1")
        updatedb("a121", "2")
        updatedb("a122", "1")
        updatedb("a122", "2")
        updatedb("a123", "1")
        updatedb("a123", "2")
        updatedb("a124", "1")
        updatedb("a124", "2")
        updatedb("a124", "3")
        updatedb("a124", "4")
        updatedb("a124", "5")
        updatedb("a124", "6")
        updatedb("a125", "1")
        updatedb("a125", "2")
        updatedb("a125", "3")
        updatedb("a125", "4")
        updatedb("a125", "5")
        updatedb("a125", "6")
        updatedb("a126", "1")
        updatedb("a126", "2")
        updatedb("a126", "3")
        updatedb("a126", "4")
        updatedb("a126", "5")
        updatedb("a126", "6")
        updatedb("a127", "1")
        updatedb("a127", "2")
        updatedb("a127", "3")
        updatedb("a127", "4")
        updatedb("a127", "5")
        updatedb("a127", "6")
        updatedb("a128", "1")
        updatedb("a128", "2")
        updatedb("a128", "3")
        updatedb("a128", "4")
        updatedb("a128", "5")
        updatedb("a128", "6")
        updatedb("a129", "1")
        updatedb("a129", "2")
        updatedb("a129", "3")
        updatedb("a129", "4")
        updatedb("a129", "5")
        updatedb("a129", "6")
        updatedb("a130", "1")
        updatedb("a130", "2")
        updatedb("a130", "3")
        updatedb("a130", "4")
        updatedb("a130", "5")
        updatedb("a130", "6")
        updatedb("a131", "1")
        updatedb("a131", "2")
        updatedb("a131", "3")
        updatedb("a131", "4")
        updatedb("a131", "5")
        updatedb("a131", "6")
        updatedb("a132", "1")
        updatedb("a132", "2")
        updatedb("a132", "3")
        updatedb("a132", "4")
        updatedb("a132", "5")
        updatedb("a132", "6")
        updatedb("a133", "1")
        updatedb("a133", "2")
        updatedb("a133", "3")
        updatedb("a133", "4")
        updatedb("a133", "5")
        updatedb("a133", "6")

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        emptyroom()
        operationlevel1()
    End Sub
End Class