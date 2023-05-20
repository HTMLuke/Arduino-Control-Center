Imports System.Net.NetworkInformation

Public Class Form1
    Dim myports As Array
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            myports = IO.Ports.SerialPort.GetPortNames
            ComboBox1.Items.AddRange(myports)
            ComboBox1.SelectedItem = ComboBox1.Items(0)

            SerialPort1.BaudRate = (9600)
            SerialPort1.ReadTimeout = (2000)
            SerialPort1.WriteTimeout = (2000)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            SerialPort1.Open()
            SerialPort1.WriteLine("on")
            SerialPort1.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Try
            SerialPort1.Open()
            SerialPort1.WriteLine("off")
            SerialPort1.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            SerialPort1.PortName = ComboBox1.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

        Try
            If RadioButton4.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("2a")
                SerialPort1.Close()

            End If
            If RadioButton5.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("2b")
                SerialPort1.Close()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

        Try
            If RadioButton4.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("2a")
                SerialPort1.Close()

            End If
            If RadioButton5.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("2b")
                SerialPort1.Close()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pin3 As String
        pin3 = "i3"
        pin3 = pin3 + TextBox1.Text
        Try

            SerialPort1.Open()
            SerialPort1.WriteLine(pin3)
            SerialPort1.Close()



        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        Try
            If RadioButton3.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("4a")
                SerialPort1.Close()

            End If
            If RadioButton6.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("4b")
                SerialPort1.Close()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

        Try
            If RadioButton3.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("4a")
                SerialPort1.Close()

            End If
            If RadioButton6.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("4b")
                SerialPort1.Close()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged

        Try
            If RadioButton7.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("7a")
                SerialPort1.Close()

            End If
            If RadioButton8.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("7b")
                SerialPort1.Close()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        Try
            If RadioButton7.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("7a")
                SerialPort1.Close()

            End If
            If RadioButton8.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("7b")
                SerialPort1.Close()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        Try
            If RadioButton9.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("8a")
                SerialPort1.Close()

            End If
            If RadioButton10.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("8b")
                SerialPort1.Close()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        Try
            If RadioButton9.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("8a")
                SerialPort1.Close()

            End If
            If RadioButton10.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("8b")
                SerialPort1.Close()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        Try
            If RadioButton11.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("12a")
                SerialPort1.Close()

            End If
            If RadioButton12.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("12b")
                SerialPort1.Close()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        Try
            If RadioButton11.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("12a")
                SerialPort1.Close()

            End If
            If RadioButton12.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("12b")
                SerialPort1.Close()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        Try
            If RadioButton13.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("13a")
                SerialPort1.Close()

            End If
            If RadioButton14.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("13b")
                SerialPort1.Close()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        Try
            If RadioButton13.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("13a")
                SerialPort1.Close()

            End If
            If RadioButton14.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("13b")
                SerialPort1.Close()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        Try
            If RadioButton15.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("0a")
                SerialPort1.Close()

            End If
            If RadioButton16.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("0a")
                SerialPort1.Close()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        Try
            If RadioButton15.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("0a")
                SerialPort1.Close()

            End If
            If RadioButton16.Checked = True Then
                SerialPort1.Open()
                SerialPort1.WriteLine("0a")
                SerialPort1.Close()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pin10 As String
        pin10 = "e10"
        pin10 = pin10 + TextBox5.Text
        Try

            SerialPort1.Open()
            SerialPort1.WriteLine(pin10)
            SerialPort1.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pin11 As String
        pin11 = "d11"
        pin11 = pin11 + TextBox6.Text
        Try

            SerialPort1.Open()
            SerialPort1.WriteLine(pin11)
            SerialPort1.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim pin9 As String
        pin9 = "c9"
        pin9 = pin9 + TextBox4.Text
        Try

            SerialPort1.Open()
            SerialPort1.WriteLine(pin9)
            SerialPort1.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim pin6 As String
        pin6 = "a6"
        pin6 = pin6 + TextBox3.Text
        Try

            SerialPort1.Open()
            SerialPort1.WriteLine(pin6)
            SerialPort1.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim pin5 As String
        pin5 = "q5"
        pin5 = pin5 + TextBox2.Text
        Try

            SerialPort1.Open()
            SerialPort1.WriteLine(pin5)
            SerialPort1.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class
