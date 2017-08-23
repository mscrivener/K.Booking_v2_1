Public Class Resident

    Private mIntID As Integer
    Private mStrFirstName As String
    Private mStrLastName As String
    Private mStrCPR As String
    Private mStrDKAddress As String
    Private mStrDKPostalCode As String
    Private mStrDKCity As String
    Private mStrPhone As String
    Private mStrPhone2 As String
    Private mStrEmail As String
    Private mBooChronicIllness As Boolean
    Private mStrChronicIllnessDescription As String
    Private mStrDKContactName As String
    Private mStrDKContactAddress As String
    Private mStrDKContactPhone As String
    Private mDatArrivalDate As DateTime
    Private mDatDepartureDate As DateTime
    Private mBooNewsletter As Boolean
    Private mIntGender As Integer
    Private mDatPaidUntil As DateTime

    Private mIntStatus As Integer

    Private mDatCreatedDate As DateTime
    Private mDatUpdatedDate As DateTime
    Private mIntUpdatedBy As Integer
    Private mIntCreatedBy As Integer

    Private mObjComment As ResidentComment
    Private mObjType As ResidentType

    Private mObjAccess As Data.Access

    '##extended
    Private m_CreatedByName As String = ""
    Private m_UpdatedByName As String = ""

    Public Sub New()
        Reset()
        mObjAccess = New Data.Access

        mObjType = New ResidentType
        mObjComment = New ResidentComment
    End Sub

    Public Sub New(ByVal iResident_ID As Integer)
        Reset()
        mObjAccess = New Data.Access

        mObjType = New ResidentType
        mObjComment = New ResidentComment

        Fetch(iResident_ID)
    End Sub

