Imports System.Diagnostics.Contracts

Public Class Form1
    Dim num1 As Integer = 0
    Dim num2 As Integer = 0
    Dim num3 As Integer = 0
    Dim num4 As Integer = 0
    Dim num5 As Integer = 0
    Dim num6 As Integer = 0
    Dim a As Integer = 0
    Dim b As Integer = 0



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then num1 = 1 Else num1 = 0
        CheckBox2.Visible = False
        Button1.Visible = False
        a = num1 + num3 + num5
        b = num2 + num4 + num6

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then num2 = 1 Else num2 = 0
        CheckBox1.Visible = False
        Button1.Visible = False
        a = num1 + num3 + num5
        b = num2 + num4 + num6

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        CheckBox1.Visible = True
        CheckBox2.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        a = num1 + num3 + num5
        b = num2 + num4 + num6
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Visible = False
        CheckBox2.Visible = False
        CheckBox3.Visible = True
        CheckBox4.Visible = True
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        a = num1 + num3 + num5
        b = num2 + num4 + num6
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then num3 = 1 Else num3 = 0
        CheckBox4.Visible = False
        Button2.Visible = False
        a = num1 + num3 + num5
        b = num2 + num4 + num6
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then num4 = 1 Else num4 = 0
        CheckBox3.Visible = False
        Button2.Visible = False
        a = num1 + num3 + num5
        b = num2 + num4 + num6
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckBox3.Visible = False
        CheckBox4.Visible = False
        CheckBox5.Visible = True
        CheckBox6.Visible = True
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        a = num1 + num3 + num5
        b = num2 + num4 + num6
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then num5 = 1 Else num5 = 0
        CheckBox6.Visible = False
        Button3.Visible = False
        Button4.Visible = True
        a = num1 + num3 + num5
        b = num2 + num4 + num6

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then num6 = 1 Else num6 = 0
        CheckBox5.Visible = False
        Button3.Visible = False
        Button4.Visible = True
        a = num1 + num3 + num5
        b = num2 + num4 + num6
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CheckBox5.Visible = False
        CheckBox6.Visible = False
        Label7.Visible = True
        Label8.Visible = True
        Label9.Text = a
        Label10.Text = b
        Label9.Visible = True
        Label10.Visible = True
        a = num1 + num3 + num5
        b = num2 + num4 + num6
        Button5.Visible = True
        Button4.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        a = 0
        b = 0
        num1 = 0
        num2 = 0
        num3 = 0
        num4 = 0
        num5 = 0
        num6 = 0
        Button4.Visible = False
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button5.Visible = False

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False

        a = num1 + num3 + num5
        b = num2 + num4 + num6
    End Sub
End Class
