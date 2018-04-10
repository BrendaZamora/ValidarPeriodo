Public Class Form1


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1.MaxLength = 7
    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Char.IsControl(e.KeyChar) And e.KeyChar <> "-" Then
            e.Handled = True
            Exit Sub

        End If
        If Char.IsControl(e.KeyChar) Then

        End If
        Dim pos As Integer = TextBox1.SelectionStart

        If e.KeyChar = "-" And pos <> 2 Then
            e.Handled = True
            Exit Sub
        End If

        If Char.IsNumber(e.KeyChar) And (pos = 2) Then
            e.Handled = True
            Exit Sub

        End If


    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus

        Dim mes As Integer = CInt(TextBox1.Text.Substring(3, 2))
        Dim año As Integer = CInt(TextBox1.Text.Substring(6, 4))

        If año < 1980 Or año > 2018 Then
            MsgBox("año no valido")
            TextBox1.Focus()
            Exit Sub

        End If
        If mes < 1 Or mes > 12 Then
            MsgBox("mes no valido")
            TextBox1.Focus()
            Exit Sub
        End If


    End Sub
End Class
