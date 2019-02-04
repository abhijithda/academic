Attribute VB_Name = "ModConnect"
Global Conn As Connection
Global Cn As Connection
Global Rs As Recordset
Global Recs As Recordset
Global Rhis As Recordset
 
Public Sub Connect()
    Set Conn = New ADODB.Connection
    Set Cn = New ADODB.Connection
    Set Rs = New ADODB.Recordset
    Set Recs = New ADODB.Recordset
    Set Rhis = New ADODB.Recordset
    On Error GoTo sys1  'if any error occurs then display error
    Conn.Open "Provider=OraOLEDB.Oracle.1", "scott", "tiger"
    Cn.Open "Provider=OraOLEDB.Oracle.1", "scott", "tiger"
    On Error GoTo sys1
    GoTo nor
   
'sco2:   On Error GoTo sys1

   '     Conn.Open "Provider=MSDAORA.1", "scott", "tiger"
     '   Cn.Open "PROVIDER=MSDAORA.1", "scott", "tiger"
      '  GoTo nor
        
sys1:   On Error GoTo err
        'Cn.Open "provider=Oracle.1", "userid=system", "Password=manager"
        'Conn.Open "oraoledb.oracle.1", "user=system", "password=manager"
        'GoTo nor
        
err:
        MsgBox "oracle not available", vbInformation + vbOKOnly, "Fatal Error"
        MsgBox "Install Oracle to run this application", vbApplicationModal, "Install Oracle"
        End

nor:

End Sub         'end of oracle connect function

Public Sub Default_Abhi()
    Rs.Open "select * from administrator", Conn, adOpenDynamic
    stg = "insert into administrator (Name,id,passwd) values ('ABHIJITH','ABHIJITH','ABHIJITH')"
    On Error GoTo nor
    Conn.Execute (stg)
    MsgBox "Please..... Enter", vbInformation + vbOKOnly, "Updated"
nor: Rs.Close
End Sub

Public Sub Records_Close()
    On Error Resume Next
    Recs.Close
    On Error Resume Next
    Rs.Close
    On Error Resume Next
    Rhis.Close
End Sub
