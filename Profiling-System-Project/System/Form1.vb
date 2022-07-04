Imports System.Data.OleDb

Public Class frmProfiling

    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = " & Application.StartupPath & "\Profile_Database.mdb")

    Private Sub bind_data()

        Dim cmd1 As New OleDbCommand("Select * from tbl_ProfileData", con)

        Dim da As New OleDbDataAdapter

        da.SelectCommand = cmd1

        Dim table1 As New DataTable

        table1.Clear()

        da.Fill(table1)

        DataGridView1.DataSource = table1



    End Sub



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtIDno.Select()


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDate.Text = Format(Now, "MMMM dd, yyyy")
        lblTime.Text = Format(TimeOfDay, "hh:MM:ss")
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtIDno.Text = "" And txtMname.Text = "" And txtFname.Text = "" And txtLname.Text = "" And Not rbtnMale.Checked And Not rbtnFemale.Checked And txtCourse.Text = "" And txtYrSection.Text = "" Then
            MsgBox("Please Fill up the Form", MsgBoxStyle.Information + vbOKOnly, "System")
            If vbOK Then
                Exit Sub
                txtIDno.Select()
            End If
        End If
        If txtIDno.Text = "" Then
            MsgBox("Type your ID Number", MsgBoxStyle.Information + vbOKOnly, "System")
            If vbOK Then
                    Exit Sub
                    txtIDno.Select()
                End If
            End If

            If txtFname.Text = "" Then
            MsgBox("Type your First Name", MsgBoxStyle.Information + vbOKOnly, "System")
            If vbOK Then
                    Exit Sub
                txtFname.Select()
            End If
            End If

            If txtMname.Text = "" Then
            MsgBox("Type your Middle Name", MsgBoxStyle.Information + vbOKOnly, "System")
            If vbOK Then
                Exit Sub
                txtMname.Select()
            End If
        End If

        If txtLname.Text = "" Then
            MsgBox("Type your Last Name", MsgBoxStyle.Information + vbOKOnly, "System")
            If vbOK Then
                Exit Sub
                txtLname.Select()
            End If
        End If

        If Not rbtnMale.Checked And Not rbtnFemale.Checked Then
            MsgBox("Choose your Gender", MsgBoxStyle.Exclamation + vbOKOnly, "System")
            If vbOK Then
                Exit Sub
            End If
        End If

        If txtCourse.Text = "" Then
            MsgBox("Type your Course", MsgBoxStyle.Exclamation + vbOKOnly, "System")
            If vbOK Then
                Exit Sub
                txtCourse.Select()
            End If
        End If

        If txtYrSection.Text = "" Then
            MsgBox("Type your Year & Section", MsgBoxStyle.Exclamation + vbOKOnly, "System")
            If vbOK Then
                Exit Sub
                txtYrSection.Select()
            End If
        End If



        Dim q = MsgBox("Do you want to save?", MsgBoxStyle.Question + vbYesNo, "Application")
        If q = vbYes Then

            Dim query As String = "INSERT into tbl_ProfileData VALUES(ID, firstName, middleName, lastName, BDay, Gender, Course, Year_and_Section)"

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd = New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("ID", txtIDno.Text)
            cmd.Parameters.AddWithValue("firstName", txtFname.Text)
            cmd.Parameters.AddWithValue("middleName", txtMname.Text)
            cmd.Parameters.AddWithValue("lastName", txtLname.Text)
            cmd.Parameters.AddWithValue("BDay", datePick.Value.ToShortDateString)

            If rbtnMale.Checked = True Then
                cmd.Parameters.AddWithValue("Gender", rbtnMale.Text)
            ElseIf rbtnFemale.Checked = True Then
                cmd.Parameters.AddWithValue("Gender", rbtnFemale.Text)
            End If

            cmd.Parameters.AddWithValue("Course", txtCourse.Text)
            cmd.Parameters.AddWithValue("Year_and_Section", txtYrSection.Text)

            cmd.ExecuteNonQuery()
            Dim ds As New DataSet
            Dim dt As New DataTable


            ds.Tables.Add(dt)

            Dim da As New OleDb.OleDbDataAdapter

            da = New OleDb.OleDbDataAdapter("SELECT * FROM tbl_ProfileData", con)
            da.Fill(dt)

            DataGridView1.DataSource = dt
            con.Close()

            txtIDno.Select()
            txtIDno.Clear()
            txtFname.Clear()
            txtMname.Clear()
            txtLname.Clear()

            rbtnMale.Checked = False
            rbtnFemale.Checked = False
            txtCourse.Clear()
            txtYrSection.Clear()

        Else
            GoTo Line2

        End If