#Region " Properties "
    Public Property ID() As Integer
        Get
            Return mIntID
        End Get
        Set(ByVal Value As Integer)
            mIntID = Value
        End Set
    End Property
    Public Property FirstName() As String
        Get
            Return mStrFirstName
        End Get
        Set(ByVal Value As String)
            mStrFirstName = Value
        End Set
    End Property
    Public Property LastName() As String
        Get
            Return mStrLastName
        End Get
        Set(ByVal Value As String)
            mStrLastName = Value
        End Set
    End Property
    Public Property CPR() As String
        Get
            Return mStrCPR
        End Get
        Set(ByVal Value As String)
            mStrCPR = Value
        End Set
    End Property
    Public ReadOnly Property DisplayMember() As String
        Get
            Dim strDisplayMember As String = FirstName & " " & LastName
            If Not CPR = String.Empty Then
                strDisplayMember &= " - " & CPR
            End If
            Return strDisplayMember
        End Get
    End Property
    Public Property DKAddress() As String
        Get
            Return mStrDKAddress
        End Get
        Set(ByVal Value As String)
            mStrDKAddress = Value
        End Set
    End Property
    Public Property DKPostalCode() As String
        Get
            Return mStrDKPostalCode
        End Get
        Set(ByVal Value As String)
            mStrDKPostalCode = Value
        End Set
    End Property
    Public Property DKCity() As String
        Get
            Return mStrDKCity
        End Get
        Set(ByVal Value As String)
            mStrDKCity = Value
        End Set
    End Property
    Public Property Phone() As String
        Get
            Return mStrPhone
        End Get
        Set(ByVal Value As String)
            mStrPhone = Value
        End Set
    End Property
    Public Property Phone2() As String
        Get
            Return mStrPhone2
        End Get
        Set(ByVal Value As String)
            mStrPhone2 = Value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return mStrEmail
        End Get
        Set(ByVal Value As String)
            mStrEmail = Value
        End Set
    End Property
    Public Property ChronicIllness() As Boolean
        Get
            Return mBooChronicIllness
        End Get
        Set(ByVal Value As Boolean)
            mBooChronicIllness = Value
        End Set
    End Property
    Public Property ChronicIllnessDescription() As String
        Get
            Return mStrChronicIllnessDescription
        End Get
        Set(ByVal Value As String)
            mStrChronicIllnessDescription = Value
        End Set
    End Property
    Public Property DKContactName() As String
        Get
            Return mStrDKContactName
        End Get
        Set(ByVal Value As String)
            mStrDKContactName = Value
        End Set
    End Property
    Public Property DKContactAddress() As String
        Get
            Return mStrDKContactAddress
        End Get
        Set(ByVal Value As String)
            mStrDKContactAddress = Value
        End Set
    End Property
    Public Property DKContactPhone() As String
        Get
            Return mStrDKContactPhone
        End Get
        Set(ByVal Value As String)
            mStrDKContactPhone = Value
        End Set
    End Property
    Public Property ArrivalDate() As DateTime
        Get
            Return mDatArrivalDate
        End Get
        Set(ByVal Value As DateTime)
            mDatArrivalDate = Value
        End Set
    End Property
    Public Property DepartureDate() As DateTime
        Get
            Return mDatDepartureDate
        End Get
        Set(ByVal Value As DateTime)
            mDatDepartureDate = Value
        End Set
    End Property
    Public Property NewsLetter() As Boolean
        Get
            Return mBooNewsletter
        End Get
        Set(ByVal Value As Boolean)
            mBooNewsletter = Value
        End Set
    End Property
    Public Property Gender() As Integer '0= male, 1= female
        Get
            Return mIntGender
        End Get
        Set(ByVal Value As Integer)
            mIntGender = Value
        End Set
    End Property
    Public Property PaidUntil() As DateTime
        Get
            Return mDatPaidUntil
        End Get
        Set(ByVal Value As DateTime)
            mDatPaidUntil = Value
        End Set
    End Property
    Public Property Status() As Integer
        Get
            Return mIntStatus
        End Get
        Set(ByVal value As Integer)
            mIntStatus = value
        End Set
    End Property
    Public ReadOnly Property Comments() As ResidentComment
        Get
            Return mObjComment
        End Get
    End Property
    Public ReadOnly Property Type() As ResidentType
        Get
            Return mObjType
        End Get
    End Property
    Public Property CreatedDate() As DateTime
        Get
            Return mDatCreatedDate
        End Get
        Set(ByVal Value As DateTime)
            mDatCreatedDate = Value
        End Set
    End Property
    Public Property UpdatedDate() As DateTime
        Get
            Return mDatUpdatedDate
        End Get
        Set(ByVal Value As DateTime)
            mDatUpdatedDate = Value
        End Set
    End Property
    Public Property CreatedBy() As Integer
        Get
            Return mIntCreatedBy
        End Get
        Set(ByVal Value As Integer)
            mIntCreatedBy = Value
        End Set
    End Property
    Public Property UpdatedBy() As Integer
        Get
            Return mIntUpdatedBy
        End Get
        Set(ByVal Value As Integer)
            mIntUpdatedBy = Value
        End Set
    End Property
    Public Property CreatedByName() As String
        Get
            Return m_CreatedByName
        End Get
        Set(ByVal value As String)
            m_CreatedByName = value
        End Set
    End Property
    Public Property UpdatedByName() As String
        Get
            Return m_UpdatedByName
        End Get
        Set(ByVal value As String)
            m_UpdatedByName = value
        End Set
    End Property
#End Region

