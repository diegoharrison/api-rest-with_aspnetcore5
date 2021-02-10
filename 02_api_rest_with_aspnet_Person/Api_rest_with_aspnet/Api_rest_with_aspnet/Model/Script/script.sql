CREATE TABLE `person` (
  `ID` bigint NOT NULL AUTO_INCREMENT,
  `ADDRESS` varchar(100) NOT NULL,
  `FIRST_NAME` varchar(80) NOT NULL,
  `GENDER` varchar(6) NOT NULL,
  `LAST_NAME` varchar(80) NOT NULL,
  PRIMARY KEY (`ID`)
)