use stage
select *from ecole where RATT='13933U'
---les table de base donner
create table utl(
                   id_admin varchar(50) primary key,
				   passe_admin varchar(30))

insert into utl values('admin','admin')
select *from utl
go
---- table de cercle de la regione safi
create table cercle(idcer int primary key,
					nomcer varchar(20))
go
-----table de coumun
create table coumun(
                    CD_COM int primary key,
					LA_COM varchar(50),
					idcer int foreign key references cercle(idcer));

select c.LA_COM from coumun c , cercle cu where c.idcer=cu.idcer and nomcer='عبدة '

go
-------table de l ecole
create table ecole(
                   RATT varchar(50) primary key ,
				   NOM_ETABA varchar(50),
				   typee  varchar(20),
				   CD_COM int foreign key references coumun(CD_COM));
select c.NOM_ETABA from ecole c , coumun cu where c.CD_COM =cu.CD_COM  and cu.LA_COM='سيدي التيجي'
select RATT from ecole where NOM_ETABA='م/م الحمامشة'
select *from eleve
go				     
------table eleve
create table eleve(
                   codeEleve varchar(50) primary key,
				   nomEleve  varchar(50),
				   prenomEleve varchar(50),
				   nomElevefr varchar(50),
				   prenomElevefr varchar(50),
				   GenreAr   varchar(50),
				   Moyennecc float,
				   Moyenne_Exam float,
				   Moyenne_ses float,
				   distance int,
				   situation_fam text,
				   RATT varchar(50) foreign key references ecole(RATT));
				   select count(*) from eleve where GenreAr='ذكر' 
				   select *from eleve
-----------------------------------------------------------------------------------------------------------------------------------------------
create table colg(
                  
                  code_colg varchar(50)  ,
				  nom_colg varchar(50),
				   CD_COM int foreign key references coumun(CD_COM));

 select distinct nom_colg from colg

select*from colg
insert into colg values( '25206X','قاسم أمين',4310313);
insert into colg values( '25206X','قاسم أمين',4310315);
--------------
insert into colg values( '23701L','الرازي',4310317);
--------------------
insert into colg values( '23702M','ابن منظور',4310503);
----------
insert into colg values( '13997N','ابن رشد',4310305);
-------
insert into colg values( '13999R',' المنصور الدهبي',4310511);
-----------
insert into colg values( '18516A','عتمان ابن عفان',4310501);
-----------
insert into colg values( '19455W','تانوية الفاربي الإعدادية',4310509);
---------
insert into colg values( '19876D','إبن طفيل',4310709);
--------
insert into colg values( '19877E','إبن زيدون',4310311);
------
insert into colg values( '24576M','البحتري',4310303);
-----------
insert into colg values( '24577N','ابن حنبل',4310309);
-------------
insert into colg values( '24580S','هارون رشيد',4310711);
insert into colg values( '24580S','هارون رشيد',4310703);
--------
insert into colg values( '24581T','أحمد أمين',4310713);
-----------------
insert into colg values( '24132E','ابن زهر',4310301);
--------------------
insert into colg values( '24133F','مولاي ادريس الأول',4310707);
insert into colg values( '24133F','مولاي ادريس الأول',4310705);
-----------
insert into colg values( '25801U','السعدين',4310505);
insert into colg values( '26007T','الإمام الشافعي',4310507);
insert into colg values( '26337B','الكندي',4310701);
select*from colg
-------------------------------------------------------------------------------------------------------------------------------------------------
create table bourse(
                   codeEleve varchar(50) primary key ,

				   nomEleve  varchar(50),

				   prenomEleve varchar(50),

				   nomElevefr varchar(50),

				   prenomElevefr varchar(50),

				   GenreAr   varchar(50),

				   Moyennecc  varchar(50),
				   Moyenne_Exam  varchar(50),
				   Moyenne_ses  varchar(50),
				   distance int,
				   situation_fam  varchar(50),

				   nom_colg varchar(50));
				   
select*from bourse
delete  bourse

select codeEleve as'رمز التلميد',nomEleve as'الإسم العائلي',prenomEleve as'الإسم الشخصي',nomElevefr as 'Nom',prenomElevefr as 'Prenom',GenreAr as 'الجنس',Moyennecc as'معدل الدورة',Moyenne_Exam as'معدل إمتحان موحد',Moyenne_ses as 'معدل الأسدس',distance as 'المسافة',situation_fam as'الوضعية العائلية',nom_colg as'المؤسسة'
from bourse 
 order by Moyennecc desc


