VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmSysSearch 
   BackColor       =   &H008080FF&
   Caption         =   "System Search"
   ClientHeight    =   9525
   ClientLeft      =   -5085
   ClientTop       =   555
   ClientWidth     =   15240
   LinkTopic       =   "Form2"
   ScaleHeight     =   9525
   ScaleWidth      =   15240
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.CommandButton CmdRAll 
      Caption         =   "Report All"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   1560
      TabIndex        =   43
      Top             =   8760
      Width           =   2055
   End
   Begin VB.CommandButton cmdReport 
      Caption         =   "Report"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   10320
      TabIndex        =   42
      Top             =   10080
      Width           =   3000
   End
   Begin VB.TextBox txtEnd 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   8160
      MaxLength       =   10
      TabIndex        =   39
      Top             =   4560
      Width           =   2385
   End
   Begin VB.TextBox txtStart 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   12720
      MaxLength       =   10
      TabIndex        =   37
      Top             =   4560
      Width           =   2145
   End
   Begin VB.ComboBox cmbPrn 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   13080
      Style           =   2  'Dropdown List
      TabIndex        =   35
      Top             =   3960
      Width           =   2000
   End
   Begin VB.ComboBox cmbInt 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   13080
      Style           =   2  'Dropdown List
      TabIndex        =   34
      Top             =   3360
      Width           =   2000
   End
   Begin VB.CommandButton cmdClear 
      Caption         =   "Clear"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   4080
      TabIndex        =   33
      Top             =   8760
      Width           =   3000
   End
   Begin VB.CheckBox chkSys 
      BackColor       =   &H00C0C0C0&
      Caption         =   "System Number"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   4440
      TabIndex        =   32
      Top             =   600
      Width           =   3000
   End
   Begin VB.ComboBox cmbStatus 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   8040
      Style           =   2  'Dropdown List
      TabIndex        =   31
      Top             =   3960
      Width           =   2500
   End
   Begin VB.ComboBox cmbCDr 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   8040
      Style           =   2  'Dropdown List
      TabIndex        =   30
      Top             =   2760
      Width           =   2500
   End
   Begin VB.ComboBox cmbSm 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   8040
      Style           =   2  'Dropdown List
      TabIndex        =   29
      Top             =   2160
      Width           =   2500
   End
   Begin VB.ComboBox cmbPm 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   8040
      Style           =   2  'Dropdown List
      TabIndex        =   28
      Top             =   1560
      Width           =   2500
   End
   Begin VB.ComboBox cmbSys 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   7680
      Style           =   2  'Dropdown List
      TabIndex        =   27
      Top             =   600
      Width           =   3000
   End
   Begin VB.ComboBox cmbKb 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   13080
      Style           =   2  'Dropdown List
      TabIndex        =   26
      Top             =   2760
      Width           =   2000
   End
   Begin VB.ComboBox cmbMTs 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   13080
      Style           =   2  'Dropdown List
      TabIndex        =   25
      Top             =   2160
      Width           =   2000
   End
   Begin VB.ComboBox cmbMTt 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   13080
      Style           =   2  'Dropdown List
      TabIndex        =   24
      Top             =   1560
      Width           =   2000
   End
   Begin VB.ComboBox cmbCDrw 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   8040
      Style           =   2  'Dropdown List
      TabIndex        =   23
      Top             =   3360
      Width           =   2500
   End
   Begin VB.ComboBox cmbFd 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   2880
      Style           =   2  'Dropdown List
      TabIndex        =   22
      Top             =   3960
      Width           =   2000
   End
   Begin VB.ComboBox cmbMou 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   2880
      Style           =   2  'Dropdown List
      TabIndex        =   21
      Top             =   3360
      Width           =   2000
   End
   Begin VB.ComboBox cmbMb 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   2880
      Style           =   2  'Dropdown List
      TabIndex        =   20
      Top             =   2760
      Width           =   2000
   End
   Begin VB.ComboBox cmbPro 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   2880
      Style           =   2  'Dropdown List
      TabIndex        =   19
      Top             =   2160
      Width           =   2000
   End
   Begin VB.CheckBox chkStatus 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Status"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   5040
      TabIndex        =   18
      Top             =   3960
      Width           =   2835
   End
   Begin VB.CheckBox chkPrn 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Printer"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   10680
      TabIndex        =   17
      Top             =   3960
      Width           =   2250
   End
   Begin VB.CheckBox chkInt 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Internet"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   10680
      TabIndex        =   16
      Top             =   3360
      Width           =   2250
   End
   Begin VB.CheckBox chkCDrw 
      BackColor       =   &H00C0C0C0&
      Caption         =   "CD Read Writer"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   5040
      TabIndex        =   15
      Top             =   3360
      Width           =   2835
   End
   Begin VB.CheckBox chkCDr 
      BackColor       =   &H00C0C0C0&
      Caption         =   "CD Read Drive"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   5040
      TabIndex        =   14
      Top             =   2760
      Width           =   2835
   End
   Begin VB.CheckBox chkFd 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Floppy Drive"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   480
      TabIndex        =   13
      Top             =   3960
      Width           =   2250
   End
   Begin VB.CheckBox chkMou 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Mouse"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   480
      TabIndex        =   12
      Top             =   3360
      Width           =   2250
   End
   Begin VB.CheckBox chkKb 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Key Board"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   10680
      TabIndex        =   11
      Top             =   2760
      Width           =   2250
   End
   Begin VB.CheckBox chkMTs 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Monitor Size"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   10680
      TabIndex        =   10
      Top             =   2160
      Width           =   2250
   End
   Begin VB.CheckBox chkMTt 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Monitor Type"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   10680
      TabIndex        =   9
      Top             =   1560
      Width           =   2250
   End
   Begin VB.CheckBox chkSm 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Secondary Memory"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   5040
      TabIndex        =   8
      Top             =   2160
      Width           =   2835
   End
   Begin VB.CheckBox chkPm 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Primary Memory"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   5040
      TabIndex        =   7
      Top             =   1560
      Width           =   2835
   End
   Begin VB.CheckBox chkMb 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Mother Board"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   480
      TabIndex        =   6
      Top             =   2760
      Width           =   2250
   End
   Begin VB.CheckBox chkPro 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Processor"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   480
      TabIndex        =   5
      Top             =   2160
      Width           =   2250
   End
   Begin VB.CheckBox chkLab 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Lab"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   480
      TabIndex        =   4
      Top             =   1560
      Width           =   2250
   End
   Begin VB.ComboBox cmbLab 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   2880
      Style           =   2  'Dropdown List
      TabIndex        =   2
      Top             =   1560
      Width           =   2000
   End
   Begin VB.CommandButton cmdOk 
      Caption         =   "Ok"
      Default         =   -1  'True
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   7920
      TabIndex        =   1
      Top             =   8760
      Width           =   3000
   End
   Begin VB.CommandButton cmdExit 
      Caption         =   "Exit"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   11640
      TabIndex        =   0
      Top             =   8760
      Width           =   3000
   End
   Begin MSDataGridLib.DataGrid DataGridSys 
      Height          =   3375
      Left            =   480
      TabIndex        =   3
      Top             =   5160
      Width           =   14295
      _ExtentX        =   25215
      _ExtentY        =   5953
      _Version        =   393216
      AllowUpdate     =   0   'False
      DefColWidth     =   133
      HeadLines       =   2
      RowHeight       =   23
      BeginProperty HeadFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ColumnCount     =   2
      BeginProperty Column00 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   0
         EndProperty
      EndProperty
      BeginProperty Column01 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   0
         EndProperty
      EndProperty
      SplitCount      =   1
      BeginProperty Split0 
         BeginProperty Column00 
         EndProperty
         BeginProperty Column01 
         EndProperty
      EndProperty
   End
   Begin VB.CheckBox chkVal 
      BackColor       =   &H80000016&
      Caption         =   " Enter costs (Lower or Upper or both)  in Rs. :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   400
      Left            =   480
      TabIndex        =   40
      Top             =   4560
      Width           =   5895
   End
   Begin VB.Label LblRep 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      BackColor       =   &H8000000B&
      Caption         =   "Report the Current Displayed Details"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   0
      TabIndex        =   41
      Top             =   10080
      Width           =   10335
   End
   Begin VB.Label lblGr 
      BackColor       =   &H80000016&
      Caption         =   "  Greater than"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   405
      Left            =   10800
      TabIndex        =   36
      Top             =   4560
      Width           =   1695
   End
   Begin VB.Label lblLe 
      BackColor       =   &H80000016&
      Caption         =   "  Less than"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   405
      Left            =   6480
      TabIndex        =   38
      Top             =   4560
      Width           =   1455
   End
