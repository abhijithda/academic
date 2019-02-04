/****************************************************************************
** nmFormproject meta object code from reading C++ file 'nmformproject.h'
**
** WARNING! All changes made in this file will be lost!
*****************************************************************************/

#undef QT_NO_COMPAT
#include "../.ui/nmformproject.h"
#include <qmetaobject.h>
#include <qapplication.h>

#include <private/qucomextra_p.h>
#if !defined(Q_MOC_OUTPUT_REVISION) || (Q_MOC_OUTPUT_REVISION != 26)
#error "This file was generated using the moc from 3.1.1. It"
#error "cannot be used with the include files from this version of Qt."
#error "(The moc has changed too much.)"
#endif

const char *nmFormproject::className() const
{
    return "nmFormproject";
}

QMetaObject *nmFormproject::metaObj = 0;
static QMetaObjectCleanUp cleanUp_nmFormproject( "nmFormproject", &nmFormproject::staticMetaObject );

#ifndef QT_NO_TRANSLATION
QString nmFormproject::tr( const char *s, const char *c )
{
    if ( qApp )
	return qApp->translate( "nmFormproject", s, c, QApplication::DefaultCodec );
    else
	return QString::fromLatin1( s );
}
#ifndef QT_NO_TRANSLATION_UTF8
QString nmFormproject::trUtf8( const char *s, const char *c )
{
    if ( qApp )
	return qApp->translate( "nmFormproject", s, c, QApplication::UnicodeUTF8 );
    else
	return QString::fromUtf8( s );
}
#endif // QT_NO_TRANSLATION_UTF8

#endif // QT_NO_TRANSLATION

QMetaObject* nmFormproject::staticMetaObject()
{
    if ( metaObj )
	return metaObj;
    QMetaObject* parentObject = QDialog::staticMetaObject();
    static const QUMethod slot_0 = {"newConnection", 0, 0 };
    static const QUMethod slot_1 = {"connectfun", 0, 0 };
    static const QUMethod slot_2 = {"requestfun", 0, 0 };
    static const QUMethod slot_3 = {"mainsaveaction", 0, 0 };
    static const QUMethod slot_4 = {"actualsaveaction", 0, 0 };
    static const QUMethod slot_5 = {"actualsavecancelaction", 0, 0 };
    static const QUMethod slot_6 = {"aboutfun", 0, 0 };
    static const QUMethod slot_7 = {"clearfun", 0, 0 };
    static const QUMethod slot_8 = {"exitfun", 0, 0 };
    static const QUMethod slot_9 = {"languageChange", 0, 0 };
    static const QMetaData slot_tbl[] = {
	{ "newConnection()", &slot_0, QMetaData::Public },
	{ "connectfun()", &slot_1, QMetaData::Public },
	{ "requestfun()", &slot_2, QMetaData::Public },
	{ "mainsaveaction()", &slot_3, QMetaData::Public },
	{ "actualsaveaction()", &slot_4, QMetaData::Public },
	{ "actualsavecancelaction()", &slot_5, QMetaData::Public },
	{ "aboutfun()", &slot_6, QMetaData::Public },
	{ "clearfun()", &slot_7, QMetaData::Public },
	{ "exitfun()", &slot_8, QMetaData::Public },
	{ "languageChange()", &slot_9, QMetaData::Protected }
    };
    metaObj = QMetaObject::new_metaobject(
	"nmFormproject", parentObject,
	slot_tbl, 10,
	0, 0,
#ifndef QT_NO_PROPERTIES
	0, 0,
	0, 0,
#endif // QT_NO_PROPERTIES
	0, 0 );
    cleanUp_nmFormproject.setMetaObject( metaObj );
    return metaObj;
}

void* nmFormproject::qt_cast( const char* clname )
{
    if ( !qstrcmp( clname, "nmFormproject" ) )
	return this;
    return QDialog::qt_cast( clname );
}

bool nmFormproject::qt_invoke( int _id, QUObject* _o )
{
    switch ( _id - staticMetaObject()->slotOffset() ) {
    case 0: newConnection(); break;
    case 1: connectfun(); break;
    case 2: requestfun(); break;
    case 3: mainsaveaction(); break;
    case 4: actualsaveaction(); break;
    case 5: actualsavecancelaction(); break;
    case 6: aboutfun(); break;
    case 7: clearfun(); break;
    case 8: exitfun(); break;
    case 9: languageChange(); break;
    default:
	return QDialog::qt_invoke( _id, _o );
    }
    return TRUE;
}

bool nmFormproject::qt_emit( int _id, QUObject* _o )
{
    return QDialog::qt_emit(_id,_o);
}
#ifndef QT_NO_PROPERTIES

bool nmFormproject::qt_property( int id, int f, QVariant* v)
{
    return QDialog::qt_property( id, f, v);
}

bool nmFormproject::qt_static_property( QObject* , int , int , QVariant* ){ return FALSE; }
#endif // QT_NO_PROPERTIES