select*from bourse order by  moyennecc  desc


delete bourse;

insert into bourse(codeEleve,nomEleve,prenomEleve,nomElevefr,prenomElevefr,GenreAr,Moyennecc,Moyenne_Exam,Moyenne_ses,distance,situation_fam,nom_colg)values()				 
                    
				   







insert into cercle values(1,'عبدة ')
insert into cercle values(2,'حرارة')
insert into cercle values(3,'جزولة')
select *from coumun

insert into coumun values(4310713,'اتوابت',1)
insert into coumun values(4310301,'لمراسلة',1)
insert into coumun values(4310501,'مول البركي',2)
insert into coumun values(4310303,'سيدي التيجي',1)
insert into coumun values(4310503,'دار سي عيسى',2)
insert into coumun values(4310311,'لبخاتي',1)
insert into coumun values(4310703,'اولاد سلمان',3)
insert into coumun values(4310305,'بوكدرة',1)
insert into coumun values(4310307,'الشهدة',1)
insert into coumun values(4310309,'لحضر',1)
insert into coumun values(4310313,'لمصابح',1)
insert into coumun values(4310315,'الكرعاني',1)

insert into coumun values(4310317,'سيدي عيسى',1)
insert into coumun values(4310505,'اصعادلا',2)
insert into coumun values(4310507,'البدوزة',2)
insert into coumun values(4310509,'أيير',2)
insert into coumun values(4310511,'احرارة',2)
insert into coumun values(4310701,'خط أزكان',3)
insert into coumun values(4310705,'لعمامرة',3)
insert into coumun values(4310707,'نكا',3)
insert into coumun values(4310709,'الغيات',3)
insert into coumun values(4310711,'لمعاشات',3)

select * from eleve