End
Attribute VB_Name = "frmSysSearch"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Stg As String
Dim stg1 As String

Private Sub chkCDr_Click()
    Call Chk_Cmb_(chkCDr, cmbCDr)
End Sub

Private Sub chkCDrw_Click()
    Call Chk_Cmb_(chkCDrw, cmbCDrw)
End Sub

Private Sub chkFd_Click()
    Call Chk_Cmb_(chkFd, cmbFd)
End Sub

Private Sub chkInt_Click()
    Call Chk_Cmb_(chkInt, cmbInt)
End Sub

Private Sub chkKb_Click()
    Call Chk_Cmb_(chkKb, cmbKb)
End Sub

Private Sub chkLab_Click()
    Call Chk_Cmb_(chkLab, cmbLab)
End Sub

Private Sub chkMb_Click()
    Call Chk_Cmb_(chkMb, cmbMb)
End Sub

Private Sub chkMou_Click()
    Call Chk_Cmb_(chkMou, cmbMou)
End Sub

Private Sub chkMTs_Click()
    Call Chk_Cmb_(chkMTs, cmbMTs)
End Sub

Private Sub chkMTt_Click()
    Call Chk_Cmb_(chkMTt, cmbMTt)
End Sub

Private Sub chkPm_Click()
    Call Chk_Cmb_(chkPm, cmbPm)
