Public Class DebugForm

    Private Sub btnPrices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrices.Click
        Dim path As String = "F:\London\K_Booking\K_Booking\K.Booking.Output\dbg_price.txt"
        Dim objPriceSet As New Elements.PriceSet
        Dim objPrice As New Elements.Price
        Dim objDataset As DataSet

        Dim datTest As New DateTime(2007, 10, 1)
        Dim str As String = ""

        For i As Integer = 0 To 100
            Dim d As DateTime = datTest.AddDays(i * 7)
            objPriceSet.FetchValidPriceSet(d)
            objDataset = objPrice.GetPrices(objPriceSet.ID)

            str &= "DATE: " & d & ", "
            str &= "ID " & objPriceSet.ID & ", "
            str &= "Valid " & objPriceSet.ValidFrom & ", "
            str &= Data.Misc.ConvertToDouble(objDataset.Tables(0).Rows(Data.GlobalEnums.PriceDesctiption.LongTermLow - 1).Item("K_PriceAmount")) & ", "
            str &= Data.Misc.ConvertToDouble(objDataset.Tables(0).Rows(Data.GlobalEnums.PriceDesctiption.LongTermHigh - 1).Item("K_PriceAmount")) & ", "
            str &= Data.Misc.ConvertToDouble(objDataset.Tables(0).Rows(Data.GlobalEnums.PriceDesctiption.ShortTerm - 1).Item("K_PriceAmount")) & ", "
            str &= Data.Misc.ConvertToDouble(objDataset.Tables(0).Rows(Data.GlobalEnums.PriceDesctiption.GuestRoomDeposit - 1).Item("K_PriceAmount")) & ", "
            str &= Data.Misc.ConvertToDouble(objDataset.Tables(0).Rows(Data.GlobalEnums.PriceDesctiption.FoodTicket - 1).Item("K_PriceAmount")) & ", "
            str &= Data.Misc.ConvertToDouble(objDataset.Tables(0).Rows(Data.GlobalEnums.PriceDesctiption.LatePaymentFee - 1).Item("K_PriceAmount")) & ", "
            str &= Data.Misc.ConvertToDouble(objDataset.Tables(0).Rows(Data.GlobalEnums.PriceDesctiption.CardPaymentFee - 1).Item("K_PriceAmount")) & ", "

            str &= vbNewLine
        Next

        IO.File.WriteAllText(path, str)

        lblPrices.Text = "Done"
    End Sub

    Private Sub btnResidentTypeList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResidentTypeList.Click
        'Dim sSQl As String = "SELECT * FROM K_Resident R WHERE R.K_ResidentArrivalDate <= #08/10/2008# AND R.K_ResidentDepartureDate > #08/10/2008# AND NOT (SELECT TOP 1 K_ResidentType FROM K_ResidentType WHERE K_ResidentID = R.K_ResidentID AND K_ResidentTypeFromDate <= #08/10/2008# ORDER BY K_ResidentTypeFromDate DESC) = 5"
        Dim sSQl As String = "SELECT TOP 1 K_ResidentType FROM K_ResidentType WHERE K_ResidentID = 43 AND K_ResidentTypeFromDate <= #08/10/2008# ORDER BY K_ResidentTypeFromDate DESC"
        'Dim sSQl As String = "SELECT TOP 1 K_ResidentType, K_ResidentID FROM K_ResidentType WHERE K_ResidentTypeFromDate <= #08/10/2008# ORDER BY K_ResidentTypeFromDate DESC"
        Dim a As New Data.Access
        Dim ds As DataSet = a.getDataset(sSQl)
    End Sub

    Private Sub btnDeleteStats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteStats.Click
        Dim a As New Data.Access
        a.Save("DELETE FROM K_Stats")
    End Sub
End Class