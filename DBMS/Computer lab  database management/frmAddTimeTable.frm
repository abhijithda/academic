VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmAddTimeTable 
   BackColor       =   &H008080FF&
   ClientHeight    =   8880
   ClientLeft      =   1710
   ClientTop       =   1545
   ClientWidth     =   12015
   ForeColor       =   &H8000000B&
   LinkTopic       =   "Form2"
   LockControls    =   -1  'True
   ScaleHeight     =   8880
   ScaleWidth      =   12015
   WindowState     =   2  'Maximized
   Begin VB.CommandButton cmdCTT 
      Caption         =   "Clear Time Table"
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
      Left            =   1920
      TabIndex        =   22
      Top             =   9360
      Width           =   3000
   End
   Begin VB.CommandButton CmdUpdate 
      Caption         =   "Update Grid Details"
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
      Left            =   6000
      TabIndex        =   21
      Top             =   9360
      Width           =   3000
   End
   Begin TCI_tools.SplabelB SplabelB1 
      Height          =   570
      Left            =   4680
      TabIndex        =   20
      Top             =   360
      Width           =   3240
      _ExtentX        =   5715
      _ExtentY        =   1005
      CAPTION         =   "Add Time Table"
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
   Begin MSDataGridLib.DataGrid DataGridLab 
      Height          =   3495
      Left            =   1320
      TabIndex        =   19
      Top             =   5040
      Width           =   12615
      _ExtentX        =   22251
      _ExtentY        =   6165
      _Version        =   393216
      AllowUpdate     =   -1  'True
      DefColWidth     =   167
      ColumnHeaders   =   -1  'True
      HeadLines       =   3
      RowHeight       =   23
      AllowDelete     =   -1  'True
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
   Begin VB.ComboBox cmbDay 
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
      ItemData        =   "frmAddTimeTable.frx":0000
      Left            =   3000
      List            =   "frmAddTimeTable.frx":0019
      Style           =   2  'Dropdown List
      TabIndex        =   18
      Top             =   1440
      Width           =   3000
   End
   Begin VB.TextBox Text3 
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
      Left            =   3000
      MaxLength       =   5
      TabIndex        =   17
      Top             =   2040
      Width           =   3000
   End
   Begin VB.ComboBox m2 
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
      ItemData        =   "frmAddTimeTable.frx":005D
      Left            =   9840
      List            =   "frmAddTimeTable.frx":0085
      Style           =   2  'Dropdown List
      TabIndex        =   14
      Top             =   2160
      Width           =   1000
   End
   Begin VB.ComboBox h2 
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
      ItemData        =   "frmAddTimeTable.frx":00B9
      Left            =   8280
      List            =   "frmAddTimeTable.frx":0105
      Style           =   2  'Dropdown List
      TabIndex        =   13
      Top             =   2160
      Width           =   1000
   End
   Begin VB.ComboBox m1 
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
      ItemData        =   "frmAddTimeTable.frx":0169
      Left            =   9840
      List            =   "frmAddTimeTable.frx":0191
      Style           =   2  'Dropdown List
      TabIndex        =   12
      Top             =   1560
      Width           =   1000
   End
   Begin VB.ComboBox h1 
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
      ItemData        =   "frmAddTimeTable.frx":01C5
      Left            =   8280
      List            =   "frmAddTimeTable.frx":0211
      Style           =   2  'Dropdown List
      TabIndex        =   11
      Top             =   1560
      Width           =   1000
   End
   Begin VB.CommandButton Command3 
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
      Height          =   495
      Left            =   9960
      TabIndex        =   10
      Top             =   9360
      Width           =   3000
   End
   Begin VB.CommandButton Command2 
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
      Left            =   6000
      TabIndex        =   9
      Top             =   3840
      Width           =   3000
   End
   Begin VB.CommandButton frmAddTimeTable 
      Caption         =   "Add"
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
      Left            =   10200
      TabIndex        =   8
      Top             =   3840
      Width           =   3000
   End
   Begin VB.ComboBox Combo1 
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
      ItemData        =   "frmAddTimeTable.frx":0275
      Left            =   8280
      List            =   "frmAddTimeTable.frx":0277
      Style           =   2  'Dropdown List
      TabIndex        =   7
      Top             =   2760
      Width           =   3000
   End
   Begin VB.TextBox Text4 
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
      Left            =   3000
      MaxLength       =   20
      TabIndex        =   6
      Top             =   2640
      Width           =   3000
   End
   Begin VB.Label Label8 
      BackStyle       =   0  'Transparent
      Caption         =   "hh                     mm"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   9480
      TabIndex        =   16
      Top             =   2160
      Width           =   2055
   End
   Begin VB.Label Label6 
      BackStyle       =   0  'Transparent
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
      Height          =   375
      Left            =   6600
      TabIndex        =   5
      Top             =   2760
      Width           =   1320
   End
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   "End Time"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   6600
      TabIndex        =   4
      Top             =   2160
      Width           =   1320
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "Start Time"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   6600
      TabIndex        =   3
      Top             =   1560
      Width           =   1320
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Incharge"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1320
      TabIndex        =   2
      Top             =   2640
      Width           =   1320
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Batch"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1320
      TabIndex        =   1
      Top             =   2040
      Width           =   1320
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Day"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1320
      TabIndex        =   0
      Top             =   1440
      Width           =   1320
   End
   Begin VB.Label Label7 
      BackStyle       =   0  'Transparent
      Caption         =   "hh                     mm"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   9480
      TabIndex        =   15
      Top             =   1560
      Width           =   2175
   End
