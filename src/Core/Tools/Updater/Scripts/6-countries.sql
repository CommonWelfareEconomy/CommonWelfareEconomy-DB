﻿CREATE TABLE [dbo].[Country](
	[ISO] [char](2) NOT NULL,
	[Name] [varchar](80) NOT NULL,
	[PrintableName] [varchar](80) NOT NULL,
	[ISO3] [char](3) NULL,
	[NumCode] [smallint] NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[ISO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('AF','AFGHANISTAN','Afghanistan','AFG','004');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('AL','ALBANIA','Albania','ALB','008');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('DZ','ALGERIA','Algeria','DZA','012');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('AS','AMERICAN SAMOA','American Samoa','ASM','016');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('AD','ANDORRA','Andorra','AND','020');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('AO','ANGOLA','Angola','AGO','024');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('AI','ANGUILLA','Anguilla','AIA','660');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('AQ','ANTARCTICA','Antarctica',NULL,NULL);
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('AG','ANTIGUA AND BARBUDA','Antigua and Barbuda','ATG','028');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('AR','ARGENTINA','Argentina','ARG','032');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('AM','ARMENIA','Armenia','ARM','051');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('AW','ARUBA','Aruba','ABW','533');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('AU','AUSTRALIA','Australia','AUS','036');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('AT','AUSTRIA','Austria','AUT','040');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('AZ','AZERBAIJAN','Azerbaijan','AZE','031');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BS','BAHAMAS','Bahamas','BHS','044');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BH','BAHRAIN','Bahrain','BHR','048');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BD','BANGLADESH','Bangladesh','BGD','050');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BB','BARBADOS','Barbados','BRB','052');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BY','BELARUS','Belarus','BLR','112');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BE','BELGIUM','Belgium','BEL','056');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BZ','BELIZE','Belize','BLZ','084');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BJ','BENIN','Benin','BEN','204');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BM','BERMUDA','Bermuda','BMU','060');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BT','BHUTAN','Bhutan','BTN','064');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BO','BOLIVIA','Bolivia','BOL','068');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BA','BOSNIA AND HERZEGOVINA','Bosnia and Herzegovina','BIH','070');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BW','BOTSWANA','Botswana','BWA','072');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BV','BOUVET ISLAND','Bouvet Island',NULL,NULL);
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BR','BRAZIL','Brazil','BRA','076');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('IO','BRITISH INDIAN OCEAN TERRITORY','British Indian Ocean Territory',NULL,NULL);
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BN','BRUNEI DARUSSALAM','Brunei Darussalam','BRN','096');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BG','BULGARIA','Bulgaria','BGR','100');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BF','BURKINA FASO','Burkina Faso','BFA','854');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('BI','BURUNDI','Burundi','BDI','108');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('KH','CAMBODIA','Cambodia','KHM','116');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CM','CAMEROON','Cameroon','CMR','120');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CA','CANADA','Canada','CAN','124');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CV','CAPE VERDE','Cape Verde','CPV','132');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('KY','CAYMAN ISLANDS','Cayman Islands','CYM','136');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CF','CENTRAL AFRICAN REPUBLIC','Central African Republic','CAF','140');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('TD','CHAD','Chad','TCD','148');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CL','CHILE','Chile','CHL','152');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CN','CHINA','China','CHN','156');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CX','CHRISTMAS ISLAND','Christmas Island',NULL,NULL);
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CC','COCOS (KEELING) ISLANDS','Cocos (Keeling) Islands',NULL,NULL);
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CO','COLOMBIA','Colombia','COL','170');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('KM','COMOROS','Comoros','COM','174');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CG','CONGO','Congo','COG','178');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CD','CONGO, THE DEMOCRATIC REPUBLIC OF THE','Congo, the Democratic Republic of the','COD','180');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CK','COOK ISLANDS','Cook Islands','COK','184');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CR','COSTA RICA','Costa Rica','CRI','188');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CI','COTE D''IVOIRE','Cote D''Ivoire','CIV','384');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('HR','CROATIA','Croatia','HRV','191');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CU','CUBA','Cuba','CUB','192');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CY','CYPRUS','Cyprus','CYP','196');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CZ','CZECH REPUBLIC','Czech Republic','CZE','203');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('DK','DENMARK','Denmark','DNK','208');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('DJ','DJIBOUTI','Djibouti','DJI','262');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('DM','DOMINICA','Dominica','DMA','212');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('DO','DOMINICAN REPUBLIC','Dominican Republic','DOM','214');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('EC','ECUADOR','Ecuador','ECU','218');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('EG','EGYPT','Egypt','EGY','818');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SV','EL SALVADOR','El Salvador','SLV','222');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GQ','EQUATORIAL GUINEA','Equatorial Guinea','GNQ','226');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('ER','ERITREA','Eritrea','ERI','232');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('EE','ESTONIA','Estonia','EST','233');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('ET','ETHIOPIA','Ethiopia','ETH','231');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('FK','FALKLAND ISLANDS (MALVINAS)','Falkland Islands (Malvinas)','FLK','238');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('FO','FAROE ISLANDS','Faroe Islands','FRO','234');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('FJ','FIJI','Fiji','FJI','242');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('FI','FINLAND','Finland','FIN','246');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('FR','FRANCE','France','FRA','250');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GF','FRENCH GUIANA','French Guiana','GUF','254');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('PF','FRENCH POLYNESIA','French Polynesia','PYF','258');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('TF','FRENCH SOUTHERN TERRITORIES','French Southern Territories',NULL,NULL);
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GA','GABON','Gabon','GAB','266');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GM','GAMBIA','Gambia','GMB','270');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GE','GEORGIA','Georgia','GEO','268');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('DE','GERMANY','Germany','DEU','276');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GH','GHANA','Ghana','GHA','288');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GI','GIBRALTAR','Gibraltar','GIB','292');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GR','GREECE','Greece','GRC','300');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GL','GREENLAND','Greenland','GRL','304');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GD','GRENADA','Grenada','GRD','308');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GP','GUADELOUPE','Guadeloupe','GLP','312');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GU','GUAM','Guam','GUM','316');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GT','GUATEMALA','Guatemala','GTM','320');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GN','GUINEA','Guinea','GIN','324');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GW','GUINEA-BISSAU','Guinea-Bissau','GNB','624');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GY','GUYANA','Guyana','GUY','328');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('HT','HAITI','Haiti','HTI','332');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('HM','HEARD ISLAND AND MCDONALD ISLANDS','Heard Island and Mcdonald Islands',NULL,NULL);
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('VA','HOLY SEE (VATICAN CITY STATE)','Holy See (Vatican City State)','VAT','336');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('HN','HONDURAS','Honduras','HND','340');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('HK','HONG KONG','Hong Kong','HKG','344');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('HU','HUNGARY','Hungary','HUN','348');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('IS','ICELAND','Iceland','ISL','352');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('IN','INDIA','India','IND','356');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('ID','INDONESIA','Indonesia','IDN','360');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('IR','IRAN, ISLAMIC REPUBLIC OF','Iran, Islamic Republic of','IRN','364');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('IQ','IRAQ','Iraq','IRQ','368');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('IE','IRELAND','Ireland','IRL','372');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('IL','ISRAEL','Israel','ISR','376');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('IT','ITALY','Italy','ITA','380');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('JM','JAMAICA','Jamaica','JAM','388');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('JP','JAPAN','Japan','JPN','392');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('JO','JORDAN','Jordan','JOR','400');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('KZ','KAZAKHSTAN','Kazakhstan','KAZ','398');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('KE','KENYA','Kenya','KEN','404');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('KI','KIRIBATI','Kiribati','KIR','296');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('KP','KOREA, DEMOCRATIC PEOPLE''S REPUBLIC OF','Korea, Democratic People''s Republic of','PRK','408');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('KR','KOREA, REPUBLIC OF','Korea, Republic of','KOR','410');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('KW','KUWAIT','Kuwait','KWT','414');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('KG','KYRGYZSTAN','Kyrgyzstan','KGZ','417');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('LA','LAO PEOPLE''S DEMOCRATIC REPUBLIC','Lao People''s Democratic Republic','LAO','418');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('LV','LATVIA','Latvia','LVA','428');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('LB','LEBANON','Lebanon','LBN','422');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('LS','LESOTHO','Lesotho','LSO','426');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('LR','LIBERIA','Liberia','LBR','430');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('LY','LIBYAN ARAB JAMAHIRIYA','Libyan Arab Jamahiriya','LBY','434');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('LI','LIECHTENSTEIN','Liechtenstein','LIE','438');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('LT','LITHUANIA','Lithuania','LTU','440');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('LU','LUXEMBOURG','Luxembourg','LUX','442');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MO','MACAO','Macao','MAC','446');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MK','MACEDONIA, THE FORMER YUGOSLAV REPUBLIC OF','Macedonia, the Former Yugoslav Republic of','MKD','807');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MG','MADAGASCAR','Madagascar','MDG','450');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MW','MALAWI','Malawi','MWI','454');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MY','MALAYSIA','Malaysia','MYS','458');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MV','MALDIVES','Maldives','MDV','462');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('ML','MALI','Mali','MLI','466');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MT','MALTA','Malta','MLT','470');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MH','MARSHALL ISLANDS','Marshall Islands','MHL','584');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MQ','MARTINIQUE','Martinique','MTQ','474');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MR','MAURITANIA','Mauritania','MRT','478');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MU','MAURITIUS','Mauritius','MUS','480');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('YT','MAYOTTE','Mayotte',NULL,NULL);
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MX','MEXICO','Mexico','MEX','484');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('FM','MICRONESIA, FEDERATED STATES OF','Micronesia, Federated States of','FSM','583');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MD','MOLDOVA, REPUBLIC OF','Moldova, Republic of','MDA','498');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MC','MONACO','Monaco','MCO','492');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MN','MONGOLIA','Mongolia','MNG','496');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MS','MONTSERRAT','Montserrat','MSR','500');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MA','MOROCCO','Morocco','MAR','504');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MZ','MOZAMBIQUE','Mozambique','MOZ','508');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MM','MYANMAR','Myanmar','MMR','104');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('NA','NAMIBIA','Namibia','NAM','516');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('NR','NAURU','Nauru','NRU','520');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('NP','NEPAL','Nepal','NPL','524');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('NL','NETHERLANDS','Netherlands','NLD','528');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('AN','NETHERLANDS ANTILLES','Netherlands Antilles','ANT','530');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('NC','NEW CALEDONIA','New Caledonia','NCL','540');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('NZ','NEW ZEALAND','New Zealand','NZL','554');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('NI','NICARAGUA','Nicaragua','NIC','558');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('NE','NIGER','Niger','NER','562');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('NG','NIGERIA','Nigeria','NGA','566');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('NU','NIUE','Niue','NIU','570');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('NF','NORFOLK ISLAND','Norfolk Island','NFK','574');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('MP','NORTHERN MARIANA ISLANDS','Northern Mariana Islands','MNP','580');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('NO','NORWAY','Norway','NOR','578');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('OM','OMAN','Oman','OMN','512');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('PK','PAKISTAN','Pakistan','PAK','586');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('PW','PALAU','Palau','PLW','585');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('PS','PALESTINIAN TERRITORY, OCCUPIED','Palestinian Territory, Occupied',NULL,NULL);
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('PA','PANAMA','Panama','PAN','591');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('PG','PAPUA NEW GUINEA','Papua New Guinea','PNG','598');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('PY','PARAGUAY','Paraguay','PRY','600');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('PE','PERU','Peru','PER','604');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('PH','PHILIPPINES','Philippines','PHL','608');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('PN','PITCAIRN','Pitcairn','PCN','612');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('PL','POLAND','Poland','POL','616');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('PT','PORTUGAL','Portugal','PRT','620');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('PR','PUERTO RICO','Puerto Rico','PRI','630');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('QA','QATAR','Qatar','QAT','634');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('RE','REUNION','Reunion','REU','638');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('RO','ROMANIA','Romania','ROM','642');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('RU','RUSSIAN FEDERATION','Russian Federation','RUS','643');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('RW','RWANDA','Rwanda','RWA','646');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SH','SAINT HELENA','Saint Helena','SHN','654');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('KN','SAINT KITTS AND NEVIS','Saint Kitts and Nevis','KNA','659');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('LC','SAINT LUCIA','Saint Lucia','LCA','662');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('PM','SAINT PIERRE AND MIQUELON','Saint Pierre and Miquelon','SPM','666');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('VC','SAINT VINCENT AND THE GRENADINES','Saint Vincent and the Grenadines','VCT','670');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('WS','SAMOA','Samoa','WSM','882');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SM','SAN MARINO','San Marino','SMR','674');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('ST','SAO TOME AND PRINCIPE','Sao Tome and Principe','STP','678');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SA','SAUDI ARABIA','Saudi Arabia','SAU','682');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SN','SENEGAL','Senegal','SEN','686');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CS','SERBIA AND MONTENEGRO','Serbia and Montenegro',NULL,NULL);
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SC','SEYCHELLES','Seychelles','SYC','690');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SL','SIERRA LEONE','Sierra Leone','SLE','694');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SG','SINGAPORE','Singapore','SGP','702');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SK','SLOVAKIA','Slovakia','SVK','703');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SI','SLOVENIA','Slovenia','SVN','705');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SB','SOLOMON ISLANDS','Solomon Islands','SLB','090');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SO','SOMALIA','Somalia','SOM','706');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('ZA','SOUTH AFRICA','South Africa','ZAF','710');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GS','SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS','South Georgia and the South Sandwich Islands',NULL,NULL);
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('ES','SPAIN','Spain','ESP','724');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('LK','SRI LANKA','Sri Lanka','LKA','144');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SD','SUDAN','Sudan','SDN','736');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SR','SURINAME','Suriname','SUR','740');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SJ','SVALBARD AND JAN MAYEN','Svalbard and Jan Mayen','SJM','744');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SZ','SWAZILAND','Swaziland','SWZ','748');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SE','SWEDEN','Sweden','SWE','752');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('CH','SWITZERLAND','Switzerland','CHE','756');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('SY','SYRIAN ARAB REPUBLIC','Syrian Arab Republic','SYR','760');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('TW','TAIWAN, PROVINCE OF CHINA','Taiwan, Province of China','TWN','158');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('TJ','TAJIKISTAN','Tajikistan','TJK','762');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('TZ','TANZANIA, UNITED REPUBLIC OF','Tanzania, United Republic of','TZA','834');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('TH','THAILAND','Thailand','THA','764');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('TL','TIMOR-LESTE','Timor-Leste',NULL,NULL);
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('TG','TOGO','Togo','TGO','768');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('TK','TOKELAU','Tokelau','TKL','772');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('TO','TONGA','Tonga','TON','776');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('TT','TRINIDAD AND TOBAGO','Trinidad and Tobago','TTO','780');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('TN','TUNISIA','Tunisia','TUN','788');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('TR','TURKEY','Turkey','TUR','792');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('TM','TURKMENISTAN','Turkmenistan','TKM','795');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('TC','TURKS AND CAICOS ISLANDS','Turks and Caicos Islands','TCA','796');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('TV','TUVALU','Tuvalu','TUV','798');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('UG','UGANDA','Uganda','UGA','800');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('UA','UKRAINE','Ukraine','UKR','804');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('AE','UNITED ARAB EMIRATES','United Arab Emirates','ARE','784');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('GB','UNITED KINGDOM','United Kingdom','GBR','826');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('US','UNITED STATES','United States','USA','840');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('UM','UNITED STATES MINOR OUTLYING ISLANDS','United States Minor Outlying Islands',NULL,NULL);
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('UY','URUGUAY','Uruguay','URY','858');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('UZ','UZBEKISTAN','Uzbekistan','UZB','860');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('VU','VANUATU','Vanuatu','VUT','548');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('VE','VENEZUELA','Venezuela','VEN','862');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('VN','VIET NAM','Viet Nam','VNM','704');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('VG','VIRGIN ISLANDS, BRITISH','Virgin Islands, British','VGB','092');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('VI','VIRGIN ISLANDS, U.S.','Virgin Islands, U.s.','VIR','850');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('WF','WALLIS AND FUTUNA','Wallis and Futuna','WLF','876');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('EH','WESTERN SAHARA','Western Sahara','ESH','732');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('YE','YEMEN','Yemen','YEM','887');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('ZM','ZAMBIA','Zambia','ZMB','894');
INSERT INTO country (iso, name, printableName, iso3, numCode) VALUES ('ZW','ZIMBABWE','Zimbabwe','ZWE','716');