End Sub

Private Sub chkPrn_Click()
    Call Chk_Cmb_(chkPrn, cmbPrn)
End Sub

Private Sub chkPro_Click()
    Call Chk_Cmb_(chkPro, cmbPro)
End Sub

Private Sub chkSm_Click()
    Call Chk_Cmb_(chkSm, cmbSm)
End Sub

Private Sub chkStatus_Click()
    Call Chk_Cmb_(chkStatus, cmbStatus)
End Sub

Private Sub chkSys_Click()
    Call Chk_Cmb_(chkSys, cmbSys)
End Sub

Private Sub chkVal_Click()
    If chkVal.Value = 0 Then
        txtStart.Text = ""
        txtStart.Enabled = False
        txtStart.BackColor = &H80000011
        txtEnd.Text = ""
        txtEnd.Enabled = False
        txtEnd.BackColor = &H80000011
    Else
        txtStart.Enabled = True
        txtStart.BackColor = &H80000005
        txtEnd.Enabled = True
        txtEnd.BackColor = &H80000005
    End If
End Sub

Private Sub cmdClear_Click()
    stg1 = ""
    Stg = ""
    chkLab.Value = 0
    chkSys.Value = 0
    chkPro.Value = 0
    chkMb.Value = 0
    chkMou.Value = 0
    chkFd.Value = 0
    chkPm.Value = 0
    chkSm.Value = 0
    chkCDr.Value = 0
    chkCDrw.Value = 0
    chkStatus.Value = 0
    chkMTt.Value = 0
    chkMTs.Value = 0
    chkKb.Value = 0
    chkInt.Value = 0
    chkPrn.Value = 0
    chkVal.Value = 0
    Call chkCDr_Click
    Call chkCDrw_Click
    Call chkPro_Click
    Call chkMb_Click
    Call chkPm_Click
    Call chkSm_Click
    Call chkKb_Click
    Call chkFd_Click
    Call chkMou_Click
    Call chkMTt_Click
    Call chkMTs_Click
    Call chkVal_Click
    Call chkStatus_Click
    Call chkInt_Click
    Call chkPrn_Click
    Call chkLab_Click
    Call chkSys_Click
    DataGridSys.Visible = False
End Sub

Private Sub CmdExit_Click()
    Unload Me
End Sub

