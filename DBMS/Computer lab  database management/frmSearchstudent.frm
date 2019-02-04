VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form frmSearchStudent 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Add Details of the student"
   ClientHeight    =   8145
   ClientLeft      =   2010
   ClientTop       =   1710
   ClientWidth     =   10875
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   8145
   ScaleWidth      =   10875
   Tag             =   "aa"
   Begin MSAdodcLib.Adodc Adodc1 
      Align           =   1  'Align Top
      Height          =   485
      Left            =   0
      Top             =   0
      Width           =   10875
      _ExtentX        =   19182
      _ExtentY        =   847
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   2
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "Provider=MSDAORA.1;Password=tiger;User ID=scott;Persist Security Info=True"
      OLEDBString     =   "Provider=MSDAORA.1;Password=tiger;User ID=scott;Persist Security Info=True"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   "scott"
      Password        =   "tiger"
      RecordSource    =   ""
      Caption         =   "Display Student details"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.CommandButton cmdcancel 
      Caption         =   "&Cancel"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   6240
      TabIndex        =   1
      Top             =   6840
      Width           =   1215
   End
   Begin VB.CommandButton cmdok 
      Caption         =   "&Ok"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3480
      TabIndex        =   0
      Top             =   6840
      Width           =   1215
   End
   Begin VB.Frame frmstuddetails 
      Caption         =   "Display of Students Details"
      Height          =   4335
      Left            =   1920
      TabIndex        =   2
      Top             =   1200
      Width           =   7095
      Begin VB.TextBox txtBatchName 
         Appearance      =   0  'Flat
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   385
         Index           =   7
         Left            =   3000
         TabIndex        =   14
         ToolTipText     =   " Students Batch Name"
         Top             =   2640
         Width           =   3255
      End
      Begin VB.TextBox txtPassword 
         Appearance      =   0  'Flat
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   385
         Index           =   6
         Left            =   3000
         TabIndex        =   13
         Tag             =   "$"
         ToolTipText     =   "  Students Total no. of hours worked in the lab during working hrs."
         Top             =   3120
         Width           =   3255
      End
      Begin VB.TextBox txtSemester 
         Appearance      =   0  'Flat
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   385
         Index           =   3
         Left            =   3000
         TabIndex        =   12
         ToolTipText     =   " Student's Semester"
         Top             =   1680
         Width           =   3255
      End
      Begin VB.TextBox txtBranch 
         Appearance      =   0  'Flat
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   385
         Index           =   2
         Left            =   3000
         TabIndex        =   11
         ToolTipText     =   " Student's Branch"
         Top             =   2160
         Width           =   3255
      End
      Begin VB.TextBox txtRegisterno 
         Appearance      =   0  'Flat
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   385
         Index           =   1
         Left            =   3000
         TabIndex        =   6
         ToolTipText     =   " Student's Register Number"
         Top             =   1200
         Width           =   3255
      End
      Begin VB.TextBox txtName 
         Appearance      =   0  'Flat
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   385
         Index           =   0
         Left            =   3000
         TabIndex        =   4
         ToolTipText     =   " Students Name"
         Top             =   720
         Width           =   3255
      End
      Begin VB.Label lblTothrs 
         Alignment       =   1  'Right Justify
         Caption         =   "&Total hours worked"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   240
         TabIndex        =   10
         Top             =   3120
         Width           =   2460
         WordWrap        =   -1  'True
      End
      Begin VB.Label Label4 
         Alignment       =   1  'Right Justify
         Caption         =   "&Semester"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   360
         TabIndex        =   9
         Top             =   1680
         Width           =   2100
      End
      Begin VB.Label Label3 
         Alignment       =   1  'Right Justify
         Caption         =   "&Branch"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   360
         TabIndex        =   8
         Top             =   2160
         Width           =   2100
      End
      Begin VB.Label Label2 
         Alignment       =   1  'Right Justify
         Caption         =   "Batch na&me"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   360
         TabIndex        =   7
         Top             =   2640
         Width           =   2100
      End
      Begin VB.Label lblregister 
         Alignment       =   1  'Right Justify
         Caption         =   "&Register number"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   360
         TabIndex        =   5
         Top             =   1200
         Width           =   2100
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Caption         =   "&Name of Student"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   405
         Left            =   120
         TabIndex        =   3
         Top             =   720
         Width           =   2295
      End
   End
End
Attribute VB_Name = "frmSearchStudent"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdcancel_Click()
    Unload Me
    frmAdministrator.Show
End Sub

Private Sub cmdclear_Click()
    'txtName.Text = ""    ' Clear text box.
   ' txtRegisterno.Text = ""
    'txtBatchName.Text = ""
    'txtdepartment.Text = ""
    'txtPassword.Text = ""
    'txtName.SetFocus
End Sub

