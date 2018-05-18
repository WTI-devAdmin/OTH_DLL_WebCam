<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWebCamSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWebCamSelect))
        Me.lst_Source = New System.Windows.Forms.ListBox()
        Me.btn_Select = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.pnl_BG = New System.Windows.Forms.Panel()
        Me.pnl_BG.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_Source
        '
        Me.lst_Source.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_Source.HorizontalScrollbar = True
        Me.lst_Source.ItemHeight = 21
        Me.lst_Source.Location = New System.Drawing.Point(0, 0)
        Me.lst_Source.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lst_Source.Name = "lst_Source"
        Me.lst_Source.Size = New System.Drawing.Size(464, 170)
        Me.lst_Source.TabIndex = 2
        '
        'btn_Select
        '
        Me.btn_Select.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Select.Image = CType(resources.GetObject("btn_Select.Image"), System.Drawing.Image)
        Me.btn_Select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Select.Location = New System.Drawing.Point(160, 184)
        Me.btn_Select.Name = "btn_Select"
        Me.btn_Select.Size = New System.Drawing.Size(144, 48)
        Me.btn_Select.TabIndex = 4
        Me.btn_Select.Text = "SELECT"
        Me.btn_Select.UseVisualStyleBackColor = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Cancel.Image = CType(resources.GetObject("btn_Cancel.Image"), System.Drawing.Image)
        Me.btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cancel.Location = New System.Drawing.Point(312, 184)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(144, 48)
        Me.btn_Cancel.TabIndex = 5
        Me.btn_Cancel.Text = "CANCEL"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'pnl_BG
        '
        Me.pnl_BG.BackColor = System.Drawing.Color.White
        Me.pnl_BG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_BG.Controls.Add(Me.btn_Cancel)
        Me.pnl_BG.Controls.Add(Me.lst_Source)
        Me.pnl_BG.Controls.Add(Me.btn_Select)
        Me.pnl_BG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_BG.Location = New System.Drawing.Point(0, 0)
        Me.pnl_BG.Name = "pnl_BG"
        Me.pnl_BG.Size = New System.Drawing.Size(466, 244)
        Me.pnl_BG.TabIndex = 6
        '
        'frmWebCamSelect
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(466, 244)
        Me.Controls.Add(Me.pnl_BG)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmWebCamSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select your webcam device"
        Me.pnl_BG.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lst_Source As System.Windows.Forms.ListBox
    Friend WithEvents btn_Select As System.Windows.Forms.Button
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents pnl_BG As System.Windows.Forms.Panel
End Class
