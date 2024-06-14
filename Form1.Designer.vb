<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_current = New System.Windows.Forms.Label()
        Me.lbl_Used = New System.Windows.Forms.Label()
        Me.pbar_budget = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_change = New System.Windows.Forms.Button()
        Me.btn_Other = New System.Windows.Forms.Button()
        Me.btn_computers = New System.Windows.Forms.Button()
        Me.btn_lighting = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(714, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Priestley Power Dashboard"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(153, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Current Budget: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(871, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Current Used: "
        '
        'lbl_current
        '
        Me.lbl_current.AutoSize = True
        Me.lbl_current.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_current.Location = New System.Drawing.Point(407, 158)
        Me.lbl_current.Name = "lbl_current"
        Me.lbl_current.Size = New System.Drawing.Size(95, 31)
        Me.lbl_current.TabIndex = 3
        Me.lbl_current.Text = "Label4"
        '
        'lbl_Used
        '
        Me.lbl_Used.AutoSize = True
        Me.lbl_Used.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Used.Location = New System.Drawing.Point(1076, 158)
        Me.lbl_Used.Name = "lbl_Used"
        Me.lbl_Used.Size = New System.Drawing.Size(95, 31)
        Me.lbl_Used.TabIndex = 4
        Me.lbl_Used.Text = "Label5"
        '
        'pbar_budget
        '
        Me.pbar_budget.ForeColor = System.Drawing.Color.Red
        Me.pbar_budget.Location = New System.Drawing.Point(158, 251)
        Me.pbar_budget.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbar_budget.Name = "pbar_budget"
        Me.pbar_budget.Size = New System.Drawing.Size(1017, 41)
        Me.pbar_budget.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(153, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 31)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "0%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1090, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 31)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "100%"
        '
        'btn_change
        '
        Me.btn_change.Location = New System.Drawing.Point(578, 158)
        Me.btn_change.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_change.Name = "btn_change"
        Me.btn_change.Size = New System.Drawing.Size(78, 28)
        Me.btn_change.TabIndex = 8
        Me.btn_change.Text = "Change"
        Me.btn_change.UseVisualStyleBackColor = True
        '
        'btn_Other
        '
        Me.btn_Other.Location = New System.Drawing.Point(974, 562)
        Me.btn_Other.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Other.Name = "btn_Other"
        Me.btn_Other.Size = New System.Drawing.Size(286, 70)
        Me.btn_Other.TabIndex = 9
        Me.btn_Other.Text = "Other Statistics"
        Me.btn_Other.UseVisualStyleBackColor = True
        '
        'btn_computers
        '
        Me.btn_computers.Location = New System.Drawing.Point(535, 562)
        Me.btn_computers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_computers.Name = "btn_computers"
        Me.btn_computers.Size = New System.Drawing.Size(286, 70)
        Me.btn_computers.TabIndex = 10
        Me.btn_computers.Text = "Computers"
        Me.btn_computers.UseVisualStyleBackColor = True
        '
        'btn_lighting
        '
        Me.btn_lighting.Location = New System.Drawing.Point(99, 562)
        Me.btn_lighting.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_lighting.Name = "btn_lighting"
        Me.btn_lighting.Size = New System.Drawing.Size(286, 70)
        Me.btn_lighting.TabIndex = 11
        Me.btn_lighting.Text = "Lighting"
        Me.btn_lighting.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1276, 14)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 30)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(605, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 45)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1394, 667)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_lighting)
        Me.Controls.Add(Me.btn_computers)
        Me.Controls.Add(Me.btn_Other)
        Me.Controls.Add(Me.btn_change)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pbar_budget)
        Me.Controls.Add(Me.lbl_Used)
        Me.Controls.Add(Me.lbl_current)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "mmenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_current As Label
    Friend WithEvents lbl_Used As Label
    Friend WithEvents pbar_budget As ProgressBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_change As Button
    Friend WithEvents btn_Other As Button
    Friend WithEvents btn_computers As Button
    Friend WithEvents btn_lighting As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
