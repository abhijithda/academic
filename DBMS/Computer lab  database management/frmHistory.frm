VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmHistory 
   BackColor       =   &H008080FF&
   Caption         =   "History"
   ClientHeight    =   7035
   ClientLeft      =   2520
   ClientTop       =   1965
   ClientWidth     =   11940
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   ScaleHeight     =   7035
   ScaleWidth      =   11940
   WindowState     =   2  'Maximized
   Begin TCI_tools.SplabelB SplabelB1 
      Height          =   570
      Left            =   4560
      TabIndex        =   4
      Top             =   840
      Width           =   3075
      _ExtentX        =   5424
      _ExtentY        =   1005
      CAPTION         =   "History Details"
      BACKCOLOUR      =   -2147483633
      TEXTBACKCOLOUR  =   12640511
      BACKSTYLE       =   1
      TEXTFORECOLOUR  =   7088128
      PLAY            =   -1  'True
      INTERVAL1       =   175
      INTERVAL2       =   10
      BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Generate Report"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   475
      Left            =   1920
      TabIndex        =   3
      Top             =   7920
      Width           =   3000
   End
   Begin VB.CommandButton cmdClear 
      Caption         =   "Clear &History"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   475
      Left            =   5280
      TabIndex        =   2
      Top             =   7920
      Width           =   3000
   End
   Begin VB.CommandButton cmdExit 
      Caption         =   "E&xit"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   475
      Left            =   8880
      TabIndex        =   1
      Top             =   7920
      Width           =   3000
   End
   Begin MSDataGridLib.DataGrid DataGridHis 
      Height          =   4935
      Left            =   1080
      TabIndex        =   0
      Top             =   2280
      Width           =   12015
      _ExtentX        =   21193
      _ExtentY        =   8705
      _Version        =   393216
      AllowUpdate     =   0   'False
      DefColWidth     =   200
      HeadLines       =   1
      RowHeight       =   21
      BeginProperty HeadFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
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
         Italic          =   -1  'True
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
End
Attribute VB_Name = "frmHistory"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdClear_Click()
    ModConnect.Rhis.Open "select * from history", ModConnect.Conn, adOpenDynamic
    ModConnect.Conn.Execute ("delete history")
    ModConnect.Rhis.Close
    Call ModFun.Data_Grid_Fill_(DataGridHis, "select * from history")
End Sub

Private Sub CmdExit_Click()
    Unload Me
End Sub

Private Sub Command1_Click()
    LabData.LabConn.Open
    On Error Resume Next
    LabData.History
    History_Report.Refresh
    History_Report.Show 1
    LabData.LabConn.Close
End Sub

Private Sub Form_Load()
    Dim Stg As String
    Stg = "select user_id,name,login,logout,lab_name,sys_no from history ORDER BY login DESC"
    Call Data_Grid_Fill_(DataGridHis, Stg)
End Sub

