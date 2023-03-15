<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.btnSpeed = New System.Windows.Forms.Button()
        Me.lstSpeed = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHeading.Location = New System.Drawing.Point(306, 35)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(333, 28)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Internet Speed Test Survey"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.BackColor = System.Drawing.Color.Transparent
        Me.lblAverage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAverage.Location = New System.Drawing.Point(405, 466)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(252, 18)
        Me.lblAverage.TabIndex = 1
        Me.lblAverage.Text = "Average Internet Speed:  X Mbps"
        '
        'btnSpeed
        '
        Me.btnSpeed.BackColor = System.Drawing.Color.Khaki
        Me.btnSpeed.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSpeed.Location = New System.Drawing.Point(349, 99)
        Me.btnSpeed.Name = "btnSpeed"
        Me.btnSpeed.Size = New System.Drawing.Size(246, 44)
        Me.btnSpeed.TabIndex = 4
        Me.btnSpeed.Text = "Enter Internet Speed"
        Me.btnSpeed.UseVisualStyleBackColor = False
        '
        'lstSpeed
        '
        Me.lstSpeed.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lstSpeed.FormattingEnabled = True
        Me.lstSpeed.ItemHeight = 28
        Me.lstSpeed.Location = New System.Drawing.Point(675, 60)
        Me.lstSpeed.Name = "lstSpeed"
        Me.lstSpeed.Size = New System.Drawing.Size(90, 144)
        Me.lstSpeed.TabIndex = 5
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnClear.Location = New System.Drawing.Point(557, 377)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 29)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AcceptButton = Me.btnSpeed
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(796, 532)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstSpeed)
        Me.Controls.Add(Me.btnSpeed)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "Form1"
        Me.Text = "Internet Speed Test Survey for Home Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents btnSpeed As Button
    Friend WithEvents lstSpeed As ListBox
    Friend WithEvents btnClear As Button
End Class
