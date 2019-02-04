/****************************************************************************
** Form implementation generated from reading ui file 'nmformproject.ui'
**
** Created: Thu Dec 30 21:59:06 2004
**      by: The User Interface Compiler ($Id: qt/main.cpp   3.1.1   edited Nov 21 17:40 $)
**
** WARNING! All changes made in this file will be lost!
****************************************************************************/

#include "nmformproject.h"

#include <qvariant.h>
#include <qcombobox.h>
#include <qlabel.h>
#include <qlineedit.h>
#include <qpushbutton.h>
#include <qtextedit.h>
#include <qlayout.h>
#include <qtooltip.h>
#include <qwhatsthis.h>
#include <qimage.h>
#include <qpixmap.h>

#include "../nmformproject.ui.h"
/* 
 *  Constructs a nmFormproject as a child of 'parent', with the 
 *  name 'name' and widget flags set to 'f'.
 *
 *  The dialog will by default be modeless, unless you set 'modal' to
 *  TRUE to construct a modal dialog.
 */
nmFormproject::nmFormproject( QWidget* parent, const char* name, bool modal, WFlags fl )
    : QDialog( parent, name, modal, fl )

{
    if ( !name )
	setName( "nmFormproject" );
    setMouseTracking( TRUE );
    setFocusPolicy( QDialog::TabFocus );

    iptextLabel = new QLabel( this, "iptextLabel" );
    iptextLabel->setGeometry( QRect( 94, 116, 120, 32 ) );

    QWidget* privateLayoutWidget = new QWidget( this, "layout7" );
    privateLayoutWidget->setGeometry( QRect( 70, 210, 610, 250 ) );
    layout7 = new QVBoxLayout( privateLayoutWidget, 11, 6, "layout7"); 
    QSpacerItem* spacer = new QSpacerItem( 20, 20, QSizePolicy::Minimum, QSizePolicy::Preferred );
    layout7->addItem( spacer );

    textEdit2 = new QTextEdit( privateLayoutWidget, "textEdit2" );
    QFont textEdit2_font(  textEdit2->font() );
    textEdit2_font.setPointSize( 11 );
    textEdit2->setFont( textEdit2_font ); 
    textEdit2->setReadOnly( TRUE );
    layout7->addWidget( textEdit2 );

    lineEdit4 = new QLineEdit( this, "lineEdit4" );
    lineEdit4->setEnabled( FALSE );
    lineEdit4->setGeometry( QRect( 230, 120, 180, 23 ) );
    lineEdit4->setFocusPolicy( QLineEdit::StrongFocus );
    lineEdit4->setMaxLength( 20 );
    lineEdit4->setAlignment( int( QLineEdit::AlignRight ) );

    enterpathtext = new QLineEdit( this, "enterpathtext" );
    enterpathtext->setEnabled( FALSE );
    enterpathtext->setGeometry( QRect( 230, 490, 450, 30 ) );
    QFont enterpathtext_font(  enterpathtext->font() );
    enterpathtext_font.setPointSize( 14 );
    enterpathtext->setFont( enterpathtext_font ); 

    quitpushButton = new QPushButton( this, "quitpushButton" );
    quitpushButton->setGeometry( QRect( 690, 320, 120, 30 ) );

    startpushButton = new QPushButton( this, "startpushButton" );
    startpushButton->setEnabled( FALSE );
    startpushButton->setGeometry( QRect( 570, 110, 110, 32 ) );
    startpushButton->setDefault( FALSE );

    requestpushButton = new QPushButton( this, "requestpushButton" );
    requestpushButton->setEnabled( FALSE );
    requestpushButton->setGeometry( QRect( 570, 170, 110, 30 ) );
    requestpushButton->setDefault( TRUE );

    selecttextLabel = new QLabel( this, "selecttextLabel" );
    selecttextLabel->setGeometry( QRect( 91, 161, 112, 48 ) );

    clearpushButton = new QPushButton( this, "clearpushButton" );
    clearpushButton->setGeometry( QRect( 690, 430, 120, 32 ) );

    textLabel1 = new QLabel( this, "textLabel1" );
    textLabel1->setGeometry( QRect( 210, 20, 420, 38 ) );

    btnNew = new QPushButton( this, "btnNew" );
    btnNew->setGeometry( QRect( 70, 70, 160, 32 ) );
    btnNew->setDefault( FALSE );

    savepushbutton = new QPushButton( this, "savepushbutton" );
    savepushbutton->setEnabled( FALSE );
    savepushbutton->setGeometry( QRect( 400, 550, 120, 32 ) );

    cancelpushbutton = new QPushButton( this, "cancelpushbutton" );
    cancelpushbutton->setEnabled( FALSE );
    cancelpushbutton->setGeometry( QRect( 560, 550, 120, 32 ) );

    createfile = new QPushButton( this, "createfile" );
    createfile->setGeometry( QRect( 70, 480, 140, 40 ) );

    aboutpushButton = new QPushButton( this, "aboutpushButton" );
    aboutpushButton->setGeometry( QRect( 690, 270, 120, 30 ) );

    comboBox2 = new QComboBox( FALSE, this, "comboBox2" );
    comboBox2->setEnabled( FALSE );
    comboBox2->setGeometry( QRect( 230, 170, 290, 27 ) );
    comboBox2->setFocusPolicy( QComboBox::WheelFocus );
    languageChange();
    resize( QSize(821, 596).expandedTo(minimumSizeHint()) );

    // signals and slots connections
    connect( quitpushButton, SIGNAL( clicked() ), this, SLOT( exitfun() ) );
    connect( clearpushButton, SIGNAL( clicked() ), this, SLOT( clearfun() ) );
    connect( aboutpushButton, SIGNAL( clicked() ), this, SLOT( aboutfun() ) );
    connect( btnNew, SIGNAL( clicked() ), this, SLOT( newConnection() ) );
    connect( requestpushButton, SIGNAL( clicked() ), this, SLOT( requestfun() ) );
    connect( startpushButton, SIGNAL( clicked() ), this, SLOT( connectfun() ) );
    connect( enterpathtext, SIGNAL( returnPressed() ), this, SLOT( actualsaveaction() ) );
    connect( createfile, SIGNAL( clicked() ), this, SLOT( mainsaveaction() ) );
    connect( savepushbutton, SIGNAL( clicked() ), this, SLOT( actualsaveaction() ) );
    connect( cancelpushbutton, SIGNAL( clicked() ), this, SLOT( actualsavecancelaction() ) );
    connect( lineEdit4, SIGNAL( returnPressed() ), this, SLOT( connectfun() ) );

    // buddies
    iptextLabel->setBuddy( lineEdit4 );
    selecttextLabel->setBuddy( comboBox2 );
}

