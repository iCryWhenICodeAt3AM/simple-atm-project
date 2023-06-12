Public Class Form1
    Dim keys() As String = {"1234", "5678"}
    Dim Caesar As Integer = 2000
    Dim Sean As Integer = 3000
    Dim Rey As Integer = 1000
    Dim Cassy As Integer = 5000
    Dim num1 As String
    Dim operation As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label35.Text = Label35.Text + "1"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label35.Text = Label35.Text + "2"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Label35.Text = Label35.Text + "3"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label35.Text = Label35.Text + "4"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label35.Text = Label35.Text + "5"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Label35.Text = Label35.Text + "6"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label35.Text = Label35.Text + "7"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label35.Text = Label35.Text + "8"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Label35.Text = Label35.Text + "9"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label35.Text = Label35.Text + "0"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Label35.Text = ""
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Label35.Text.Length > 0 Then
            Label35.Text = Label35.Text.Remove(Label35.Text.Length - 1, 1)
        End If
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If keys.Contains(Label35.Text) Then
            RadioButton2.Enabled = True
            RadioButton3.Enabled = True
            RadioButton6.Enabled = True
            TabControl1.Visible = True
        Else
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            RadioButton6.Enabled = False
            TabControl1.Visible = False
        End If
        Label3.Text = ""
        ComboBox3.Text = ""
        Label36.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label10.Text = ""
        TextBox6.Text = ""
        TextBox4.Text = ""
        Label6.Text = ""
    End Sub
    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If Button49.Visible = True Then
            If Label3.Text.Length > 0 Then
                Label3.Text = Label3.Text.Remove(Label3.Text.Length - 1, 1)
            End If
        Else
            If Label36.Text.Length > 0 Then
                Label36.Text = Label36.Text.Remove(Label36.Text.Length - 1, 1)
            End If
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        If Button49.Visible = True Then
            Label3.Text = ""
        Else
            Label36.Text = ""
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If Button49.Visible = True Then
            Label3.Text = Label3.Text + "1"
        Else
            Label36.Text = Label36.Text + "1"
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        If Button49.Visible = True Then
            Label3.Text = Label3.Text + "0"
        Else
            Label36.Text = Label36.Text + "0"
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If Button49.Visible = True Then
            Label3.Text = Label3.Text + "2"
        Else
            Label36.Text = Label36.Text + "2"
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If Button49.Visible = True Then
            Label3.Text = Label3.Text + "3"
        Else
            Label36.Text = Label36.Text + "3"
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Button49.Visible = True Then
            Label3.Text = Label3.Text + "4"
        Else
            Label36.Text = Label36.Text + "4"
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If Button49.Visible = True Then
            Label3.Text = Label3.Text + "5"
        Else
            Label36.Text = Label36.Text + "5"
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If Button49.Visible = True Then
            Label3.Text = Label3.Text + "6"
        Else
            Label36.Text = Label36.Text + "6"
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If Button49.Visible = True Then
            Label3.Text = Label3.Text + "7"
        Else
            Label36.Text = Label36.Text + "7"
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If Button49.Visible = True Then
            Label3.Text = Label3.Text + "8"
        Else
            Label36.Text = Label36.Text + "8"
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If Button49.Visible = True Then
            Label3.Text = Label3.Text + "9"
        Else
            Label36.Text = Label36.Text + "9"
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click

        If Button49.Visible = True Then
            If Not Label3.Text.Contains(".") Then
                Label3.Text = Label3.Text + "."
            End If
        Else
            If Not Label36.Text.Contains(".") Then
                Label36.Text = Label36.Text + "."
            End If
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If Label3.Text.Length > 0 Then 'if inputbox has no value then ignore the operation
            If num1 Is Nothing Then 'if num1 has no value then set its value as inputbox value then empty inputbox
                num1 = Label3.Text
                operation = "+"
                Label3.Text = ""
            ElseIf num1 IsNot Nothing Then 'if num1 has value then perform the operation
                Label3.Text = Convert.ToInt32(num1) + Convert.ToInt32(Label3.Text)
                num1 = Nothing
            End If
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If Label3.Text.Length > 0 Then 'if inputbox has no value then ignore the operation
            If num1 Is Nothing Then 'if num1 has no value then set its value as inputbox value then empty inputbox
                num1 = Label3.Text
                operation = "-"
                Label3.Text = ""
            ElseIf num1 IsNot Nothing Then 'if num1 has value then perform the operation
                Label3.Text = Convert.ToInt32(num1) - Convert.ToInt32(Label3.Text)
                num1 = Nothing
            End If
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If Label3.Text.Length > 0 Then 'if inputbox has no value then ignore the operation
            If num1 Is Nothing Then 'if num1 has no value then set its value as inputbox value then empty inputbox
                num1 = Label3.Text
                operation = "/"
                Label3.Text = ""
            ElseIf num1 IsNot Nothing Then 'if num1 has value then perform the operation
                Label3.Text = Convert.ToInt32(num1) / Convert.ToInt32(Label3.Text)
                num1 = Nothing
            End If
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If Label3.Text.Length > 0 Then 'if inputbox has no value then ignore the operation
            If num1 Is Nothing Then 'if num1 has no value then set its value as inputbox value then empty inputbox
                num1 = Label3.Text
                operation = "*"
                Label3.Text = ""
            ElseIf num1 IsNot Nothing Then 'if num1 has value then perform the operation
                Label3.Text = Convert.ToInt32(num1) * Convert.ToInt32(Label3.Text)
                num1 = Nothing
            End If
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If Label3.Text.Length > 0 Then 'if inputbox has no value then ignore the operation
            If num1 IsNot Nothing Then 'if num1 has value then perform the operation
                If operation = "+" Then
                    Label3.Text = Convert.ToInt32(num1) + Convert.ToInt32(Label3.Text)
                ElseIf operation = "-" Then
                    Label3.Text = Convert.ToInt32(num1) - Convert.ToInt32(Label3.Text)
                ElseIf operation = "/" Then
                    Label3.Text = Convert.ToInt32(num1) / Convert.ToInt32(Label3.Text)
                ElseIf operation = "*" Then
                    Label3.Text = Convert.ToInt32(num1) * Convert.ToInt32(Label3.Text)
                End If
                num1 = Nothing
            End If
        End If
    End Sub
    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Button49.Visible = True
        ComboBox3.Visible = False
        Label36.Visible = False
        Button47.Visible = False
        Button48.Visible = False
        Label4.Visible = False
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        Button49.Visible = False
        ComboBox3.Visible = True
        Label36.Visible = True
        Button47.Visible = True
        Button48.Visible = True
        Label4.Visible = True
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        If Label36.Text.Length > 0 Then
            If ComboBox3.Text = "USA" Then
                Label36.Text = Label36.Text * 0.018
            End If
            If ComboBox3.Text = "CHN" Then
                Label36.Text = Label36.Text * 0.13
            End If
            If ComboBox3.Text = "JPN" Then
                Label36.Text = Label36.Text * 2.49
            End If
        End If
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        'Withdraw
        If Label35.Text = "1234" Then
            If TextBox1.Text = "Caesar" And Label12.Visible = False Then
                TextBox1.Enabled = False
                Label10.Text = Caesar
                Label12.Visible = True
                TextBox2.Visible = True
                Label10.Visible = True
            ElseIf TextBox1.Text = "Caesar" And Label12.Visible = True Then
                If TextBox2.Text.Length > 0 Then
                    If Caesar >= Convert.ToInt32(TextBox2.Text) Then
                        Caesar -= TextBox2.Text
                        Label10.Text = Caesar
                    End If
                End If
            ElseIf TextBox1.Text = "Sean" And Label12.Visible = False Then
                TextBox1.Enabled = False
                Label10.Text = Sean
                Label12.Visible = True
                TextBox2.Visible = True
                Label10.Visible = True
            ElseIf TextBox1.Text = "Sean" And Label12.Visible = True Then
                If TextBox2.Text.Length > 0 Then
                    If Sean >= Convert.ToInt32(TextBox2.Text) Then
                        Sean -= TextBox2.Text
                        Label10.Text = Sean
                    End If
                End If
            End If
        ElseIf Label35.Text = "5678" Then
            If TextBox1.Text = "Rey" And Label12.Visible = False Then
                TextBox1.Enabled = False
                Label10.Text = Rey
                Label12.Visible = True
                TextBox2.Visible = True
                Label10.Visible = True
            ElseIf TextBox1.Text = "Rey" And Label12.Visible = True Then
                If TextBox2.Text.Length > 0 Then
                    If Rey >= Convert.ToInt32(TextBox2.Text) Then
                        Rey -= TextBox2.Text
                        Label10.Text = Rey
                    End If
                End If
            ElseIf TextBox1.Text = "Cassy" And Label12.Visible = False Then
                TextBox1.Enabled = False
                Label10.Text = Cassy
                Label12.Visible = True
                TextBox2.Visible = True
                Label10.Visible = True
            ElseIf TextBox1.Text = "Cassy" And Label12.Visible = True Then
                If TextBox2.Text.Length > 0 Then
                    If Cassy >= Convert.ToInt32(TextBox2.Text) Then
                        Cassy -= TextBox2.Text
                        Label10.Text = Cassy
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Label12.Visible = False
        TextBox2.Visible = False
        Label10.Visible = False
        TextBox2.Text = ""
        TextBox1.Enabled = True
        Label10.Text = ""
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        If Label35.Text = "1234" Then
            If TextBox6.Text = "Caesar" And Label18.Visible = False Then
                TextBox6.Enabled = False
                Label6.Text = Caesar
                Label18.Visible = True
                TextBox4.Visible = True
                Label6.Visible = True
            ElseIf TextBox6.Text = "Caesar" And Label18.Visible = True Then
                If TextBox4.Text.Length > 0 Then
                    Caesar += TextBox4.Text
                    Label6.Text = Caesar
                End If
            ElseIf TextBox6.Text = "Sean" And Label18.Visible = False Then
                TextBox6.Enabled = False
                Label6.Text = Sean
                Label18.Visible = True
                TextBox4.Visible = True
                Label6.Visible = True
            ElseIf TextBox6.Text = "Sean" And Label18.Visible = True Then
                If TextBox4.Text.Length > 0 Then
                    Sean += TextBox4.Text
                    Label6.Text = Sean
                End If
            End If
        ElseIf Label35.Text = "5678" Then
            If TextBox6.Text = "Rey" And Label18.Visible = False Then
                TextBox6.Enabled = False
                Label6.Text = Rey
                Label18.Visible = True
                TextBox4.Visible = True
                Label6.Visible = True
            ElseIf TextBox6.Text = "Rey" And Label18.Visible = True Then
                If TextBox4.Text.Length > 0 Then
                    Rey += TextBox4.Text
                    Label6.Text = Rey
                End If
            ElseIf TextBox6.Text = "Cassy" And Label18.Visible = False Then
                TextBox6.Enabled = False
                Label6.Text = Cassy
                Label18.Visible = True
                TextBox4.Visible = True
                Label6.Visible = True
            ElseIf TextBox6.Text = "Cassy" And Label18.Visible = True Then
                If TextBox4.Text.Length > 0 Then
                    Cassy += TextBox4.Text
                    Label6.Text = Cassy
                End If
            End If
        End If
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        TextBox6.Enabled = True
        Label6.Text = ""
        Label18.Visible = False
        TextBox4.Visible = False
        Label6.Visible = False
        TextBox4.Text = ""
    End Sub
End Class
