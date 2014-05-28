﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DROP TABLE IF EXISTS DOCUMENTS;\r\nCREATE TABLE Documents (dID INT NOT NULL, medieN" +
            "umber INT NOT NULL, relativePath TEXT NOT NULL, pID INT, \r\noriginalFileName TEXT" +
            ", originalExtension TEXT, archiveExtension TEXT, gmlXSD TEXT, testResults TEXT,\r" +
            "\nPRIMARY KEY  (medieNumber,relativePath, dID));\r\n\r\nDROP TABLE IF EXISTS CONTEXTD" +
            "OCUMENTATIONDOCUMENTS;\r\nCREATE TABLE CONTEXTDOCUMENTATIONDOCUMENTS (dID INT NOT " +
            "NULL, medieNumber INT NOT NULL, relativePath TEXT NOT NULL, \r\noriginalFileName T" +
            "EXT, archiveExtension TEXT, docDescription TEXT, docDate TEXT, testResults TEXT," +
            " \r\nPRIMARY KEY  (medieNumber,relativePath, dID));\r\n\r\n\r\n\r\nDROP TABLE IF EXISTS co" +
            "lumns;\r\nCREATE TABLE columns (colNumber TEXT NOT NULL,  tableName TEXT NOT NULL," +
            " colName TEXT NOT NULL, \r\ncolType TEXT NOT NULL, colOriginalType TEXT NULL, defa" +
            "ultValue TEXT NULL, nullAble TEXT NOT NULL, colDescription TEXT NOT NULL, PRIMAR" +
            "Y KEY(colName, tableName)); \r\n\r\n\r\nDROP TABLE IF EXISTS tables;\r\nCreate table tab" +
            "les (tableName text NOT NULL PRIMARY KEY, folder text NOT NULL, description text" +
            " NOT NULL, rows int NOT NULL, countedRows int NOT NULL, \r\nmedianumber int NOT NU" +
            "LL, relativePath text NOT NULL, priority int NOT NULL);\r\n\r\nDROP TABLE IF EXISTS " +
            "constraintNames;\r\nCREATE TABLE constraintNames (constraintName TEXT NOT NULL PRI" +
            "MARY KEY, tableName TEXT, constraintType TEXT, recursive TEXT);\r\n\r\n\r\nDROP TABLE " +
            "IF EXISTS constraintColumns;\r\nCREATE TABLE constraintColumns (constraintColumnNa" +
            "me TEXT NOT NULL , constraintName TEXT NOT NULL, tableName TEXT, count TEXT, PRI" +
            "MARY KEY(constraintColumnName ,constraintName ) ); \r\n\r\n\r\nDROP TABLE IF EXISTS re" +
            "ferencedColumns;\r\nCREATE TABLE referencedColumns (referencedColumnName TEXT NOT " +
            "NULL ,  constraintName TEXT NOT NULL, referencedTableName TEXT,  count TEXT, PRI" +
            "MARY KEY(referencedColumnName , constraintName ) ); \r\n\r\n\r\nDROP TABLE IF EXISTS  " +
            "functionalDescription;\r\nCREATE TABLE funcTionalDescription (tableName TEXT NOT N" +
            "ULL, colNumber TEXT NOT NULL, functionalDescription TEXT NOT NULL, \r\nPRIMARY KEY" +
            "(colNumber, tableName));\r\n\r\n\r\nDROP TABLE IF EXISTS  Files;\r\nCREATE TABLE Files\r\n" +
            "(mediaNumber INTEGER NOT NULL, relativePath TEXT NOT NULL, [fileName] TEXT NOT N" +
            "ULL, extension TEXT, md5 TEXT, size TEXT, \r\nIDnumFileType INTEGER, [timeStamp] T" +
            "EXT, PRIMARY KEY (mediaNumber, relativePath, [fileName], extension));\r\n\r\n\r\nDROP " +
            "TABLE IF EXISTS  Media;\r\nCREATE TABLE Media(mediaNumber INTEGER NOT NULL PRIMARY" +
            " KEY AUTOINCREMENT, hasDocuments TEXT, hasTables TEXT);\r\n\r\n\r\nDROP TABLE IF EXIST" +
            "S  FileType;\r\nCREATE TABLE FileType (IDnumFileType INTEGER NOT NULL PRIMARY KEY " +
            "AUTOINCREMENT, FileType TEXT NOT NULL); \r\nINSERT INTO FileType(FileType) VALUES(" +
            "\'Index\');\r\nINSERT INTO FileType(FileType) VALUES(\'IndexXSD\');\r\nINSERT INTO FileT" +
            "ype(FileType) VALUES(\'Document\');\r\nINSERT INTO FileType(FileType) VALUES(\'Docume" +
            "ntation\');\r\nINSERT INTO FileType(FileType) VALUES(\'Table\');\r\nINSERT INTO FileTyp" +
            "e(FileType) VALUES(\'TableXSD\');\r\nINSERT INTO FileType(FileType) VALUES(\'GML\');\r\n" +
            "INSERT INTO FileType(FileType) VALUES(\'GMLxsd\');\r\n\r\nDROP TABLE IF EXISTS  Functi" +
            "onalDescriptionType;\r\nCREATE TABLE FunctionalDescriptionType (IDfunctionalDescri" +
            "ptionType INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, functionalDescriptionType " +
            "TEXT NOT NULL); \r\n\r\nINSERT INTO FunctionalDescriptionType(functionalDescriptionT" +
            "ype) VALUES(\'Myndighedsindentifikation\');\r\nINSERT INTO FunctionalDescriptionType" +
            "(functionalDescriptionType) VALUES(\'Dokumentidentifikation\');\t\r\nINSERT INTO Func" +
            "tionalDescriptionType(functionalDescriptionType) VALUES(\'Lagringsform\');\r\nINSERT" +
            " INTO FunctionalDescriptionType(functionalDescriptionType) VALUES(\'Afleveret\');\r" +
            "\nINSERT INTO FunctionalDescriptionType(functionalDescriptionType) VALUES(\'Sagsid" +
            "entifikation\');\r\nINSERT INTO FunctionalDescriptionType(functionalDescriptionType" +
            ") VALUES(\'Sagstitel\');\r\nINSERT INTO FunctionalDescriptionType(functionalDescript" +
            "ionType) VALUES(\'Dokumenttitel\');\t\t\t\r\nINSERT INTO FunctionalDescriptionType(func" +
            "tionalDescriptionType) VALUES(\'Dokumentdato\');\t\t\t\t\r\nINSERT INTO FunctionalDescri" +
            "ptionType(functionalDescriptionType) VALUES(\'Afsender_modtager\');\r\nINSERT INTO F" +
            "unctionalDescriptionType(functionalDescriptionType) VALUES(\'Digital_signatur\');\r" +
            "\nINSERT INTO FunctionalDescriptionType(functionalDescriptionType) VALUES(\'FORM\')" +
            ";\r\nINSERT INTO FunctionalDescriptionType(functionalDescriptionType) VALUES(\'Kass" +
            "ation\');\r\n\r\n\r\nDROP TABLE IF EXISTS views;\r\nCREATE TABLE views (viewName TEXT NOT" +
            " NULL PRIMARY KEY, view TEXT, description TEXT);\r\n\r\n\r\nDROP TABLE IF EXISTS  Sett" +
            "ings;\r\nCREATE TABLE Settings (settingsID INTEGER NOT NULL PRIMARY KEY AUTOINCREM" +
            "ENT,structureTest INTEGER NOT NULL, \r\nparserSettings INTEGER NOT NULL, tabelTest" +
            " INTEGER NOT NULL, documentsTest INTEGER NOT NULl, constraintTest INTEGER NOT NU" +
            "LL);\r\n\r\n\r\nDROP TABLE IF EXISTS  TestLog;\r\nCREATE TABLE TestLog (logID INTEGER NO" +
            "T NULL PRIMARY KEY AUTOINCREMENT, mediaNumber INTEGER NOT NULL, relativePath TEX" +
            "T NOT NULL, [fileName] TEXT NOT NULL, \r\ntestCode INTEGER, errorCode INTEGER, err" +
            "orCodePosOrCount INTEGER, errorText TEXT, accumulated INTEGER, [timeStamp] TEXT)" +
            ";  \r\n\r\nDROP TABLE IF EXISTS Info;\r\nCREATE TABLE Info(Key VARCHAR(20),Value VARCH" +
            "AR(20));\r\nINSERT INTO Info(Key, Value) VALUES(\"DBVersion\", \"{0}\");\r\n\r\n\r\nDROP TAB" +
            "LE IF EXISTS archiveIndex;\r\nCREATE TABLE archiveIndex\r\n(\r\n\t\tarchiveInformationPa" +
            "ckageID TEXT PRIMARY KEY,\r\n\t\tarchiveInformationPackageIDPrevious TEXT NULL,\r\n\t\ta" +
            "rchivePeriodStart TEXT NOT NULL,\r\n\t\tarchivePeriodEnd TEXT NOT NULL,\r\n\t\tarchiveIn" +
            "formationPacketType TEXT NOT NULL,\r\n\t\tarchiveType TEXT NOT NULL,\r\n\t\tsystemName T" +
            "EXT NOT NULL,\r\n\t\tsystemPurpose TEXT NOT NULL,\r\n\t\tsystemContent TEXT NOT NULL,\r\n\t" +
            "\tregionNum TEXT NOT NULL,\r\n\t\tkomNum TEXT NOT NULL,\r\n\t\tcprNum TEXT NOT NULL,\r\n\t\tc" +
            "vrNum TEXT NOT NULL,\r\n\t\tmatrikNum TEXT NOT NULL,\r\n\t\tbbrNum TEXT NOT NULL,\r\n\t\twho" +
            "SygKod TEXT NOT NULL,\r\n\t\tcontainsDigitalDocuments TEXT NOT NULL,\r\n\t\tsearchRelate" +
            "dOtherRecords TEXT NOT NULL,\r\n\t\tsystemFileConcept TEXT NOT NULL,\r\n\t\tmultipleData" +
            "Collection TEXT NOT NULL,\r\n\t\tpersonalDataRestrictedInfo TEXT NOT NULL,\r\n\t\totherA" +
            "ccessTypeRestrictions TEXT NOT NULL,\r\n\t\tarchiveApproval TEXT NOT NULL,\r\n\t\tarchiv" +
            "eRestrictions TEXT NULL\r\n);\r\n\r\nDROP TABLE IF EXISTS form;\r\nCREATE TABLE form\r\n(\r" +
            "\n\t\tformVersion TEXT PRIMARY KEY,\r\n\t\tarchiveInformationPackageID TEXT NULL,\r\n\t\tFO" +
            "REIGN KEY(archiveInformationPackageID) REFERENCES archiveIndex(archiveInformatio" +
            "nPackageID)\t \r\n);\r\n\r\nDROP TABLE IF EXISTS archiveCreatorList;\r\nCREATE TABLE arch" +
            "iveCreatorList\r\n(\r\n\t\tarchiveCreatorID INTEGER PRIMARY KEY AUTOINCREMENT,\r\n\t\tcrea" +
            "torName TEXT NOT NULL,\r\n\t\tcreationPeriodStart TEXT NULL,\r\n\t\tcreationPeriodEnd TE" +
            "XT NOT NULL,\r\n\t\tarchiveInformationPackageID TEXT NOT NULL,\r\n\t\tFOREIGN KEY(archiv" +
            "eInformationPackageID) REFERENCES archiveIndex(archiveInformationPackageID)\t \r\n)" +
            ";\r\n\r\nDROP TABLE IF EXISTS classList;\r\nCREATE TABLE classList\r\n(\r\n\t\tformClass TEX" +
            "T PRIMARY KEY,\r\n\t\tformClassTEXT TEXT NOT NULL,\r\n\t\tformVersion TEXT NULL,\r\n\t\tFORE" +
            "IGN KEY(formVersion) REFERENCES form(formVersion)\t\r\n);\r\n\r\nDROP TABLE IF EXISTS a" +
            "lternativeNames;\r\nCREATE TABLE alternativeNames\r\n(\r\n\t  alternativeName TEXT NULL" +
            ",\r\n\t  archiveInformationPackageID TEXT NOT NULL,\t\r\n\t\tFOREIGN KEY(archiveInformat" +
            "ionPackageID) REFERENCES archiveIndex(archiveInformationPackageID)\t\r\n);\r\n\r\nDROP " +
            "TABLE IF EXISTS sourceNames;\r\nCREATE TABLE sourceNames\r\n(\r\n\t  sourceName TEXT NU" +
            "LL,\r\n\t  archiveInformationPackageID TEXT NOT NULL,\t\r\n\t\tFOREIGN KEY(archiveInform" +
            "ationPackageID) REFERENCES archiveIndex(archiveInformationPackageID)\t\r\n);\r\n\r\nDRO" +
            "P TABLE IF EXISTS userNames;\r\nCREATE TABLE userNames\r\n(\r\n\t  userName TEXT NULL,\r" +
            "\n\t  archiveInformationPackageID TEXT NOT NULL,\t\r\n\t\tFOREIGN KEY(archiveInformatio" +
            "nPackageID) REFERENCES archiveIndex(archiveInformationPackageID)\t\r\n);\r\n\r\nDROP TA" +
            "BLE IF EXISTS predecessorNames;\r\nCREATE TABLE predecessorNames\r\n(\r\n\t  predecesso" +
            "rName TEXT NULL,\r\n\t  archiveInformationPackageID TEXT NOT NULL,\t\r\n\t\tFOREIGN KEY(" +
            "archiveInformationPackageID) REFERENCES archiveIndex(archiveInformationPackageID" +
            ")\t\r\n);\r\n\r\nDROP TABLE IF EXISTS relatedRecordsNames;\r\nCREATE TABLE relatedRecords" +
            "Names\r\n(\r\n\t  relatedRecordsName TEXT NULL,\r\n\t  archiveInformationPackageID TEXT " +
            "NOT NULL,\t\r\n\t\tFOREIGN KEY(archiveInformationPackageID) REFERENCES archiveIndex(a" +
            "rchiveInformationPackageID)\t\r\n);\r\n\r\nDROP TABLE IF EXISTS adaViews;\r\nCREATE TABLE" +
            " adaViews\r\n(\r\n\t  viewName TEXT NOT NULL,\r\n\t  query TEXT NOT NULL\t\r\n);\r\n")]
        public string sqlite_db {
            get {
                return ((string)(this["sqlite_db"]));
            }
            set {
                this["sqlite_db"] = value;
            }
        }
    }
}
