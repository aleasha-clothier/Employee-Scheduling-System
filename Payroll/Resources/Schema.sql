-- Create table for employee data
CREATE TABLE `employeedata` (
  `emp_EmployeeID` INT NOT NULL,
  `emp_title` VARCHAR(50) DEFAULT NULL,
  `emp_FirstName` VARCHAR(30) NOT NULL,
  `emp_LastName` VARCHAR(45) NOT NULL,
  `emp_Email` VARCHAR(250) NOT NULL,
  `emp_AddressLine1` VARCHAR(250) NOT NULL,
  `emp_AddressLine2` VARCHAR(250) DEFAULT NULL,
  `emp_Town` VARCHAR(45) NOT NULL,
  `emp_City` VARCHAR(45) NOT NULL,
  `emp_County` VARCHAR(45) DEFAULT NULL,
  `emp_PostCode` VARCHAR(45) NOT NULL,
  `emp_phone` VARCHAR(11) DEFAULT NULL,
  `emp_TaxCode` VARCHAR(45) NOT NULL,
  `emp_HourlyRate` VARCHAR(45) NOT NULL,
  `emp_NINumber` VARCHAR(45) NOT NULL,
  `emp_OnPension` CHAR(1) NOT NULL,
  `emp_StudentLoanPlan` VARCHAR(45) DEFAULT NULL,
  `emp_SortCode` VARCHAR(45) NOT NULL,
  `emp_AccountNumber` VARCHAR(45) NOT NULL,
  `emp_Notes` VARCHAR(500) DEFAULT NULL,
  PRIMARY KEY (`emp_EmployeeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Create table for shift schedules
CREATE TABLE `schedule` (
  `sch_ScheduleID` INT NOT NULL AUTO_INCREMENT,
  `sch_EmployeeID` INT DEFAULT NULL,
  `sch_ShiftDate` DATE NOT NULL,
  `sch_TimeStart` TIME NOT NULL,
  `sch_TimeEnd` TIME NOT NULL,
  `sch_Task` VARCHAR(50) DEFAULT NULL,
  `sch_BreakMinutes` INT DEFAULT 60,
  `sch_TotalHours` DECIMAL(5,2) GENERATED ALWAYS AS (((TIMESTAMPDIFF(MINUTE, `sch_TimeStart`, `sch_TimeEnd`) / 60) - (`sch_BreakMinutes` / 60))) STORED,
  PRIMARY KEY (`sch_ScheduleID`),
  KEY `sch_EmployeeID` (`sch_EmployeeID`),
  CONSTRAINT `schedule_ibfk_1` FOREIGN KEY (`sch_EmployeeID`) REFERENCES `employeedata` (`emp_EmployeeID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Create table for absences
CREATE TABLE `absence` (
  `ab_EmployeeID` INT NOT NULL,
  `ab_AbsenceType` VARCHAR(50) DEFAULT NULL,
  `ab_StartDate` DATE NOT NULL,
  `ab_EndDate` DATE DEFAULT NULL,
  PRIMARY KEY (`ab_EmployeeID`, `ab_StartDate`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Create table for worked time summaries
CREATE TABLE `workedtime` (
  `wh_EmployeeID` INT NOT NULL,
  `wh_HoursWorked` DOUBLE DEFAULT NULL,
  `wh_EmergencyShiftsCovered` INT DEFAULT NULL,
  `wh_SickDays` INT DEFAULT NULL,
  `wh_HolidayTaken` INT DEFAULT NULL,
  `wh_HolidayRemaining` INT DEFAULT NULL,
  `wh_Holiday` INT DEFAULT NULL,
  `period_start` DATE DEFAULT NULL,
  `period_end` DATE DEFAULT NULL,
  PRIMARY KEY (`wh_EmployeeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Create table for employee payment records
CREATE TABLE `employeepaymentrecord` (
  `epr_EmployeeID` INT NOT NULL,
  `epr_FirstName` VARCHAR(45) NOT NULL,
  `epr_LastName` VARCHAR(45) NOT NULL,
  `epr_HoursWorked` DOUBLE NOT NULL,
  `epr_EmergencyShiftsCovered` INT DEFAULT NULL,
  `epr_SickDays` INT DEFAULT NULL,
  `epr_HolidayTaken` INT DEFAULT NULL,
  `epr_GrossPay` DOUBLE NOT NULL,
  `epr_TaxCode` INT NOT NULL,
  `epr_TaxDeducted` DOUBLE NOT NULL,
  `epr_NetPay` DOUBLE NOT NULL,
  `epr_PensionPaidByEmployee` DOUBLE NOT NULL,
  `epr_PensionPaidByEmployer` DOUBLE NOT NULL,
  `epr_StudenLoanRepayment` DOUBLE NOT NULL,
  `epr_FuelMoneyDeduction` DOUBLE NOT NULL,
  `epr_Bonus` DOUBLE NOT NULL,
  `epr_PayPeriod` INT NOT NULL,
  `epr_PayDate` DATE NOT NULL,
  `epr_HolidayRemaining` INT NOT NULL,
  `epr_NIPayment` DOUBLE NOT NULL,
  PRIMARY KEY (`epr_EmployeeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
