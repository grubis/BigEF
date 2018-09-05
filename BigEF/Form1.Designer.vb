<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BEFForm
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.AllocationTable = New System.Windows.Forms.DataGridView()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BefDataSet = New BigEF.befDataSet()
        Me.AddAlloc = New System.Windows.Forms.Button()
        Me.EditAllocAmt = New System.Windows.Forms.Button()
        Me.EditAllocDesc = New System.Windows.Forms.Button()
        Me.BEFTabs = New System.Windows.Forms.TabControl()
        Me.DashboardTab = New System.Windows.Forms.TabPage()
        Me.CategoryGraph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ContributionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegisterTab = New System.Windows.Forms.TabPage()
        Me.DeleteRegEntry = New System.Windows.Forms.Button()
        Me.EditRegDescription = New System.Windows.Forms.Button()
        Me.EditRegisterAmt = New System.Windows.Forms.Button()
        Me.AddRegEntry = New System.Windows.Forms.Button()
        Me.RegisterTable = New System.Windows.Forms.DataGridView()
        Me.DateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDepositDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RegisterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContributionTab = New System.Windows.Forms.TabPage()
        Me.DelContrib = New System.Windows.Forms.Button()
        Me.EditContribDesc = New System.Windows.Forms.Button()
        Me.EditContribAmt = New System.Windows.Forms.Button()
        Me.AddContrib = New System.Windows.Forms.Button()
        Me.ContributionTable = New System.Windows.Forms.DataGridView()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllocationTab = New System.Windows.Forms.TabPage()
        Me.DelAlloc = New System.Windows.Forms.Button()
        Me.AllocationTableAdapter = New BigEF.befDataSetTableAdapters.AllocationTableAdapter()
        Me.ContributionTableAdapter = New BigEF.befDataSetTableAdapters.ContributionTableAdapter()
        Me.RegisterTableAdapter = New BigEF.befDataSetTableAdapters.RegisterTableAdapter()
        CType(Me.AllocationTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BefDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BEFTabs.SuspendLayout()
        Me.DashboardTab.SuspendLayout()
        CType(Me.CategoryGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContributionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegisterTab.SuspendLayout()
        CType(Me.RegisterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContributionTab.SuspendLayout()
        CType(Me.ContributionTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AllocationTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'AllocationTable
        '
        Me.AllocationTable.AllowUserToAddRows = False
        Me.AllocationTable.AllowUserToDeleteRows = False
        Me.AllocationTable.AllowUserToResizeColumns = False
        Me.AllocationTable.AllowUserToResizeRows = False
        Me.AllocationTable.AutoGenerateColumns = False
        Me.AllocationTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.AllocationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AllocationTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CategoryDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn1, Me.DescriptionDataGridViewTextBoxColumn1})
        Me.AllocationTable.DataSource = Me.AllocationBindingSource
        Me.AllocationTable.Location = New System.Drawing.Point(3, 3)
        Me.AllocationTable.MultiSelect = False
        Me.AllocationTable.Name = "AllocationTable"
        Me.AllocationTable.ReadOnly = True
        Me.AllocationTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AllocationTable.Size = New System.Drawing.Size(700, 375)
        Me.AllocationTable.TabIndex = 0
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryDataGridViewTextBoxColumn.Width = 74
        '
        'AmountDataGridViewTextBoxColumn1
        '
        Me.AmountDataGridViewTextBoxColumn1.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn1.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn1.Name = "AmountDataGridViewTextBoxColumn1"
        Me.AmountDataGridViewTextBoxColumn1.ReadOnly = True
        Me.AmountDataGridViewTextBoxColumn1.Width = 68
        '
        'DescriptionDataGridViewTextBoxColumn1
        '
        Me.DescriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn1.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn1.Name = "DescriptionDataGridViewTextBoxColumn1"
        Me.DescriptionDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn1.Width = 85
        '
        'AllocationBindingSource
        '
        Me.AllocationBindingSource.DataMember = "Allocation"
        Me.AllocationBindingSource.DataSource = Me.BefDataSet
        '
        'BefDataSet
        '
        Me.BefDataSet.DataSetName = "befDataSet"
        Me.BefDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddAlloc
        '
        Me.AddAlloc.AutoEllipsis = True
        Me.AddAlloc.Location = New System.Drawing.Point(6, 385)
        Me.AddAlloc.Name = "AddAlloc"
        Me.AddAlloc.Size = New System.Drawing.Size(90, 33)
        Me.AddAlloc.TabIndex = 1
        Me.AddAlloc.Text = "Add Allocation"
        Me.AddAlloc.UseVisualStyleBackColor = True
        '
        'EditAllocAmt
        '
        Me.EditAllocAmt.AutoEllipsis = True
        Me.EditAllocAmt.Location = New System.Drawing.Point(102, 385)
        Me.EditAllocAmt.Name = "EditAllocAmt"
        Me.EditAllocAmt.Size = New System.Drawing.Size(90, 33)
        Me.EditAllocAmt.TabIndex = 2
        Me.EditAllocAmt.Text = "Edit Amount"
        Me.EditAllocAmt.UseVisualStyleBackColor = True
        '
        'EditAllocDesc
        '
        Me.EditAllocDesc.AutoEllipsis = True
        Me.EditAllocDesc.Location = New System.Drawing.Point(198, 385)
        Me.EditAllocDesc.Name = "EditAllocDesc"
        Me.EditAllocDesc.Size = New System.Drawing.Size(90, 33)
        Me.EditAllocDesc.TabIndex = 3
        Me.EditAllocDesc.Text = "Edit Description"
        Me.EditAllocDesc.UseVisualStyleBackColor = True
        '
        'BEFTabs
        '
        Me.BEFTabs.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BEFTabs.Controls.Add(Me.DashboardTab)
        Me.BEFTabs.Controls.Add(Me.RegisterTab)
        Me.BEFTabs.Controls.Add(Me.ContributionTab)
        Me.BEFTabs.Controls.Add(Me.AllocationTab)
        Me.BEFTabs.Location = New System.Drawing.Point(-4, -2)
        Me.BEFTabs.Name = "BEFTabs"
        Me.BEFTabs.SelectedIndex = 0
        Me.BEFTabs.Size = New System.Drawing.Size(805, 455)
        Me.BEFTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.BEFTabs.TabIndex = 4
        '
        'DashboardTab
        '
        Me.DashboardTab.Controls.Add(Me.CategoryGraph)
        Me.DashboardTab.Location = New System.Drawing.Point(4, 22)
        Me.DashboardTab.Name = "DashboardTab"
        Me.DashboardTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DashboardTab.Size = New System.Drawing.Size(797, 429)
        Me.DashboardTab.TabIndex = 1
        Me.DashboardTab.Text = "Dashboard"
        Me.DashboardTab.UseVisualStyleBackColor = True
        '
        'CategoryGraph
        '
        ChartArea1.Name = "ChartArea1"
        Me.CategoryGraph.ChartAreas.Add(ChartArea1)
        Me.CategoryGraph.DataSource = Me.ContributionBindingSource
        Me.CategoryGraph.Location = New System.Drawing.Point(6, 6)
        Me.CategoryGraph.Name = "CategoryGraph"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series1.Name = "Series1"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.CategoryGraph.Series.Add(Series1)
        Me.CategoryGraph.Size = New System.Drawing.Size(377, 371)
        Me.CategoryGraph.TabIndex = 0
        Me.CategoryGraph.Text = "Chart1"
        '
        'ContributionBindingSource
        '
        Me.ContributionBindingSource.DataMember = "Contribution"
        Me.ContributionBindingSource.DataSource = Me.BefDataSet
        '
        'RegisterTab
        '
        Me.RegisterTab.Controls.Add(Me.DeleteRegEntry)
        Me.RegisterTab.Controls.Add(Me.EditRegDescription)
        Me.RegisterTab.Controls.Add(Me.EditRegisterAmt)
        Me.RegisterTab.Controls.Add(Me.AddRegEntry)
        Me.RegisterTab.Controls.Add(Me.RegisterTable)
        Me.RegisterTab.Location = New System.Drawing.Point(4, 22)
        Me.RegisterTab.Name = "RegisterTab"
        Me.RegisterTab.Size = New System.Drawing.Size(797, 429)
        Me.RegisterTab.TabIndex = 3
        Me.RegisterTab.Text = "Register"
        Me.RegisterTab.UseVisualStyleBackColor = True
        '
        'DeleteRegEntry
        '
        Me.DeleteRegEntry.Location = New System.Drawing.Point(255, 384)
        Me.DeleteRegEntry.Name = "DeleteRegEntry"
        Me.DeleteRegEntry.Size = New System.Drawing.Size(75, 33)
        Me.DeleteRegEntry.TabIndex = 4
        Me.DeleteRegEntry.Text = "Delete Entry"
        Me.DeleteRegEntry.UseVisualStyleBackColor = True
        '
        'EditRegDescription
        '
        Me.EditRegDescription.Location = New System.Drawing.Point(174, 385)
        Me.EditRegDescription.Name = "EditRegDescription"
        Me.EditRegDescription.Size = New System.Drawing.Size(75, 33)
        Me.EditRegDescription.TabIndex = 3
        Me.EditRegDescription.Text = "Edit Desc"
        Me.EditRegDescription.UseVisualStyleBackColor = True
        '
        'EditRegisterAmt
        '
        Me.EditRegisterAmt.Location = New System.Drawing.Point(93, 385)
        Me.EditRegisterAmt.Name = "EditRegisterAmt"
        Me.EditRegisterAmt.Size = New System.Drawing.Size(75, 33)
        Me.EditRegisterAmt.TabIndex = 2
        Me.EditRegisterAmt.Text = "Edit Amt"
        Me.EditRegisterAmt.UseVisualStyleBackColor = True
        '
        'AddRegEntry
        '
        Me.AddRegEntry.Location = New System.Drawing.Point(12, 385)
        Me.AddRegEntry.Name = "AddRegEntry"
        Me.AddRegEntry.Size = New System.Drawing.Size(75, 33)
        Me.AddRegEntry.TabIndex = 1
        Me.AddRegEntry.Text = "Add Entry"
        Me.AddRegEntry.UseVisualStyleBackColor = True
        '
        'RegisterTable
        '
        Me.RegisterTable.AllowUserToAddRows = False
        Me.RegisterTable.AllowUserToDeleteRows = False
        Me.RegisterTable.AllowUserToResizeColumns = False
        Me.RegisterTable.AllowUserToResizeRows = False
        Me.RegisterTable.AutoGenerateColumns = False
        Me.RegisterTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.RegisterTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegisterTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateDataGridViewTextBoxColumn1, Me.CategoryDataGridViewTextBoxColumn1, Me.AmountDataGridViewTextBoxColumn2, Me.DescriptionDataGridViewTextBoxColumn2, Me.IsDepositDataGridViewCheckBoxColumn})
        Me.RegisterTable.DataSource = Me.RegisterBindingSource
        Me.RegisterTable.Location = New System.Drawing.Point(3, 3)
        Me.RegisterTable.MultiSelect = False
        Me.RegisterTable.Name = "RegisterTable"
        Me.RegisterTable.ReadOnly = True
        Me.RegisterTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RegisterTable.Size = New System.Drawing.Size(700, 375)
        Me.RegisterTable.TabIndex = 0
        '
        'DateDataGridViewTextBoxColumn1
        '
        Me.DateDataGridViewTextBoxColumn1.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn1.Name = "DateDataGridViewTextBoxColumn1"
        Me.DateDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DateDataGridViewTextBoxColumn1.Width = 55
        '
        'CategoryDataGridViewTextBoxColumn1
        '
        Me.CategoryDataGridViewTextBoxColumn1.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn1.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn1.Name = "CategoryDataGridViewTextBoxColumn1"
        Me.CategoryDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CategoryDataGridViewTextBoxColumn1.Width = 74
        '
        'AmountDataGridViewTextBoxColumn2
        '
        Me.AmountDataGridViewTextBoxColumn2.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn2.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn2.Name = "AmountDataGridViewTextBoxColumn2"
        Me.AmountDataGridViewTextBoxColumn2.ReadOnly = True
        Me.AmountDataGridViewTextBoxColumn2.Width = 68
        '
        'DescriptionDataGridViewTextBoxColumn2
        '
        Me.DescriptionDataGridViewTextBoxColumn2.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn2.Name = "DescriptionDataGridViewTextBoxColumn2"
        Me.DescriptionDataGridViewTextBoxColumn2.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn2.Width = 85
        '
        'IsDepositDataGridViewCheckBoxColumn
        '
        Me.IsDepositDataGridViewCheckBoxColumn.DataPropertyName = "IsDeposit"
        Me.IsDepositDataGridViewCheckBoxColumn.HeaderText = "IsDeposit"
        Me.IsDepositDataGridViewCheckBoxColumn.Name = "IsDepositDataGridViewCheckBoxColumn"
        Me.IsDepositDataGridViewCheckBoxColumn.ReadOnly = True
        Me.IsDepositDataGridViewCheckBoxColumn.Width = 57
        '
        'RegisterBindingSource
        '
        Me.RegisterBindingSource.DataMember = "Register"
        Me.RegisterBindingSource.DataSource = Me.BefDataSet
        '
        'ContributionTab
        '
        Me.ContributionTab.Controls.Add(Me.DelContrib)
        Me.ContributionTab.Controls.Add(Me.EditContribDesc)
        Me.ContributionTab.Controls.Add(Me.EditContribAmt)
        Me.ContributionTab.Controls.Add(Me.AddContrib)
        Me.ContributionTab.Controls.Add(Me.ContributionTable)
        Me.ContributionTab.Location = New System.Drawing.Point(4, 22)
        Me.ContributionTab.Name = "ContributionTab"
        Me.ContributionTab.Size = New System.Drawing.Size(797, 429)
        Me.ContributionTab.TabIndex = 2
        Me.ContributionTab.Text = "Contribution"
        Me.ContributionTab.UseVisualStyleBackColor = True
        '
        'DelContrib
        '
        Me.DelContrib.Location = New System.Drawing.Point(293, 385)
        Me.DelContrib.Name = "DelContrib"
        Me.DelContrib.Size = New System.Drawing.Size(106, 32)
        Me.DelContrib.TabIndex = 5
        Me.DelContrib.Text = "Delete Contribution"
        Me.DelContrib.UseVisualStyleBackColor = True
        '
        'EditContribDesc
        '
        Me.EditContribDesc.Location = New System.Drawing.Point(191, 385)
        Me.EditContribDesc.Name = "EditContribDesc"
        Me.EditContribDesc.Size = New System.Drawing.Size(93, 33)
        Me.EditContribDesc.TabIndex = 4
        Me.EditContribDesc.Text = "Edit Description"
        Me.EditContribDesc.UseVisualStyleBackColor = True
        '
        'EditContribAmt
        '
        Me.EditContribAmt.Location = New System.Drawing.Point(105, 385)
        Me.EditContribAmt.Name = "EditContribAmt"
        Me.EditContribAmt.Size = New System.Drawing.Size(80, 33)
        Me.EditContribAmt.TabIndex = 3
        Me.EditContribAmt.Text = "Edit Amount"
        Me.EditContribAmt.UseVisualStyleBackColor = True
        '
        'AddContrib
        '
        Me.AddContrib.AutoEllipsis = True
        Me.AddContrib.Location = New System.Drawing.Point(3, 385)
        Me.AddContrib.Name = "AddContrib"
        Me.AddContrib.Size = New System.Drawing.Size(96, 33)
        Me.AddContrib.TabIndex = 2
        Me.AddContrib.Text = "Add Contribution"
        Me.AddContrib.UseVisualStyleBackColor = True
        '
        'ContributionTable
        '
        Me.ContributionTable.AllowUserToAddRows = False
        Me.ContributionTable.AllowUserToDeleteRows = False
        Me.ContributionTable.AllowUserToResizeColumns = False
        Me.ContributionTable.AllowUserToResizeRows = False
        Me.ContributionTable.AutoGenerateColumns = False
        Me.ContributionTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ContributionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContributionTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.ContributionTable.DataSource = Me.ContributionBindingSource
        Me.ContributionTable.Location = New System.Drawing.Point(3, 4)
        Me.ContributionTable.MultiSelect = False
        Me.ContributionTable.Name = "ContributionTable"
        Me.ContributionTable.ReadOnly = True
        Me.ContributionTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ContributionTable.Size = New System.Drawing.Size(700, 375)
        Me.ContributionTable.TabIndex = 0
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateDataGridViewTextBoxColumn.Width = 55
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        Me.AmountDataGridViewTextBoxColumn.Width = 68
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 85
        '
        'AllocationTab
        '
        Me.AllocationTab.Controls.Add(Me.DelAlloc)
        Me.AllocationTab.Controls.Add(Me.AddAlloc)
        Me.AllocationTab.Controls.Add(Me.EditAllocDesc)
        Me.AllocationTab.Controls.Add(Me.AllocationTable)
        Me.AllocationTab.Controls.Add(Me.EditAllocAmt)
        Me.AllocationTab.Location = New System.Drawing.Point(4, 22)
        Me.AllocationTab.Name = "AllocationTab"
        Me.AllocationTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AllocationTab.Size = New System.Drawing.Size(797, 429)
        Me.AllocationTab.TabIndex = 0
        Me.AllocationTab.Text = "Allocation"
        Me.AllocationTab.UseVisualStyleBackColor = True
        '
        'DelAlloc
        '
        Me.DelAlloc.AutoEllipsis = True
        Me.DelAlloc.Location = New System.Drawing.Point(294, 385)
        Me.DelAlloc.Name = "DelAlloc"
        Me.DelAlloc.Size = New System.Drawing.Size(101, 33)
        Me.DelAlloc.TabIndex = 4
        Me.DelAlloc.Text = "Delete Allocation"
        Me.DelAlloc.UseVisualStyleBackColor = True
        '
        'AllocationTableAdapter
        '
        Me.AllocationTableAdapter.ClearBeforeFill = True
        '
        'ContributionTableAdapter
        '
        Me.ContributionTableAdapter.ClearBeforeFill = True
        '
        'RegisterTableAdapter
        '
        Me.RegisterTableAdapter.ClearBeforeFill = True
        '
        'BEFForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BEFTabs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "BEFForm"
        Me.Text = "Big Expenses Tracker"
        CType(Me.AllocationTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BefDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BEFTabs.ResumeLayout(False)
        Me.DashboardTab.ResumeLayout(False)
        CType(Me.CategoryGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContributionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegisterTab.ResumeLayout(False)
        CType(Me.RegisterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContributionTab.ResumeLayout(False)
        CType(Me.ContributionTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AllocationTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AllocationTable As DataGridView
    Friend WithEvents AddAlloc As Button
    Friend WithEvents EditAllocAmt As Button
    Friend WithEvents EditAllocDesc As Button
    Friend WithEvents BEFTabs As TabControl
    Friend WithEvents AllocationTab As TabPage
    Friend WithEvents DashboardTab As TabPage
    Friend WithEvents RegisterTab As TabPage
    Friend WithEvents ContributionTab As TabPage
    Friend WithEvents DelAlloc As Button
    Friend WithEvents ContributionTable As DataGridView
    Friend WithEvents AddContrib As Button
    Friend WithEvents EditContribAmt As Button
    Friend WithEvents AllocationBindingSource As BindingSource
    Friend WithEvents BefDataSet As befDataSet
    Friend WithEvents AllocationTableAdapter As befDataSetTableAdapters.AllocationTableAdapter
    Friend WithEvents ContributionBindingSource As BindingSource
    Friend WithEvents ContributionTableAdapter As befDataSetTableAdapters.ContributionTableAdapter
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EditContribDesc As Button
    Friend WithEvents DelContrib As Button
    Friend WithEvents RegisterTable As DataGridView
    Friend WithEvents AddRegEntry As Button
    Friend WithEvents RegisterBindingSource As BindingSource
    Friend WithEvents RegisterTableAdapter As befDataSetTableAdapters.RegisterTableAdapter
    Friend WithEvents DateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IsDepositDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EditRegisterAmt As Button
    Friend WithEvents EditRegDescription As Button
    Friend WithEvents DeleteRegEntry As Button
    Friend WithEvents CategoryGraph As DataVisualization.Charting.Chart
End Class