Private Sub cmdOK_Click()
    Stg = ""
    If chkSys.Value = 1 Then
        If cmbSys.Text <> "" Then
            Stg = "sys_no= '" + cmbSys.Text + "'"
        Else
            Stg = ""
        End If
    End If
    If chkLab.Value = 1 Then
        If Stg <> "" Then
            Stg = Stg + " and "
        End If
        Stg = Stg + "lab = '" + cmbLab.Text + "'"
    End If
    If chkPro.Value = 1 Then
        If Stg <> "" Then
            Stg = Stg + " and "
        End If
        Stg = Stg + "processor = '" + cmbPro.Text + "'"
    End If
    If chkMb.Value = 1 Then
        If Stg <> "" Then
            Stg = Stg + " and "
        End If
        Stg = Stg + "mother_board = '" + cmbMb.Text + "'"
    End If
    If chkPm.Value = 1 Then
        If Stg <> "" Then
            Stg = Stg + " and "
        End If
        Stg = Stg + "pr_mem = to_number('" + cmbPm.Text + "')"
    End If
    If chkSm.Value = 1 Then
        If Stg <> "" Then
            Stg = Stg + " and "
        End If
        Stg = Stg + "se_mem = to_number('" + cmbSm.Text + "')"
    End If
    If chkFd.Value = 1 Then
        If Stg <> "" Then
            Stg = Stg + " and "
        End If
        Stg = Stg + "fl_drive = '" + cmbFd.Text + "'"
    End If
    If chkCDr.Value = 1 Then
        If Stg <> "" Then
            Stg = Stg + " and "
        End If
        Stg = Stg + "cdr_drive = '" + cmbCDr.Text + "'"
    End If
    If chkCDrw.Value = 1 Then
        If Stg <> "" Then
            Stg = Stg + " and "
        End If
        Stg = Stg + "cdrw_drive = '" + cmbCDrw.Text + "'"
    End If
    If chkMTs.Value = 1 Then
        If Stg <> "" Then
            Stg = Stg + " and "
        End If
        Stg = Stg + "mon_size = '" + cmbMTs.Text + "'"
    End If
    If chkMTt.Value = 1 Then
        If Stg <> "" Then
            Stg = Stg + " and "
        End If
        Stg = Stg + "mon_type = '" + cmbMTt.Text + "'"
    End If
    If chkKb.Value = 1 Then
        If Stg <> "" Then
            Stg = Stg + " and "
        End If
        Stg = Stg + "key_board = '" + cmbKb.Text + "'"
    End If
    If chkMou.Value = 1 Then
        If Stg <> "" Then
            Stg = Stg + " and "
        End If
        Stg = Stg + "mouse = '" + cmbMou.Text + "'"
    End If
    If chkInt.Value = 1 Then
        If Stg <> "" Then
            Stg = Stg + " and "
        End If
        Stg = Stg + "internet = '" + cmbInt.Text + "'"
    End If
    If chkPrn.Value = 1 Then
        If Stg <> "" Then
            Stg = Stg + " and "
        End If
        Stg = Stg + "printer = '" + cmbPrn.Text + "'"
    End If
    If chkVal.Value = 1 Then
        'If Stg <> "" Then
           ' Stg = Stg + " and "
        'End If
        'Stg = Stg + " value "
        flag = 0
        
        If txtStart.Text <> "" Then
            flag = 1
            If Stg <> "" Then
                Stg = Stg + " and "
            End If
            Stg = Stg + " value "
            Stg = Stg + " > to_number('" + txtStart.Text + "')"
        End If
        If txtEnd.Text <> "" Then
            If Stg <> "" Then
                Stg = Stg + " and "
            End If
            'If flag = 0 Then
             ' Stg = Stg + " value "
            'End If
            'If txtStart.Text <> "" Then
                Stg = Stg + " value "
            'End If
            Stg = Stg + " <  to_number ('" + txtEnd.Text + "')"
        End If
    End If
    If chkStatus.Value = 1 Then
        If Stg <> "" Then
            Stg = Stg + " and "
        End If
        Stg = Stg + "status = '" + cmbStatus.Text + "'"
    End If
    If Stg = "" Then
        Exit Sub
    End If
    ModConnect.Records_Close
'    Call Combos_
    Dim stg1 As String
    stg1 = "select * from system where " + Stg
    Call Data_Grid_Fill_(DataGridSys, stg1)
    If stg1 = "" Then
        Stg = ""
    End If
    DataGridSys.Visible = True
End Sub


Private Sub CmdRAll_Click()
    'If LabData.LabConn.State = 0 Then
    On Error Resume Next
        LabData.LabConn.Open
        LabData.System
