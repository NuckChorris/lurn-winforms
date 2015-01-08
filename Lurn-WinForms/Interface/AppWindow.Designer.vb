<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppWindow
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Answer1 = New System.Windows.Forms.Button()
        Me.Answer2 = New System.Windows.Forms.Button()
        Me.Answer3 = New System.Windows.Forms.Button()
        Me.Answer4 = New System.Windows.Forms.Button()
        Me.Question = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TimerLabel = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.CorrectnessLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Question, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(283, 448)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Answer1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Answer2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Answer3, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Answer4, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 204)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(283, 204)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Answer1
        '
        Me.Answer1.BackColor = System.Drawing.Color.Transparent
        Me.Answer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Answer1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Answer1.FlatAppearance.BorderSize = 0
        Me.Answer1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Answer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Answer1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer1.Location = New System.Drawing.Point(5, 6)
        Me.Answer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Answer1.Name = "Answer1"
        Me.Answer1.Size = New System.Drawing.Size(132, 90)
        Me.Answer1.TabIndex = 0
        Me.Answer1.Tag = "0"
        Me.Answer1.Text = "A"
        Me.Answer1.UseVisualStyleBackColor = False
        '
        'Answer2
        '
        Me.Answer2.BackColor = System.Drawing.Color.Transparent
        Me.Answer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Answer2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Answer2.FlatAppearance.BorderSize = 0
        Me.Answer2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Answer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Answer2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer2.Location = New System.Drawing.Point(146, 6)
        Me.Answer2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Answer2.Name = "Answer2"
        Me.Answer2.Size = New System.Drawing.Size(132, 90)
        Me.Answer2.TabIndex = 1
        Me.Answer2.Tag = "1"
        Me.Answer2.Text = "B"
        Me.Answer2.UseVisualStyleBackColor = False
        '
        'Answer3
        '
        Me.Answer3.BackColor = System.Drawing.Color.Transparent
        Me.Answer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Answer3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Answer3.FlatAppearance.BorderSize = 0
        Me.Answer3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Answer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Answer3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer3.Location = New System.Drawing.Point(5, 107)
        Me.Answer3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Answer3.Name = "Answer3"
        Me.Answer3.Size = New System.Drawing.Size(132, 91)
        Me.Answer3.TabIndex = 1
        Me.Answer3.Tag = "2"
        Me.Answer3.Text = "C"
        Me.Answer3.UseVisualStyleBackColor = False
        '
        'Answer4
        '
        Me.Answer4.BackColor = System.Drawing.Color.Transparent
        Me.Answer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Answer4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Answer4.FlatAppearance.BorderSize = 0
        Me.Answer4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Answer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Answer4.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer4.Location = New System.Drawing.Point(146, 107)
        Me.Answer4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Answer4.Name = "Answer4"
        Me.Answer4.Size = New System.Drawing.Size(132, 91)
        Me.Answer4.TabIndex = 1
        Me.Answer4.Tag = "3"
        Me.Answer4.Text = "D"
        Me.Answer4.UseVisualStyleBackColor = False
        '
        'Question
        '
        Me.Question.AutoSize = True
        Me.Question.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Question.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question.Location = New System.Drawing.Point(4, 0)
        Me.Question.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Question.Name = "Question"
        Me.Question.Size = New System.Drawing.Size(275, 204)
        Me.Question.TabIndex = 2
        Me.Question.Text = "Q"
        Me.Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.TimerLabel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ScoreLabel, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CorrectnessLabel, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 408)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(283, 40)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'TimerLabel
        '
        Me.TimerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TimerLabel.AutoSize = True
        Me.TimerLabel.Location = New System.Drawing.Point(3, 9)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(40, 21)
        Me.TimerLabel.TabIndex = 0
        Me.TimerLabel.Text = "0:00"
        '
        'ScoreLabel
        '
        Me.ScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Location = New System.Drawing.Point(261, 9)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(19, 21)
        Me.ScoreLabel.TabIndex = 1
        Me.ScoreLabel.Text = "0"
        '
        'CorrectnessLabel
        '
        Me.CorrectnessLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CorrectnessLabel.AutoSize = True
        Me.CorrectnessLabel.Location = New System.Drawing.Point(134, 9)
        Me.CorrectnessLabel.Name = "CorrectnessLabel"
        Me.CorrectnessLabel.Size = New System.Drawing.Size(14, 21)
        Me.CorrectnessLabel.TabIndex = 2
        Me.CorrectnessLabel.Text = " "
        '
        'AppWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(283, 448)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AppWindow"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Answer1 As System.Windows.Forms.Button
    Friend WithEvents Answer2 As System.Windows.Forms.Button
    Friend WithEvents Answer3 As System.Windows.Forms.Button
    Friend WithEvents Answer4 As System.Windows.Forms.Button
    Friend WithEvents Question As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TimerLabel As System.Windows.Forms.Label
    Friend WithEvents ScoreLabel As System.Windows.Forms.Label
    Friend WithEvents CorrectnessLabel As System.Windows.Forms.Label

End Class
