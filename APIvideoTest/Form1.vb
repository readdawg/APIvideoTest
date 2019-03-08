Imports TokenAuth
Imports MjpegProcessor
Imports System.Drawing


Public Class Form1

    Dim encryptedToken As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Populate text boxes when form loads
        tbUser.Text = "administrator"
        tbPassword.Text = "12345"
        tbTimeout.Text = "36000"
        tbCamera.Text = "333228228"

    End Sub

    ' Create encrypted user token
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim user As String = tbUser.Text
        Dim password As String = tbPassword.Text
        Dim timeout As Long = tbTimeout.Text

        Dim userToken As New TokenAuth.UserToken(user, password, timeout)
        encryptedToken = userToken.Encrypt()

        MsgBox(encryptedToken)

    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    ' Connect to VI API and ingest MJPEG stream
    Private Sub btnStart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVideo.Click
        Dim mjpeg As New MjpegDecoder
        Dim ip As String = "10.10.3.33"
        Dim camera As String = tbCamera.Text
        Dim url As String = "http://" + ip + ":9000/api/v1/video/" + camera + "/mjpeg?token=" + encryptedToken

        MsgBox("URL =" + url)

        AddHandler mjpeg.FrameReady, AddressOf mjpeg_FrameReady
        mjpeg.ParseStream(New Uri("http://" + ip + ":9000/api/v1/video/" + camera + "/mjpeg?token=" + encryptedToken))
    End Sub

    ' Display MJPEG stream in an image box object
    Private Sub mjpeg_FrameReady(ByVal sender As Object, ByVal e As FrameReadyEventArgs)
        pbVideo.Image = e.Bitmap
    End Sub

End Class