'    End If
     System_Report.Show 1
     LabData.LabConn.Close
End Sub

Private Sub cmdReportClick()
If cmbSys.Text <> "" Then
    On Error Resume Next
    LabData.LabConn.Close
    LabData.LabConn.Open
    STNG = Trim(cmbSys.Text)
    LabData.ssystem (STNG)
    DataReportSSys.Refresh
    DataReportSSys.Show 1
    LabData.LabConn.Close
End If
    MsgBox "Select System number", vbInformation, "Error"
End Sub

Private Sub cmdReport_Click()
    On Error Resume Next
    LabData.LabConn.Open
    If Stg <> "" Then
        Dim str As String
        str = "create or replace view sys_view as select * from system where " + Stg
        ModConnect.Conn.Execute (str)
        str = "select * from sys_view"
        ModConnect.Records_Close
        Rs.Open str, Conn, adOpenKeyset
        Conn.Execute (str)
'        DataRepSys.Show 1
    Else
        MsgBox "Nothing to display", vbInformation + vbOKOnly, "Report Empty"
        Exit Sub
    End If
    LabData.Sys_View
    DataRepviewsys.Refresh
    DataRepviewsys.Show 1
    LabData.LabConn.Close
    Call cmdOK_Click
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Form_Load()
    If LOGIN_TYPE = "S" Then
        chkVal.Visible = False
        lblGr.Visible = False
        lblLe.Visible = False
        txtStart.Visible = False
        txtEnd.Visible = False
        LblRep.Visible = False
        cmdReport.Visible = False
        CmdRAll.Visible = False
    End If
    Call ModConnect.Connect
    Call cmdClear_Click
    Call Combos_
End Sub
Private Sub txtEnd_KeyPress(KeyAscii As Integer)
    Call ModFun.Numbers_(KeyAscii)
End Sub

Private Sub txtStart_KeyPress(KeyAscii As Integer)
    Call ModFun.Numbers_(KeyAscii)
End Sub

Public Sub Combos_()
    Call ModFun.Combo_Fill(cmbSys, "system", "sys_no", "sys_no")
    Call ModFun.Combo_Fill(cmbLab, "lab", "lab_name", "lab_name")
    Call ModFun.Combo_Fill(cmbPro, "System", "processor", "processor")
    Call ModFun.Combo_Fill(cmbMb, "System", "mother_board", "mother_board")
    Call ModFun.Combo_Fill(cmbPm, "System", "pr_mem", "pr_mem")
    Call ModFun.Combo_Fill(cmbSm, "System", "se_mem", "se_mem")
    Call ModFun.Combo_Fill(cmbFd, "System", "fl_drive", "fl_drive")
    Call ModFun.Combo_Fill(cmbCDr, "System", "cdr_drive", "cdr_drive")
    Call ModFun.Combo_Fill(cmbCDrw, "System", "cdrw_drive", "cdrw_drive")
    Call ModFun.Combo_Fill(cmbMTs, "System", "mon_size", "mon_size")
    Call ModFun.Combo_Fill(cmbMTt, "System", "mon_type", "mon_type")
    Call ModFun.Combo_Fill(cmbKb, "System", "key_board", "key_board")
    Call ModFun.Combo_Fill(cmbMou, "System", "mouse", "mouse")
    Call ModFun.Combo_Fill(cmbInt, "System", "internet", "internet")
    Call ModFun.Combo_Fill(cmbPrn, "System", "printer", "printer")
    Call ModFun.Combo_Fill(cmbStatus, "System", "status", "status")
End Sub

Private Sub simple_clear_not_valid()

    cmbSys.Text = ""
    cmbPro.Text = ""
    cmbMb.Text = ""
    cmbMou.Text = ""
    cmbFd.Text = ""
    cmbPm.Text = ""
    cmbSm.Text = ""
    cmbCDr.Text = ""
    cmbCDrw.Text = ""
    cmbCDrw.Text = ""
    cmbStatus.Text = ""
    cmbMTt.Text = ""
    cmbMTs.Text = ""
    cmbKb.Text = ""
    cmbInt.Text = ""
    cmbPrn.Text = ""
    cmbLab.Text = ""
    txtStart.Text = ""
    txtEnd.Text = ""

End Sub

