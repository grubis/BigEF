Public Class FormAddNewContrib
    Private Sub FormAddNewContrib_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BefDataSet.Contribution' table. You can move, or remove it, as needed.
        Me.ContributionTableAdapter.Fill(Me.BefDataSet.Contribution)

    End Sub

    Private Sub ButtonAddContribCancel_Click(sender As Object, e As EventArgs) Handles ButtonAddContribCancel.Click
        Close()
    End Sub

    Private Sub ButtonAddNewContrib_Click(sender As Object, e As EventArgs) Handles ButtonAddNewContrib.Click
        Dim IsOK As Boolean
        Dim Amt As Integer
        Dim TrimmedAmt As String
        Dim DateChar As Char()

        IsOK = True
        'Does the date exist already?
        Dim categoryRow As befDataSet.ContributionRow
        categoryRow = BefDataSet.Contribution.FindBy_Date(DateOfContribution.Value)
        If IsNothing(categoryRow) = False Then
            MsgBox("Contribution date already exists!")
            IsOK = False
        End If

        'Remove leading underscores
        TrimmedAmt = MaskedTextContribAmt.Text.TrimStart("_")
        'Is the amount formated correctly
        If Integer.TryParse(TrimmedAmt, Amt) = False Then
            MsgBox("Not a valid amount!")
            IsOK = False
        End If

        'Add to DataBase
        If IsOK Then
            DateChar = CStr(DateOfContribution.Value)
            BefDataSet.Contribution.AddContributionRow(Amt, TextAddDescription.Text, DateChar)
            ContributionTableAdapter.Update(BefDataSet)
            BEFForm.Reload_DBs()
            Close()
        End If

    End Sub

End Class