select *from ecole
------ecole
insert into ecole values('13871B','م/م ضواحي','a',4310701)
insert into ecole values('13875F','م/م اولاد طلحة','a',4310701)
insert into ecole values('13878J','م/م اولاد شكر','a',4310701)
insert into ecole values('13879K','م/م لكبابر','a',4310701)
insert into ecole values('13879P','م/م رباط الشيخ','a',4310703)
insert into ecole values('13886T','م/م الحمامشة','a',4310703)
insert into ecole values('13887U','م/م اولاد عبد','a',4310703)
insert into ecole values('13887U','م/م الدعاكرة','a',4310703)
insert into ecole values('13907R','م/م عبد المومن','a',4310705)
insert into ecole values('13913Y','م/م ابن نفيس','a',4310705)
insert into ecole values('13915Z','م/م الدعيجات','a',4310705)
insert into ecole values('13919D','خميس نكة','a',4310707)
insert into ecole values('13922G','الرحاحلة','a',4310707)
insert into ecole values('13924J','م/م اولاد','a',4310707)
insert into ecole values('13926L','م/م الطهاهرة','a',4310707)
insert into ecole values('13837P','م/م النواصر','a',4310507)
insert into ecole values('13838R','م/م ايير','a',4310509)
insert into ecole values('13840T','م/م القواسمة','a',4310509)
insert into ecole values('13843W','مدرسة','a',4310509)
insert into ecole values('13845Y','م/م زاوية','a',4310509)
insert into ecole values('13848B','م/م العبابدة','a',4310509)
insert into ecole values('13851E','م/م اولاد','a',4310509)
insert into ecole values('26344J','مدرسة السعادة','a',4310509)
insert into ecole values('13853G','م/م حرارة','a',4310511)
insert into ecole values('13854H','م/م لعوينة','a',4310511)
insert into ecole values('13858M','م/م البوحيدات','a',4310511)
insert into ecole values('13859N','م/م الزيدانية','a',4310511)
insert into ecole values('13864U','م/م كاروش','a',4310511)
insert into ecole values('13867X','م/م الساحل','a',4310511)
insert into ecole values('19602F','م/م اكدال','a',4310511)
----delete from ecole  where RATT='13875F'
-----khawla
insert into ecole values('13929P','م/م اولاد عبة','a',4310707)
insert into ecole values('13957V','م/م الغيات','a',4310709)
insert into ecole values('13959X','م/م الحراتة','a',4310709)
insert into ecole values('13963B','م/م سيدي محمد','a',4310709)
insert into ecole values('13967F','م/م ابن تومرت','a',4310709)
insert into ecole values('13968G','م/م اولاد الحاج','a',4310709)
insert into ecole values('13974N','م/م السراحنة','a',4310709)
insert into ecole values('13975P','م/م العمورية','a',4310709)
insert into ecole values('13978T','م/م الهمامدة','a',4310709)
insert into ecole values('13933U','م/م المالح','a',43107011)
insert into ecole values('13937Y','م/م دار الحاجي','a',43107011)
insert into ecole values('13940B','م/م المعاشاة','a',43107011)
insert into ecole values('13942D','م/م سيدي','a',43107011)
insert into ecole values('13943E','م/م أهل الواد ','a',43107011)
insert into ecole values('13946H','م/م الرواحلة','a',43107013)
insert into ecole values('13947J','م/م الواد الغارق','a',43107013)
insert into ecole values('13952B','م/م براكة','a',43107013)
insert into ecole values('13602J','م/م الرزوكات','a',4310301)
insert into ecole values('13607P','م/م ابن حنبل','a',4310301)
insert into ecole values('13610T','م/م الصبابحة','a',4310301)
insert into ecole values('18548K','م/م المراسلة','a',4310301)
insert into ecole values('25808B','مدرسة النجاح','a',4310301)
insert into ecole values('13612V','م/م سيدي','a',4310303)
insert into ecole values('13613W','م/م لعبادلة','a',4310303)
insert into ecole values('13619C','م/م دار الزيدية','a',4310303)
insert into ecole values('13810K','م/م مول','a',4310501)
insert into ecole values('13824A','م/م اولاد الحاج','a',4310503)
insert into ecole values('13656T','م/م لعتامنة','a',4310311)
insert into ecole values('1389OX','م/م الحساسنة','a',4310703)
insert into ecole values('13820W','م/م  إبن الهيتم','a',4310501)
insert into ecole values('13625J','م/م اولاد سعادة','a',4310305)
insert into ecole values('13589V',' مدرسة محمد','a',4310305)
insert into ecole values('13622F','م/م الجرادات','a',4310305)
insert into ecole values('13629N','م/م اولادامحمد','a',4310305)
insert into ecole values('13633T','م/م الركاركة','a',4310305)



