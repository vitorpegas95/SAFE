Imports System.IO

Public Class Form1
    Dim DES As New System.Security.Cryptography.TripleDESCryptoServiceProvider
    Dim Hash As New System.Security.Cryptography.MD5CryptoServiceProvider

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles encryptBtn.Click
        Try
            DES.Key = Hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(keyTxt.Text))                       'Hash the key
            DES.Mode = Security.Cryptography.CipherMode.ECB                                                         'ECB Cipher Mode
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = DES.CreateEncryptor                 '
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(dataTxt.Text)                           '
            dataTxt.Text = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            My.Settings.encrypted = dataTxt.Text

        Catch ex As Exception
            MessageBox.Show("The following error have occurred: " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles decryptBtn.Click
        Try
            DES.Key = Hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(keyTxt.Text))
            DES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = DES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(dataTxt.Text)
            dataTxt.Text = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            MessageBox.Show("The following error have occurred:" & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        dataTxt.Text = My.Settings.encrypted
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        Dim FILE_NAME As String = "SAFE.txt"

        Dim f = File.CreateText(FILE_NAME)
        f.Close()

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            objWriter.Write(dataTxt.Text)
            objWriter.Close()
            MsgBox("File created in APP Location.")
        Else
            MsgBox("The File was not created!")
        End If

    End Sub

    Private Sub CleanAPPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CleanAPPToolStripMenuItem.Click
        My.Settings.encrypted = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
