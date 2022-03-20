'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
'Program: Travel Cost Reimbursement Calculator
'Date: Dec 09/20
'Author: Ty Green
'Operation: This program calculates the total amount of money an employee must
'           be reimbursed by the company, based on the number of KM they travel
'           each day. It does so using data input by the user into the form. It 
'           then provides dynamic feedback to the user with the addition of each
'           new input.
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date           Programmer      Change
'-----------------------------------------------------------------------------
'Dec 09/20      Ty Green        Initial build
Public Class Form1
    'Constants to represent the company's business rules.
    Const regReimburseRate As Decimal = 0.55
    Const flatReimburseRate As Byte = 150
    Const flatRateQualifier As UInt16 = 300
    'Global array that stores specific error messages.
    Dim array_errorMsgs() As String = {"KM cannot be left blank! Please enter a value for KM.", "KM must be a number! Please enter a numeric value for KM."}
    'Form calls resetForm sub procedure upon loading.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetForm()
    End Sub
    '"Initialize" button calls resetForm sub procedure when click.
    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        resetForm()
    End Sub
    'Sub procedure that re-initializes the form's data.
    Private Sub resetForm()
        libxKmTrav.Items.Clear()
        txtbxDailyKm.Clear()
        txtbxDailyKm.Focus()
        lblTotalKmTravOutput.Text = ""
        lblTotalDaysOutput.Text = ""
        lblTotalReimburseOutput.Text = ""
        lblTotalFlatKmOutput.Text = ""
        lblTotalFlatDaysOutput.Text = ""
        lblTotalFlatReimburseOutput.Text = ""
    End Sub
    '"Add Daily KM" button calls specific functions depending on the value returned by the validateInput 
    'Function. 
    Private Sub btnAddDailyKm_Click(sender As Object, e As EventArgs) Handles btnAddDailyKm.Click
        'If validateInput returns "noInput", the program calls the showErrorMsg sub procedure to
        'display a message box corresponding to a blank data entry. 
        If validateInput(txtbxDailyKm.Text) = "noInput" Then
            showErrorMsg(1)
            txtbxDailyKm.Clear()
            txtbxDailyKm.Focus()
            'If validateInput returns "notNumber", the program calls the showErrorMsg sub procedure to 
            'display a message box corresponding to a non-numeric data entry. 
        ElseIf validateInput(txtbxDailyKm.Text) = "notNumber" Then
            showErrorMsg(2)
            txtbxDailyKm.Clear()
            txtbxDailyKm.Focus()
            'If data input passes all validation checks, the data will be added to the listbox and various
            'calculations performed using the input data.
        Else
            libxKmTrav.Items.Add(txtbxDailyKm.Text)
            txtbxDailyKm.Clear()
            txtbxDailyKm.Focus()
            lblTotalKmTravOutput.Text = calcTotalKm(libxKmTrav)
            lblTotalDaysOutput.Text = calcTotalDays(libxKmTrav)
            lblTotalReimburseOutput.Text = "$" & calcTotalReimburse(libxKmTrav).ToString("0.00")
            lblTotalFlatKmOutput.Text = calcTotalFlatKm(libxKmTrav)
            lblTotalFlatDaysOutput.Text = calcTotalFlatDays(libxKmTrav)
            lblTotalFlatReimburseOutput.Text = "$" & calcTotalFlatReimburse(libxKmTrav).ToString("0.00")
        End If
    End Sub
    'Sub procedure that retrieves a specific error message from the array storing the error messages.
    Private Sub showErrorMsg(errorCode As Byte)
        Select Case errorCode
            Case 1
                MsgBox(array_errorMsgs(0))
            Case 2
                MsgBox(array_errorMsgs(1))
        End Select
    End Sub
    'Function that performs validation checks on  input data, returning a specific string value depending on
    'the validation check not passed.
    Private Function validateInput(inputData As String) As String
        If inputData = "" Then
            Return "noInput"
        ElseIf IsNumeric(inputData) = False Then
            Return "notNumber"
        Else
            Return "inputValid"
        End If
    End Function
    'Function that calculates total KM travelled by an employee across all days.
    Private Function calcTotalKm(listbox As ListBox) As Single
        Dim listboxIndex As UInt16
        Dim listboxSum As UInt16

        For listboxIndex = 0 To listbox.Items.Count - 1
            listboxSum += listbox.Items(listboxIndex)
        Next
        Return listboxSum
    End Function
    'Function that sums the amount of KM travelled from the days on which the employee travelled at least
    '300KM.
    Private Function calcTotalFlatKm(listbox As ListBox) As Single
        Dim listboxIndex As UInt16
        Dim totalFlatKm As Single

        For listboxIndex = 0 To listbox.Items.Count - 1
            If listbox.Items(listboxIndex) >= 300 Then
                totalFlatKm += listbox.Items(listboxIndex)
            Else
            End If
        Next

        Return totalFlatKm
    End Function
    'Function that calculates the total number of days spent travelling by the employee.
    Private Function calcTotalDays(listbox As ListBox) As UInt16
        Dim listboxIndex As UInt16
        Dim totalDays As UInt16

        For listboxIndex = 0 To listbox.Items.Count - 1
            totalDays += 1
        Next
        Return totalDays
    End Function
    'Function that calculates the total number of days for which the employee will be reimbursed at the
    'flat reimbursement rate ($150).
    Private Function calcTotalFlatDays(listbox As ListBox) As UInt16
        Dim listboxIndex As UInt16
        Dim flatRateDays As UInt16

        For listboxIndex = 0 To listbox.Items.Count - 1
            If listbox.Items(listboxIndex) >= 300 Then
                flatRateDays += 1
            Else
            End If
        Next
        Return flatRateDays
    End Function
    'Function that calculcates the total amount of money to be reimbursed.
    Private Function calcTotalReimburse(listbox As ListBox) As Decimal
        Dim listboxIndex As UInt16
        Dim totalReimburse As Decimal

        For listboxIndex = 0 To listbox.Items.Count - 1
            If listbox.Items(listboxIndex) >= 300 Then
                totalReimburse += flatReimburseRate
            Else
                totalReimburse += (listbox.Items(listboxIndex) * regReimburseRate)
            End If
        Next
        Return totalReimburse
    End Function
    'Function that calculates the amount of money reimbursed at the flat reimbursement rate ($150).
    Private Function calcTotalFlatReimburse(listbox As ListBox) As Decimal
        Dim listboxIndex As UInt16
        Dim flatRateReimburse As Decimal

        For listboxIndex = 0 To listbox.Items.Count - 1
            If listbox.Items(listboxIndex) >= 300 Then
                flatRateReimburse += flatReimburseRate
            Else
            End If
        Next
        Return flatRateReimburse
    End Function
End Class
