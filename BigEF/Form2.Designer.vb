<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddNewAlloc
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
        Me.TextCategory = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextAddDescription = New System.Windows.Forms.TextBox()
        Me.ButtonAddNewAllocation = New System.Windows.Forms.Button()
        Me.ButtonAddAllocationCancel = New System.Windows.Forms.Button()
        Me.MaskedTextAmoutAllocated = New System.Windows.Forms.MaskedTextBox()
        Me.BefDataSet = New BigEF.befDataSet()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllocationTableAdapter = New BigEF.befDataSetTableAdapters.AllocationTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BefDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextCategory
        '
        Me.TextCategory.Location = New System.Drawing.Point(15, 25)
        Me.TextCategory.MaxLength = 20
        Me.TextCategory.Name = "TextCategory"
        Me.TextCategory.Size = New System.Drawing.Size(151, 20)
        Me.TextCategory.TabIndex = 1
        Me.TextCategory.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Amount Allocated"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Description"
        '
        'TextAddDescription
        '
        Me.TextAddDescription.Location = New System.Drawing.Point(16, 121)
        Me.TextAddDescription.MaxLength = 200
        Me.TextAddDescription.Multiline = True
        Me.TextAddDescription.Name = "TextAddDescription"
        Me.TextAddDescription.Size = New System.Drawing.Size(151, 95)
        Me.TextAddDescription.TabIndex = 5
        '
        'ButtonAddNewAllocation
        '
        Me.ButtonAddNewAllocation.Location = New System.Drawing.Point(15, 233)
        Me.ButtonAddNewAllocation.Name = "ButtonAddNewAllocation"
        Me.ButtonAddNewAllocation.Size = New System.Drawing.Size(84, 29)
        Me.ButtonAddNewAllocation.TabIndex = 6
        Me.ButtonAddNewAllocation.Text = "Add Allocation"
        Me.ButtonAddNewAllocation.UseVisualStyleBackColor = True
        '
        'ButtonAddAllocationCancel
        '
        Me.ButtonAddAllocationCancel.Location = New System.Drawing.Point(113, 233)
        Me.ButtonAddAllocationCancel.Name = "ButtonAddAllocationCancel"
        Me.ButtonAddAllocationCancel.Size = New System.Drawing.Size(52, 28)
        Me.ButtonAddAllocationCancel.TabIndex = 7
        Me.ButtonAddAllocationCancel.Text = "Cancel"
        Me.ButtonAddAllocationCancel.UseVisualStyleBackColor = True
        '
        'MaskedTextAmoutAllocated
        '
        Me.MaskedTextAmoutAllocated.Location = New System.Drawing.Point(17, 73)
        Me.MaskedTextAmoutAllocated.Mask = "$99,000"
        Me.MaskedTextAmoutAllocated.Name = "MaskedTextAmoutAllocated"
        Me.MaskedTextAmoutAllocated.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextAmoutAllocated.TabIndex = 3
        Me.MaskedTextAmoutAllocated.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'BefDataSet
        '
        Me.BefDataSet.DataSetName = "befDataSet"
        Me.BefDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource
        '
        Me.BindingSource.DataMember = "Allocation"
        Me.BindingSource.DataSource = Me.BefDataSet
        '
        'AllocationTableAdapter
        '
        Me.AllocationTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category Name"
        '
        'FormAddNewAlloc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(187, 274)
        Me.Controls.Add(Me.MaskedTextAmoutAllocated)
        Me.Controls.Add(Me.ButtonAddAllocationCancel)
        Me.Controls.Add(Me.ButtonAddNewAllocation)
        Me.Controls.Add(Me.TextAddDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextCategory)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAddNewAlloc"
        Me.Text = "Add New Allocation"
        CType(Me.BefDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextCategory As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextAddDescription As TextBox
    Friend WithEvents ButtonAddNewAllocation As Button
    Friend WithEvents ButtonAddAllocationCancel As Button
    Friend WithEvents MaskedTextAmoutAllocated As MaskedTextBox
    Friend WithEvents BefDataSet As befDataSet
    Friend WithEvents BindingSource As BindingSource
    Friend WithEvents AllocationTableAdapter As befDataSetTableAdapters.AllocationTableAdapter
    Friend WithEvents Label1 As Label
End Class
