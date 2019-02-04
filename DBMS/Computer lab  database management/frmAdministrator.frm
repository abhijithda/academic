VERSION 5.00
Begin VB.Form frmAdministrator 
   Caption         =   "Administrator"
   ClientHeight    =   6930
   ClientLeft      =   4140
   ClientTop       =   2865
   ClientWidth     =   9510
   BeginProperty Font 
      Name            =   "Arial"
      Size            =   11.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   Palette         =   "frmAdministrator.frx":0000
   PaletteMode     =   2  'Custom
   Picture         =   "frmAdministrator.frx":43891
   ScaleHeight     =   6930
   ScaleWidth      =   9510
   WindowState     =   2  'Maximized
   Begin VB.PictureBox Picture1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4575
      Left            =   240
      Picture         =   "frmAdministrator.frx":5A642
      ScaleHeight     =   4515
      ScaleWidth      =   3915
      TabIndex        =   4
      Top             =   600
      Width           =   3975
   End
   Begin VB.CommandButton cmdMod 
      Caption         =   "Modify Student Details"
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
      Left            =   4680
      MaskColor       =   &H00C0FFFF&
      TabIndex        =   3
      Top             =   4080
      Width           =   3495
   End
   Begin VB.CommandButton cmdRemove 
      Caption         =   "Remove Student"
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
      Left            =   4680
      MaskColor       =   &H00C0FFFF&
      TabIndex        =   2
      Top             =   3480
      Width           =   3495
   End
   Begin VB.CommandButton cmdDisplay 
      Caption         =   "Display Student Details"
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
      Left            =   4680
      MaskColor       =   &H00C0FFFF&
      TabIndex        =   1
      Top             =   2880
      Width           =   3495
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "Add Student"
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
      Left            =   4680
      MaskColor       =   &H00C0FFFF&
      TabIndex        =   0
      Top             =   2280
      Width           =   3495
   End
   Begin VB.Menu mnuData 
      Caption         =   "Data&bases"
      Begin VB.Menu mnuDataadmin 
         Caption         =   "&Administrator databases"
      End
      Begin VB.Menu mnuDataStudent 
         Caption         =   "&Student databases"
      End
      Begin VB.Menu DataLab 
         Caption         =   "&Lab databases"
      End
      Begin VB.Menu mnuDataComputer 
         Caption         =   "S&ystem datebases"
      End
   End
   Begin VB.Menu mnuTime 
      Caption         =   "&Time Table Details"
   End
   Begin VB.Menu mnuRes 
      Caption         =   "&Reservation Details"
   End
   Begin VB.Menu mnuHis 
      Caption         =   "&History Details"
   End
   Begin VB.Menu mnuExit 
      Caption         =   "E&xit"
      Begin VB.Menu mnuExitLogoff 
         Caption         =   "&Log Off"
      End
   End
End
Attribute VB_Name = "frmAdministrator"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Log_Close As Boolean

Private Sub cmdAdd_Click()
    Select Case cmdAdd.Caption
        Case "Add Administrator":  frmAddAdmin.Show 1, frmAdministrator
        Case "Add Student":    frmAddstudent.Show 1, frmAdministrator
        Case "Add Lab":         frmAddLab.Show 1, frmAdministrator
        Case "Add System": frmAddSys.Show 1, frmAdministrator
    End Select
End Sub

Private Sub cmdDisplay_Click()
     Select Case CmdDisplay.Caption
        Case "Display Student Details":             frmDisplayStudent.Show 1, frmAdministrator
        Case "Display Administrator Details":       frmDispAdmin.Show 1, frmAdministrator
        Case "Display Lab Details":                 FrmDispLab.Show 1, frmAdministrator
        Case "Display System Details":              frmSysSearch.Show 1
'        LabData.LabConn.Open
'        LabData.System
'        System_Report.Refresh
'        System_Report.Show 1
'        LabData.LabConn.Close
    End Select
End Sub

Private Sub cmdMod_Click()
     Select Case cmdMod.Caption
        Case "Modify Student Details":              frmModStud.Show 1, frmAdministrator
        Case "Modify Administrator Details":        frmModAdmin.Show 1, frmAdministrator
        Case "Modify Lab Details":                  frmModLab.Show 1, frmAdministrator
        Case "Modify System Details":               frmModSys.Show 1, frmAdministrator
    End Select
End Sub

Private Sub cmdRemove_Click()
    Select Case cmdRemove.Caption
        Case "Remove Student":    frmRemStu.Show 1, frmAdministrator
        Case "Remove Administrator": frmRemAdmin.Show 1, frmAdministrator
        Case "Remove Lab": frmRemLab.Show 1, frmAdministrator
        Case "Remove System": frmRemSys.Show 1, frmAdministrator
    End Select
End Sub

Private Sub DataLab_Click()
    cmdAdd.Caption = "Add Lab"
    CmdDisplay.Caption = "Display Lab Details"
    cmdRemove.Caption = "Remove Lab"
    cmdMod.Caption = "Modify Lab Details"
End Sub

Private Sub Form_Load()
    ModVar.LOGIN_TYPE = "A"
    Log_Close = True
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If Log_Close = True Then
        Cancel = 1
    Else
        Cancel = 0
    End If
End Sub

Private Sub mnuDataadmin_Click()
    cmdAdd.Caption = "Add Administrator"
    CmdDisplay.Caption = "Display Administrator Details"
    cmdRemove.Caption = "Remove Administrator"
    cmdMod.Caption = "Modify Administrator Details"
End Sub

Private Sub mnuDataStudent_Click()
    cmdAdd.Caption = "Add Student"
    CmdDisplay.Caption = "Display Student Details"
    cmdRemove.Caption = "Remove Student"
    cmdMod.Caption = "Modify Student Details"
End Sub

Private Sub mnuDataComputer_Click()
    cmdAdd.Caption = "Add System"
    CmdDisplay.Caption = "Display System Details"
    cmdRemove.Caption = "Remove System"
    cmdMod.Caption = "Modify System Details"
End Sub

Private Sub mnuExitLogoff_Click()
    Call Logout_Call
    Log_Close = False
    Unload Me
    MDIFrmMain.Show
End Sub

Private Sub mnuHis_Click()
    frmHistory.Show 1
End Sub

Private Sub mnuRes_Click()
    FrmRes.Show 1
End Sub

Private Sub mnuTime_Click()
    frmAddTimeTable.Show 1
End Sub

