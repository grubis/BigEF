Public Class FormAddNewAlloc

    Private Sub FormAddNewAlloc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BefDataSet.Allocation' table. You can move, or remove it, as needed.
        Me.AllocationTableAdapter.Fill(Me.BefDataSet.Allocation)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAddNewAllocation.Click
        Dim IsOK As Boolean
        Dim Amt As Integer
        Dim TrimmedAmt As String

        IsOK = True
        'Does the category exist already?
        Dim categoryRow As befDataSet.AllocationRow
        categoryRow = BefDataSet.Allocation.FindByCategory(TextCategory.Text)
        If IsNothing(categoryRow) = False Then
            MsgBox("Category already exists!")
            IsOK = False
        End If

        'Remove leading underscores
        TrimmedAmt = MaskedTextAmoutAllocated.Text.TrimStart("_")
        'Is the amount formated correctly
        If Integer.TryParse(TrimmedAmt, Amt) = False Then
            MsgBox("Not a valid amount!")
            IsOK = False
        End If

        'Add to DataBase
        If IsOK Then
            BefDataSet.Allocation.AddAllocationRow(TextCategory.Text, Amt, TextAddDescription.Text)
            AllocationTableAdapter.Update(BefDataSet)
            BEFForm.Reload_DBs()
            Close()
        End If


    End Sub

    Private Sub ButtonAddAllocationCancel_Click(sender As Object, e As EventArgs) Handles ButtonAddAllocationCancel.Click
        Close()
    End Sub

End Class