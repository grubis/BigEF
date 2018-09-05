Public Class FormAddRegEntry
    Private Sub FormAddRegEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BefDataSet.Register' table. You can move, or remove it, as needed.
        Me.RegisterTableAdapter.Fill(Me.BefDataSet.Register)
        'TODO: This line of code loads data into the 'BefDataSet.Allocation' table. You can move, or remove it, as needed.
        Me.AllocationTableAdapter.Fill(Me.BefDataSet.Allocation)
        'TODO: This line of code loads data into the 'BefDataSet.Register' table. You can move, or remove it, as needed.
        Me.RegisterTableAdapter.Fill(Me.BefDataSet.Register)
        'TODO: This line of code loads data into the 'BefDataSet.Allocation' table. You can move, or remove it, as needed.
        Me.AllocationTableAdapter.Fill(Me.BefDataSet.Allocation)
        NewID.Text = System.Guid.NewGuid.ToString()
        RegisterEntryTime.Value = Date.Now.ToShortDateString
    End Sub

    Private Sub DepositButton_CheckedChanged(sender As Object, e As EventArgs) Handles DepositButton.CheckedChanged
        NewCategory.Visible = False
    End Sub

    Private Sub DirectButton_CheckedChanged(sender As Object, e As EventArgs) Handles DirectButton.CheckedChanged
        NewCategory.Visible = True
    End Sub

    Private Sub WithdrawalButton_CheckedChanged(sender As Object, e As EventArgs) Handles WithdrawalButton.CheckedChanged
        NewCategory.Visible = True
    End Sub

    Private Sub ButtonAddEntryCancel_Click(sender As Object, e As EventArgs) Handles ButtonAddEntryCancel.Click
        Close()
    End Sub

    Private Sub ButtonAddNewEntry_Click(sender As Object, e As EventArgs) Handles ButtonAddNewEntry.Click

        Dim IsOK As Boolean
        Dim Amt As Integer
        Dim TrimmedAmt As String
        Dim DateChar As Char()
        Dim DepositTrue As Boolean
        Dim CategoryName As String


        'Check if $ amt is correct
        IsOK = True
        'Remove leading underscores
        TrimmedAmt = MaskedTextAmount.Text.TrimStart("_")
        'Is the amount formated correctly
        If Integer.TryParse(TrimmedAmt, Amt) = False Then
            MsgBox("Not a valid amount!")
            IsOK = False
        End If

        If DepositButton.Checked Or DirectButton.Checked Then
            DepositTrue = True
        Else
            DepositTrue = False
        End If

        If DepositButton.Checked Then
            CategoryName = "Deposit"
        Else
            CategoryName = NewCategory.Text
        End If

        'Add to database
        If IsOK Then
            DateChar = CStr(RegisterEntryTime.Value)
            BefDataSet.Register.AddRegisterRow(NewID.Text, DateChar, CategoryName, TrimmedAmt, TextAddDescription.Text, DepositTrue)
            RegisterTableAdapter.Update(BefDataSet)
            BEFForm.Reload_DBs()
            Close()
        End If

    End Sub
End Class