Public Class BEFForm
    Dim CategoryNameQueue As New Queue(Of String)
    Dim CategoryAmtArray() As Int16

    Public Sub Reload_DBs()
        Dim i As Int16
        Dim j As Int16

        AllocationTableAdapter.Fill(BefDataSet.Allocation)
        ContributionTableAdapter.Fill(BefDataSet.Contribution)
        RegisterTableAdapter.Fill(BefDataSet.Register)
        'Build tables for charts
        'Build category list from allocation table
        CategoryNameQueue.Clear()

        If AllocationTable.RowCount > 0 Then
            ReDim CategoryAmtArray(AllocationTable.RowCount - 1)
            For i = 0 To AllocationTable.RowCount - 1
                CategoryNameQueue.Enqueue(AllocationTable.Rows.Item(i).DataBoundItem("Category").Trim)
                CategoryAmtArray(i) = 0
            Next
        End If

        'Calculate amount spent from register
        If RegisterTable.RowCount > 0 And AllocationTable.RowCount > 0 Then
            For i = 0 To RegisterTable.RowCount - 1
                For j = 0 To AllocationTable.RowCount - 1
                    If RegisterTable.Rows.Item(i).DataBoundItem("Category").Trim = AllocationTable.Rows.Item(j).DataBoundItem("Category").Trim Then
                        CategoryAmtArray(j) = CategoryAmtArray(j) + RegisterTable.Rows.Item(i).DataBoundItem("Amount")
                        Exit For
                    End If
                Next
            Next
        End If

        CategoryGraph.Series(0).Points.DataBindXY(CategoryNameQueue, CategoryAmtArray)


    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload_DBs()
    End Sub

    Private Sub AddAlloc_Click(sender As Object, e As EventArgs) Handles AddAlloc.Click
        FormAddNewAlloc.ShowDialog()

    End Sub

    Private Sub EditAlloc_Click(sender As Object, e As EventArgs) Handles EditAllocAmt.Click
        Dim EditRow As DataGridViewRow
        Dim newAmtString As String

        EditRow = AllocationTable.SelectedRows.Item(0)
        newAmtString = InputBox("Update the Allocated Amount", "Edit Allocation", "$" + Str(CInt(EditRow.DataBoundItem.Row.Amount)))

        If newAmtString IsNot "" Then
            Try
                newAmtString = Replace(newAmtString, "$ ", "0")
                If MsgBox("Change Amount to $" + Str(CInt(newAmtString)) + "?", 4, "Change Amount") = MsgBoxResult.Yes Then
                    EditRow.DataBoundItem.Row.Amount = CInt(newAmtString)
                    AllocationTable.SelectedRows.Item(0).SetValues(EditRow.DataBoundItem.Row)
                    AllocationTableAdapter.Update(BefDataSet)
                    Reload_DBs()
                End If
            Catch
                MsgBox("Entered value not valid!")
            End Try
        End If

    End Sub

    Private Sub EditAllocDesc_Click(sender As Object, e As EventArgs) Handles EditAllocDesc.Click
        Dim EditRow As DataGridViewRow
        Dim newDesc As String

        EditRow = AllocationTable.SelectedRows.Item(0)
        newDesc = InputBox("Update the Description", "Edit Allocation", EditRow.DataBoundItem.Row.Description)

        If newDesc IsNot "" Then
            If MsgBox("Change Description to: " + newDesc + "?", 4, "Change Amount") = MsgBoxResult.Yes Then
                EditRow.DataBoundItem.Row.Description = newDesc
                AllocationTable.SelectedRows.Item(0).SetValues(EditRow.DataBoundItem.Row)
                AllocationTableAdapter.Update(BefDataSet)
                Reload_DBs()
            End If
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DelAlloc.Click
        Dim EditRow As DataGridViewRow
        EditRow = AllocationTable.SelectedRows.Item(0)
        'TODO make sure category isn't used in register before allowing delete
        If MsgBox("Are you sure you want to delete the category " + EditRow.DataBoundItem.Row.Category + "?", 4, "Delete Category") = MsgBoxResult.Yes Then
            AllocationTable.Rows.Remove(AllocationTable.SelectedRows.Item(0))
            AllocationTableAdapter.Update(BefDataSet)
            Reload_DBs()
        End If

    End Sub

    Private Sub AddContrib_Click(sender As Object, e As EventArgs) Handles AddContrib.Click
        FormAddNewContrib.ShowDialog()
    End Sub

    Private Sub EditContribAmt_Click(sender As Object, e As EventArgs) Handles EditContribAmt.Click
        Dim EditRow As DataGridViewRow
        Dim newAmtString As String

        EditRow = ContributionTable.SelectedRows.Item(0)
        newAmtString = InputBox("Update the Contribution Amount", "Edit Contribution", "$" + Str(CInt(EditRow.DataBoundItem.Row.Amount)))

        If newAmtString IsNot "" Then
            Try
                newAmtString = Replace(newAmtString, "$ ", "0")
                If MsgBox("Change Amount to $" + Str(CInt(newAmtString)) + "?", 4, "Change Amount") = MsgBoxResult.Yes Then
                    EditRow.DataBoundItem.Row.Amount = CInt(newAmtString)
                    ContributionTable.SelectedRows.Item(0).SetValues(EditRow.DataBoundItem.Row)
                    ContributionTableAdapter.Update(BefDataSet)
                    Reload_DBs()
                End If
            Catch
                MsgBox("Entered value not valid!")
            End Try
        End If
    End Sub

    Private Sub EditContribDesc_Click(sender As Object, e As EventArgs) Handles EditContribDesc.Click
        Dim EditRow As DataGridViewRow
        Dim newDesc As String

        EditRow = ContributionTable.SelectedRows.Item(0)
        newDesc = InputBox("Update the Description", "Edit Contribution", EditRow.DataBoundItem.Row.Description)

        If newDesc IsNot "" Then
            If MsgBox("Change Description to: " + newDesc + "?", 4, "Change Amount") = MsgBoxResult.Yes Then
                EditRow.DataBoundItem.Row.Description = newDesc
                ContributionTable.SelectedRows.Item(0).SetValues(EditRow.DataBoundItem.Row)
                ContributionTableAdapter.Update(BefDataSet)
                Reload_DBs()
            End If
        End If
    End Sub

    Private Sub DelContrib_Click(sender As Object, e As EventArgs) Handles DelContrib.Click
        Dim EditRow As DataGridViewRow
        EditRow = ContributionTable.SelectedRows.Item(0)

        If MsgBox("Are you sure you want to delete the contribution on date " + EditRow.DataBoundItem.Row._Date + "?", 4, "Delete Contribution") = MsgBoxResult.Yes Then
            ContributionTable.Rows.Remove(ContributionTable.SelectedRows.Item(0))
            ContributionTableAdapter.Update(BefDataSet)
            Reload_DBs()
        End If
    End Sub

    Private Sub AddRegEntry_Click(sender As Object, e As EventArgs) Handles AddRegEntry.Click
        FormAddRegEntry.ShowDialog()
    End Sub

    Private Sub EditRegisterAmt_Click(sender As Object, e As EventArgs) Handles EditRegisterAmt.Click
        Dim EditRow As DataGridViewRow
        Dim newAmtString As String

        EditRow = RegisterTable.SelectedRows.Item(0)
        newAmtString = InputBox("Update the Register Amount", "Edit Registry Entry", "$" + Str(CInt(EditRow.DataBoundItem.Row.Amount)))

        If newAmtString IsNot "" Then
            Try
                newAmtString = Replace(newAmtString, "$ ", "0")
                If MsgBox("Change Amount to $" + Str(CInt(newAmtString)) + "?", 4, "Change Amount") = MsgBoxResult.Yes Then
                    EditRow.DataBoundItem.Row.Amount = CInt(newAmtString)
                    RegisterTable.SelectedRows.Item(0).SetValues(EditRow.DataBoundItem.Row)
                    RegisterTableAdapter.Update(BefDataSet)
                    Reload_DBs()
                End If
            Catch
                MsgBox("Entered value not valid!")
            End Try
        End If
    End Sub

    Private Sub EditRegDescription_Click(sender As Object, e As EventArgs) Handles EditRegDescription.Click
        Dim EditRow As DataGridViewRow
        Dim newDesc As String

        EditRow = RegisterTable.SelectedRows.Item(0)
        newDesc = InputBox("Update the Description", "Edit Contribution", EditRow.DataBoundItem.Row.Description)

        If newDesc IsNot "" Then
            If MsgBox("Change Description to: " + newDesc + "?", 4, "Change Register Amount") = MsgBoxResult.Yes Then
                EditRow.DataBoundItem.Row.Description = newDesc
                RegisterTable.SelectedRows.Item(0).SetValues(EditRow.DataBoundItem.Row)
                RegisterTableAdapter.Update(BefDataSet)
                Reload_DBs()
            End If
        End If
    End Sub

    Private Sub DeleteRegEntry_Click(sender As Object, e As EventArgs) Handles DeleteRegEntry.Click
        Dim EditRow As DataGridViewRow
        EditRow = RegisterTable.SelectedRows.Item(0)

        If MsgBox("Are you sure you want to delete the registry entry on date " + EditRow.DataBoundItem.Row._Date + "?", 4, "Delete Register Entry") = MsgBoxResult.Yes Then
            RegisterTable.Rows.Remove(RegisterTable.SelectedRows.Item(0))
            RegisterTableAdapter.Update(BefDataSet)
            Reload_DBs()
        End If
    End Sub

End Class
