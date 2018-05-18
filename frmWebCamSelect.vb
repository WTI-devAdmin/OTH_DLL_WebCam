Public Class frmWebCamSelect

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" _
        ( _
        ByVal wDriver As Short, _
        ByVal lpszName As String, _
        ByVal cbName As Integer, _
        ByVal lpszVer As String, _
        ByVal cbVer As Integer _
        ) As Boolean
#Region " EVENT - Form "
    Private Sub MyBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDeviceList()
        If lst_Source.Items.Count > 0 Then
            lst_Source.SelectedIndex = 0
        Else
            lst_Source.Items.Add("No Capture Device")
            btn_Select.Enabled = False
        End If
    End Sub
#End Region
#Region " EVENT - List Box "
    Private Sub lst_Source_DoubleClick(sender As Object, e As EventArgs) Handles lst_Source.DoubleClick
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
#End Region
#Region " EVENT - Button "
    Private Sub btn_Select_Click(sender As Object, e As EventArgs) Handles btn_Select.Click
            Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
        'Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region " SUBS "
    Private Sub LoadDeviceList()
        Dim strName As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bReturn As Boolean
        Dim x As Integer = 0
        ' Load name of all avialable devices into the lstDevices
        Do
            'Get Driver name and version
            bReturn = capGetDriverDescriptionA(x, strName, 100, strVer, 100)

            'If there was a device add device name to the list
            If bReturn Then lst_Source.Items.Add(strName.Trim)
            x += 1
        Loop Until bReturn = False
    End Sub
#End Region



End Class