<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArea
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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblDelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearchArea = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.dtgvArea = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgvArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(30, 90)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(81, 36)
        Me.btnCreate.TabIndex = 10
        Me.btnCreate.Text = "ADD"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Area"
        '
        'txtArea
        '
        Me.txtArea.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(20, 47)
        Me.txtArea.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(281, 29)
        Me.txtArea.TabIndex = 6
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(119, 90)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(81, 36)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblDelete
        '
        Me.lblDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelete.Location = New System.Drawing.Point(208, 90)
        Me.lblDelete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(81, 36)
        Me.lblDelete.TabIndex = 12
        Me.lblDelete.Text = "DELETE"
        Me.lblDelete.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 150)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Search Area"
        '
        'txtSearchArea
        '
        Me.txtSearchArea.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchArea.Location = New System.Drawing.Point(22, 174)
        Me.txtSearchArea.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtSearchArea.Name = "txtSearchArea"
        Me.txtSearchArea.Size = New System.Drawing.Size(281, 29)
        Me.txtSearchArea.TabIndex = 13
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Red
        Me.lblID.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(112, 150)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(24, 20)
        Me.lblID.TabIndex = 15
        Me.lblID.Text = "ID"
        '
        'dtgvArea
        '
        Me.dtgvArea.AllowUserToAddRows = False
        Me.dtgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvArea.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dtgvArea.Location = New System.Drawing.Point(24, 214)
        Me.dtgvArea.Name = "dtgvArea"
        Me.dtgvArea.RowHeadersVisible = False
        Me.dtgvArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvArea.Size = New System.Drawing.Size(279, 189)
        Me.dtgvArea.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "areaID"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "areaName"
        Me.Column2.HeaderText = "Area Name"
        Me.Column2.Name = "Column2"
        '
        'frmArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(323, 460)
        Me.Controls.Add(Me.dtgvArea)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearchArea)
        Me.Controls.Add(Me.lblDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtArea)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Area"
        Me.TopMost = True
        CType(Me.dtgvArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearchArea As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents dtgvArea As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
