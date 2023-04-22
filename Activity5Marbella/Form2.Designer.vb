<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.UploadCsvButton = New System.Windows.Forms.Button()
        Me.BackupCsvButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CurrentCellTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColumnTextBox = New System.Windows.Forms.TextBox()
        Me.RowTextBox = New System.Windows.Forms.TextBox()
        Me.RemoveRowButton = New System.Windows.Forms.Button()
        Me.GoToCellButton = New System.Windows.Forms.Button()
        Me.ClearGridButton = New System.Windows.Forms.Button()
        Me.DeleteCsvButton = New System.Windows.Forms.Button()
        Me.RemoveColumnButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UploadCsvButton
        '
        Me.UploadCsvButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.UploadCsvButton.BackgroundImage = CType(resources.GetObject("UploadCsvButton.BackgroundImage"), System.Drawing.Image)
        Me.UploadCsvButton.FlatAppearance.BorderSize = 0
        Me.UploadCsvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UploadCsvButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadCsvButton.ForeColor = System.Drawing.Color.FloralWhite
        Me.UploadCsvButton.Location = New System.Drawing.Point(405, 38)
        Me.UploadCsvButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UploadCsvButton.Name = "UploadCsvButton"
        Me.UploadCsvButton.Size = New System.Drawing.Size(191, 55)
        Me.UploadCsvButton.TabIndex = 1
        Me.UploadCsvButton.Text = "Upload CSV File"
        Me.UploadCsvButton.UseVisualStyleBackColor = False
        '
        'BackupCsvButton
        '
        Me.BackupCsvButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackupCsvButton.BackgroundImage = CType(resources.GetObject("BackupCsvButton.BackgroundImage"), System.Drawing.Image)
        Me.BackupCsvButton.FlatAppearance.BorderSize = 0
        Me.BackupCsvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackupCsvButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackupCsvButton.ForeColor = System.Drawing.Color.FloralWhite
        Me.BackupCsvButton.Location = New System.Drawing.Point(878, 38)
        Me.BackupCsvButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackupCsvButton.Name = "BackupCsvButton"
        Me.BackupCsvButton.Size = New System.Drawing.Size(199, 55)
        Me.BackupCsvButton.TabIndex = 2
        Me.BackupCsvButton.Text = "Create a Back-up"
        Me.BackupCsvButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(405, 122)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(672, 359)
        Me.DataGridView1.TabIndex = 1
        '
        'CurrentCellTextBox
        '
        Me.CurrentCellTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CurrentCellTextBox.Location = New System.Drawing.Point(405, 486)
        Me.CurrentCellTextBox.Name = "CurrentCellTextBox"
        Me.CurrentCellTextBox.Size = New System.Drawing.Size(672, 22)
        Me.CurrentCellTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Bisque
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(496, 535)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Enter Column:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Bisque
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(794, 539)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Enter Row:"
        '
        'ColumnTextBox
        '
        Me.ColumnTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ColumnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ColumnTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColumnTextBox.ForeColor = System.Drawing.Color.Black
        Me.ColumnTextBox.Location = New System.Drawing.Point(618, 535)
        Me.ColumnTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ColumnTextBox.Name = "ColumnTextBox"
        Me.ColumnTextBox.Size = New System.Drawing.Size(127, 23)
        Me.ColumnTextBox.TabIndex = 12
        Me.ColumnTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RowTextBox
        '
        Me.RowTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.RowTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RowTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RowTextBox.ForeColor = System.Drawing.Color.Black
        Me.RowTextBox.Location = New System.Drawing.Point(892, 539)
        Me.RowTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RowTextBox.Name = "RowTextBox"
        Me.RowTextBox.Size = New System.Drawing.Size(127, 23)
        Me.RowTextBox.TabIndex = 13
        Me.RowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RemoveRowButton
        '
        Me.RemoveRowButton.BackColor = System.Drawing.Color.Gold
        Me.RemoveRowButton.FlatAppearance.BorderSize = 0
        Me.RemoveRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveRowButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveRowButton.ForeColor = System.Drawing.Color.Black
        Me.RemoveRowButton.Location = New System.Drawing.Point(115, 292)
        Me.RemoveRowButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RemoveRowButton.Name = "RemoveRowButton"
        Me.RemoveRowButton.Size = New System.Drawing.Size(167, 55)
        Me.RemoveRowButton.TabIndex = 22
        Me.RemoveRowButton.Text = "Remove Row"
        Me.RemoveRowButton.UseVisualStyleBackColor = False
        '
        'GoToCellButton
        '
        Me.GoToCellButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GoToCellButton.FlatAppearance.BorderSize = 0
        Me.GoToCellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoToCellButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoToCellButton.ForeColor = System.Drawing.Color.Black
        Me.GoToCellButton.Location = New System.Drawing.Point(48, 144)
        Me.GoToCellButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GoToCellButton.Name = "GoToCellButton"
        Me.GoToCellButton.Size = New System.Drawing.Size(308, 32)
        Me.GoToCellButton.TabIndex = 21
        Me.GoToCellButton.Text = "Search"
        Me.GoToCellButton.UseVisualStyleBackColor = False
        '
        'ClearGridButton
        '
        Me.ClearGridButton.BackColor = System.Drawing.Color.Gold
        Me.ClearGridButton.FlatAppearance.BorderSize = 0
        Me.ClearGridButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearGridButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearGridButton.ForeColor = System.Drawing.Color.Black
        Me.ClearGridButton.Location = New System.Drawing.Point(115, 213)
        Me.ClearGridButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearGridButton.Name = "ClearGridButton"
        Me.ClearGridButton.Size = New System.Drawing.Size(167, 55)
        Me.ClearGridButton.TabIndex = 20
        Me.ClearGridButton.Text = "Clear all"
        Me.ClearGridButton.UseVisualStyleBackColor = False
        '
        'DeleteCsvButton
        '
        Me.DeleteCsvButton.BackColor = System.Drawing.Color.Gold
        Me.DeleteCsvButton.FlatAppearance.BorderSize = 0
        Me.DeleteCsvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteCsvButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteCsvButton.ForeColor = System.Drawing.Color.Black
        Me.DeleteCsvButton.Location = New System.Drawing.Point(115, 453)
        Me.DeleteCsvButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DeleteCsvButton.Name = "DeleteCsvButton"
        Me.DeleteCsvButton.Size = New System.Drawing.Size(167, 55)
        Me.DeleteCsvButton.TabIndex = 19
        Me.DeleteCsvButton.Text = "Delete"
        Me.DeleteCsvButton.UseVisualStyleBackColor = False
        '
        'RemoveColumnButton
        '
        Me.RemoveColumnButton.BackColor = System.Drawing.Color.Gold
        Me.RemoveColumnButton.FlatAppearance.BorderSize = 0
        Me.RemoveColumnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveColumnButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveColumnButton.ForeColor = System.Drawing.Color.Black
        Me.RemoveColumnButton.Location = New System.Drawing.Point(115, 371)
        Me.RemoveColumnButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RemoveColumnButton.Name = "RemoveColumnButton"
        Me.RemoveColumnButton.Size = New System.Drawing.Size(167, 55)
        Me.RemoveColumnButton.TabIndex = 23
        Me.RemoveColumnButton.Text = "Remove Column"
        Me.RemoveColumnButton.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1108, 669)
        Me.Controls.Add(Me.RemoveColumnButton)
        Me.Controls.Add(Me.RemoveRowButton)
        Me.Controls.Add(Me.GoToCellButton)
        Me.Controls.Add(Me.ClearGridButton)
        Me.Controls.Add(Me.DeleteCsvButton)
        Me.Controls.Add(Me.RowTextBox)
        Me.Controls.Add(Me.ColumnTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CurrentCellTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BackupCsvButton)
        Me.Controls.Add(Me.UploadCsvButton)
        Me.ForeColor = System.Drawing.Color.Azure
        Me.Name = "Form2"
        Me.Text = "Activity 5: Project Data Loading and Conversion plus Database Backup Functions"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UploadCsvButton As Button
    Friend WithEvents BackupCsvButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CurrentCellTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ColumnTextBox As TextBox
    Friend WithEvents RowTextBox As TextBox
    Friend WithEvents RemoveRowButton As Button
    Friend WithEvents GoToCellButton As Button
    Friend WithEvents ClearGridButton As Button
    Friend WithEvents DeleteCsvButton As Button
    Friend WithEvents RemoveColumnButton As Button
End Class