#Region " Data Access "

    Public Function List(Optional ByVal strSQL As String = "") As DataSet
        Dim objDataset As New DataSet
        If strSQL = String.Empty Then
            'strSQL = "SELECT * FROM K_Resident"

            strSQL = "SELECT R.*, U1.K_UserFullName AS U1Name, U2.K_UserFullName AS U2Name FROM K_Resident R, K_User U1, K_User U2 WHERE U1.K_UserID = R.K_ResidentCreatedBy AND U2.K_UserID = R.K_ResidentUpdatedBy "

            'strSQL = "SELECT * FROM K_Resident AS R" & _
            '"INNER JOIN K_ResidentComment AS C" & _
            '"ON R.K_ResidentID = C.K_ResidentID " & _
            '"INNER JOIN K_ResidentType AS T " & _
            '"ON R.K_ResidentID = T.K_ResidentID"
        End If
        objDataset = mObjAccess.getDataset(strSQL)
        Return objDataset
    End Function

    Public Function ListMoving(ByVal dat As DateTime) As DataSet
        Dim sSQL As String = "SELECT RES.K_ResidentFirstName, RES.K_ResidentLastName, R2.K_RoomKey AS FromRoom, R1.K_RoomKey AS ToRoom " & _
            "FROM K_Resident RES, K_ResidentInBed RIB1, K_ResidentInBed RIB2, K_Bed B1, K_Bed B2, K_Room R1, K_Room R2 " & _
            "WHERE(RES.K_ResidentID = RIB1.K_ResidentID And B1.K_BedID = RIB1.K_BedID And R1.K_RoomID = B1.K_RoomID And RIB1.K_ResidentInBedFromDate = #" & Format(dat, Data.Misc.DataBaseDateFormat) & "#) " & _
            "AND (RES.K_ResidentID = RIB2.K_ResidentID AND B2.K_BedID = RIB2.K_BedID AND R2.K_RoomID = B2.K_RoomID AND RIB2.K_ResidentInBedToDate = #" & Format(dat.AddDays(-1), Data.Misc.DataBaseDateFormat) & "#)"

        Return mObjAccess.getDataset(sSQL)
    End Function

    Public Function ListLeaving(ByVal dat As DateTime) As DataSet
        Dim sSQL As String = "SELECT RES.K_ResidentFirstName, RES.K_ResidentLastName, R.K_RoomKey " & _
            "FROM K_Resident RES, K_ResidentInBed RIB, K_Bed B, K_Room R " & _
            " WHERE(RES.K_ResidentID = RIB.K_ResidentID And B.K_BedID = RIB.K_BedID And R.K_RoomID = B.K_RoomID And RES.K_ResidentDepartureDate = #" & Format(dat, Data.Misc.DataBaseDateFormat) & "# And RIB.K_ResidentInBedToDate = #" & Format(dat, Data.Misc.DataBaseDateFormat) & "#)"

        Return mObjAccess.getDataset(sSQL)
    End Function

    Public Function Fetch(ByVal intID As Integer) As Boolean
        Dim objDataset As DataSet
        objDataset = mObjAccess.getDataset("SELECT R.*, U1.K_UserFullName AS U1Name, U2.K_UserFullName AS U2Name FROM K_Resident R, K_User U1, K_User U2 WHERE R.K_ResidentID = " & intID & " AND U1.K_UserID = R.K_ResidentCreatedBy AND U2.K_UserID = R.K_ResidentUpdatedBy ")
        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
        Else
            Reset()
        End If
        mObjComment.FetchFromResident(mIntID)
    End Function

    Public Function GetResidentID() As Integer
        Dim strSQL As String
        strSQL = "SELECT TOP 1 R.*, U1.K_UserFullName AS U1Name, U2.K_UserFullName AS U2Name FROM K_Resident R, K_User U1, K_User U2 WHERE U1.K_UserID = R.K_ResidentCreatedBy AND U2.K_UserID = R.K_ResidentUpdatedBy " & _
        "ORDER BY K_ResidentID DESC"
        '"ORDER BY K_ResidentUpdatedDate DESC"
        Dim objDataset As DataSet
        objDataset = mObjAccess.getDataset(strSQL)
        If objDataset.Tables(0).Rows.Count > 0 Then
            FetchFromRow(objDataset.Tables(0).Rows(0))
        End If
        Return mIntID
    End Function

    Public Function CheckHoliday(ByVal datFrom As DateTime, ByVal datTo As DateTime) As DataSet
        Dim strSQL As String
        strSQL = "SELECT * FROM K_Holiday " & _
        "WHERE K_ResidentID = " & mIntID & " " & _
        "AND (K_HolidayFromDate BETWEEN #" & datFrom.ToString(Data.Misc.DataBaseDateFormat) & "# AND #" & datTo.ToString(Data.Misc.DataBaseDateFormat) & "# " & _
        "OR K_HolidayToDate BETWEEN #" & datFrom.ToString(Data.Misc.DataBaseDateFormat) & "# AND #" & datTo.ToString(Data.Misc.DataBaseDateFormat) & "#)"
        Return mObjAccess.getDataset(strSQL)
    End Function

    Public Function ListInArray(Optional ByVal strSQL As String = "") As ArrayList
        Dim objDataset As New DataSet
        Dim objArray As New ArrayList

        objDataset = List(strSQL)

        For Each objRow As DataRow In objDataset.Tables(0).Rows
            Dim objResident As New Resident
            objResident.FetchFromRow(objRow)
            objArray.Add(objResident)
        Next

        Return objArray
    End Function

    Public Function SaveResidentSQL() As Integer
        Dim strSQL As String
        If mIntID = 0 Then
            strSQL = "INSERT INTO K_Resident (" & _
            "K_ResidentFirstName,  " & _
            "K_ResidentLastName, " & _
            "K_ResidentCPR, " & _
            "K_ResidentDKAddress, " & _
            "K_ResidentDKPostalCode, " & _
            "K_ResidentDKCity, " & _
            "K_ResidentPhone, " & _
            "K_ResidentPhone2, " & _
            "K_ResidentEMail, " & _
            "K_ResidentChronicIllness, " & _
            "K_ResidentChronicIllnessDescription, " & _
            "K_ResidentDKContactName, " & _
            "K_ResidentDKContactAddress, " & _
            "K_ResidentDKContactPhone, " & _
            "K_ResidentArrivalDate, " & _
            "K_ResidentDepartureDate, " & _
            "K_ResidentNewsLetter, " & _
            "K_ResidentGender, " & _
            "K_ResidentPaidUntil, " & _
            "K_ResidentStatus, " & _
            "K_ResidentCreatedDate, " & _
            "K_ResidentUpdatedDate, " & _
            "K_ResidentCreatedBy, " & _
            "K_ResidentUpdatedBy ) " & _
            "VALUES ( " & _
            "'" & mStrFirstName & "', " & _
            "'" & mStrLastName & "', " & _
            "'" & mStrCPR & "', " & _
            "'" & mStrDKAddress & "', " & _
            "'" & mStrDKPostalCode & "', " & _
            "'" & mStrDKCity & "', " & _
            "'" & mStrPhone & "', " & _
            "'" & mStrPhone2 & "', " & _
            "'" & mStrEmail & "', " & _
            "" & mBooChronicIllness & ", " & _
            "'" & mStrChronicIllnessDescription & "', " & _
            "'" & mStrDKContactName & "', " & _
            "'" & mStrDKContactAddress & "', " & _
            "'" & mStrDKContactPhone & "', " & _
            "#" & Format(mDatArrivalDate, Data.Misc.DataBaseDateFormat) & "#, " & _
            "#" & Format(mDatDepartureDate, Data.Misc.DataBaseDateFormat) & "#, " & _
            "" & mBooNewsletter & ", " & _
            "" & mIntGender & ", " & _
            "#" & Format(mDatPaidUntil, Data.Misc.DataBaseDateFormat) & "#, " & _
            "" & mIntStatus & ", " & _
            "'" & mDatCreatedDate.ToString(Data.Misc.DataBaseDateFormatLong) & "' , " & _
            "'" & mDatUpdatedDate.ToString(Data.Misc.DataBaseDateFormatLong) & "', " & _
            "" & mIntCreatedBy & ", " & _
            "" & mIntUpdatedBy & ");"
        Else
            strSQL = "UPDATE K_Resident SET " & _
            "K_ResidentFirstName = '" & mStrFirstName & "', " & _
            "K_ResidentLastName = '" & mStrLastName & "', " & _
            "K_ResidentCPR = '" & mStrCPR & "', " & _
            "K_ResidentEmail = '" & mStrEmail & "', " & _
            "K_ResidentPhone = '" & mStrPhone & "', " & _
            "K_ResidentPhone2 = '" & mStrPhone2 & "', " & _
            "K_ResidentDKAddress = '" & mStrDKAddress & "', " & _
            "K_ResidentDKPostalCode = '" & mStrDKPostalCode & "', " & _
            "K_ResidentDKCity = '" & mStrDKCity & "', " & _
            "K_ResidentChronicIllness = " & mBooChronicIllness & ", " & _
            "K_ResidentChronicIllnessDescription = '" & mStrChronicIllnessDescription & "', " & _
            "K_ResidentDKContactName = '" & mStrDKContactName & "', " & _
            "K_ResidentDKContactAddress = '" & mStrDKContactAddress & "', " & _
            "K_ResidentDKContactPhone = '" & mStrDKContactPhone & "', " & _
            "K_ResidentArrivalDate = #" & Format(mDatArrivalDate, Data.Misc.DataBaseDateFormat) & "#, " & _
            "K_ResidentDepartureDate = #" & Format(mDatDepartureDate, Data.Misc.DataBaseDateFormat) & "#, " & _
            "K_ResidentNewsLetter = " & mBooNewsletter & ", " & _
            "K_ResidentGender = " & mIntGender & ", " & _
            "K_ResidentPaidUntil = #" & Format(mDatPaidUntil, Data.Misc.DataBaseDateFormat) & "#, " & _
            "K_ResidentStatus = " & mIntStatus & ", " & _
            "K_ResidentUpdatedDate = '" & mDatUpdatedDate.ToString(Data.Misc.DataBaseDateFormatLong) & "', " & _
            "K_ResidentUpdatedBy = " & mIntUpdatedBy & " " & _
            "WHERE K_ResidentID = " & mIntID & ";"

        End If
        Return mObjAccess.Save(strSQL)
    End Function

    Public Sub FetchFromRow(ByVal objRow As DataRow)
        mIntID = Data.Misc.ConvertToInt(objRow.Item("K_ResidentID"))
        mStrFirstName = Data.Misc.ConvertToString(objRow.Item("K_ResidentFirstName"))
        mStrLastName = Data.Misc.ConvertToString(objRow.Item("K_ResidentLastName"))
        mStrCPR = Data.Misc.ConvertToString(objRow.Item("K_ResidentCPR"))
        mStrDKAddress = Data.Misc.ConvertToString(objRow.Item("K_ResidentDKAddress"))
        mStrDKPostalCode = Data.Misc.ConvertToString(objRow.Item("K_ResidentDKPostalCode"))
        mStrDKCity = Data.Misc.ConvertToString(objRow.Item("K_ResidentDKCity"))
        mStrPhone = Data.Misc.ConvertToString(objRow.Item("K_ResidentPhone"))
        mStrPhone2 = Data.Misc.ConvertToString(objRow.Item("K_ResidentPhone2"))
        mStrEmail = Data.Misc.ConvertToString(objRow.Item("K_ResidentEmail"))
        mBooChronicIllness = Data.Misc.ConvertToBoolean(objRow.Item("K_ResidentChronicIllness"))
        mStrChronicIllnessDescription = Data.Misc.ConvertToString(objRow.Item("K_ResidentChronicIllnessDescription"))
        mStrDKContactName = Data.Misc.ConvertToString(objRow.Item("K_ResidentDKContactName"))
        mStrDKContactAddress = Data.Misc.ConvertToString(objRow.Item("K_ResidentDKContactAddress"))
        mStrDKContactPhone = Data.Misc.ConvertToString(objRow.Item("K_ResidentDKContactPhone"))
        mDatArrivalDate = Data.Misc.ConvertToDateTime(objRow.Item("K_ResidentArrivalDate"))
        mDatDepartureDate = Data.Misc.ConvertToDateTime(objRow.Item("K_ResidentDepartureDate"))
        mBooNewsletter = Data.Misc.ConvertToBoolean(objRow.Item("K_ResidentNewsLetter"))
        mIntGender = Data.Misc.ConvertToInt(objRow.Item("K_ResidentGender"))
        mDatPaidUntil = Data.Misc.ConvertToDateTime(objRow.Item("K_ResidentPaidUntil"))
        mIntStatus = Data.Misc.ConvertToInt(objRow.Item("K_ResidentStatus"))
        mDatCreatedDate = Data.Misc.ConvertToDateTime(objRow.Item("K_ResidentCreatedDate"))
        mDatUpdatedDate = Data.Misc.ConvertToDateTime(objRow.Item("K_ResidentUpdatedDate"))
        mIntCreatedBy = Data.Misc.ConvertToInt(objRow.Item("K_ResidentCreatedBy"))
        mIntUpdatedBy = Data.Misc.ConvertToInt(objRow.Item("K_ResidentUpdatedBy"))
        m_CreatedByName = Data.Misc.ConvertToString(objRow.Item("U1Name"))
        m_UpdatedByName = Data.Misc.ConvertToString(objRow.Item("U2Name"))
        mObjType = New ResidentType(mIntID)
        mObjComment = New ResidentComment(mIntID)
    End Sub

    Public Sub Reset()
        mIntID = 0
        mStrFirstName = ""
        mStrLastName = ""
        mStrCPR = ""
        mStrDKAddress = ""
        mStrDKPostalCode = ""
        mStrDKCity = ""
        mStrPhone = ""
        mStrPhone2 = ""
        mStrEmail = ""
        mBooChronicIllness = False
        mStrChronicIllnessDescription = ""
        mStrDKContactName = ""
        mStrDKContactAddress = ""
        mStrDKContactPhone = ""
        mDatArrivalDate = Data.Misc.DefaultDate
        mDatDepartureDate = Data.Misc.DefaultDate
        mBooNewsletter = False
        mIntGender = Data.GlobalEnums.Gender.Undecided
        mDatPaidUntil = Data.Misc.DefaultDate
        mIntStatus = 1
        mDatCreatedDate = Data.Misc.DefaultDate
        mDatUpdatedDate = Data.Misc.DefaultDate
        mIntCreatedBy = 0
        mIntUpdatedBy = 0
    End Sub
#End Region
End Class