End
Attribute VB_Name = "frmAddTimeTable"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub DBList1_Click()
Call Clear
End Sub

Private Sub cmdCTT_Click()
    If (MsgBox("Wish to Clear Time table ? ", vbQuestion + vbYesNo, "Confirm ") = vbYes) Then
        ModConnect.Records_Close
        'ModConnect.Rs.Open "select * from time_table", ModConnect.Conn, adOpenDynamic
        Stg = "delete time_table"
        Conn.Execute (Stg)
        ModConnect.Records_Close
    End If
End Sub

Private Sub Form_Terminate()
    ModConnect.Records_Close
End Sub

Private Sub Form_Unload(Cancel As Integer)
    ModConnect.Records_Close
End Sub

Private Sub frmAddTimeTable_Click()

    If cmbDay.Text = "" Or IsEmpty(Text3.Text) Or IsEmpty(Text4.Text) Then
        MsgBox "Enter All the fields", vbInformation + vbOKOnly, "Details Incomplete"
        Exit Sub
    End If
    If Combo1.Text = "" Then
        MsgBox "Enter Lab. If lab is not present Add lab", vbApplicationModal, "Error Add"
        Exit Sub
    End If
    st = h1.Text + ":" + m1.Text
    et = h2.Text + ":" + m2.Text
    
    ModConnect.Records_Close
    ModConnect.Rs.Open "select * from time_table", ModConnect.Conn, adOpenDynamic
    stg1 = "insert into time_table(day,start_time,end_time,lab,incharge,batch) values ('" + cmbDay.Text + "','" + st + "','" + et + "','" + Combo1.Text + "','" + Text4.Text + "','" + Text3.Text + "')"
    On Error GoTo err
    ModConnect.Conn.Execute (stg1)
    MsgBox "Time Table Entered", vbOKOnly, "Success"
    GoTo Le
err:
    MsgBox "Time Table for this Time already exists", vbCritical, Failure
Le:
    Call DataGrid_Lab
End Sub

Private Sub Command2_Click()
    Call Clear
End Sub

Private Sub Command3_Click()
    Unload Me
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Form_Load()
    Call ModConnect.Connect
    Call ModFun.Combo_Fill(Combo1, "lab", "lab_name", "lab_name")
    Call ModConnect.Records_Close
    Call DataGrid_Lab
End Sub


Public Sub Clear()
    cmbDay.ListIndex = -1
    h1.ListIndex = -1
    h2.ListIndex = -1
    m1.ListIndex = -1
    m2.ListIndex = -1
    Text3.Text = ""
    Text4.Text = ""
    Combo1.ListIndex = -1
End Sub

Public Sub DataGrid_Lab()
    ModConnect.Records_Close
    stg1 = "Select * from time_table"
    ModConnect.Rs.Open stg1, ModConnect.Conn, adOpenKeyset, adLockPessimistic
    ModConnect.Conn.Execute (stg1)
    If Not ModConnect.Rs.EOF Then
        Set DataGridLab.DataSource = ModConnect.Rs
    End If
End Sub

Public Sub cmdUpdate_Click()
    Set ModConnect.Rs = DataGridLab.DataSource
'    ModConnect.Rs.UpdateBatch adAffectGroup
End Sub

