<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstCamera = New System.Windows.Forms.ListBox()
        Me.lstModel = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.pbMain = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFileName)
        Me.GroupBox1.Controls.Add(Me.lstCamera)
        Me.GroupBox1.Controls.Add(Me.lstModel)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(717, 138)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection"
        '
        'lstCamera
        '
        Me.lstCamera.FormattingEnabled = True
        Me.lstCamera.ItemHeight = 16
        Me.lstCamera.Location = New System.Drawing.Point(6, 93)
        Me.lstCamera.Name = "lstCamera"
        Me.lstCamera.Size = New System.Drawing.Size(692, 36)
        Me.lstCamera.TabIndex = 2
        '
        'lstModel
        '
        Me.lstModel.FormattingEnabled = True
        Me.lstModel.ItemHeight = 16
        Me.lstModel.Location = New System.Drawing.Point(6, 51)
        Me.lstModel.Name = "lstModel"
        Me.lstModel.Size = New System.Drawing.Size(692, 36)
        Me.lstModel.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(576, 718)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(149, 33)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.AllowDrop = True
        Me.txtFileName.Location = New System.Drawing.Point(6, 23)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(692, 22)
        Me.txtFileName.TabIndex = 5
        '
        'pbMain
        '
        Me.pbMain.Location = New System.Drawing.Point(11, 152)
        Me.pbMain.Name = "pbMain"
        Me.pbMain.Size = New System.Drawing.Size(715, 556)
        Me.pbMain.TabIndex = 3
        Me.pbMain.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 763)
        Me.Controls.Add(Me.pbMain)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "ParallaxOverview"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lstCamera As ListBox
    Friend WithEvents lstModel As ListBox
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents pbMain As PictureBox
End Class
