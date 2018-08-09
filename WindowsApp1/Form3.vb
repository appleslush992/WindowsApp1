Public Class Altaf
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'InventarioDataSet.INVENTARIO' Puede moverla o quitarla según sea necesario.
        'Me.INVENTARIOTableAdapter2.Fill(Me.InventarioDataSet.INVENTARIO)
        'TODO: esta línea de código carga datos en la tabla 'InventarioDataSet01.INVENTARIO' Puede moverla o quitarla según sea necesario.
        ' Me.INVENTARIOTableAdapter.Fill(Me.InventarioDataSet01.INVENTARIO)
        'TODO: esta línea de código carga datos en la tabla 'InventarioDataSet4.INVENTARIO' Puede moverla o quitarla según sea necesario.
        ' Me.INVENTARIOTableAdapter1.Fill(Me.InventarioDataSet4.INVENTARIO)
        'TODO: esta línea de código carga datos en la tabla 'InventarioDataSet1.INVENTARIO' Puede moverla o quitarla según sea necesario.
        'Me.INVENTARIOTableAdapter.Fill(Me.InventarioDataSet1.INVENTARIO)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Gradi.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        INVENTARIOBindingSource.EndEdit()
        'INVENTARIOTableAdapter.Update(InventarioDataSet)



    End Sub

    Private Sub InventarioDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        INVENTARIOBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Gradi.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        INVENTARIOBindingSource.MovePrevious()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        INVENTARIOBindingSource.AddNew()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        INVENTARIOBindingSource.MoveNext()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        INVENTARIOBindingSource.EndEdit()
        ' INVENTARIOTableAdapter2.Update(InventarioDataSet.Tables)
    End Sub
End Class