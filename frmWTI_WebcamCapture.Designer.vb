<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWTI_WebcamCapture
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWTI_WebcamCapture))
        Me.pic_IDPic = New System.Windows.Forms.PictureBox()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Select = New System.Windows.Forms.Button()
        Me.pnl_Border = New System.Windows.Forms.Panel()
        Me.pic_Temp = New System.Windows.Forms.PictureBox()
        CType(Me.pic_IDPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Border.SuspendLayout()
        CType(Me.pic_Temp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_IDPic
        '
        Me.pic_IDPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_IDPic.Location = New System.Drawing.Point(0, 0)
        Me.pic_IDPic.Name = "pic_IDPic"
        Me.pic_IDPic.Size = New System.Drawing.Size(312, 304)
        Me.pic_IDPic.TabIndex = 4
        Me.pic_IDPic.TabStop = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Cancel.Image = CType(resources.GetObject("btn_Cancel.Image"), System.Drawing.Image)
        Me.btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cancel.Location = New System.Drawing.Point(160, 312)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(144, 48)
        Me.btn_Cancel.TabIndex = 7
        Me.btn_Cancel.Text = "CANCEL"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btn_Select
        '
        Me.btn_Select.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Select.Image = CType(resources.GetObject("btn_Select.Image"), System.Drawing.Image)
        Me.btn_Select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Select.Location = New System.Drawing.Point(8, 312)
        Me.btn_Select.Name = "btn_Select"
        Me.btn_Select.Size = New System.Drawing.Size(144, 48)
        Me.btn_Select.TabIndex = 6
        Me.btn_Select.Text = "CAPTURE"
        Me.btn_Select.UseVisualStyleBackColor = False
        '
        'pnl_Border
        '
        Me.pnl_Border.BackColor = System.Drawing.Color.White
        Me.pnl_Border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_Border.Controls.Add(Me.pic_Temp)
        Me.pnl_Border.Controls.Add(Me.pic_IDPic)
        Me.pnl_Border.Controls.Add(Me.btn_Select)
        Me.pnl_Border.Controls.Add(Me.btn_Cancel)
        Me.pnl_Border.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_Border.Location = New System.Drawing.Point(0, 0)
        Me.pnl_Border.Name = "pnl_Border"
        Me.pnl_Border.Size = New System.Drawing.Size(314, 371)
        Me.pnl_Border.TabIndex = 8
        '
        'pic_Temp
        '
        Me.pic_Temp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Temp.Location = New System.Drawing.Point(16, 16)
        Me.pic_Temp.Name = "pic_Temp"
        Me.pic_Temp.Size = New System.Drawing.Size(64, 60)
        Me.pic_Temp.TabIndex = 8
        Me.pic_Temp.TabStop = False
        Me.pic_Temp.Visible = False
        '
        'frmWTI_WebcamCapture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 371)
        Me.Controls.Add(Me.pnl_Border)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWTI_WebcamCapture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capture Image Via Webcam"
        CType(Me.pic_IDPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Border.ResumeLayout(False)
        CType(Me.pic_Temp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pic_IDPic As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Select As System.Windows.Forms.Button
    Friend WithEvents pnl_Border As System.Windows.Forms.Panel
    Friend WithEvents pic_Temp As System.Windows.Forms.PictureBox
End Class
