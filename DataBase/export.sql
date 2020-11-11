--------------------------------------------------------
--  File created - יום רביעי-נובמבר-11-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table DOCUMENT_MARKER
--------------------------------------------------------

  CREATE TABLE "DOCUMENT_MARKER" 
   (	"OWNER" VARCHAR2(20 BYTE), 
	"DOCID" VARCHAR2(20 BYTE), 
	"MARKERID" VARCHAR2(20 BYTE), 
	"MARKERTYPE" VARCHAR2(20 BYTE), 
	"MARKERLOC" VARCHAR2(132 BYTE), 
	"FORECOLOR" VARCHAR2(20 BYTE), 
	"BACKCOLOR" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table DOCUMENTS
--------------------------------------------------------

  CREATE TABLE "DOCUMENTS" 
   (	"OWNER" VARCHAR2(20 BYTE), 
	"DOCID" VARCHAR2(20 BYTE), 
	"DOCNAME" VARCHAR2(20 BYTE), 
	"DOCURL" VARCHAR2(500 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table SHARE_DOCS
--------------------------------------------------------

  CREATE TABLE "SHARE_DOCS" 
   (	"DOCID" VARCHAR2(20 BYTE), 
	"USERID" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table TYPE_SHAPE
--------------------------------------------------------

  CREATE TABLE "TYPE_SHAPE" 
   (	"SHAPE" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table USERS
--------------------------------------------------------

  CREATE TABLE "USERS" 
   (	"USERID" VARCHAR2(20 BYTE), 
	"USERNAME" VARCHAR2(20 BYTE), 
	"ISACTIVE" NUMBER, 
	"ISLOGIN" NUMBER DEFAULT 0
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
REM INSERTING into DOCUMENT_MARKER
SET DEFINE OFF;
Insert into DOCUMENT_MARKER (OWNER,DOCID,MARKERID,MARKERTYPE,MARKERLOC,FORECOLOR,BACKCOLOR) values ('yosef@gmail.com','jpcvfi7pi','_293le3umd','Rectangle','{"Position":{"X":193.0,"Y":63.0},"Radius":{"X":431.0,"Y":167.0}}','#000000','#000000');
Insert into DOCUMENT_MARKER (OWNER,DOCID,MARKERID,MARKERTYPE,MARKERLOC,FORECOLOR,BACKCOLOR) values ('yosef@gmail.com','987','_ym7d1pzx3','Rectangle','{"Position":{"X":109.0,"Y":77.0},"Radius":{"X":260.0,"Y":246.0}}','#000000','#000000');
Insert into DOCUMENT_MARKER (OWNER,DOCID,MARKERID,MARKERTYPE,MARKERLOC,FORECOLOR,BACKCOLOR) values ('yosef@gmail.com','987','_9vxaf71cg','Ellipse','{"Position":{"X":188.85,"Y":451.66},"Radius":{"X":86.42,"Y":37.21}}','#000000','#000000');
Insert into DOCUMENT_MARKER (OWNER,DOCID,MARKERID,MARKERTYPE,MARKERLOC,FORECOLOR,BACKCOLOR) values ('yosef@gmail.com','jpcvfi7pi','_z92ppbfqp','Rectangle','{"Position":{"X":584.0,"Y":439.0},"Radius":{"X":0.0,"Y":0.0}}','#ff0011','#000000');
Insert into DOCUMENT_MARKER (OWNER,DOCID,MARKERID,MARKERTYPE,MARKERLOC,FORECOLOR,BACKCOLOR) values ('yosef@gmail.com','jpcvfi7pi','_n0z672fga','Rectangle','{"Position":{"X":190.0,"Y":277.0},"Radius":{"X":318.0,"Y":153.0}}','#ff0011','#0062ff');
Insert into DOCUMENT_MARKER (OWNER,DOCID,MARKERID,MARKERTYPE,MARKERLOC,FORECOLOR,BACKCOLOR) values ('yosef@gmail.com','jpcvfi7pi','_i21tyu7gh','Rectangle','{"Position":{"X":718.0,"Y":63.0},"Radius":{"X":110.0,"Y":221.0}}','#ff0011','#0062ff');
Insert into DOCUMENT_MARKER (OWNER,DOCID,MARKERID,MARKERTYPE,MARKERLOC,FORECOLOR,BACKCOLOR) values ('yosef@gmail.com','987','1','Rectangle','{"Position":{"X":0.0,"Y":0.0},"Radius":{"X":0.0,"Y":0.0}}','string','string');
Insert into DOCUMENT_MARKER (OWNER,DOCID,MARKERID,MARKERTYPE,MARKERLOC,FORECOLOR,BACKCOLOR) values ('yosef@gmail.com','987','2','RECTANGLE','{"Position":{"X":0.0,"Y":0.0},"Radius":{"X":0.0,"Y":0.0}}','string','string');
Insert into DOCUMENT_MARKER (OWNER,DOCID,MARKERID,MARKERTYPE,MARKERLOC,FORECOLOR,BACKCOLOR) values ('yosef@gmail.com','987','3','RECTANGLE','{"Position":{"X":0.0,"Y":0.0},"Radius":{"X":0.0,"Y":0.0}}','string','string');
Insert into DOCUMENT_MARKER (OWNER,DOCID,MARKERID,MARKERTYPE,MARKERLOC,FORECOLOR,BACKCOLOR) values ('yosef@gmail.com','987','89','Rectangle','{"Position":{"X":0.0,"Y":0.0},"Radius":{"X":0.0,"Y":0.0}}','#000000','#000000');
Insert into DOCUMENT_MARKER (OWNER,DOCID,MARKERID,MARKERTYPE,MARKERLOC,FORECOLOR,BACKCOLOR) values ('yosef@gmail.com','369','_d83qbgo5v','Rectangle','{"Position":{"X":253.0,"Y":78.0},"Radius":{"X":276.0,"Y":393.0}}','#000000','#000000');
Insert into DOCUMENT_MARKER (OWNER,DOCID,MARKERID,MARKERTYPE,MARKERLOC,FORECOLOR,BACKCOLOR) values ('yosef@gmail.com','953','_gfmk16lgg','Rectangle','{"Position":{"X":209.0,"Y":123.0},"Radius":{"X":459.0,"Y":211.0}}','#ff0000','#000000');
Insert into DOCUMENT_MARKER (OWNER,DOCID,MARKERID,MARKERTYPE,MARKERLOC,FORECOLOR,BACKCOLOR) values ('yosef@gmail.com','953','_x8olu1o8i','Rectangle','{"Position":{"X":781.0,"Y":83.0},"Radius":{"X":57.0,"Y":404.0}}','#ff0000','#000000');
Insert into DOCUMENT_MARKER (OWNER,DOCID,MARKERID,MARKERTYPE,MARKERLOC,FORECOLOR,BACKCOLOR) values ('yosef@gmail.com','987','_gyro8yze8','Rectangle','{"Position":{"X":569.0,"Y":47.0},"Radius":{"X":213.0,"Y":37.0}}','#000000','#000000');
Insert into DOCUMENT_MARKER (OWNER,DOCID,MARKERID,MARKERTYPE,MARKERLOC,FORECOLOR,BACKCOLOR) values ('yosef@gmail.com','953','_03sxog8sw','Ellipse','{"Position":{"X":293.55,"Y":424.68},"Radius":{"X":102.1,"Y":48.0}}','#ff0000','#000000');
REM INSERTING into DOCUMENTS
SET DEFINE OFF;
Insert into DOCUMENTS (OWNER,DOCID,DOCNAME,DOCURL) values ('meir@gmail.com','m4jhwiwkv','pic3','https://images.squarespace-cdn.com/content/v1/5a7c0544d74cffa3a6ce66b3/1581028716769-K1Y7KURGOFNJ8LW6ZHOF/ke17ZwdGBToddI8pDm48kEc6DKFOx3cpvkyhZQwPkJYUqsxRUqqbr1mOJYKfIPR7LoDQ9mXPOjoJoqy81S2I8N_N4V1vUb5AoIIIbLZhVYxCRW4BPu10St3TBAUQYVKc53GO0vWykWK-lIOAtsaJ7vbB1JiXq7byw-6Ogo-kuNnXzR_WIuWSVqqqoqhN8EA5/%D7%AA%D7%9E%D7%95%D7%A0%D7%AA+%D7%A0%D7%95%D7%A3+-+%D7%A9%D7%95%D7%95%D7%99%D7%A5.jpg?format=2500w');
Insert into DOCUMENTS (OWNER,DOCID,DOCNAME,DOCURL) values ('yosef@gmail.com','jpcvfi7pi','Pic7','https://wildtravel.co.il/wp-content/uploads/2016/02/IMG_8968-2-Sjpeg-no-sign.jpg');
Insert into DOCUMENTS (OWNER,DOCID,DOCNAME,DOCURL) values ('meir@gmail.com','123','PIC1','https://dalicanvas.co.il/wp-content/uploads/2019/01/%D7%A0%D7%95%D7%A3-%D7%9C%D7%99%D7%9D-6.jpg');
Insert into DOCUMENTS (OWNER,DOCID,DOCNAME,DOCURL) values ('yosef@gmail.com','789','PIC1','https://www.photo-art.co.il/wp-content/uploads/2015/06/BY1A65881.jpg');
Insert into DOCUMENTS (OWNER,DOCID,DOCNAME,DOCURL) values ('yosef@gmail.com','582','PIC2','https://d3m9l0v76dty0.cloudfront.net/system/photos/3874255/large/69d4ab7766cffe77cfaa32ab51d15df4.jpg');
Insert into DOCUMENTS (OWNER,DOCID,DOCNAME,DOCURL) values ('racheli@gmail.com','456','PIC1','https://static.wixstatic.com/media/fe48d7_2b0efce379964962bfd95cec34ffbbee~mv2_d_4608_3072_s_4_2.jpg/v1/fill/w_480,h_320,al_c,q_85,usm_0.66_1.00_0.01/fe48d7_2b0efce379964962bfd95cec34ffbbee~mv2_d_4608_3072_s_4_2.webp');
Insert into DOCUMENTS (OWNER,DOCID,DOCNAME,DOCURL) values ('yosef@gmail.com','987','PIC3','https://www.yo-yoo.co.il/coolpics/images/uploads/886571.jpeg');
Insert into DOCUMENTS (OWNER,DOCID,DOCNAME,DOCURL) values ('yosef@gmail.com','369','PIC4','https://dalicanvas.co.il/wp-content/uploads/2019/01/%D7%A0%D7%95%D7%A3-%D7%9C%D7%99%D7%9D-6.jpg');
Insert into DOCUMENTS (OWNER,DOCID,DOCNAME,DOCURL) values ('yosef@gmail.com','624','PIC5','https://static.wixstatic.com/media/fe48d7_2b0efce379964962bfd95cec34ffbbee~mv2_d_4608_3072_s_4_2.jpg/v1/fill/w_480,h_320,al_c,q_85,usm_0.66_1.00_0.01/fe48d7_2b0efce379964962bfd95cec34ffbbee~mv2_d_4608_3072_s_4_2.webp');
Insert into DOCUMENTS (OWNER,DOCID,DOCNAME,DOCURL) values ('yosef@gmail.com','953','PIC6','https://4.bp.blogspot.com/-c_Cv5N32AEA/Vvz2v5iSgzI/AAAAAAAGBY0/VHdJLF2ibFYkXVgqvoBuEmfy2dtJloMgQ/s1600/%25D7%25AA%25D7%259E%25D7%2595%25D7%25A0%25D7%2594%2B52.jpg');
Insert into DOCUMENTS (OWNER,DOCID,DOCNAME,DOCURL) values ('racheli@gmail.com','364','PIC2','https://www.yo-yoo.co.il/coolpics/images/uploads/886571.jpeg');
Insert into DOCUMENTS (OWNER,DOCID,DOCNAME,DOCURL) values ('meir@gmail.com','n6ubgrn2d','land','https://www.eliadyahalom.co.il/media/source/ELI_0752_B.jpg');
REM INSERTING into SHARE_DOCS
SET DEFINE OFF;
Insert into SHARE_DOCS (DOCID,USERID) values ('123','yair@gmail.com');
Insert into SHARE_DOCS (DOCID,USERID) values ('456','meir@gmail.com');
Insert into SHARE_DOCS (DOCID,USERID) values ('624','racheli@gmail.com');
Insert into SHARE_DOCS (DOCID,USERID) values ('953','meir@gmail.com');
Insert into SHARE_DOCS (DOCID,USERID) values ('953','racheli@gmail.com');
Insert into SHARE_DOCS (DOCID,USERID) values ('987','yair@gmail.com');
REM INSERTING into TYPE_SHAPE
SET DEFINE OFF;
REM INSERTING into USERS
SET DEFINE OFF;
Insert into USERS (USERID,USERNAME,ISACTIVE,ISLOGIN) values ('shai@gmail.com','shai',1,0);
Insert into USERS (USERID,USERNAME,ISACTIVE,ISLOGIN) values ('shalom@gmail.com','shalom',1,0);
Insert into USERS (USERID,USERNAME,ISACTIVE,ISLOGIN) values ('meir@gmail.com','meir',1,1);
Insert into USERS (USERID,USERNAME,ISACTIVE,ISLOGIN) values ('racheli@gmail.com','racheli',1,1);
Insert into USERS (USERID,USERNAME,ISACTIVE,ISLOGIN) values ('yosef@gmail.com','yosef',1,1);
Insert into USERS (USERID,USERNAME,ISACTIVE,ISLOGIN) values ('ariel@gmail.com','ariel',1,1);
Insert into USERS (USERID,USERNAME,ISACTIVE,ISLOGIN) values ('simhony@gmail.com','simhony',1,1);
Insert into USERS (USERID,USERNAME,ISACTIVE,ISLOGIN) values ('EVYATAR@GMAIL.COM','EVYAAR',0,1);
Insert into USERS (USERID,USERNAME,ISACTIVE,ISLOGIN) values ('yair@gmail.com','Yair',1,1);
Insert into USERS (USERID,USERNAME,ISACTIVE,ISLOGIN) values ('ARYEH@GMAIL.COM','ARYEH',1,0);
Insert into USERS (USERID,USERNAME,ISACTIVE,ISLOGIN) values ('BB@GMAIL.COM','BEZALEL',1,0);
Insert into USERS (USERID,USERNAME,ISACTIVE,ISLOGIN) values ('HAIM@GMAIL.COM','HAIM',1,0);
Insert into USERS (USERID,USERNAME,ISACTIVE,ISLOGIN) values ('eli@gmail.com','eli',0,0);
Insert into USERS (USERID,USERNAME,ISACTIVE,ISLOGIN) values ('Evyatar@gmail.com','Evyatar',1,0);
--------------------------------------------------------
--  DDL for Index DOCUMENTS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "DOCUMENTS_PK" ON "DOCUMENTS" ("DOCID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index DOCUMENT_MARKER_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "DOCUMENT_MARKER_PK" ON "DOCUMENT_MARKER" ("DOCID", "MARKERID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index SHARE_DOCS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "SHARE_DOCS_PK" ON "SHARE_DOCS" ("DOCID", "USERID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index USERS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "USERS_PK" ON "USERS" ("USERID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Procedure CREATE_DOC
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "CREATE_DOC" 
(
  P_OWNER IN VARCHAR2 
, P_DOCID IN VARCHAR2 
, P_DOCNAME IN VARCHAR2 
, P_DOCURL IN VARCHAR2 
, P_RC OUT SYS_REFCURSOR 
) AS 

BEGIN
INSERT INTO DOCUMENTS (OWNER, DOCID, DOCNAME, DOCURL)
VALUES  
    (  (SELECT USERID from USERS WHERE USERID=P_OWNER),  P_DOCID,  P_DOCNAME, P_DOCURL) ;
   
    OPEN P_RC FOR SELECT * FROM documents WHERE docid=P_DOCID;
    
END CREATE_DOC;

/
--------------------------------------------------------
--  DDL for Procedure CREATE_MARKER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "CREATE_MARKER" 
(
  P_OWNER IN VARCHAR2 
, P_DOCID IN VARCHAR2 
, P_MARKERID IN VARCHAR2
, P_MARKERTYPE IN VARCHAR2 
, P_MARKERLOC IN VARCHAR2 
, P_FORECOL IN VARCHAR2 
, P_BACKCOL IN VARCHAR2 
, P_RC OUT SYS_REFCURSOR 
) AS 
BEGIN
  INSERT INTO document_marker VALUES(
                        (select userid from users where userid = P_OWNER), 
                        (select docid from documents where docid = P_DOCID), 
                        P_MARKERID, P_MARKERTYPE,  P_MARKERLOC, P_FORECOL, P_BACKCOL);
                                                                                                   
  OPEN P_RC FOR SELECT * FROM document_marker 
  WHERE P_DOCID = DOCID AND P_MARKERID = markerid;                                                                                              
END CREATE_MARKER;

/
--------------------------------------------------------
--  DDL for Procedure CREATE_SHARE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "CREATE_SHARE" 
(
  P_DOCID IN VARCHAR2 
, P_USERID IN VARCHAR2 
, P_RC OUT SYS_REFCURSOR 
) AS 
BEGIN
  INSERT INTO share_docs 
  VALUES (  (SELECT docid FROM documents WHERE docid = P_DOCID), 
                       (SELECT USERID from USERS WHERE USERID= P_USERID) );
                       
   OPEN P_RC FOR SELECT * FROM share_docs 
   WHERE docid=P_DOCID and  USERID= P_USERID; 
END CREATE_SHARE;

/
--------------------------------------------------------
--  DDL for Procedure CREATE_USER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "CREATE_USER" 
(
      P_USERID IN VARCHAR2 
    , P_USERNAME IN VARCHAR2 
    , P_RC OUT SYS_REFCURSOR 
) AS 
BEGIN

INSERT INTO USERS VALUES (P_USERID, P_USERNAME, 1, 0);
OPEN P_RC FOR SELECT * FROM USERS WHERE USERID=P_USERID;

END CREATE_USER;

/
--------------------------------------------------------
--  DDL for Procedure GET_ALL_DOCS_OF_USER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "GET_ALL_DOCS_OF_USER" 
(
  P_USERID IN VARCHAR2 
, P_RC OUT SYS_REFCURSOR 
) AS 
BEGIN
  OPEN P_RC FOR SELECT * FROM documents WHERE P_USERID=OWNER;
END GET_ALL_DOCS_OF_USER;

/
--------------------------------------------------------
--  DDL for Procedure GET_ALL_MARKERS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "GET_ALL_MARKERS" 
(
  P_DOCID IN VARCHAR2 
, P_RC OUT SYS_REFCURSOR
) AS 
BEGIN
    OPEN P_RC FOR 
    SELECT * FROM document_marker 
    WHERE P_DOCID = docid; 
END GET_ALL_MARKERS;

/
--------------------------------------------------------
--  DDL for Procedure GET_ALL_USERS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "GET_ALL_USERS" 
(
  P_RC OUT SYS_REFCURSOR 
) AS 
BEGIN
  OPEN P_RC FOR SELECT * FROM USERS WHERE isactive = 1;
END GET_ALL_USERS;

/
--------------------------------------------------------
--  DDL for Procedure GET_DOC
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "GET_DOC" 
(
  P_DOCID IN VARCHAR2 
, P_RC OUT SYS_REFCURSOR 
) AS 
BEGIN
  OPEN P_RC FOR SELECT * FROM documents WHERE docid=P_DOCID;
END GET_DOC;

/
--------------------------------------------------------
--  DDL for Procedure GET_MARKER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "GET_MARKER" 
(
  P_DOCID IN VARCHAR2 
, P_MARKERID IN NUMBER 
, P_RC OUT SYS_REFCURSOR
) AS 
BEGIN
    OPEN P_RC FOR SELECT * FROM document_marker 
    WHERE P_DOCID = docid and P_MARKERID = markerid;
END GET_MARKER;

/
--------------------------------------------------------
--  DDL for Procedure GET_MY_SHARED_DOCS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "GET_MY_SHARED_DOCS" 
(
  P_USERID IN VARCHAR2 
, P_RC OUT SYS_REFCURSOR 
) AS 
BEGIN
  open P_RC for 
  select * 
  FROM documents d, share_docs sh
  where d.owner = P_USERID and  d.docid = sh.docid; 
END GET_MY_SHARED_DOCS;

/
--------------------------------------------------------
--  DDL for Procedure GET_USER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "GET_USER" 
(
  P_USERID IN VARCHAR2 
, P_RC OUT SYS_REFCURSOR 
) AS 
BEGIN
   OPEN P_RC FOR SELECT * FROM USERS WHERE P_USERID=USERID;
END GET_USER;

/
--------------------------------------------------------
--  DDL for Procedure LOGIN
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "LOGIN" 
(
  P_USERID IN VARCHAR2 
, P_RC OUT SYS_REFCURSOR 
) AS 
BEGIN
   UPDATE USERS
  SET ISLOGIN = 1
  WHERE USERID = p_userid;
  OPEN P_RC FOR SELECT * FROM USERS WHERE USERID=P_USERID;
END LOGIN;

/
--------------------------------------------------------
--  DDL for Procedure LOGOUT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "LOGOUT" 
(
  P_USERID IN VARCHAR2 
, P_RC OUT SYS_REFCURSOR 
) AS 
BEGIN
   UPDATE USERS
  SET ISLOGIN = 0
  WHERE USERID = P_USERID;
  OPEN P_RC FOR SELECT * FROM USERS WHERE USERID=P_USERID;
END LOGOUT;

/
--------------------------------------------------------
--  DDL for Procedure REMOVE_ALL_MARKERS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "REMOVE_ALL_MARKERS" 
(
    P_DOCID IN VARCHAR2,
    P_RC OUT SYS_REFCURSOR
) AS 
BEGIN
  DELETE FROM document_marker 
  WHERE P_DOCID = DOCID;
  
  OPEN P_RC FOR SELECT * FROM document_marker; 
END REMOVE_ALL_MARKERS;

/
--------------------------------------------------------
--  DDL for Procedure REMOVE_DOC
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "REMOVE_DOC" 
(
  P_DOCID IN VARCHAR2 
, P_RC OUT SYS_REFCURSOR 
) AS 
BEGIN
    DELETE FROM documents WHERE DOCID=P_DOCID;
    OPEN P_RC FOR SELECT * FROM documents;
END REMOVE_DOC;

/
--------------------------------------------------------
--  DDL for Procedure REMOVE_MARKER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "REMOVE_MARKER" 
(
  P_DOCID IN VARCHAR2 
, P_MARKERID IN NUMBER 
, P_RC OUT SYS_REFCURSOR
) AS 
BEGIN
  DELETE FROM document_marker 
  WHERE P_DOCID = DOCID AND p_markerid = MARKERID;
  
  OPEN P_RC FOR SELECT * FROM document_marker 
  WHERE P_DOCID = docid and p_markerid = markerid;
END REMOVE_MARKER;

/
--------------------------------------------------------
--  DDL for Procedure REMOVE_SHARE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "REMOVE_SHARE" 
(
  P_DOCID IN VARCHAR2 
, P_USERID IN VARCHAR2
, P_RC OUT SYS_REFCURSOR 
) AS 
BEGIN
  DELETE FROM SHARE_DOCS 
  WHERE P_DOCID = DOCID AND P_USERID = USERID;
  
    OPEN P_RC FOR SELECT * FROM share_docs;
END REMOVE_SHARE;

/
--------------------------------------------------------
--  DDL for Procedure REMOVE_USER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "REMOVE_USER" 
--MARKED USER AS REMOVED 
(
  P_USERID IN VARCHAR2 
, P_RC OUT SYS_REFCURSOR
) AS 
BEGIN
  UPDATE USERS
  SET ISACTIVE = 0
  WHERE USERID = p_userid;
  
  OPEN P_RC FOR SELECT* FROM USERS WHERE USERID=P_USERID;
  
END REMOVE_USER;

/
--------------------------------------------------------
--  Constraints for Table DOCUMENTS
--------------------------------------------------------

  ALTER TABLE "DOCUMENTS" MODIFY ("DOCID" NOT NULL ENABLE);
  ALTER TABLE "DOCUMENTS" ADD CONSTRAINT "DOCUMENTS_PK" PRIMARY KEY ("DOCID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table SHARE_DOCS
--------------------------------------------------------

  ALTER TABLE "SHARE_DOCS" MODIFY ("USERID" NOT NULL ENABLE);
  ALTER TABLE "SHARE_DOCS" MODIFY ("DOCID" NOT NULL ENABLE);
  ALTER TABLE "SHARE_DOCS" ADD CONSTRAINT "SHARE_DOCS_PK" PRIMARY KEY ("DOCID", "USERID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table DOCUMENT_MARKER
--------------------------------------------------------

  ALTER TABLE "DOCUMENT_MARKER" MODIFY ("DOCID" NOT NULL ENABLE);
  ALTER TABLE "DOCUMENT_MARKER" MODIFY ("MARKERID" NOT NULL ENABLE);
  ALTER TABLE "DOCUMENT_MARKER" ADD CONSTRAINT "DOCUMENT_MARKER_PK" PRIMARY KEY ("DOCID", "MARKERID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table USERS
--------------------------------------------------------

  ALTER TABLE "USERS" MODIFY ("USERID" NOT NULL ENABLE);
  ALTER TABLE "USERS" ADD CONSTRAINT "USERS_PK" PRIMARY KEY ("USERID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "USERS" MODIFY ("ISACTIVE" NOT NULL ENABLE);
  ALTER TABLE "USERS" MODIFY ("ISLOGIN" NOT NULL ENABLE);
--------------------------------------------------------
--  Ref Constraints for Table DOCUMENT_MARKER
--------------------------------------------------------

  ALTER TABLE "DOCUMENT_MARKER" ADD CONSTRAINT "DOCUMENT_MARKER_FK1" FOREIGN KEY ("DOCID")
	  REFERENCES "DOCUMENTS" ("DOCID") ENABLE;
  ALTER TABLE "DOCUMENT_MARKER" ADD CONSTRAINT "DOCUMENT_MARKER_FK2" FOREIGN KEY ("OWNER")
	  REFERENCES "USERS" ("USERID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table DOCUMENTS
--------------------------------------------------------

  ALTER TABLE "DOCUMENTS" ADD CONSTRAINT "DOCUMENTS_FK1" FOREIGN KEY ("OWNER")
	  REFERENCES "USERS" ("USERID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table SHARE_DOCS
--------------------------------------------------------

  ALTER TABLE "SHARE_DOCS" ADD CONSTRAINT "SHARE_DOCS_FK1" FOREIGN KEY ("DOCID")
	  REFERENCES "DOCUMENTS" ("DOCID") ENABLE;
  ALTER TABLE "SHARE_DOCS" ADD CONSTRAINT "SHARE_DOCS_FK2" FOREIGN KEY ("USERID")
	  REFERENCES "USERS" ("USERID") ENABLE;
