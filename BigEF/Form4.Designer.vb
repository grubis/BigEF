<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddRegEntry
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RegisterEntryTime = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NewCategory = New System.Windows.Forms.ComboBox()
        Me.DepositButton = New System.Windows.Forms.RadioButton()
        Me.DirectButton = New System.Windows.Forms.RadioButton()
        Me.WithdrawalButton = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaskedTextAmount = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextAddDescription = New System.Windows.Forms.TextBox()
        Me.ButtonAddNewEntry = New System.Windows.Forms.Button()
        Me.ButtonAddEntryCancel = New System.Windows.Forms.Button()
        Me.AllocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BefDataSet = New BigEF.befDataSet()
        Me.AllocationTableAdapter = New BigEF.befDataSetTableAdapters.AllocationTableAdapter()
        Me.RegisterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegisterTableAdapter = New BigEF.befDataSetTableAdapters.RegisterTableAdapter()
        CType(Me.AllocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BefDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unique ID"
        '
        'NewID
        '
        Me.NewID.AutoSize = True
        Me.NewID.Location = New System.Drawing.Point(21, 27)
        Me.NewID.Name = "NewID"
        Me.NewID.Size = New System.Drawing.Size(39, 13)
        Me.NewID.TabIndex = 1
        Me.NewID.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date"
        '
        'RegisterEntryTime
        '
        Me.RegisterEntryTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RegisterEntryTime.Location = New System.Drawing.Point(24, 70)
        Me.RegisterEntryTime.Name = "RegisterEntryTime"
        Me.RegisterEntryTime.Size = New System.Drawing.Size(93, 20)
        Me.RegisterEntryTime.TabIndex = 3
        Me.RegisterEntryTime.Value = New Date(2018, 8, 1, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Category"
        '
        'NewCategory
        '
        Me.NewCategory.DataSource = Me.AllocationBindingSource
        Me.NewCategory.DisplayMember = "Category"
        Me.NewCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NewCategory.FormattingEnabled = True
        Me.NewCategory.Location = New System.Drawing.Point(24, 124)
        Me.NewCategory.Name = "NewCategory"
        Me.NewCategory.Size = New System.Drawing.Size(129, 21)
        Me.NewCategory.TabIndex = 5
        '
        'DepositButton
        '
        Me.DepositButton.AutoSize = True
        Me.DepositButton.Location = New System.Drawing.Point(24, 151)
        Me.DepositButton.Name = "DepositButton"
        Me.DepositButton.Size = New System.Drawing.Size(96, 17)
        Me.DepositButton.TabIndex = 6
        Me.DepositButton.Text = "Deposit to BEF"
        Me.DepositButton.UseVisualStyleBackColor = True
        '
        'DirectButton
        '
        Me.DirectButton.AutoSize = True
        Me.DirectButton.Checked = True
        Me.DirectButton.Location = New System.Drawing.Point(24, 171)
        Me.DirectButton.Name = "DirectButton"
        Me.DirectButton.Size = New System.Drawing.Size(87, 17)
        Me.DirectButton.TabIndex = 7
        Me.DirectButton.TabStop = True
        Me.DirectButton.Text = "Direct Spend"
        Me.DirectButton.UseVisualStyleBackColor = True
        '
        'WithdrawalButton
        '
        Me.WithdrawalButton.AutoSize = True
        Me.WithdrawalButton.Location = New System.Drawing.Point(24, 192)
        Me.WithdrawalButton.Name = "WithdrawalButton"
        Me.WithdrawalButton.Size = New System.Drawing.Size(124, 17)
        Me.WithdrawalButton.TabIndex = 8
        Me.WithdrawalButton.Text = "Withdrawal from BEF"
        Me.WithdrawalButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Amount"
        '
        'MaskedTextAmount
        '
        Me.MaskedTextAmount.Location = New System.Drawing.Point(24, 242)
        Me.MaskedTextAmount.Mask = "$99,900"
        Me.MaskedTextAmount.Name = "MaskedTextAmount"
        Me.MaskedTextAmount.Size = New System.Drawing.Size(117, 20)
        Me.MaskedTextAmount.TabIndex = 10
        Me.MaskedTextAmount.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Description"
        '
        'TextAddDescription
        '
        Me.TextAddDescription.Location = New System.Drawing.Point(24, 300)
        Me.TextAddDescription.MaxLength = 200
        Me.TextAddDescription.Multiline = True
        Me.TextAddDescription.Name = "TextAddDescription"
        Me.TextAddDescription.Size = New System.Drawing.Size(163, 95)
        Me.TextAddDescription.TabIndex = 12
        '
        'ButtonAddNewEntry
        '
        Me.ButtonAddNewEntry.Location = New System.Drawing.Point(19, 415)
        Me.ButtonAddNewEntry.Name = "ButtonAddNewEntry"
        Me.ButtonAddNewEntry.Size = New System.Drawing.Size(78, 29)
        Me.ButtonAddNewEntry.TabIndex = 13
        Me.ButtonAddNewEntry.Text = "Add Entry"
        Me.ButtonAddNewEntry.UseVisualStyleBackColor = True
        '
        'ButtonAddEntryCancel
        '
        Me.ButtonAddEntryCancel.Location = New System.Drawing.Point(113, 416)
        Me.ButtonAddEntryCancel.Name = "ButtonAddEntryCancel"
        Me.ButtonAddEntryCancel.Size = New System.Drawing.Size(74, 28)
        Me.ButtonAddEntryCancel.TabIndex = 14
        Me.ButtonAddEntryCancel.Text = "Cancel"
        Me.ButtonAddEntryCancel.UseVisualStyleBackColor = True
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
        'AllocationTableAdapter
        '
        Me.AllocationTableAdapter.ClearBeforeFill = True
        '
        'RegisterBindingSource
        '
        Me.RegisterBindingSource.DataMember = "Register"
        Me.RegisterBindingSource.DataSource = Me.BefDataSet
        '
        'RegisterTableAdapter
        '
        Me.RegisterTableAdapter.ClearBeforeFill = True
        '
        'FormAddRegEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 456)
        Me.Controls.Add(Me.ButtonAddEntryCancel)
        Me.Controls.Add(Me.ButtonAddNewEntry)
        Me.Controls.Add(Me.TextAddDescription)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MaskedTextAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WithdrawalButton)
        Me.Controls.Add(Me.DirectButton)
        Me.Controls.Add(Me.DepositButton)
        Me.Controls.Add(Me.NewCategory)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RegisterEntryTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NewID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAddRegEntry"
        Me.Text = "Add Register Entry"
        CType(Me.AllocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BefDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NewID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RegisterEntryTime As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents NewCategory As ComboBox
    Friend WithEvents DepositButton As RadioButton
    Friend WithEvents DirectButton As RadioButton
    Friend WithEvents WithdrawalButton As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents MaskedTextAmount As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextAddDescription As TextBox
    Friend WithEvents ButtonAddNewEntry As Button
    Friend WithEvents ButtonAddEntryCancel As Button
    Friend WithEvents AllocationBindingSource As BindingSource
    Friend WithEvents BefDataSet As befDataSet
    Friend WithEvents AllocationTableAdapter As befDataSetTableAdapters.AllocationTableAdapter
    Friend WithEvents RegisterBindingSource As BindingSource
    Friend WithEvents RegisterTableAdapter As befDataSetTableAdapters.RegisterTableAdapter
End Class
