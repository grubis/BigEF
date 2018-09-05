<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddNewContrib
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
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BefDataSet = New BigEF.befDataSet()
        Me.ContributionTableAdapter = New BigEF.befDataSetTableAdapters.ContributionTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateOfContribution = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaskedTextContribAmt = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextAddDescription = New System.Windows.Forms.TextBox()
        Me.ButtonAddNewContrib = New System.Windows.Forms.Button()
        Me.ButtonAddContribCancel = New System.Windows.Forms.Button()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BefDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource
        '
        Me.BindingSource.DataMember = "Contribution"
        Me.BindingSource.DataSource = Me.BefDataSet
        '
        'BefDataSet
        '
        Me.BefDataSet.DataSetName = "befDataSet"
        Me.BefDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContributionTableAdapter
        '
        Me.ContributionTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date"
        '
        'DateOfContribution
        '
        Me.DateOfContribution.Cursor = System.Windows.Forms.Cursors.Default
        Me.DateOfContribution.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateOfContribution.Location = New System.Drawing.Point(12, 25)
        Me.DateOfContribution.Name = "DateOfContribution"
        Me.DateOfContribution.Size = New System.Drawing.Size(102, 20)
        Me.DateOfContribution.TabIndex = 2
        Me.DateOfContribution.Value = New Date(2018, 8, 22, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Expected Contribution Amount"
        '
        'MaskedTextContribAmt
        '
        Me.MaskedTextContribAmt.Location = New System.Drawing.Point(12, 79)
        Me.MaskedTextContribAmt.Mask = "$99,000"
        Me.MaskedTextContribAmt.Name = "MaskedTextContribAmt"
        Me.MaskedTextContribAmt.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextContribAmt.TabIndex = 4
        Me.MaskedTextContribAmt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Description"
        '
        'TextAddDescription
        '
        Me.TextAddDescription.Location = New System.Drawing.Point(12, 132)
        Me.TextAddDescription.MaxLength = 200
        Me.TextAddDescription.Multiline = True
        Me.TextAddDescription.Name = "TextAddDescription"
        Me.TextAddDescription.Size = New System.Drawing.Size(163, 95)
        Me.TextAddDescription.TabIndex = 6
        '
        'ButtonAddNewContrib
        '
        Me.ButtonAddNewContrib.Location = New System.Drawing.Point(12, 237)
        Me.ButtonAddNewContrib.Name = "ButtonAddNewContrib"
        Me.ButtonAddNewContrib.Size = New System.Drawing.Size(100, 29)
        Me.ButtonAddNewContrib.TabIndex = 7
        Me.ButtonAddNewContrib.Text = "Add Contribution"
        Me.ButtonAddNewContrib.UseVisualStyleBackColor = True
        '
        'ButtonAddContribCancel
        '
        Me.ButtonAddContribCancel.Location = New System.Drawing.Point(123, 238)
        Me.ButtonAddContribCancel.Name = "ButtonAddContribCancel"
        Me.ButtonAddContribCancel.Size = New System.Drawing.Size(52, 28)
        Me.ButtonAddContribCancel.TabIndex = 8
        Me.ButtonAddContribCancel.Text = "Cancel"
        Me.ButtonAddContribCancel.UseVisualStyleBackColor = True
        '
        'FormAddNewContrib
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(187, 274)
        Me.Controls.Add(Me.ButtonAddContribCancel)
        Me.Controls.Add(Me.ButtonAddNewContrib)
        Me.Controls.Add(Me.TextAddDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MaskedTextContribAmt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateOfContribution)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAddNewContrib"
        Me.Text = "Add New Contribution"
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BefDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingSource As BindingSource
    Friend WithEvents BefDataSet As befDataSet
    Friend WithEvents ContributionTableAdapter As befDataSetTableAdapters.ContributionTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents DateOfContribution As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents MaskedTextContribAmt As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextAddDescription As TextBox
    Friend WithEvents ButtonAddNewContrib As Button
    Friend WithEvents ButtonAddContribCancel As Button
End Class
