Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Drawing

Public Class clsWTI_WebcamSource

    Dim iDevice As Integer
    Dim hHwnd As Integer 'Handle to preview window
    Private tempObj As IDataObject
    Private tempimg As System.Drawing.Bitmap
    Private picCapture As PictureBox

    Friend WithEvents tmr_Temp As System.Windows.Forms.Timer

#Region " DECLARE - CONST "
    Const WM_CAP As Short = &H400S

    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    'Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30

    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    'Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1

    Const WM_CAP_GET_FRAME As Integer = 1084
    Const WM_CAP_COPY As Integer = 1054

#End Region
#Region " DECLARE - LIB "
    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean
    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        ( _
        ByVal lpszWindowName As String, _
        ByVal dwStyle As Integer, _
        ByVal x As Integer, _
        ByVal y As Integer, _
        ByVal nWidth As Integer, _
        ByVal nHeight As Short, _
        ByVal hWndParent As Integer, _
        ByVal nID As Integer _
        ) As Integer
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
       ( _
        ByVal hwnd As Integer, _
        ByVal wMsg As Integer, _
        ByVal wParam As Integer, _
       <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object _
       ) As Integer
    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" _
        ( _
        ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, _
        ByVal x As Integer, _
        ByVal y As Integer, _
        ByVal cx As Integer, _
        ByVal cy As Integer, _
        ByVal wFlags As Integer _
        ) As Integer
#End Region

#Region " NEW "
    Public Sub New(ByVal pic As PictureBox)
        Try
            picCapture = pic
            GetImageFromWebcam()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region " EVENT - Timer "
    Private Sub tmr_Temp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Temp.Tick
        Try
            ' get the next frame;
            SendMessage(hHwnd, WM_CAP_GET_FRAME, 0, 0)
            ' copy the frame to the clipboard
            SendMessage(hHwnd, WM_CAP_COPY, 0, 0)
            ' get from the clipboard
            tempObj = Clipboard.GetDataObject()
            tempimg = tempObj.GetData(System.Windows.Forms.DataFormats.Bitmap)
            tempimg.RotateFlip(RotateFlipType.RotateNoneFlipX)

            picCapture.Image = tempimg
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region " RETURN VALUE "
    Public Property WebcamImage As Image
        Set(value As Image)
            picCapture.Image = value
        End Set
        Get
            Return picCapture.Image
        End Get
    End Property
#End Region

#Region " FUNCTIONS "
    Private Function Valid_WebcamSource() As Boolean
        Dim f As New frmWebCamSelect
        Try
            iDevice = 0
            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                iDevice = f.lst_Source.SelectedIndex
                Return True
            Else
                WebcamImage = picCapture.Image
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
#Region " SUBS "
    Private Sub GetImageFromWebcam()
        Try
            tmr_Temp = New Timer
            If Not Valid_WebcamSource() Then Exit Sub
            Dim f As New frmWTI_WebcamCapture
            f.pic_Temp.Image = picCapture.Image
            picCapture = f.pic_IDPic
            OpenPreviewWindow()
            picCapture.SizeMode = PictureBoxSizeMode.StretchImage
            tmr_Temp.Interval = 1
            tmr_Temp.Enabled = True
            If f.ShowDialog = DialogResult.OK Then
                WebcamImage = f.pic_IDPic.Image
                SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)
            Else
                WebcamImage = f.pic_Temp.Image
                SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)
            End If
            f.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub OpenPreviewWindow()
        hHwnd = capCreateCaptureWindowA("WebCap", 0, 0, 0, 640, 480, Me.picCapture.Handle.ToInt32(), 0)

        ' connect to the capture device
        SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0)
        SendMessage(hHwnd, WM_CAP_SET_PREVIEW, iDevice, 0)

        'Set the preview rate in milliseconds
        SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)
    End Sub
#End Region

#Region "SUB"
    Private Sub Test()

    End Sub
#End Region


End Class