Public Class FrmItems
    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        FrmItemDetails.Show()
        FrmItemDetails.ItemsBindingSource.Filter = "ID = '" & ItemsQueryDataGridView.CurrentRow.Cells("TbcID").Value & "'"

        Dim id As String = ItemsQueryDataGridView.CurrentRow.Cells("TbcID").Value
        Dim folder As String = "E:\MintaWood\MintaWood\Resources\ItemsImages"
        Dim filename As String = System.IO.Path.Combine(folder, id & ".jpg")
        FrmItemDetails.PictureBox1.Image = Image.FromFile(filename)

    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        FrmItemDetails.Show()
        FrmItemDetails.ItemsBindingSource.AddNew()

    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ItemsQueryTableAdapter.Fill(DBWoodDataSet.ItemsQuery)
    End Sub

    Private Sub FrmItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.ItemsQuery' table. You can move, or remove it, as needed.
        Me.ItemsQueryTableAdapter.Fill(Me.DBWoodDataSet.ItemsQuery)
        'TODO: This line of code loads data into the 'DBWoodDataSet.ItemsQuery' table. You can move, or remove it, as needed.
        Me.ItemsQueryTableAdapter.Fill(Me.DBWoodDataSet.ItemsQuery)
        ItemsQueryTableAdapter.Fill(DBWoodDataSet.ItemsQuery)
    End Sub

    Private Sub ItemsQueryDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsQueryDataGridView.CellContentClick

    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        TxtCapital.Text = 0
        Dim i As Integer
        For i = 0 To ItemsQueryDataGridView.Rows.Count - 1
            TxtCapital.Text = Val(TxtCapital.Text) + ItemsQueryDataGridView.Rows(i).Cells("TbcTotal_Supplier_Price").Value
        Next i

    End Sub
End Class