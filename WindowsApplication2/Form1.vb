Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim file As System.IO.StreamReader
        file = My.Computer.FileSystem.OpenTextFileReader("\\Mac\Home\Desktop\test.txt")
        Dim width = Convert.ToInt32(file.ReadLine)
        Dim height = Convert.ToInt32(file.ReadLine)
        Dim imageStr = file.ReadToEnd
        Dim index = 1
        Dim c As Char
        Dim pixel As Integer
        Dim myBitMap = New Bitmap(width, height)
        For x As Integer = 0 To width - 1
            For y As Integer = 0 To height - 1
                c = GetChar(imageStr, index)
                index += 1
                If c = "0" Then
                    pixel = 255
                Else
                    pixel = 0
                End If
                Dim MyColor = Color.FromArgb(pixel, pixel, pixel)
                myBitMap.SetPixel(x, y, MyColor)
            Next
        Next
        PictureBox1.Image = myBitMap
    End Sub
End Class
