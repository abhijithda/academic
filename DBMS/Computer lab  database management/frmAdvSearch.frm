VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form frmAdvSearch 
   Caption         =   "Advanced Search"
   ClientHeight    =   4020
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   6105
   LinkTopic       =   "Form1"
   ScaleHeight     =   4020
   ScaleWidth      =   6105
   StartUpPosition =   3  'Windows Default
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   1575
      Left            =   1560
      TabIndex        =   0
      Top             =   1200
      Width           =   2895
      _ExtentX        =   5106
      _ExtentY        =   2778
      _Version        =   393216
      Rows            =   4
      _NumberOfBands  =   1
      _Band(0).Cols   =   2
   End
End
Attribute VB_Name = "frmAdvSearch"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim item(3) As String
Private Sub Header()
    item(0) = "User Id"
    item(1) = "User Name"
'    item(2) = "Branch"
    For i = 1 To 2 Step 1
        MSHFlexGrid1.Row = 0
'        MSHFlexGrid1.col = i
'        MSHFlexGrid1.Text = item(i - 1)
    Next
End Sub

Public Sub SetColWidth()
    Dim counter
    MSHFlexGrid1.ColWidth(0) = 700
    For counter = 1 To 2 Step 1
        MSHFlexGrid1.ColWidth(counter) = 1700
    Next
End Sub

Public Sub SetRowHeight()
    Dim counter
    For counter = 1 To 2 Step 1
        MSHFlexGrid1.RowHeight(counter) = 350
    Next
End Sub

Private Sub Form_Load()
    Call ModConnect.Connect
'   Call setrowheight
    Call SetColWidth
    Call Header
    Call Load
End Sub

Private Sub Load()
    Dim colc, rowc
    ModConnect.Rs.Open "select * from student ", ModConnect.Conn, adOpenDynamic
    stg = "select id,Name from administrator"
    ModConnect.Conn.Execute (stg)
    If ModConnect.Rs.RecordCount = 0 Then
        MsgBox " no records "
    End If
'   MsgBox "done"
'   On Error Resume Next
    For rowc = 1 To ModConnect.Rs.RecordCount Step 1
        MSHFlexGrid1.Row = rowc
        MSHFlexGrid1.col = 0
        MSHFlexGrid1.Text = " " & rowc & " "
        For colc = 1 To 3 Step 1
            MSHFlexGrid1.col = colc
            MSHFlexGrid1.Text = Rs(colc - 1)
        Next
'   On Error Resume Next
        ModConnect.Rs.MoveNext
    Next
    Call ModConnect.Records_Close
End Sub



