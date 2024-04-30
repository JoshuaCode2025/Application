Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim HoursWorked As Integer

        Dim HourlyRate As Integer

        Dim Gross As Integer

        Dim Deductions As Integer

        Dim netpay As Integer



        HoursWorked = Val(TextBox1.Text)

        HourlyRate = Val(TextBox2.Text)

        Gross = HoursWorked * HourlyRate

        TextBox3.Text = Gross

        Deductions = Gross * 20 / 100

        TextBox4.Text = Deductions

        netpay = Gross - Deductions

        TextBox5.Text = netpay


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub


End Class
