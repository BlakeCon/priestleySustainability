<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class computers
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_LRC = New System.Windows.Forms.Button()
        Me.btn_LC = New System.Windows.Forms.Button()
        Me.btn_mob = New System.Windows.Forms.Button()
        Me.btn_oth = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_locator = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btn_all = New System.Windows.Forms.Button()
        Me.btn_power = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1333, 736)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 30)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1446, 736)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 30)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_LRC
        '
        Me.btn_LRC.Location = New System.Drawing.Point(91, 140)
        Me.btn_LRC.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_LRC.Name = "btn_LRC"
        Me.btn_LRC.Size = New System.Drawing.Size(237, 70)
        Me.btn_LRC.TabIndex = 10
        Me.btn_LRC.Text = "Learning Resouce Centre"
        Me.btn_LRC.UseVisualStyleBackColor = True
        '
        'btn_LC
        '
        Me.btn_LC.Location = New System.Drawing.Point(375, 140)
        Me.btn_LC.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_LC.Name = "btn_LC"
        Me.btn_LC.Size = New System.Drawing.Size(237, 70)
        Me.btn_LC.TabIndex = 11
        Me.btn_LC.Text = "Lewis Carrol"
        Me.btn_LC.UseVisualStyleBackColor = True
        '
        'btn_mob
        '
        Me.btn_mob.Location = New System.Drawing.Point(651, 140)
        Me.btn_mob.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_mob.Name = "btn_mob"
        Me.btn_mob.Size = New System.Drawing.Size(237, 70)
        Me.btn_mob.TabIndex = 12
        Me.btn_mob.Text = "Laptops / Mobile Devices"
        Me.btn_mob.UseVisualStyleBackColor = True
        '
        'btn_oth
        '
        Me.btn_oth.Location = New System.Drawing.Point(929, 140)
        Me.btn_oth.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_oth.Name = "btn_oth"
        Me.btn_oth.Size = New System.Drawing.Size(237, 70)
        Me.btn_oth.TabIndex = 13
        Me.btn_oth.Text = "Other"
        Me.btn_oth.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(558, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 83)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Computers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(496, 260)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Locator:"
        '
        'lbl_locator
        '
        Me.lbl_locator.AutoSize = True
        Me.lbl_locator.Location = New System.Drawing.Point(569, 260)
        Me.lbl_locator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_locator.Name = "lbl_locator"
        Me.lbl_locator.Size = New System.Drawing.Size(40, 16)
        Me.lbl_locator.TabIndex = 16
        Me.lbl_locator.Text = "None"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(320, 322)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(774, 287)
        Me.DataGridView1.TabIndex = 17
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(954, 561)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(13, 6)
        Me.DataGridView2.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 18)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(681, 249)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(214, 50)
        Me.btnSubmit.TabIndex = 20
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btn_all
        '
        Me.btn_all.Location = New System.Drawing.Point(1204, 140)
        Me.btn_all.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_all.Name = "btn_all"
        Me.btn_all.Size = New System.Drawing.Size(237, 70)
        Me.btn_all.TabIndex = 21
        Me.btn_all.Text = "All"
        Me.btn_all.UseVisualStyleBackColor = True
        '
        'btn_power
        '
        Me.btn_power.Location = New System.Drawing.Point(1125, 559)
        Me.btn_power.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_power.Name = "btn_power"
        Me.btn_power.Size = New System.Drawing.Size(214, 50)
        Me.btn_power.TabIndex = 22
        Me.btn_power.Text = "Turn Off Comptuers Within Locator"
        Me.btn_power.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1125, 505)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(214, 50)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Turn Off All Comptuers "
        Me.Button4.UseVisualStyleBackColor = True
        '
        'computers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1577, 788)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btn_power)
        Me.Controls.Add(Me.btn_all)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_locator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_oth)
        Me.Controls.Add(Me.btn_mob)
        Me.Controls.Add(Me.btn_LC)
        Me.Controls.Add(Me.btn_LRC)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "computers"
        Me.Text = "otherStats"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_LRC As Button
    Friend WithEvents btn_LC As Button
    Friend WithEvents btn_mob As Button
    Friend WithEvents btn_oth As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_locator As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btn_all As Button
    Friend WithEvents btn_power As Button
    Friend WithEvents Button4 As Button
End Class
