Public Class BEFForm
    Dim CategoryNameQueue As New Queue(Of String)
    Dim CategoryAmtArray() As Int32

    Dim CategoryTotalArray() As Int32
    Dim ContribTotalArray() As Int32
    Dim ContribDateArray() As Date

    Public Sub Reload_DBs()
        Dim i As Int16
        Dim j As Int16
        Dim LowDate As Date
        Dim LowDateIndex As Int16

        Dim r1, r2 As DataGridViewRow

        Dim d1, d2 As String
        Dim t1, t2 As String
        Dim a1, a2 As Int32

        AllocationTableAdapter.Fill(BefDataSet.Allocation)
        ContributionTableAdapter.Fill(BefDataSet.Contribution)
        RegisterTableAdapter.Fill(BefDataSet.Register)

        'Sort the Tables
        For i = 0 To ContributionTable.RowCount - 2
            LowDate = ContributionTable.Rows.Item(i).DataBoundItem("Date")
            LowDateIndex = i
            For j = i + 1 To ContributionTable.RowCount - 1
                If LowDate > ContributionTable.Rows.Item(j).DataBoundItem("Date") Then
                    LowDate = ContributionTable.Rows.Item(j).DataBoundItem("Date")
                    LowDateIndex = j
                End If
                If LowDateIndex <> i Then
                    r1 = ContributionTable.Rows.Item(i)
                    r2 = ContributionTable.Rows.Item(j)
                    ContributionTable.Rows.Item(i).SetValues(r2.DataBoundItem.Row)
                    ContributionTable.Rows.Item(j).SetValues(r1.DataBoundItem.Row)


                End If
            Next
        Next

        'Build tables for charts
        'Build category list from allocation table
        CategoryNameQueue.Clear()

        If AllocationTable.RowCount > 0 Then
            ReDim CategoryAmtArray(AllocationTable.RowCount - 1)
            ReDim CategoryTotalArray(AllocationTable.RowCount - 1)
            For i = 0 To AllocationTable.RowCount - 1
                CategoryNameQueue.Enqueue(AllocationTable.Rows.Item(i).DataBoundItem("Category").Trim)
                CategoryAmtArray(i) = 0
                CategoryTotalArray(i) = AllocationTable.Rows.Item(i).DataBoundItem("Amount")
            Next
        End If

        'Calculate amount spent from register
        If RegisterTable.RowCount > 0 And AllocationTable.RowCount > 0 Then
            For i = 0 To RegisterTable.RowCount - 1
                For j = 0 To AllocationTable.RowCount - 1
                    If RegisterTable.Rows.Item(i).DataBoundItem("Category").Trim = AllocationTable.Rows.Item(j).DataBoundItem("Category").Trim Then
                        CategoryAmtArray(j) = CategoryAmtArray(j) + RegisterTable.Rows.Item(i).DataBoundItem("Amount")
                        CategoryTotalArray(j) = CategoryTotalArray(j) - RegisterTable.Rows.Item(i).DataBoundItem("Amount")
                        If CategoryTotalArray(j) < 0 Then
                            CategoryTotalArray(j) = 0
                        End If
                        Exit For
                    End If
                Next
            Next
        End If

        'Add contribution dates to array
        If ContributionTable.RowCount > 0 Then
            ReDim ContribDateArray(ContributionTable.RowCount - 1)
            ReDim ContribTotalArray(ContributionTable.RowCount - 1)
            For i = 0 To ContributionTable.RowCount - 1
                ContribDateArray(i) = ContributionTable.Rows.Item(i).DataBoundItem("Date")
                If i = 0 Then
                    ContribTotalArray(i) = ContributionTable.Rows.Item(i).DataBoundItem("Amount")
                Else
                    ContribTotalArray(i) = ContribTotalArray(i - 1) + ContributionTable.Rows.Item(i).DataBoundItem("Amount")
                End If
            Next
        End If

        CategoryGraph.Series(0).Points.DataBindXY(CategoryNameQueue, CategoryAmtArray)
        CategoryGraph.Series(1).Points.DataBindY(CategoryTotalArray)
        ContributionPace.Series(0).Points.DataBindXY(ContribDateArray, ContribTotalArray)

        'CategoryGraph.Series(0).Points()


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

    Private Sub ContributionTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ContributionTable.CellContentClick

    End Sub
End Class
