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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.dgvDetails = New System.Windows.Forms.DataGridView()
        Me.ColName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNicNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPassportNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMaritalStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNameOfHusband = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNamesofChildren = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColProtectorOfChildren = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColProtectorStillAvailable = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColBenefitsFromEmmigration = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(901, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListToolStripMenuItem, Me.NameToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'NameToolStripMenuItem
        '
        Me.NameToolStripMenuItem.Name = "NameToolStripMenuItem"
        Me.NameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NameToolStripMenuItem.Text = "Name"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(901, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'dgvDetails
        '
        Me.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColName, Me.ColAddress, Me.ColNicNo, Me.ColPassportNo, Me.ColMaritalStatus, Me.ColNameOfHusband, Me.ColNamesofChildren, Me.ColProtectorOfChildren, Me.ColProtectorStillAvailable, Me.ColBenefitsFromEmmigration})
        Me.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetails.Location = New System.Drawing.Point(0, 49)
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.Size = New System.Drawing.Size(901, 275)
        Me.dgvDetails.TabIndex = 2
        '
        'ColName
        '
        Me.ColName.FillWeight = 252.9138!
        Me.ColName.HeaderText = "Name"
        Me.ColName.Name = "ColName"
        '
        'ColAddress
        '
        Me.ColAddress.FillWeight = 92.3875!
        Me.ColAddress.HeaderText = "Address"
        Me.ColAddress.Name = "ColAddress"
        '
        'ColNicNo
        '
        Me.ColNicNo.FillWeight = 92.3875!
        Me.ColNicNo.HeaderText = "NIC No"
        Me.ColNicNo.Name = "ColNicNo"
        '
        'ColPassportNo
        '
        Me.ColPassportNo.FillWeight = 92.3875!
        Me.ColPassportNo.HeaderText = "Passport No"
        Me.ColPassportNo.Name = "ColPassportNo"
        '
        'ColMaritalStatus
        '
        Me.ColMaritalStatus.FillWeight = 92.3875!
        Me.ColMaritalStatus.HeaderText = "Marital Status"
        Me.ColMaritalStatus.Name = "ColMaritalStatus"
        '
        'ColNameOfHusband
        '
        Me.ColNameOfHusband.FillWeight = 92.3875!
        Me.ColNameOfHusband.HeaderText = "Name of Husband"
        Me.ColNameOfHusband.Name = "ColNameOfHusband"
        '
        'ColNamesofChildren
        '
        Me.ColNamesofChildren.FillWeight = 92.3875!
        Me.ColNamesofChildren.HeaderText = "Names of Children"
        Me.ColNamesofChildren.Name = "ColNamesofChildren"
        '
        'ColProtectorOfChildren
        '
        Me.ColProtectorOfChildren.FillWeight = 92.3875!
        Me.ColProtectorOfChildren.HeaderText = "Protector of Children"
        Me.ColProtectorOfChildren.Name = "ColProtectorOfChildren"
        '
        'ColProtectorStillAvailable
        '
        Me.ColProtectorStillAvailable.FillWeight = 51.45343!
        Me.ColProtectorStillAvailable.HeaderText = "Is Protector Still Available"
        Me.ColProtectorStillAvailable.Name = "ColProtectorStillAvailable"
        Me.ColProtectorStillAvailable.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColProtectorStillAvailable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ColBenefitsFromEmmigration
        '
        Me.ColBenefitsFromEmmigration.FillWeight = 48.92038!
        Me.ColBenefitsFromEmmigration.HeaderText = "Benefits From Emmigration"
        Me.ColBenefitsFromEmmigration.Name = "ColBenefitsFromEmmigration"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 324)
        Me.Controls.Add(Me.dgvDetails)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Emigrated Worker Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents dgvDetails As DataGridView
    Friend WithEvents ColName As DataGridViewTextBoxColumn
    Friend WithEvents ColAddress As DataGridViewTextBoxColumn
    Friend WithEvents ColNicNo As DataGridViewTextBoxColumn
    Friend WithEvents ColPassportNo As DataGridViewTextBoxColumn
    Friend WithEvents ColMaritalStatus As DataGridViewTextBoxColumn
    Friend WithEvents ColNameOfHusband As DataGridViewTextBoxColumn
    Friend WithEvents ColNamesofChildren As DataGridViewTextBoxColumn
    Friend WithEvents ColProtectorOfChildren As DataGridViewTextBoxColumn
    Friend WithEvents ColProtectorStillAvailable As DataGridViewCheckBoxColumn
    Friend WithEvents ColBenefitsFromEmmigration As DataGridViewCheckBoxColumn
End Class