----------hicham
select *from ecole where RATT='13624H'
insert into ecole values('13871B','م/م ضواحي','a',4310701)
				   insert into ecole values('13875F','م/م اولاد طلحة','a',4310701) 
				   insert into ecole values('13878J','م/م اولاد شكر','a',4310701)
				    insert into ecole values('13879K','م/م لكبابر','a',4310701)
					 insert into ecole values('13883P','م/م رباط الشيخ','a',4310703)
					  insert into ecole values('13886T','م/م الحمامشة','a',4310703) 
					  insert into ecole values('13887U','م/م اولاد عبد','a',4310703)
					   insert into ecole values('13887U','م/م الدعاكرة','a',4310703)
					    insert into ecole values('13907R','م/م عبد المومن','a',4310705)
						 insert into ecole values('13913Y','م/م ابن نفيس','a',4310705) 
						 insert into ecole values('13915Z','م/م الدعيجات','a',4310705)
						  insert into ecole values('13919D','خميس نكة','a',4310707)
						   insert into ecole values('13922G','الرحاحلة','a',4310707) 
						   insert into ecole values('13924J','م/م اولاد','a',4310707) 
						   insert into ecole values('13926L','م/م الطهاهرة','a',4310707)
						    insert into ecole values('13837P','م/م النواصر','a',4310507) 
							insert into ecole values('13838R','م/م ايير','a',4310509)
							 insert into ecole values('13840T','م/م القواسمة','a',4310509)
							  insert into ecole values('13843W','مدرسة','a',4310509)
							   insert into ecole values('13845Y','م/م زاوية','a',4310509)
							    insert into ecole values('13848B','م/م العبابدة','a',4310509)
								 insert into ecole values('13851E','م/م اولاد','a',4310509)
								  insert into ecole values('26344J','مدرسة السعادة','a',4310509)
								   insert into ecole values('13853G','م/م حرارة','a',4310511)
								    insert into ecole values('13854H','م/م لعوينة','a',4310511) 
									insert into ecole values('13858M','م/م البوحيدات','a',4310511) 
									insert into ecole values('13859N','م/م الزيدانية','a',4310511) 
									insert into ecole values('13864U','م/م كاروش','a',4310511) 
									insert into ecole values('13867X','م/م الساحل','a',4310511) 
									insert into ecole values('19602F','م/م اكدال','a',4310511)
									insert into ecole values('13595P','م/م شهدة','a',4310307)
									insert into ecole values('13624H','م/م لوكاكدة','a',4310307)
									insert into ecole values('13634V','م/م بني دغوغ','a',4310307)
									insert into ecole values('13637X','م/م امشعرن','a',4310309)
									insert into ecole values('13640A','م/م سيدي','a',4310309)
									insert into ecole values('13643D','م/م السور','a',4310309)
									insert into ecole values('13647H','م/م أحد البخاتي','a',4310311)
									insert into ecole values('13652N','م/م اولاد فارقو','a',4310311)
									insert into ecole values('13656T','م/م العثامنة','a',4310311)
									insert into ecole values('13660X','م/م تازرورت','a',4310311)
									insert into ecole values('13666D','م/م أولا','a',4310313)
									insert into ecole values('13667E','م/م العرفان','a',4310313)
									insert into ecole values('13671J','م/م اولاد عبد','a',4310315)
									insert into ecole values('13674M','اولاد عامر','a',4310315)
									insert into ecole values('13676P','م/م اولاد','a',4310315)
									insert into ecole values('13680V','م/م الثلاتاء','a',4310317)
									insert into ecole values('13684Y','م/م بئراوزو','a',4310317)
									insert into ecole values('13814P','م/م الشعاعلة','a',4310501)
									insert into ecole values('13823Z','م/م دار القئد','a',4310503)
									insert into ecole values('13824A',' م/م اولاد الحاج','a',4310503)
									insert into ecole values('13826C','م/م أولا موسى','a',4310503)
									insert into ecole values('13897E','م/م الصعادلا','a',4310505)
									insert into ecole values('13901J','م/م الخوادرة','a',4310505)
									insert into ecole values('13902K','م م/ الموحدين','a',4310505)
									insert into ecole values('13904M','م/م الدار','a',4310505)
									insert into ecole values('13829F','م/م الدار','a',4310507)
									insert into ecole values('13834L','م/م الزلاقة','a',4310507)
									insert into ecole values('13833K','م/م اولاد','a',4310507)
-------------------------------------------------------------------------------------------------------------------------
select  top 1 * from eleve

select top 1 el.codeEleve as'رمز التلميد',el.nomEleve as'الإسم العائلي',el.prenomEleve as'الإسم الشخصي',el.nomElevefr as 'Nom',el.prenomElevefr as 'Prenom',el.GenreAr as 'الجنس',el.Moyennecc as'معدل الدورة',el.Moyenne_Exam as'معدل إمتحان موحد',el.Moyenne_ses as 'معدل الأسدس',el.distance as 'المسافة',el.situation_fam as'الوضعية العائلية',ec.NOM_ETABA as'المؤسسة'
from eleve el,cercle ce,coumun co,ecole ec 
where  el.RATT=ec.RATT and ec.CD_COM=co.CD_COM and co.idcer=ce.idcer order by el.Moyennecc desc

select  el.codeEleve as'رمز التلميد',el.nomEleve as'الإسم العائلي',el.prenomEleve as'الإسم الشخصي',el.nomElevefr as 'Nom',el.prenomElevefr as 'Prenom',el.GenreAr as 'الجنس',el.Moyennecc as'معدل الدورة',el.Moyenne_Exam as'معدل إمتحان موحد',el.Moyenne_ses as 'معدل الأسدس',el.distance as 'المسافة',el.situation_fam as'الوضعية العائلية',ec.NOM_ETABA as'المؤسسة'
from eleve el,ecole ec 
where  el.RATT=ec.RATT and  el.codeEleve='K110066613'
select*from eleve
select count(*) from eleve where GenreAr='أنثى'
select count(*) from eleve where GenreAr='ذكر'  