/*
 *  Destroys the object and frees any allocated resources
 */
nmFormproject::~nmFormproject()
{
    // no need to delete child widgets, Qt does it all for us
}

/*
 *  Sets the strings of the subwidgets using the current
 *  language.
 */
void nmFormproject::languageChange()
{
    setCaption( tr( "Network  System  Monitoring" ) );
    iptextLabel->setText( tr( "Enter IP address :" ) );
    textEdit2->setText( tr( "Server Wating....." ) );
    QToolTip::add( lineEdit4, tr( "Enter the IP Address of the Client." ) );
    quitpushButton->setText( tr( "&Quit" ) );
    startpushButton->setText( tr( "&Start" ) );
    requestpushButton->setText( tr( "&Request" ) );
    selecttextLabel->setText( tr( "Select an item :    " ) );
    clearpushButton->setText( tr( "&Clear" ) );
    textLabel1->setText( tr( "<b><h1><font color = magenta><p align=\"center\"><b>Network System Monitoring </b></p></h1></font>" ) );
    btnNew->setText( tr( "Start &New Connection" ) );
    savepushbutton->setText( tr( "Sa&ve" ) );
    cancelpushbutton->setText( tr( "Cance&l" ) );
    createfile->setText( tr( "&Enter path to save" ) );
    aboutpushButton->setText( tr( "&About" ) );
    comboBox2->clear();
    comboBox2->insertItem( tr( "Process status of the client" ) );
    comboBox2->insertItem( tr( "tty of the client" ) );
    comboBox2->insertItem( tr( "uptime of the client" ) );
    comboBox2->insertItem( tr( "cpu info of the client" ) );
    comboBox2->insertItem( tr( "IO ports of the client" ) );
    comboBox2->insertItem( tr( "Interrupts of the client" ) );
    comboBox2->insertItem( tr( "File system of the client" ) );
    comboBox2->insertItem( tr( "Hardware configuration of the client" ) );
    comboBox2->insertItem( tr( "Partition information of the client" ) );
    comboBox2->insertItem( tr( "Slab information of the client" ) );
    comboBox2->insertItem( tr( "IO memory status of the client" ) );
    comboBox2->insertItem( tr( "Device status of the client" ) );
    comboBox2->insertItem( tr( "Stat status of the client" ) );
    comboBox2->insertItem( tr( "Memory information of the client" ) );
    comboBox2->insertItem( tr( "File System Mounted" ) );
    comboBox2->insertItem( tr( "Model and Number of Hard Disk" ) );
    comboBox2->insertItem( tr( "Hardware Drivers of the client" ) );
    comboBox2->insertItem( tr( "Users of the Client System" ) );
    comboBox2->insertItem( tr( "Client System User's Information" ) );
    comboBox2->insertItem( tr( "System Processes of client" ) );
    comboBox2->insertItem( tr( "File system disk space usage" ) );
}

