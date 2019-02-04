VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmSplash 
   BackColor       =   &H8000000D&
   BorderStyle     =   3  'Fixed Dialog
   ClientHeight    =   4365
   ClientLeft      =   3585
   ClientTop       =   2925
   ClientWidth     =   7560
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   Icon            =   "frmSplash.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4365
   ScaleWidth      =   7560
   ShowInTaskbar   =   0   'False
   Begin VB.Frame Frame1 
      BackColor       =   &H8000000A&
      ForeColor       =   &H8000000D&
      Height          =   4515
      Left            =   -120
      MouseIcon       =   "frmSplash.frx":000C
      MousePointer    =   99  'Custom
      TabIndex        =   0
      Top             =   -120
      Width           =   7785
      Begin VB.PictureBox Picture1 
         Height          =   1335
         Left            =   5280
         MouseIcon       =   "frmSplash.frx":044E
         Picture         =   "frmSplash.frx":05A0
         ScaleHeight     =   1275
         ScaleWidth      =   1875
         TabIndex        =   8
         Top             =   1320
         Width           =   1935
      End
      Begin TCI_tools.Splabel Splabel1 
         Height          =   525
         Left            =   480
         TabIndex        =   7
         Top             =   600
         Width           =   6975
         _ExtentX        =   12303
         _ExtentY        =   926
         CAPTION         =   "Computer Lab Database Management"
         BACKCOLOUR      =   -2147483635
         TEXTBACKCOLOUR  =   8438015
         BACKSTYLE       =   0
         TEXTFORECOLOUR  =   255
         PLAY            =   -1  'True
         INTERVAL1       =   100
         INTERVAL2       =   10
         BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Tahoma"
            Size            =   18
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000001&
         BackStyle       =   0  'Transparent
         Caption         =   "By"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   2760
         TabIndex        =   9
         Top             =   2880
         Width           =   1215
      End
      Begin VB.Image imgLogo 
         BorderStyle     =   1  'Fixed Single
         DragMode        =   1  'Automatic
         Height          =   1875
         Left            =   360
         MouseIcon       =   "frmSplash.frx":9B38
         MousePointer    =   99  'Custom
         Picture         =   "frmSplash.frx":9F7A
         Stretch         =   -1  'True
         Top             =   1560
         Width           =   1815
      End
      Begin VB.Label lblCopyright 
         Alignment       =   2  'Center
         BackColor       =   &H80000001&
         BackStyle       =   0  'Transparent
         Caption         =   "ABHIJITH D.A. 1PI01IS001"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   4080
         TabIndex        =   4
         Top             =   2880
         Width           =   3495
      End
      Begin VB.Label lblCompany 
         Alignment       =   2  'Center
         BackColor       =   &H80000001&
         BackStyle       =   0  'Transparent
         Caption         =   "MAHESH M.P. 1PI01IS042"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   4200
         TabIndex        =   3
         Top             =   3360
         Width           =   3255
      End
      Begin VB.Label lblWarning 
         BackColor       =   &H80000001&
         BackStyle       =   0  'Transparent
         Caption         =   "Starting Up. . . . ."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   240
         TabIndex        =   2
         Top             =   4200
         Width           =   3615
      End
      Begin VB.Label lblVersion 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackColor       =   &H80000001&
         BackStyle       =   0  'Transparent
         Caption         =   "Version 1.0  "
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Left            =   3480
         TabIndex        =   5
         Top             =   2400
         Width           =   1395
      End
      Begin VB.Label lblPlatform 
         AutoSize        =   -1  'True
         BackColor       =   &H80000001&
         BackStyle       =   0  'Transparent
         Caption         =   " PESIT "
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Left            =   6000
         TabIndex        =   6
         Top             =   3840
         Width           =   825
      End
      Begin VB.Label lblLicenseTo 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000001&
         BackStyle       =   0  'Transparent
         Caption         =   "LicenseTo :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   3480
         TabIndex        =   1
         Top             =   3840
         Width           =   2415
      End
   End
End
Attribute VB_Name = "frmSplash"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit

Private Sub Form_KeyPress(KeyAscii As Integer)
    Unload Me
    MDIFrmMain.Show
End Sub

Private Sub Form_Load()
    lblVersion.Caption = "Version " & App.Major & "." & App.Minor & "." & App.Revision
'    frmTableCheck.Show
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Frame1_Click()
    Unload Me
    MDIFrmMain.Show
End Sub

Private Sub imgLogo_Click()
    Unload Me
    MDIFrmMain.Show
End Sub

Private Sub Splabel1_Click()
    Unload Me
    MDIFrmMain.Show
End Sub

Private Sub Picture1_Click()
    Unload Me
    MDIFrmMain.Show
End Sub