Line2:
        con.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim q = MsgBox("Do you want to Edit", MsgBoxStyle.Question + vbYesNo, "Application")
        If q = vbYes Then
            End
        Else
            Exit Sub
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con.Open()

        Dim ds As New DataSet
        Dim dt As New DataTable


        ds.Tables.Add(dt)

        Dim da As New OleDb.OleDbDataAdapter

        da = New OleDb.OleDbDataAdapter("SELECT * FROM tbl_ProfileData", con)
        da.Fill(dt)

        DataGridView1.DataSource = dt
        con.Close()

    End Sub

    Dim current_row As Integer
    Dim combo
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim q = MsgBox("Do you want to Edit", MsgBoxStyle.Question + vbYesNo, "Application")
        If q = vbYes Then


            Dim gender As String
            current_row = DataGridView1.CurrentRow.Index

            txtIDno.Text = DataGridView1.Rows(current_row).Cells("ID").Value.ToString
            txtFname.Text = DataGridView1.Rows(current_row).Cells("firstName").Value.ToString
            txtLname.Text = DataGridView1.Rows(current_row).Cells("lastName").Value.ToString
            txtMname.Text = DataGridView1.Rows(current_row).Cells("middleName").Value.ToString
            combo = DataGridView1.Rows(current_row).Cells("BDay").Value.ToString
            datePick.Value = combo

            gender = DataGridView1.Rows(current_row).Cells("Gender").Value.ToString
            If Label10.Text = "Female" Then
                rbtnFemale.Checked = True
                rbtnMale.Checked = False
            Else
                rbtnMale.Checked = True
                rbtnFemale.Checked = False
            End If
            txtCourse.Text = DataGridView1.Rows(current_row).Cells("Course").Value.ToString
            txtYrSection.Text = DataGridView1.Rows(current_row).Cells("Year_and_Section").Value.ToString

            txtFname.Select()
            txtIDno.Enabled = False
            btnSave.Visible = False
            btnDone.Visible = True
            btnEdit.Enabled = False
            bind_data()
        Else
            GoTo Line2
        End If
Line2:
        con.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim q = MsgBox("Do you want to Delete?", MsgBoxStyle.Question + vbYesNo, "Application")
        If q = vbYes Then

            Dim delete_command As String

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            delete_command = "DELETE from tbl_ProfileData WHERE ID = '" & Label9.Text & "'"
            cmd = New OleDbCommand(delete_command, con)
            cmd.Parameters.AddWithValue("ID", Label9.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            bind_data()
            Label9.Text = ""
        Else
            GoTo Line2
        End If
Line2:
        con.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim selectedGR As DataGridViewRow
        Try
            selectedGR = DataGridView1.Rows(e.RowIndex)
            Label9.Text = selectedGR.Cells(0).Value
        Catch ex As Exception

        End Try



        btnEdit.Enabled = True
        btnDelete.Enabled = True
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)
        rbtnMale.Checked = True
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        Dim baseGender
        Dim update_command As String

        If rbtnFemale.Checked = True Then
            baseGender = "Female"
        ElseIf rbtnMale.Checked = True Then
            baseGender = "Male"
        End If

        update_command = "Update tbl_ProfileData set firstName='" & txtFname.Text & "', middleName='" & txtMname.Text & "', lastName='" & txtLname.Text & "', BDay='" & datePick.Value.ToShortDateString & "', Gender='" & baseGender & "', Course='" & txtCourse.Text & "', Year_and_Section='" & txtYrSection.Text & "' where id='" & Label9.Text & "'"

        con.Open()
        cmd = New OleDbCommand(update_command, con)
        cmd.ExecuteNonQuery()

        con.Close()

        Label9.Text = ""
        txtIDno.Enabled = True
        bind_data()
        btnDone.Visible = False
        btnSave.Visible = True
        txtIDno.Select()
        txtIDno.Clear()
        txtFname.Clear()
        txtMname.Clear()
        txtLname.Clear()

        rbtnMale.Checked = False
        rbtnFemale.Checked = False
        txtCourse.Clear()
        txtYrSection.Clear()
    End Sub

    Private Sub DataGridView1_MouseLeave(sender As Object, e As EventArgs) Handles DataGridView1.MouseLeave

    End Sub

    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDown
        Label9.Text = ""
        btnEdit.Enabled = False
    End Sub

    Private Sub DataGridView1_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseUp

    End Sub
End Class
